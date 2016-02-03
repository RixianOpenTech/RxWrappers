using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _IAsyncResult
{
    
public static IObservable<System.Boolean> get_IsCompleted(this IObservable<System.IAsyncResult> IAsyncResultValue)
{
    return Observable.Select(IAsyncResultValue, (IAsyncResultValueLambda) => IAsyncResultValueLambda.IsCompleted);
}


public static IObservable<System.Threading.WaitHandle> get_AsyncWaitHandle(this IObservable<System.IAsyncResult> IAsyncResultValue)
{
    return Observable.Select(IAsyncResultValue, (IAsyncResultValueLambda) => IAsyncResultValueLambda.AsyncWaitHandle);
}


public static IObservable<System.Object> get_AsyncState(this IObservable<System.IAsyncResult> IAsyncResultValue)
{
    return Observable.Select(IAsyncResultValue, (IAsyncResultValueLambda) => IAsyncResultValueLambda.AsyncState);
}


public static IObservable<System.Boolean> get_CompletedSynchronously(this IObservable<System.IAsyncResult> IAsyncResultValue)
{
    return Observable.Select(IAsyncResultValue, (IAsyncResultValueLambda) => IAsyncResultValueLambda.CompletedSynchronously);
}

}
}