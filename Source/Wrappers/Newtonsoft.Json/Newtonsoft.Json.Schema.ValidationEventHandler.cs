using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Schema
{
    public static class __ValidationEventHandler
    {
        
        public static IObservable<System.Reactive.Unit> Invoke(this IObservable<Newtonsoft.Json.Schema.ValidationEventHandler> ValidationEventHandlerValue, IObservable<System.Object> sender, IObservable<Newtonsoft.Json.Schema.ValidationEventArgs> e)
        {
            return ObservableExt.ZipExecute(ValidationEventHandlerValue, sender, e, (ValidationEventHandlerValueLambda, senderLambda, eLambda) => ValidationEventHandlerValueLambda.Invoke(senderLambda, eLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(this IObservable<Newtonsoft.Json.Schema.ValidationEventHandler> ValidationEventHandlerValue, IObservable<System.Object> sender, IObservable<Newtonsoft.Json.Schema.ValidationEventArgs> e, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(ValidationEventHandlerValue, sender, e, callback, @object, (ValidationEventHandlerValueLambda, senderLambda, eLambda, callbackLambda, @objectLambda) => ValidationEventHandlerValueLambda.BeginInvoke(senderLambda, eLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke(this IObservable<Newtonsoft.Json.Schema.ValidationEventHandler> ValidationEventHandlerValue, IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(ValidationEventHandlerValue, result, (ValidationEventHandlerValueLambda, resultLambda) => ValidationEventHandlerValueLambda.EndInvoke(resultLambda));
        }

    }
}