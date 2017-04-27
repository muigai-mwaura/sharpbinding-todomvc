using Bridge;
using Bridge.Html5;
using Bridge.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using Rx;

namespace HtmlUtils
{
    public static class HtmlUtil
    {

        public static void AppendChildElements(this HTMLElement parent, IEnumerable<Node> children)
        {
            children.ForEach(a => parent.AppendChild(a));
        }

        public static void Clear(this HTMLElement element)
        {
            while (element.LastChild != null)
            {
                element.RemoveChild(element.LastChild);
            }
        }

        static T InitElement<T>(T element, IAttributes init, params Node[] children)
            where T : HTMLElement
        {
            init?.InitElement(element);

            element.AppendChildElements(children);

            return element;
        }

        public static Text Text(string text)
        {
            return Document.CreateTextNode(text);
        }

        public static HTMLDivElement Div(IAttributes init, params Node[] children)
        {
            return InitElement(new HTMLDivElement(), init, children);
        }

        public static HTMLSpanElement Span(IAttributes init, params Node[] children)
        {
            return InitElement(new HTMLSpanElement(), init, children);
        }

        public static HTMLParagraphElement P(IAttributes init, params Node[] children)
        {
            return InitElement(new HTMLParagraphElement(), init, children);
        }

        public static HTMLPreElement Pre(IAttributes init, params Node[] children)
        {
            return InitElement(new HTMLPreElement(), init, children);
        }

        public static HTMLElement Strong(IAttributes init, params Node[] children)
        {
            return InitElement(new HTMLElement("strong"), init, children);
        }

        public static HTMLBRElement Br(IAttributes init)
        {
            return InitElement(new HTMLBRElement(), init);
        }

        public static HTMLOListElement Ol(IAttributes init, params HTMLLIElement[] children)
        {
            var a = new HTMLOListElement();

            //init.InitOListElement(a);

            a.AppendChildElements(children);

            return a;
        }

        public static HTMLUListElement Ul(IAttributes init, params HTMLLIElement[] children)
        {
            return InitElement(new HTMLUListElement(), init, children);
        }

        public static HTMLLIElement Li(IAttributes init, params Node[] children)
        {
            return InitElement(new HTMLLIElement(), init, children);
        }


        public static HTMLElement Main(IAttributes init, params Node[] children)
        {
            return InitElement(new HTMLElement("main"), init, children);
        }

        public static HTMLElement Header(IAttributes init, params Node[] children)
        {
            return InitElement(new HTMLElement("header"), init, children);
        }

        public static HTMLElement Footer(IAttributes init, params Node[] children)
        {
            return InitElement(new HTMLElement("footer"), init, children);
        }

        public static HTMLElement Section(IAttributes init, params Node[] children)
        {
            return InitElement(new HTMLElement("section"), init, children);
        }

        public static HTMLElement Nav(IAttributes init, params Node[] children)
        {
            return InitElement(new HTMLElement("nav"), init, children);
        }

        public static HTMLHRElement HR(IAttributes init)
        {
            return InitElement(new HTMLHRElement(), init);
        }

        public static HTMLAnchorElement A(IAttributes init, params Node[] children)
        {
            var a = new HTMLAnchorElement();

            init.InitAnchorElement(a);

            a.AppendChildElements(children);

            return a;
        }

        public static HTMLImageElement Image(IAttributes init)
        {
            var a = new HTMLImageElement();

            init.InitImageElement(a);

            return a;
        }

        public static HTMLCanvasElement Canvas(IAttributes init)
        {
            var a = new HTMLCanvasElement();

            init.InitCanvasElement(a);

            return a;
        }

        static HTMLHeadingElement H(IAttributes init, HeadingType type, params Node[] children)
        {
            var h = new HTMLHeadingElement(type);

            init.InitElement(h);

            h.AppendChildElements(children);

            return h;
        }

        public static HTMLHeadingElement H1(IAttributes a, params Node[] children)
        {
            return H(a, HeadingType.H1, children);
        }

        public static HTMLHeadingElement H2(IAttributes a, params Node[] children)
        {
            return H(a, HeadingType.H2, children);
        }

        public static HTMLHeadingElement H3(IAttributes a, params Node[] children)
        {
            return H(a, HeadingType.H3, children);
        }

        public static HTMLHeadingElement H4(IAttributes a, params Node[] children)
        {
            return H(a, HeadingType.H4, children);
        }

        public static HTMLHeadingElement H5(IAttributes a, params Node[] children)
        {
            return H(a, HeadingType.H5, children);
        }

        public static HTMLHeadingElement H6(IAttributes a, params Node[] children)
        {
            return H(a, HeadingType.H6, children);
        }

        public static HTMLFormElement Form(IAttributes init, params Node[] children)
        {
            var f = new HTMLFormElement();

            init.InitFormElement(f);

            f.AppendChildElements(children);

            return f;
        }

        public static HTMLFieldSetElement FieldSet(IAttributes init, params Node[] children)
        {
            var f = new HTMLFieldSetElement();

            init.InitFieldSetElement(f);

            f.AppendChildElements(children);

            return f;
        }

        public static HTMLOptGroupElement OptGroup(IAttributes init, params HTMLOptionElement[] children)
        {
            var f = new HTMLOptGroupElement();

            init.InitOptGroupElement(f);

            f.AppendChildElements(children);

            return f;
        }

        public static HTMLOptionElement Option(IAttributes init)
        {

            var f = new HTMLOptionElement();

            init.InitOptionElement(f);

            return f;
        }

        public static HTMLLegendElement Legend(IAttributes init, params Node[] children)
        {
            return InitElement(new HTMLLegendElement(), init, children);

        }

        public static HTMLButtonElement Button(IAttributes init, params Node[] children)
        {
            var f = new HTMLButtonElement();

            init.InitButtonElement(f);

            f.AppendChildElements(children);

            return f;
        }

        public static HTMLSelectElement Select(IAttributes init, params HTMLOptionElement[] children)
        {
            var f = new HTMLSelectElement();

            init.InitSelectElement(f);

            f.AppendChildElements(children);

            return f;
        }

        public static HTMLDataListElement DataList(IAttributes init, params HTMLOptionElement[] children)
        {
            var f = new HTMLDataListElement();

            f.AppendChildElements(children);

            return f;
        }

        public static HTMLInputElement TextBox(IAttributes init)
        {

            var f = new HTMLInputElement();

            init.InitInputElement(f);

            return f;
        }

        public static HTMLInputElement CheckBox(IAttributes init)
        {

            var input = new HTMLInputElement();

            input.Type = InputType.Checkbox;

            init.InitInputElement(input);

            return input;
        }

        public static HTMLInputElement RadioButton(IAttributes init)
        {

            var input = new HTMLInputElement();

            input.Type = InputType.Radio;

            init.InitInputElement(input);

            return input;
        }

        public static HTMLTextAreaElement TextArea(IAttributes init)
        {
            var a = new HTMLTextAreaElement();

            init.InitTextAreaElement(a);

            return a;
        }

        public static HTMLLabelElement Label(IAttributes init)
        {
            var label = new HTMLLabelElement();

            init.InitLabelElement(label);

            return label;
        }

        public static HTMLTableElement Table(IAttributes init, params Node[] children)
        {
            var table = new HTMLTableElement();

            init.InitTableElement(table);

            table.AppendChildElements(children);

            return table;
        }

        public static HTMLTableCaptionElement Caption(IAttributes init, params Node[] children)
        {
            return InitElement(new HTMLTableCaptionElement(), init, children);
        }

