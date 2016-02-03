using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
public static class _IOCompletionCallback
{
    
public static IObservable<System.Reactive.Unit> Invoke(this IObservable<System.Threading.IOCompletionCallback> IOCompletionCallbackValue, IObservable<System.UInt32> errorCode, IObservable<System.UInt32> numBytes, IObservable<System.Threading.NativeOverlapped*> pOVERLAP)
{
    return ObservableExt.ZipExecute(IOCompletionCallbackValue, errorCode, numBytes, pOVERLAP, (IOCompletionCallbackValueLambda, errorCodeLambda, numBytesLambda, pOVERLAPLambda) => IOCompletionCallbackValueLambda.Invoke(errorCodeLambda, numBytesLambda, pOVERLAPLambda));
}


public static IObservable<System.IAsyncResult> BeginInvoke(this IObservable<System.Threading.IOCompletionCallback> IOCompletionCallbackValue, IObservable<System.UInt32> errorCode, IObservable<System.UInt32> numBytes, IObservable<System.Threading.NativeOverlapped*> pOVERLAP, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
{
    return Observable.Zip(IOCompletionCallbackValue, errorCode, numBytes, pOVERLAP, callback, @object, (IOCompletionCallbackValueLambda, errorCodeLambda, numBytesLambda, pOVERLAPLambda, callbackLambda, @objectLambda) => IOCompletionCallbackValueLambda.BeginInvoke(errorCodeLambda, numBytesLambda, pOVERLAPLambda, callbackLambda, @objectLambda));
}


public static IObservable<System.Reactive.Unit> EndInvoke(this IObservable<System.Threading.IOCompletionCallback> IOCompletionCallbackValue, IObservable<System.IAsyncResult> result)
{
    return ObservableExt.ZipExecute(IOCompletionCallbackValue, result, (IOCompletionCallbackValueLambda, resultLambda) => IOCompletionCallbackValueLambda.EndInvoke(resultLambda));
}

}
}