using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
public static class _IServerResponseChannelSinkStack
{
    
public static IObservable<System.Reactive.Unit> AsyncProcessResponse(this IObservable<System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack> IServerResponseChannelSinkStackValue, IObservable<System.Runtime.Remoting.Messaging.IMessage> msg, IObservable<System.Runtime.Remoting.Channels.ITransportHeaders> headers, IObservable<System.IO.Stream> stream)
{
    return ObservableExt.ZipExecute(IServerResponseChannelSinkStackValue, msg, headers, stream, (IServerResponseChannelSinkStackValueLambda, msgLambda, headersLambda, streamLambda) => IServerResponseChannelSinkStackValueLambda.AsyncProcessResponse(msgLambda, headersLambda, streamLambda));
}


public static IObservable<System.IO.Stream> GetResponseStream(this IObservable<System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack> IServerResponseChannelSinkStackValue, IObservable<System.Runtime.Remoting.Messaging.IMessage> msg, IObservable<System.Runtime.Remoting.Channels.ITransportHeaders> headers)
{
    return Observable.Zip(IServerResponseChannelSinkStackValue, msg, headers, (IServerResponseChannelSinkStackValueLambda, msgLambda, headersLambda) => IServerResponseChannelSinkStackValueLambda.GetResponseStream(msgLambda, headersLambda));
}

}
}