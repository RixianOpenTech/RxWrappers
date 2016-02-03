using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
public static class _ConfiguredTaskAwaiter
{
    
public static IObservable<System.Reactive.Unit> OnCompleted(this IObservable<System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter> ConfiguredTaskAwaiterValue, IObservable<System.Action> continuation)
{
    return ObservableExt.ZipExecute(ConfiguredTaskAwaiterValue, continuation, (ConfiguredTaskAwaiterValueLambda, continuationLambda) => ConfiguredTaskAwaiterValueLambda.OnCompleted(continuationLambda));
}


public static IObservable<System.Reactive.Unit> UnsafeOnCompleted(this IObservable<System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter> ConfiguredTaskAwaiterValue, IObservable<System.Action> continuation)
{
    return ObservableExt.ZipExecute(ConfiguredTaskAwaiterValue, continuation, (ConfiguredTaskAwaiterValueLambda, continuationLambda) => ConfiguredTaskAwaiterValueLambda.UnsafeOnCompleted(continuationLambda));
}


public static IObservable<System.Reactive.Unit> GetResult(this IObservable<System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter> ConfiguredTaskAwaiterValue)
{
    return Observable.Do(ConfiguredTaskAwaiterValue, (ConfiguredTaskAwaiterValueLambda) => ConfiguredTaskAwaiterValueLambda.GetResult()).ToUnit();
}


public static IObservable<System.Boolean> get_IsCompleted(this IObservable<System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter> ConfiguredTaskAwaiterValue)
{
    return Observable.Select(ConfiguredTaskAwaiterValue, (ConfiguredTaskAwaiterValueLambda) => ConfiguredTaskAwaiterValueLambda.IsCompleted);
}

}
}