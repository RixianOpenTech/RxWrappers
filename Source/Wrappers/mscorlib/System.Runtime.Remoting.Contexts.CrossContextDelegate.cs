using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Contexts
{
    public static class __CrossContextDelegate
    {
        
        public static IObservable<System.Reactive.Unit> Invoke(this IObservable<System.Runtime.Remoting.Contexts.CrossContextDelegate> CrossContextDelegateValue)
        {
            return Observable.Do(CrossContextDelegateValue, (CrossContextDelegateValueLambda) => CrossContextDelegateValueLambda.Invoke()).ToUnit();
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(this IObservable<System.Runtime.Remoting.Contexts.CrossContextDelegate> CrossContextDelegateValue, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(CrossContextDelegateValue, callback, @object, (CrossContextDelegateValueLambda, callbackLambda, @objectLambda) => CrossContextDelegateValueLambda.BeginInvoke(callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke(this IObservable<System.Runtime.Remoting.Contexts.CrossContextDelegate> CrossContextDelegateValue, IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(CrossContextDelegateValue, result, (CrossContextDelegateValueLambda, resultLambda) => CrossContextDelegateValueLambda.EndInvoke(resultLambda));
        }

    }
}