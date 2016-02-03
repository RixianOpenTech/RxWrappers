using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Contexts
{
    public static class __IContextPropertyActivator
    {
        public static IObservable<System.Boolean> IsOKToActivate(
            this IObservable<System.Runtime.Remoting.Contexts.IContextPropertyActivator> IContextPropertyActivatorValue,
            IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> msg)
        {
            return Observable.Zip(IContextPropertyActivatorValue, msg,
                (IContextPropertyActivatorValueLambda, msgLambda) =>
                    IContextPropertyActivatorValueLambda.IsOKToActivate(msgLambda));
        }


        public static IObservable<System.Reactive.Unit> CollectFromClientContext(
            this IObservable<System.Runtime.Remoting.Contexts.IContextPropertyActivator> IContextPropertyActivatorValue,
            IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> msg)
        {
            return ObservableExt.ZipExecute(IContextPropertyActivatorValue, msg,
                (IContextPropertyActivatorValueLambda, msgLambda) =>
                    IContextPropertyActivatorValueLambda.CollectFromClientContext(msgLambda));
        }


        public static IObservable<System.Boolean> DeliverClientContextToServerContext(
            this IObservable<System.Runtime.Remoting.Contexts.IContextPropertyActivator> IContextPropertyActivatorValue,
            IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> msg)
        {
            return Observable.Zip(IContextPropertyActivatorValue, msg,
                (IContextPropertyActivatorValueLambda, msgLambda) =>
                    IContextPropertyActivatorValueLambda.DeliverClientContextToServerContext(msgLambda));
        }


        public static IObservable<System.Reactive.Unit> CollectFromServerContext(
            this IObservable<System.Runtime.Remoting.Contexts.IContextPropertyActivator> IContextPropertyActivatorValue,
            IObservable<System.Runtime.Remoting.Activation.IConstructionReturnMessage> msg)
        {
            return ObservableExt.ZipExecute(IContextPropertyActivatorValue, msg,
                (IContextPropertyActivatorValueLambda, msgLambda) =>
                    IContextPropertyActivatorValueLambda.CollectFromServerContext(msgLambda));
        }


        public static IObservable<System.Boolean> DeliverServerContextToClientContext(
            this IObservable<System.Runtime.Remoting.Contexts.IContextPropertyActivator> IContextPropertyActivatorValue,
            IObservable<System.Runtime.Remoting.Activation.IConstructionReturnMessage> msg)
        {
            return Observable.Zip(IContextPropertyActivatorValue, msg,
                (IContextPropertyActivatorValueLambda, msgLambda) =>
                    IContextPropertyActivatorValueLambda.DeliverServerContextToClientContext(msgLambda));
        }
    }
}