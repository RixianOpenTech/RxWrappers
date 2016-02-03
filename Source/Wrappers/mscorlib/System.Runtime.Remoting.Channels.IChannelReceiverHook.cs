using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
public static class _IChannelReceiverHook
{
    
public static IObservable<System.Reactive.Unit> AddHookChannelUri(this IObservable<System.Runtime.Remoting.Channels.IChannelReceiverHook> IChannelReceiverHookValue, IObservable<System.String> channelUri)
{
    return ObservableExt.ZipExecute(IChannelReceiverHookValue, channelUri, (IChannelReceiverHookValueLambda, channelUriLambda) => IChannelReceiverHookValueLambda.AddHookChannelUri(channelUriLambda));
}


public static IObservable<System.String> get_ChannelScheme(this IObservable<System.Runtime.Remoting.Channels.IChannelReceiverHook> IChannelReceiverHookValue)
{
    return Observable.Select(IChannelReceiverHookValue, (IChannelReceiverHookValueLambda) => IChannelReceiverHookValueLambda.ChannelScheme);
}


public static IObservable<System.Boolean> get_WantsToListen(this IObservable<System.Runtime.Remoting.Channels.IChannelReceiverHook> IChannelReceiverHookValue)
{
    return Observable.Select(IChannelReceiverHookValue, (IChannelReceiverHookValueLambda) => IChannelReceiverHookValueLambda.WantsToListen);
}


public static IObservable<System.Runtime.Remoting.Channels.IServerChannelSink> get_ChannelSinkChain(this IObservable<System.Runtime.Remoting.Channels.IChannelReceiverHook> IChannelReceiverHookValue)
{
    return Observable.Select(IChannelReceiverHookValue, (IChannelReceiverHookValueLambda) => IChannelReceiverHookValueLambda.ChannelSinkChain);
}

}
}