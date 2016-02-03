using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Contexts
{
    public static class __SynchronizationAttribute
    {
        public static IObservable<System.Boolean> IsContextOK(
            this IObservable<System.Runtime.Remoting.Contexts.SynchronizationAttribute> SynchronizationAttributeValue,
            IObservable<System.Runtime.Remoting.Contexts.Context> ctx,
            IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> msg)
        {
            return Observable.Zip(SynchronizationAttributeValue, ctx, msg,
                (SynchronizationAttributeValueLambda, ctxLambda, msgLambda) =>
                    SynchronizationAttributeValueLambda.IsContextOK(ctxLambda, msgLambda));
        }


        public static IObservable<System.Reactive.Unit> GetPropertiesForNewContext(
            this IObservable<System.Runtime.Remoting.Contexts.SynchronizationAttribute> SynchronizationAttributeValue,
            IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> ctorMsg)
        {
            return ObservableExt.ZipExecute(SynchronizationAttributeValue, ctorMsg,
                (SynchronizationAttributeValueLambda, ctorMsgLambda) =>
                    SynchronizationAttributeValueLambda.GetPropertiesForNewContext(ctorMsgLambda));
        }


        public static IObservable<System.Runtime.Remoting.Messaging.IMessageSink> GetServerContextSink(
            this IObservable<System.Runtime.Remoting.Contexts.SynchronizationAttribute> SynchronizationAttributeValue,
            IObservable<System.Runtime.Remoting.Messaging.IMessageSink> nextSink)
        {
            return Observable.Zip(SynchronizationAttributeValue, nextSink,
                (SynchronizationAttributeValueLambda, nextSinkLambda) =>
                    SynchronizationAttributeValueLambda.GetServerContextSink(nextSinkLambda));
        }


        public static IObservable<System.Runtime.Remoting.Messaging.IMessageSink> GetClientContextSink(
            this IObservable<System.Runtime.Remoting.Contexts.SynchronizationAttribute> SynchronizationAttributeValue,
            IObservable<System.Runtime.Remoting.Messaging.IMessageSink> nextSink)
        {
            return Observable.Zip(SynchronizationAttributeValue, nextSink,
                (SynchronizationAttributeValueLambda, nextSinkLambda) =>
                    SynchronizationAttributeValueLambda.GetClientContextSink(nextSinkLambda));
        }


        public static IObservable<System.Boolean> get_Locked(
            this IObservable<System.Runtime.Remoting.Contexts.SynchronizationAttribute> SynchronizationAttributeValue)
        {
            return Observable.Select(SynchronizationAttributeValue,
                (SynchronizationAttributeValueLambda) => SynchronizationAttributeValueLambda.Locked);
        }


        public static IObservable<System.Boolean> get_IsReEntrant(
            this IObservable<System.Runtime.Remoting.Contexts.SynchronizationAttribute> SynchronizationAttributeValue)
        {
            return Observable.Select(SynchronizationAttributeValue,
                (SynchronizationAttributeValueLambda) => SynchronizationAttributeValueLambda.IsReEntrant);
        }


        public static IObservable<System.Reactive.Unit> set_Locked(
            this IObservable<System.Runtime.Remoting.Contexts.SynchronizationAttribute> SynchronizationAttributeValue,
            IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(SynchronizationAttributeValue, value,
                (SynchronizationAttributeValueLambda, valueLambda) =>
                    SynchronizationAttributeValueLambda.Locked = valueLambda);
        }
    }
}