using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
    public static class __IServerChannelSinkStack
    {
        public static IObservable<System.Reactive.Unit> Push(
            this IObservable<System.Runtime.Remoting.Channels.IServerChannelSinkStack> IServerChannelSinkStackValue,
            IObservable<System.Runtime.Remoting.Channels.IServerChannelSink> sink, IObservable<System.Object> state)
        {
            return ObservableExt.ZipExecute(IServerChannelSinkStackValue, sink, state,
                (IServerChannelSinkStackValueLambda, sinkLambda, stateLambda) =>
                    IServerChannelSinkStackValueLambda.Push(sinkLambda, stateLambda));
        }


        public static IObservable<System.Object> Pop(
            this IObservable<System.Runtime.Remoting.Channels.IServerChannelSinkStack> IServerChannelSinkStackValue,
            IObservable<System.Runtime.Remoting.Channels.IServerChannelSink> sink)
        {
            return Observable.Zip(IServerChannelSinkStackValue, sink,
                (IServerChannelSinkStackValueLambda, sinkLambda) => IServerChannelSinkStackValueLambda.Pop(sinkLambda));
        }


        public static IObservable<System.Reactive.Unit> Store(
            this IObservable<System.Runtime.Remoting.Channels.IServerChannelSinkStack> IServerChannelSinkStackValue,
            IObservable<System.Runtime.Remoting.Channels.IServerChannelSink> sink, IObservable<System.Object> state)
        {
            return ObservableExt.ZipExecute(IServerChannelSinkStackValue, sink, state,
                (IServerChannelSinkStackValueLambda, sinkLambda, stateLambda) =>
                    IServerChannelSinkStackValueLambda.Store(sinkLambda, stateLambda));
        }


        public static IObservable<System.Reactive.Unit> StoreAndDispatch(
            this IObservable<System.Runtime.Remoting.Channels.IServerChannelSinkStack> IServerChannelSinkStackValue,
            IObservable<System.Runtime.Remoting.Channels.IServerChannelSink> sink, IObservable<System.Object> state)
        {
            return ObservableExt.ZipExecute(IServerChannelSinkStackValue, sink, state,
                (IServerChannelSinkStackValueLambda, sinkLambda, stateLambda) =>
                    IServerChannelSinkStackValueLambda.StoreAndDispatch(sinkLambda, stateLambda));
        }


        public static IObservable<System.Reactive.Unit> ServerCallback(
            this IObservable<System.Runtime.Remoting.Channels.IServerChannelSinkStack> IServerChannelSinkStackValue,
            IObservable<System.IAsyncResult> ar)
        {
            return ObservableExt.ZipExecute(IServerChannelSinkStackValue, ar,
                (IServerChannelSinkStackValueLambda, arLambda) =>
                    IServerChannelSinkStackValueLambda.ServerCallback(arLambda));
        }
    }
}