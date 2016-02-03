using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
    public static class __ChannelServices
    {
        public static IObservable<System.Reactive.Unit> RegisterChannel(
            IObservable<System.Runtime.Remoting.Channels.IChannel> chnl, IObservable<System.Boolean> ensureSecurity)
        {
            return ObservableExt.ZipExecute(chnl, ensureSecurity,
                (chnlLambda, ensureSecurityLambda) =>
                    System.Runtime.Remoting.Channels.ChannelServices.RegisterChannel(chnlLambda, ensureSecurityLambda));
        }


        public static IObservable<System.Reactive.Unit> RegisterChannel(
            IObservable<System.Runtime.Remoting.Channels.IChannel> chnl)
        {
            return
                Observable.Do(chnl,
                    (chnlLambda) => System.Runtime.Remoting.Channels.ChannelServices.RegisterChannel(chnlLambda))
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> UnregisterChannel(
            IObservable<System.Runtime.Remoting.Channels.IChannel> chnl)
        {
            return
                Observable.Do(chnl,
                    (chnlLambda) => System.Runtime.Remoting.Channels.ChannelServices.UnregisterChannel(chnlLambda))
                    .ToUnit();
        }


        public static IObservable<System.Runtime.Remoting.Channels.IChannel> GetChannel(IObservable<System.String> name)
        {
            return Observable.Select(name,
                (nameLambda) => System.Runtime.Remoting.Channels.ChannelServices.GetChannel(nameLambda));
        }


        public static IObservable<System.String[]> GetUrlsForObject(IObservable<System.MarshalByRefObject> obj)
        {
            return Observable.Select(obj,
                (objLambda) => System.Runtime.Remoting.Channels.ChannelServices.GetUrlsForObject(objLambda));
        }


        public static IObservable<System.Collections.IDictionary> GetChannelSinkProperties(
            IObservable<System.Object> obj)
        {
            return Observable.Select(obj,
                (objLambda) => System.Runtime.Remoting.Channels.ChannelServices.GetChannelSinkProperties(objLambda));
        }


        public static
            IObservable
                <Tuple<System.Runtime.Remoting.Channels.ServerProcessing, System.Runtime.Remoting.Messaging.IMessage>>
            DispatchMessage(IObservable<System.Runtime.Remoting.Channels.IServerChannelSinkStack> sinkStack,
                IObservable<System.Runtime.Remoting.Messaging.IMessage> msg)
        {
            return Observable.Zip(sinkStack, msg, (sinkStackLambda, msgLambda) =>
            {
                System.Runtime.Remoting.Messaging.IMessage replyMsgOutput =
                    default(System.Runtime.Remoting.Messaging.IMessage);
                var result = System.Runtime.Remoting.Channels.ChannelServices.DispatchMessage(sinkStackLambda, msgLambda,
                    out replyMsgOutput);
                return Tuple.Create(result, replyMsgOutput);
            });
        }


        public static IObservable<System.Runtime.Remoting.Messaging.IMessage> SyncDispatchMessage(
            IObservable<System.Runtime.Remoting.Messaging.IMessage> msg)
        {
            return Observable.Select(msg,
                (msgLambda) => System.Runtime.Remoting.Channels.ChannelServices.SyncDispatchMessage(msgLambda));
        }


        public static IObservable<System.Runtime.Remoting.Messaging.IMessageCtrl> AsyncDispatchMessage(
            IObservable<System.Runtime.Remoting.Messaging.IMessage> msg,
            IObservable<System.Runtime.Remoting.Messaging.IMessageSink> replySink)
        {
            return Observable.Zip(msg, replySink,
                (msgLambda, replySinkLambda) =>
                    System.Runtime.Remoting.Channels.ChannelServices.AsyncDispatchMessage(msgLambda, replySinkLambda));
        }


        public static IObservable<System.Runtime.Remoting.Channels.IServerChannelSink> CreateServerChannelSinkChain(
            IObservable<System.Runtime.Remoting.Channels.IServerChannelSinkProvider> provider,
            IObservable<System.Runtime.Remoting.Channels.IChannelReceiver> channel)
        {
            return Observable.Zip(provider, channel,
                (providerLambda, channelLambda) =>
                    System.Runtime.Remoting.Channels.ChannelServices.CreateServerChannelSinkChain(providerLambda,
                        channelLambda));
        }


        public static IObservable<System.Runtime.Remoting.Channels.IChannel[]> get_RegisteredChannels()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Channels.ChannelServices.RegisteredChannels);
        }
    }
}