using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
    public static class __IChannel
    {
        
        public static IObservable<Tuple<System.String, System.String>> Parse(this IObservable<System.Runtime.Remoting.Channels.IChannel> IChannelValue, IObservable<System.String> url)
        {
            return Observable.Zip(IChannelValue, url, (IChannelValueLambda, urlLambda) => {
System.String objectURIOutput = default(System.String);
var result = IChannelValueLambda.Parse(urlLambda, out objectURIOutput);
return Tuple.Create(result, objectURIOutput);
});
        }


        public static IObservable<System.Int32> get_ChannelPriority(this IObservable<System.Runtime.Remoting.Channels.IChannel> IChannelValue)
        {
            return Observable.Select(IChannelValue, (IChannelValueLambda) => IChannelValueLambda.ChannelPriority);
        }


        public static IObservable<System.String> get_ChannelName(this IObservable<System.Runtime.Remoting.Channels.IChannel> IChannelValue)
        {
            return Observable.Select(IChannelValue, (IChannelValueLambda) => IChannelValueLambda.ChannelName);
        }

    }
}