        public static HTMLTableSectionElement THeader(IAttributes init, params HTMLTableRowElement[] children)
        {
            return InitElement(new HTMLTableSectionElement(), init, children);
        }

        public static HTMLTableSectionElement TBody(IAttributes init, params HTMLTableRowElement[] children)
        {
            return InitElement(new HTMLTableSectionElement(), init, children);
        }

        public static HTMLTableSectionElement TFooter(IAttributes init, params HTMLTableRowElement[] children)
        {
            return InitElement(new HTMLTableSectionElement(), init, children);
        }

        public static HTMLTableRowElement TRow(IAttributes init, params HTMLTableDataCellElement[] children)
        {
            return InitElement(new HTMLTableRowElement(), init, children);
        }

        public static HTMLTableRowElement TRow(IAttributes init, params HTMLTableHeaderCellElement[] children)
        {
            return InitElement(new HTMLTableRowElement(), init, children);
        }

        public static HTMLTableDataCellElement Td(IAttributes init, params Node[] children)
        {
            var f = new HTMLTableDataCellElement();

            init.InitTableDataCellElement(f);

            f.AppendChildElements(children);

            return f;
        }

        public static HTMLTableHeaderCellElement Th(IAttributes init, params Node[] children)
        {
            var f = new HTMLTableHeaderCellElement();

            init.InitTableHeaderCellElement(f);

            f.AppendChildElements(children);

            return f;
        }

        public static HTMLIFrameElement IFrame(IAttributes init, params Node[] children)
        {
            var a = new HTMLIFrameElement();

            init.InitIFrameElement(a);

            a.AppendChildElements(children);

            return a;
        }

        public static Observable<object> ToObservable(this INotifyPropertyChanged source)
        {
            var s = Subject.Create<object>();

            var obj = new object();

            // need to provide for unsubscription
            source.PropertyChanged += (_, __) => s.Next(obj);

            return s.AsObservable();
        }

        //Cannot convert lambda expression to type 'Any*' because it is not a delegate type
        //public extern static Func<T> fun<T>(object a);

        public static bool IsChecked(this Event e)
        {

            return ((HTMLInputElement)e.Target).Checked;
        }

        public static string Value(this Event e)
        {
            return ((HTMLInputElement)e.Target).Value;
        }

        public static void SetValue(this HTMLElement e, string value)
        {
            ((HTMLInputElement)e).Value = value;
        }

        public static Observable<string> GetRouting()
        {
            var routing = Subject.Create<string>();

            Window.OnHashChange += _ => routing.Next(Window.Location.Hash);

            return routing.StartWith(Window.Location.Hash);
        }
    }

    public sealed class ObservableCollection<T> : IEnumerable<T>, ICollection<T>, INotifyPropertyChanged
    {

        readonly List<T> list = new List<T>();

        readonly Subject<T[]> added = Subject.Create<T[]>();

        readonly Subject<T[]> removed = Subject.Create<T[]>();

        readonly Subject<Tuple<T, T>> replaced = Subject.Create<Tuple<T, T>>();

        public event PropertyChangedEventHandler PropertyChanged;

        public int Count
        {
            get
            {
                return list.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public T this[int index]
        {
            get
            {
                return list[index];
            }

            set
            {
                var old = list[index];

                list[index] = value;

                replaced.Next(Tuple.Create(old, value));

                UnSubscribe(old);

                Subscribe(value);

                RaisePropertyChanged();
            }
        }

        public void Add(T item)
        {
            list.Add(item);

            added.Next(new[] { item });

            Subscribe(item);

            RaisePropertyChanged();
        }

        public bool Remove(T item)
        {
            var isRemoved = list.Remove(item);

            if (!isRemoved)
            {
                return false;
            }

            removed.Next(new[] { item });

            UnSubscribe(item);

            RaisePropertyChanged();

            return isRemoved;
        }

        public void Clear()
        {
            var items = list.ToArray();

            list.Clear();

            removed.Next(items);

            items.ForEach(i => UnSubscribe(i));

            RaisePropertyChanged();
        }

        void Subscribe(T item)
        {
            var a = (item as INotifyPropertyChanged);

            if (a != null)
            {
                a.PropertyChanged += ItemChanged;
            }
        }

        void UnSubscribe(T item)
        {
            var a = (item as INotifyPropertyChanged);

            if (a != null)
            {
                a.PropertyChanged -= ItemChanged;
            }
        }

        void ItemChanged(object sender, PropertyChangedEventArgs e)
        {
            RaisePropertyChanged();
        }

        void RaisePropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null, null));
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public Observable<T[]> Added
        {
            get
            {
                return added.AsObservable();
            }
        }

        public Observable<T[]> Removed
        {
            get
            {
                return removed.AsObservable();
            }
        }

        public static implicit operator Observable<object>(ObservableCollection<T> collection)
        {
            return collection.ToObservable();
        }
    }

    public sealed class Var<T> : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public Var(T val)
        {
            this.val = val;
        }

        T val;
        public T Value
        {
            get
            {
                return val;
            }
            set
            {
                if (EqualityComparer<T>.Default.Equals(value, val))
                {
                    return;
                }

                val = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Value", val));
            }
        }

        public static implicit operator Observable<object>(Var<T> v)
        {
            return v.ToObservable();
        }

