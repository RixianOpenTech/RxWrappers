using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Activation
{
    public static class __UrlAttribute
    {
        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Runtime.Remoting.Activation.UrlAttribute> UrlAttributeValue,
            IObservable<System.Object> o)
        {
            return Observable.Zip(UrlAttributeValue, o,
                (UrlAttributeValueLambda, oLambda) => UrlAttributeValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Runtime.Remoting.Activation.UrlAttribute> UrlAttributeValue)
        {
            return Observable.Select(UrlAttributeValue,
                (UrlAttributeValueLambda) => UrlAttributeValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> IsContextOK(
            this IObservable<System.Runtime.Remoting.Activation.UrlAttribute> UrlAttributeValue,
            IObservable<System.Runtime.Remoting.Contexts.Context> ctx,
            IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> msg)
        {
            return Observable.Zip(UrlAttributeValue, ctx, msg,
                (UrlAttributeValueLambda, ctxLambda, msgLambda) =>
                    UrlAttributeValueLambda.IsContextOK(ctxLambda, msgLambda));
        }


        public static IObservable<System.Reactive.Unit> GetPropertiesForNewContext(
            this IObservable<System.Runtime.Remoting.Activation.UrlAttribute> UrlAttributeValue,
            IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> ctorMsg)
        {
            return ObservableExt.ZipExecute(UrlAttributeValue, ctorMsg,
                (UrlAttributeValueLambda, ctorMsgLambda) =>
                    UrlAttributeValueLambda.GetPropertiesForNewContext(ctorMsgLambda));
        }


        public static IObservable<System.String> get_UrlValue(
            this IObservable<System.Runtime.Remoting.Activation.UrlAttribute> UrlAttributeValue)
        {
            return Observable.Select(UrlAttributeValue, (UrlAttributeValueLambda) => UrlAttributeValueLambda.UrlValue);
        }
    }
}