using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Contexts
{
    public static class __IContributeClientContextSink
    {
        
        public static IObservable<System.Runtime.Remoting.Messaging.IMessageSink> GetClientContextSink(this IObservable<System.Runtime.Remoting.Contexts.IContributeClientContextSink> IContributeClientContextSinkValue, IObservable<System.Runtime.Remoting.Messaging.IMessageSink> nextSink)
        {
            return Observable.Zip(IContributeClientContextSinkValue, nextSink, (IContributeClientContextSinkValueLambda, nextSinkLambda) => IContributeClientContextSinkValueLambda.GetClientContextSink(nextSinkLambda));
        }

    }
}