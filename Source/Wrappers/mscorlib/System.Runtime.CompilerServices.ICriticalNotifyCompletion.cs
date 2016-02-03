using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
    public static class __ICriticalNotifyCompletion
    {
        public static IObservable<System.Reactive.Unit> UnsafeOnCompleted(
            this IObservable<System.Runtime.CompilerServices.ICriticalNotifyCompletion> ICriticalNotifyCompletionValue,
            IObservable<System.Action> continuation)
        {
            return ObservableExt.ZipExecute(ICriticalNotifyCompletionValue, continuation,
                (ICriticalNotifyCompletionValueLambda, continuationLambda) =>
                    ICriticalNotifyCompletionValueLambda.UnsafeOnCompleted(continuationLambda));
        }
    }
}