using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Contexts
{
    public static class __IContributeEnvoySink
    {
        public static IObservable<System.Runtime.Remoting.Messaging.IMessageSink> GetEnvoySink(
            this IObservable<System.Runtime.Remoting.Contexts.IContributeEnvoySink> IContributeEnvoySinkValue,
            IObservable<System.MarshalByRefObject> obj,
            IObservable<System.Runtime.Remoting.Messaging.IMessageSink> nextSink)
        {
            return Observable.Zip(IContributeEnvoySinkValue, obj, nextSink,
                (IContributeEnvoySinkValueLambda, objLambda, nextSinkLambda) =>
                    IContributeEnvoySinkValueLambda.GetEnvoySink(objLambda, nextSinkLambda));
        }
    }
}