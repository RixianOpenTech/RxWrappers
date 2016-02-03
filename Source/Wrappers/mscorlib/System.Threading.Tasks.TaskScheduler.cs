using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading.Tasks
{
    public static class __TaskScheduler
    {
        
        public static IObservable<System.Threading.Tasks.TaskScheduler> FromCurrentSynchronizationContext()
        {
            return ObservableExt.Factory(() => System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }


        public static IObservable<System.Int32> get_MaximumConcurrencyLevel(this IObservable<System.Threading.Tasks.TaskScheduler> TaskSchedulerValue)
        {
            return Observable.Select(TaskSchedulerValue, (TaskSchedulerValueLambda) => TaskSchedulerValueLambda.MaximumConcurrencyLevel);
        }


        public static IObservable<System.Threading.Tasks.TaskScheduler> get_Default()
        {
            return ObservableExt.Factory(() => System.Threading.Tasks.TaskScheduler.Default);
        }


        public static IObservable<System.Threading.Tasks.TaskScheduler> get_Current()
        {
            return ObservableExt.Factory(() => System.Threading.Tasks.TaskScheduler.Current);
        }


        public static IObservable<System.Int32> get_Id(this IObservable<System.Threading.Tasks.TaskScheduler> TaskSchedulerValue)
        {
            return Observable.Select(TaskSchedulerValue, (TaskSchedulerValueLambda) => TaskSchedulerValueLambda.Id);
        }

    }
}