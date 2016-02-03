using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
    public static class __TaskAwaiter1
    {
        public static IObservable<System.Reactive.Unit> OnCompleted<TResult>(
            this IObservable<System.Runtime.CompilerServices.TaskAwaiter<TResult>> TaskAwaiterValue,
            IObservable<System.Action> continuation)
        {
            return ObservableExt.ZipExecute(TaskAwaiterValue, continuation,
                (TaskAwaiterValueLambda, continuationLambda) => TaskAwaiterValueLambda.OnCompleted(continuationLambda));
        }


        public static IObservable<System.Reactive.Unit> UnsafeOnCompleted<TResult>(
            this IObservable<System.Runtime.CompilerServices.TaskAwaiter<TResult>> TaskAwaiterValue,
            IObservable<System.Action> continuation)
        {
            return ObservableExt.ZipExecute(TaskAwaiterValue, continuation,
                (TaskAwaiterValueLambda, continuationLambda) =>
                    TaskAwaiterValueLambda.UnsafeOnCompleted(continuationLambda));
        }


        public static IObservable<TResult> GetResult<TResult>(
            this IObservable<System.Runtime.CompilerServices.TaskAwaiter<TResult>> TaskAwaiterValue)
        {
            return Observable.Select(TaskAwaiterValue, (TaskAwaiterValueLambda) => TaskAwaiterValueLambda.GetResult());
        }


        public static IObservable<System.Boolean> get_IsCompleted<TResult>(
            this IObservable<System.Runtime.CompilerServices.TaskAwaiter<TResult>> TaskAwaiterValue)
        {
            return Observable.Select(TaskAwaiterValue, (TaskAwaiterValueLambda) => TaskAwaiterValueLambda.IsCompleted);
        }
    }
}