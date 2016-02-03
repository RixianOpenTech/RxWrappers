using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
    public static class __IChannelDataStore
    {
        public static IObservable<System.String[]> get_ChannelUris(
            this IObservable<System.Runtime.Remoting.Channels.IChannelDataStore> IChannelDataStoreValue)
        {
            return Observable.Select(IChannelDataStoreValue,
                (IChannelDataStoreValueLambda) => IChannelDataStoreValueLambda.ChannelUris);
        }


        public static IObservable<System.Object> get_Item(
            this IObservable<System.Runtime.Remoting.Channels.IChannelDataStore> IChannelDataStoreValue,
            IObservable<System.Object> key)
        {
            return Observable.Zip(IChannelDataStoreValue, key,
                (IChannelDataStoreValueLambda, keyLambda) => IChannelDataStoreValueLambda[keyLambda]);
        }


        public static IObservable<System.Reactive.Unit> set_Item(
            this IObservable<System.Runtime.Remoting.Channels.IChannelDataStore> IChannelDataStoreValue,
            IObservable<System.Object> key, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(IChannelDataStoreValue, key, value,
                (IChannelDataStoreValueLambda, keyLambda, valueLambda) =>
                    IChannelDataStoreValueLambda[keyLambda] = valueLambda);
        }
    }
}