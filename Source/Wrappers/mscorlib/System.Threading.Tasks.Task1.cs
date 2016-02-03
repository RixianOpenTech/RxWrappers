using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Runtime.CompilerServices;
using MS.Core;

namespace System.Threading.Tasks
{
    public static class __Task1
    {
        
        public static IObservable<TaskAwaiter<TResult>> GetAwaiter<TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue)
        {
            return Observable.Select(TaskValue, (TaskValueLambda) => TaskValueLambda.GetAwaiter());
        }


        public static IObservable<ConfiguredTaskAwaitable<TResult>> ConfigureAwait<TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<System.Boolean> continueOnCapturedContext)
        {
            return Observable.Zip(TaskValue, continueOnCapturedContext, (TaskValueLambda, continueOnCapturedContextLambda) => TaskValueLambda.ConfigureAwait(continueOnCapturedContextLambda));
        }


        public static IObservable<System.Reactive.Unit> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Action<System.Threading.Tasks.Task<TResult>>> continuationAction)
        {
            return Observable.Zip(TaskValue, continuationAction, (TaskValueLambda, continuationActionLambda) => TaskValueLambda.ContinueWith(continuationActionLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Action<System.Threading.Tasks.Task<TResult>>> continuationAction, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(TaskValue, continuationAction, cancellationToken, (TaskValueLambda, continuationActionLambda, cancellationTokenLambda) => TaskValueLambda.ContinueWith(continuationActionLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Action<System.Threading.Tasks.Task<TResult>>> continuationAction, IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return Observable.Zip(TaskValue, continuationAction, scheduler, (TaskValueLambda, continuationActionLambda, schedulerLambda) => TaskValueLambda.ContinueWith(continuationActionLambda, schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Action<System.Threading.Tasks.Task<TResult>>> continuationAction, IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions)
        {
            return Observable.Zip(TaskValue, continuationAction, continuationOptions, (TaskValueLambda, continuationActionLambda, continuationOptionsLambda) => TaskValueLambda.ContinueWith(continuationActionLambda, continuationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Action<System.Threading.Tasks.Task<TResult>>> continuationAction, IObservable<System.Threading.CancellationToken> cancellationToken, IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions, IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return Observable.Zip(TaskValue, continuationAction, cancellationToken, continuationOptions, scheduler, (TaskValueLambda, continuationActionLambda, cancellationTokenLambda, continuationOptionsLambda, schedulerLambda) => TaskValueLambda.ContinueWith(continuationActionLambda, cancellationTokenLambda, continuationOptionsLambda, schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Action<System.Threading.Tasks.Task<TResult>, System.Object>> continuationAction, IObservable<System.Object> state)
        {
            return Observable.Zip(TaskValue, continuationAction, state, (TaskValueLambda, continuationActionLambda, stateLambda) => TaskValueLambda.ContinueWith(continuationActionLambda, stateLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Action<System.Threading.Tasks.Task<TResult>, System.Object>> continuationAction, IObservable<System.Object> state, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(TaskValue, continuationAction, state, cancellationToken, (TaskValueLambda, continuationActionLambda, stateLambda, cancellationTokenLambda) => TaskValueLambda.ContinueWith(continuationActionLambda, stateLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Action<System.Threading.Tasks.Task<TResult>, System.Object>> continuationAction, IObservable<System.Object> state, IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return Observable.Zip(TaskValue, continuationAction, state, scheduler, (TaskValueLambda, continuationActionLambda, stateLambda, schedulerLambda) => TaskValueLambda.ContinueWith(continuationActionLambda, stateLambda, schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Action<System.Threading.Tasks.Task<TResult>, System.Object>> continuationAction, IObservable<System.Object> state, IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions)
        {
            return Observable.Zip(TaskValue, continuationAction, state, continuationOptions, (TaskValueLambda, continuationActionLambda, stateLambda, continuationOptionsLambda) => TaskValueLambda.ContinueWith(continuationActionLambda, stateLambda, continuationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Action<System.Threading.Tasks.Task<TResult>, System.Object>> continuationAction, IObservable<System.Object> state, IObservable<System.Threading.CancellationToken> cancellationToken, IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions, IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return Observable.Zip(TaskValue, continuationAction, state, cancellationToken, continuationOptions, scheduler, (TaskValueLambda, continuationActionLambda, stateLambda, cancellationTokenLambda, continuationOptionsLambda, schedulerLambda) => TaskValueLambda.ContinueWith(continuationActionLambda, stateLambda, cancellationTokenLambda, continuationOptionsLambda, schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<TNewResult> ContinueWith<TNewResult, TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Func<System.Threading.Tasks.Task<TResult>, TNewResult>> continuationFunction)
        {
            return Observable.Zip(TaskValue, continuationFunction, (TaskValueLambda, continuationFunctionLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda).ToObservable()).Flatten();
        }


        public static IObservable<TNewResult> ContinueWith<TNewResult, TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Func<System.Threading.Tasks.Task<TResult>, TNewResult>> continuationFunction, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(TaskValue, continuationFunction, cancellationToken, (TaskValueLambda, continuationFunctionLambda, cancellationTokenLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<TNewResult> ContinueWith<TNewResult, TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Func<System.Threading.Tasks.Task<TResult>, TNewResult>> continuationFunction, IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return Observable.Zip(TaskValue, continuationFunction, scheduler, (TaskValueLambda, continuationFunctionLambda, schedulerLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda, schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<TNewResult> ContinueWith<TNewResult, TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Func<System.Threading.Tasks.Task<TResult>, TNewResult>> continuationFunction, IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions)
        {
            return Observable.Zip(TaskValue, continuationFunction, continuationOptions, (TaskValueLambda, continuationFunctionLambda, continuationOptionsLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda, continuationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<TNewResult> ContinueWith<TNewResult, TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Func<System.Threading.Tasks.Task<TResult>, TNewResult>> continuationFunction, IObservable<System.Threading.CancellationToken> cancellationToken, IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions, IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return Observable.Zip(TaskValue, continuationFunction, cancellationToken, continuationOptions, scheduler, (TaskValueLambda, continuationFunctionLambda, cancellationTokenLambda, continuationOptionsLambda, schedulerLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda, cancellationTokenLambda, continuationOptionsLambda, schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<TNewResult> ContinueWith<TNewResult, TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Func<System.Threading.Tasks.Task<TResult>, System.Object, TNewResult>> continuationFunction, IObservable<System.Object> state)
        {
            return Observable.Zip(TaskValue, continuationFunction, state, (TaskValueLambda, continuationFunctionLambda, stateLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda, stateLambda).ToObservable()).Flatten();
        }


        public static IObservable<TNewResult> ContinueWith<TNewResult, TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Func<System.Threading.Tasks.Task<TResult>, System.Object, TNewResult>> continuationFunction, IObservable<System.Object> state, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(TaskValue, continuationFunction, state, cancellationToken, (TaskValueLambda, continuationFunctionLambda, stateLambda, cancellationTokenLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda, stateLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<TNewResult> ContinueWith<TNewResult, TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Func<System.Threading.Tasks.Task<TResult>, System.Object, TNewResult>> continuationFunction, IObservable<System.Object> state, IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return Observable.Zip(TaskValue, continuationFunction, state, scheduler, (TaskValueLambda, continuationFunctionLambda, stateLambda, schedulerLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda, stateLambda, schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<TNewResult> ContinueWith<TNewResult, TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Func<System.Threading.Tasks.Task<TResult>, System.Object, TNewResult>> continuationFunction, IObservable<System.Object> state, IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions)
        {
            return Observable.Zip(TaskValue, continuationFunction, state, continuationOptions, (TaskValueLambda, continuationFunctionLambda, stateLambda, continuationOptionsLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda, stateLambda, continuationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<TNewResult> ContinueWith<TNewResult, TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue, IObservable<Func<System.Threading.Tasks.Task<TResult>, System.Object, TNewResult>> continuationFunction, IObservable<System.Object> state, IObservable<System.Threading.CancellationToken> cancellationToken, IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions, IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return Observable.Zip(TaskValue, continuationFunction, state, cancellationToken, continuationOptions, scheduler, (TaskValueLambda, continuationFunctionLambda, stateLambda, cancellationTokenLambda, continuationOptionsLambda, schedulerLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda, stateLambda, cancellationTokenLambda, continuationOptionsLambda, schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> get_Result<TResult>(this IObservable<System.Threading.Tasks.Task<TResult>> TaskValue)
        {
            return Observable.Select(TaskValue, (TaskValueLambda) => TaskValueLambda.Result);
        }


        public static IObservable<TaskFactory<TResult>> get_Factory<TResult>()
        {
            return ObservableExt.Factory(() => System.Threading.Tasks.Task<TResult>.Factory);
        }

    }
}