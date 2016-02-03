using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
    public static class __IChannelSender
    {
        
        public static IObservable<Tuple<System.Runtime.Remoting.Messaging.IMessageSink, System.String>> CreateMessageSink(this IObservable<System.Runtime.Remoting.Channels.IChannelSender> IChannelSenderValue, IObservable<System.String> url, IObservable<System.Object> remoteChannelData)
        {
            return Observable.Zip(IChannelSenderValue, url, remoteChannelData, (IChannelSenderValueLambda, urlLambda, remoteChannelDataLambda) => {
System.String objectURIOutput = default(System.String);
var result = IChannelSenderValueLambda.CreateMessageSink(urlLambda, remoteChannelDataLambda, out objectURIOutput);
return Tuple.Create(result, objectURIOutput);
});
        }

    }
}