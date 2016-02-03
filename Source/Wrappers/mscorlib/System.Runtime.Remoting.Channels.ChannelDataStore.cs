using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
    public static class __ChannelDataStore
    {
        
        public static IObservable<System.String[]> get_ChannelUris(this IObservable<System.Runtime.Remoting.Channels.ChannelDataStore> ChannelDataStoreValue)
        {
            return Observable.Select(ChannelDataStoreValue, (ChannelDataStoreValueLambda) => ChannelDataStoreValueLambda.ChannelUris);
        }


        public static IObservable<System.Object> get_Item(this IObservable<System.Runtime.Remoting.Channels.ChannelDataStore> ChannelDataStoreValue, IObservable<System.Object> key)
        {
            return Observable.Zip(ChannelDataStoreValue, key, (ChannelDataStoreValueLambda, keyLambda) => ChannelDataStoreValueLambda[keyLambda]);
        }


        public static IObservable<System.Reactive.Unit> set_ChannelUris(this IObservable<System.Runtime.Remoting.Channels.ChannelDataStore> ChannelDataStoreValue, IObservable<System.String[]> value)
        {
            return ObservableExt.ZipExecute(ChannelDataStoreValue, value, (ChannelDataStoreValueLambda, valueLambda) => ChannelDataStoreValueLambda.ChannelUris = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Item(this IObservable<System.Runtime.Remoting.Channels.ChannelDataStore> ChannelDataStoreValue, IObservable<System.Object> key, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(ChannelDataStoreValue, key, value, (ChannelDataStoreValueLambda, keyLambda, valueLambda) => ChannelDataStoreValueLambda[keyLambda] = valueLambda);
        }

    }
}