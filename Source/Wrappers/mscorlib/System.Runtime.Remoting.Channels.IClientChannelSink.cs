using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
    public static class __IClientChannelSink
    {
        
        public static IObservable<Tuple<System.Runtime.Remoting.Channels.ITransportHeaders, System.IO.Stream>> ProcessMessage(this IObservable<System.Runtime.Remoting.Channels.IClientChannelSink> IClientChannelSinkValue, IObservable<System.Runtime.Remoting.Messaging.IMessage> msg, IObservable<System.Runtime.Remoting.Channels.ITransportHeaders> requestHeaders, IObservable<System.IO.Stream> requestStream)
        {
            return Observable.Zip(IClientChannelSinkValue, msg, requestHeaders, requestStream, (IClientChannelSinkValueLambda, msgLambda, requestHeadersLambda, requestStreamLambda) => {
System.Runtime.Remoting.Channels.ITransportHeaders responseHeadersOutput = default(System.Runtime.Remoting.Channels.ITransportHeaders);
System.IO.Stream responseStreamOutput = default(System.IO.Stream);
IClientChannelSinkValueLambda.ProcessMessage(msgLambda, requestHeadersLambda, requestStreamLambda, out responseHeadersOutput, out responseStreamOutput);
return Tuple.Create(responseHeadersOutput, responseStreamOutput);
});
        }


        public static IObservable<System.Reactive.Unit> AsyncProcessRequest(this IObservable<System.Runtime.Remoting.Channels.IClientChannelSink> IClientChannelSinkValue, IObservable<System.Runtime.Remoting.Channels.IClientChannelSinkStack> sinkStack, IObservable<System.Runtime.Remoting.Messaging.IMessage> msg, IObservable<System.Runtime.Remoting.Channels.ITransportHeaders> headers, IObservable<System.IO.Stream> stream)
        {
            return ObservableExt.ZipExecute(IClientChannelSinkValue, sinkStack, msg, headers, stream, (IClientChannelSinkValueLambda, sinkStackLambda, msgLambda, headersLambda, streamLambda) => IClientChannelSinkValueLambda.AsyncProcessRequest(sinkStackLambda, msgLambda, headersLambda, streamLambda));
        }


        public static IObservable<System.Reactive.Unit> AsyncProcessResponse(this IObservable<System.Runtime.Remoting.Channels.IClientChannelSink> IClientChannelSinkValue, IObservable<System.Runtime.Remoting.Channels.IClientResponseChannelSinkStack> sinkStack, IObservable<System.Object> state, IObservable<System.Runtime.Remoting.Channels.ITransportHeaders> headers, IObservable<System.IO.Stream> stream)
        {
            return ObservableExt.ZipExecute(IClientChannelSinkValue, sinkStack, state, headers, stream, (IClientChannelSinkValueLambda, sinkStackLambda, stateLambda, headersLambda, streamLambda) => IClientChannelSinkValueLambda.AsyncProcessResponse(sinkStackLambda, stateLambda, headersLambda, streamLambda));
        }


        public static IObservable<System.IO.Stream> GetRequestStream(this IObservable<System.Runtime.Remoting.Channels.IClientChannelSink> IClientChannelSinkValue, IObservable<System.Runtime.Remoting.Messaging.IMessage> msg, IObservable<System.Runtime.Remoting.Channels.ITransportHeaders> headers)
        {
            return Observable.Zip(IClientChannelSinkValue, msg, headers, (IClientChannelSinkValueLambda, msgLambda, headersLambda) => IClientChannelSinkValueLambda.GetRequestStream(msgLambda, headersLambda));
        }


        public static IObservable<System.Runtime.Remoting.Channels.IClientChannelSink> get_NextChannelSink(this IObservable<System.Runtime.Remoting.Channels.IClientChannelSink> IClientChannelSinkValue)
        {
            return Observable.Select(IClientChannelSinkValue, (IClientChannelSinkValueLambda) => IClientChannelSinkValueLambda.NextChannelSink);
        }

    }
}