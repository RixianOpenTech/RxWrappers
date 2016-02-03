using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
public static class _ClientChannelSinkStack
{
    
public static IObservable<System.Reactive.Unit> Push(this IObservable<System.Runtime.Remoting.Channels.ClientChannelSinkStack> ClientChannelSinkStackValue, IObservable<System.Runtime.Remoting.Channels.IClientChannelSink> sink, IObservable<System.Object> state)
{
    return ObservableExt.ZipExecute(ClientChannelSinkStackValue, sink, state, (ClientChannelSinkStackValueLambda, sinkLambda, stateLambda) => ClientChannelSinkStackValueLambda.Push(sinkLambda, stateLambda));
}


public static IObservable<System.Object> Pop(this IObservable<System.Runtime.Remoting.Channels.ClientChannelSinkStack> ClientChannelSinkStackValue, IObservable<System.Runtime.Remoting.Channels.IClientChannelSink> sink)
{
    return Observable.Zip(ClientChannelSinkStackValue, sink, (ClientChannelSinkStackValueLambda, sinkLambda) => ClientChannelSinkStackValueLambda.Pop(sinkLambda));
}


public static IObservable<System.Reactive.Unit> AsyncProcessResponse(this IObservable<System.Runtime.Remoting.Channels.ClientChannelSinkStack> ClientChannelSinkStackValue, IObservable<System.Runtime.Remoting.Channels.ITransportHeaders> headers, IObservable<System.IO.Stream> stream)
{
    return ObservableExt.ZipExecute(ClientChannelSinkStackValue, headers, stream, (ClientChannelSinkStackValueLambda, headersLambda, streamLambda) => ClientChannelSinkStackValueLambda.AsyncProcessResponse(headersLambda, streamLambda));
}


public static IObservable<System.Reactive.Unit> DispatchReplyMessage(this IObservable<System.Runtime.Remoting.Channels.ClientChannelSinkStack> ClientChannelSinkStackValue, IObservable<System.Runtime.Remoting.Messaging.IMessage> msg)
{
    return ObservableExt.ZipExecute(ClientChannelSinkStackValue, msg, (ClientChannelSinkStackValueLambda, msgLambda) => ClientChannelSinkStackValueLambda.DispatchReplyMessage(msgLambda));
}


public static IObservable<System.Reactive.Unit> DispatchException(this IObservable<System.Runtime.Remoting.Channels.ClientChannelSinkStack> ClientChannelSinkStackValue, IObservable<System.Exception> e)
{
    return ObservableExt.ZipExecute(ClientChannelSinkStackValue, e, (ClientChannelSinkStackValueLambda, eLambda) => ClientChannelSinkStackValueLambda.DispatchException(eLambda));
}

}
}