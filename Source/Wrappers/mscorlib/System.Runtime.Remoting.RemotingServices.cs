using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting
{
    public static class __RemotingServices
    {
        
        public static IObservable<System.Boolean> IsTransparentProxy(IObservable<System.Object> proxy)
        {
            return Observable.Select(proxy, (proxyLambda) => System.Runtime.Remoting.RemotingServices.IsTransparentProxy(proxyLambda));
        }


        public static IObservable<System.Boolean> IsObjectOutOfContext(IObservable<System.Object> tp)
        {
            return Observable.Select(tp, (tpLambda) => System.Runtime.Remoting.RemotingServices.IsObjectOutOfContext(tpLambda));
        }


        public static IObservable<System.Boolean> IsObjectOutOfAppDomain(IObservable<System.Object> tp)
        {
            return Observable.Select(tp, (tpLambda) => System.Runtime.Remoting.RemotingServices.IsObjectOutOfAppDomain(tpLambda));
        }


        public static IObservable<System.Runtime.Remoting.Proxies.RealProxy> GetRealProxy(IObservable<System.Object> proxy)
        {
            return Observable.Select(proxy, (proxyLambda) => System.Runtime.Remoting.RemotingServices.GetRealProxy(proxyLambda));
        }


        public static IObservable<System.String> GetSessionIdForMethodMessage(IObservable<System.Runtime.Remoting.Messaging.IMethodMessage> msg)
        {
            return Observable.Select(msg, (msgLambda) => System.Runtime.Remoting.RemotingServices.GetSessionIdForMethodMessage(msgLambda));
        }


        public static IObservable<System.Object> GetLifetimeService(IObservable<System.MarshalByRefObject> obj)
        {
            return Observable.Select(obj, (objLambda) => System.Runtime.Remoting.RemotingServices.GetLifetimeService(objLambda));
        }


        public static IObservable<System.String> GetObjectUri(IObservable<System.MarshalByRefObject> obj)
        {
            return Observable.Select(obj, (objLambda) => System.Runtime.Remoting.RemotingServices.GetObjectUri(objLambda));
        }


        public static IObservable<System.Reactive.Unit> SetObjectUriForMarshal(IObservable<System.MarshalByRefObject> obj, IObservable<System.String> uri)
        {
            return ObservableExt.ZipExecute(obj, uri, (objLambda, uriLambda) => System.Runtime.Remoting.RemotingServices.SetObjectUriForMarshal(objLambda, uriLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjRef> Marshal(IObservable<System.MarshalByRefObject> Obj)
        {
            return Observable.Select(Obj, (ObjLambda) => System.Runtime.Remoting.RemotingServices.Marshal(ObjLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjRef> Marshal(IObservable<System.MarshalByRefObject> Obj, IObservable<System.String> URI)
        {
            return Observable.Zip(Obj, URI, (ObjLambda, URILambda) => System.Runtime.Remoting.RemotingServices.Marshal(ObjLambda, URILambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjRef> Marshal(IObservable<System.MarshalByRefObject> Obj, IObservable<System.String> ObjURI, IObservable<System.Type> RequestedType)
        {
            return Observable.Zip(Obj, ObjURI, RequestedType, (ObjLambda, ObjURILambda, RequestedTypeLambda) => System.Runtime.Remoting.RemotingServices.Marshal(ObjLambda, ObjURILambda, RequestedTypeLambda));
        }


        public static IObservable<System.Reactive.Unit> GetObjectData(IObservable<System.Object> obj, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(obj, info, context, (objLambda, infoLambda, contextLambda) => System.Runtime.Remoting.RemotingServices.GetObjectData(objLambda, infoLambda, contextLambda));
        }


        public static IObservable<System.Object> Unmarshal(IObservable<System.Runtime.Remoting.ObjRef> objectRef)
        {
            return Observable.Select(objectRef, (objectRefLambda) => System.Runtime.Remoting.RemotingServices.Unmarshal(objectRefLambda));
        }


        public static IObservable<System.Object> Unmarshal(IObservable<System.Runtime.Remoting.ObjRef> objectRef, IObservable<System.Boolean> fRefine)
        {
            return Observable.Zip(objectRef, fRefine, (objectRefLambda, fRefineLambda) => System.Runtime.Remoting.RemotingServices.Unmarshal(objectRefLambda, fRefineLambda));
        }


        public static IObservable<System.Object> Connect(IObservable<System.Type> classToProxy, IObservable<System.String> url)
        {
            return Observable.Zip(classToProxy, url, (classToProxyLambda, urlLambda) => System.Runtime.Remoting.RemotingServices.Connect(classToProxyLambda, urlLambda));
        }


        public static IObservable<System.Object> Connect(IObservable<System.Type> classToProxy, IObservable<System.String> url, IObservable<System.Object> data)
        {
            return Observable.Zip(classToProxy, url, data, (classToProxyLambda, urlLambda, dataLambda) => System.Runtime.Remoting.RemotingServices.Connect(classToProxyLambda, urlLambda, dataLambda));
        }


        public static IObservable<System.Boolean> Disconnect(IObservable<System.MarshalByRefObject> obj)
        {
            return Observable.Select(obj, (objLambda) => System.Runtime.Remoting.RemotingServices.Disconnect(objLambda));
        }


        public static IObservable<System.Runtime.Remoting.Messaging.IMessageSink> GetEnvoyChainForProxy(IObservable<System.MarshalByRefObject> obj)
        {
            return Observable.Select(obj, (objLambda) => System.Runtime.Remoting.RemotingServices.GetEnvoyChainForProxy(objLambda));
        }


        public static IObservable<System.Runtime.Remoting.ObjRef> GetObjRefForProxy(IObservable<System.MarshalByRefObject> obj)
        {
            return Observable.Select(obj, (objLambda) => System.Runtime.Remoting.RemotingServices.GetObjRefForProxy(objLambda));
        }


        public static IObservable<System.Reflection.MethodBase> GetMethodBaseFromMethodMessage(IObservable<System.Runtime.Remoting.Messaging.IMethodMessage> msg)
        {
            return Observable.Select(msg, (msgLambda) => System.Runtime.Remoting.RemotingServices.GetMethodBaseFromMethodMessage(msgLambda));
        }


        public static IObservable<System.Boolean> IsMethodOverloaded(IObservable<System.Runtime.Remoting.Messaging.IMethodMessage> msg)
        {
            return Observable.Select(msg, (msgLambda) => System.Runtime.Remoting.RemotingServices.IsMethodOverloaded(msgLambda));
        }


        public static IObservable<System.Boolean> IsOneWay(IObservable<System.Reflection.MethodBase> method)
        {
            return Observable.Select(method, (methodLambda) => System.Runtime.Remoting.RemotingServices.IsOneWay(methodLambda));
        }


        public static IObservable<System.Type> GetServerTypeForUri(IObservable<System.String> URI)
        {
            return Observable.Select(URI, (URILambda) => System.Runtime.Remoting.RemotingServices.GetServerTypeForUri(URILambda));
        }


        public static IObservable<System.Runtime.Remoting.Messaging.IMethodReturnMessage> ExecuteMessage(IObservable<System.MarshalByRefObject> target, IObservable<System.Runtime.Remoting.Messaging.IMethodCallMessage> reqMsg)
        {
            return Observable.Zip(target, reqMsg, (targetLambda, reqMsgLambda) => System.Runtime.Remoting.RemotingServices.ExecuteMessage(targetLambda, reqMsgLambda));
        }


        public static IObservable<System.Reactive.Unit> LogRemotingStage(IObservable<System.Int32> stage)
        {
            return Observable.Do(stage, (stageLambda) => System.Runtime.Remoting.RemotingServices.LogRemotingStage(stageLambda)).ToUnit();
        }

    }
}