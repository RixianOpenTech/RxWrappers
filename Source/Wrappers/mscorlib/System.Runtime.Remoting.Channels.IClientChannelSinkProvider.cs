using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
public static class _IClientChannelSinkProvider
{
    
public static IObservable<System.Runtime.Remoting.Channels.IClientChannelSink> CreateSink(this IObservable<System.Runtime.Remoting.Channels.IClientChannelSinkProvider> IClientChannelSinkProviderValue, IObservable<System.Runtime.Remoting.Channels.IChannelSender> channel, IObservable<System.String> url, IObservable<System.Object> remoteChannelData)
{
    return Observable.Zip(IClientChannelSinkProviderValue, channel, url, remoteChannelData, (IClientChannelSinkProviderValueLambda, channelLambda, urlLambda, remoteChannelDataLambda) => IClientChannelSinkProviderValueLambda.CreateSink(channelLambda, urlLambda, remoteChannelDataLambda));
}


public static IObservable<System.Runtime.Remoting.Channels.IClientChannelSinkProvider> get_Next(this IObservable<System.Runtime.Remoting.Channels.IClientChannelSinkProvider> IClientChannelSinkProviderValue)
{
    return Observable.Select(IClientChannelSinkProviderValue, (IClientChannelSinkProviderValueLambda) => IClientChannelSinkProviderValueLambda.Next);
}


public static IObservable<System.Reactive.Unit> set_Next(this IObservable<System.Runtime.Remoting.Channels.IClientChannelSinkProvider> IClientChannelSinkProviderValue, IObservable<System.Runtime.Remoting.Channels.IClientChannelSinkProvider> value)
{
    return ObservableExt.ZipExecute(IClientChannelSinkProviderValue, value, (IClientChannelSinkProviderValueLambda, valueLambda) => IClientChannelSinkProviderValueLambda.Next = valueLambda);
}

}
}