using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _AsyncCallback
{
    
public static IObservable<System.Reactive.Unit> Invoke(this IObservable<System.AsyncCallback> AsyncCallbackValue, IObservable<System.IAsyncResult> ar)
{
    return ObservableExt.ZipExecute(AsyncCallbackValue, ar, (AsyncCallbackValueLambda, arLambda) => AsyncCallbackValueLambda.Invoke(arLambda));
}


public static IObservable<System.IAsyncResult> BeginInvoke(this IObservable<System.AsyncCallback> AsyncCallbackValue, IObservable<System.IAsyncResult> ar, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
{
    return Observable.Zip(AsyncCallbackValue, ar, callback, @object, (AsyncCallbackValueLambda, arLambda, callbackLambda, @objectLambda) => AsyncCallbackValueLambda.BeginInvoke(arLambda, callbackLambda, @objectLambda));
}


public static IObservable<System.Reactive.Unit> EndInvoke(this IObservable<System.AsyncCallback> AsyncCallbackValue, IObservable<System.IAsyncResult> result)
{
    return ObservableExt.ZipExecute(AsyncCallbackValue, result, (AsyncCallbackValueLambda, resultLambda) => AsyncCallbackValueLambda.EndInvoke(resultLambda));
}

}
}