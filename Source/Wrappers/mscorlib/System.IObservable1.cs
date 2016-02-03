using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _IObservable1
{
    
public static IObservable<System.IDisposable> Subscribe<T>(this IObservable<System.IObservable<T>> IObservableValue, IObservable<IObserver<T>> observer)
{
    return Observable.Zip(IObservableValue, observer, (IObservableValueLambda, observerLambda) => IObservableValueLambda.Subscribe(observerLambda));
}

}
}