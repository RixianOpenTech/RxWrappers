using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
    public static class __BaseChannelObjectWithProperties
    {
        
        public static IObservable<System.Boolean> Contains(this IObservable<System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties> BaseChannelObjectWithPropertiesValue, IObservable<System.Object> key)
        {
            return Observable.Zip(BaseChannelObjectWithPropertiesValue, key, (BaseChannelObjectWithPropertiesValueLambda, keyLambda) => BaseChannelObjectWithPropertiesValueLambda.Contains(keyLambda));
        }


        public static IObservable<System.Reactive.Unit> Add(this IObservable<System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties> BaseChannelObjectWithPropertiesValue, IObservable<System.Object> key, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(BaseChannelObjectWithPropertiesValue, key, value, (BaseChannelObjectWithPropertiesValueLambda, keyLambda, valueLambda) => BaseChannelObjectWithPropertiesValueLambda.Add(keyLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Clear(this IObservable<System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties> BaseChannelObjectWithPropertiesValue)
        {
            return Observable.Do(BaseChannelObjectWithPropertiesValue, (BaseChannelObjectWithPropertiesValueLambda) => BaseChannelObjectWithPropertiesValueLambda.Clear()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Remove(this IObservable<System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties> BaseChannelObjectWithPropertiesValue, IObservable<System.Object> key)
        {
            return ObservableExt.ZipExecute(BaseChannelObjectWithPropertiesValue, key, (BaseChannelObjectWithPropertiesValueLambda, keyLambda) => BaseChannelObjectWithPropertiesValueLambda.Remove(keyLambda));
        }


        public static IObservable<System.Collections.IDictionaryEnumerator> GetEnumerator(this IObservable<System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties> BaseChannelObjectWithPropertiesValue)
        {
            return Observable.Select(BaseChannelObjectWithPropertiesValue, (BaseChannelObjectWithPropertiesValueLambda) => BaseChannelObjectWithPropertiesValueLambda.GetEnumerator());
        }


        public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties> BaseChannelObjectWithPropertiesValue, IObservable<System.Array> array, IObservable<System.Int32> index)
        {
            return ObservableExt.ZipExecute(BaseChannelObjectWithPropertiesValue, array, index, (BaseChannelObjectWithPropertiesValueLambda, arrayLambda, indexLambda) => BaseChannelObjectWithPropertiesValueLambda.CopyTo(arrayLambda, indexLambda));
        }


        public static IObservable<System.Collections.IDictionary> get_Properties(this IObservable<System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties> BaseChannelObjectWithPropertiesValue)
        {
            return Observable.Select(BaseChannelObjectWithPropertiesValue, (BaseChannelObjectWithPropertiesValueLambda) => BaseChannelObjectWithPropertiesValueLambda.Properties);
        }


        public static IObservable<System.Object> get_Item(this IObservable<System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties> BaseChannelObjectWithPropertiesValue, IObservable<System.Object> key)
        {
            return Observable.Zip(BaseChannelObjectWithPropertiesValue, key, (BaseChannelObjectWithPropertiesValueLambda, keyLambda) => BaseChannelObjectWithPropertiesValueLambda[keyLambda]);
        }


        public static IObservable<System.Collections.ICollection> get_Keys(this IObservable<System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties> BaseChannelObjectWithPropertiesValue)
        {
            return Observable.Select(BaseChannelObjectWithPropertiesValue, (BaseChannelObjectWithPropertiesValueLambda) => BaseChannelObjectWithPropertiesValueLambda.Keys);
        }


        public static IObservable<System.Collections.ICollection> get_Values(this IObservable<System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties> BaseChannelObjectWithPropertiesValue)
        {
            return Observable.Select(BaseChannelObjectWithPropertiesValue, (BaseChannelObjectWithPropertiesValueLambda) => BaseChannelObjectWithPropertiesValueLambda.Values);
        }


        public static IObservable<System.Boolean> get_IsReadOnly(this IObservable<System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties> BaseChannelObjectWithPropertiesValue)
        {
            return Observable.Select(BaseChannelObjectWithPropertiesValue, (BaseChannelObjectWithPropertiesValueLambda) => BaseChannelObjectWithPropertiesValueLambda.IsReadOnly);
        }


        public static IObservable<System.Boolean> get_IsFixedSize(this IObservable<System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties> BaseChannelObjectWithPropertiesValue)
        {
            return Observable.Select(BaseChannelObjectWithPropertiesValue, (BaseChannelObjectWithPropertiesValueLambda) => BaseChannelObjectWithPropertiesValueLambda.IsFixedSize);
        }


        public static IObservable<System.Int32> get_Count(this IObservable<System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties> BaseChannelObjectWithPropertiesValue)
        {
            return Observable.Select(BaseChannelObjectWithPropertiesValue, (BaseChannelObjectWithPropertiesValueLambda) => BaseChannelObjectWithPropertiesValueLambda.Count);
        }


        public static IObservable<System.Object> get_SyncRoot(this IObservable<System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties> BaseChannelObjectWithPropertiesValue)
        {
            return Observable.Select(BaseChannelObjectWithPropertiesValue, (BaseChannelObjectWithPropertiesValueLambda) => BaseChannelObjectWithPropertiesValueLambda.SyncRoot);
        }


        public static IObservable<System.Boolean> get_IsSynchronized(this IObservable<System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties> BaseChannelObjectWithPropertiesValue)
        {
            return Observable.Select(BaseChannelObjectWithPropertiesValue, (BaseChannelObjectWithPropertiesValueLambda) => BaseChannelObjectWithPropertiesValueLambda.IsSynchronized);
        }


        public static IObservable<System.Reactive.Unit> set_Item(this IObservable<System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties> BaseChannelObjectWithPropertiesValue, IObservable<System.Object> key, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(BaseChannelObjectWithPropertiesValue, key, value, (BaseChannelObjectWithPropertiesValueLambda, keyLambda, valueLambda) => BaseChannelObjectWithPropertiesValueLambda[keyLambda] = valueLambda);
        }

    }
}