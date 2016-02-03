using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading.Tasks
{
    public static class __TaskFactory
    {
        public static IObservable<System.Reactive.Unit> StartNew(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue, IObservable<System.Action> action)
        {
            return
                Observable.Zip(TaskFactoryValue, action,
                    (TaskFactoryValueLambda, actionLambda) =>
                        TaskFactoryValueLambda.StartNew(actionLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> StartNew(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue, IObservable<System.Action> action,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(TaskFactoryValue, action, cancellationToken,
                    (TaskFactoryValueLambda, actionLambda, cancellationTokenLambda) =>
                        TaskFactoryValueLambda.StartNew(actionLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> StartNew(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue, IObservable<System.Action> action,
            IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, action, creationOptions,
                    (TaskFactoryValueLambda, actionLambda, creationOptionsLambda) =>
                        TaskFactoryValueLambda.StartNew(actionLambda, creationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> StartNew(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue, IObservable<System.Action> action,
            IObservable<System.Threading.CancellationToken> cancellationToken,
            IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions,
            IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return
                Observable.Zip(TaskFactoryValue, action, cancellationToken, creationOptions, scheduler,
                    (TaskFactoryValueLambda, actionLambda, cancellationTokenLambda, creationOptionsLambda,
                        schedulerLambda) =>
                        TaskFactoryValueLambda.StartNew(actionLambda, cancellationTokenLambda, creationOptionsLambda,
                            schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> StartNew(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Action<System.Object>> action, IObservable<System.Object> state)
        {
            return
                Observable.Zip(TaskFactoryValue, action, state,
                    (TaskFactoryValueLambda, actionLambda, stateLambda) =>
                        TaskFactoryValueLambda.StartNew(actionLambda, stateLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> StartNew(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Action<System.Object>> action, IObservable<System.Object> state,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(TaskFactoryValue, action, state, cancellationToken,
                    (TaskFactoryValueLambda, actionLambda, stateLambda, cancellationTokenLambda) =>
                        TaskFactoryValueLambda.StartNew(actionLambda, stateLambda, cancellationTokenLambda)
                            .ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> StartNew(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Action<System.Object>> action, IObservable<System.Object> state,
            IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, action, state, creationOptions,
                    (TaskFactoryValueLambda, actionLambda, stateLambda, creationOptionsLambda) =>
                        TaskFactoryValueLambda.StartNew(actionLambda, stateLambda, creationOptionsLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<System.Reactive.Unit> StartNew(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Action<System.Object>> action, IObservable<System.Object> state,
            IObservable<System.Threading.CancellationToken> cancellationToken,
            IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions,
            IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return
                Observable.Zip(TaskFactoryValue, action, state, cancellationToken, creationOptions, scheduler,
                    (TaskFactoryValueLambda, actionLambda, stateLambda, cancellationTokenLambda, creationOptionsLambda,
                        schedulerLambda) =>
                        TaskFactoryValueLambda.StartNew(actionLambda, stateLambda, cancellationTokenLambda,
                            creationOptionsLambda, schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> StartNew<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue, IObservable<Func<TResult>> function)
        {
            return
                Observable.Zip(TaskFactoryValue, function,
                    (TaskFactoryValueLambda, functionLambda) =>
                        TaskFactoryValueLambda.StartNew(functionLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> StartNew<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue, IObservable<Func<TResult>> function,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(TaskFactoryValue, function, cancellationToken,
                    (TaskFactoryValueLambda, functionLambda, cancellationTokenLambda) =>
                        TaskFactoryValueLambda.StartNew(functionLambda, cancellationTokenLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<TResult> StartNew<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue, IObservable<Func<TResult>> function,
            IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, function, creationOptions,
                    (TaskFactoryValueLambda, functionLambda, creationOptionsLambda) =>
                        TaskFactoryValueLambda.StartNew(functionLambda, creationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> StartNew<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue, IObservable<Func<TResult>> function,
            IObservable<System.Threading.CancellationToken> cancellationToken,
            IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions,
            IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return
                Observable.Zip(TaskFactoryValue, function, cancellationToken, creationOptions, scheduler,
                    (TaskFactoryValueLambda, functionLambda, cancellationTokenLambda, creationOptionsLambda,
                        schedulerLambda) =>
                        TaskFactoryValueLambda.StartNew(functionLambda, cancellationTokenLambda, creationOptionsLambda,
                            schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> StartNew<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Func<System.Object, TResult>> function, IObservable<System.Object> state)
        {
            return
                Observable.Zip(TaskFactoryValue, function, state,
                    (TaskFactoryValueLambda, functionLambda, stateLambda) =>
                        TaskFactoryValueLambda.StartNew(functionLambda, stateLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> StartNew<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Func<System.Object, TResult>> function, IObservable<System.Object> state,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(TaskFactoryValue, function, state, cancellationToken,
                    (TaskFactoryValueLambda, functionLambda, stateLambda, cancellationTokenLambda) =>
                        TaskFactoryValueLambda.StartNew(functionLambda, stateLambda, cancellationTokenLambda)
                            .ToObservable()).Flatten();
        }


        public static IObservable<TResult> StartNew<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Func<System.Object, TResult>> function, IObservable<System.Object> state,
            IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, function, state, creationOptions,
                    (TaskFactoryValueLambda, functionLambda, stateLambda, creationOptionsLambda) =>
                        TaskFactoryValueLambda.StartNew(functionLambda, stateLambda, creationOptionsLambda)
                            .ToObservable()).Flatten();
        }


        public static IObservable<TResult> StartNew<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Func<System.Object, TResult>> function, IObservable<System.Object> state,
            IObservable<System.Threading.CancellationToken> cancellationToken,
            IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions,
            IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return
                Observable.Zip(TaskFactoryValue, function, state, cancellationToken, creationOptions, scheduler,
                    (TaskFactoryValueLambda, functionLambda, stateLambda, cancellationTokenLambda, creationOptionsLambda,
                        schedulerLambda) =>
                        TaskFactoryValueLambda.StartNew(functionLambda, stateLambda, cancellationTokenLambda,
                            creationOptionsLambda, schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> FromAsync(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.IAsyncResult> asyncResult, IObservable<System.Action<System.IAsyncResult>> endMethod)
        {
            return
                Observable.Zip(TaskFactoryValue, asyncResult, endMethod,
                    (TaskFactoryValueLambda, asyncResultLambda, endMethodLambda) =>
                        TaskFactoryValueLambda.FromAsync(asyncResultLambda, endMethodLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> FromAsync(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.IAsyncResult> asyncResult, IObservable<System.Action<System.IAsyncResult>> endMethod,
            IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, asyncResult, endMethod, creationOptions,
                    (TaskFactoryValueLambda, asyncResultLambda, endMethodLambda, creationOptionsLambda) =>
                        TaskFactoryValueLambda.FromAsync(asyncResultLambda, endMethodLambda, creationOptionsLambda)
                            .ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> FromAsync(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.IAsyncResult> asyncResult, IObservable<System.Action<System.IAsyncResult>> endMethod,
            IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions,
            IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return
                Observable.Zip(TaskFactoryValue, asyncResult, endMethod, creationOptions, scheduler,
                    (TaskFactoryValueLambda, asyncResultLambda, endMethodLambda, creationOptionsLambda, schedulerLambda)
                        =>
                        TaskFactoryValueLambda.FromAsync(asyncResultLambda, endMethodLambda, creationOptionsLambda,
                            schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> FromAsync(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Func<System.AsyncCallback, System.Object, System.IAsyncResult>> beginMethod,
            IObservable<System.Action<System.IAsyncResult>> endMethod, IObservable<System.Object> state)
        {
            return
                Observable.Zip(TaskFactoryValue, beginMethod, endMethod, state,
                    (TaskFactoryValueLambda, beginMethodLambda, endMethodLambda, stateLambda) =>
                        TaskFactoryValueLambda.FromAsync(beginMethodLambda, endMethodLambda, stateLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<System.Reactive.Unit> FromAsync(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Func<System.AsyncCallback, System.Object, System.IAsyncResult>> beginMethod,
            IObservable<System.Action<System.IAsyncResult>> endMethod, IObservable<System.Object> state,
            IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, beginMethod, endMethod, state, creationOptions,
                    (TaskFactoryValueLambda, beginMethodLambda, endMethodLambda, stateLambda, creationOptionsLambda) =>
                        TaskFactoryValueLambda.FromAsync(beginMethodLambda, endMethodLambda, stateLambda,
                            creationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> FromAsync<TArg1>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Func<TArg1, System.AsyncCallback, System.Object, System.IAsyncResult>> beginMethod,
            IObservable<System.Action<System.IAsyncResult>> endMethod, IObservable<TArg1> arg1,
            IObservable<System.Object> state)
        {
            return
                Observable.Zip(TaskFactoryValue, beginMethod, endMethod, arg1, state,
                    (TaskFactoryValueLambda, beginMethodLambda, endMethodLambda, arg1Lambda, stateLambda) =>
                        TaskFactoryValueLambda.FromAsync(beginMethodLambda, endMethodLambda, arg1Lambda, stateLambda)
                            .ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> FromAsync<TArg1>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Func<TArg1, System.AsyncCallback, System.Object, System.IAsyncResult>> beginMethod,
            IObservable<System.Action<System.IAsyncResult>> endMethod, IObservable<TArg1> arg1,
            IObservable<System.Object> state, IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, beginMethod, endMethod, arg1, state, creationOptions,
                    (TaskFactoryValueLambda, beginMethodLambda, endMethodLambda, arg1Lambda, stateLambda,
                        creationOptionsLambda) =>
                        TaskFactoryValueLambda.FromAsync(beginMethodLambda, endMethodLambda, arg1Lambda, stateLambda,
                            creationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> FromAsync<TArg1, TArg2>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Func<TArg1, TArg2, System.AsyncCallback, System.Object, System.IAsyncResult>> beginMethod,
            IObservable<System.Action<System.IAsyncResult>> endMethod, IObservable<TArg1> arg1, IObservable<TArg2> arg2,
            IObservable<System.Object> state)
        {
            return
                Observable.Zip(TaskFactoryValue, beginMethod, endMethod, arg1, arg2, state,
                    (TaskFactoryValueLambda, beginMethodLambda, endMethodLambda, arg1Lambda, arg2Lambda, stateLambda) =>
                        TaskFactoryValueLambda.FromAsync(beginMethodLambda, endMethodLambda, arg1Lambda, arg2Lambda,
                            stateLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> FromAsync<TArg1, TArg2>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Func<TArg1, TArg2, System.AsyncCallback, System.Object, System.IAsyncResult>> beginMethod,
            IObservable<System.Action<System.IAsyncResult>> endMethod, IObservable<TArg1> arg1, IObservable<TArg2> arg2,
            IObservable<System.Object> state, IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, beginMethod, endMethod, arg1, arg2, state, creationOptions,
                    (TaskFactoryValueLambda, beginMethodLambda, endMethodLambda, arg1Lambda, arg2Lambda, stateLambda,
                        creationOptionsLambda) =>
                        TaskFactoryValueLambda.FromAsync(beginMethodLambda, endMethodLambda, arg1Lambda, arg2Lambda,
                            stateLambda, creationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> FromAsync<TArg1, TArg2, TArg3>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Func<TArg1, TArg2, TArg3, System.AsyncCallback, System.Object, System.IAsyncResult>> beginMethod,
            IObservable<System.Action<System.IAsyncResult>> endMethod, IObservable<TArg1> arg1, IObservable<TArg2> arg2,
            IObservable<TArg3> arg3, IObservable<System.Object> state)
        {
            return
                Observable.Zip(TaskFactoryValue, beginMethod, endMethod, arg1, arg2, arg3, state,
                    (TaskFactoryValueLambda, beginMethodLambda, endMethodLambda, arg1Lambda, arg2Lambda, arg3Lambda,
                        stateLambda) =>
                        TaskFactoryValueLambda.FromAsync(beginMethodLambda, endMethodLambda, arg1Lambda, arg2Lambda,
                            arg3Lambda, stateLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> FromAsync<TArg1, TArg2, TArg3>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Func<TArg1, TArg2, TArg3, System.AsyncCallback, System.Object, System.IAsyncResult>> beginMethod,
            IObservable<System.Action<System.IAsyncResult>> endMethod, IObservable<TArg1> arg1, IObservable<TArg2> arg2,
            IObservable<TArg3> arg3, IObservable<System.Object> state,
            IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, beginMethod, endMethod, arg1, arg2, arg3, state, creationOptions,
                    (TaskFactoryValueLambda, beginMethodLambda, endMethodLambda, arg1Lambda, arg2Lambda, arg3Lambda,
                        stateLambda, creationOptionsLambda) =>
                        TaskFactoryValueLambda.FromAsync(beginMethodLambda, endMethodLambda, arg1Lambda, arg2Lambda,
                            arg3Lambda, stateLambda, creationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> FromAsync<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.IAsyncResult> asyncResult, IObservable<Func<System.IAsyncResult, TResult>> endMethod)
        {
            return
                Observable.Zip(TaskFactoryValue, asyncResult, endMethod,
                    (TaskFactoryValueLambda, asyncResultLambda, endMethodLambda) =>
                        TaskFactoryValueLambda.FromAsync(asyncResultLambda, endMethodLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> FromAsync<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.IAsyncResult> asyncResult, IObservable<Func<System.IAsyncResult, TResult>> endMethod,
            IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, asyncResult, endMethod, creationOptions,
                    (TaskFactoryValueLambda, asyncResultLambda, endMethodLambda, creationOptionsLambda) =>
                        TaskFactoryValueLambda.FromAsync(asyncResultLambda, endMethodLambda, creationOptionsLambda)
                            .ToObservable()).Flatten();
        }


        public static IObservable<TResult> FromAsync<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.IAsyncResult> asyncResult, IObservable<Func<System.IAsyncResult, TResult>> endMethod,
            IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions,
            IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return
                Observable.Zip(TaskFactoryValue, asyncResult, endMethod, creationOptions, scheduler,
                    (TaskFactoryValueLambda, asyncResultLambda, endMethodLambda, creationOptionsLambda, schedulerLambda)
                        =>
                        TaskFactoryValueLambda.FromAsync(asyncResultLambda, endMethodLambda, creationOptionsLambda,
                            schedulerLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> FromAsync<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Func<System.AsyncCallback, System.Object, System.IAsyncResult>> beginMethod,
            IObservable<Func<System.IAsyncResult, TResult>> endMethod, IObservable<System.Object> state)
        {
            return
                Observable.Zip(TaskFactoryValue, beginMethod, endMethod, state,
                    (TaskFactoryValueLambda, beginMethodLambda, endMethodLambda, stateLambda) =>
                        TaskFactoryValueLambda.FromAsync(beginMethodLambda, endMethodLambda, stateLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<TResult> FromAsync<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Func<System.AsyncCallback, System.Object, System.IAsyncResult>> beginMethod,
            IObservable<Func<System.IAsyncResult, TResult>> endMethod, IObservable<System.Object> state,
            IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, beginMethod, endMethod, state, creationOptions,
                    (TaskFactoryValueLambda, beginMethodLambda, endMethodLambda, stateLambda, creationOptionsLambda) =>
                        TaskFactoryValueLambda.FromAsync(beginMethodLambda, endMethodLambda, stateLambda,
                            creationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> FromAsync<TArg1, TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Func<TArg1, System.AsyncCallback, System.Object, System.IAsyncResult>> beginMethod,
            IObservable<Func<System.IAsyncResult, TResult>> endMethod, IObservable<TArg1> arg1,
            IObservable<System.Object> state)
        {
            return
                Observable.Zip(TaskFactoryValue, beginMethod, endMethod, arg1, state,
                    (TaskFactoryValueLambda, beginMethodLambda, endMethodLambda, arg1Lambda, stateLambda) =>
                        TaskFactoryValueLambda.FromAsync(beginMethodLambda, endMethodLambda, arg1Lambda, stateLambda)
                            .ToObservable()).Flatten();
        }


        public static IObservable<TResult> FromAsync<TArg1, TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Func<TArg1, System.AsyncCallback, System.Object, System.IAsyncResult>> beginMethod,
            IObservable<Func<System.IAsyncResult, TResult>> endMethod, IObservable<TArg1> arg1,
            IObservable<System.Object> state, IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, beginMethod, endMethod, arg1, state, creationOptions,
                    (TaskFactoryValueLambda, beginMethodLambda, endMethodLambda, arg1Lambda, stateLambda,
                        creationOptionsLambda) =>
                        TaskFactoryValueLambda.FromAsync(beginMethodLambda, endMethodLambda, arg1Lambda, stateLambda,
                            creationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> FromAsync<TArg1, TArg2, TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Func<TArg1, TArg2, System.AsyncCallback, System.Object, System.IAsyncResult>> beginMethod,
            IObservable<Func<System.IAsyncResult, TResult>> endMethod, IObservable<TArg1> arg1, IObservable<TArg2> arg2,
            IObservable<System.Object> state)
        {
            return
                Observable.Zip(TaskFactoryValue, beginMethod, endMethod, arg1, arg2, state,
                    (TaskFactoryValueLambda, beginMethodLambda, endMethodLambda, arg1Lambda, arg2Lambda, stateLambda) =>
                        TaskFactoryValueLambda.FromAsync(beginMethodLambda, endMethodLambda, arg1Lambda, arg2Lambda,
                            stateLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> FromAsync<TArg1, TArg2, TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Func<TArg1, TArg2, System.AsyncCallback, System.Object, System.IAsyncResult>> beginMethod,
            IObservable<Func<System.IAsyncResult, TResult>> endMethod, IObservable<TArg1> arg1, IObservable<TArg2> arg2,
            IObservable<System.Object> state, IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, beginMethod, endMethod, arg1, arg2, state, creationOptions,
                    (TaskFactoryValueLambda, beginMethodLambda, endMethodLambda, arg1Lambda, arg2Lambda, stateLambda,
                        creationOptionsLambda) =>
                        TaskFactoryValueLambda.FromAsync(beginMethodLambda, endMethodLambda, arg1Lambda, arg2Lambda,
                            stateLambda, creationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Func<TArg1, TArg2, TArg3, System.AsyncCallback, System.Object, System.IAsyncResult>> beginMethod,
            IObservable<Func<System.IAsyncResult, TResult>> endMethod, IObservable<TArg1> arg1, IObservable<TArg2> arg2,
            IObservable<TArg3> arg3, IObservable<System.Object> state)
        {
            return
                Observable.Zip(TaskFactoryValue, beginMethod, endMethod, arg1, arg2, arg3, state,
                    (TaskFactoryValueLambda, beginMethodLambda, endMethodLambda, arg1Lambda, arg2Lambda, arg3Lambda,
                        stateLambda) =>
                        TaskFactoryValueLambda.FromAsync(beginMethodLambda, endMethodLambda, arg1Lambda, arg2Lambda,
                            arg3Lambda, stateLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Func<TArg1, TArg2, TArg3, System.AsyncCallback, System.Object, System.IAsyncResult>> beginMethod,
            IObservable<Func<System.IAsyncResult, TResult>> endMethod, IObservable<TArg1> arg1, IObservable<TArg2> arg2,
            IObservable<TArg3> arg3, IObservable<System.Object> state,
            IObservable<System.Threading.Tasks.TaskCreationOptions> creationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, beginMethod, endMethod, arg1, arg2, arg3, state, creationOptions,
                    (TaskFactoryValueLambda, beginMethodLambda, endMethodLambda, arg1Lambda, arg2Lambda, arg3Lambda,
                        stateLambda, creationOptionsLambda) =>
                        TaskFactoryValueLambda.FromAsync(beginMethodLambda, endMethodLambda, arg1Lambda, arg2Lambda,
                            arg3Lambda, stateLambda, creationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWhenAll(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Threading.Tasks.Task[]> tasks,
            IObservable<System.Action<System.Threading.Tasks.Task[]>> continuationAction)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationAction,
                    (TaskFactoryValueLambda, tasksLambda, continuationActionLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAll(tasksLambda, continuationActionLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWhenAll(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Threading.Tasks.Task[]> tasks,
            IObservable<System.Action<System.Threading.Tasks.Task[]>> continuationAction,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationAction, cancellationToken,
                    (TaskFactoryValueLambda, tasksLambda, continuationActionLambda, cancellationTokenLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAll(tasksLambda, continuationActionLambda,
                            cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWhenAll(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Threading.Tasks.Task[]> tasks,
            IObservable<System.Action<System.Threading.Tasks.Task[]>> continuationAction,
            IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationAction, continuationOptions,
                    (TaskFactoryValueLambda, tasksLambda, continuationActionLambda, continuationOptionsLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAll(tasksLambda, continuationActionLambda,
                            continuationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWhenAll(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Threading.Tasks.Task[]> tasks,
            IObservable<System.Action<System.Threading.Tasks.Task[]>> continuationAction,
            IObservable<System.Threading.CancellationToken> cancellationToken,
            IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions,
            IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationAction, cancellationToken, continuationOptions,
                    scheduler,
                    (TaskFactoryValueLambda, tasksLambda, continuationActionLambda, cancellationTokenLambda,
                        continuationOptionsLambda, schedulerLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAll(tasksLambda, continuationActionLambda,
                            cancellationTokenLambda, continuationOptionsLambda, schedulerLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWhenAll<TAntecedentResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Task<TAntecedentResult>[]> tasks,
            IObservable<Action<Task<TAntecedentResult>[]>> continuationAction)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationAction,
                    (TaskFactoryValueLambda, tasksLambda, continuationActionLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAll(tasksLambda, continuationActionLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWhenAll<TAntecedentResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Task<TAntecedentResult>[]> tasks,
            IObservable<Action<Task<TAntecedentResult>[]>> continuationAction,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationAction, cancellationToken,
                    (TaskFactoryValueLambda, tasksLambda, continuationActionLambda, cancellationTokenLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAll(tasksLambda, continuationActionLambda,
                            cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWhenAll<TAntecedentResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Task<TAntecedentResult>[]> tasks,
            IObservable<Action<Task<TAntecedentResult>[]>> continuationAction,
            IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationAction, continuationOptions,
                    (TaskFactoryValueLambda, tasksLambda, continuationActionLambda, continuationOptionsLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAll(tasksLambda, continuationActionLambda,
                            continuationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWhenAll<TAntecedentResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Task<TAntecedentResult>[]> tasks,
            IObservable<Action<Task<TAntecedentResult>[]>> continuationAction,
            IObservable<System.Threading.CancellationToken> cancellationToken,
            IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions,
            IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationAction, cancellationToken, continuationOptions,
                    scheduler,
                    (TaskFactoryValueLambda, tasksLambda, continuationActionLambda, cancellationTokenLambda,
                        continuationOptionsLambda, schedulerLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAll(tasksLambda, continuationActionLambda,
                            cancellationTokenLambda, continuationOptionsLambda, schedulerLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<TResult> ContinueWhenAll<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Threading.Tasks.Task[]> tasks,
            IObservable<Func<System.Threading.Tasks.Task[], TResult>> continuationFunction)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationFunction,
                    (TaskFactoryValueLambda, tasksLambda, continuationFunctionLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAll(tasksLambda, continuationFunctionLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<TResult> ContinueWhenAll<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Threading.Tasks.Task[]> tasks,
            IObservable<Func<System.Threading.Tasks.Task[], TResult>> continuationFunction,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationFunction, cancellationToken,
                    (TaskFactoryValueLambda, tasksLambda, continuationFunctionLambda, cancellationTokenLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAll(tasksLambda, continuationFunctionLambda,
                            cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> ContinueWhenAll<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Threading.Tasks.Task[]> tasks,
            IObservable<Func<System.Threading.Tasks.Task[], TResult>> continuationFunction,
            IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationFunction, continuationOptions,
                    (TaskFactoryValueLambda, tasksLambda, continuationFunctionLambda, continuationOptionsLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAll(tasksLambda, continuationFunctionLambda,
                            continuationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> ContinueWhenAll<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Threading.Tasks.Task[]> tasks,
            IObservable<Func<System.Threading.Tasks.Task[], TResult>> continuationFunction,
            IObservable<System.Threading.CancellationToken> cancellationToken,
            IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions,
            IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationFunction, cancellationToken, continuationOptions,
                    scheduler,
                    (TaskFactoryValueLambda, tasksLambda, continuationFunctionLambda, cancellationTokenLambda,
                        continuationOptionsLambda, schedulerLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAll(tasksLambda, continuationFunctionLambda,
                            cancellationTokenLambda, continuationOptionsLambda, schedulerLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<TResult> ContinueWhenAll<TAntecedentResult, TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Task<TAntecedentResult>[]> tasks,
            IObservable<Func<Task<TAntecedentResult>[], TResult>> continuationFunction)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationFunction,
                    (TaskFactoryValueLambda, tasksLambda, continuationFunctionLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAll(tasksLambda, continuationFunctionLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<TResult> ContinueWhenAll<TAntecedentResult, TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Task<TAntecedentResult>[]> tasks,
            IObservable<Func<Task<TAntecedentResult>[], TResult>> continuationFunction,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationFunction, cancellationToken,
                    (TaskFactoryValueLambda, tasksLambda, continuationFunctionLambda, cancellationTokenLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAll(tasksLambda, continuationFunctionLambda,
                            cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> ContinueWhenAll<TAntecedentResult, TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Task<TAntecedentResult>[]> tasks,
            IObservable<Func<Task<TAntecedentResult>[], TResult>> continuationFunction,
            IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationFunction, continuationOptions,
                    (TaskFactoryValueLambda, tasksLambda, continuationFunctionLambda, continuationOptionsLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAll(tasksLambda, continuationFunctionLambda,
                            continuationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> ContinueWhenAll<TAntecedentResult, TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Task<TAntecedentResult>[]> tasks,
            IObservable<Func<Task<TAntecedentResult>[], TResult>> continuationFunction,
            IObservable<System.Threading.CancellationToken> cancellationToken,
            IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions,
            IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationFunction, cancellationToken, continuationOptions,
                    scheduler,
                    (TaskFactoryValueLambda, tasksLambda, continuationFunctionLambda, cancellationTokenLambda,
                        continuationOptionsLambda, schedulerLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAll(tasksLambda, continuationFunctionLambda,
                            cancellationTokenLambda, continuationOptionsLambda, schedulerLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWhenAny(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Threading.Tasks.Task[]> tasks,
            IObservable<System.Action<System.Threading.Tasks.Task>> continuationAction)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationAction,
                    (TaskFactoryValueLambda, tasksLambda, continuationActionLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAny(tasksLambda, continuationActionLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWhenAny(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Threading.Tasks.Task[]> tasks,
            IObservable<System.Action<System.Threading.Tasks.Task>> continuationAction,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationAction, cancellationToken,
                    (TaskFactoryValueLambda, tasksLambda, continuationActionLambda, cancellationTokenLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAny(tasksLambda, continuationActionLambda,
                            cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWhenAny(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Threading.Tasks.Task[]> tasks,
            IObservable<System.Action<System.Threading.Tasks.Task>> continuationAction,
            IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationAction, continuationOptions,
                    (TaskFactoryValueLambda, tasksLambda, continuationActionLambda, continuationOptionsLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAny(tasksLambda, continuationActionLambda,
                            continuationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWhenAny(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Threading.Tasks.Task[]> tasks,
            IObservable<System.Action<System.Threading.Tasks.Task>> continuationAction,
            IObservable<System.Threading.CancellationToken> cancellationToken,
            IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions,
            IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationAction, cancellationToken, continuationOptions,
                    scheduler,
                    (TaskFactoryValueLambda, tasksLambda, continuationActionLambda, cancellationTokenLambda,
                        continuationOptionsLambda, schedulerLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAny(tasksLambda, continuationActionLambda,
                            cancellationTokenLambda, continuationOptionsLambda, schedulerLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<TResult> ContinueWhenAny<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Threading.Tasks.Task[]> tasks,
            IObservable<Func<System.Threading.Tasks.Task, TResult>> continuationFunction)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationFunction,
                    (TaskFactoryValueLambda, tasksLambda, continuationFunctionLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAny(tasksLambda, continuationFunctionLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<TResult> ContinueWhenAny<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Threading.Tasks.Task[]> tasks,
            IObservable<Func<System.Threading.Tasks.Task, TResult>> continuationFunction,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationFunction, cancellationToken,
                    (TaskFactoryValueLambda, tasksLambda, continuationFunctionLambda, cancellationTokenLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAny(tasksLambda, continuationFunctionLambda,
                            cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> ContinueWhenAny<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Threading.Tasks.Task[]> tasks,
            IObservable<Func<System.Threading.Tasks.Task, TResult>> continuationFunction,
            IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationFunction, continuationOptions,
                    (TaskFactoryValueLambda, tasksLambda, continuationFunctionLambda, continuationOptionsLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAny(tasksLambda, continuationFunctionLambda,
                            continuationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> ContinueWhenAny<TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<System.Threading.Tasks.Task[]> tasks,
            IObservable<Func<System.Threading.Tasks.Task, TResult>> continuationFunction,
            IObservable<System.Threading.CancellationToken> cancellationToken,
            IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions,
            IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationFunction, cancellationToken, continuationOptions,
                    scheduler,
                    (TaskFactoryValueLambda, tasksLambda, continuationFunctionLambda, cancellationTokenLambda,
                        continuationOptionsLambda, schedulerLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAny(tasksLambda, continuationFunctionLambda,
                            cancellationTokenLambda, continuationOptionsLambda, schedulerLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<TResult> ContinueWhenAny<TAntecedentResult, TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Task<TAntecedentResult>[]> tasks,
            IObservable<Func<Task<TAntecedentResult>, TResult>> continuationFunction)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationFunction,
                    (TaskFactoryValueLambda, tasksLambda, continuationFunctionLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAny(tasksLambda, continuationFunctionLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<TResult> ContinueWhenAny<TAntecedentResult, TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Task<TAntecedentResult>[]> tasks,
            IObservable<Func<Task<TAntecedentResult>, TResult>> continuationFunction,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationFunction, cancellationToken,
                    (TaskFactoryValueLambda, tasksLambda, continuationFunctionLambda, cancellationTokenLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAny(tasksLambda, continuationFunctionLambda,
                            cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> ContinueWhenAny<TAntecedentResult, TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Task<TAntecedentResult>[]> tasks,
            IObservable<Func<Task<TAntecedentResult>, TResult>> continuationFunction,
            IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationFunction, continuationOptions,
                    (TaskFactoryValueLambda, tasksLambda, continuationFunctionLambda, continuationOptionsLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAny(tasksLambda, continuationFunctionLambda,
                            continuationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<TResult> ContinueWhenAny<TAntecedentResult, TResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Task<TAntecedentResult>[]> tasks,
            IObservable<Func<Task<TAntecedentResult>, TResult>> continuationFunction,
            IObservable<System.Threading.CancellationToken> cancellationToken,
            IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions,
            IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationFunction, cancellationToken, continuationOptions,
                    scheduler,
                    (TaskFactoryValueLambda, tasksLambda, continuationFunctionLambda, cancellationTokenLambda,
                        continuationOptionsLambda, schedulerLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAny(tasksLambda, continuationFunctionLambda,
                            cancellationTokenLambda, continuationOptionsLambda, schedulerLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWhenAny<TAntecedentResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Task<TAntecedentResult>[]> tasks,
            IObservable<Action<Task<TAntecedentResult>>> continuationAction)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationAction,
                    (TaskFactoryValueLambda, tasksLambda, continuationActionLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAny(tasksLambda, continuationActionLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWhenAny<TAntecedentResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Task<TAntecedentResult>[]> tasks,
            IObservable<Action<Task<TAntecedentResult>>> continuationAction,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationAction, cancellationToken,
                    (TaskFactoryValueLambda, tasksLambda, continuationActionLambda, cancellationTokenLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAny(tasksLambda, continuationActionLambda,
                            cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWhenAny<TAntecedentResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Task<TAntecedentResult>[]> tasks,
            IObservable<Action<Task<TAntecedentResult>>> continuationAction,
            IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationAction, continuationOptions,
                    (TaskFactoryValueLambda, tasksLambda, continuationActionLambda, continuationOptionsLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAny(tasksLambda, continuationActionLambda,
                            continuationOptionsLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> ContinueWhenAny<TAntecedentResult>(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue,
            IObservable<Task<TAntecedentResult>[]> tasks,
            IObservable<Action<Task<TAntecedentResult>>> continuationAction,
            IObservable<System.Threading.CancellationToken> cancellationToken,
            IObservable<System.Threading.Tasks.TaskContinuationOptions> continuationOptions,
            IObservable<System.Threading.Tasks.TaskScheduler> scheduler)
        {
            return
                Observable.Zip(TaskFactoryValue, tasks, continuationAction, cancellationToken, continuationOptions,
                    scheduler,
                    (TaskFactoryValueLambda, tasksLambda, continuationActionLambda, cancellationTokenLambda,
                        continuationOptionsLambda, schedulerLambda) =>
                        TaskFactoryValueLambda.ContinueWhenAny(tasksLambda, continuationActionLambda,
                            cancellationTokenLambda, continuationOptionsLambda, schedulerLambda).ToObservable())
                    .Flatten();
        }


        public static IObservable<System.Threading.CancellationToken> get_CancellationToken(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue)
        {
            return Observable.Select(TaskFactoryValue,
                (TaskFactoryValueLambda) => TaskFactoryValueLambda.CancellationToken);
        }


        public static IObservable<System.Threading.Tasks.TaskScheduler> get_Scheduler(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue)
        {
            return Observable.Select(TaskFactoryValue, (TaskFactoryValueLambda) => TaskFactoryValueLambda.Scheduler);
        }


        public static IObservable<System.Threading.Tasks.TaskCreationOptions> get_CreationOptions(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue)
        {
            return Observable.Select(TaskFactoryValue,
                (TaskFactoryValueLambda) => TaskFactoryValueLambda.CreationOptions);
        }


        public static IObservable<System.Threading.Tasks.TaskContinuationOptions> get_ContinuationOptions(
            this IObservable<System.Threading.Tasks.TaskFactory> TaskFactoryValue)
        {
            return Observable.Select(TaskFactoryValue,
                (TaskFactoryValueLambda) => TaskFactoryValueLambda.ContinuationOptions);
        }
    }
}