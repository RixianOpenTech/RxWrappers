using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
public static class _IChannelReceiver
{
    
public static IObservable<System.String[]> GetUrlsForUri(this IObservable<System.Runtime.Remoting.Channels.IChannelReceiver> IChannelReceiverValue, IObservable<System.String> objectURI)
{
    return Observable.Zip(IChannelReceiverValue, objectURI, (IChannelReceiverValueLambda, objectURILambda) => IChannelReceiverValueLambda.GetUrlsForUri(objectURILambda));
}


public static IObservable<System.Reactive.Unit> StartListening(this IObservable<System.Runtime.Remoting.Channels.IChannelReceiver> IChannelReceiverValue, IObservable<System.Object> data)
{
    return ObservableExt.ZipExecute(IChannelReceiverValue, data, (IChannelReceiverValueLambda, dataLambda) => IChannelReceiverValueLambda.StartListening(dataLambda));
}


public static IObservable<System.Reactive.Unit> StopListening(this IObservable<System.Runtime.Remoting.Channels.IChannelReceiver> IChannelReceiverValue, IObservable<System.Object> data)
{
    return ObservableExt.ZipExecute(IChannelReceiverValue, data, (IChannelReceiverValueLambda, dataLambda) => IChannelReceiverValueLambda.StopListening(dataLambda));
}


public static IObservable<System.Object> get_ChannelData(this IObservable<System.Runtime.Remoting.Channels.IChannelReceiver> IChannelReceiverValue)
{
    return Observable.Select(IChannelReceiverValue, (IChannelReceiverValueLambda) => IChannelReceiverValueLambda.ChannelData);
}

}
}