using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Contexts
{
    public static class __IContributeServerContextSink
    {
        
        public static IObservable<System.Runtime.Remoting.Messaging.IMessageSink> GetServerContextSink(this IObservable<System.Runtime.Remoting.Contexts.IContributeServerContextSink> IContributeServerContextSinkValue, IObservable<System.Runtime.Remoting.Messaging.IMessageSink> nextSink)
        {
            return Observable.Zip(IContributeServerContextSinkValue, nextSink, (IContributeServerContextSinkValueLambda, nextSinkLambda) => IContributeServerContextSinkValueLambda.GetServerContextSink(nextSinkLambda));
        }

    }
}