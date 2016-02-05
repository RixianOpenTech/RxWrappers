using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __SerializationCallback
    {
        
        public static IObservable<System.Reactive.Unit> Invoke(this IObservable<Newtonsoft.Json.Serialization.SerializationCallback> SerializationCallbackValue, IObservable<System.Object> o, IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(SerializationCallbackValue, o, context, (SerializationCallbackValueLambda, oLambda, contextLambda) => SerializationCallbackValueLambda.Invoke(oLambda, contextLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(this IObservable<Newtonsoft.Json.Serialization.SerializationCallback> SerializationCallbackValue, IObservable<System.Object> o, IObservable<System.Runtime.Serialization.StreamingContext> context, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(SerializationCallbackValue, o, context, callback, @object, (SerializationCallbackValueLambda, oLambda, contextLambda, callbackLambda, @objectLambda) => SerializationCallbackValueLambda.BeginInvoke(oLambda, contextLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke(this IObservable<Newtonsoft.Json.Serialization.SerializationCallback> SerializationCallbackValue, IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(SerializationCallbackValue, result, (SerializationCallbackValueLambda, resultLambda) => SerializationCallbackValueLambda.EndInvoke(resultLambda));
        }

    }
}