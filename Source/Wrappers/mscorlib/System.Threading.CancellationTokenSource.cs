using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
public static class _CancellationTokenSource
{
    
public static IObservable<System.Reactive.Unit> Cancel(this IObservable<System.Threading.CancellationTokenSource> CancellationTokenSourceValue)
{
    return Observable.Do(CancellationTokenSourceValue, (CancellationTokenSourceValueLambda) => CancellationTokenSourceValueLambda.Cancel()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Cancel(this IObservable<System.Threading.CancellationTokenSource> CancellationTokenSourceValue, IObservable<System.Boolean> throwOnFirstException)
{
    return ObservableExt.ZipExecute(CancellationTokenSourceValue, throwOnFirstException, (CancellationTokenSourceValueLambda, throwOnFirstExceptionLambda) => CancellationTokenSourceValueLambda.Cancel(throwOnFirstExceptionLambda));
}


public static IObservable<System.Reactive.Unit> CancelAfter(this IObservable<System.Threading.CancellationTokenSource> CancellationTokenSourceValue, IObservable<System.TimeSpan> delay)
{
    return ObservableExt.ZipExecute(CancellationTokenSourceValue, delay, (CancellationTokenSourceValueLambda, delayLambda) => CancellationTokenSourceValueLambda.CancelAfter(delayLambda));
}


public static IObservable<System.Reactive.Unit> CancelAfter(this IObservable<System.Threading.CancellationTokenSource> CancellationTokenSourceValue, IObservable<System.Int32> millisecondsDelay)
{
    return ObservableExt.ZipExecute(CancellationTokenSourceValue, millisecondsDelay, (CancellationTokenSourceValueLambda, millisecondsDelayLambda) => CancellationTokenSourceValueLambda.CancelAfter(millisecondsDelayLambda));
}


public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Threading.CancellationTokenSource> CancellationTokenSourceValue)
{
    return Observable.Do(CancellationTokenSourceValue, (CancellationTokenSourceValueLambda) => CancellationTokenSourceValueLambda.Dispose()).ToUnit();
}


public static IObservable<System.Threading.CancellationTokenSource> CreateLinkedTokenSource(IObservable<System.Threading.CancellationToken> token1, IObservable<System.Threading.CancellationToken> token2)
{
    return Observable.Zip(token1, token2, (token1Lambda, token2Lambda) => System.Threading.CancellationTokenSource.CreateLinkedTokenSource(token1Lambda, token2Lambda));
}


public static IObservable<System.Threading.CancellationTokenSource> CreateLinkedTokenSource(IObservable<System.Threading.CancellationToken[]> tokens)
{
    return Observable.Select(tokens, (tokensLambda) => System.Threading.CancellationTokenSource.CreateLinkedTokenSource(tokensLambda));
}


public static IObservable<System.Boolean> get_IsCancellationRequested(this IObservable<System.Threading.CancellationTokenSource> CancellationTokenSourceValue)
{
    return Observable.Select(CancellationTokenSourceValue, (CancellationTokenSourceValueLambda) => CancellationTokenSourceValueLambda.IsCancellationRequested);
}


public static IObservable<System.Threading.CancellationToken> get_Token(this IObservable<System.Threading.CancellationTokenSource> CancellationTokenSourceValue)
{
    return Observable.Select(CancellationTokenSourceValue, (CancellationTokenSourceValueLambda) => CancellationTokenSourceValueLambda.Token);
}

}
}