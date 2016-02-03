using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
    public static class __CleanupCode
    {
        
        public static IObservable<System.Reactive.Unit> Invoke(this IObservable<System.Runtime.CompilerServices.RuntimeHelpers.CleanupCode> CleanupCodeValue, IObservable<System.Object> userData, IObservable<System.Boolean> exceptionThrown)
        {
            return ObservableExt.ZipExecute(CleanupCodeValue, userData, exceptionThrown, (CleanupCodeValueLambda, userDataLambda, exceptionThrownLambda) => CleanupCodeValueLambda.Invoke(userDataLambda, exceptionThrownLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(this IObservable<System.Runtime.CompilerServices.RuntimeHelpers.CleanupCode> CleanupCodeValue, IObservable<System.Object> userData, IObservable<System.Boolean> exceptionThrown, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(CleanupCodeValue, userData, exceptionThrown, callback, @object, (CleanupCodeValueLambda, userDataLambda, exceptionThrownLambda, callbackLambda, @objectLambda) => CleanupCodeValueLambda.BeginInvoke(userDataLambda, exceptionThrownLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke(this IObservable<System.Runtime.CompilerServices.RuntimeHelpers.CleanupCode> CleanupCodeValue, IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(CleanupCodeValue, result, (CleanupCodeValueLambda, resultLambda) => CleanupCodeValueLambda.EndInvoke(resultLambda));
        }

    }
}