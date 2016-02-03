using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
public static class _AsyncLocal1
{
    
public static IObservable<T> get_Value<T>(this IObservable<System.Threading.AsyncLocal<T>> AsyncLocalValue)
{
    return Observable.Select(AsyncLocalValue, (AsyncLocalValueLambda) => AsyncLocalValueLambda.Value);
}


public static IObservable<System.Reactive.Unit> set_Value<T>(this IObservable<System.Threading.AsyncLocal<T>> AsyncLocalValue, IObservable<T> value)
{
    return ObservableExt.ZipExecute(AsyncLocalValue, value, (AsyncLocalValueLambda, valueLambda) => AsyncLocalValueLambda.Value = valueLambda);
}

}
}