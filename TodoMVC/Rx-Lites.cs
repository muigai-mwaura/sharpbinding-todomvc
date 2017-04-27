using Bridge;
using System;

namespace Rx
{
    [External]
    public interface Observer<T>
    {
        void Next(T value);
        void Error(object err);
        void Complete();
    }

    [External]
    public class Subject<T> : Observable<T>, Observer<T>
    {
        public void Complete()
        {
            throw new NotImplementedException();
        }

        public void Error(object err)
        {
            throw new NotImplementedException();
        }

        public void Next(T value)
        {
            throw new NotImplementedException();
        }

        public Observable<T> AsObservable()
        {
            throw new NotImplementedException();
        }

        public void Unsubscribe()
        {
            throw new NotImplementedException();
        }
    }

    [External]
    [IgnoreGeneric]
    public class Observable<T>
    {

        public void Subscribe(Observer<T> observer) { }
        
        public void Subscribe(Action<T> onNext, Action<object> onError = null, Action onComplete = null) { }

        public static Observable<TEventArgs> FromEvent<TEventArgs>(object element, string eventName) { throw new NotImplementedException(); }
        
        public Observable<T> StartWith(params T[] values) { throw new NotImplementedException(); }
      
        public  Observable<T> Filter(Func<T, bool> predicate){throw new NotImplementedException(); }

        public Observable<T1> Map<T1>(Func<T, T1> selector) { throw new NotImplementedException(); }

        public Observable<T> Merge(params Observable<T>[] ps) { throw new NotImplementedException(); }
    }

    public static class Subject
    {
        [Template("new Rx.Subject()")]
        public extern static Subject<T> Create<T>();


    }
}
