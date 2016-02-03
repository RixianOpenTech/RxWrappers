using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading.Tasks
{
public static class _ParallelLoopResult
{
    
public static IObservable<System.Boolean> get_IsCompleted(this IObservable<System.Threading.Tasks.ParallelLoopResult> ParallelLoopResultValue)
{
    return Observable.Select(ParallelLoopResultValue, (ParallelLoopResultValueLambda) => ParallelLoopResultValueLambda.IsCompleted);
}


public static IObservable<System.Nullable<System.Int64>> get_LowestBreakIteration(this IObservable<System.Threading.Tasks.ParallelLoopResult> ParallelLoopResultValue)
{
    return Observable.Select(ParallelLoopResultValue, (ParallelLoopResultValueLambda) => ParallelLoopResultValueLambda.LowestBreakIteration);
}

}
}