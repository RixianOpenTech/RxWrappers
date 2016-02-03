using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
    public static class __ServerChannelSinkStack
    {
        
        public static IObservable<System.Reactive.Unit> Push(this IObservable<System.Runtime.Remoting.Channels.ServerChannelSinkStack> ServerChannelSinkStackValue, IObservable<System.Runtime.Remoting.Channels.IServerChannelSink> sink, IObservable<System.Object> state)
        {
            return ObservableExt.ZipExecute(ServerChannelSinkStackValue, sink, state, (ServerChannelSinkStackValueLambda, sinkLambda, stateLambda) => ServerChannelSinkStackValueLambda.Push(sinkLambda, stateLambda));
        }


        public static IObservable<System.Object> Pop(this IObservable<System.Runtime.Remoting.Channels.ServerChannelSinkStack> ServerChannelSinkStackValue, IObservable<System.Runtime.Remoting.Channels.IServerChannelSink> sink)
        {
            return Observable.Zip(ServerChannelSinkStackValue, sink, (ServerChannelSinkStackValueLambda, sinkLambda) => ServerChannelSinkStackValueLambda.Pop(sinkLambda));
        }


        public static IObservable<System.Reactive.Unit> Store(this IObservable<System.Runtime.Remoting.Channels.ServerChannelSinkStack> ServerChannelSinkStackValue, IObservable<System.Runtime.Remoting.Channels.IServerChannelSink> sink, IObservable<System.Object> state)
        {
            return ObservableExt.ZipExecute(ServerChannelSinkStackValue, sink, state, (ServerChannelSinkStackValueLambda, sinkLambda, stateLambda) => ServerChannelSinkStackValueLambda.Store(sinkLambda, stateLambda));
        }


        public static IObservable<System.Reactive.Unit> StoreAndDispatch(this IObservable<System.Runtime.Remoting.Channels.ServerChannelSinkStack> ServerChannelSinkStackValue, IObservable<System.Runtime.Remoting.Channels.IServerChannelSink> sink, IObservable<System.Object> state)
        {
            return ObservableExt.ZipExecute(ServerChannelSinkStackValue, sink, state, (ServerChannelSinkStackValueLambda, sinkLambda, stateLambda) => ServerChannelSinkStackValueLambda.StoreAndDispatch(sinkLambda, stateLambda));
        }


        public static IObservable<System.Reactive.Unit> AsyncProcessResponse(this IObservable<System.Runtime.Remoting.Channels.ServerChannelSinkStack> ServerChannelSinkStackValue, IObservable<System.Runtime.Remoting.Messaging.IMessage> msg, IObservable<System.Runtime.Remoting.Channels.ITransportHeaders> headers, IObservable<System.IO.Stream> stream)
        {
            return ObservableExt.ZipExecute(ServerChannelSinkStackValue, msg, headers, stream, (ServerChannelSinkStackValueLambda, msgLambda, headersLambda, streamLambda) => ServerChannelSinkStackValueLambda.AsyncProcessResponse(msgLambda, headersLambda, streamLambda));
        }


        public static IObservable<System.IO.Stream> GetResponseStream(this IObservable<System.Runtime.Remoting.Channels.ServerChannelSinkStack> ServerChannelSinkStackValue, IObservable<System.Runtime.Remoting.Messaging.IMessage> msg, IObservable<System.Runtime.Remoting.Channels.ITransportHeaders> headers)
        {
            return Observable.Zip(ServerChannelSinkStackValue, msg, headers, (ServerChannelSinkStackValueLambda, msgLambda, headersLambda) => ServerChannelSinkStackValueLambda.GetResponseStream(msgLambda, headersLambda));
        }


        public static IObservable<System.Reactive.Unit> ServerCallback(this IObservable<System.Runtime.Remoting.Channels.ServerChannelSinkStack> ServerChannelSinkStackValue, IObservable<System.IAsyncResult> ar)
        {
            return ObservableExt.ZipExecute(ServerChannelSinkStackValue, ar, (ServerChannelSinkStackValueLambda, arLambda) => ServerChannelSinkStackValueLambda.ServerCallback(arLambda));
        }

    }
}