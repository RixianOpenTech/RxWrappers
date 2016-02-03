using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
    public static class __IServerChannelSink
    {
        
        public static IObservable<Tuple<System.Runtime.Remoting.Channels.ServerProcessing, System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Channels.ITransportHeaders, System.IO.Stream>> ProcessMessage(this IObservable<System.Runtime.Remoting.Channels.IServerChannelSink> IServerChannelSinkValue, IObservable<System.Runtime.Remoting.Channels.IServerChannelSinkStack> sinkStack, IObservable<System.Runtime.Remoting.Messaging.IMessage> requestMsg, IObservable<System.Runtime.Remoting.Channels.ITransportHeaders> requestHeaders, IObservable<System.IO.Stream> requestStream)
        {
            return Observable.Zip(IServerChannelSinkValue, sinkStack, requestMsg, requestHeaders, requestStream, (IServerChannelSinkValueLambda, sinkStackLambda, requestMsgLambda, requestHeadersLambda, requestStreamLambda) => {
System.Runtime.Remoting.Messaging.IMessage responseMsgOutput = default(System.Runtime.Remoting.Messaging.IMessage);
System.Runtime.Remoting.Channels.ITransportHeaders responseHeadersOutput = default(System.Runtime.Remoting.Channels.ITransportHeaders);
System.IO.Stream responseStreamOutput = default(System.IO.Stream);
var result = IServerChannelSinkValueLambda.ProcessMessage(sinkStackLambda, requestMsgLambda, requestHeadersLambda, requestStreamLambda, out responseMsgOutput, out responseHeadersOutput, out responseStreamOutput);
return Tuple.Create(result, responseMsgOutput, responseHeadersOutput, responseStreamOutput);
});
        }


        public static IObservable<System.Reactive.Unit> AsyncProcessResponse(this IObservable<System.Runtime.Remoting.Channels.IServerChannelSink> IServerChannelSinkValue, IObservable<System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack> sinkStack, IObservable<System.Object> state, IObservable<System.Runtime.Remoting.Messaging.IMessage> msg, IObservable<System.Runtime.Remoting.Channels.ITransportHeaders> headers, IObservable<System.IO.Stream> stream)
        {
            return ObservableExt.ZipExecute(IServerChannelSinkValue, sinkStack, state, msg, headers, stream, (IServerChannelSinkValueLambda, sinkStackLambda, stateLambda, msgLambda, headersLambda, streamLambda) => IServerChannelSinkValueLambda.AsyncProcessResponse(sinkStackLambda, stateLambda, msgLambda, headersLambda, streamLambda));
        }


        public static IObservable<System.IO.Stream> GetResponseStream(this IObservable<System.Runtime.Remoting.Channels.IServerChannelSink> IServerChannelSinkValue, IObservable<System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack> sinkStack, IObservable<System.Object> state, IObservable<System.Runtime.Remoting.Messaging.IMessage> msg, IObservable<System.Runtime.Remoting.Channels.ITransportHeaders> headers)
        {
            return Observable.Zip(IServerChannelSinkValue, sinkStack, state, msg, headers, (IServerChannelSinkValueLambda, sinkStackLambda, stateLambda, msgLambda, headersLambda) => IServerChannelSinkValueLambda.GetResponseStream(sinkStackLambda, stateLambda, msgLambda, headersLambda));
        }


        public static IObservable<System.Runtime.Remoting.Channels.IServerChannelSink> get_NextChannelSink(this IObservable<System.Runtime.Remoting.Channels.IServerChannelSink> IServerChannelSinkValue)
        {
            return Observable.Select(IServerChannelSinkValue, (IServerChannelSinkValueLambda) => IServerChannelSinkValueLambda.NextChannelSink);
        }

    }
}