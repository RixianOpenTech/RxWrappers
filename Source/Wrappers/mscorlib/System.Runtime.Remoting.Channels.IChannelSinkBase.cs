using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
public static class _IChannelSinkBase
{
    
public static IObservable<System.Collections.IDictionary> get_Properties(this IObservable<System.Runtime.Remoting.Channels.IChannelSinkBase> IChannelSinkBaseValue)
{
    return Observable.Select(IChannelSinkBaseValue, (IChannelSinkBaseValueLambda) => IChannelSinkBaseValueLambda.Properties);
}

}
}