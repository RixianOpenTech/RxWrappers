using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting
{
    public static class __InternalRemotingServices
    {
        
        public static IObservable<System.Reactive.Unit> DebugOutChnl(IObservable<System.String> s)
        {
            return Observable.Do(s, (sLambda) => System.Runtime.Remoting.InternalRemotingServices.DebugOutChnl(sLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> RemotingTrace(IObservable<System.Object[]> messages)
        {
            return Observable.Do(messages, (messagesLambda) => System.Runtime.Remoting.InternalRemotingServices.RemotingTrace(messagesLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> RemotingAssert(IObservable<System.Boolean> condition, IObservable<System.String> message)
        {
            return ObservableExt.ZipExecute(condition, message, (conditionLambda, messageLambda) => System.Runtime.Remoting.InternalRemotingServices.RemotingAssert(conditionLambda, messageLambda));
        }


        public static IObservable<System.Reactive.Unit> SetServerIdentity(IObservable<System.Runtime.Remoting.Messaging.MethodCall> m, IObservable<System.Object> srvID)
        {
            return ObservableExt.ZipExecute(m, srvID, (mLambda, srvIDLambda) => System.Runtime.Remoting.InternalRemotingServices.SetServerIdentity(mLambda, srvIDLambda));
        }


        public static IObservable<System.Runtime.Remoting.Metadata.SoapAttribute> GetCachedSoapAttribute(IObservable<System.Object> reflectionObject)
        {
            return Observable.Select(reflectionObject, (reflectionObjectLambda) => System.Runtime.Remoting.InternalRemotingServices.GetCachedSoapAttribute(reflectionObjectLambda));
        }

    }
}