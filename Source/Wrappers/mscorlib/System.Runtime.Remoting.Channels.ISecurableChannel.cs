using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
public static class _ISecurableChannel
{
    
public static IObservable<System.Boolean> get_IsSecured(this IObservable<System.Runtime.Remoting.Channels.ISecurableChannel> ISecurableChannelValue)
{
    return Observable.Select(ISecurableChannelValue, (ISecurableChannelValueLambda) => ISecurableChannelValueLambda.IsSecured);
}


public static IObservable<System.Reactive.Unit> set_IsSecured(this IObservable<System.Runtime.Remoting.Channels.ISecurableChannel> ISecurableChannelValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(ISecurableChannelValue, value, (ISecurableChannelValueLambda, valueLambda) => ISecurableChannelValueLambda.IsSecured = valueLambda);
}

}
}