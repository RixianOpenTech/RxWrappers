using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Proxies
{
    public static class __RealProxy
    {
        public static IObservable<System.Runtime.Remoting.Activation.IConstructionReturnMessage> InitializeServerObject(
            this IObservable<System.Runtime.Remoting.Proxies.RealProxy> RealProxyValue,
            IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> ctorMsg)
        {
            return Observable.Zip(RealProxyValue, ctorMsg,
                (RealProxyValueLambda, ctorMsgLambda) => RealProxyValueLambda.InitializeServerObject(ctorMsgLambda));
        }


        public static IObservable<System.Reactive.Unit> SetStubData(
            IObservable<System.Runtime.Remoting.Proxies.RealProxy> rp, IObservable<System.Object> stubData)
        {
            return ObservableExt.ZipExecute(rp, stubData,
                (rpLambda, stubDataLambda) =>
                    System.Runtime.Remoting.Proxies.RealProxy.SetStubData(rpLambda, stubDataLambda));
        }


        public static IObservable<System.Object> GetStubData(IObservable<System.Runtime.Remoting.Proxies.RealProxy> rp)
        {
            return Observable.Select(rp, (rpLambda) => System.Runtime.Remoting.Proxies.RealProxy.GetStubData(rpLambda));
        }


        public static IObservable<System.Type> GetProxiedType(
            this IObservable<System.Runtime.Remoting.Proxies.RealProxy> RealProxyValue)
        {
            return Observable.Select(RealProxyValue, (RealProxyValueLambda) => RealProxyValueLambda.GetProxiedType());
        }


        public static IObservable<System.Runtime.Remoting.Messaging.IMessage> Invoke(
            this IObservable<System.Runtime.Remoting.Proxies.RealProxy> RealProxyValue,
            IObservable<System.Runtime.Remoting.Messaging.IMessage> msg)
        {
            return Observable.Zip(RealProxyValue, msg,
                (RealProxyValueLambda, msgLambda) => RealProxyValueLambda.Invoke(msgLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjRef> CreateObjRef(
            this IObservable<System.Runtime.Remoting.Proxies.RealProxy> RealProxyValue,
            IObservable<System.Type> requestedType)
        {
            return Observable.Zip(RealProxyValue, requestedType,
                (RealProxyValueLambda, requestedTypeLambda) => RealProxyValueLambda.CreateObjRef(requestedTypeLambda));
        }


        public static IObservable<System.Reactive.Unit> GetObjectData(
            this IObservable<System.Runtime.Remoting.Proxies.RealProxy> RealProxyValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(RealProxyValue, info, context,
                (RealProxyValueLambda, infoLambda, contextLambda) =>
                    RealProxyValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.IntPtr> GetCOMIUnknown(
            this IObservable<System.Runtime.Remoting.Proxies.RealProxy> RealProxyValue,
            IObservable<System.Boolean> fIsMarshalled)
        {
            return Observable.Zip(RealProxyValue, fIsMarshalled,
                (RealProxyValueLambda, fIsMarshalledLambda) => RealProxyValueLambda.GetCOMIUnknown(fIsMarshalledLambda));
        }


        public static IObservable<System.Reactive.Unit> SetCOMIUnknown(
            this IObservable<System.Runtime.Remoting.Proxies.RealProxy> RealProxyValue, IObservable<System.IntPtr> i)
        {
            return ObservableExt.ZipExecute(RealProxyValue, i,
                (RealProxyValueLambda, iLambda) => RealProxyValueLambda.SetCOMIUnknown(iLambda));
        }


        public static IObservable<Tuple<System.IntPtr, System.Guid>> SupportsInterface(
            this IObservable<System.Runtime.Remoting.Proxies.RealProxy> RealProxyValue, IObservable<System.Guid> iid)
        {
            return Observable.Zip(RealProxyValue, iid, (RealProxyValueLambda, iidLambda) =>
            {
                var result = RealProxyValueLambda.SupportsInterface(ref iidLambda);
                return Tuple.Create(result, iidLambda);
            });
        }


        public static IObservable<System.Object> GetTransparentProxy(
            this IObservable<System.Runtime.Remoting.Proxies.RealProxy> RealProxyValue)
        {
            return Observable.Select(RealProxyValue,
                (RealProxyValueLambda) => RealProxyValueLambda.GetTransparentProxy());
        }
    }
}