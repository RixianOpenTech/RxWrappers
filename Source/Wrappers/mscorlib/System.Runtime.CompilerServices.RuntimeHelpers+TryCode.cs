using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
public static class _TryCode
{
    
public static IObservable<System.Reactive.Unit> Invoke(this IObservable<System.Runtime.CompilerServices.RuntimeHelpers.TryCode> TryCodeValue, IObservable<System.Object> userData)
{
    return ObservableExt.ZipExecute(TryCodeValue, userData, (TryCodeValueLambda, userDataLambda) => TryCodeValueLambda.Invoke(userDataLambda));
}


public static IObservable<System.IAsyncResult> BeginInvoke(this IObservable<System.Runtime.CompilerServices.RuntimeHelpers.TryCode> TryCodeValue, IObservable<System.Object> userData, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
{
    return Observable.Zip(TryCodeValue, userData, callback, @object, (TryCodeValueLambda, userDataLambda, callbackLambda, @objectLambda) => TryCodeValueLambda.BeginInvoke(userDataLambda, callbackLambda, @objectLambda));
}


public static IObservable<System.Reactive.Unit> EndInvoke(this IObservable<System.Runtime.CompilerServices.RuntimeHelpers.TryCode> TryCodeValue, IObservable<System.IAsyncResult> result)
{
    return ObservableExt.ZipExecute(TryCodeValue, result, (TryCodeValueLambda, resultLambda) => TryCodeValueLambda.EndInvoke(resultLambda));
}

}
}