using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __IObserver1
    {
        
        public static IObservable<System.Reactive.Unit> OnNext<T>(this IObservable<System.IObserver<T>> IObserverValue, IObservable<T> value)
        {
            return ObservableExt.ZipExecute(IObserverValue, value, (IObserverValueLambda, valueLambda) => IObserverValueLambda.OnNext(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> OnError<T>(this IObservable<System.IObserver<T>> IObserverValue, IObservable<System.Exception> error)
        {
            return ObservableExt.ZipExecute(IObserverValue, error, (IObserverValueLambda, errorLambda) => IObserverValueLambda.OnError(errorLambda));
        }


        public static IObservable<System.Reactive.Unit> OnCompleted<T>(this IObservable<System.IObserver<T>> IObserverValue)
        {
            return Observable.Do(IObserverValue, (IObserverValueLambda) => IObserverValueLambda.OnCompleted()).ToUnit();
        }

    }
}