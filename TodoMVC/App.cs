using Bridge.Html5;
using SharpBindings;
using Rx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TodoMVC
{
    
    using static HtmlUtil;

    public class Todo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string description;
        public string Description
        {
            get { return description; }
            set
            {
                SetProperty(ref description, value);
            }
        }

        bool isCompleted;
        public bool IsCompleted
        {
            get { return isCompleted; }
            set
            {
                SetProperty(ref isCompleted, value);
            }
        }

        void SetProperty<T>(ref T target, T value, [CallerMemberName] string propertyName = "")
        {

            if (EqualityComparer<T>.Default.Equals(value, target))
            {
                return;
            }

            var oldValue = target;

            target = value;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName, value, oldValue));
        }

        // makes working with the dsl smoother
        public static implicit operator Observable<object>(Todo toDo)
        {
            return toDo.ToObservable();
        }
    }

    public class FilterUrl
    {
        public string Hash { get; set; }

        public Func<Todo, bool> IsHidden { get; set; }

        public string Text { get; set; }
    }

    public class App
    {

        const int ENTER_KEY = 13;

        const int ESCAPE_KEY = 27;

        public static void Main()
        {

            var todos = new ObservableCollection<Todo>();

            Func<int> activeCount = () => todos.Where(a => !a.IsCompleted).Count();

            var filters =
                new FilterUrl[]
                {
                    new FilterUrl { Text = "All",  Hash = "#!/", IsHidden = a => false },
                    new FilterUrl { Text = "Active", Hash = "#/active", IsHidden = a => a.IsCompleted },
                    new FilterUrl { Text = "Completed", Hash = "#/completed", IsHidden = a => !a.IsCompleted },
                };

            var currentFilter = new Var<FilterUrl>(filters[0]);            

            var url = GetRouting()
                             .Map(hash => filters.FirstOrDefault(a => hash.Contains(a.Hash)))
                             .Filter(a => a != null);

            url.Subscribe(a => currentFilter.Value = a);

            var urlTrigger = url.Map(a => (object)a);

            var header = HeaderSection(todos);

            Action<Todo> removeTodo = a => todos.Remove(a);
            
            var mainSection = MainSection(todos, 
                                          activeCount, 
                                          TodoTemplate(removeTodo, 
                                                       urlTrigger, 
                                                       currentFilter
                                                      )
                                         );

            var footer = FooterSection(todos, activeCount, filters, urlTrigger);

            var section =
                Section(__(className: "todoapp"),
                    header, 
                    mainSection, 
                    footer,
                    Footer(__(className: "info"),
                        P(__(text: "Double-click to edit a todo")),
                        P(__(text: "Written by "), A(__(text: "Muigai Mwaura", href: "https://github.com/muigai-mwaura"))),
                        P(__(text: "*Not* part of "), A(__(text: "TodoMVC", href: "http://todomvc.com")))
                    )
                );

            // Add the container to the page
            Document.Body.AppendChild(section);
        }

        static HTMLElement HeaderSection(ObservableCollection<Todo> todos)
        {
            var editingTodo = new Todo(); ;

            Action<KeyboardEvent> addTodo =
                e =>
                {

                    if (e.KeyCode != ENTER_KEY || string.IsNullOrWhiteSpace(editingTodo.Description))
                    {
                        return;
                    }

                    todos.Add(new Todo { Description = editingTodo.Description });

                    editingTodo.Description = string.Empty;
                };

            Func<string> description = () => editingTodo.Description;

            return
                Header(__(className: "header"),
                    H1(__(text: "todos")),
                    TextBox(__(className: "new-todo", 
                               placeholder: "What needs to be done?",
                               autoFocus: true,
                               onKeyDown: addTodo,
                               onKeyUp: e => editingTodo.Description = e.Value(),
                               value: description,
                               watch: editingTodo
                             )
                           )
                );
        }

        static Func<Todo, HTMLElement> TodoTemplate(Action<Todo> removeTodo, 
                                                    Observable<object> urlTrigger,
                                                    Var<FilterUrl> currentFilter)
        {

            return
                item =>
                {

                    var isEditMode = new Var<bool>(false);

                    Action<string> submit =
                        description =>
                        {
                            if (string.IsNullOrWhiteSpace(description))
                            {
                                removeTodo(item);
                            }
                            else
                            {
                                item.Description = description;
                            }

                            isEditMode.Value = false;
                        };

                    Action<KeyboardEvent> onKeyDown =
                        e =>
                        {
                            switch (e.KeyCode)
                            {
                                case ESCAPE_KEY:
                                    isEditMode.Value = false;
                                    break;
                                case ENTER_KEY:
                                    submit(e.Value());
                                    break;
                                default:
                                    break;
                            }
                        };

                    Action<Event> onBlur =
                        e =>
                        {
                            if (isEditMode.Value)
                            {
                                submit(e.Value());
                            }
                        };

                    Action<HTMLElement> onTriggerEdit =
                        e =>
                        {
                            if (isEditMode.Value)
                            {
                                e.SetValue(item.Description);

                                e.Focus();
                            }
                        };

                    Func<bool> itemIsDone = () => item.IsCompleted;

                    Func<string> itemDescription = () => item.Description;
                    
                    Func<string> itemClass =
                        () => currentFilter.Value.IsHidden(item) ? "hidden" :
                              item.IsCompleted ? "completed" :
                              isEditMode.Value ? "editing" : 
                              "";

                    var itemClassWatch = urlTrigger.Merge(item, isEditMode);

                    return
                        Li(__(className: itemClass,
                              watch: itemClassWatch),
                            Div(__(className: "view"),
                                CheckBox(__(className: "toggle",
                                            onClick: e => item.IsCompleted = e.IsChecked(),
                                            checked_: itemIsDone,
                                            watch: item)
                                        ),
                                Label(__(text: itemDescription,
                                         onDblClick: b => isEditMode.Value = true,
                                         watch: item)
                                       ),
                                Button(__(className: "destroy",
                                          onClick: b => removeTodo(item))
                                      )
                            ),
                            TextBox(__(className: "edit",
                                       autoFocus: false,
                                       trigger: isEditMode,
                                       onTrigger: onTriggerEdit,
                                       onKeyDown: onKeyDown,
                                       onBlur: onBlur
                                      )
                                  )
                            );
                };
        }

        static HTMLElement MainSection(ObservableCollection<Todo> todos,
                                       Func<int> activeCount, 
                                       Func<Todo, HTMLElement> todoTemplate)
        {

            Action<bool> toggleAll =
                isDone =>
                {
                    // bug if *toDos.ForEach(a => a.IsDone = isDone)* is used
                    for (var i = 0; i < todos.Count; i++)
                    {
                        todos[i].IsCompleted = isDone;
                    }
                };

            Func<bool> noActiveTodos = () => activeCount() == 0;

            Func<string> shouldShowMain = () => todos.Count == 0 ? "hidden" : "main";

            return
            Section(__(className: shouldShowMain,
                       watch: todos),
                    CheckBox(__(className: "toggle-all",
                                onClick: e => toggleAll(e.IsChecked()),
                                checked_: noActiveTodos,
                                watch: todos
                                )
                            ),
                    Label(__(text: "Mark all as complete", htmlFor: "toggle-all")),
                    Ul(__(className: "todo-list",
                          items: todos,
                          template: todoTemplate)
                      )
                );
        }

        static HTMLElement FooterSection(ObservableCollection<Todo> todos,
                                         Func<int> activeCount, 
                                         IEnumerable<FilterUrl> filters,
                                         Observable<object> urlTrigger)
        {
            Func<string> shouldShowFooter = () => todos.Count == 0 ? "hidden" : "footer";

            Func<string> numberActive = () => activeCount().ToString();

            Func<string> itemsLeft = () => activeCount() == 1 ? " item left" : " items left";

            Func<string> shouldShowClearButton = 
                () => todos.Where(a => a.IsCompleted).Count() == 0 ? "hidden" : "clear-completed";

            Action<MouseEvent> clearCompleted =
                b => todos.Where(a => a.IsCompleted)
                          .ToArray()
                          .ForEach(a => todos.Remove(a));

            Func<FilterUrl, Func<string>> selectedAnchor = f => () => Document.URL.Contains(f.Hash) ? "selected" : "";

            return
            Footer(__(className: shouldShowFooter,
                      watch: todos),
                Span(__(className: "todo-count"),
                    Strong(__(text: numberActive,
                              watch: todos)
                          ),
                    Span(__(text: itemsLeft,
                            watch: todos)
                        )
                     ),
                Ul(__(className: "filters",
                     items: filters,
                     template:
                         f => Li(null,
                                 A(__(className: selectedAnchor(f),
                                      text: f.Text,
                                      href: f.Hash,
                                      watch: urlTrigger)
                                  )
                              )
                      )
                  ),
                Button(__(className: shouldShowClearButton,
                          onClick: clearCompleted,
                          text: "Clear Completed",
                          watch: todos)
                      )
          );
        }

    }
}