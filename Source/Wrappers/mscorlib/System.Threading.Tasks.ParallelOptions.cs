using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading.Tasks
{
public static class _ParallelOptions
{
    
public static IObservable<System.Threading.Tasks.TaskScheduler> get_TaskScheduler(this IObservable<System.Threading.Tasks.ParallelOptions> ParallelOptionsValue)
{
    return Observable.Select(ParallelOptionsValue, (ParallelOptionsValueLambda) => ParallelOptionsValueLambda.TaskScheduler);
}


public static IObservable<System.Int32> get_MaxDegreeOfParallelism(this IObservable<System.Threading.Tasks.ParallelOptions> ParallelOptionsValue)
{
    return Observable.Select(ParallelOptionsValue, (ParallelOptionsValueLambda) => ParallelOptionsValueLambda.MaxDegreeOfParallelism);
}


public static IObservable<System.Threading.CancellationToken> get_CancellationToken(this IObservable<System.Threading.Tasks.ParallelOptions> ParallelOptionsValue)
{
    return Observable.Select(ParallelOptionsValue, (ParallelOptionsValueLambda) => ParallelOptionsValueLambda.CancellationToken);
}


public static IObservable<System.Reactive.Unit> set_TaskScheduler(this IObservable<System.Threading.Tasks.ParallelOptions> ParallelOptionsValue, IObservable<System.Threading.Tasks.TaskScheduler> value)
{
    return ObservableExt.ZipExecute(ParallelOptionsValue, value, (ParallelOptionsValueLambda, valueLambda) => ParallelOptionsValueLambda.TaskScheduler = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_MaxDegreeOfParallelism(this IObservable<System.Threading.Tasks.ParallelOptions> ParallelOptionsValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(ParallelOptionsValue, value, (ParallelOptionsValueLambda, valueLambda) => ParallelOptionsValueLambda.MaxDegreeOfParallelism = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_CancellationToken(this IObservable<System.Threading.Tasks.ParallelOptions> ParallelOptionsValue, IObservable<System.Threading.CancellationToken> value)
{
    return ObservableExt.ZipExecute(ParallelOptionsValue, value, (ParallelOptionsValueLambda, valueLambda) => ParallelOptionsValueLambda.CancellationToken = valueLambda);
}

}
}