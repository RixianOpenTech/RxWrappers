using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
public static class _YieldAwaiter
{
    
public static IObservable<System.Reactive.Unit> OnCompleted(this IObservable<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter> YieldAwaiterValue, IObservable<System.Action> continuation)
{
    return ObservableExt.ZipExecute(YieldAwaiterValue, continuation, (YieldAwaiterValueLambda, continuationLambda) => YieldAwaiterValueLambda.OnCompleted(continuationLambda));
}


public static IObservable<System.Reactive.Unit> UnsafeOnCompleted(this IObservable<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter> YieldAwaiterValue, IObservable<System.Action> continuation)
{
    return ObservableExt.ZipExecute(YieldAwaiterValue, continuation, (YieldAwaiterValueLambda, continuationLambda) => YieldAwaiterValueLambda.UnsafeOnCompleted(continuationLambda));
}


public static IObservable<System.Reactive.Unit> GetResult(this IObservable<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter> YieldAwaiterValue)
{
    return Observable.Do(YieldAwaiterValue, (YieldAwaiterValueLambda) => YieldAwaiterValueLambda.GetResult()).ToUnit();
}


public static IObservable<System.Boolean> get_IsCompleted(this IObservable<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter> YieldAwaiterValue)
{
    return Observable.Select(YieldAwaiterValue, (YieldAwaiterValueLambda) => YieldAwaiterValueLambda.IsCompleted);
}

}
}