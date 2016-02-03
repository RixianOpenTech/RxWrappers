using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
public static class _CancellationToken
{
    
public static IObservable<System.Threading.CancellationTokenRegistration> Register(this IObservable<System.Threading.CancellationToken> CancellationTokenValue, IObservable<System.Action> callback)
{
    return Observable.Zip(CancellationTokenValue, callback, (CancellationTokenValueLambda, callbackLambda) => CancellationTokenValueLambda.Register(callbackLambda));
}


public static IObservable<System.Threading.CancellationTokenRegistration> Register(this IObservable<System.Threading.CancellationToken> CancellationTokenValue, IObservable<System.Action> callback, IObservable<System.Boolean> useSynchronizationContext)
{
    return Observable.Zip(CancellationTokenValue, callback, useSynchronizationContext, (CancellationTokenValueLambda, callbackLambda, useSynchronizationContextLambda) => CancellationTokenValueLambda.Register(callbackLambda, useSynchronizationContextLambda));
}


public static IObservable<System.Threading.CancellationTokenRegistration> Register(this IObservable<System.Threading.CancellationToken> CancellationTokenValue, IObservable<System.Action<System.Object>> callback, IObservable<System.Object> state)
{
    return Observable.Zip(CancellationTokenValue, callback, state, (CancellationTokenValueLambda, callbackLambda, stateLambda) => CancellationTokenValueLambda.Register(callbackLambda, stateLambda));
}


public static IObservable<System.Threading.CancellationTokenRegistration> Register(this IObservable<System.Threading.CancellationToken> CancellationTokenValue, IObservable<System.Action<System.Object>> callback, IObservable<System.Object> state, IObservable<System.Boolean> useSynchronizationContext)
{
    return Observable.Zip(CancellationTokenValue, callback, state, useSynchronizationContext, (CancellationTokenValueLambda, callbackLambda, stateLambda, useSynchronizationContextLambda) => CancellationTokenValueLambda.Register(callbackLambda, stateLambda, useSynchronizationContextLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Threading.CancellationToken> CancellationTokenValue, IObservable<System.Threading.CancellationToken> other)
{
    return Observable.Zip(CancellationTokenValue, other, (CancellationTokenValueLambda, otherLambda) => CancellationTokenValueLambda.Equals(otherLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Threading.CancellationToken> CancellationTokenValue, IObservable<System.Object> other)
{
    return Observable.Zip(CancellationTokenValue, other, (CancellationTokenValueLambda, otherLambda) => CancellationTokenValueLambda.Equals(otherLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Threading.CancellationToken> CancellationTokenValue)
{
    return Observable.Select(CancellationTokenValue, (CancellationTokenValueLambda) => CancellationTokenValueLambda.GetHashCode());
}


public static IObservable<System.Reactive.Unit> ThrowIfCancellationRequested(this IObservable<System.Threading.CancellationToken> CancellationTokenValue)
{
    return Observable.Do(CancellationTokenValue, (CancellationTokenValueLambda) => CancellationTokenValueLambda.ThrowIfCancellationRequested()).ToUnit();
}


public static IObservable<System.Threading.CancellationToken> get_None()
{
    return ObservableExt.Factory(() => System.Threading.CancellationToken.None);
}


public static IObservable<System.Boolean> get_IsCancellationRequested(this IObservable<System.Threading.CancellationToken> CancellationTokenValue)
{
    return Observable.Select(CancellationTokenValue, (CancellationTokenValueLambda) => CancellationTokenValueLambda.IsCancellationRequested);
}


public static IObservable<System.Boolean> get_CanBeCanceled(this IObservable<System.Threading.CancellationToken> CancellationTokenValue)
{
    return Observable.Select(CancellationTokenValue, (CancellationTokenValueLambda) => CancellationTokenValueLambda.CanBeCanceled);
}


public static IObservable<System.Threading.WaitHandle> get_WaitHandle(this IObservable<System.Threading.CancellationToken> CancellationTokenValue)
{
    return Observable.Select(CancellationTokenValue, (CancellationTokenValueLambda) => CancellationTokenValueLambda.WaitHandle);
}

}
}