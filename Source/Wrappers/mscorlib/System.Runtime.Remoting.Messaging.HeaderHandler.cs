using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
    public static class __HeaderHandler
    {
        public static IObservable<System.Object> Invoke(
            this IObservable<System.Runtime.Remoting.Messaging.HeaderHandler> HeaderHandlerValue,
            IObservable<System.Runtime.Remoting.Messaging.Header[]> headers)
        {
            return Observable.Zip(HeaderHandlerValue, headers,
                (HeaderHandlerValueLambda, headersLambda) => HeaderHandlerValueLambda.Invoke(headersLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(
            this IObservable<System.Runtime.Remoting.Messaging.HeaderHandler> HeaderHandlerValue,
            IObservable<System.Runtime.Remoting.Messaging.Header[]> headers, IObservable<System.AsyncCallback> callback,
            IObservable<System.Object> @object)
        {
            return Observable.Zip(HeaderHandlerValue, headers, callback, @object,
                (HeaderHandlerValueLambda, headersLambda, callbackLambda, @objectLambda) =>
                    HeaderHandlerValueLambda.BeginInvoke(headersLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Object> EndInvoke(
            this IObservable<System.Runtime.Remoting.Messaging.HeaderHandler> HeaderHandlerValue,
            IObservable<System.IAsyncResult> result)
        {
            return Observable.Zip(HeaderHandlerValue, result,
                (HeaderHandlerValueLambda, resultLambda) => HeaderHandlerValueLambda.EndInvoke(resultLambda));
        }
    }
}