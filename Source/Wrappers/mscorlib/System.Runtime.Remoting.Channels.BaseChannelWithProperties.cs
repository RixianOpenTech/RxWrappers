using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
    public static class __BaseChannelWithProperties
    {
        public static IObservable<System.Collections.IDictionary> get_Properties(
            this IObservable<System.Runtime.Remoting.Channels.BaseChannelWithProperties> BaseChannelWithPropertiesValue)
        {
            return Observable.Select(BaseChannelWithPropertiesValue,
                (BaseChannelWithPropertiesValueLambda) => BaseChannelWithPropertiesValueLambda.Properties);
        }
    }
}