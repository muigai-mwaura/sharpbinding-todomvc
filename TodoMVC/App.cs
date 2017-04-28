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



        public static Attributes<INotifyPropertyChanged> __(
            AnyString className = null,
AnyString id = null,
AnyInt scrollLeft = null,
AnyInt scrollTop = null,
AnyString accessKey = null,
//AnyContentEditable contentEditable = null,
//AnyTextDirection dir = null,
AnyString lang = null,
AnyInt tabIndex = null,
AnyString title = null,
Action onCopy = null,
Action onCut = null,
Action onPaste = null,
Action<Event> onAbort = null,
Action<Event> onBlur = null,
Action onError = null,
Action<Event> onFocus = null,
Action<Event> onCancel = null,
Action<Event> onCanPlay = null,
Action<Event> onCanPlayThrough = null,
Action<Event> onChange = null,
Action<MouseEvent> onClick = null,
Action<Event> onClose = null,
Action<Event> onContextMenu = null,
Action<Event> onCueChange = null,
Action<MouseEvent> onDblClick = null,
Action<Event> onDrag = null,
Action<Event> onDragEnd = null,
Action<Event> onDragEnter = null,
Action<Event> onDragExit = null,
Action<Event> onDragLeave = null,
Action<Event> onDragOver = null,
Action<Event> onDragStart = null,
Action<Event> onDrop = null,
Action<Event> onDurationChange = null,
Action<Event> onEmptied = null,
Action<Event> onEnded = null,
Action<Event> onInput = null,
Action<Event> onInvalid = null,
Action<KeyboardEvent> onKeyDown = null,
Action<KeyboardEvent> onKeyPress = null,
Action<KeyboardEvent> onKeyUp = null,
Action<Event> onLoad = null,
Action<Event> onLoadedData = null,
Action<Event> onLoadedMetaData = null,
Action<Event> onLoadStart = null,
Action<MouseEvent> onMouseDown = null,
Action<MouseEvent> onMouseEnter = null,
Action<MouseEvent> onMouseLeave = null,
Action<MouseEvent> onMouseMove = null,
Action<MouseEvent> onMouseOut = null,
Action<MouseEvent> onMouseOver = null,
Action<MouseEvent> onMouseUp = null,
Action<MouseEvent> onMouseWheel = null,
Action<Event> onPause = null,
Action<Event> onPlay = null,
Action<Event> onPlaying = null,
Action<Event> onProgress = null,
Action<Event> onRateChange = null,
Action<Event> onReset = null,
Action<Event> onScroll = null,
Action<Event> onSeeked = null,
Action<Event> onSeeking = null,
Action<Event> onSelect = null,
Action<Event> onShow = null,
Action<Event> onSort = null,
Action<Event> onStalled = null,
Action<Event> onSubmit = null,
Action<Event> onSuspend = null,
Action<Event> onTimeUpdate = null,
Action<Event> onVolumeChange = null,
Action<Event> onWaiting = null,
Action<TouchEvent> onTouchStart = null,
Action<TouchEvent> onTouchEnd = null,
Action<TouchEvent> onTouchMove = null,
Action<TouchEvent> onTouchEnter = null,
Action<TouchEvent> onTouchLeave = null,
Action<TouchEvent> onTouchCancel = null,
AnyString charset = null,
AnyString coords = null,
AnyString download = null,
AnyString hash = null,
AnyString host = null,
AnyString hostname = null,
AnyString href = null,
AnyString hreflang = null,
AnyString media = null,
AnyString name = null,
AnyString password = null,
AnyString pathname = null,
AnyString port = null,
AnyString protocol = null,
AnyString rel = null,
AnyString rev = null,
AnyString search = null,
//AnyURLSearchParams searchParams = null,
AnyString shape = null,
AnyString target = null,
AnyString text = null,
AnyString type = null,
AnyString username = null,
AnyBool autoFocus = null,
AnyBool disabled = null,
AnyString formAction = null,
AnyString formEncType = null,
AnyString formMethod = null,
AnyBool formNoValidate = null,
AnyString formTarget = null,
AnyButtonType buttonType = null,
AnyString value = null,
AnyString acceptCharset = null,
AnyString action = null,
AnyAutoComplete autoComplete = null,
AnyString encoding = null,
AnyString enctype = null,
AnyString method = null,
AnyBool noValidate = null,
AnyString crossOrigin = null,
AnyInt imageHeight = null,
AnyBool isMap = null,
AnyString src = null,
AnyString srcSet = null,
AnyString useMap = null,
AnyInt imageWidth = null,
AnyString accept = null,
AnyString alt = null,
AnyBool autoSave = null,
AnyBool checked_ = null,
AnyBool defaultChecked = null,
AnyString defaultValue = null,
AnyBool indeterminate = null,
//AnyHTMLElement list = null,
AnyString max = null,
AnyInt maxLength = null,
AnyString min = null,
AnyBool multiple = null,
AnyString pattern = null,
AnyString placeholder = null,
AnyBool readOnly = null,
AnyBool required = null,
AnyString selectionDirection = null,
AnyInt selectionEnd = null,
AnyInt selectionStart = null,
AnyString step = null,
AnyInputType inputType = null,
AnyString htmlFor = null,
AnyBool allowFullScreen = null,
AnyString frameBorder = null,
AnyInt iFrameHeight = null,
AnyString longDesc = null,
AnyInt iFrameMarginHeight = null,
AnyInt iFrameMarginWidth = null,
AnyString scrolling = null,
AnyBool seamless = null,
AnyString srcDoc = null,
AnyInt iFrameWidth = null,
AnyString label = null,
AnyBool defaultSelected = null,
AnyBool disable = null,
AnyBool selected = null,
AnyInt selectedIndex = null,
AnyInt size = null,
AnyInt cols = null,
AnyInt rows = null,
AnyWrap wrap = null,
AnyInt span = null,
AnyInt colSpan = null,
AnyInt rowSpan = null,
AnyInt cellIndex = null,
AnyString abbr = null,
AnyInt canvasWidth = null,
AnyInt canvasHeight = null,
AnyHTMLTableCaptionElement caption = null,
AnyHTMLTableSectionElement tHead = null,
AnyHTMLTableSectionElement tFoot = null,
Observable<object> trigger = null,
Action<HTMLElement> onTrigger = null,
Observable<object> watch = null)
        {
            var a = new Attributes<INotifyPropertyChanged>();

            var na = NoNotification.Instance.ToObservable();

            if (className != null)
            {
                a.ClassName = className.IsFirst ? new Cell(() => className.First, na) : new Cell((Func<object>)(object)className.Second, watch);
            }
            if (id != null)
            {
                a.Id = id.IsFirst ? new Cell(() => id.First, na) : new Cell((Func<object>)(object)id.Second, watch);
            }
            if (canvasWidth != null)
            {
                a.CanvasWidth = canvasWidth.IsFirst ? new Cell(() => canvasWidth.First, na) : new Cell((Func<object>)(object)canvasWidth.Second, watch);
            }
            if (canvasHeight != null)
            {
                a.CanvasHeight = canvasHeight.IsFirst ? new Cell(() => canvasHeight.First, na) : new Cell((Func<object>)(object)canvasHeight.Second, watch);
            }
            if (scrollLeft != null)
            {
                a.ScrollLeft = scrollLeft.IsFirst ? new Cell(() => scrollLeft.First, na) : new Cell((Func<object>)(object)scrollLeft.Second, watch);
            }
            if (scrollTop != null)
            {
                a.ScrollTop = scrollTop.IsFirst ? new Cell(() => scrollTop.First, na) : new Cell((Func<object>)(object)scrollTop.Second, watch);
            }
            if (accessKey != null)
            {
                a.AccessKey = accessKey.IsFirst ? new Cell(() => accessKey.First, na) : new Cell((Func<object>)(object)accessKey.Second, watch);
            }
            //if (contentEditable != null)
            //{
            //    a.ContentEditable = contentEditable.IsFirst ? new Cell(() => contentEditable.First, na) : new Cell((Func<object>)(object)contentEditable.Second, watch);
            //}
            //if (dir != null)
            //{
            //    a.Dir = dir.IsFirst ? new Cell(() => dir.First, na) : new Cell((Func<object>)(object)dir.Second, watch);
            //}
            if (lang != null)
            {
                a.Lang = lang.IsFirst ? new Cell(() => lang.First, na) : new Cell((Func<object>)(object)lang.Second, watch);
            }
            if (tabIndex != null)
            {
                a.TabIndex = tabIndex.IsFirst ? new Cell(() => tabIndex.First, na) : new Cell((Func<object>)(object)tabIndex.Second, watch);
            }
            if (title != null)
            {
                a.Title = title.IsFirst ? new Cell(() => title.First, na) : new Cell((Func<object>)(object)title.Second, watch);
            }
            a.OnCopy = onCopy;
            a.OnCut = onCut;
            a.OnPaste = onPaste;
            a.OnAbort = onAbort;
            a.OnBlur = onBlur;
            a.OnError = onError;
            a.OnFocus = onFocus;
            a.OnCancel = onCancel;
            a.OnCanPlay = onCanPlay;
            a.OnCanPlayThrough = onCanPlayThrough;
            a.OnChange = onChange;
            a.OnClick = onClick;
            a.OnClose = onClose;
            a.OnContextMenu = onContextMenu;
            a.OnCueChange = onCueChange;
            a.OnDblClick = onDblClick;
            a.OnDrag = onDrag;
            a.OnDragEnd = onDragEnd;
            a.OnDragEnter = onDragEnter;
            a.OnDragExit = onDragExit;
            a.OnDragLeave = onDragLeave;
            a.OnDragOver = onDragOver;
            a.OnDragStart = onDragStart;
            a.OnDrop = onDrop;
            a.OnDurationChange = onDurationChange;
            a.OnEmptied = onEmptied;
            a.OnEnded = onEnded;
            a.OnInput = onInput;
            a.OnInvalid = onInvalid;
            a.OnKeyDown = onKeyDown;
            a.OnKeyPress = onKeyPress;
            a.OnKeyUp = onKeyUp;
            a.OnLoad = onLoad;
            a.OnLoadedData = onLoadedData;
            a.OnLoadedMetaData = onLoadedMetaData;
            a.OnLoadStart = onLoadStart;
            a.OnMouseDown = onMouseDown;
            a.OnMouseEnter = onMouseEnter;
            a.OnMouseLeave = onMouseLeave;
            a.OnMouseMove = onMouseMove;
            a.OnMouseOut = onMouseOut;
            a.OnMouseOver = onMouseOver;
            a.OnMouseUp = onMouseUp;
            a.OnMouseWheel = onMouseWheel;
            a.OnPause = onPause;
            a.OnPlay = onPlay;
            a.OnPlaying = onPlaying;
            a.OnProgress = onProgress;
            a.OnRateChange = onRateChange;
            a.OnReset = onReset;
            a.OnScroll = onScroll;
            a.OnSeeked = onSeeked;
            a.OnSeeking = onSeeking;
            a.OnSelect = onSelect;
            a.OnShow = onShow;
            a.OnSort = onSort;
            a.OnStalled = onStalled;
            a.OnSubmit = onSubmit;
            a.OnSuspend = onSuspend;
            a.OnTimeUpdate = onTimeUpdate;
            a.OnVolumeChange = onVolumeChange;
            a.OnWaiting = onWaiting;
            a.OnTouchStart = onTouchStart;
            a.OnTouchEnd = onTouchEnd;
            a.OnTouchMove = onTouchMove;
            a.OnTouchEnter = onTouchEnter;
            a.OnTouchLeave = onTouchLeave;
            a.OnTouchCancel = onTouchCancel;
            if (charset != null)
            {
                a.Charset = charset.IsFirst ? new Cell(() => charset.First, na) : new Cell((Func<object>)(object)charset.Second, watch);
            }
            if (coords != null)
            {
                a.Coords = coords.IsFirst ? new Cell(() => coords.First, na) : new Cell((Func<object>)(object)coords.Second, watch);
            }
            if (download != null)
            {
                a.Download = download.IsFirst ? new Cell(() => download.First, na) : new Cell((Func<object>)(object)download.Second, watch);
            }
            if (hash != null)
            {
                a.Hash = hash.IsFirst ? new Cell(() => hash.First, na) : new Cell((Func<object>)(object)hash.Second, watch);
            }
            if (host != null)
            {
                a.Host = host.IsFirst ? new Cell(() => host.First, na) : new Cell((Func<object>)(object)host.Second, watch);
            }
            if (hostname != null)
            {
                a.Hostname = hostname.IsFirst ? new Cell(() => hostname.First, na) : new Cell((Func<object>)(object)hostname.Second, watch);
            }
            if (href != null)
            {
                a.Href = href.IsFirst ? new Cell(() => href.First, na) : new Cell((Func<object>)(object)href.Second, watch);
            }
            if (hreflang != null)
            {
                a.Hreflang = hreflang.IsFirst ? new Cell(() => hreflang.First, na) : new Cell((Func<object>)(object)hreflang.Second, watch);
            }
            if (media != null)
            {
                a.Media = media.IsFirst ? new Cell(() => media.First, na) : new Cell((Func<object>)(object)media.Second, watch);
            }
            if (name != null)
            {
                a.Name = name.IsFirst ? new Cell(() => name.First, na) : new Cell((Func<object>)(object)name.Second, watch);
            }
            if (password != null)
            {
                a.Password = password.IsFirst ? new Cell(() => password.First, na) : new Cell((Func<object>)(object)password.Second, watch);
            }
            if (pathname != null)
            {
                a.Pathname = pathname.IsFirst ? new Cell(() => pathname.First, na) : new Cell((Func<object>)(object)pathname.Second, watch);
            }
            if (port != null)
            {
                a.Port = port.IsFirst ? new Cell(() => port.First, na) : new Cell((Func<object>)(object)port.Second, watch);
            }
            if (protocol != null)
            {
                a.Protocol = protocol.IsFirst ? new Cell(() => protocol.First, na) : new Cell((Func<object>)(object)protocol.Second, watch);
            }
            if (rel != null)
            {
                a.Rel = rel.IsFirst ? new Cell(() => rel.First, na) : new Cell((Func<object>)(object)rel.Second, watch);
            }
            if (rev != null)
            {
                a.Rev = rev.IsFirst ? new Cell(() => rev.First, na) : new Cell((Func<object>)(object)rev.Second, watch);
            }
            if (search != null)
            {
                a.Search = search.IsFirst ? new Cell(() => search.First, na) : new Cell((Func<object>)(object)search.Second, watch);
            }
            //if (searchParams != null)
            //{
            //    a.SearchParams = searchParams.IsFirst ? new Cell(() => searchParams.First, na) : new Cell((Func<object>)(object)searchParams.Second, watch);
            //}
            if (shape != null)
            {
                a.Shape = shape.IsFirst ? new Cell(() => shape.First, na) : new Cell((Func<object>)(object)shape.Second, watch);
            }
            if (target != null)
            {
                a.Target = target.IsFirst ? new Cell(() => target.First, na) : new Cell((Func<object>)(object)target.Second, watch);
            }
            if (text != null)
            {
                a.Text = text.IsFirst ? new Cell(() => text.First, na) : new Cell((Func<object>)(object)text.Second, watch);
            }
            if (type != null)
            {
                a.Type = type.IsFirst ? new Cell(() => type.First, na) : new Cell((Func<object>)(object)type.Second, watch);
            }
            if (username != null)
            {
                a.Username = username.IsFirst ? new Cell(() => username.First, na) : new Cell((Func<object>)(object)username.Second, watch);
            }
            if (autoFocus != null)
            {
                a.AutoFocus = autoFocus.IsFirst ? new Cell(() => autoFocus.First, na) : new Cell((Func<object>)(object)autoFocus.Second, watch);
            }
            if (disabled != null)
            {
                a.Disabled = disabled.IsFirst ? new Cell(() => disabled.First, na) : new Cell((Func<object>)(object)disabled.Second, watch);
            }
            if (formAction != null)
            {
                a.FormAction = formAction.IsFirst ? new Cell(() => formAction.First, na) : new Cell((Func<object>)(object)formAction.Second, watch);
            }
            if (formEncType != null)
            {
                a.FormEncType = formEncType.IsFirst ? new Cell(() => formEncType.First, na) : new Cell((Func<object>)(object)formEncType.Second, watch);
            }
            if (formMethod != null)
            {
                a.FormMethod = formMethod.IsFirst ? new Cell(() => formMethod.First, na) : new Cell((Func<object>)(object)formMethod.Second, watch);
            }
            if (formNoValidate != null)
            {
                a.FormNoValidate = formNoValidate.IsFirst ? new Cell(() => formNoValidate.First, na) : new Cell((Func<object>)(object)formNoValidate.Second, watch);
            }
            if (formTarget != null)
            {
                a.FormTarget = formTarget.IsFirst ? new Cell(() => formTarget.First, na) : new Cell((Func<object>)(object)formTarget.Second, watch);
            }
            if (buttonType != null)
            {
                a.ButtonType = buttonType.IsFirst ? new Cell(() => buttonType.First, na) : new Cell((Func<object>)(object)buttonType.Second, watch);
            }
            if (value != null)
            {
                a.Value = value.IsFirst ? new Cell(() => value.First, na) : new Cell((Func<object>)(object)value.Second, watch);
            }
            if (acceptCharset != null)
            {
                a.AcceptCharset = acceptCharset.IsFirst ? new Cell(() => acceptCharset.First, na) : new Cell((Func<object>)(object)acceptCharset.Second, watch);
            }
            if (action != null)
            {
                a.Action = action.IsFirst ? new Cell(() => action.First, na) : new Cell((Func<object>)(object)action.Second, watch);
            }
            if (autoComplete != null)
            {
                a.AutoComplete = autoComplete.IsFirst ? new Cell(() => autoComplete.First, na) : new Cell((Func<object>)(object)autoComplete.Second, watch);
            }
            if (encoding != null)
            {
                a.Encoding = encoding.IsFirst ? new Cell(() => encoding.First, na) : new Cell((Func<object>)(object)encoding.Second, watch);
            }
            if (enctype != null)
            {
                a.Enctype = enctype.IsFirst ? new Cell(() => enctype.First, na) : new Cell((Func<object>)(object)enctype.Second, watch);
            }
            if (method != null)
            {
                a.Method = method.IsFirst ? new Cell(() => method.First, na) : new Cell((Func<object>)(object)method.Second, watch);
            }
            if (noValidate != null)
            {
                a.NoValidate = noValidate.IsFirst ? new Cell(() => noValidate.First, na) : new Cell((Func<object>)(object)noValidate.Second, watch);
            }
            if (crossOrigin != null)
            {
                a.CrossOrigin = crossOrigin.IsFirst ? new Cell(() => crossOrigin.First, na) : new Cell((Func<object>)(object)crossOrigin.Second, watch);
            }
            if (imageHeight != null)
            {
                a.ImageHeight = imageHeight.IsFirst ? new Cell(() => imageHeight.First, na) : new Cell((Func<object>)(object)imageHeight.Second, watch);
            }
            if (isMap != null)
            {
                a.IsMap = isMap.IsFirst ? new Cell(() => isMap.First, na) : new Cell((Func<object>)(object)isMap.Second, watch);
            }
            if (src != null)
            {
                a.Src = src.IsFirst ? new Cell(() => src.First, na) : new Cell((Func<object>)(object)src.Second, watch);
            }
            if (srcSet != null)
            {
                a.SrcSet = srcSet.IsFirst ? new Cell(() => srcSet.First, na) : new Cell((Func<object>)(object)srcSet.Second, watch);
            }
            if (useMap != null)
            {
                a.UseMap = useMap.IsFirst ? new Cell(() => useMap.First, na) : new Cell((Func<object>)(object)useMap.Second, watch);
            }
            if (imageWidth != null)
            {
                a.ImageWidth = imageWidth.IsFirst ? new Cell(() => imageWidth.First, na) : new Cell((Func<object>)(object)imageWidth.Second, watch);
            }
            if (accept != null)
            {
                a.Accept = accept.IsFirst ? new Cell(() => accept.First, na) : new Cell((Func<object>)(object)accept.Second, watch);
            }
            if (alt != null)
            {
                a.Alt = alt.IsFirst ? new Cell(() => alt.First, na) : new Cell((Func<object>)(object)alt.Second, watch);
            }
            if (autoSave != null)
            {
                a.AutoSave = autoSave.IsFirst ? new Cell(() => autoSave.First, na) : new Cell((Func<object>)(object)autoSave.Second, watch);
            }
            if (checked_ != null)
            {
                a.Checked = checked_.IsFirst ? new Cell(() => checked_.First, na) : new Cell((Func<object>)(object)checked_.Second, watch);
            }
            if (defaultChecked != null)
            {
                a.DefaultChecked = defaultChecked.IsFirst ? new Cell(() => defaultChecked.First, na) : new Cell((Func<object>)(object)defaultChecked.Second, watch);
            }
            if (defaultValue != null)
            {
                a.DefaultValue = defaultValue.IsFirst ? new Cell(() => defaultValue.First, na) : new Cell((Func<object>)(object)defaultValue.Second, watch);
            }
            if (indeterminate != null)
            {
                a.Indeterminate = indeterminate.IsFirst ? new Cell(() => indeterminate.First, na) : new Cell((Func<object>)(object)indeterminate.Second, watch);
            }
            //if (list != null)
            //{
            //    a.List = list.IsFirst ? new Cell(() => list.First, na) : new Cell((Func<object>)(object)list.Second, watch);
            //}
            if (max != null)
            {
                a.Max = max.IsFirst ? new Cell(() => max.First, na) : new Cell((Func<object>)(object)max.Second, watch);
            }
            if (maxLength != null)
            {
                a.MaxLength = maxLength.IsFirst ? new Cell(() => maxLength.First, na) : new Cell((Func<object>)(object)maxLength.Second, watch);
            }
            if (min != null)
            {
                a.Min = min.IsFirst ? new Cell(() => min.First, na) : new Cell((Func<object>)(object)min.Second, watch);
            }
            if (multiple != null)
            {
                a.Multiple = multiple.IsFirst ? new Cell(() => multiple.First, na) : new Cell((Func<object>)(object)multiple.Second, watch);
            }
            if (pattern != null)
            {
                a.Pattern = pattern.IsFirst ? new Cell(() => pattern.First, na) : new Cell((Func<object>)(object)pattern.Second, watch);
            }
            if (placeholder != null)
            {
                a.Placeholder = placeholder.IsFirst ? new Cell(() => placeholder.First, na) : new Cell((Func<object>)(object)placeholder.Second, watch);
            }
            if (readOnly != null)
            {
                a.ReadOnly = readOnly.IsFirst ? new Cell(() => readOnly.First, na) : new Cell((Func<object>)(object)readOnly.Second, watch);
            }
            if (required != null)
            {
                a.Required = required.IsFirst ? new Cell(() => required.First, na) : new Cell((Func<object>)(object)required.Second, watch);
            }
            if (selectionDirection != null)
            {
                a.SelectionDirection = selectionDirection.IsFirst ? new Cell(() => selectionDirection.First, na) : new Cell((Func<object>)(object)selectionDirection.Second, watch);
            }
            if (selectionEnd != null)
            {
                a.SelectionEnd = selectionEnd.IsFirst ? new Cell(() => selectionEnd.First, na) : new Cell((Func<object>)(object)selectionEnd.Second, watch);
            }
            if (selectionStart != null)
            {
                a.SelectionStart = selectionStart.IsFirst ? new Cell(() => selectionStart.First, na) : new Cell((Func<object>)(object)selectionStart.Second, watch);
            }
            if (step != null)
            {
                a.Step = step.IsFirst ? new Cell(() => step.First, na) : new Cell((Func<object>)(object)step.Second, watch);
            }
            if (inputType != null)
            {
                a.InputType = inputType.IsFirst ? new Cell(() => inputType.First, na) : new Cell((Func<object>)(object)inputType.Second, watch);
            }
            if (htmlFor != null)
            {
                a.HtmlFor = htmlFor.IsFirst ? new Cell(() => htmlFor.First, na) : new Cell((Func<object>)(object)htmlFor.Second, watch);
            }
            if (allowFullScreen != null)
            {
                a.AllowFullScreen = allowFullScreen.IsFirst ? new Cell(() => allowFullScreen.First, na) : new Cell((Func<object>)(object)allowFullScreen.Second, watch);
            }
            if (frameBorder != null)
            {
                a.FrameBorder = frameBorder.IsFirst ? new Cell(() => frameBorder.First, na) : new Cell((Func<object>)(object)frameBorder.Second, watch);
            }
            if (iFrameHeight != null)
            {
                a.IFrameHeight = iFrameHeight.IsFirst ? new Cell(() => iFrameHeight.First, na) : new Cell((Func<object>)(object)iFrameHeight.Second, watch);
            }
            if (longDesc != null)
            {
                a.LongDesc = longDesc.IsFirst ? new Cell(() => longDesc.First, na) : new Cell((Func<object>)(object)longDesc.Second, watch);
            }
            if (iFrameMarginHeight != null)
            {
                a.IFrameMarginHeight = iFrameMarginHeight.IsFirst ? new Cell(() => iFrameMarginHeight.First, na) : new Cell((Func<object>)(object)iFrameMarginHeight.Second, watch);
            }
            if (iFrameMarginWidth != null)
            {
                a.IFrameMarginWidth = iFrameMarginWidth.IsFirst ? new Cell(() => iFrameMarginWidth.First, na) : new Cell((Func<object>)(object)iFrameMarginWidth.Second, watch);
            }
            if (scrolling != null)
            {
                a.Scrolling = scrolling.IsFirst ? new Cell(() => scrolling.First, na) : new Cell((Func<object>)(object)scrolling.Second, watch);
            }
            if (seamless != null)
            {
                a.Seamless = seamless.IsFirst ? new Cell(() => seamless.First, na) : new Cell((Func<object>)(object)seamless.Second, watch);
            }
            if (srcDoc != null)
            {
                a.SrcDoc = srcDoc.IsFirst ? new Cell(() => srcDoc.First, na) : new Cell((Func<object>)(object)srcDoc.Second, watch);
            }
            if (iFrameWidth != null)
            {
                a.IFrameWidth = iFrameWidth.IsFirst ? new Cell(() => iFrameWidth.First, na) : new Cell((Func<object>)(object)iFrameWidth.Second, watch);
            }
            if (label != null)
            {
                a.Label = label.IsFirst ? new Cell(() => label.First, na) : new Cell((Func<object>)(object)label.Second, watch);
            }
            if (defaultSelected != null)
            {
                a.DefaultSelected = defaultSelected.IsFirst ? new Cell(() => defaultSelected.First, na) : new Cell((Func<object>)(object)defaultSelected.Second, watch);
            }
            if (disable != null)
            {
                a.Disable = disable.IsFirst ? new Cell(() => disable.First, na) : new Cell((Func<object>)(object)disable.Second, watch);
            }
            if (selected != null)
            {
                a.Selected = selected.IsFirst ? new Cell(() => selected.First, na) : new Cell((Func<object>)(object)selected.Second, watch);
            }
            if (selectedIndex != null)
            {
                a.SelectedIndex = selectedIndex.IsFirst ? new Cell(() => selectedIndex.First, na) : new Cell((Func<object>)(object)selectedIndex.Second, watch);
            }
            if (size != null)
            {
                a.Size = size.IsFirst ? new Cell(() => size.First, na) : new Cell((Func<object>)(object)size.Second, watch);
            }
            if (cols != null)
            {
                a.Cols = cols.IsFirst ? new Cell(() => cols.First, na) : new Cell((Func<object>)(object)cols.Second, watch);
            }
            if (rows != null)
            {
                a.Rows = rows.IsFirst ? new Cell(() => rows.First, na) : new Cell((Func<object>)(object)rows.Second, watch);
            }
            if (wrap != null)
            {
                a.Wrap = wrap.IsFirst ? new Cell(() => wrap.First, na) : new Cell((Func<object>)(object)wrap.Second, watch);
            }
            if (span != null)
            {
                a.Span = span.IsFirst ? new Cell(() => span.First, na) : new Cell((Func<object>)(object)span.Second, watch);
            }
            if (colSpan != null)
            {
                a.ColSpan = colSpan.IsFirst ? new Cell(() => colSpan.First, na) : new Cell((Func<object>)(object)colSpan.Second, watch);
            }
            if (rowSpan != null)
            {
                a.RowSpan = rowSpan.IsFirst ? new Cell(() => rowSpan.First, na) : new Cell((Func<object>)(object)rowSpan.Second, watch);
            }
            if (cellIndex != null)
            {
                a.CellIndex = cellIndex.IsFirst ? new Cell(() => cellIndex.First, na) : new Cell((Func<object>)(object)cellIndex.Second, watch);
            }
            if (abbr != null)
            {
                a.Abbr = abbr.IsFirst ? new Cell(() => abbr.First, na) : new Cell((Func<object>)(object)abbr.Second, watch);
            }
            if (caption != null)
            {
                a.Caption = caption.IsFirst ? new Cell(() => caption.First, na) : new Cell((Func<object>)(object)caption.Second, watch);
            }
            if (tHead != null)
            {
                a.THead = tHead.IsFirst ? new Cell(() => tHead.First, na) : new Cell((Func<object>)(object)tHead.Second, watch);
            }
            if (tFoot != null)
            {
                a.TFoot = tFoot.IsFirst ? new Cell(() => tFoot.First, na) : new Cell((Func<object>)(object)tFoot.Second, watch);
            }

            a.Trigger = trigger;

            a.OnTrigger = onTrigger;

            return a;
        }

        public static Attributes<T> __<T>(
            AnyString className = null,
AnyString id = null,
AnyInt scrollLeft = null,
AnyInt scrollTop = null,
AnyString accessKey = null,
//AnyContentEditable contentEditable = null,
//AnyTextDirection dir = null,
AnyString lang = null,
AnyInt tabIndex = null,
AnyString title = null,
Action onCopy = null,
Action onCut = null,
Action onPaste = null,
Action<Event> onAbort = null,
Action<Event> onBlur = null,
Action onError = null,
Action<Event> onFocus = null,
Action<Event> onCancel = null,
Action<Event> onCanPlay = null,
Action<Event> onCanPlayThrough = null,
Action<Event> onChange = null,
Action<MouseEvent> onClick = null,
Action<Event> onClose = null,
Action<Event> onContextMenu = null,
Action<Event> onCueChange = null,
Action<MouseEvent> onDblClick = null,
Action<Event> onDrag = null,
Action<Event> onDragEnd = null,
Action<Event> onDragEnter = null,
Action<Event> onDragExit = null,
Action<Event> onDragLeave = null,
Action<Event> onDragOver = null,
Action<Event> onDragStart = null,
Action<Event> onDrop = null,
Action<Event> onDurationChange = null,
Action<Event> onEmptied = null,
Action<Event> onEnded = null,
Action<Event> onInput = null,
Action<Event> onInvalid = null,
Action<KeyboardEvent> onKeyDown = null,
Action<KeyboardEvent> onKeyPress = null,
Action<KeyboardEvent> onKeyUp = null,
Action<Event> onLoad = null,
Action<Event> onLoadedData = null,
Action<Event> onLoadedMetaData = null,
Action<Event> onLoadStart = null,
Action<MouseEvent> onMouseDown = null,
Action<MouseEvent> onMouseEnter = null,
Action<MouseEvent> onMouseLeave = null,
Action<MouseEvent> onMouseMove = null,
Action<MouseEvent> onMouseOut = null,
Action<MouseEvent> onMouseOver = null,
Action<MouseEvent> onMouseUp = null,
Action<MouseEvent> onMouseWheel = null,
Action<Event> onPause = null,
Action<Event> onPlay = null,
Action<Event> onPlaying = null,
Action<Event> onProgress = null,
Action<Event> onRateChange = null,
Action<Event> onReset = null,
Action<Event> onScroll = null,
Action<Event> onSeeked = null,
Action<Event> onSeeking = null,
Action<Event> onSelect = null,
Action<Event> onShow = null,
Action<Event> onSort = null,
Action<Event> onStalled = null,
Action<Event> onSubmit = null,
Action<Event> onSuspend = null,
Action<Event> onTimeUpdate = null,
Action<Event> onVolumeChange = null,
Action<Event> onWaiting = null,
Action<TouchEvent> onTouchStart = null,
Action<TouchEvent> onTouchEnd = null,
Action<TouchEvent> onTouchMove = null,
Action<TouchEvent> onTouchEnter = null,
Action<TouchEvent> onTouchLeave = null,
Action<TouchEvent> onTouchCancel = null,
AnyString charset = null,
AnyString coords = null,
AnyString download = null,
AnyString hash = null,
AnyString host = null,
AnyString hostname = null,
AnyString href = null,
AnyString hreflang = null,
AnyString media = null,
AnyString name = null,
AnyString password = null,
AnyString pathname = null,
AnyString port = null,
AnyString protocol = null,
AnyString rel = null,
AnyString rev = null,
AnyString search = null,
//AnyURLSearchParams searchParams = null,
AnyString shape = null,
AnyString target = null,
AnyString text = null,
AnyString type = null,
AnyString username = null,
AnyBool autoFocus = null,
AnyBool disabled = null,
AnyString formAction = null,
AnyString formEncType = null,
AnyString formMethod = null,
AnyBool formNoValidate = null,
AnyString formTarget = null,
AnyButtonType buttonType = null,
AnyString value = null,
AnyString acceptCharset = null,
AnyString action = null,
AnyAutoComplete autoComplete = null,
AnyString encoding = null,
AnyString enctype = null,
AnyString method = null,
AnyBool noValidate = null,
AnyString crossOrigin = null,
AnyInt imageHeight = null,
AnyBool isMap = null,
AnyString src = null,
AnyString srcSet = null,
AnyString useMap = null,
AnyInt imageWidth = null,
AnyString accept = null,
AnyString alt = null,
AnyBool autoSave = null,
AnyBool checked_ = null,
AnyBool defaultChecked = null,
AnyString defaultValue = null,
AnyBool indeterminate = null,
//AnyHTMLElement list = null,
AnyString max = null,
AnyInt maxLength = null,
AnyString min = null,
AnyBool multiple = null,
AnyString pattern = null,
AnyString placeholder = null,
AnyBool readOnly = null,
AnyBool required = null,
AnyString selectionDirection = null,
AnyInt selectionEnd = null,
AnyInt selectionStart = null,
AnyString step = null,
AnyInputType inputType = null,
AnyString htmlFor = null,
AnyBool allowFullScreen = null,
AnyString frameBorder = null,
AnyInt iFrameHeight = null,
AnyString longDesc = null,
AnyInt iFrameMarginHeight = null,
AnyInt iFrameMarginWidth = null,
AnyString scrolling = null,
AnyBool seamless = null,
AnyString srcDoc = null,
AnyInt iFrameWidth = null,
AnyString label = null,
AnyBool defaultSelected = null,
AnyBool disable = null,
AnyBool selected = null,
AnyInt selectedIndex = null,
AnyInt size = null,
AnyInt cols = null,
AnyInt rows = null,
AnyWrap wrap = null,
AnyInt span = null,
AnyInt colSpan = null,
AnyInt rowSpan = null,
AnyInt cellIndex = null,
AnyString abbr = null,
AnyHTMLTableCaptionElement caption = null,
AnyHTMLTableSectionElement tHead = null,
AnyHTMLTableSectionElement tFoot = null,
Observable<object> trigger = null,
Action<HTMLElement> onTrigger = null,
Observable<object> watch = null,
IEnumerable<T> items = null,
Func<T, HTMLElement> template = null)
        {
            var a = new Attributes<T>();

            a.Items = items;

            a.Template = template;

            var na = NoNotification.Instance.ToObservable();

            if (className != null)
            {
                a.ClassName = className.IsFirst ? new Cell(() => className.First, na) : new Cell((Func<object>)(object)className.Second, watch);
            }
            if (id != null)
            {
                a.Id = id.IsFirst ? new Cell(() => id.First, na) : new Cell((Func<object>)(object)id.Second, watch);
            }
            if (scrollLeft != null)
            {
                a.ScrollLeft = scrollLeft.IsFirst ? new Cell(() => scrollLeft.First, na) : new Cell((Func<object>)(object)scrollLeft.Second, watch);
            }
            if (scrollTop != null)
            {
                a.ScrollTop = scrollTop.IsFirst ? new Cell(() => scrollTop.First, na) : new Cell((Func<object>)(object)scrollTop.Second, watch);
            }
            if (accessKey != null)
            {
                a.AccessKey = accessKey.IsFirst ? new Cell(() => accessKey.First, na) : new Cell((Func<object>)(object)accessKey.Second, watch);
            }
            //if (contentEditable != null)
            //{
            //    a.ContentEditable = contentEditable.IsFirst ? new Cell(() => contentEditable.First, na) : new Cell((Func<object>)(object)contentEditable.Second, watch);
            //}
            //if (dir != null)
            //{
            //    a.Dir = dir.IsFirst ? new Cell(() => dir.First, na) : new Cell((Func<object>)(object)dir.Second, watch);
            //}
            if (lang != null)
            {
                a.Lang = lang.IsFirst ? new Cell(() => lang.First, na) : new Cell((Func<object>)(object)lang.Second, watch);
            }
            if (tabIndex != null)
            {
                a.TabIndex = tabIndex.IsFirst ? new Cell(() => tabIndex.First, na) : new Cell((Func<object>)(object)tabIndex.Second, watch);
            }
            if (title != null)
            {
                a.Title = title.IsFirst ? new Cell(() => title.First, na) : new Cell((Func<object>)(object)title.Second, watch);
            }
            a.OnCopy = onCopy;
            a.OnCut = onCut;
            a.OnPaste = onPaste;
            a.OnAbort = onAbort;
            a.OnBlur = onBlur;
            a.OnError = onError;
            a.OnFocus = onFocus;
            a.OnCancel = onCancel;
            a.OnCanPlay = onCanPlay;
            a.OnCanPlayThrough = onCanPlayThrough;
            a.OnChange = onChange;
            a.OnClick = onClick;
            a.OnClose = onClose;
            a.OnContextMenu = onContextMenu;
            a.OnCueChange = onCueChange;
            a.OnDblClick = onDblClick;
            a.OnDrag = onDrag;
            a.OnDragEnd = onDragEnd;
            a.OnDragEnter = onDragEnter;
            a.OnDragExit = onDragExit;
            a.OnDragLeave = onDragLeave;
            a.OnDragOver = onDragOver;
            a.OnDragStart = onDragStart;
            a.OnDrop = onDrop;
            a.OnDurationChange = onDurationChange;
            a.OnEmptied = onEmptied;
            a.OnEnded = onEnded;
            a.OnInput = onInput;
            a.OnInvalid = onInvalid;
            a.OnKeyDown = onKeyDown;
            a.OnKeyPress = onKeyPress;
            a.OnKeyUp = onKeyUp;
            a.OnLoad = onLoad;
            a.OnLoadedData = onLoadedData;
            a.OnLoadedMetaData = onLoadedMetaData;
            a.OnLoadStart = onLoadStart;
            a.OnMouseDown = onMouseDown;
            a.OnMouseEnter = onMouseEnter;
            a.OnMouseLeave = onMouseLeave;
            a.OnMouseMove = onMouseMove;
            a.OnMouseOut = onMouseOut;
            a.OnMouseOver = onMouseOver;
            a.OnMouseUp = onMouseUp;
            a.OnMouseWheel = onMouseWheel;
            a.OnPause = onPause;
            a.OnPlay = onPlay;
            a.OnPlaying = onPlaying;
            a.OnProgress = onProgress;
            a.OnRateChange = onRateChange;
            a.OnReset = onReset;
            a.OnScroll = onScroll;
            a.OnSeeked = onSeeked;
            a.OnSeeking = onSeeking;
            a.OnSelect = onSelect;
            a.OnShow = onShow;
            a.OnSort = onSort;
            a.OnStalled = onStalled;
            a.OnSubmit = onSubmit;
            a.OnSuspend = onSuspend;
            a.OnTimeUpdate = onTimeUpdate;
            a.OnVolumeChange = onVolumeChange;
            a.OnWaiting = onWaiting;
            a.OnTouchStart = onTouchStart;
            a.OnTouchEnd = onTouchEnd;
            a.OnTouchMove = onTouchMove;
            a.OnTouchEnter = onTouchEnter;
            a.OnTouchLeave = onTouchLeave;
            a.OnTouchCancel = onTouchCancel;
            if (charset != null)
            {
                a.Charset = charset.IsFirst ? new Cell(() => charset.First, na) : new Cell((Func<object>)(object)charset.Second, watch);
            }
            if (coords != null)
            {
                a.Coords = coords.IsFirst ? new Cell(() => coords.First, na) : new Cell((Func<object>)(object)coords.Second, watch);
            }
            if (download != null)
            {
                a.Download = download.IsFirst ? new Cell(() => download.First, na) : new Cell((Func<object>)(object)download.Second, watch);
            }
            if (hash != null)
            {
                a.Hash = hash.IsFirst ? new Cell(() => hash.First, na) : new Cell((Func<object>)(object)hash.Second, watch);
            }
            if (host != null)
            {
                a.Host = host.IsFirst ? new Cell(() => host.First, na) : new Cell((Func<object>)(object)host.Second, watch);
            }
            if (hostname != null)
            {
                a.Hostname = hostname.IsFirst ? new Cell(() => hostname.First, na) : new Cell((Func<object>)(object)hostname.Second, watch);
            }
            if (href != null)
            {
                a.Href = href.IsFirst ? new Cell(() => href.First, na) : new Cell((Func<object>)(object)href.Second, watch);
            }
            if (hreflang != null)
            {
                a.Hreflang = hreflang.IsFirst ? new Cell(() => hreflang.First, na) : new Cell((Func<object>)(object)hreflang.Second, watch);
            }
            if (media != null)
            {
                a.Media = media.IsFirst ? new Cell(() => media.First, na) : new Cell((Func<object>)(object)media.Second, watch);
            }
            if (name != null)
            {
                a.Name = name.IsFirst ? new Cell(() => name.First, na) : new Cell((Func<object>)(object)name.Second, watch);
            }
            if (password != null)
            {
                a.Password = password.IsFirst ? new Cell(() => password.First, na) : new Cell((Func<object>)(object)password.Second, watch);
            }
            if (pathname != null)
            {
                a.Pathname = pathname.IsFirst ? new Cell(() => pathname.First, na) : new Cell((Func<object>)(object)pathname.Second, watch);
            }
            if (port != null)
            {
                a.Port = port.IsFirst ? new Cell(() => port.First, na) : new Cell((Func<object>)(object)port.Second, watch);
            }
            if (protocol != null)
            {
                a.Protocol = protocol.IsFirst ? new Cell(() => protocol.First, na) : new Cell((Func<object>)(object)protocol.Second, watch);
            }
            if (rel != null)
            {
                a.Rel = rel.IsFirst ? new Cell(() => rel.First, na) : new Cell((Func<object>)(object)rel.Second, watch);
            }
            if (rev != null)
            {
                a.Rev = rev.IsFirst ? new Cell(() => rev.First, na) : new Cell((Func<object>)(object)rev.Second, watch);
            }
            if (search != null)
            {
                a.Search = search.IsFirst ? new Cell(() => search.First, na) : new Cell((Func<object>)(object)search.Second, watch);
            }
            //if (searchParams != null)
            //{
            //    a.SearchParams = searchParams.IsFirst ? new Cell(() => searchParams.First, na) : new Cell((Func<object>)(object)searchParams.Second, watch);
            //}
            if (shape != null)
            {
                a.Shape = shape.IsFirst ? new Cell(() => shape.First, na) : new Cell((Func<object>)(object)shape.Second, watch);
            }
            if (target != null)
            {
                a.Target = target.IsFirst ? new Cell(() => target.First, na) : new Cell((Func<object>)(object)target.Second, watch);
            }
            if (text != null)
            {
                a.Text = text.IsFirst ? new Cell(() => text.First, na) : new Cell((Func<object>)(object)text.Second, watch);
            }
            if (type != null)
            {
                a.Type = type.IsFirst ? new Cell(() => type.First, na) : new Cell((Func<object>)(object)type.Second, watch);
            }
            if (username != null)
            {
                a.Username = username.IsFirst ? new Cell(() => username.First, na) : new Cell((Func<object>)(object)username.Second, watch);
            }
            if (autoFocus != null)
            {
                a.AutoFocus = autoFocus.IsFirst ? new Cell(() => autoFocus.First, na) : new Cell((Func<object>)(object)autoFocus.Second, watch);
            }
            if (disabled != null)
            {
                a.Disabled = disabled.IsFirst ? new Cell(() => disabled.First, na) : new Cell((Func<object>)(object)disabled.Second, watch);
            }
            if (formAction != null)
            {
                a.FormAction = formAction.IsFirst ? new Cell(() => formAction.First, na) : new Cell((Func<object>)(object)formAction.Second, watch);
            }
            if (formEncType != null)
            {
                a.FormEncType = formEncType.IsFirst ? new Cell(() => formEncType.First, na) : new Cell((Func<object>)(object)formEncType.Second, watch);
            }
            if (formMethod != null)
            {
                a.FormMethod = formMethod.IsFirst ? new Cell(() => formMethod.First, na) : new Cell((Func<object>)(object)formMethod.Second, watch);
            }
            if (formNoValidate != null)
            {
                a.FormNoValidate = formNoValidate.IsFirst ? new Cell(() => formNoValidate.First, na) : new Cell((Func<object>)(object)formNoValidate.Second, watch);
            }
            if (formTarget != null)
            {
                a.FormTarget = formTarget.IsFirst ? new Cell(() => formTarget.First, na) : new Cell((Func<object>)(object)formTarget.Second, watch);
            }
            if (buttonType != null)
            {
                a.ButtonType = buttonType.IsFirst ? new Cell(() => buttonType.First, na) : new Cell((Func<object>)(object)buttonType.Second, watch);
            }
            if (value != null)
            {
                a.Value = value.IsFirst ? new Cell(() => value.First, na) : new Cell((Func<object>)(object)value.Second, watch);
            }
            if (acceptCharset != null)
            {
                a.AcceptCharset = acceptCharset.IsFirst ? new Cell(() => acceptCharset.First, na) : new Cell((Func<object>)(object)acceptCharset.Second, watch);
            }
            if (action != null)
            {
                a.Action = action.IsFirst ? new Cell(() => action.First, na) : new Cell((Func<object>)(object)action.Second, watch);
            }
            if (autoComplete != null)
            {
                a.AutoComplete = autoComplete.IsFirst ? new Cell(() => autoComplete.First, na) : new Cell((Func<object>)(object)autoComplete.Second, watch);
            }
            if (encoding != null)
            {
                a.Encoding = encoding.IsFirst ? new Cell(() => encoding.First, na) : new Cell((Func<object>)(object)encoding.Second, watch);
            }
            if (enctype != null)
            {
                a.Enctype = enctype.IsFirst ? new Cell(() => enctype.First, na) : new Cell((Func<object>)(object)enctype.Second, watch);
            }
            if (method != null)
            {
                a.Method = method.IsFirst ? new Cell(() => method.First, na) : new Cell((Func<object>)(object)method.Second, watch);
            }
            if (noValidate != null)
            {
                a.NoValidate = noValidate.IsFirst ? new Cell(() => noValidate.First, na) : new Cell((Func<object>)(object)noValidate.Second, watch);
            }
            if (crossOrigin != null)
            {
                a.CrossOrigin = crossOrigin.IsFirst ? new Cell(() => crossOrigin.First, na) : new Cell((Func<object>)(object)crossOrigin.Second, watch);
            }
            if (imageHeight != null)
            {
                a.ImageHeight = imageHeight.IsFirst ? new Cell(() => imageHeight.First, na) : new Cell((Func<object>)(object)imageHeight.Second, watch);
            }
            if (isMap != null)
            {
                a.IsMap = isMap.IsFirst ? new Cell(() => isMap.First, na) : new Cell((Func<object>)(object)isMap.Second, watch);
            }
            if (src != null)
            {
                a.Src = src.IsFirst ? new Cell(() => src.First, na) : new Cell((Func<object>)(object)src.Second, watch);
            }
            if (srcSet != null)
            {
                a.SrcSet = srcSet.IsFirst ? new Cell(() => srcSet.First, na) : new Cell((Func<object>)(object)srcSet.Second, watch);
            }
            if (useMap != null)
            {
                a.UseMap = useMap.IsFirst ? new Cell(() => useMap.First, na) : new Cell((Func<object>)(object)useMap.Second, watch);
            }
            if (imageWidth != null)
            {
                a.ImageWidth = imageWidth.IsFirst ? new Cell(() => imageWidth.First, na) : new Cell((Func<object>)(object)imageWidth.Second, watch);
            }
            if (accept != null)
            {
                a.Accept = accept.IsFirst ? new Cell(() => accept.First, na) : new Cell((Func<object>)(object)accept.Second, watch);
            }
            if (alt != null)
            {
                a.Alt = alt.IsFirst ? new Cell(() => alt.First, na) : new Cell((Func<object>)(object)alt.Second, watch);
            }
            if (autoSave != null)
            {
                a.AutoSave = autoSave.IsFirst ? new Cell(() => autoSave.First, na) : new Cell((Func<object>)(object)autoSave.Second, watch);
            }
            if (checked_ != null)
            {
                a.Checked = checked_.IsFirst ? new Cell(() => checked_.First, na) : new Cell((Func<object>)(object)checked_.Second, watch);
            }
            if (defaultChecked != null)
            {
                a.DefaultChecked = defaultChecked.IsFirst ? new Cell(() => defaultChecked.First, na) : new Cell((Func<object>)(object)defaultChecked.Second, watch);
            }
            if (defaultValue != null)
            {
                a.DefaultValue = defaultValue.IsFirst ? new Cell(() => defaultValue.First, na) : new Cell((Func<object>)(object)defaultValue.Second, watch);
            }
            if (indeterminate != null)
            {
                a.Indeterminate = indeterminate.IsFirst ? new Cell(() => indeterminate.First, na) : new Cell((Func<object>)(object)indeterminate.Second, watch);
            }
            //if (list != null)
            //{
            //    a.List = list.IsFirst ? new Cell(() => list.First, na) : new Cell((Func<object>)(object)list.Second, watch);
            //}
            if (max != null)
            {
                a.Max = max.IsFirst ? new Cell(() => max.First, na) : new Cell((Func<object>)(object)max.Second, watch);
            }
            if (maxLength != null)
            {
                a.MaxLength = maxLength.IsFirst ? new Cell(() => maxLength.First, na) : new Cell((Func<object>)(object)maxLength.Second, watch);
            }
            if (min != null)
            {
                a.Min = min.IsFirst ? new Cell(() => min.First, na) : new Cell((Func<object>)(object)min.Second, watch);
            }
            if (multiple != null)
            {
                a.Multiple = multiple.IsFirst ? new Cell(() => multiple.First, na) : new Cell((Func<object>)(object)multiple.Second, watch);
            }
            if (pattern != null)
            {
                a.Pattern = pattern.IsFirst ? new Cell(() => pattern.First, na) : new Cell((Func<object>)(object)pattern.Second, watch);
            }
            if (placeholder != null)
            {
                a.Placeholder = placeholder.IsFirst ? new Cell(() => placeholder.First, na) : new Cell((Func<object>)(object)placeholder.Second, watch);
            }
            if (readOnly != null)
            {
                a.ReadOnly = readOnly.IsFirst ? new Cell(() => readOnly.First, na) : new Cell((Func<object>)(object)readOnly.Second, watch);
            }
            if (required != null)
            {
                a.Required = required.IsFirst ? new Cell(() => required.First, na) : new Cell((Func<object>)(object)required.Second, watch);
            }
            if (selectionDirection != null)
            {
                a.SelectionDirection = selectionDirection.IsFirst ? new Cell(() => selectionDirection.First, na) : new Cell((Func<object>)(object)selectionDirection.Second, watch);
            }
            if (selectionEnd != null)
            {
                a.SelectionEnd = selectionEnd.IsFirst ? new Cell(() => selectionEnd.First, na) : new Cell((Func<object>)(object)selectionEnd.Second, watch);
            }
            if (selectionStart != null)
            {
                a.SelectionStart = selectionStart.IsFirst ? new Cell(() => selectionStart.First, na) : new Cell((Func<object>)(object)selectionStart.Second, watch);
            }
            if (step != null)
            {
                a.Step = step.IsFirst ? new Cell(() => step.First, na) : new Cell((Func<object>)(object)step.Second, watch);
            }
            if (inputType != null)
            {
                a.InputType = inputType.IsFirst ? new Cell(() => inputType.First, na) : new Cell((Func<object>)(object)inputType.Second, watch);
            }
            if (htmlFor != null)
            {
                a.HtmlFor = htmlFor.IsFirst ? new Cell(() => htmlFor.First, na) : new Cell((Func<object>)(object)htmlFor.Second, watch);
            }
            if (allowFullScreen != null)
            {
                a.AllowFullScreen = allowFullScreen.IsFirst ? new Cell(() => allowFullScreen.First, na) : new Cell((Func<object>)(object)allowFullScreen.Second, watch);
            }
            if (frameBorder != null)
            {
                a.FrameBorder = frameBorder.IsFirst ? new Cell(() => frameBorder.First, na) : new Cell((Func<object>)(object)frameBorder.Second, watch);
            }
            if (iFrameHeight != null)
            {
                a.IFrameHeight = iFrameHeight.IsFirst ? new Cell(() => iFrameHeight.First, na) : new Cell((Func<object>)(object)iFrameHeight.Second, watch);
            }
            if (longDesc != null)
            {
                a.LongDesc = longDesc.IsFirst ? new Cell(() => longDesc.First, na) : new Cell((Func<object>)(object)longDesc.Second, watch);
            }
            if (iFrameMarginHeight != null)
            {
                a.IFrameMarginHeight = iFrameMarginHeight.IsFirst ? new Cell(() => iFrameMarginHeight.First, na) : new Cell((Func<object>)(object)iFrameMarginHeight.Second, watch);
            }
            if (iFrameMarginWidth != null)
            {
                a.IFrameMarginWidth = iFrameMarginWidth.IsFirst ? new Cell(() => iFrameMarginWidth.First, na) : new Cell((Func<object>)(object)iFrameMarginWidth.Second, watch);
            }
            if (scrolling != null)
            {
                a.Scrolling = scrolling.IsFirst ? new Cell(() => scrolling.First, na) : new Cell((Func<object>)(object)scrolling.Second, watch);
            }
            if (seamless != null)
            {
                a.Seamless = seamless.IsFirst ? new Cell(() => seamless.First, na) : new Cell((Func<object>)(object)seamless.Second, watch);
            }
            if (srcDoc != null)
            {
                a.SrcDoc = srcDoc.IsFirst ? new Cell(() => srcDoc.First, na) : new Cell((Func<object>)(object)srcDoc.Second, watch);
            }
            if (iFrameWidth != null)
            {
                a.IFrameWidth = iFrameWidth.IsFirst ? new Cell(() => iFrameWidth.First, na) : new Cell((Func<object>)(object)iFrameWidth.Second, watch);
            }
            if (label != null)
            {
                a.Label = label.IsFirst ? new Cell(() => label.First, na) : new Cell((Func<object>)(object)label.Second, watch);
            }
            if (defaultSelected != null)
            {
                a.DefaultSelected = defaultSelected.IsFirst ? new Cell(() => defaultSelected.First, na) : new Cell((Func<object>)(object)defaultSelected.Second, watch);
            }
            if (disable != null)
            {
                a.Disable = disable.IsFirst ? new Cell(() => disable.First, na) : new Cell((Func<object>)(object)disable.Second, watch);
            }
            if (selected != null)
            {
                a.Selected = selected.IsFirst ? new Cell(() => selected.First, na) : new Cell((Func<object>)(object)selected.Second, watch);
            }
            if (selectedIndex != null)
            {
                a.SelectedIndex = selectedIndex.IsFirst ? new Cell(() => selectedIndex.First, na) : new Cell((Func<object>)(object)selectedIndex.Second, watch);
            }
            if (size != null)
            {
                a.Size = size.IsFirst ? new Cell(() => size.First, na) : new Cell((Func<object>)(object)size.Second, watch);
            }
            if (cols != null)
            {
                a.Cols = cols.IsFirst ? new Cell(() => cols.First, na) : new Cell((Func<object>)(object)cols.Second, watch);
            }
            if (rows != null)
            {
                a.Rows = rows.IsFirst ? new Cell(() => rows.First, na) : new Cell((Func<object>)(object)rows.Second, watch);
            }
            if (wrap != null)
            {
                a.Wrap = wrap.IsFirst ? new Cell(() => wrap.First, na) : new Cell((Func<object>)(object)wrap.Second, watch);
            }
            if (span != null)
            {
                a.Span = span.IsFirst ? new Cell(() => span.First, na) : new Cell((Func<object>)(object)span.Second, watch);
            }
            if (colSpan != null)
            {
                a.ColSpan = colSpan.IsFirst ? new Cell(() => colSpan.First, na) : new Cell((Func<object>)(object)colSpan.Second, watch);
            }
            if (rowSpan != null)
            {
                a.RowSpan = rowSpan.IsFirst ? new Cell(() => rowSpan.First, na) : new Cell((Func<object>)(object)rowSpan.Second, watch);
            }
            if (cellIndex != null)
            {
                a.CellIndex = cellIndex.IsFirst ? new Cell(() => cellIndex.First, na) : new Cell((Func<object>)(object)cellIndex.Second, watch);
            }
            if (abbr != null)
            {
                a.Abbr = abbr.IsFirst ? new Cell(() => abbr.First, na) : new Cell((Func<object>)(object)abbr.Second, watch);
            }
            if (caption != null)
            {
                a.Caption = caption.IsFirst ? new Cell(() => caption.First, na) : new Cell((Func<object>)(object)caption.Second, watch);
            }
            if (tHead != null)
            {
                a.THead = tHead.IsFirst ? new Cell(() => tHead.First, na) : new Cell((Func<object>)(object)tHead.Second, watch);
            }
            if (tFoot != null)
            {
                a.TFoot = tFoot.IsFirst ? new Cell(() => tFoot.First, na) : new Cell((Func<object>)(object)tFoot.Second, watch);
            }

            a.Trigger = trigger;

            a.OnTrigger = onTrigger;

            return a;
        }

    }
}