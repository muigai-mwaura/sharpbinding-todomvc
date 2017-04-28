using Bridge;
using Bridge.Html5;
using Bridge.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using Rx;

namespace SharpBindings
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