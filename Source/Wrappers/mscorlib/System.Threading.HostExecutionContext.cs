using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
public static class _HostExecutionContext
{
    
public static IObservable<System.Threading.HostExecutionContext> CreateCopy(this IObservable<System.Threading.HostExecutionContext> HostExecutionContextValue)
{
    return Observable.Select(HostExecutionContextValue, (HostExecutionContextValueLambda) => HostExecutionContextValueLambda.CreateCopy());
}


public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Threading.HostExecutionContext> HostExecutionContextValue)
{
    return Observable.Do(HostExecutionContextValue, (HostExecutionContextValueLambda) => HostExecutionContextValueLambda.Dispose()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Threading.HostExecutionContext> HostExecutionContextValue, IObservable<System.Boolean> disposing)
{
    return ObservableExt.ZipExecute(HostExecutionContextValue, disposing, (HostExecutionContextValueLambda, disposingLambda) => HostExecutionContextValueLambda.Dispose(disposingLambda));
}

}
}