var Cell$1 = function (_source, _notifier) {
    this.source = _source;

    this.notifier = _notifier;

    this.current = this.source();

    this.subject = new Rx.Subject();

    this.notifier.System$ComponentModel$INotifyPropertyChanged$addPropertyChanged(Bridge.fn.bind(this, function (_, __) {

        var p = this.source();

        if (this.current != null && Bridge.equals(this.current, p)) {
            return;
        } else if (this.current == null && p == null) {
            return;
        }

        this.current = p;

        this.subject.next(this.current);
    }

    
    ));

    this.getObservable = function () {
        return this.subject.asObservable().startWith(this.current);
    }
};


