using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
public static class _AsyncTaskMethodBuilder1
{
    
public static IObservable<TStateMachine> Start<TStateMachine, TResult>(this IObservable<System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult>> AsyncTaskMethodBuilderValue, IObservable<TStateMachine> stateMachine)
{
    return Observable.Zip(AsyncTaskMethodBuilderValue, stateMachine, (AsyncTaskMethodBuilderValueLambda, stateMachineLambda) => {
AsyncTaskMethodBuilderValueLambda.Start(ref stateMachineLambda);
return stateMachineLambda;
});
}


public static IObservable<System.Reactive.Unit> SetStateMachine<TResult>(this IObservable<System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult>> AsyncTaskMethodBuilderValue, IObservable<System.Runtime.CompilerServices.IAsyncStateMachine> stateMachine)
{
    return ObservableExt.ZipExecute(AsyncTaskMethodBuilderValue, stateMachine, (AsyncTaskMethodBuilderValueLambda, stateMachineLambda) => AsyncTaskMethodBuilderValueLambda.SetStateMachine(stateMachineLambda));
}


public static IObservable<Tuple<TAwaiter, TStateMachine>> AwaitOnCompleted<TAwaiter, TStateMachine, TResult>(this IObservable<System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult>> AsyncTaskMethodBuilderValue, IObservable<TAwaiter> awaiter, IObservable<TStateMachine> stateMachine)
{
    return Observable.Zip(AsyncTaskMethodBuilderValue, awaiter, stateMachine, (AsyncTaskMethodBuilderValueLambda, awaiterLambda, stateMachineLambda) => {
AsyncTaskMethodBuilderValueLambda.AwaitOnCompleted(ref awaiterLambda, ref stateMachineLambda);
return Tuple.Create(awaiterLambda, stateMachineLambda);
});
}


public static IObservable<Tuple<TAwaiter, TStateMachine>> AwaitUnsafeOnCompleted<TAwaiter, TStateMachine, TResult>(this IObservable<System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult>> AsyncTaskMethodBuilderValue, IObservable<TAwaiter> awaiter, IObservable<TStateMachine> stateMachine)
{
    return Observable.Zip(AsyncTaskMethodBuilderValue, awaiter, stateMachine, (AsyncTaskMethodBuilderValueLambda, awaiterLambda, stateMachineLambda) => {
AsyncTaskMethodBuilderValueLambda.AwaitUnsafeOnCompleted(ref awaiterLambda, ref stateMachineLambda);
return Tuple.Create(awaiterLambda, stateMachineLambda);
});
}


public static IObservable<System.Reactive.Unit> SetResult<TResult>(this IObservable<System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult>> AsyncTaskMethodBuilderValue, IObservable<TResult> result)
{
    return ObservableExt.ZipExecute(AsyncTaskMethodBuilderValue, result, (AsyncTaskMethodBuilderValueLambda, resultLambda) => AsyncTaskMethodBuilderValueLambda.SetResult(resultLambda));
}


public static IObservable<System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult>> Create<TResult>()
{
    return ObservableExt.Factory(() => System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult>.Create());
}


public static IObservable<System.Reactive.Unit> SetException<TResult>(this IObservable<System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult>> AsyncTaskMethodBuilderValue, IObservable<System.Exception> exception)
{
    return ObservableExt.ZipExecute(AsyncTaskMethodBuilderValue, exception, (AsyncTaskMethodBuilderValueLambda, exceptionLambda) => AsyncTaskMethodBuilderValueLambda.SetException(exceptionLambda));
}


public static IObservable<TResult> get_Task<TResult>(this IObservable<System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult>> AsyncTaskMethodBuilderValue)
{
    return Observable.Select(AsyncTaskMethodBuilderValue, (AsyncTaskMethodBuilderValueLambda) => AsyncTaskMethodBuilderValueLambda.Task.ToObservable()).Flatten();
}

}
}