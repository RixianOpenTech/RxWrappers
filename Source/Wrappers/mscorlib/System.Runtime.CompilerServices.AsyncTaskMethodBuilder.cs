using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
    public static class __AsyncTaskMethodBuilder
    {
        public static IObservable<System.Runtime.CompilerServices.AsyncTaskMethodBuilder> Create()
        {
            return ObservableExt.Factory(() => System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create());
        }


        public static IObservable<TStateMachine> Start<TStateMachine>(
            this IObservable<System.Runtime.CompilerServices.AsyncTaskMethodBuilder> AsyncTaskMethodBuilderValue,
            IObservable<TStateMachine> stateMachine)
            where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            return Observable.Zip(AsyncTaskMethodBuilderValue, stateMachine,
                (AsyncTaskMethodBuilderValueLambda, stateMachineLambda) =>
                {
                    AsyncTaskMethodBuilderValueLambda.Start(ref stateMachineLambda);
                    return stateMachineLambda;
                });
        }


        public static IObservable<System.Reactive.Unit> SetStateMachine(
            this IObservable<System.Runtime.CompilerServices.AsyncTaskMethodBuilder> AsyncTaskMethodBuilderValue,
            IObservable<System.Runtime.CompilerServices.IAsyncStateMachine> stateMachine)
        {
            return ObservableExt.ZipExecute(AsyncTaskMethodBuilderValue, stateMachine,
                (AsyncTaskMethodBuilderValueLambda, stateMachineLambda) =>
                    AsyncTaskMethodBuilderValueLambda.SetStateMachine(stateMachineLambda));
        }


        public static IObservable<Tuple<TAwaiter, TStateMachine>> AwaitOnCompleted<TAwaiter, TStateMachine>(
            this IObservable<System.Runtime.CompilerServices.AsyncTaskMethodBuilder> AsyncTaskMethodBuilderValue,
            IObservable<TAwaiter> awaiter, IObservable<TStateMachine> stateMachine)
            where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine where TAwaiter : INotifyCompletion
        {
            return Observable.Zip(AsyncTaskMethodBuilderValue, awaiter, stateMachine,
                (AsyncTaskMethodBuilderValueLambda, awaiterLambda, stateMachineLambda) =>
                {
                    AsyncTaskMethodBuilderValueLambda.AwaitOnCompleted(ref awaiterLambda, ref stateMachineLambda);
                    return Tuple.Create(awaiterLambda, stateMachineLambda);
                });
        }


        public static IObservable<Tuple<TAwaiter, TStateMachine>> AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(
            this IObservable<System.Runtime.CompilerServices.AsyncTaskMethodBuilder> AsyncTaskMethodBuilderValue,
            IObservable<TAwaiter> awaiter, IObservable<TStateMachine> stateMachine)
            where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine
            where TAwaiter : ICriticalNotifyCompletion
        {
            return Observable.Zip(AsyncTaskMethodBuilderValue, awaiter, stateMachine,
                (AsyncTaskMethodBuilderValueLambda, awaiterLambda, stateMachineLambda) =>
                {
                    AsyncTaskMethodBuilderValueLambda.AwaitUnsafeOnCompleted(ref awaiterLambda, ref stateMachineLambda);
                    return Tuple.Create(awaiterLambda, stateMachineLambda);
                });
        }


        public static IObservable<System.Reactive.Unit> SetResult(
            this IObservable<System.Runtime.CompilerServices.AsyncTaskMethodBuilder> AsyncTaskMethodBuilderValue)
        {
            return
                Observable.Do(AsyncTaskMethodBuilderValue,
                    (AsyncTaskMethodBuilderValueLambda) => AsyncTaskMethodBuilderValueLambda.SetResult()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> SetException(
            this IObservable<System.Runtime.CompilerServices.AsyncTaskMethodBuilder> AsyncTaskMethodBuilderValue,
            IObservable<System.Exception> exception)
        {
            return ObservableExt.ZipExecute(AsyncTaskMethodBuilderValue, exception,
                (AsyncTaskMethodBuilderValueLambda, exceptionLambda) =>
                    AsyncTaskMethodBuilderValueLambda.SetException(exceptionLambda));
        }


        public static IObservable<System.Reactive.Unit> get_Task(
            this IObservable<System.Runtime.CompilerServices.AsyncTaskMethodBuilder> AsyncTaskMethodBuilderValue)
        {
            return
                Observable.Select(AsyncTaskMethodBuilderValue,
                    (AsyncTaskMethodBuilderValueLambda) => AsyncTaskMethodBuilderValueLambda.Task.ToObservable())
                    .Flatten()
                    .ToUnit();
        }
    }
}