using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __OperationCanceledException
    {
        
        public static IObservable<System.Threading.CancellationToken> get_CancellationToken(this IObservable<System.OperationCanceledException> OperationCanceledExceptionValue)
        {
            return Observable.Select(OperationCanceledExceptionValue, (OperationCanceledExceptionValueLambda) => OperationCanceledExceptionValueLambda.CancellationToken);
        }

    }
}