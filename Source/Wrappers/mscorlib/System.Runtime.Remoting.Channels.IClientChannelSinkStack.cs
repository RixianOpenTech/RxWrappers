using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
    public static class __IClientChannelSinkStack
    {
        public static IObservable<System.Reactive.Unit> Push(
            this IObservable<System.Runtime.Remoting.Channels.IClientChannelSinkStack> IClientChannelSinkStackValue,
            IObservable<System.Runtime.Remoting.Channels.IClientChannelSink> sink, IObservable<System.Object> state)
        {
            return ObservableExt.ZipExecute(IClientChannelSinkStackValue, sink, state,
                (IClientChannelSinkStackValueLambda, sinkLambda, stateLambda) =>
                    IClientChannelSinkStackValueLambda.Push(sinkLambda, stateLambda));
        }


        public static IObservable<System.Object> Pop(
            this IObservable<System.Runtime.Remoting.Channels.IClientChannelSinkStack> IClientChannelSinkStackValue,
            IObservable<System.Runtime.Remoting.Channels.IClientChannelSink> sink)
        {
            return Observable.Zip(IClientChannelSinkStackValue, sink,
                (IClientChannelSinkStackValueLambda, sinkLambda) => IClientChannelSinkStackValueLambda.Pop(sinkLambda));
        }
    }
}