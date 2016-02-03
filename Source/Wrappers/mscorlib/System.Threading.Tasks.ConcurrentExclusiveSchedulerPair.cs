using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading.Tasks
{
public static class _ConcurrentExclusiveSchedulerPair
{
    
public static IObservable<System.Reactive.Unit> Complete(this IObservable<System.Threading.Tasks.ConcurrentExclusiveSchedulerPair> ConcurrentExclusiveSchedulerPairValue)
{
    return Observable.Do(ConcurrentExclusiveSchedulerPairValue, (ConcurrentExclusiveSchedulerPairValueLambda) => ConcurrentExclusiveSchedulerPairValueLambda.Complete()).ToUnit();
}


public static IObservable<System.Reactive.Unit> get_Completion(this IObservable<System.Threading.Tasks.ConcurrentExclusiveSchedulerPair> ConcurrentExclusiveSchedulerPairValue)
{
    return Observable.Select(ConcurrentExclusiveSchedulerPairValue, (ConcurrentExclusiveSchedulerPairValueLambda) => ConcurrentExclusiveSchedulerPairValueLambda.Completion.ToObservable()).Flatten().ToUnit();
}


public static IObservable<System.Threading.Tasks.TaskScheduler> get_ConcurrentScheduler(this IObservable<System.Threading.Tasks.ConcurrentExclusiveSchedulerPair> ConcurrentExclusiveSchedulerPairValue)
{
    return Observable.Select(ConcurrentExclusiveSchedulerPairValue, (ConcurrentExclusiveSchedulerPairValueLambda) => ConcurrentExclusiveSchedulerPairValueLambda.ConcurrentScheduler);
}


public static IObservable<System.Threading.Tasks.TaskScheduler> get_ExclusiveScheduler(this IObservable<System.Threading.Tasks.ConcurrentExclusiveSchedulerPair> ConcurrentExclusiveSchedulerPairValue)
{
    return Observable.Select(ConcurrentExclusiveSchedulerPairValue, (ConcurrentExclusiveSchedulerPairValueLambda) => ConcurrentExclusiveSchedulerPairValueLambda.ExclusiveScheduler);
}

}
}