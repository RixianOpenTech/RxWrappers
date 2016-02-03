using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
public static class _ThreadAbortException
{
    
public static IObservable<System.Object> get_ExceptionState(this IObservable<System.Threading.ThreadAbortException> ThreadAbortExceptionValue)
{
    return Observable.Select(ThreadAbortExceptionValue, (ThreadAbortExceptionValueLambda) => ThreadAbortExceptionValueLambda.ExceptionState);
}

}
}