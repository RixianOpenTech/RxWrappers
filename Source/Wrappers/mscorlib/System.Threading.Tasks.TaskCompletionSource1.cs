using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading.Tasks
{
    public static class __TaskCompletionSource1
    {
        public static IObservable<System.Boolean> TrySetException<TResult>(
            this IObservable<System.Threading.Tasks.TaskCompletionSource<TResult>> TaskCompletionSourceValue,
            IObservable<System.Exception> exception)
        {
            return Observable.Zip(TaskCompletionSourceValue, exception,
                (TaskCompletionSourceValueLambda, exceptionLambda) =>
                    TaskCompletionSourceValueLambda.TrySetException(exceptionLambda));
        }


        public static IObservable<System.Boolean> TrySetException<TResult>(
            this IObservable<System.Threading.Tasks.TaskCompletionSource<TResult>> TaskCompletionSourceValue,
            IObservable<System.Collections.Generic.IEnumerable<System.Exception>> exceptions)
        {
            return Observable.Zip(TaskCompletionSourceValue, exceptions,
                (TaskCompletionSourceValueLambda, exceptionsLambda) =>
                    TaskCompletionSourceValueLambda.TrySetException(exceptionsLambda));
        }


        public static IObservable<System.Reactive.Unit> SetException<TResult>(
            this IObservable<System.Threading.Tasks.TaskCompletionSource<TResult>> TaskCompletionSourceValue,
            IObservable<System.Exception> exception)
        {
            return ObservableExt.ZipExecute(TaskCompletionSourceValue, exception,
                (TaskCompletionSourceValueLambda, exceptionLambda) =>
                    TaskCompletionSourceValueLambda.SetException(exceptionLambda));
        }


        public static IObservable<System.Reactive.Unit> SetException<TResult>(
            this IObservable<System.Threading.Tasks.TaskCompletionSource<TResult>> TaskCompletionSourceValue,
            IObservable<System.Collections.Generic.IEnumerable<System.Exception>> exceptions)
        {
            return ObservableExt.ZipExecute(TaskCompletionSourceValue, exceptions,
                (TaskCompletionSourceValueLambda, exceptionsLambda) =>
                    TaskCompletionSourceValueLambda.SetException(exceptionsLambda));
        }


        public static IObservable<System.Boolean> TrySetResult<TResult>(
            this IObservable<System.Threading.Tasks.TaskCompletionSource<TResult>> TaskCompletionSourceValue,
            IObservable<TResult> result)
        {
            return Observable.Zip(TaskCompletionSourceValue, result,
                (TaskCompletionSourceValueLambda, resultLambda) =>
                    TaskCompletionSourceValueLambda.TrySetResult(resultLambda));
        }


        public static IObservable<System.Reactive.Unit> SetResult<TResult>(
            this IObservable<System.Threading.Tasks.TaskCompletionSource<TResult>> TaskCompletionSourceValue,
            IObservable<TResult> result)
        {
            return ObservableExt.ZipExecute(TaskCompletionSourceValue, result,
                (TaskCompletionSourceValueLambda, resultLambda) =>
                    TaskCompletionSourceValueLambda.SetResult(resultLambda));
        }


        public static IObservable<System.Boolean> TrySetCanceled<TResult>(
            this IObservable<System.Threading.Tasks.TaskCompletionSource<TResult>> TaskCompletionSourceValue)
        {
            return Observable.Select(TaskCompletionSourceValue,
                (TaskCompletionSourceValueLambda) => TaskCompletionSourceValueLambda.TrySetCanceled());
        }


        public static IObservable<System.Boolean> TrySetCanceled<TResult>(
            this IObservable<System.Threading.Tasks.TaskCompletionSource<TResult>> TaskCompletionSourceValue,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(TaskCompletionSourceValue, cancellationToken,
                (TaskCompletionSourceValueLambda, cancellationTokenLambda) =>
                    TaskCompletionSourceValueLambda.TrySetCanceled(cancellationTokenLambda));
        }


        public static IObservable<System.Reactive.Unit> SetCanceled<TResult>(
            this IObservable<System.Threading.Tasks.TaskCompletionSource<TResult>> TaskCompletionSourceValue)
        {
            return
                Observable.Do(TaskCompletionSourceValue,
                    (TaskCompletionSourceValueLambda) => TaskCompletionSourceValueLambda.SetCanceled()).ToUnit();
        }


        public static IObservable<TResult> get_Task<TResult>(
            this IObservable<System.Threading.Tasks.TaskCompletionSource<TResult>> TaskCompletionSourceValue)
        {
            return
                Observable.Select(TaskCompletionSourceValue,
                    (TaskCompletionSourceValueLambda) => TaskCompletionSourceValueLambda.Task.ToObservable()).Flatten();
        }
    }
}