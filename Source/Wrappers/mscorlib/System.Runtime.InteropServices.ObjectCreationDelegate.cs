using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __ObjectCreationDelegate
    {
        
        public static IObservable<System.IntPtr> Invoke(this IObservable<System.Runtime.InteropServices.ObjectCreationDelegate> ObjectCreationDelegateValue, IObservable<System.IntPtr> aggregator)
        {
            return Observable.Zip(ObjectCreationDelegateValue, aggregator, (ObjectCreationDelegateValueLambda, aggregatorLambda) => ObjectCreationDelegateValueLambda.Invoke(aggregatorLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(this IObservable<System.Runtime.InteropServices.ObjectCreationDelegate> ObjectCreationDelegateValue, IObservable<System.IntPtr> aggregator, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(ObjectCreationDelegateValue, aggregator, callback, @object, (ObjectCreationDelegateValueLambda, aggregatorLambda, callbackLambda, @objectLambda) => ObjectCreationDelegateValueLambda.BeginInvoke(aggregatorLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.IntPtr> EndInvoke(this IObservable<System.Runtime.InteropServices.ObjectCreationDelegate> ObjectCreationDelegateValue, IObservable<System.IAsyncResult> result)
        {
            return Observable.Zip(ObjectCreationDelegateValue, result, (ObjectCreationDelegateValueLambda, resultLambda) => ObjectCreationDelegateValueLambda.EndInvoke(resultLambda));
        }

    }
}