        // causes stack overflow if uncommented
        //public static implicit operator T(Var<T> v)
        //{
        //    return v;
        //}

    }

    public sealed class Cell
    {

        static readonly Observable<object> noNotification =
            Subject.Create<object>()
                   .AsObservable();

        Func<object> source;

        Observable<object> notifier;

        object current;

        Subject<object> subject;

        public Cell(Func<object> _source, Observable<object> _notifier)
        {
            source = _source;

            notifier = _notifier;

            current = source();

            subject = Subject.Create<object>();

            _notifier.Subscribe(_ =>
                {

                    var p = source();

                    if (current != null && current.Equals(p))
                    {
                        return;
                    }
                    else if (current == null && p == null)
                    {
                        return;
                    }

                    current = p;

                    subject.Next(current);
                });
        }

        public static implicit operator Cell(string value)
        {
            return new Cell(() => value, noNotification);
        }

        public Observable<object> Observable
        {
            get
            {
                return subject.AsObservable()
                              .StartWith(current);
            }
        }
    }

    public sealed class NoNotification : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private NoNotification() { }

        public static NoNotification Instance = new NoNotification();
    }

    public interface IAttributes
    {

        void InitElement(HTMLElement element);

        void InitAnchorElement(HTMLAnchorElement element);

        void InitButtonElement(HTMLButtonElement element);

        void InitFormElement(HTMLFormElement element);

        void InitImageElement(HTMLImageElement element);

        void InitCanvasElement(HTMLCanvasElement element);

        void InitInputElement(HTMLInputElement element);

        void InitLabelElement(HTMLLabelElement element);

        void InitFieldSetElement(HTMLFieldSetElement element);

        void InitIFrameElement(HTMLIFrameElement element);

        void InitOptGroupElement(HTMLOptGroupElement element);

        void InitOptionElement(HTMLOptionElement element);

        void InitSelectElement(HTMLSelectElement element);

        void InitTextAreaElement(HTMLTextAreaElement element);

        void InitTableDataCellElement(HTMLTableDataCellElement element);

        void InitTableHeaderCellElement(HTMLTableHeaderCellElement element);

        void InitTableElement(HTMLTableElement element);

        void BindTemplate(HTMLElement element);
    }

    public sealed class Attributes<T> : IAttributes
    {
        public Cell ClassName { get; set; }
        public Cell Id { get; set; }
        public Cell ScrollLeft { get; set; }
        public Cell ScrollTop { get; set; }
        public Cell AccessKey { get; set; }
        public Cell ContentEditable { get; set; }
        public Cell Dir { get; set; }
        public Cell Lang { get; set; }
        public Cell TabIndex { get; set; }
        public Cell Title { get; set; }
        public Action OnCopy { get; set; }
        public Action OnCut { get; set; }
        public Action OnPaste { get; set; }
        public Action<Event> OnAbort { get; set; }
        public Action<Event> OnBlur { get; set; }
        public Action OnError { get; set; }
        public Action<Event> OnFocus { get; set; }
        public Action<Event> OnCancel { get; set; }
        public Action<Event> OnCanPlay { get; set; }
        public Action<Event> OnCanPlayThrough { get; set; }
        public Action<Event> OnChange { get; set; }
        public Action<MouseEvent> OnClick { get; set; }
        public Action<Event> OnClose { get; set; }
        public Action<Event> OnContextMenu { get; set; }
        public Action<Event> OnCueChange { get; set; }
        public Action<MouseEvent> OnDblClick { get; set; }
        public Action<Event> OnDrag { get; set; }
        public Action<Event> OnDragEnd { get; set; }
        public Action<Event> OnDragEnter { get; set; }
        public Action<Event> OnDragExit { get; set; }
        public Action<Event> OnDragLeave { get; set; }
        public Action<Event> OnDragOver { get; set; }
        public Action<Event> OnDragStart { get; set; }
        public Action<Event> OnDrop { get; set; }
        public Action<Event> OnDurationChange { get; set; }
        public Action<Event> OnEmptied { get; set; }
        public Action<Event> OnEnded { get; set; }
        public Action<Event> OnInput { get; set; }
        public Action<Event> OnInvalid { get; set; }
        public Action<KeyboardEvent> OnKeyDown { get; set; }
        public Action<KeyboardEvent> OnKeyPress { get; set; }
        public Action<KeyboardEvent> OnKeyUp { get; set; }
        public Action<Event> OnLoad { get; set; }
        public Action<Event> OnLoadedData { get; set; }
        public Action<Event> OnLoadedMetaData { get; set; }
        public Action<Event> OnLoadStart { get; set; }
        public Action<MouseEvent> OnMouseDown { get; set; }
        public Action<MouseEvent> OnMouseEnter { get; set; }
        public Action<MouseEvent> OnMouseLeave { get; set; }
        public Action<MouseEvent> OnMouseMove { get; set; }
        public Action<MouseEvent> OnMouseOut { get; set; }
        public Action<MouseEvent> OnMouseOver { get; set; }
        public Action<MouseEvent> OnMouseUp { get; set; }
        public Action<MouseEvent> OnMouseWheel { get; set; }
        public Action<Event> OnPause { get; set; }
        public Action<Event> OnPlay { get; set; }
        public Action<Event> OnPlaying { get; set; }
        public Action<Event> OnProgress { get; set; }
        public Action<Event> OnRateChange { get; set; }
        public Action<Event> OnReset { get; set; }
        public Action<Event> OnScroll { get; set; }
        public Action<Event> OnSeeked { get; set; }
        public Action<Event> OnSeeking { get; set; }
        public Action<Event> OnSelect { get; set; }
        public Action<Event> OnShow { get; set; }
        public Action<Event> OnSort { get; set; }
        public Action<Event> OnStalled { get; set; }
        public Action<Event> OnSubmit { get; set; }
        public Action<Event> OnSuspend { get; set; }
        public Action<Event> OnTimeUpdate { get; set; }
        public Action<Event> OnVolumeChange { get; set; }
        public Action<Event> OnWaiting { get; set; }
        public Action<TouchEvent> OnTouchStart { get; set; }
        public Action<TouchEvent> OnTouchEnd { get; set; }
        public Action<TouchEvent> OnTouchMove { get; set; }
        public Action<TouchEvent> OnTouchEnter { get; set; }
        public Action<TouchEvent> OnTouchLeave { get; set; }
        public Action<TouchEvent> OnTouchCancel { get; set; }
        public Cell Charset { get; set; }
        public Cell Coords { get; set; }
        public Cell Download { get; set; }
        public Cell Hash { get; set; }
        public Cell Host { get; set; }
        public Cell Hostname { get; set; }
        public Cell Href { get; set; }
        public Cell Hreflang { get; set; }
        public Cell Media { get; set; }
        public Cell Name { get; set; }
        public Cell Password { get; set; }
        public Cell Pathname { get; set; }
        public Cell Port { get; set; }
        public Cell Protocol { get; set; }
        public Cell Rel { get; set; }
        public Cell Rev { get; set; }
        public Cell Search { get; set; }
        public Cell SearchParams { get; set; }
        public Cell Shape { get; set; }
        public Cell Target { get; set; }
        public Cell Text { get; set; }
        public Cell Type { get; set; }
        public Cell Username { get; set; }
        public Cell AutoFocus { get; set; }
        public Cell Disabled { get; set; }
        public Cell FormAction { get; set; }
        public Cell FormEncType { get; set; }
        public Cell FormMethod { get; set; }
        public Cell FormNoValidate { get; set; }
        public Cell FormTarget { get; set; }
        public Cell ButtonType { get; set; }
        public Cell Value { get; set; }
        public Cell AcceptCharset { get; set; }
        public Cell Action { get; set; }
        public Cell AutoComplete { get; set; }
        public Cell Encoding { get; set; }
        public Cell Enctype { get; set; }
        public Cell Method { get; set; }
        public Cell NoValidate { get; set; }
        public Cell CrossOrigin { get; set; }
        public Cell ImageHeight { get; set; }
        public Cell IsMap { get; set; }
        public Cell Src { get; set; }
        public Cell SrcSet { get; set; }
        public Cell UseMap { get; set; }
        public Cell ImageWidth { get; set; }
        public Cell Accept { get; set; }
        public Cell Alt { get; set; }
        public Cell AutoSave { get; set; }
        public Cell Checked { get; set; }
        public Cell DefaultChecked { get; set; }
        public Cell DefaultValue { get; set; }
        public Cell Indeterminate { get; set; }
        public Cell List { get; set; }
        public Cell Max { get; set; }
        public Cell MaxLength { get; set; }
        public Cell Min { get; set; }
        public Cell Multiple { get; set; }
        public Cell Pattern { get; set; }
        public Cell Placeholder { get; set; }
        public Cell ReadOnly { get; set; }
        public Cell Required { get; set; }
        public Cell SelectionDirection { get; set; }
        public Cell SelectionEnd { get; set; }
        public Cell SelectionStart { get; set; }
        public Cell Step { get; set; }
        public Cell InputType { get; set; }
        public Cell HtmlFor { get; set; }
        public Cell AllowFullScreen { get; set; }
        public Cell FrameBorder { get; set; }
        public Cell IFrameHeight { get; set; }
        public Cell LongDesc { get; set; }
        public Cell IFrameMarginHeight { get; set; }
        public Cell IFrameMarginWidth { get; set; }
        public Cell Scrolling { get; set; }
        public Cell Seamless { get; set; }
        public Cell SrcDoc { get; set; }
        public Cell IFrameWidth { get; set; }
        public Cell Label { get; set; }
        public Cell DefaultSelected { get; set; }
        public Cell Disable { get; set; }
        public Cell Selected { get; set; }
        public Cell SelectedIndex { get; set; }
        public Cell Size { get; set; }
        public Cell Cols { get; set; }
        public Cell Rows { get; set; }
        public Cell Wrap { get; set; }
        public Cell Span { get; set; }
        public Cell ColSpan { get; set; }
        public Cell RowSpan { get; set; }
        public Cell CellIndex { get; set; }
        public Cell Abbr { get; set; }
        public Cell Caption { get; set; }
        public Cell THead { get; set; }
        public Cell TFoot { get; set; }
        public Cell CanvasHeight { get; set; }
        public Cell CanvasWidth { get; set; }

        public IEnumerable<T> Items { get; set; }

        public Func<T, HTMLElement> Template { get; set; }

        public Observable<object> Trigger { get; set; }

        public Action<HTMLElement> OnTrigger { get; set; }

        public void BindTemplate(HTMLElement element)
        {
            if (Items == null || Template == null)
            {
                return;
            }

            Dictionary<T, Action> onRemove = new Dictionary<T, Action>();

            Action<IEnumerable<T>> load =
                vals =>
                {
                    foreach (var a in vals)
                    {
                        var b = Template(a);

                        element.AppendChild(b);

                        onRemove[a] =
                            () =>
                            {
                                element.RemoveChild(b);

                                onRemove.Remove(a);
                            };
                    }
                };

            (Items as ObservableCollection<T>)?
                 .Added
                 .Subscribe(
                    added => load(added));

            (Items as ObservableCollection<T>)?
                 .Removed
                 .Subscribe(removed => removed.ForEach(a => onRemove[a]()));

            load(Items);
        }

        public void InitElement(HTMLElement element)
        {
            // remember to remove automated text binding
            var currentText = default(Text);

            Text?.Observable
                 .Subscribe(
                    t =>
                    {
                        var n = Document.CreateTextNode((string)t);

                        if (currentText != null)
                        {
                            element.ReplaceChild(n, currentText);
                        }
                        else
                        {
                            element.AppendChild(n);
                        }

                        currentText = n;
                    });

            ClassName?.Observable.Subscribe(a => element.ClassName = (String)a);
            AccessKey?.Observable.Subscribe(a => element.AccessKey = (String)a);
            ContentEditable?.Observable.Subscribe(a => element.ContentEditable = (ContentEditable)a);
            Dir?.Observable.Subscribe(a => element.Dir = (TextDirection)a);
            Lang?.Observable.Subscribe(a => element.Lang = (String)a);
            TabIndex?.Observable.Subscribe(a => element.TabIndex = (Int32)a);
            Title?.Observable.Subscribe(a => element.Title = (String)a);
            element.OnCopy = OnCopy;
            element.OnCut = OnCut;
            element.OnPaste = OnPaste;
            element.OnAbort = OnAbort;
            element.OnBlur = OnBlur;
            //if (OnError != null) { element.OnError += OnError; }
            if (OnFocus != null) { element.OnFocus += OnFocus; }
            if (OnCancel != null) { element.OnCancel += OnCancel; }
            if (OnCanPlay != null) { element.OnCanPlay += OnCanPlay; }
            if (OnCanPlayThrough != null) { element.OnCanPlayThrough += OnCanPlayThrough; }
            if (OnChange != null) { element.OnChange += OnChange; }
            if (OnClick != null) { element.OnClick += OnClick; }
            if (OnClose != null) { element.OnClose += OnClose; }
            if (OnContextMenu != null) { element.OnContextMenu += OnContextMenu; }
            if (OnCueChange != null) { element.OnCueChange += OnCueChange; }
            if (OnDblClick != null) { element.OnDblClick += OnDblClick; }
            if (OnDrag != null) { element.OnDrag += OnDrag; }
            if (OnDragEnd != null) { element.OnDragEnd += OnDragEnd; }
            if (OnDragEnter != null) { element.OnDragEnter += OnDragEnter; }
            if (OnDragExit != null) { element.OnDragExit += OnDragExit; }
            if (OnDragLeave != null) { element.OnDragLeave += OnDragLeave; }
            if (OnDragOver != null) { element.OnDragOver += OnDragOver; }
            if (OnDragStart != null) { element.OnDragStart += OnDragStart; }
            if (OnDrop != null) { element.OnDrop += OnDrop; }
            if (OnDurationChange != null) { element.OnDurationChange += OnDurationChange; }
            if (OnEmptied != null) { element.OnEmptied += OnEmptied; }
            if (OnEnded != null) { element.OnEnded += OnEnded; }
            if (OnInput != null) { element.OnInput += OnInput; }
            if (OnInvalid != null) { element.OnInvalid += OnInvalid; }
            if (OnKeyDown != null) { element.OnKeyDown += OnKeyDown; }
            if (OnKeyPress != null) { element.OnKeyPress += OnKeyPress; }
            if (OnKeyUp != null) { element.OnKeyUp += OnKeyUp; }
            if (OnLoad != null) { element.OnLoad += OnLoad; }
            if (OnLoadedData != null) { element.OnLoadedData += OnLoadedData; }
            if (OnLoadedMetaData != null) { element.OnLoadedMetaData += OnLoadedMetaData; }
            if (OnLoadStart != null) { element.OnLoadStart += OnLoadStart; }
            if (OnMouseDown != null) { element.OnMouseDown += OnMouseDown; }
            if (OnMouseEnter != null) { element.OnMouseEnter += OnMouseEnter; }
            if (OnMouseLeave != null) { element.OnMouseLeave += OnMouseLeave; }
            if (OnMouseMove != null) { element.OnMouseMove += OnMouseMove; }
            if (OnMouseOut != null) { element.OnMouseOut += OnMouseOut; }
            if (OnMouseOver != null) { element.OnMouseOver += OnMouseOver; }
            if (OnMouseUp != null) { element.OnMouseUp += OnMouseUp; }
            if (OnMouseWheel != null) { element.OnMouseWheel += OnMouseWheel; }
            if (OnPause != null) { element.OnPause += OnPause; }
            if (OnPlay != null) { element.OnPlay += OnPlay; }
            if (OnPlaying != null) { element.OnPlaying += OnPlaying; }
            if (OnProgress != null) { element.OnProgress += OnProgress; }
            if (OnRateChange != null) { element.OnRateChange += OnRateChange; }
            if (OnReset != null) { element.OnReset += OnReset; }
            if (OnScroll != null) { element.OnScroll += OnScroll; }
            if (OnSeeked != null) { element.OnSeeked += OnSeeked; }
            if (OnSeeking != null) { element.OnSeeking += OnSeeking; }
            if (OnSelect != null) { element.OnSelect += OnSelect; }
            if (OnShow != null) { element.OnShow += OnShow; }
            if (OnSort != null) { element.OnSort += OnSort; }
            if (OnStalled != null) { element.OnStalled += OnStalled; }
            if (OnSubmit != null) { element.OnSubmit += OnSubmit; }
            if (OnSuspend != null) { element.OnSuspend += OnSuspend; }
            if (OnTimeUpdate != null) { element.OnTimeUpdate += OnTimeUpdate; }
            if (OnVolumeChange != null) { element.OnVolumeChange += OnVolumeChange; }
            if (OnWaiting != null) { element.OnWaiting += OnWaiting; }
            if (OnTouchStart != null) { element.OnTouchStart += OnTouchStart; }
            if (OnTouchEnd != null) { element.OnTouchEnd += OnTouchEnd; }
            if (OnTouchMove != null) { element.OnTouchMove += OnTouchMove; }
            if (OnTouchEnter != null) { element.OnTouchEnter += OnTouchEnter; }
            if (OnTouchLeave != null) { element.OnTouchLeave += OnTouchLeave; }
            if (OnTouchCancel != null) { element.OnTouchCancel += OnTouchCancel; }

            Trigger?.Subscribe(_ => OnTrigger?.Invoke(element));

            BindTemplate(element);
        }


        public void InitCanvasElement(HTMLCanvasElement element)
        {
            InitElement(element);
            
            CanvasHeight?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.Height != b)
                                                            {
                                                                element.Height = b;
                                                            }
                                                        }
                                                                   );
            
            CanvasWidth?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.Width != b)
                                                            {
                                                                element.Width = b;
                                                            }
                                                        }
                                                                   );
        }

        public void InitAnchorElement(HTMLAnchorElement element)
        {
            InitElement(element);
            Charset?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Charset != b)
                                                            {
                                                                element.Charset = b;
                                                            }
                                                        }
                                                                   );
            Coords?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Coords != b)
                                                            {
                                                                element.Coords = b;
                                                            }
                                                        }
                                                                   );
            Download?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Download != b)
                                                            {
                                                                element.Download = b;
                                                            }
                                                        }
                                                                   );
            Hash?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Hash != b)
                                                            {
                                                                element.Hash = b;
                                                            }
                                                        }
                                                                   );
            Host?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Host != b)
                                                            {
                                                                element.Host = b;
                                                            }
                                                        }
                                                                   );
            Hostname?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Hostname != b)
                                                            {
                                                                element.Hostname = b;
                                                            }
                                                        }
                                                                   );
            Href?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Href != b)
                                                            {
                                                                element.Href = b;
                                                            }
                                                        }
                                                                   );
            Hreflang?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Hreflang != b)
                                                            {
                                                                element.Hreflang = b;
                                                            }
                                                        }
                                                                   );
            Media?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Media != b)
                                                            {
                                                                element.Media = b;
                                                            }
                                                        }
                                                                   );
            Name?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Name != b)
                                                            {
                                                                element.Name = b;
                                                            }
                                                        }
                                                                   );
            Password?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Password != b)
                                                            {
                                                                element.Password = b;
                                                            }
                                                        }
                                                                   );
            Pathname?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Pathname != b)
                                                            {
                                                                element.Pathname = b;
                                                            }
                                                        }
                                                                   );
            Port?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Port != b)
                                                            {
                                                                element.Port = b;
                                                            }
                                                        }
                                                                   );
            Protocol?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Protocol != b)
                                                            {
                                                                element.Protocol = b;
                                                            }
                                                        }
                                                                   );
            Rel?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Rel != b)
                                                            {
                                                                element.Rel = b;
                                                            }
                                                        }
                                                                   );
            Rev?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Rev != b)
                                                            {
                                                                element.Rev = b;
                                                            }
                                                        }
                                                                   );
            Search?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Search != b)
                                                            {
                                                                element.Search = b;
                                                            }
                                                        }
                                                                   );
            SearchParams?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (URLSearchParams)a;
                                                            if (element.SearchParams != b)
                                                            {
                                                                element.SearchParams = b;
                                                            }
                                                        }
                                                                   );
            Shape?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Shape != b)
                                                            {
                                                                element.Shape = b;
                                                            }
                                                        }
                                                                   );
            Target?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Target != b)
                                                            {
                                                                element.Target = b;
                                                            }
                                                        }
                                                                   );
            Text?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Text != b)
                                                            {
                                                                element.Text = b;
                                                            }
                                                        }
                                                                   );
            Type?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Type != b)
                                                            {
                                                                element.Type = b;
                                                            }
                                                        }
                                                                   );
            Username?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Username != b)
                                                            {
                                                                element.Username = b;
                                                            }
                                                        }
                                                                   );
        }
        public void InitButtonElement(HTMLButtonElement element)
        {
            InitElement(element);
            AutoFocus?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.AutoFocus != b)
                                                            {
                                                                element.AutoFocus = b;
                                                            }
                                                        }
                                                                   );
            Disabled?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.Disabled != b)
                                                            {
                                                                element.Disabled = b;
                                                            }
                                                        }
                                                                   );
            FormAction?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.FormAction != b)
                                                            {
                                                                element.FormAction = b;
                                                            }
                                                        }
                                                                   );
            FormEncType?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.FormEncType != b)
                                                            {
                                                                element.FormEncType = b;
                                                            }
                                                        }
                                                                   );
            FormMethod?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.FormMethod != b)
                                                            {
                                                                element.FormMethod = b;
                                                            }
                                                        }
                                                                   );
            FormNoValidate?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.FormNoValidate != b)
                                                            {
                                                                element.FormNoValidate = b;
                                                            }
                                                        }
                                                                   );
            FormTarget?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.FormTarget != b)
                                                            {
                                                                element.FormTarget = b;
                                                            }
                                                        }
                                                                   );
            Name?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Name != b)
                                                            {
                                                                element.Name = b;
                                                            }
                                                        }
                                                                   );
            ButtonType?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (ButtonType)a;
                                                            if (element.Type != b)
                                                            {
                                                                element.Type = b;
                                                            }
                                                        }
                                                                   );
            Value?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Value != b)
                                                            {
                                                                element.Value = b;
                                                            }
                                                        }
                                                                   );
        }
        public void InitFormElement(HTMLFormElement element)
        {
            InitElement(element);
            AcceptCharset?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.AcceptCharset != b)
                                                            {
                                                                element.AcceptCharset = b;
                                                            }
                                                        }
                                                                   );
            Action?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Action != b)
                                                            {
                                                                element.Action = b;
                                                            }
                                                        }
                                                                   );
            AutoComplete?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (AutoComplete)a;
                                                            if (element.AutoComplete != b)
                                                            {
                                                                element.AutoComplete = b;
                                                            }
                                                        }
                                                                   );
            Encoding?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Encoding != b)
                                                            {
                                                                element.Encoding = b;
                                                            }
                                                        }
                                                                   );
            Enctype?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Enctype != b)
                                                            {
                                                                element.Enctype = b;
                                                            }
                                                        }
                                                                   );
            Method?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Method != b)
                                                            {
                                                                element.Method = b;
                                                            }
                                                        }
                                                                   );
            Name?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Name != b)
                                                            {
                                                                element.Name = b;
                                                            }
                                                        }
                                                                   );
            NoValidate?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.NoValidate != b)
                                                            {
                                                                element.NoValidate = b;
                                                            }
                                                        }
                                                                   );
            Target?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Target != b)
                                                            {
                                                                element.Target = b;
                                                            }
                                                        }
                                                                   );
        }
        public void InitImageElement(HTMLImageElement element)
        {
            InitElement(element);
            CrossOrigin?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.CrossOrigin != b)
                                                            {
                                                                element.CrossOrigin = b;
                                                            }
                                                        }
                                                                   );
            ImageHeight?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.Height != b)
                                                            {
                                                                element.Height = b;
                                                            }
                                                        }
                                                                   );
            IsMap?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.IsMap != b)
                                                            {
                                                                element.IsMap = b;
                                                            }
                                                        }
                                                                   );
            Src?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Src != b)
                                                            {
                                                                element.Src = b;
                                                            }
                                                        }
                                                                   );
            SrcSet?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.SrcSet != b)
                                                            {
                                                                element.SrcSet = b;
                                                            }
                                                        }
                                                                   );
            UseMap?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.UseMap != b)
                                                            {
                                                                element.UseMap = b;
                                                            }
                                                        }
                                                                   );
            ImageWidth?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.Width != b)
                                                            {
                                                                element.Width = b;
                                                            }
                                                        }
                                                                   );
        }
        public void InitInputElement(HTMLInputElement element)
        {
            InitElement(element);
            Accept?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Accept != b)
                                                            {
                                                                element.Accept = b;
                                                            }
                                                        }
                                                                   );
            Alt?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Alt != b)
                                                            {
                                                                element.Alt = b;
                                                            }
                                                        }
                                                                   );
            AutoComplete?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (AutoComplete)a;
                                                            if (element.AutoComplete != b)
                                                            {
                                                                element.AutoComplete = b;
                                                            }
                                                        }
                                                                   );
            AutoFocus?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.AutoFocus != b)
                                                            {
                                                                element.AutoFocus = b;
                                                            }
                                                        }
                                                                   );
            AutoSave?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.AutoSave != b)
                                                            {
                                                                element.AutoSave = b;
                                                            }
                                                        }
                                                                   );
            Checked?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.Checked != b)
                                                            {
                                                                element.Checked = b;
                                                            }
                                                        }
                                                                   );
            DefaultChecked?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.DefaultChecked != b)
                                                            {
                                                                element.DefaultChecked = b;
                                                            }
                                                        }
                                                                   );
            DefaultValue?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.DefaultValue != b)
                                                            {
                                                                element.DefaultValue = b;
                                                            }
                                                        }
                                                                   );
            Disabled?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.Disabled != b)
                                                            {
                                                                element.Disabled = b;
                                                            }
                                                        }
                                                                   );
            FormAction?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.FormAction != b)
                                                            {
                                                                element.FormAction = b;
                                                            }
                                                        }
                                                                   );
            FormEncType?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.FormEncType != b)
                                                            {
                                                                element.FormEncType = b;
                                                            }
                                                        }
                                                                   );
            FormMethod?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.FormMethod != b)
                                                            {
                                                                element.FormMethod = b;
                                                            }
                                                        }
                                                                   );
            FormNoValidate?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.FormNoValidate != b)
                                                            {
                                                                element.FormNoValidate = b;
                                                            }
                                                        }
                                                                   );
            FormTarget?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.FormTarget != b)
                                                            {
                                                                element.FormTarget = b;
                                                            }
                                                        }
                                                                   );
            Indeterminate?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.Indeterminate != b)
                                                            {
                                                                element.Indeterminate = b;
                                                            }
                                                        }
                                                                   );
            List?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (HTMLElement)a;
                                                            if (element.List != b)
                                                            {
                                                                element.List = b;
                                                            }
                                                        }
                                                                   );
            Max?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Max != b)
                                                            {
                                                                element.Max = b;
                                                            }
                                                        }
                                                                   );
            MaxLength?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.MaxLength != b)
                                                            {
                                                                element.MaxLength = b;
                                                            }
                                                        }
                                                                   );
            Min?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Min != b)
                                                            {
                                                                element.Min = b;
                                                            }
                                                        }
                                                                   );
            Multiple?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.Multiple != b)
                                                            {
                                                                element.Multiple = b;
                                                            }
                                                        }
                                                                   );
            Name?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Name != b)
                                                            {
                                                                element.Name = b;
                                                            }
                                                        }
                                                                   );
            Pattern?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Pattern != b)
                                                            {
                                                                element.Pattern = b;
                                                            }
                                                        }
                                                                   );
            Placeholder?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Placeholder != b)
                                                            {
                                                                element.Placeholder = b;
                                                            }
                                                        }
                                                                   );
            ReadOnly?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.ReadOnly != b)
                                                            {
                                                                element.ReadOnly = b;
                                                            }
                                                        }
                                                                   );
            Required?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.Required != b)
                                                            {
                                                                element.Required = b;
                                                            }
                                                        }
                                                                   );
            SelectionDirection?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.SelectionDirection != b)
                                                            {
                                                                element.SelectionDirection = b;
                                                            }
                                                        }
                                                                   );
            SelectionEnd?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.SelectionEnd != b)
                                                            {
                                                                element.SelectionEnd = b;
                                                            }
                                                        }
                                                                   );
            SelectionStart?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.SelectionStart != b)
                                                            {
                                                                element.SelectionStart = b;
                                                            }
                                                        }
                                                                   );
            Src?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Src != b)
                                                            {
                                                                element.Src = b;
                                                            }
                                                        }
                                                                   );
            Step?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Step != b)
                                                            {
                                                                element.Step = b;
                                                            }
                                                        }
                                                                   );
            TabIndex?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.TabIndex != b)
                                                            {
                                                                element.TabIndex = b;
                                                            }
                                                        }
                                                                   );
            InputType?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (InputType)a;
                                                            if (element.Type != b)
                                                            {
                                                                element.Type = b;
                                                            }
                                                        }
                                                                   );
            UseMap?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.UseMap != b)
                                                            {
                                                                element.UseMap = b;
                                                            }
                                                        }
                                                                   );
            Value?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Value != b)
                                                            {
                                                                element.Value = b;
                                                            }
                                                        }
                                                                   );
        }
        public void InitLabelElement(HTMLLabelElement element)
        {
            InitElement(element);
            HtmlFor?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.HtmlFor != b)
                                                            {
                                                                element.HtmlFor = b;
                                                            }
                                                        }
                                                                   );
        }
        public void InitFieldSetElement(HTMLFieldSetElement element)
        {
            InitElement(element);
            Disabled?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.Disabled != b)
                                                            {
                                                                element.Disabled = b;
                                                            }
                                                        }
                                                                   );
            Name?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Name != b)
                                                            {
                                                                element.Name = b;
                                                            }
                                                        }
                                                                   );
        }
        public void InitIFrameElement(HTMLIFrameElement element)
        {
            InitElement(element);
            AllowFullScreen?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.AllowFullScreen != b)
                                                            {
                                                                element.AllowFullScreen = b;
                                                            }
                                                        }
                                                                   );
            FrameBorder?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.FrameBorder != b)
                                                            {
                                                                element.FrameBorder = b;
                                                            }
                                                        }
                                                                   );
            IFrameHeight?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.Height != b)
                                                            {
                                                                element.Height = b;
                                                            }
                                                        }
                                                                   );
            LongDesc?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.LongDesc != b)
                                                            {
                                                                element.LongDesc = b;
                                                            }
                                                        }
                                                                   );
            IFrameMarginHeight?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.MarginHeight != b)
                                                            {
                                                                element.MarginHeight = b;
                                                            }
                                                        }
                                                                   );
            IFrameMarginWidth?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.MarginWidth != b)
                                                            {
                                                                element.MarginWidth = b;
                                                            }
                                                        }
                                                                   );
            Name?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Name != b)
                                                            {
                                                                element.Name = b;
                                                            }
                                                        }
                                                                   );
            Scrolling?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Scrolling != b)
                                                            {
                                                                element.Scrolling = b;
                                                            }
                                                        }
                                                                   );
            Seamless?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.Seamless != b)
                                                            {
                                                                element.Seamless = b;
                                                            }
                                                        }
                                                                   );
            Src?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Src != b)
                                                            {
                                                                element.Src = b;
                                                            }
                                                        }
                                                                   );
            SrcDoc?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.SrcDoc != b)
                                                            {
                                                                element.SrcDoc = b;
                                                            }
                                                        }
                                                                   );
            IFrameWidth?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.Width != b)
                                                            {
                                                                element.Width = b;
                                                            }
                                                        }
                                                                   );
        }
        public void InitOptGroupElement(HTMLOptGroupElement element)
        {
            InitElement(element);
            Disabled?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.Disabled != b)
                                                            {
                                                                element.Disabled = b;
                                                            }
                                                        }
                                                                   );
            Label?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Label != b)
                                                            {
                                                                element.Label = b;
                                                            }
                                                        }
                                                                   );
        }
        public void InitOptionElement(HTMLOptionElement element)
        {
            InitElement(element);
            DefaultSelected?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.DefaultSelected != b)
                                                            {
                                                                element.DefaultSelected = b;
                                                            }
                                                        }
                                                                   );
            Disable?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.Disable != b)
                                                            {
                                                                element.Disable = b;
                                                            }
                                                        }
                                                                   );
            Label?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Label != b)
                                                            {
                                                                element.Label = b;
                                                            }
                                                        }
                                                                   );
            Selected?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.Selected != b)
                                                            {
                                                                element.Selected = b;
                                                            }
                                                        }
                                                                   );
            Text?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Text != b)
                                                            {
                                                                element.Text = b;
                                                            }
                                                        }
                                                                   );
            Value?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Value != b)
                                                            {
                                                                element.Value = b;
                                                            }
                                                        }
                                                                   );
        }
        public void InitSelectElement(HTMLSelectElement element)
        {
            InitElement(element);
            AutoFocus?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.AutoFocus != b)
                                                            {
                                                                element.AutoFocus = b;
                                                            }
                                                        }
                                                                   );
            Disabled?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.Disabled != b)
                                                            {
                                                                element.Disabled = b;
                                                            }
                                                        }
                                                                   );
            Multiple?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.Multiple != b)
                                                            {
                                                                element.Multiple = b;
                                                            }
                                                        }
                                                                   );
            Name?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Name != b)
                                                            {
                                                                element.Name = b;
                                                            }
                                                        }
                                                                   );
            Required?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.Required != b)
                                                            {
                                                                element.Required = b;
                                                            }
                                                        }
                                                                   );
            SelectedIndex?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.SelectedIndex != b)
                                                            {
                                                                element.SelectedIndex = b;
                                                            }
                                                        }
                                                                   );
            Size?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.Size != b)
                                                            {
                                                                element.Size = b;
                                                            }
                                                        }
                                                                   );
            Src?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Src != b)
                                                            {
                                                                element.Src = b;
                                                            }
                                                        }
                                                                   );
        }
        public void InitTextAreaElement(HTMLTextAreaElement element)
        {
            InitElement(element);
            AutoFocus?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.AutoFocus != b)
                                                            {
                                                                element.AutoFocus = b;
                                                            }
                                                        }
                                                                   );
            Cols?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.Cols != b)
                                                            {
                                                                element.Cols = b;
                                                            }
                                                        }
                                                                   );
            Disabled?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.Disabled != b)
                                                            {
                                                                element.Disabled = b;
                                                            }
                                                        }
                                                                   );
            MaxLength?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.MaxLength != b)
                                                            {
                                                                element.MaxLength = b;
                                                            }
                                                        }
                                                                   );
            Name?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Name != b)
                                                            {
                                                                element.Name = b;
                                                            }
                                                        }
                                                                   );
            Placeholder?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Placeholder != b)
                                                            {
                                                                element.Placeholder = b;
                                                            }
                                                        }
                                                                   );
            ReadOnly?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.ReadOnly != b)
                                                            {
                                                                element.ReadOnly = b;
                                                            }
                                                        }
                                                                   );
            Required?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Boolean)a;
                                                            if (element.Required != b)
                                                            {
                                                                element.Required = b;
                                                            }
                                                        }
                                                                   );
            Rows?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.Rows != b)
                                                            {
                                                                element.Rows = b;
                                                            }
                                                        }
                                                                   );
            SelectionDirection?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.SelectionDirection != b)
                                                            {
                                                                element.SelectionDirection = b;
                                                            }
                                                        }
                                                                   );
            SelectionEnd?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.SelectionEnd != b)
                                                            {
                                                                element.SelectionEnd = b;
                                                            }
                                                        }
                                                                   );
            SelectionStart?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.SelectionStart != b)
                                                            {
                                                                element.SelectionStart = b;
                                                            }
                                                        }
                                                                   );
            Value?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Value != b)
                                                            {
                                                                element.Value = b;
                                                            }
                                                        }
                                                                   );
            Wrap?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Wrap)a;
                                                            if (element.Wrap != b)
                                                            {
                                                                element.Wrap = b;
                                                            }
                                                        }
                                                                   );
        }
        public void InitTableDataCellElement(HTMLTableDataCellElement element)
        {
            InitElement(element);
            ColSpan?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (uint)(int)a;
                                                            if (element.ColSpan != b)
                                                            {
                                                                element.ColSpan = b;
                                                            }
                                                        }
                                                                   );
            RowSpan?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (uint)(int)a;
                                                            if (element.RowSpan != b)
                                                            {
                                                                element.RowSpan = b;
                                                            }
                                                        }
                                                                   );
            CellIndex?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.CellIndex != b)
                                                            {
                                                                element.CellIndex = b;
                                                            }
                                                        }
                                                                   );
        }
        public void InitTableHeaderCellElement(HTMLTableHeaderCellElement element)
        {
            InitElement(element);
            Abbr?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (String)a;
                                                            if (element.Abbr != b)
                                                            {
                                                                element.Abbr = b;
                                                            }
                                                        }
                                                                   );
            ColSpan?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (uint)(int)a;
                                                            if (element.ColSpan != b)
                                                            {
                                                                element.ColSpan = b;
                                                            }
                                                        }
                                                                   );
            RowSpan?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (uint)(int)a;
                                                            if (element.RowSpan != b)
                                                            {
                                                                element.RowSpan = b;
                                                            }
                                                        }
                                                                   );
            CellIndex?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (Int32)a;
                                                            if (element.CellIndex != b)
                                                            {
                                                                element.CellIndex = b;
                                                            }
                                                        }
                                                                   );
        }
        public void InitTableElement(HTMLTableElement element)
        {
            InitElement(element);
            Caption?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (HTMLTableCaptionElement)a;
                                                            if (element.Caption != b)
                                                            {
                                                                element.Caption = b;
                                                            }
                                                        }
                                                                   );
            THead?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (HTMLTableSectionElement)a;
                                                            if (element.THead != b)
                                                            {
                                                                element.THead = b;
                                                            }
                                                        }
                                                                   );
            TFoot?.Observable
                                                        .Subscribe(a =>
                                                        {
                                                            var b = (HTMLTableSectionElement)a;
                                                            if (element.TFoot != b)
                                                            {
                                                                element.TFoot = b;
                                                            }
                                                        }
                                                                   );
        }


    }

    public sealed class AnyString
    {

        string first;
        public string First
        {
            get { return first; }
            set
            {
                first = value;
                isFirst = true;
            }
        }

        Func<string> second;
        public Func<string> Second
        {
            get { return second; }
            set
            {
                second = value;
                isFirst = false;
            }
        }

        bool isFirst;
        public bool IsFirst { get { return isFirst; } }

        public static implicit operator AnyString(string s)
        {
            var a = new AnyString();

            a.First = s;

            return a;
        }

        public static implicit operator AnyString(Func<string> s)
        {
            var a = new AnyString();

            a.Second = s;

            return a;
        }
    }

    public sealed class AnyInt
    {

        int first;
        public int First
        {
            get { return first; }
            set
            {
                first = value;
                isFirst = true;
            }
        }

        Func<int> second;
        public Func<int> Second
        {
            get { return second; }
            set
            {
                second = value;
                isFirst = false;
            }
        }

        bool isFirst;
        public bool IsFirst { get { return isFirst; } }

        public static implicit operator AnyInt(int s)
        {
            var a = new AnyInt();

            a.First = s;

            return a;
        }

        public static implicit operator AnyInt(Func<int> s)
        {
            var a = new AnyInt();

            a.Second = s;

            return a;
        }

    }

    public sealed class AnyBool
    {

        bool first;
        public bool First
        {
            get { return first; }
            set
            {
                first = value;
                isFirst = true;
            }
        }

        Func<bool> second;
        public Func<bool> Second
        {
            get { return second; }
            set
            {
                second = value;
                isFirst = false;
            }
        }

        bool isFirst;
        public bool IsFirst { get { return isFirst; } }

        public static implicit operator AnyBool(bool s)
        {
            var a = new AnyBool();

            a.First = s;

            return a;
        }

        public static implicit operator AnyBool(Func<bool> s)
        {
            var a = new AnyBool();

            a.Second = s;

            return a;
        }


    }

    public sealed class AnyDate
    {

        Date first;
        public Date First
        {
            get { return first; }
            set
            {
                first = value;
                isFirst = true;
            }
        }

        Func<Date> second;
        public Func<Date> Second
        {
            get { return second; }
            set
            {
                second = value;
                isFirst = false;
            }
        }

        bool isFirst;
        public bool IsFirst { get { return isFirst; } }

        public static implicit operator AnyDate(Date s)
        {
            var a = new AnyDate();

            a.First = s;

            return a;
        }

        public static implicit operator AnyDate(Func<Date> s)
        {
            var a = new AnyDate();

            a.Second = s;

            return a;
        }

    }

    public sealed class AnyDouble
    {

        Double first;
        public Double First
        {
            get { return first; }
            set
            {
                first = value;
                isFirst = true;
            }
        }

        Func<Double> second;
        public Func<Double> Second
        {
            get { return second; }
            set
            {
                second = value;
                isFirst = false;
            }
        }

        bool isFirst;
        public bool IsFirst { get { return isFirst; } }

        public static implicit operator AnyDouble(Double s)
        {
            var a = new AnyDouble();

            a.First = s;

            return a;
        }

        public static implicit operator AnyDouble(Func<Double> s)
        {
            var a = new AnyDouble();

            a.Second = s;

            return a;
        }

    }

    public sealed class AnyHTMLTableSectionElement
    {

        HTMLTableSectionElement first;
        public HTMLTableSectionElement First
        {
            get { return first; }
            set
            {
                first = value;
                isFirst = true;
            }
        }

        Func<HTMLTableSectionElement> second;
        public Func<HTMLTableSectionElement> Second
        {
            get { return second; }
            set
            {
                second = value;
                isFirst = false;
            }
        }

        bool isFirst;
        public bool IsFirst { get { return isFirst; } }

        public static implicit operator AnyHTMLTableSectionElement(HTMLTableSectionElement s)
        {
            var a = new AnyHTMLTableSectionElement();

            a.First = s;

            return a;
        }

        public static implicit operator AnyHTMLTableSectionElement(Func<HTMLTableSectionElement> s)
        {
            var a = new AnyHTMLTableSectionElement();

            a.Second = s;

            return a;
        }

    }

    public sealed class AnyButtonType
    {

        ButtonType first;
        public ButtonType First
        {
            get { return first; }
            set
            {
                first = value;
                isFirst = true;
            }
        }

        Func<ButtonType> second;
        public Func<ButtonType> Second
        {
            get { return second; }
            set
            {
                second = value;
                isFirst = false;
            }
        }

        bool isFirst;
        public bool IsFirst { get { return isFirst; } }

        public static implicit operator AnyButtonType(ButtonType s)
        {
            var a = new AnyButtonType();

            a.First = s;

            return a;
        }

        public static implicit operator AnyButtonType(Func<ButtonType> s)
        {
            var a = new AnyButtonType();

            a.Second = s;

            return a;
        }

    }

    public sealed class AnyAutoComplete
    {

        AutoComplete first;
        public AutoComplete First
        {
            get { return first; }
            set
            {
                first = value;
                isFirst = true;
            }
        }

        Func<AutoComplete> second;
        public Func<AutoComplete> Second
        {
            get { return second; }
            set
            {
                second = value;
                isFirst = false;
            }
        }

        bool isFirst;
        public bool IsFirst { get { return isFirst; } }

        public static implicit operator AnyAutoComplete(AutoComplete s)
        {
            var a = new AnyAutoComplete();

            a.First = s;

            return a;
        }

        public static implicit operator AnyAutoComplete(Func<AutoComplete> s)
        {
            var a = new AnyAutoComplete();

            a.Second = s;

            return a;
        }

    }

    public sealed class AnyInputType
    {

        InputType first;
        public InputType First
        {
            get { return first; }
            set
            {
                first = value;
                isFirst = true;
            }
        }

        Func<InputType> second;
        public Func<InputType> Second
        {
            get { return second; }
            set
            {
                second = value;
                isFirst = false;
            }
        }

        bool isFirst;
        public bool IsFirst { get { return isFirst; } }

        public static implicit operator AnyInputType(InputType s)
        {
            var a = new AnyInputType();

            a.First = s;

            return a;
        }

        public static implicit operator AnyInputType(Func<InputType> s)
        {
            var a = new AnyInputType();

            a.Second = s;

            return a;
        }

    }

    public sealed class AnyWrap
    {

        Wrap first;
        public Wrap First
        {
            get { return first; }
            set
            {
                first = value;
                isFirst = true;
            }
        }

        Func<Wrap> second;
        public Func<Wrap> Second
        {
            get { return second; }
            set
            {
                second = value;
                isFirst = false;
            }
        }

        bool isFirst;
        public bool IsFirst { get { return isFirst; } }

        public static implicit operator AnyWrap(Wrap s)
        {
            var a = new AnyWrap();

            a.First = s;

            return a;
        }

        public static implicit operator AnyWrap(Func<Wrap> s)
        {
            var a = new AnyWrap();

            a.Second = s;

            return a;
        }

    }

    public sealed class AnyHTMLTableCaptionElement
    {

        HTMLTableCaptionElement first;
        public HTMLTableCaptionElement First
        {
            get { return first; }
            set
            {
                first = value;
                isFirst = true;
            }
        }

        Func<HTMLTableCaptionElement> second;
        public Func<HTMLTableCaptionElement> Second
        {
            get { return second; }
            set
            {
                second = value;
                isFirst = false;
            }
        }

        bool isFirst;
        public bool IsFirst { get { return isFirst; } }

        public static implicit operator AnyHTMLTableCaptionElement(HTMLTableCaptionElement s)
        {
            var a = new AnyHTMLTableCaptionElement();

            a.First = s;

            return a;
        }

        public static implicit operator AnyHTMLTableCaptionElement(Func<HTMLTableCaptionElement> s)
        {
            var a = new AnyHTMLTableCaptionElement();

            a.Second = s;

            return a;
        }

    }


}