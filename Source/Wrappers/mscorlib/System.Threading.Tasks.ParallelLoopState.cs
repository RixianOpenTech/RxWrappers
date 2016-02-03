using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading.Tasks
{
    public static class __ParallelLoopState
    {
        
        public static IObservable<System.Reactive.Unit> Stop(this IObservable<System.Threading.Tasks.ParallelLoopState> ParallelLoopStateValue)
        {
            return Observable.Do(ParallelLoopStateValue, (ParallelLoopStateValueLambda) => ParallelLoopStateValueLambda.Stop()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Break(this IObservable<System.Threading.Tasks.ParallelLoopState> ParallelLoopStateValue)
        {
            return Observable.Do(ParallelLoopStateValue, (ParallelLoopStateValueLambda) => ParallelLoopStateValueLambda.Break()).ToUnit();
        }


        public static IObservable<System.Boolean> get_ShouldExitCurrentIteration(this IObservable<System.Threading.Tasks.ParallelLoopState> ParallelLoopStateValue)
        {
            return Observable.Select(ParallelLoopStateValue, (ParallelLoopStateValueLambda) => ParallelLoopStateValueLambda.ShouldExitCurrentIteration);
        }


        public static IObservable<System.Boolean> get_IsStopped(this IObservable<System.Threading.Tasks.ParallelLoopState> ParallelLoopStateValue)
        {
            return Observable.Select(ParallelLoopStateValue, (ParallelLoopStateValueLambda) => ParallelLoopStateValueLambda.IsStopped);
        }


        public static IObservable<System.Boolean> get_IsExceptional(this IObservable<System.Threading.Tasks.ParallelLoopState> ParallelLoopStateValue)
        {
            return Observable.Select(ParallelLoopStateValue, (ParallelLoopStateValueLambda) => ParallelLoopStateValueLambda.IsExceptional);
        }


        public static IObservable<System.Nullable<System.Int64>> get_LowestBreakIteration(this IObservable<System.Threading.Tasks.ParallelLoopState> ParallelLoopStateValue)
        {
            return Observable.Select(ParallelLoopStateValue, (ParallelLoopStateValueLambda) => ParallelLoopStateValueLambda.LowestBreakIteration);
        }

    }
}