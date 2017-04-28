Bridge.assembly("Aurelia", function ($asm, globals) {
    "use strict";

    Bridge.define("SharpBindings.AnyAutoComplete", {
        statics: {
            op_Implicit: function (s) {
                var a = new SharpBindings.AnyAutoComplete();

                a.setFirst(s);

                return a;
            },
            op_Implicit$1: function (s) {
                var a = new SharpBindings.AnyAutoComplete();

                a.setSecond(s);

                return a;
            }
        },
        first: "off",
        second: null,
        isFirst: false,
        getFirst: function () {
            return this.first;
        },
        setFirst: function (value) {
            this.first = value;
            this.isFirst = true;
        },
        getSecond: function () {
            return this.second;
        },
        setSecond: function (value) {
            this.second = value;
            this.isFirst = false;
        },
        getIsFirst: function () {
            return this.isFirst;
        }
    });

    Bridge.define("SharpBindings.AnyBool", {
        statics: {
            op_Implicit: function (s) {
                var a = new SharpBindings.AnyBool();

                a.setFirst(s);

                return a;
            },
            op_Implicit$1: function (s) {
                var a = new SharpBindings.AnyBool();

                a.setSecond(s);

                return a;
            }
        },
        first: false,
        second: null,
        isFirst: false,
        getFirst: function () {
            return this.first;
        },
        setFirst: function (value) {
            this.first = value;
            this.isFirst = true;
        },
        getSecond: function () {
            return this.second;
        },
        setSecond: function (value) {
            this.second = value;
            this.isFirst = false;
        },
        getIsFirst: function () {
            return this.isFirst;
        }
    });

    Bridge.define("SharpBindings.AnyButtonType", {
        statics: {
            op_Implicit: function (s) {
                var a = new SharpBindings.AnyButtonType();

                a.setFirst(s);

                return a;
            },
            op_Implicit$1: function (s) {
                var a = new SharpBindings.AnyButtonType();

                a.setSecond(s);

                return a;
            }
        },
        first: "submit",
        second: null,
        isFirst: false,
        getFirst: function () {
            return this.first;
        },
        setFirst: function (value) {
            this.first = value;
            this.isFirst = true;
        },
        getSecond: function () {
            return this.second;
        },
        setSecond: function (value) {
            this.second = value;
            this.isFirst = false;
        },
        getIsFirst: function () {
            return this.isFirst;
        }
    });

    Bridge.define("SharpBindings.AnyDate", {
        statics: {
            op_Implicit: function (s) {
                var a = new SharpBindings.AnyDate();

                a.setFirst(s);

                return a;
            },
            op_Implicit$1: function (s) {
                var a = new SharpBindings.AnyDate();

                a.setSecond(s);

                return a;
            }
        },
        first: null,
        second: null,
        isFirst: false,
        getFirst: function () {
            return this.first;
        },
        setFirst: function (value) {
            this.first = value;
            this.isFirst = true;
        },
        getSecond: function () {
            return this.second;
        },
        setSecond: function (value) {
            this.second = value;
            this.isFirst = false;
        },
        getIsFirst: function () {
            return this.isFirst;
        }
    });

    Bridge.define("SharpBindings.AnyDouble", {
        statics: {
            op_Implicit: function (s) {
                var a = new SharpBindings.AnyDouble();

                a.setFirst(s);

                return a;
            },
            op_Implicit$1: function (s) {
                var a = new SharpBindings.AnyDouble();

                a.setSecond(s);

                return a;
            }
        },
        first: 0,
        second: null,
        isFirst: false,
        getFirst: function () {
            return this.first;
        },
        setFirst: function (value) {
            this.first = value;
            this.isFirst = true;
        },
        getSecond: function () {
            return this.second;
        },
        setSecond: function (value) {
            this.second = value;
            this.isFirst = false;
        },
        getIsFirst: function () {
            return this.isFirst;
        }
    });

    Bridge.define("SharpBindings.AnyHTMLTableCaptionElement", {
        statics: {
            op_Implicit: function (s) {
                var a = new SharpBindings.AnyHTMLTableCaptionElement();

                a.setFirst(s);

                return a;
            },
            op_Implicit$1: function (s) {
                var a = new SharpBindings.AnyHTMLTableCaptionElement();

                a.setSecond(s);

                return a;
            }
        },
        first: null,
        second: null,
        isFirst: false,
        getFirst: function () {
            return this.first;
        },
        setFirst: function (value) {
            this.first = value;
            this.isFirst = true;
        },
        getSecond: function () {
            return this.second;
        },
        setSecond: function (value) {
            this.second = value;
            this.isFirst = false;
        },
        getIsFirst: function () {
            return this.isFirst;
        }
    });

    Bridge.define("SharpBindings.AnyHTMLTableSectionElement", {
        statics: {
            op_Implicit: function (s) {
                var a = new SharpBindings.AnyHTMLTableSectionElement();

                a.setFirst(s);

                return a;
            },
            op_Implicit$1: function (s) {
                var a = new SharpBindings.AnyHTMLTableSectionElement();

                a.setSecond(s);

                return a;
            }
        },
        first: null,
        second: null,
        isFirst: false,
        getFirst: function () {
            return this.first;
        },
        setFirst: function (value) {
            this.first = value;
            this.isFirst = true;
        },
        getSecond: function () {
            return this.second;
        },
        setSecond: function (value) {
            this.second = value;
            this.isFirst = false;
        },
        getIsFirst: function () {
            return this.isFirst;
        }
    });

    Bridge.define("SharpBindings.AnyInputType", {
        statics: {
            op_Implicit: function (s) {
                var a = new SharpBindings.AnyInputType();

                a.setFirst(s);

                return a;
            },
            op_Implicit$1: function (s) {
                var a = new SharpBindings.AnyInputType();

                a.setSecond(s);

                return a;
            }
        },
        first: "button",
        second: null,
        isFirst: false,
        getFirst: function () {
            return this.first;
        },
        setFirst: function (value) {
            this.first = value;
            this.isFirst = true;
        },
        getSecond: function () {
            return this.second;
        },
        setSecond: function (value) {
            this.second = value;
            this.isFirst = false;
        },
        getIsFirst: function () {
            return this.isFirst;
        }
    });

    Bridge.define("SharpBindings.AnyInt", {
        statics: {
            op_Implicit$1: function (s) {
                var a = new SharpBindings.AnyInt();

                a.setFirst(s);

                return a;
            },
            op_Implicit: function (s) {
                var a = new SharpBindings.AnyInt();

                a.setSecond(s);

                return a;
            }
        },
        first: 0,
        second: null,
        isFirst: false,
        getFirst: function () {
            return this.first;
        },
        setFirst: function (value) {
            this.first = value;
            this.isFirst = true;
        },
        getSecond: function () {
            return this.second;
        },
        setSecond: function (value) {
            this.second = value;
            this.isFirst = false;
        },
        getIsFirst: function () {
            return this.isFirst;
        }
    });

    Bridge.define("SharpBindings.AnyString", {
        statics: {
            op_Implicit$1: function (s) {
                var a = new SharpBindings.AnyString();

                a.setFirst(s);

                return a;
            },
            op_Implicit: function (s) {
                var a = new SharpBindings.AnyString();

                a.setSecond(s);

                return a;
            }
        },
        first: null,
        second: null,
        isFirst: false,
        getFirst: function () {
            return this.first;
        },
        setFirst: function (value) {
            this.first = value;
            this.isFirst = true;
        },
        getSecond: function () {
            return this.second;
        },
        setSecond: function (value) {
            this.second = value;
            this.isFirst = false;
        },
        getIsFirst: function () {
            return this.isFirst;
        }
    });

    Bridge.define("SharpBindings.AnyWrap", {
        statics: {
            op_Implicit: function (s) {
                var a = new SharpBindings.AnyWrap();

                a.setFirst(s);

                return a;
            },
            op_Implicit$1: function (s) {
                var a = new SharpBindings.AnyWrap();

                a.setSecond(s);

                return a;
            }
        },
        first: "hard",
        second: null,
        isFirst: false,
        getFirst: function () {
            return this.first;
        },
        setFirst: function (value) {
            this.first = value;
            this.isFirst = true;
        },
        getSecond: function () {
            return this.second;
        },
        setSecond: function (value) {
            this.second = value;
            this.isFirst = false;
        },
        getIsFirst: function () {
            return this.isFirst;
        }
    });

    Bridge.define("SharpBindings.IAttributes", {
        $kind: "interface"
    });

    Bridge.define("SharpBindings.Cell", {
        statics: {
            noNotification: null,
            config: {
                init: function () {
                    this.noNotification = new Rx.Subject().asObservable();
                }
            },
            op_Implicit: function (value) {
                return new SharpBindings.Cell(function () {
                    return value;
                }, SharpBindings.Cell.noNotification);
            }
        },
        source: null,
        notifier: null,
        current: null,
        subject: null,
        ctor: function (_source, _notifier) {
            this.$initialize();
            this.source = _source;

            this.notifier = _notifier;

            this.current = this.source();

            this.subject = new Rx.Subject();

            _notifier.subscribe(Bridge.fn.bind(this, $asm.$.SharpBindings.Cell.f1));
        },
        getObservable: function () {
            return this.subject.asObservable().startWith(this.current);
        }
    });

    Bridge.ns("SharpBindings.Cell", $asm.$);

    Bridge.apply($asm.$.SharpBindings.Cell, {
        f1: function (_) {

            var p = this.source();

            if (this.current != null && Bridge.equals(this.current, p)) {
                return;
            } else if (this.current == null && p == null) {
                return;
            }

            this.current = p;

            this.subject.next(this.current);
        }
    });

    Bridge.define("SharpBindings.HtmlUtil", {
        statics: {
            appendChildElements: function (parent, children) {
                Bridge.Linq.Enumerable.from(children).forEach(function (a) {
                        parent.appendChild(a);
                    });
            },
            clear: function (element) {
                while (element.lastChild != null) {
                    element.removeChild(element.lastChild);
                }
            },
            initElement: function (T, element, init, children) {
                if (children === void 0) { children = []; }
                init != null ? init.SharpBindings$IAttributes$initElement(element) : null;

                SharpBindings.HtmlUtil.appendChildElements(element, children);

                return element;
            },
            text: function (text) {
                return document.createTextNode(text);
            },
            div: function (init, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.initElement(HTMLDivElement, document.createElement('div'), init, children);
            },
            span: function (init, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.initElement(HTMLSpanElement, document.createElement('span'), init, children);
            },
            p: function (init, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.initElement(HTMLParagraphElement, document.createElement('p'), init, children);
            },
            pre: function (init, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.initElement(HTMLPreElement, document.createElement('pre'), init, children);
            },
            strong: function (init, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.initElement(HTMLElement, document.createElement("strong"), init, children);
            },
            br: function (init) {
                return SharpBindings.HtmlUtil.initElement(HTMLBRElement, document.createElement('br'), init);
            },
            ol: function (init, children) {
                if (children === void 0) { children = []; }
                var a = document.createElement('ol');

                //init.InitOListElement(a);

                SharpBindings.HtmlUtil.appendChildElements(a, children);

                return a;
            },
            ul: function (init, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.initElement(HTMLUListElement, document.createElement('ul'), init, children);
            },
            li: function (init, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.initElement(HTMLLIElement, document.createElement('li'), init, children);
            },
            main: function (init, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.initElement(HTMLElement, document.createElement("main"), init, children);
            },
            header: function (init, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.initElement(HTMLElement, document.createElement("header"), init, children);
            },
            footer: function (init, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.initElement(HTMLElement, document.createElement("footer"), init, children);
            },
            section: function (init, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.initElement(HTMLElement, document.createElement("section"), init, children);
            },
            nav: function (init, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.initElement(HTMLElement, document.createElement("nav"), init, children);
            },
            HR: function (init) {
                return SharpBindings.HtmlUtil.initElement(HTMLHRElement, document.createElement('hr'), init);
            },
            a: function (init, children) {
                if (children === void 0) { children = []; }
                var a = document.createElement('a');

                init.SharpBindings$IAttributes$initAnchorElement(a);

                SharpBindings.HtmlUtil.appendChildElements(a, children);

                return a;
            },
            image: function (init) {
                var a = new Image();

                init.SharpBindings$IAttributes$initImageElement(a);

                return a;
            },
            canvas: function (init) {
                var a = document.createElement('canvas');

                init.SharpBindings$IAttributes$initCanvasElement(a);

                return a;
            },
            h: function (init, type, children) {
                if (children === void 0) { children = []; }
                var h = document.createElement(type);

                init.SharpBindings$IAttributes$initElement(h);

                SharpBindings.HtmlUtil.appendChildElements(h, children);

                return h;
            },
            H1: function (a, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.h(a, "h1", children);
            },
            H2: function (a, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.h(a, "h2", children);
            },
            H3: function (a, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.h(a, "h3", children);
            },
            H4: function (a, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.h(a, "h4", children);
            },
            H5: function (a, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.h(a, "h5", children);
            },
            H6: function (a, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.h(a, "h6", children);
            },
            form: function (init, children) {
                if (children === void 0) { children = []; }
                var f = document.createElement('form');

                init.SharpBindings$IAttributes$initFormElement(f);

                SharpBindings.HtmlUtil.appendChildElements(f, children);

                return f;
            },
            fieldSet: function (init, children) {
                if (children === void 0) { children = []; }
                var f = document.createElement('fieldset');

                init.SharpBindings$IAttributes$initFieldSetElement(f);

                SharpBindings.HtmlUtil.appendChildElements(f, children);

                return f;
            },
            optGroup: function (init, children) {
                if (children === void 0) { children = []; }
                var f = document.createElement('optgroup');

                init.SharpBindings$IAttributes$initOptGroupElement(f);

                SharpBindings.HtmlUtil.appendChildElements(f, children);

                return f;
            },
            option: function (init) {

                var f = document.createElement('option');

                init.SharpBindings$IAttributes$initOptionElement(f);

                return f;
            },
            legend: function (init, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.initElement(HTMLLegendElement, document.createElement('legend'), init, children);

            },
            button: function (init, children) {
                if (children === void 0) { children = []; }
                var f = document.createElement('button');

                init.SharpBindings$IAttributes$initButtonElement(f);

                SharpBindings.HtmlUtil.appendChildElements(f, children);

                return f;
            },
            select: function (init, children) {
                if (children === void 0) { children = []; }
                var f = document.createElement('select');

                init.SharpBindings$IAttributes$initSelectElement(f);

                SharpBindings.HtmlUtil.appendChildElements(f, children);

                return f;
            },
            dataList: function (init, children) {
                if (children === void 0) { children = []; }
                var f = document.createElement('datalist');

                SharpBindings.HtmlUtil.appendChildElements(f, children);

                return f;
            },
            textBox: function (init) {

                var f = document.createElement('input');

                init.SharpBindings$IAttributes$initInputElement(f);

                return f;
            },
            checkBox: function (init) {

                var input = document.createElement('input');

                input.type = "checkbox";

                init.SharpBindings$IAttributes$initInputElement(input);

                return input;
            },
            radioButton: function (init) {

                var input = document.createElement('input');

                input.type = "radio";

                init.SharpBindings$IAttributes$initInputElement(input);

                return input;
            },
            textArea: function (init) {
                var a = document.createElement('textarea');

                init.SharpBindings$IAttributes$initTextAreaElement(a);

                return a;
            },
            label: function (init) {
                var label = document.createElement('label');

                init.SharpBindings$IAttributes$initLabelElement(label);

                return label;
            },
            table: function (init, children) {
                if (children === void 0) { children = []; }
                var table = document.createElement('table');

                init.SharpBindings$IAttributes$initTableElement(table);

                SharpBindings.HtmlUtil.appendChildElements(table, children);

                return table;
            },
            caption: function (init, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.initElement(HTMLTableCaptionElement, document.createElement('caption'), init, children);
            },
            tHeader: function (init, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.initElement(HTMLTableSectionElement, document.createElement('tbody'), init, children);
            },
            tBody: function (init, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.initElement(HTMLTableSectionElement, document.createElement('tbody'), init, children);
            },
            tFooter: function (init, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.initElement(HTMLTableSectionElement, document.createElement('tbody'), init, children);
            },
            tRow: function (init, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.initElement(HTMLTableRowElement, document.createElement('tr'), init, children);
            },
            tRow$1: function (init, children) {
                if (children === void 0) { children = []; }
                return SharpBindings.HtmlUtil.initElement(HTMLTableRowElement, document.createElement('tr'), init, children);
            },
            td: function (init, children) {
                if (children === void 0) { children = []; }
                var f = document.createElement('td');

                init.SharpBindings$IAttributes$initTableDataCellElement(f);

                SharpBindings.HtmlUtil.appendChildElements(f, children);

                return f;
            },
            th: function (init, children) {
                if (children === void 0) { children = []; }
                var f = document.createElement('th');

                init.SharpBindings$IAttributes$initTableHeaderCellElement(f);

                SharpBindings.HtmlUtil.appendChildElements(f, children);

                return f;
            },
            iFrame: function (init, children) {
                if (children === void 0) { children = []; }
                var a = document.createElement('iframe');

                init.SharpBindings$IAttributes$initIFrameElement(a);

                SharpBindings.HtmlUtil.appendChildElements(a, children);

                return a;
            },
            toObservable: function (source) {
                var s = new Rx.Subject();

                var obj = {  };

                // need to provide for unsubscription
                source.System$ComponentModel$INotifyPropertyChanged$addPropertyChanged(function (_, __) {
                    s.next(obj);
                });

                return s.asObservable();
            },
            isChecked: function (e) {

                return Bridge.cast(e.target, HTMLInputElement).checked;
            },
            value: function (e) {
                return Bridge.cast(e.target, HTMLInputElement).value;
            },
            setValue: function (e, value) {
                Bridge.cast(e, HTMLInputElement).value = value;
            },
            getRouting: function () {
                var routing = new Rx.Subject();

                window.onhashchange = Bridge.fn.combine(window.onhashchange, function (_) {
                    routing.next(window.location.hash);
                });

                return routing.startWith(window.location.hash);
            }
        }
    });

    Bridge.define("SharpBindings.NoNotification", {
        inherits: [System.ComponentModel.INotifyPropertyChanged],
        statics: {
            instance: null,
            config: {
                init: function () {
                    this.instance = new SharpBindings.NoNotification();
                }
            }
        },
        config: {
            events: {
                PropertyChanged: null
            },
            alias: [
            "addPropertyChanged", "System$ComponentModel$INotifyPropertyChanged$addPropertyChanged",
            "removePropertyChanged", "System$ComponentModel$INotifyPropertyChanged$removePropertyChanged"
            ]
        },
        ctor: function () {
            this.$initialize();
        }
    });

    Bridge.define("SharpBindings.ObservableCollection$1", function (T) { return {
        inherits: [System.Collections.Generic.IEnumerable$1(T),System.Collections.Generic.ICollection$1(T),System.ComponentModel.INotifyPropertyChanged],
        statics: {
            op_Implicit: function (collection) {
                return SharpBindings.HtmlUtil.toObservable(collection);
            }
        },
        list: null,
        added: null,
        removed: null,
        replaced: null,
        config: {
            events: {
                PropertyChanged: null
            },
            alias: [
            "addPropertyChanged", "System$ComponentModel$INotifyPropertyChanged$addPropertyChanged",
            "removePropertyChanged", "System$ComponentModel$INotifyPropertyChanged$removePropertyChanged",
            "getCount", "System$Collections$Generic$ICollection$1$" + Bridge.getTypeAlias(T) + "$getCount",
            "getIsReadOnly", "System$Collections$Generic$ICollection$1$" + Bridge.getTypeAlias(T) + "$getIsReadOnly",
            "add", "System$Collections$Generic$ICollection$1$" + Bridge.getTypeAlias(T) + "$add",
            "remove", "System$Collections$Generic$ICollection$1$" + Bridge.getTypeAlias(T) + "$remove",
            "clear", "System$Collections$Generic$ICollection$1$" + Bridge.getTypeAlias(T) + "$clear",
            "getEnumerator", "System$Collections$Generic$IEnumerable$1$" + Bridge.getTypeAlias(T) + "$getEnumerator",
            "copyTo", "System$Collections$Generic$ICollection$1$" + Bridge.getTypeAlias(T) + "$copyTo",
            "contains", "System$Collections$Generic$ICollection$1$" + Bridge.getTypeAlias(T) + "$contains"
            ],
            init: function () {
                this.list = new (System.Collections.Generic.List$1(T))();
                this.added = new Rx.Subject();
                this.removed = new Rx.Subject();
                this.replaced = new Rx.Subject();
            }
        },
        getCount: function () {
            return this.list.getCount();
        },
        getIsReadOnly: function () {
            return false;
        },
        getItem: function (index) {
            return this.list.getItem(index);
        },
        setItem: function (index, value) {
            var old = this.list.getItem(index);

            this.list.setItem(index, value);

            this.replaced.next({ item1: old, item2: value });

            this.unSubscribe(old);

            this.subscribe(value);

            this.raisePropertyChanged();
        },
        getAdded: function () {
            return this.added.asObservable();
        },
        getRemoved: function () {
            return this.removed.asObservable();
        },
        add: function (item) {
            this.list.add(item);

            this.added.next(System.Array.init([item], T));

            this.subscribe(item);

            this.raisePropertyChanged();
        },
        remove: function (item) {
            var isRemoved = this.list.remove(item);

            if (!isRemoved) {
                return false;
            }

            this.removed.next(System.Array.init([item], T));

            this.unSubscribe(item);

            this.raisePropertyChanged();

            return isRemoved;
        },
        clear: function () {
            var items = this.list.toArray();

            this.list.clear();

            this.removed.next(items);
            items.forEach(Bridge.fn.bind(this, function (i) {
                    this.unSubscribe(i);
                }));

            this.raisePropertyChanged();
        },
        subscribe: function (item) {
            var a = (Bridge.as(item, System.ComponentModel.INotifyPropertyChanged));

            if (a != null) {
                a.System$ComponentModel$INotifyPropertyChanged$addPropertyChanged(Bridge.fn.cacheBind(this, this.itemChanged));
            }
        },
        unSubscribe: function (item) {
            var a = (Bridge.as(item, System.ComponentModel.INotifyPropertyChanged));

            if (a != null) {
                a.System$ComponentModel$INotifyPropertyChanged$removePropertyChanged(Bridge.fn.cacheBind(this, this.itemChanged));
            }
        },
        itemChanged: function (sender, e) {
            this.raisePropertyChanged();
        },
        raisePropertyChanged: function () {
            !Bridge.staticEquals(this.PropertyChanged, null) ? this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(null, null)) : null;
        },
        getEnumerator: function () {
            return this.list.getEnumerator();
        },
        System$Collections$IEnumerable$getEnumerator: function () {
            return this.list.getEnumerator();
        },
        copyTo: function (array, arrayIndex) {
            this.list.copyTo(array, arrayIndex);
        },
        contains: function (item) {
            return this.list.contains(item);
        }
    }; });

    Bridge.define("SharpBindings.Var$1", function (T) { return {
        inherits: [System.ComponentModel.INotifyPropertyChanged],
        statics: {
            op_Implicit: function (v) {
                return SharpBindings.HtmlUtil.toObservable(v);
            }
        },
        val: Bridge.getDefaultValue(T),
        config: {
            events: {
                PropertyChanged: null
            },
            alias: [
            "addPropertyChanged", "System$ComponentModel$INotifyPropertyChanged$addPropertyChanged",
            "removePropertyChanged", "System$ComponentModel$INotifyPropertyChanged$removePropertyChanged"
            ]
        },
        ctor: function (val) {
            this.$initialize();
            this.val = val;
        },
        getValue: function () {
            return this.val;
        },
        setValue: function (value) {
            if (System.Collections.Generic.EqualityComparer$1(T).def.equals2(value, this.val)) {
                return;
            }

            this.val = value;
            !Bridge.staticEquals(this.PropertyChanged, null) ? this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("Value", this.val)) : null;
        }
    }; });

    Bridge.define("SharpBindings.Attributes$1", function (T) { return {
        inherits: [SharpBindings.IAttributes],
        config: {
            properties: {
                ClassName: null,
                Id: null,
                ScrollLeft: null,
                ScrollTop: null,
                AccessKey: null,
                ContentEditable: null,
                Dir: null,
                Lang: null,
                TabIndex: null,
                Title: null,
                OnCopy: null,
                OnCut: null,
                OnPaste: null,
                OnAbort: null,
                OnBlur: null,
                OnError: null,
                OnFocus: null,
                OnCancel: null,
                OnCanPlay: null,
                OnCanPlayThrough: null,
                OnChange: null,
                OnClick: null,
                OnClose: null,
                OnContextMenu: null,
                OnCueChange: null,
                OnDblClick: null,
                OnDrag: null,
                OnDragEnd: null,
                OnDragEnter: null,
                OnDragExit: null,
                OnDragLeave: null,
                OnDragOver: null,
                OnDragStart: null,
                OnDrop: null,
                OnDurationChange: null,
                OnEmptied: null,
                OnEnded: null,
                OnInput: null,
                OnInvalid: null,
                OnKeyDown: null,
                OnKeyPress: null,
                OnKeyUp: null,
                OnLoad: null,
                OnLoadedData: null,
                OnLoadedMetaData: null,
                OnLoadStart: null,
                OnMouseDown: null,
                OnMouseEnter: null,
                OnMouseLeave: null,
                OnMouseMove: null,
                OnMouseOut: null,
                OnMouseOver: null,
                OnMouseUp: null,
                OnMouseWheel: null,
                OnPause: null,
                OnPlay: null,
                OnPlaying: null,
                OnProgress: null,
                OnRateChange: null,
                OnReset: null,
                OnScroll: null,
                OnSeeked: null,
                OnSeeking: null,
                OnSelect: null,
                OnShow: null,
                OnSort: null,
                OnStalled: null,
                OnSubmit: null,
                OnSuspend: null,
                OnTimeUpdate: null,
                OnVolumeChange: null,
                OnWaiting: null,
                OnTouchStart: null,
                OnTouchEnd: null,
                OnTouchMove: null,
                OnTouchEnter: null,
                OnTouchLeave: null,
                OnTouchCancel: null,
                Charset: null,
                Coords: null,
                Download: null,
                Hash: null,
                Host: null,
                Hostname: null,
                Href: null,
                Hreflang: null,
                Media: null,
                Name: null,
                Password: null,
                Pathname: null,
                Port: null,
                Protocol: null,
                Rel: null,
                Rev: null,
                Search: null,
                SearchParams: null,
                Shape: null,
                Target: null,
                Text: null,
                Type: null,
                Username: null,
                AutoFocus: null,
                Disabled: null,
                FormAction: null,
                FormEncType: null,
                FormMethod: null,
                FormNoValidate: null,
                FormTarget: null,
                ButtonType: null,
                Value: null,
                AcceptCharset: null,
                Action: null,
                AutoComplete: null,
                Encoding: null,
                Enctype: null,
                Method: null,
                NoValidate: null,
                CrossOrigin: null,
                ImageHeight: null,
                IsMap: null,
                Src: null,
                SrcSet: null,
                UseMap: null,
                ImageWidth: null,
                Accept: null,
                Alt: null,
                AutoSave: null,
                Checked: null,
                DefaultChecked: null,
                DefaultValue: null,
                Indeterminate: null,
                List: null,
                Max: null,
                MaxLength: null,
                Min: null,
                Multiple: null,
                Pattern: null,
                Placeholder: null,
                ReadOnly: null,
                Required: null,
                SelectionDirection: null,
                SelectionEnd: null,
                SelectionStart: null,
                Step: null,
                InputType: null,
                HtmlFor: null,
                AllowFullScreen: null,
                FrameBorder: null,
                IFrameHeight: null,
                LongDesc: null,
                IFrameMarginHeight: null,
                IFrameMarginWidth: null,
                Scrolling: null,
                Seamless: null,
                SrcDoc: null,
                IFrameWidth: null,
                Label: null,
                DefaultSelected: null,
                Disable: null,
                Selected: null,
                SelectedIndex: null,
                Size: null,
                Cols: null,
                Rows: null,
                Wrap: null,
                Span: null,
                ColSpan: null,
                RowSpan: null,
                CellIndex: null,
                Abbr: null,
                Caption: null,
                THead: null,
                TFoot: null,
                CanvasHeight: null,
                CanvasWidth: null,
                Items: null,
                Template: null,
                Trigger: null,
                OnTrigger: null
            },
            alias: [
            "bindTemplate", "SharpBindings$IAttributes$bindTemplate",
            "initElement", "SharpBindings$IAttributes$initElement",
            "initCanvasElement", "SharpBindings$IAttributes$initCanvasElement",
            "initAnchorElement", "SharpBindings$IAttributes$initAnchorElement",
            "initButtonElement", "SharpBindings$IAttributes$initButtonElement",
            "initFormElement", "SharpBindings$IAttributes$initFormElement",
            "initImageElement", "SharpBindings$IAttributes$initImageElement",
            "initInputElement", "SharpBindings$IAttributes$initInputElement",
            "initLabelElement", "SharpBindings$IAttributes$initLabelElement",
            "initFieldSetElement", "SharpBindings$IAttributes$initFieldSetElement",
            "initIFrameElement", "SharpBindings$IAttributes$initIFrameElement",
            "initOptGroupElement", "SharpBindings$IAttributes$initOptGroupElement",
            "initOptionElement", "SharpBindings$IAttributes$initOptionElement",
            "initSelectElement", "SharpBindings$IAttributes$initSelectElement",
            "initTextAreaElement", "SharpBindings$IAttributes$initTextAreaElement",
            "initTableDataCellElement", "SharpBindings$IAttributes$initTableDataCellElement",
            "initTableHeaderCellElement", "SharpBindings$IAttributes$initTableHeaderCellElement",
            "initTableElement", "SharpBindings$IAttributes$initTableElement"
            ]
        },
        bindTemplate: function (element) {
            var $t, $t1;
            if (this.getItems() == null || Bridge.staticEquals(this.getTemplate(), null)) {
                return;
            }

            var onRemove = new (System.Collections.Generic.Dictionary$2(T,Function))();

            var load = Bridge.fn.bind(this, function (vals) {
                var $t;
                $t = Bridge.getEnumerator(vals, T);
                while ($t.moveNext()) {
                    (function () {
                        var a = $t.getCurrent();
                        var b = this.getTemplate()(a);

                        element.appendChild(b);

                        onRemove.set(a, function () {
                            element.removeChild(b);

                            onRemove.remove(a);
                        });
                    }).call(this);
                }
            });
            ($t = (Bridge.as(this.getItems(), SharpBindings.ObservableCollection$1(T)))) != null ? $t.getAdded().subscribe(function (added) {
                    load(added);
                }) : null;
            ($t1 = (Bridge.as(this.getItems(), SharpBindings.ObservableCollection$1(T)))) != null ? $t1.getRemoved().subscribe(function (removed) {
                    removed.forEach(function (a) {
                            onRemove.get(a)();
                        });
                }) : null;

            load(this.getItems());
        },
        initElement: function (element) {
            var $t, $t1, $t2, $t3, $t4, $t5, $t6, $t7, $t8;
            // remember to remove automated text binding
            var currentText = null;
            ($t = this.getText()) != null ? $t.getObservable().subscribe(function (t) {
                    var n = document.createTextNode(Bridge.cast(t, String));

                    if (currentText != null) {
                        element.replaceChild(n, currentText);
                    } else {
                        element.appendChild(n);
                    }

                    currentText = n;
















                }) : null;
            ($t1 = this.getClassName()) != null ? $t1.getObservable().subscribe(function (a) {
                    element.className = Bridge.cast(a, String);
                }) : null;
            ($t2 = this.getAccessKey()) != null ? $t2.getObservable().subscribe(function (a) {
                    element.accessKey = Bridge.cast(a, String);
                }) : null;
            ($t3 = this.getContentEditable()) != null ? $t3.getObservable().subscribe(function (a) {
                    element.contentEditable = Bridge.cast(a, String);
                }) : null;
            ($t4 = this.getDir()) != null ? $t4.getObservable().subscribe(function (a) {
                    element.dir = Bridge.cast(a, String);
                }) : null;
            ($t5 = this.getLang()) != null ? $t5.getObservable().subscribe(function (a) {
                    element.lang = Bridge.cast(a, String);
                }) : null;
            ($t6 = this.getTabIndex()) != null ? $t6.getObservable().subscribe(function (a) {
                    element.tabIndex = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                }) : null;
            ($t7 = this.getTitle()) != null ? $t7.getObservable().subscribe(function (a) {
                    element.title = Bridge.cast(a, String);
                }) : null;
            element.oncopy = this.getOnCopy();
            element.oncut = this.getOnCut();
            element.onpaste = this.getOnPaste();
            element.onabort = this.getOnAbort();
            element.onblur = this.getOnBlur();
            //if (OnError != null) { element.OnError += OnError; }
            if (!Bridge.staticEquals(this.getOnFocus(), null)) {
                element.onfocus = Bridge.fn.combine(element.onfocus, this.getOnFocus());
            }
            if (!Bridge.staticEquals(this.getOnCancel(), null)) {
                element.oncancel = Bridge.fn.combine(element.oncancel, this.getOnCancel());
            }
            if (!Bridge.staticEquals(this.getOnCanPlay(), null)) {
                element.oncanplay = Bridge.fn.combine(element.oncanplay, this.getOnCanPlay());
            }
            if (!Bridge.staticEquals(this.getOnCanPlayThrough(), null)) {
                element.oncanplaythrough = Bridge.fn.combine(element.oncanplaythrough, this.getOnCanPlayThrough());
            }
            if (!Bridge.staticEquals(this.getOnChange(), null)) {
                element.onchange = Bridge.fn.combine(element.onchange, this.getOnChange());
            }
            if (!Bridge.staticEquals(this.getOnClick(), null)) {
                element.onclick = Bridge.fn.combine(element.onclick, this.getOnClick());
            }
            if (!Bridge.staticEquals(this.getOnClose(), null)) {
                element.onclose = Bridge.fn.combine(element.onclose, this.getOnClose());
            }
            if (!Bridge.staticEquals(this.getOnContextMenu(), null)) {
                element.oncontextmenu = Bridge.fn.combine(element.oncontextmenu, this.getOnContextMenu());
            }
            if (!Bridge.staticEquals(this.getOnCueChange(), null)) {
                element.oncuechange = Bridge.fn.combine(element.oncuechange, this.getOnCueChange());
            }
            if (!Bridge.staticEquals(this.getOnDblClick(), null)) {
                element.ondblclick = Bridge.fn.combine(element.ondblclick, this.getOnDblClick());
            }
            if (!Bridge.staticEquals(this.getOnDrag(), null)) {
                element.ondrag = Bridge.fn.combine(element.ondrag, this.getOnDrag());
            }
            if (!Bridge.staticEquals(this.getOnDragEnd(), null)) {
                element.ondragend = Bridge.fn.combine(element.ondragend, this.getOnDragEnd());
            }
            if (!Bridge.staticEquals(this.getOnDragEnter(), null)) {
                element.ondragenter = Bridge.fn.combine(element.ondragenter, this.getOnDragEnter());
            }
            if (!Bridge.staticEquals(this.getOnDragExit(), null)) {
                element.ondragexit = Bridge.fn.combine(element.ondragexit, this.getOnDragExit());
            }
            if (!Bridge.staticEquals(this.getOnDragLeave(), null)) {
                element.ondragleave = Bridge.fn.combine(element.ondragleave, this.getOnDragLeave());
            }
            if (!Bridge.staticEquals(this.getOnDragOver(), null)) {
                element.ondragover = Bridge.fn.combine(element.ondragover, this.getOnDragOver());
            }
            if (!Bridge.staticEquals(this.getOnDragStart(), null)) {
                element.ondragstart = Bridge.fn.combine(element.ondragstart, this.getOnDragStart());
            }
            if (!Bridge.staticEquals(this.getOnDrop(), null)) {
                element.ondrop = Bridge.fn.combine(element.ondrop, this.getOnDrop());
            }
            if (!Bridge.staticEquals(this.getOnDurationChange(), null)) {
                element.ondurationchange = Bridge.fn.combine(element.ondurationchange, this.getOnDurationChange());
            }
            if (!Bridge.staticEquals(this.getOnEmptied(), null)) {
                element.onemptied = Bridge.fn.combine(element.onemptied, this.getOnEmptied());
            }
            if (!Bridge.staticEquals(this.getOnEnded(), null)) {
                element.onended = Bridge.fn.combine(element.onended, this.getOnEnded());
            }
            if (!Bridge.staticEquals(this.getOnInput(), null)) {
                element.oninput = Bridge.fn.combine(element.oninput, this.getOnInput());
            }
            if (!Bridge.staticEquals(this.getOnInvalid(), null)) {
                element.oninvalid = Bridge.fn.combine(element.oninvalid, this.getOnInvalid());
            }
            if (!Bridge.staticEquals(this.getOnKeyDown(), null)) {
                element.onkeydown = Bridge.fn.combine(element.onkeydown, this.getOnKeyDown());
            }
            if (!Bridge.staticEquals(this.getOnKeyPress(), null)) {
                element.onkeypress = Bridge.fn.combine(element.onkeypress, this.getOnKeyPress());
            }
            if (!Bridge.staticEquals(this.getOnKeyUp(), null)) {
                element.onkeyup = Bridge.fn.combine(element.onkeyup, this.getOnKeyUp());
            }
            if (!Bridge.staticEquals(this.getOnLoad(), null)) {
                element.onload = Bridge.fn.combine(element.onload, this.getOnLoad());
            }
            if (!Bridge.staticEquals(this.getOnLoadedData(), null)) {
                element.onloadeddata = Bridge.fn.combine(element.onloadeddata, this.getOnLoadedData());
            }
            if (!Bridge.staticEquals(this.getOnLoadedMetaData(), null)) {
                element.onloadedmetadata = Bridge.fn.combine(element.onloadedmetadata, this.getOnLoadedMetaData());
            }
            if (!Bridge.staticEquals(this.getOnLoadStart(), null)) {
                element.onloadstart = Bridge.fn.combine(element.onloadstart, this.getOnLoadStart());
            }
            if (!Bridge.staticEquals(this.getOnMouseDown(), null)) {
                element.onmousedown = Bridge.fn.combine(element.onmousedown, this.getOnMouseDown());
            }
            if (!Bridge.staticEquals(this.getOnMouseEnter(), null)) {
                element.onmouseenter = Bridge.fn.combine(element.onmouseenter, this.getOnMouseEnter());
            }
            if (!Bridge.staticEquals(this.getOnMouseLeave(), null)) {
                element.onmouseleave = Bridge.fn.combine(element.onmouseleave, this.getOnMouseLeave());
            }
            if (!Bridge.staticEquals(this.getOnMouseMove(), null)) {
                element.onmousemove = Bridge.fn.combine(element.onmousemove, this.getOnMouseMove());
            }
            if (!Bridge.staticEquals(this.getOnMouseOut(), null)) {
                element.onmouseout = Bridge.fn.combine(element.onmouseout, this.getOnMouseOut());
            }
            if (!Bridge.staticEquals(this.getOnMouseOver(), null)) {
                element.onmouseover = Bridge.fn.combine(element.onmouseover, this.getOnMouseOver());
            }
            if (!Bridge.staticEquals(this.getOnMouseUp(), null)) {
                element.onmouseup = Bridge.fn.combine(element.onmouseup, this.getOnMouseUp());
            }
            if (!Bridge.staticEquals(this.getOnMouseWheel(), null)) {
                element.onmousewheel = Bridge.fn.combine(element.onmousewheel, this.getOnMouseWheel());
            }
            if (!Bridge.staticEquals(this.getOnPause(), null)) {
                element.onpause = Bridge.fn.combine(element.onpause, this.getOnPause());
            }
            if (!Bridge.staticEquals(this.getOnPlay(), null)) {
                element.onplay = Bridge.fn.combine(element.onplay, this.getOnPlay());
            }
            if (!Bridge.staticEquals(this.getOnPlaying(), null)) {
                element.onplaying = Bridge.fn.combine(element.onplaying, this.getOnPlaying());
            }
            if (!Bridge.staticEquals(this.getOnProgress(), null)) {
                element.onprogress = Bridge.fn.combine(element.onprogress, this.getOnProgress());
            }
            if (!Bridge.staticEquals(this.getOnRateChange(), null)) {
                element.onratechange = Bridge.fn.combine(element.onratechange, this.getOnRateChange());
            }
            if (!Bridge.staticEquals(this.getOnReset(), null)) {
                element.onreset = Bridge.fn.combine(element.onreset, this.getOnReset());
            }
            if (!Bridge.staticEquals(this.getOnScroll(), null)) {
                element.onscroll = Bridge.fn.combine(element.onscroll, this.getOnScroll());
            }
            if (!Bridge.staticEquals(this.getOnSeeked(), null)) {
                element.onseeked = Bridge.fn.combine(element.onseeked, this.getOnSeeked());
            }
            if (!Bridge.staticEquals(this.getOnSeeking(), null)) {
                element.onseeking = Bridge.fn.combine(element.onseeking, this.getOnSeeking());
            }
            if (!Bridge.staticEquals(this.getOnSelect(), null)) {
                element.onselect = Bridge.fn.combine(element.onselect, this.getOnSelect());
            }
            if (!Bridge.staticEquals(this.getOnShow(), null)) {
                element.onshow = Bridge.fn.combine(element.onshow, this.getOnShow());
            }
            if (!Bridge.staticEquals(this.getOnSort(), null)) {
                element.onsort = Bridge.fn.combine(element.onsort, this.getOnSort());
            }
            if (!Bridge.staticEquals(this.getOnStalled(), null)) {
                element.onstalled = Bridge.fn.combine(element.onstalled, this.getOnStalled());
            }
            if (!Bridge.staticEquals(this.getOnSubmit(), null)) {
                element.onsubmit = Bridge.fn.combine(element.onsubmit, this.getOnSubmit());
            }
            if (!Bridge.staticEquals(this.getOnSuspend(), null)) {
                element.onsuspend = Bridge.fn.combine(element.onsuspend, this.getOnSuspend());
            }
            if (!Bridge.staticEquals(this.getOnTimeUpdate(), null)) {
                element.ontimeupdate = Bridge.fn.combine(element.ontimeupdate, this.getOnTimeUpdate());
            }
            if (!Bridge.staticEquals(this.getOnVolumeChange(), null)) {
                element.onvolumechange = Bridge.fn.combine(element.onvolumechange, this.getOnVolumeChange());
            }
            if (!Bridge.staticEquals(this.getOnWaiting(), null)) {
                element.onwaiting = Bridge.fn.combine(element.onwaiting, this.getOnWaiting());
            }
            if (!Bridge.staticEquals(this.getOnTouchStart(), null)) {
                element.ontouchstart = Bridge.fn.combine(element.ontouchstart, this.getOnTouchStart());
            }
            if (!Bridge.staticEquals(this.getOnTouchEnd(), null)) {
                element.ontouchend = Bridge.fn.combine(element.ontouchend, this.getOnTouchEnd());
            }
            if (!Bridge.staticEquals(this.getOnTouchMove(), null)) {
                element.ontouchmove = Bridge.fn.combine(element.ontouchmove, this.getOnTouchMove());
            }
            if (!Bridge.staticEquals(this.getOnTouchEnter(), null)) {
                element.ontouchenter = Bridge.fn.combine(element.ontouchenter, this.getOnTouchEnter());
            }
            if (!Bridge.staticEquals(this.getOnTouchLeave(), null)) {
                element.ontouchleave = Bridge.fn.combine(element.ontouchleave, this.getOnTouchLeave());
            }
            if (!Bridge.staticEquals(this.getOnTouchCancel(), null)) {
                element.ontouchcancel = Bridge.fn.combine(element.ontouchcancel, this.getOnTouchCancel());
            }
            ($t8 = this.getTrigger()) != null ? $t8.subscribe(Bridge.fn.bind(this, function (_) {
                    var $t9;
                    !Bridge.staticEquals(($t9 = this.getOnTrigger()), null) ? $t9(element) : null;
                })) : null;

            this.bindTemplate(element);
        },
        initCanvasElement: function (element) {
            var $t, $t1;
            this.initElement(element);
            ($t = this.getCanvasHeight()) != null ? $t.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.height !== b) {
                        element.height = b;
                    }
                }) : null;
            ($t1 = this.getCanvasWidth()) != null ? $t1.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.width !== b) {
                        element.width = b;
                    }
                }) : null;
        },
        initAnchorElement: function (element) {
            var $t, $t1, $t2, $t3, $t4, $t5, $t6, $t7, $t8, $t9, $t10, $t11, $t12, $t13, $t14, $t15, $t16, $t17, $t18, $t19, $t20, $t21, $t22;
            this.initElement(element);
            ($t = this.getCharset()) != null ? $t.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.charset, b)) {
                        element.charset = b;
                    }
                }) : null;
            ($t1 = this.getCoords()) != null ? $t1.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.coords, b)) {
                        element.coords = b;
                    }
                }) : null;
            ($t2 = this.getDownload()) != null ? $t2.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.download, b)) {
                        element.download = b;
                    }
                }) : null;
            ($t3 = this.getHash()) != null ? $t3.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.hash, b)) {
                        element.hash = b;
                    }
                }) : null;
            ($t4 = this.getHost()) != null ? $t4.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.host, b)) {
                        element.host = b;
                    }
                }) : null;
            ($t5 = this.getHostname()) != null ? $t5.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.hostname, b)) {
                        element.hostname = b;
                    }
                }) : null;
            ($t6 = this.getHref()) != null ? $t6.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.href, b)) {
                        element.href = b;
                    }
                }) : null;
            ($t7 = this.getHreflang()) != null ? $t7.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.hreflang, b)) {
                        element.hreflang = b;
                    }
                }) : null;
            ($t8 = this.getMedia()) != null ? $t8.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.media, b)) {
                        element.media = b;
                    }
                }) : null;
            ($t9 = this.getName()) != null ? $t9.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.name, b)) {
                        element.name = b;
                    }
                }) : null;
            ($t10 = this.getPassword()) != null ? $t10.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.password, b)) {
                        element.password = b;
                    }
                }) : null;
            ($t11 = this.getPathname()) != null ? $t11.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.pathname, b)) {
                        element.pathname = b;
                    }
                }) : null;
            ($t12 = this.getPort()) != null ? $t12.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.port, b)) {
                        element.port = b;
                    }
                }) : null;
            ($t13 = this.getProtocol()) != null ? $t13.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.protocol, b)) {
                        element.protocol = b;
                    }
                }) : null;
            ($t14 = this.getRel()) != null ? $t14.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.rel, b)) {
                        element.rel = b;
                    }
                }) : null;
            ($t15 = this.getRev()) != null ? $t15.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.rev, b)) {
                        element.rev = b;
                    }
                }) : null;
            ($t16 = this.getSearch()) != null ? $t16.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.search, b)) {
                        element.search = b;
                    }
                }) : null;
            ($t17 = this.getSearchParams()) != null ? $t17.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, URLSearchParams);
                    if (!Bridge.referenceEquals(element.searchParams, b)) {
                        element.searchParams = b;
                    }
                }) : null;
            ($t18 = this.getShape()) != null ? $t18.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.shape, b)) {
                        element.shape = b;
                    }
                }) : null;
            ($t19 = this.getTarget()) != null ? $t19.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.target, b)) {
                        element.target = b;
                    }
                }) : null;
            ($t20 = this.getText()) != null ? $t20.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.text, b)) {
                        element.text = b;
                    }
                }) : null;
            ($t21 = this.getType()) != null ? $t21.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.type, b)) {
                        element.type = b;
                    }
                }) : null;
            ($t22 = this.getUsername()) != null ? $t22.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.username, b)) {
                        element.username = b;
                    }
                }) : null;
        },
        initButtonElement: function (element) {
            var $t, $t1, $t2, $t3, $t4, $t5, $t6, $t7, $t8, $t9;
            this.initElement(element);
            ($t = this.getAutoFocus()) != null ? $t.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.autofocus !== b) {
                        element.autofocus = b;
                    }
                }) : null;
            ($t1 = this.getDisabled()) != null ? $t1.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.disabled !== b) {
                        element.disabled = b;
                    }
                }) : null;
            ($t2 = this.getFormAction()) != null ? $t2.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.formAction, b)) {
                        element.formAction = b;
                    }
                }) : null;
            ($t3 = this.getFormEncType()) != null ? $t3.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.formEncType, b)) {
                        element.formEncType = b;
                    }
                }) : null;
            ($t4 = this.getFormMethod()) != null ? $t4.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.formMethod, b)) {
                        element.formMethod = b;
                    }
                }) : null;
            ($t5 = this.getFormNoValidate()) != null ? $t5.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.formNoValidate !== b) {
                        element.formNoValidate = b;
                    }
                }) : null;
            ($t6 = this.getFormTarget()) != null ? $t6.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.formTarget, b)) {
                        element.formTarget = b;
                    }
                }) : null;
            ($t7 = this.getName()) != null ? $t7.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.name, b)) {
                        element.name = b;
                    }
                }) : null;
            ($t8 = this.getButtonType()) != null ? $t8.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (element.type !== b) {
                        element.type = b;
                    }
                }) : null;
            ($t9 = this.getValue()) != null ? $t9.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.value, b)) {
                        element.value = b;
                    }
                }) : null;
        },
        initFormElement: function (element) {
            var $t, $t1, $t2, $t3, $t4, $t5, $t6, $t7, $t8;
            this.initElement(element);
            ($t = this.getAcceptCharset()) != null ? $t.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.acceptCharset, b)) {
                        element.acceptCharset = b;
                    }
                }) : null;
            ($t1 = this.getAction()) != null ? $t1.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.action, b)) {
                        element.action = b;
                    }
                }) : null;
            ($t2 = this.getAutoComplete()) != null ? $t2.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (element.autocomplete !== b) {
                        element.autocomplete = b;
                    }
                }) : null;
            ($t3 = this.getEncoding()) != null ? $t3.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.encoding, b)) {
                        element.encoding = b;
                    }
                }) : null;
            ($t4 = this.getEnctype()) != null ? $t4.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.enctype, b)) {
                        element.enctype = b;
                    }
                }) : null;
            ($t5 = this.getMethod()) != null ? $t5.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.method, b)) {
                        element.method = b;
                    }
                }) : null;
            ($t6 = this.getName()) != null ? $t6.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.name, b)) {
                        element.name = b;
                    }
                }) : null;
            ($t7 = this.getNoValidate()) != null ? $t7.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.noValidate !== b) {
                        element.noValidate = b;
                    }
                }) : null;
            ($t8 = this.getTarget()) != null ? $t8.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.target, b)) {
                        element.target = b;
                    }
                }) : null;
        },
        initImageElement: function (element) {
            var $t, $t1, $t2, $t3, $t4, $t5, $t6;
            this.initElement(element);
            ($t = this.getCrossOrigin()) != null ? $t.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.crossOrigin, b)) {
                        element.crossOrigin = b;
                    }
                }) : null;
            ($t1 = this.getImageHeight()) != null ? $t1.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.height !== b) {
                        element.height = b;
                    }
                }) : null;
            ($t2 = this.getIsMap()) != null ? $t2.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.isMap !== b) {
                        element.isMap = b;
                    }
                }) : null;
            ($t3 = this.getSrc()) != null ? $t3.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.src, b)) {
                        element.src = b;
                    }
                }) : null;
            ($t4 = this.getSrcSet()) != null ? $t4.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.srcSet, b)) {
                        element.srcSet = b;
                    }
                }) : null;
            ($t5 = this.getUseMap()) != null ? $t5.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.useMap, b)) {
                        element.useMap = b;
                    }
                }) : null;
            ($t6 = this.getImageWidth()) != null ? $t6.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.width !== b) {
                        element.width = b;
                    }
                }) : null;
        },
        initInputElement: function (element) {
            var $t, $t1, $t2, $t3, $t4, $t5, $t6, $t7, $t8, $t9, $t10, $t11, $t12, $t13, $t14, $t15, $t16, $t17, $t18, $t19, $t20, $t21, $t22, $t23, $t24, $t25, $t26, $t27, $t28, $t29, $t30, $t31, $t32, $t33;
            this.initElement(element);
            ($t = this.getAccept()) != null ? $t.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.accept, b)) {
                        element.accept = b;
                    }
                }) : null;
            ($t1 = this.getAlt()) != null ? $t1.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.alt, b)) {
                        element.alt = b;
                    }
                }) : null;
            ($t2 = this.getAutoComplete()) != null ? $t2.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (element.autocomplete !== b) {
                        element.autocomplete = b;
                    }
                }) : null;
            ($t3 = this.getAutoFocus()) != null ? $t3.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.autofocus !== b) {
                        element.autofocus = b;
                    }
                }) : null;
            ($t4 = this.getAutoSave()) != null ? $t4.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.autosave !== b) {
                        element.autosave = b;
                    }
                }) : null;
            ($t5 = this.getChecked()) != null ? $t5.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.checked !== b) {
                        element.checked = b;
                    }
                }) : null;
            ($t6 = this.getDefaultChecked()) != null ? $t6.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.defaultChecked !== b) {
                        element.defaultChecked = b;
                    }
                }) : null;
            ($t7 = this.getDefaultValue()) != null ? $t7.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.defaultValue, b)) {
                        element.defaultValue = b;
                    }
                }) : null;
            ($t8 = this.getDisabled()) != null ? $t8.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.disabled !== b) {
                        element.disabled = b;
                    }
                }) : null;
            ($t9 = this.getFormAction()) != null ? $t9.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.formAction, b)) {
                        element.formAction = b;
                    }
                }) : null;
            ($t10 = this.getFormEncType()) != null ? $t10.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.formEncType, b)) {
                        element.formEncType = b;
                    }
                }) : null;
            ($t11 = this.getFormMethod()) != null ? $t11.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.formMethod, b)) {
                        element.formMethod = b;
                    }
                }) : null;
            ($t12 = this.getFormNoValidate()) != null ? $t12.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.formNoValidate !== b) {
                        element.formNoValidate = b;
                    }
                }) : null;
            ($t13 = this.getFormTarget()) != null ? $t13.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.formTarget, b)) {
                        element.formTarget = b;
                    }
                }) : null;
            ($t14 = this.getIndeterminate()) != null ? $t14.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.indeterminate !== b) {
                        element.indeterminate = b;
                    }
                }) : null;
            ($t15 = this.getList()) != null ? $t15.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, HTMLElement);
                    if (!Bridge.referenceEquals(element.list, b)) {
                        element.list = b;
                    }
                }) : null;
            ($t16 = this.getMax()) != null ? $t16.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.max, b)) {
                        element.max = b;
                    }
                }) : null;
            ($t17 = this.getMaxLength()) != null ? $t17.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.maxLength !== b) {
                        element.maxLength = b;
                    }
                }) : null;
            ($t18 = this.getMin()) != null ? $t18.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.min, b)) {
                        element.min = b;
                    }
                }) : null;
            ($t19 = this.getMultiple()) != null ? $t19.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.multiple !== b) {
                        element.multiple = b;
                    }
                }) : null;
            ($t20 = this.getName()) != null ? $t20.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.name, b)) {
                        element.name = b;
                    }
                }) : null;
            ($t21 = this.getPattern()) != null ? $t21.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.pattern, b)) {
                        element.pattern = b;
                    }
                }) : null;
            ($t22 = this.getPlaceholder()) != null ? $t22.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.placeholder, b)) {
                        element.placeholder = b;
                    }
                }) : null;
            ($t23 = this.getReadOnly()) != null ? $t23.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.readOnly !== b) {
                        element.readOnly = b;
                    }
                }) : null;
            ($t24 = this.getRequired()) != null ? $t24.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.required !== b) {
                        element.required = b;
                    }
                }) : null;
            ($t25 = this.getSelectionDirection()) != null ? $t25.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.selectionDirection, b)) {
                        element.selectionDirection = b;
                    }
                }) : null;
            ($t26 = this.getSelectionEnd()) != null ? $t26.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.selectionEnd !== b) {
                        element.selectionEnd = b;
                    }
                }) : null;
            ($t27 = this.getSelectionStart()) != null ? $t27.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.selectionStart !== b) {
                        element.selectionStart = b;
                    }
                }) : null;
            ($t28 = this.getSrc()) != null ? $t28.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.src, b)) {
                        element.src = b;
                    }
                }) : null;
            ($t29 = this.getStep()) != null ? $t29.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.step, b)) {
                        element.step = b;
                    }
                }) : null;
            ($t30 = this.getTabIndex()) != null ? $t30.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.tabIndex !== b) {
                        element.tabIndex = b;
                    }
                }) : null;
            ($t31 = this.getInputType()) != null ? $t31.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (element.type !== b) {
                        element.type = b;
                    }
                }) : null;
            ($t32 = this.getUseMap()) != null ? $t32.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.useMap, b)) {
                        element.useMap = b;
                    }
                }) : null;
            ($t33 = this.getValue()) != null ? $t33.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.value, b)) {
                        element.value = b;
                    }
                }) : null;
        },
        initLabelElement: function (element) {
            var $t;
            this.initElement(element);
            ($t = this.getHtmlFor()) != null ? $t.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.htmlFor, b)) {
                        element.htmlFor = b;
                    }
                }) : null;
        },
        initFieldSetElement: function (element) {
            var $t, $t1;
            this.initElement(element);
            ($t = this.getDisabled()) != null ? $t.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.disabled !== b) {
                        element.disabled = b;
                    }
                }) : null;
            ($t1 = this.getName()) != null ? $t1.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.name, b)) {
                        element.name = b;
                    }
                }) : null;
        },
        initIFrameElement: function (element) {
            var $t, $t1, $t2, $t3, $t4, $t5, $t6, $t7, $t8, $t9, $t10, $t11;
            this.initElement(element);
            ($t = this.getAllowFullScreen()) != null ? $t.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.allowfullscreen !== b) {
                        element.allowfullscreen = b;
                    }
                }) : null;
            ($t1 = this.getFrameBorder()) != null ? $t1.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.frameborder, b)) {
                        element.frameborder = b;
                    }
                }) : null;
            ($t2 = this.getIFrameHeight()) != null ? $t2.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.height !== b) {
                        element.height = b;
                    }
                }) : null;
            ($t3 = this.getLongDesc()) != null ? $t3.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.longDesc, b)) {
                        element.longDesc = b;
                    }
                }) : null;
            ($t4 = this.getIFrameMarginHeight()) != null ? $t4.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.marginHeight !== b) {
                        element.marginHeight = b;
                    }
                }) : null;
            ($t5 = this.getIFrameMarginWidth()) != null ? $t5.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.marginWidth !== b) {
                        element.marginWidth = b;
                    }
                }) : null;
            ($t6 = this.getName()) != null ? $t6.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.name, b)) {
                        element.name = b;
                    }
                }) : null;
            ($t7 = this.getScrolling()) != null ? $t7.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.scrolling, b)) {
                        element.scrolling = b;
                    }
                }) : null;
            ($t8 = this.getSeamless()) != null ? $t8.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.seamless !== b) {
                        element.seamless = b;
                    }
                }) : null;
            ($t9 = this.getSrc()) != null ? $t9.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.src, b)) {
                        element.src = b;
                    }
                }) : null;
            ($t10 = this.getSrcDoc()) != null ? $t10.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.srcDoc, b)) {
                        element.srcDoc = b;
                    }
                }) : null;
            ($t11 = this.getIFrameWidth()) != null ? $t11.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.width !== b) {
                        element.width = b;
                    }
                }) : null;
        },
        initOptGroupElement: function (element) {
            var $t, $t1;
            this.initElement(element);
            ($t = this.getDisabled()) != null ? $t.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.disabled !== b) {
                        element.disabled = b;
                    }
                }) : null;
            ($t1 = this.getLabel()) != null ? $t1.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.label, b)) {
                        element.label = b;
                    }
                }) : null;
        },
        initOptionElement: function (element) {
            var $t, $t1, $t2, $t3, $t4, $t5;
            this.initElement(element);
            ($t = this.getDefaultSelected()) != null ? $t.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.defaultSelected !== b) {
                        element.defaultSelected = b;
                    }
                }) : null;
            ($t1 = this.getDisable()) != null ? $t1.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.disable !== b) {
                        element.disable = b;
                    }
                }) : null;
            ($t2 = this.getLabel()) != null ? $t2.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.label, b)) {
                        element.label = b;
                    }
                }) : null;
            ($t3 = this.getSelected()) != null ? $t3.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.selected !== b) {
                        element.selected = b;
                    }
                }) : null;
            ($t4 = this.getText()) != null ? $t4.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.text, b)) {
                        element.text = b;
                    }
                }) : null;
            ($t5 = this.getValue()) != null ? $t5.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.value, b)) {
                        element.value = b;
                    }
                }) : null;
        },
        initSelectElement: function (element) {
            var $t, $t1, $t2, $t3, $t4, $t5, $t6, $t7;
            this.initElement(element);
            ($t = this.getAutoFocus()) != null ? $t.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.autofocus !== b) {
                        element.autofocus = b;
                    }
                }) : null;
            ($t1 = this.getDisabled()) != null ? $t1.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.disabled !== b) {
                        element.disabled = b;
                    }
                }) : null;
            ($t2 = this.getMultiple()) != null ? $t2.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.multiple !== b) {
                        element.multiple = b;
                    }
                }) : null;
            ($t3 = this.getName()) != null ? $t3.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.name, b)) {
                        element.name = b;
                    }
                }) : null;
            ($t4 = this.getRequired()) != null ? $t4.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.required !== b) {
                        element.required = b;
                    }
                }) : null;
            ($t5 = this.getSelectedIndex()) != null ? $t5.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.selectedIndex !== b) {
                        element.selectedIndex = b;
                    }
                }) : null;
            ($t6 = this.getSize()) != null ? $t6.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.size !== b) {
                        element.size = b;
                    }
                }) : null;
            ($t7 = this.getSrc()) != null ? $t7.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.src, b)) {
                        element.src = b;
                    }
                }) : null;
        },
        initTextAreaElement: function (element) {
            var $t, $t1, $t2, $t3, $t4, $t5, $t6, $t7, $t8, $t9, $t10, $t11, $t12, $t13;
            this.initElement(element);
            ($t = this.getAutoFocus()) != null ? $t.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.autofocus !== b) {
                        element.autofocus = b;
                    }
                }) : null;
            ($t1 = this.getCols()) != null ? $t1.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.cols !== b) {
                        element.cols = b;
                    }
                }) : null;
            ($t2 = this.getDisabled()) != null ? $t2.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.disabled !== b) {
                        element.disabled = b;
                    }
                }) : null;
            ($t3 = this.getMaxLength()) != null ? $t3.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.maxLength !== b) {
                        element.maxLength = b;
                    }
                }) : null;
            ($t4 = this.getName()) != null ? $t4.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.name, b)) {
                        element.name = b;
                    }
                }) : null;
            ($t5 = this.getPlaceholder()) != null ? $t5.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.placeholder, b)) {
                        element.placeholder = b;
                    }
                }) : null;
            ($t6 = this.getReadOnly()) != null ? $t6.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.readOnly !== b) {
                        element.readOnly = b;
                    }
                }) : null;
            ($t7 = this.getRequired()) != null ? $t7.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, Boolean));
                    if (element.required !== b) {
                        element.required = b;
                    }
                }) : null;
            ($t8 = this.getRows()) != null ? $t8.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.rows !== b) {
                        element.rows = b;
                    }
                }) : null;
            ($t9 = this.getSelectionDirection()) != null ? $t9.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.selectionDirection, b)) {
                        element.selectionDirection = b;
                    }
                }) : null;
            ($t10 = this.getSelectionEnd()) != null ? $t10.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.selectionEnd !== b) {
                        element.selectionEnd = b;
                    }
                }) : null;
            ($t11 = this.getSelectionStart()) != null ? $t11.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.selectionStart !== b) {
                        element.selectionStart = b;
                    }
                }) : null;
            ($t12 = this.getValue()) != null ? $t12.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.value, b)) {
                        element.value = b;
                    }
                }) : null;
            ($t13 = this.getWrap()) != null ? $t13.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (element.wrap !== b) {
                        element.wrap = b;
                    }
                }) : null;
        },
        initTableDataCellElement: function (element) {
            var $t, $t1, $t2;
            this.initElement(element);
            ($t = this.getColSpan()) != null ? $t.getObservable().subscribe(function (a) {
                    var b = (System.Nullable.getValue(Bridge.cast(a, System.Int32))) >>> 0;
                    if (element.colSpan !== b) {
                        element.colSpan = b;
                    }
                }) : null;
            ($t1 = this.getRowSpan()) != null ? $t1.getObservable().subscribe(function (a) {
                    var b = (System.Nullable.getValue(Bridge.cast(a, System.Int32))) >>> 0;
                    if (element.rowSpan !== b) {
                        element.rowSpan = b;
                    }
                }) : null;
            ($t2 = this.getCellIndex()) != null ? $t2.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.cellIndex !== b) {
                        element.cellIndex = b;
                    }
                }) : null;
        },
        initTableHeaderCellElement: function (element) {
            var $t, $t1, $t2, $t3;
            this.initElement(element);
            ($t = this.getAbbr()) != null ? $t.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, String);
                    if (!Bridge.referenceEquals(element.abbr, b)) {
                        element.abbr = b;
                    }
                }) : null;
            ($t1 = this.getColSpan()) != null ? $t1.getObservable().subscribe(function (a) {
                    var b = (System.Nullable.getValue(Bridge.cast(a, System.Int32))) >>> 0;
                    if (element.colSpan !== b) {
                        element.colSpan = b;
                    }
                }) : null;
            ($t2 = this.getRowSpan()) != null ? $t2.getObservable().subscribe(function (a) {
                    var b = (System.Nullable.getValue(Bridge.cast(a, System.Int32))) >>> 0;
                    if (element.rowSpan !== b) {
                        element.rowSpan = b;
                    }
                }) : null;
            ($t3 = this.getCellIndex()) != null ? $t3.getObservable().subscribe(function (a) {
                    var b = System.Nullable.getValue(Bridge.cast(a, System.Int32));
                    if (element.cellIndex !== b) {
                        element.cellIndex = b;
                    }
                }) : null;
        },
        initTableElement: function (element) {
            var $t, $t1, $t2;
            this.initElement(element);
            ($t = this.getCaption()) != null ? $t.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, HTMLTableCaptionElement);
                    if (!Bridge.referenceEquals(element.caption, b)) {
                        element.caption = b;
                    }
                }) : null;
            ($t1 = this.getTHead()) != null ? $t1.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, HTMLTableSectionElement);
                    if (!Bridge.referenceEquals(element.tHead, b)) {
                        element.tHead = b;
                    }
                }) : null;
            ($t2 = this.getTFoot()) != null ? $t2.getObservable().subscribe(function (a) {
                    var b = Bridge.cast(a, HTMLTableSectionElement);
                    if (!Bridge.referenceEquals(element.tFoot, b)) {
                        element.tFoot = b;
                    }
                }) : null;
        }
    }; });
});
