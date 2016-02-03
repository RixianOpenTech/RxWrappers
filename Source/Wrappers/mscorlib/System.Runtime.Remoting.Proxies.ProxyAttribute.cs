using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Proxies
{
    public static class __ProxyAttribute
    {
        public static IObservable<System.MarshalByRefObject> CreateInstance(
            this IObservable<System.Runtime.Remoting.Proxies.ProxyAttribute> ProxyAttributeValue,
            IObservable<System.Type> serverType)
        {
            return Observable.Zip(ProxyAttributeValue, serverType,
                (ProxyAttributeValueLambda, serverTypeLambda) =>
                    ProxyAttributeValueLambda.CreateInstance(serverTypeLambda));
        }


        public static IObservable<System.Runtime.Remoting.Proxies.RealProxy> CreateProxy(
            this IObservable<System.Runtime.Remoting.Proxies.ProxyAttribute> ProxyAttributeValue,
            IObservable<System.Runtime.Remoting.ObjRef> objRef, IObservable<System.Type> serverType,
            IObservable<System.Object> serverObject, IObservable<System.Runtime.Remoting.Contexts.Context> serverContext)
        {
            return Observable.Zip(ProxyAttributeValue, objRef, serverType, serverObject, serverContext,
                (ProxyAttributeValueLambda, objRefLambda, serverTypeLambda, serverObjectLambda, serverContextLambda) =>
                    ProxyAttributeValueLambda.CreateProxy(objRefLambda, serverTypeLambda, serverObjectLambda,
                        serverContextLambda));
        }


        public static IObservable<System.Boolean> IsContextOK(
            this IObservable<System.Runtime.Remoting.Proxies.ProxyAttribute> ProxyAttributeValue,
            IObservable<System.Runtime.Remoting.Contexts.Context> ctx,
            IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> msg)
        {
            return Observable.Zip(ProxyAttributeValue, ctx, msg,
                (ProxyAttributeValueLambda, ctxLambda, msgLambda) =>
                    ProxyAttributeValueLambda.IsContextOK(ctxLambda, msgLambda));
        }


        public static IObservable<System.Reactive.Unit> GetPropertiesForNewContext(
            this IObservable<System.Runtime.Remoting.Proxies.ProxyAttribute> ProxyAttributeValue,
            IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> msg)
        {
            return ObservableExt.ZipExecute(ProxyAttributeValue, msg,
                (ProxyAttributeValueLambda, msgLambda) =>
                    ProxyAttributeValueLambda.GetPropertiesForNewContext(msgLambda));
        }
    }
}