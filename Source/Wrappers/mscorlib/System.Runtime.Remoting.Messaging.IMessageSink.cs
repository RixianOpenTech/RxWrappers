using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
public static class _IMessageSink
{
    
public static IObservable<System.Runtime.Remoting.Messaging.IMessage> SyncProcessMessage(this IObservable<System.Runtime.Remoting.Messaging.IMessageSink> IMessageSinkValue, IObservable<System.Runtime.Remoting.Messaging.IMessage> msg)
{
    return Observable.Zip(IMessageSinkValue, msg, (IMessageSinkValueLambda, msgLambda) => IMessageSinkValueLambda.SyncProcessMessage(msgLambda));
}


public static IObservable<System.Runtime.Remoting.Messaging.IMessageCtrl> AsyncProcessMessage(this IObservable<System.Runtime.Remoting.Messaging.IMessageSink> IMessageSinkValue, IObservable<System.Runtime.Remoting.Messaging.IMessage> msg, IObservable<System.Runtime.Remoting.Messaging.IMessageSink> replySink)
{
    return Observable.Zip(IMessageSinkValue, msg, replySink, (IMessageSinkValueLambda, msgLambda, replySinkLambda) => IMessageSinkValueLambda.AsyncProcessMessage(msgLambda, replySinkLambda));
}


public static IObservable<System.Runtime.Remoting.Messaging.IMessageSink> get_NextSink(this IObservable<System.Runtime.Remoting.Messaging.IMessageSink> IMessageSinkValue)
{
    return Observable.Select(IMessageSinkValue, (IMessageSinkValueLambda) => IMessageSinkValueLambda.NextSink);
}

}
}