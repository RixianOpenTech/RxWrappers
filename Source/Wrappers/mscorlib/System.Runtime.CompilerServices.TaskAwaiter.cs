using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
    public static class __TaskAwaiter
    {
        public static IObservable<System.Reactive.Unit> OnCompleted(
            this IObservable<System.Runtime.CompilerServices.TaskAwaiter> TaskAwaiterValue,
            IObservable<System.Action> continuation)
        {
            return ObservableExt.ZipExecute(TaskAwaiterValue, continuation,
                (TaskAwaiterValueLambda, continuationLambda) => TaskAwaiterValueLambda.OnCompleted(continuationLambda));
        }


        public static IObservable<System.Reactive.Unit> UnsafeOnCompleted(
            this IObservable<System.Runtime.CompilerServices.TaskAwaiter> TaskAwaiterValue,
            IObservable<System.Action> continuation)
        {
            return ObservableExt.ZipExecute(TaskAwaiterValue, continuation,
                (TaskAwaiterValueLambda, continuationLambda) =>
                    TaskAwaiterValueLambda.UnsafeOnCompleted(continuationLambda));
        }


        public static IObservable<System.Reactive.Unit> GetResult(
            this IObservable<System.Runtime.CompilerServices.TaskAwaiter> TaskAwaiterValue)
        {
            return
                Observable.Do(TaskAwaiterValue, (TaskAwaiterValueLambda) => TaskAwaiterValueLambda.GetResult()).ToUnit();
        }


        public static IObservable<System.Boolean> get_IsCompleted(
            this IObservable<System.Runtime.CompilerServices.TaskAwaiter> TaskAwaiterValue)
        {
            return Observable.Select(TaskAwaiterValue, (TaskAwaiterValueLambda) => TaskAwaiterValueLambda.IsCompleted);
        }
    }
}