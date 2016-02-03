using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
public static class _IAsyncStateMachine
{
    
public static IObservable<System.Reactive.Unit> MoveNext(this IObservable<System.Runtime.CompilerServices.IAsyncStateMachine> IAsyncStateMachineValue)
{
    return Observable.Do(IAsyncStateMachineValue, (IAsyncStateMachineValueLambda) => IAsyncStateMachineValueLambda.MoveNext()).ToUnit();
}


public static IObservable<System.Reactive.Unit> SetStateMachine(this IObservable<System.Runtime.CompilerServices.IAsyncStateMachine> IAsyncStateMachineValue, IObservable<System.Runtime.CompilerServices.IAsyncStateMachine> stateMachine)
{
    return ObservableExt.ZipExecute(IAsyncStateMachineValue, stateMachine, (IAsyncStateMachineValueLambda, stateMachineLambda) => IAsyncStateMachineValueLambda.SetStateMachine(stateMachineLambda));
}

}
}