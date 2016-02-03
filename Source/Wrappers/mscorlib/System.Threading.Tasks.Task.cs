using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading.Tasks
{
    public static class __Task
    {
        
        public static IObservable<System.Reactive.Unit> Start(this IObservable<System.Threading.Tasks.Task> TaskValue)
        {
            return Observable.Do(TaskValue, (TaskValueLambda) => TaskValueLambda.Start()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Start(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return ObservableExt.ZipExecute(TaskValue, scheduler, (TaskValueLambda, schedulerLambda) => TaskValueLambda.Start(schedulerLambda));
        }


        public static IObservable<System.Reactive.Unit> RunSynchronously(this IObservable<System.Threading.Tasks.Task> TaskValue)
        {
            return Observable.Do(TaskValue, (TaskValueLambda) => TaskValueLambda.RunSynchronously()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> RunSynchronously(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return ObservableExt.ZipExecute(TaskValue, scheduler, (TaskValueLambda, schedulerLambda) => TaskValueLambda.RunSynchronously(schedulerLambda));
        }


        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Threading.Tasks.Task> TaskValue)
        {
            return Observable.Do(TaskValue, (TaskValueLambda) => TaskValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Runtime.CompilerServices.TaskAwaiter> GetAwaiter(this IObservable<System.Threading.Tasks.Task> TaskValue)
        {
            return Observable.Select(TaskValue, (TaskValueLambda) => TaskValueLambda.GetAwaiter());
        }


        public static IObservable<System.Runtime.CompilerServices.ConfiguredTaskAwaitable> ConfigureAwait(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<System.Boolean> continueOnCapturedContext)
        {
            return Observable.Zip(TaskValue, continueOnCapturedContext, (TaskValueLambda, continueOnCapturedContextLambda) => TaskValueLambda.ConfigureAwait(continueOnCapturedContextLambda));
        }


        public static IObservable<System.Runtime.CompilerServices.YieldAwaitable> Yield()
        {
            return ObservableExt.Factory(() => System.Threading.Tasks.Task.Yield());
        }


        public static IObservable<System.Reactive.Unit> Wait(this IObservable<System.Threading.Tasks.Task> TaskValue)
        {
            return Observable.Do(TaskValue, (TaskValueLambda) => TaskValueLambda.Wait()).ToUnit();
        }


        public static IObservable<System.Boolean> Wait(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<System.TimeSpan> timeout)
        {
            return Observable.Zip(TaskValue, timeout, (TaskValueLambda, timeoutLambda) => TaskValueLambda.Wait(timeoutLambda));
        }


        public static IObservable<System.Reactive.Unit> Wait(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return ObservableExt.ZipExecute(TaskValue, cancellationToken, (TaskValueLambda, cancellationTokenLambda) => TaskValueLambda.Wait(cancellationTokenLambda));
        }


        public static IObservable<System.Boolean> Wait(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<System.Int32> millisecondsTimeout)
        {
            return Observable.Zip(TaskValue, millisecondsTimeout, (TaskValueLambda, millisecondsTimeoutLambda) => TaskValueLambda.Wait(millisecondsTimeoutLambda));
        }


        public static IObservable<System.Boolean> Wait(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<System.Int32> millisecondsTimeout, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(TaskValue, millisecondsTimeout, cancellationToken, (TaskValueLambda, millisecondsTimeoutLambda, cancellationTokenLambda) => TaskValueLambda.Wait(millisecondsTimeoutLambda, cancellationTokenLambda));
        }


        public static IObservable<System.Reactive.Unit> ContinueWith(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<System.Action<System.Threading.Tasks.Task>> continuationAction)
        {
            return Observable.Zip(TaskValue, continuationAction, (TaskValueLambda, continuationActionLambda) => TaskValueLambda.ContinueWith(continuationActionLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWith(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<System.Action<System.Threading.Tasks.Task>> continuationAction, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(TaskValue, continuationAction, cancellationToken, (TaskValueLambda, continuationActionLambda, cancellationTokenLambda) => TaskValueLambda.ContinueWith(continuationActionLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWith(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<System.Action<System.Threading.Tasks.Task>> continuationAction, IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return Observable.Zip(TaskValue, continuationAction, scheduler, (TaskValueLambda, continuationActionLambda, schedulerLambda) => TaskValueLambda.ContinueWith(continuationActionLambda, schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWith(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<System.Action<System.Threading.Tasks.Task>> continuationAction, IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions)
        {
            return Observable.Zip(TaskValue, continuationAction, continuationOptions, (TaskValueLambda, continuationActionLambda, continuationOptionsLambda) => TaskValueLambda.ContinueWith(continuationActionLambda, continuationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWith(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<System.Action<System.Threading.Tasks.Task>> continuationAction, IObservable<System.Threading.CancellationToken> cancellationToken, IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions, IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return Observable.Zip(TaskValue, continuationAction, cancellationToken, continuationOptions, scheduler, (TaskValueLambda, continuationActionLambda, cancellationTokenLambda, continuationOptionsLambda, schedulerLambda) => TaskValueLambda.ContinueWith(continuationActionLambda, cancellationTokenLambda, continuationOptionsLambda, schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWith(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<System.Action<System.Threading.Tasks.Task, System.Object>> continuationAction, IObservable<System.Object> state)
        {
            return Observable.Zip(TaskValue, continuationAction, state, (TaskValueLambda, continuationActionLambda, stateLambda) => TaskValueLambda.ContinueWith(continuationActionLambda, stateLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWith(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<System.Action<System.Threading.Tasks.Task, System.Object>> continuationAction, IObservable<System.Object> state, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(TaskValue, continuationAction, state, cancellationToken, (TaskValueLambda, continuationActionLambda, stateLambda, cancellationTokenLambda) => TaskValueLambda.ContinueWith(continuationActionLambda, stateLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWith(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<System.Action<System.Threading.Tasks.Task, System.Object>> continuationAction, IObservable<System.Object> state, IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return Observable.Zip(TaskValue, continuationAction, state, scheduler, (TaskValueLambda, continuationActionLambda, stateLambda, schedulerLambda) => TaskValueLambda.ContinueWith(continuationActionLambda, stateLambda, schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWith(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<System.Action<System.Threading.Tasks.Task, System.Object>> continuationAction, IObservable<System.Object> state, IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions)
        {
            return Observable.Zip(TaskValue, continuationAction, state, continuationOptions, (TaskValueLambda, continuationActionLambda, stateLambda, continuationOptionsLambda) => TaskValueLambda.ContinueWith(continuationActionLambda, stateLambda, continuationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWith(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<System.Action<System.Threading.Tasks.Task, System.Object>> continuationAction, IObservable<System.Object> state, IObservable<System.Threading.CancellationToken> cancellationToken, IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions, IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return Observable.Zip(TaskValue, continuationAction, state, cancellationToken, continuationOptions, scheduler, (TaskValueLambda, continuationActionLambda, stateLambda, cancellationTokenLambda, continuationOptionsLambda, schedulerLambda) => TaskValueLambda.ContinueWith(continuationActionLambda, stateLambda, cancellationTokenLambda, continuationOptionsLambda, schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<Func<System.Threading.Tasks.Task, TResult>> continuationFunction)
        {
            return Observable.Zip(TaskValue, continuationFunction, (TaskValueLambda, continuationFunctionLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<Func<System.Threading.Tasks.Task, TResult>> continuationFunction, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(TaskValue, continuationFunction, cancellationToken, (TaskValueLambda, continuationFunctionLambda, cancellationTokenLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<Func<System.Threading.Tasks.Task, TResult>> continuationFunction, IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return Observable.Zip(TaskValue, continuationFunction, scheduler, (TaskValueLambda, continuationFunctionLambda, schedulerLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda, schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<Func<System.Threading.Tasks.Task, TResult>> continuationFunction, IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions)
        {
            return Observable.Zip(TaskValue, continuationFunction, continuationOptions, (TaskValueLambda, continuationFunctionLambda, continuationOptionsLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda, continuationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<Func<System.Threading.Tasks.Task, TResult>> continuationFunction, IObservable<System.Threading.CancellationToken> cancellationToken, IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions, IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return Observable.Zip(TaskValue, continuationFunction, cancellationToken, continuationOptions, scheduler, (TaskValueLambda, continuationFunctionLambda, cancellationTokenLambda, continuationOptionsLambda, schedulerLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda, cancellationTokenLambda, continuationOptionsLambda, schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<Func<System.Threading.Tasks.Task, System.Object, TResult>> continuationFunction, IObservable<System.Object> state)
        {
            return Observable.Zip(TaskValue, continuationFunction, state, (TaskValueLambda, continuationFunctionLambda, stateLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda, stateLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<Func<System.Threading.Tasks.Task, System.Object, TResult>> continuationFunction, IObservable<System.Object> state, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(TaskValue, continuationFunction, state, cancellationToken, (TaskValueLambda, continuationFunctionLambda, stateLambda, cancellationTokenLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda, stateLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<Func<System.Threading.Tasks.Task, System.Object, TResult>> continuationFunction, IObservable<System.Object> state, IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return Observable.Zip(TaskValue, continuationFunction, state, scheduler, (TaskValueLambda, continuationFunctionLambda, stateLambda, schedulerLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda, stateLambda, schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<Func<System.Threading.Tasks.Task, System.Object, TResult>> continuationFunction, IObservable<System.Object> state, IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions)
        {
            return Observable.Zip(TaskValue, continuationFunction, state, continuationOptions, (TaskValueLambda, continuationFunctionLambda, stateLambda, continuationOptionsLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda, stateLambda, continuationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> ContinueWith<TResult>(this IObservable<System.Threading.Tasks.Task> TaskValue, IObservable<Func<System.Threading.Tasks.Task, System.Object, TResult>> continuationFunction, IObservable<System.Object> state, IObservable<System.Threading.CancellationToken> cancellationToken, IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions, IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return Observable.Zip(TaskValue, continuationFunction, state, cancellationToken, continuationOptions, scheduler, (TaskValueLambda, continuationFunctionLambda, stateLambda, cancellationTokenLambda, continuationOptionsLambda, schedulerLambda) => TaskValueLambda.ContinueWith(continuationFunctionLambda, stateLambda, cancellationTokenLambda, continuationOptionsLambda, schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> WaitAll(IObservable<System.Threading.Tasks.Task[]> tasks)
        {
            return Observable.Do(tasks, (tasksLambda) => System.Threading.Tasks.Task.WaitAll(tasksLambda)).ToUnit();
        }


        public static IObservable<System.Boolean> WaitAll(IObservable<System.Threading.Tasks.Task[]> tasks, IObservable<System.TimeSpan> timeout)
        {
            return Observable.Zip(tasks, timeout, (tasksLambda, timeoutLambda) => System.Threading.Tasks.Task.WaitAll(tasksLambda, timeoutLambda));
        }


        public static IObservable<System.Boolean> WaitAll(IObservable<System.Threading.Tasks.Task[]> tasks, IObservable<System.Int32> millisecondsTimeout)
        {
            return Observable.Zip(tasks, millisecondsTimeout, (tasksLambda, millisecondsTimeoutLambda) => System.Threading.Tasks.Task.WaitAll(tasksLambda, millisecondsTimeoutLambda));
        }


        public static IObservable<System.Reactive.Unit> WaitAll(IObservable<System.Threading.Tasks.Task[]> tasks, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return ObservableExt.ZipExecute(tasks, cancellationToken, (tasksLambda, cancellationTokenLambda) => System.Threading.Tasks.Task.WaitAll(tasksLambda, cancellationTokenLambda));
        }


        public static IObservable<System.Boolean> WaitAll(IObservable<System.Threading.Tasks.Task[]> tasks, IObservable<System.Int32> millisecondsTimeout, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(tasks, millisecondsTimeout, cancellationToken, (tasksLambda, millisecondsTimeoutLambda, cancellationTokenLambda) => System.Threading.Tasks.Task.WaitAll(tasksLambda, millisecondsTimeoutLambda, cancellationTokenLambda));
        }


        public static IObservable<System.Int32> WaitAny(IObservable<System.Threading.Tasks.Task[]> tasks)
        {
            return Observable.Select(tasks, (tasksLambda) => System.Threading.Tasks.Task.WaitAny(tasksLambda));
        }


        public static IObservable<System.Int32> WaitAny(IObservable<System.Threading.Tasks.Task[]> tasks, IObservable<System.TimeSpan> timeout)
        {
            return Observable.Zip(tasks, timeout, (tasksLambda, timeoutLambda) => System.Threading.Tasks.Task.WaitAny(tasksLambda, timeoutLambda));
        }


        public static IObservable<System.Int32> WaitAny(IObservable<System.Threading.Tasks.Task[]> tasks, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(tasks, cancellationToken, (tasksLambda, cancellationTokenLambda) => System.Threading.Tasks.Task.WaitAny(tasksLambda, cancellationTokenLambda));
        }


        public static IObservable<System.Int32> WaitAny(IObservable<System.Threading.Tasks.Task[]> tasks, IObservable<System.Int32> millisecondsTimeout)
        {
            return Observable.Zip(tasks, millisecondsTimeout, (tasksLambda, millisecondsTimeoutLambda) => System.Threading.Tasks.Task.WaitAny(tasksLambda, millisecondsTimeoutLambda));
        }


        public static IObservable<System.Int32> WaitAny(IObservable<System.Threading.Tasks.Task[]> tasks, IObservable<System.Int32> millisecondsTimeout, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(tasks, millisecondsTimeout, cancellationToken, (tasksLambda, millisecondsTimeoutLambda, cancellationTokenLambda) => System.Threading.Tasks.Task.WaitAny(tasksLambda, millisecondsTimeoutLambda, cancellationTokenLambda));
        }


        public static IObservable<TResult> FromResult<TResult>(IObservable<TResult> result)
        {
            return Observable.Select(result, (resultLambda) => System.Threading.Tasks.Task.FromResult(resultLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> FromException(IObservable<System.Exception> exception)
        {
            return Observable.Select(exception, (exceptionLambda) => System.Threading.Tasks.Task.FromException(exceptionLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> FromException<TResult>(IObservable<System.Exception> exception)
        {
            return Observable.Select(exception, (exceptionLambda) => System.Threading.Tasks.Task.FromException<TResult>(exceptionLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> FromCanceled(IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Select(cancellationToken, (cancellationTokenLambda) => System.Threading.Tasks.Task.FromCanceled(cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> FromCanceled<TResult>(IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Select(cancellationToken, (cancellationTokenLambda) => System.Threading.Tasks.Task.FromCanceled<TResult>(cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> Run(IObservable<System.Action> action)
        {
            return Observable.Select(action, (actionLambda) => System.Threading.Tasks.Task.Run(actionLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> Run(IObservable<System.Action> action, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(action, cancellationToken, (actionLambda, cancellationTokenLambda) => System.Threading.Tasks.Task.Run(actionLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> Run<TResult>(IObservable<Func<TResult>> function)
        {
            return Observable.Select(function, (functionLambda) => System.Threading.Tasks.Task.Run(functionLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> Run<TResult>(IObservable<Func<TResult>> function, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(function, cancellationToken, (functionLambda, cancellationTokenLambda) => System.Threading.Tasks.Task.Run(functionLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> Run(IObservable<System.Func<System.Threading.Tasks.Task>> function)
        {
            return Observable.Select(function, (functionLambda) => System.Threading.Tasks.Task.Run(functionLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> Run(IObservable<System.Func<System.Threading.Tasks.Task>> function, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(function, cancellationToken, (functionLambda, cancellationTokenLambda) => System.Threading.Tasks.Task.Run(functionLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> Run<TResult>(IObservable<Func<Task<TResult>>> function)
        {
            return Observable.Select(function, (functionLambda) => System.Threading.Tasks.Task.Run(functionLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> Run<TResult>(IObservable<Func<Task<TResult>>> function, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(function, cancellationToken, (functionLambda, cancellationTokenLambda) => System.Threading.Tasks.Task.Run(functionLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> Delay(IObservable<System.TimeSpan> delay)
        {
            return Observable.Select(delay, (delayLambda) => System.Threading.Tasks.Task.Delay(delayLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> Delay(IObservable<System.TimeSpan> delay, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(delay, cancellationToken, (delayLambda, cancellationTokenLambda) => System.Threading.Tasks.Task.Delay(delayLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> Delay(IObservable<System.Int32> millisecondsDelay)
        {
            return Observable.Select(millisecondsDelay, (millisecondsDelayLambda) => System.Threading.Tasks.Task.Delay(millisecondsDelayLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> Delay(IObservable<System.Int32> millisecondsDelay, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(millisecondsDelay, cancellationToken, (millisecondsDelayLambda, cancellationTokenLambda) => System.Threading.Tasks.Task.Delay(millisecondsDelayLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> WhenAll(IObservable<System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>> tasks)
        {
            return Observable.Select(tasks, (tasksLambda) => System.Threading.Tasks.Task.WhenAll(tasksLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> WhenAll(IObservable<System.Threading.Tasks.Task[]> tasks)
        {
            return Observable.Select(tasks, (tasksLambda) => System.Threading.Tasks.Task.WhenAll(tasksLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult[]> WhenAll<TResult>(IObservable<IEnumerable<Task<TResult>>> tasks)
        {
            return Observable.Select(tasks, (tasksLambda) => System.Threading.Tasks.Task.WhenAll(tasksLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult[]> WhenAll<TResult>(IObservable<Task<TResult>[]> tasks)
        {
            return Observable.Select(tasks, (tasksLambda) => System.Threading.Tasks.Task.WhenAll(tasksLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Threading.Tasks.Task> WhenAny(IObservable<System.Threading.Tasks.Task[]> tasks)
        {
            return Observable.Select(tasks, (tasksLambda) => System.Threading.Tasks.Task.WhenAny(tasksLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Threading.Tasks.Task> WhenAny(IObservable<System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>> tasks)
        {
            return Observable.Select(tasks, (tasksLambda) => System.Threading.Tasks.Task.WhenAny(tasksLambda).ToObservable()).Flatten();
        }


        public static IObservable<Task<TResult>> WhenAny<TResult>(IObservable<Task<TResult>[]> tasks)
        {
            return Observable.Select(tasks, (tasksLambda) => System.Threading.Tasks.Task.WhenAny(tasksLambda).ToObservable()).Flatten();
        }


        public static IObservable<Task<TResult>> WhenAny<TResult>(IObservable<IEnumerable<Task<TResult>>> tasks)
        {
            return Observable.Select(tasks, (tasksLambda) => System.Threading.Tasks.Task.WhenAny(tasksLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Int32> get_Id(this IObservable<System.Threading.Tasks.Task> TaskValue)
        {
            return Observable.Select(TaskValue, (TaskValueLambda) => TaskValueLambda.Id);
        }


        public static IObservable<System.Nullable<System.Int32>> get_CurrentId()
        {
            return ObservableExt.Factory(() => System.Threading.Tasks.Task.CurrentId);
        }


        public static IObservable<System.AggregateException> get_Exception(this IObservable<System.Threading.Tasks.Task> TaskValue)
        {
            return Observable.Select(TaskValue, (TaskValueLambda) => TaskValueLambda.Exception);
        }


        public static IObservable<System.Threading.Tasks.TaskStatus> get_Status(this IObservable<System.Threading.Tasks.Task> TaskValue)
        {
            return Observable.Select(TaskValue, (TaskValueLambda) => TaskValueLambda.Status);
        }


        public static IObservable<System.Boolean> get_IsCanceled(this IObservable<System.Threading.Tasks.Task> TaskValue)
        {
            return Observable.Select(TaskValue, (TaskValueLambda) => TaskValueLambda.IsCanceled);
        }


        public static IObservable<System.Boolean> get_IsCompleted(this IObservable<System.Threading.Tasks.Task> TaskValue)
        {
            return Observable.Select(TaskValue, (TaskValueLambda) => TaskValueLambda.IsCompleted);
        }


        public static IObservable<System.Threading.Tasks.TaskCreationOptions> get_CreationOptions(this IObservable<System.Threading.Tasks.Task> TaskValue)
        {
            return Observable.Select(TaskValue, (TaskValueLambda) => TaskValueLambda.CreationOptions);
        }


        public static IObservable<System.Object> get_AsyncState(this IObservable<System.Threading.Tasks.Task> TaskValue)
        {
            return Observable.Select(TaskValue, (TaskValueLambda) => TaskValueLambda.AsyncState);
        }


        public static IObservable<System.Threading.Tasks.TaskFactory> get_Factory()
        {
            return ObservableExt.Factory(() => System.Threading.Tasks.Task.Factory);
        }


        public static IObservable<System.Reactive.Unit> get_CompletedTask()
        {
            return ObservableExt.Factory(() => System.Threading.Tasks.Task.CompletedTask.ToObservable()).Flatten();
        }


        public static IObservable<System.Boolean> get_IsFaulted(this IObservable<System.Threading.Tasks.Task> TaskValue)
        {
            return Observable.Select(TaskValue, (TaskValueLambda) => TaskValueLambda.IsFaulted);
        }

    }
}