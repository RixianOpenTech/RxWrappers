using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __SerializationErrorCallback
    {
        
        public static IObservable<System.Reactive.Unit> Invoke(this IObservable<Newtonsoft.Json.Serialization.SerializationErrorCallback> SerializationErrorCallbackValue, IObservable<System.Object> o, IObservable<System.Runtime.Serialization.StreamingContext> context, IObservable<Newtonsoft.Json.Serialization.ErrorContext> errorContext)
        {
            return ObservableExt.ZipExecute(SerializationErrorCallbackValue, o, context, errorContext, (SerializationErrorCallbackValueLambda, oLambda, contextLambda, errorContextLambda) => SerializationErrorCallbackValueLambda.Invoke(oLambda, contextLambda, errorContextLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(this IObservable<Newtonsoft.Json.Serialization.SerializationErrorCallback> SerializationErrorCallbackValue, IObservable<System.Object> o, IObservable<System.Runtime.Serialization.StreamingContext> context, IObservable<Newtonsoft.Json.Serialization.ErrorContext> errorContext, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(SerializationErrorCallbackValue, o, context, errorContext, callback, @object, (SerializationErrorCallbackValueLambda, oLambda, contextLambda, errorContextLambda, callbackLambda, @objectLambda) => SerializationErrorCallbackValueLambda.BeginInvoke(oLambda, contextLambda, errorContextLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke(this IObservable<Newtonsoft.Json.Serialization.SerializationErrorCallback> SerializationErrorCallbackValue, IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(SerializationErrorCallbackValue, result, (SerializationErrorCallbackValueLambda, resultLambda) => SerializationErrorCallbackValueLambda.EndInvoke(resultLambda));
        }

    }
}