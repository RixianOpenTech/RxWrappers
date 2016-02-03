using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
    public static class __MessageSurrogateFilter
    {
        public static IObservable<System.Boolean> Invoke(
            this IObservable<System.Runtime.Remoting.Messaging.MessageSurrogateFilter> MessageSurrogateFilterValue,
            IObservable<System.String> key, IObservable<System.Object> value)
        {
            return Observable.Zip(MessageSurrogateFilterValue, key, value,
                (MessageSurrogateFilterValueLambda, keyLambda, valueLambda) =>
                    MessageSurrogateFilterValueLambda.Invoke(keyLambda, valueLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(
            this IObservable<System.Runtime.Remoting.Messaging.MessageSurrogateFilter> MessageSurrogateFilterValue,
            IObservable<System.String> key, IObservable<System.Object> value, IObservable<System.AsyncCallback> callback,
            IObservable<System.Object> @object)
        {
            return Observable.Zip(MessageSurrogateFilterValue, key, value, callback, @object,
                (MessageSurrogateFilterValueLambda, keyLambda, valueLambda, callbackLambda, @objectLambda) =>
                    MessageSurrogateFilterValueLambda.BeginInvoke(keyLambda, valueLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Boolean> EndInvoke(
            this IObservable<System.Runtime.Remoting.Messaging.MessageSurrogateFilter> MessageSurrogateFilterValue,
            IObservable<System.IAsyncResult> result)
        {
            return Observable.Zip(MessageSurrogateFilterValue, result,
                (MessageSurrogateFilterValueLambda, resultLambda) =>
                    MessageSurrogateFilterValueLambda.EndInvoke(resultLambda));
        }
    }
}