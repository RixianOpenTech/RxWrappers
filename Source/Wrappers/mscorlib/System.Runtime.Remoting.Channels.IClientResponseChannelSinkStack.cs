using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
    public static class __IClientResponseChannelSinkStack
    {
        
        public static IObservable<System.Reactive.Unit> AsyncProcessResponse(this IObservable<System.Runtime.Remoting.Channels.IClientResponseChannelSinkStack> IClientResponseChannelSinkStackValue, IObservable<System.Runtime.Remoting.Channels.ITransportHeaders> headers, IObservable<System.IO.Stream> stream)
        {
            return ObservableExt.ZipExecute(IClientResponseChannelSinkStackValue, headers, stream, (IClientResponseChannelSinkStackValueLambda, headersLambda, streamLambda) => IClientResponseChannelSinkStackValueLambda.AsyncProcessResponse(headersLambda, streamLambda));
        }


        public static IObservable<System.Reactive.Unit> DispatchReplyMessage(this IObservable<System.Runtime.Remoting.Channels.IClientResponseChannelSinkStack> IClientResponseChannelSinkStackValue, IObservable<System.Runtime.Remoting.Messaging.IMessage> msg)
        {
            return ObservableExt.ZipExecute(IClientResponseChannelSinkStackValue, msg, (IClientResponseChannelSinkStackValueLambda, msgLambda) => IClientResponseChannelSinkStackValueLambda.DispatchReplyMessage(msgLambda));
        }


        public static IObservable<System.Reactive.Unit> DispatchException(this IObservable<System.Runtime.Remoting.Channels.IClientResponseChannelSinkStack> IClientResponseChannelSinkStackValue, IObservable<System.Exception> e)
        {
            return ObservableExt.ZipExecute(IClientResponseChannelSinkStackValue, e, (IClientResponseChannelSinkStackValueLambda, eLambda) => IClientResponseChannelSinkStackValueLambda.DispatchException(eLambda));
        }

    }
}