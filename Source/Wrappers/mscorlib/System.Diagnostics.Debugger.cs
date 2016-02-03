using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics
{
public static class _Debugger
{
    
public static IObservable<System.Reactive.Unit> Break()
{
    return ObservableExt.Factory(() => System.Diagnostics.Debugger.Break());
}


public static IObservable<System.Boolean> Launch()
{
    return ObservableExt.Factory(() => System.Diagnostics.Debugger.Launch());
}


public static IObservable<System.Reactive.Unit> NotifyOfCrossThreadDependency()
{
    return ObservableExt.Factory(() => System.Diagnostics.Debugger.NotifyOfCrossThreadDependency());
}


public static IObservable<System.Reactive.Unit> Log(IObservable<System.Int32> level, IObservable<System.String> category, IObservable<System.String> message)
{
    return ObservableExt.ZipExecute(level, category, message, (levelLambda, categoryLambda, messageLambda) => System.Diagnostics.Debugger.Log(levelLambda, categoryLambda, messageLambda));
}


public static IObservable<System.Boolean> IsLogging()
{
    return ObservableExt.Factory(() => System.Diagnostics.Debugger.IsLogging());
}


public static IObservable<System.Boolean> get_IsAttached()
{
    return ObservableExt.Factory(() => System.Diagnostics.Debugger.IsAttached);
}

}
}