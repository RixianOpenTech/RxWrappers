using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
public static class _IServerChannelSinkProvider
{
    
public static IObservable<System.Reactive.Unit> GetChannelData(this IObservable<System.Runtime.Remoting.Channels.IServerChannelSinkProvider> IServerChannelSinkProviderValue, IObservable<System.Runtime.Remoting.Channels.IChannelDataStore> channelData)
{
    return ObservableExt.ZipExecute(IServerChannelSinkProviderValue, channelData, (IServerChannelSinkProviderValueLambda, channelDataLambda) => IServerChannelSinkProviderValueLambda.GetChannelData(channelDataLambda));
}


public static IObservable<System.Runtime.Remoting.Channels.IServerChannelSink> CreateSink(this IObservable<System.Runtime.Remoting.Channels.IServerChannelSinkProvider> IServerChannelSinkProviderValue, IObservable<System.Runtime.Remoting.Channels.IChannelReceiver> channel)
{
    return Observable.Zip(IServerChannelSinkProviderValue, channel, (IServerChannelSinkProviderValueLambda, channelLambda) => IServerChannelSinkProviderValueLambda.CreateSink(channelLambda));
}


public static IObservable<System.Runtime.Remoting.Channels.IServerChannelSinkProvider> get_Next(this IObservable<System.Runtime.Remoting.Channels.IServerChannelSinkProvider> IServerChannelSinkProviderValue)
{
    return Observable.Select(IServerChannelSinkProviderValue, (IServerChannelSinkProviderValueLambda) => IServerChannelSinkProviderValueLambda.Next);
}


public static IObservable<System.Reactive.Unit> set_Next(this IObservable<System.Runtime.Remoting.Channels.IServerChannelSinkProvider> IServerChannelSinkProviderValue, IObservable<System.Runtime.Remoting.Channels.IServerChannelSinkProvider> value)
{
    return ObservableExt.ZipExecute(IServerChannelSinkProviderValue, value, (IServerChannelSinkProviderValueLambda, valueLambda) => IServerChannelSinkProviderValueLambda.Next = valueLambda);
}

}
}