using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting
{
    public static class __IChannelInfo
    {
        
        public static IObservable<System.Object[]> get_ChannelData(this IObservable<System.Runtime.Remoting.IChannelInfo> IChannelInfoValue)
        {
            return Observable.Select(IChannelInfoValue, (IChannelInfoValueLambda) => IChannelInfoValueLambda.ChannelData);
        }


        public static IObservable<System.Reactive.Unit> set_ChannelData(this IObservable<System.Runtime.Remoting.IChannelInfo> IChannelInfoValue, IObservable<System.Object[]> value)
        {
            return ObservableExt.ZipExecute(IChannelInfoValue, value, (IChannelInfoValueLambda, valueLambda) => IChannelInfoValueLambda.ChannelData = valueLambda);
        }

    }
}