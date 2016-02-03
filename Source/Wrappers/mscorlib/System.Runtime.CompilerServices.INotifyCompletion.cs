using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
public static class _INotifyCompletion
{
    
public static IObservable<System.Reactive.Unit> OnCompleted(this IObservable<System.Runtime.CompilerServices.INotifyCompletion> INotifyCompletionValue, IObservable<System.Action> continuation)
{
    return ObservableExt.ZipExecute(INotifyCompletionValue, continuation, (INotifyCompletionValueLambda, continuationLambda) => INotifyCompletionValueLambda.OnCompleted(continuationLambda));
}

}
}