using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
    public static class __AsyncVoidMethodBuilder
    {
        public static IObservable<System.Runtime.CompilerServices.AsyncVoidMethodBuilder> Create()
        {
            return ObservableExt.Factory(() => System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Create());
        }


        public static IObservable<TStateMachine> Start<TStateMachine>(
            this IObservable<System.Runtime.CompilerServices.AsyncVoidMethodBuilder> AsyncVoidMethodBuilderValue,
            IObservable<TStateMachine> stateMachine)
            where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            return Observable.Zip(AsyncVoidMethodBuilderValue, stateMachine,
                (AsyncVoidMethodBuilderValueLambda, stateMachineLambda) =>
                {
                    AsyncVoidMethodBuilderValueLambda.Start(ref stateMachineLambda);
                    return stateMachineLambda;
                });
        }


        public static IObservable<System.Reactive.Unit> SetStateMachine(
            this IObservable<System.Runtime.CompilerServices.AsyncVoidMethodBuilder> AsyncVoidMethodBuilderValue,
            IObservable<System.Runtime.CompilerServices.IAsyncStateMachine> stateMachine)
        {
            return ObservableExt.ZipExecute(AsyncVoidMethodBuilderValue, stateMachine,
                (AsyncVoidMethodBuilderValueLambda, stateMachineLambda) =>
                    AsyncVoidMethodBuilderValueLambda.SetStateMachine(stateMachineLambda));
        }


        public static IObservable<Tuple<TAwaiter, TStateMachine>> AwaitOnCompleted<TAwaiter, TStateMachine>(
            this IObservable<System.Runtime.CompilerServices.AsyncVoidMethodBuilder> AsyncVoidMethodBuilderValue,
            IObservable<TAwaiter> awaiter, IObservable<TStateMachine> stateMachine)
            where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine where TAwaiter : INotifyCompletion
        {
            return Observable.Zip(AsyncVoidMethodBuilderValue, awaiter, stateMachine,
                (AsyncVoidMethodBuilderValueLambda, awaiterLambda, stateMachineLambda) =>
                {
                    AsyncVoidMethodBuilderValueLambda.AwaitOnCompleted(ref awaiterLambda, ref stateMachineLambda);
                    return Tuple.Create(awaiterLambda, stateMachineLambda);
                });
        }


        public static IObservable<Tuple<TAwaiter, TStateMachine>> AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(
            this IObservable<System.Runtime.CompilerServices.AsyncVoidMethodBuilder> AsyncVoidMethodBuilderValue,
            IObservable<TAwaiter> awaiter, IObservable<TStateMachine> stateMachine)
            where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine
            where TAwaiter : ICriticalNotifyCompletion
        {
            return Observable.Zip(AsyncVoidMethodBuilderValue, awaiter, stateMachine,
                (AsyncVoidMethodBuilderValueLambda, awaiterLambda, stateMachineLambda) =>
                {
                    AsyncVoidMethodBuilderValueLambda.AwaitUnsafeOnCompleted(ref awaiterLambda, ref stateMachineLambda);
                    return Tuple.Create(awaiterLambda, stateMachineLambda);
                });
        }


        public static IObservable<System.Reactive.Unit> SetResult(
            this IObservable<System.Runtime.CompilerServices.AsyncVoidMethodBuilder> AsyncVoidMethodBuilderValue)
        {
            return
                Observable.Do(AsyncVoidMethodBuilderValue,
                    (AsyncVoidMethodBuilderValueLambda) => AsyncVoidMethodBuilderValueLambda.SetResult()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> SetException(
            this IObservable<System.Runtime.CompilerServices.AsyncVoidMethodBuilder> AsyncVoidMethodBuilderValue,
            IObservable<System.Exception> exception)
        {
            return ObservableExt.ZipExecute(AsyncVoidMethodBuilderValue, exception,
                (AsyncVoidMethodBuilderValueLambda, exceptionLambda) =>
                    AsyncVoidMethodBuilderValueLambda.SetException(exceptionLambda));
        }
    }
}