using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
public static class _ThreadStart
{
    
public static IObservable<System.Reactive.Unit> Invoke(this IObservable<System.Threading.ThreadStart> ThreadStartValue)
{
    return Observable.Do(ThreadStartValue, (ThreadStartValueLambda) => ThreadStartValueLambda.Invoke()).ToUnit();
}


public static IObservable<System.IAsyncResult> BeginInvoke(this IObservable<System.Threading.ThreadStart> ThreadStartValue, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
{
    return Observable.Zip(ThreadStartValue, callback, @object, (ThreadStartValueLambda, callbackLambda, @objectLambda) => ThreadStartValueLambda.BeginInvoke(callbackLambda, @objectLambda));
}


public static IObservable<System.Reactive.Unit> EndInvoke(this IObservable<System.Threading.ThreadStart> ThreadStartValue, IObservable<System.IAsyncResult> result)
{
    return ObservableExt.ZipExecute(ThreadStartValue, result, (ThreadStartValueLambda, resultLambda) => ThreadStartValueLambda.EndInvoke(resultLambda));
}

}
}