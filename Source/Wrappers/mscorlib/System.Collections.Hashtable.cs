using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __Hashtable
    {
        
        public static IObservable<System.Reactive.Unit> Add(this IObservable<System.Collections.Hashtable> HashtableValue, IObservable<System.Object> key, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(HashtableValue, key, value, (HashtableValueLambda, keyLambda, valueLambda) => HashtableValueLambda.Add(keyLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Clear(this IObservable<System.Collections.Hashtable> HashtableValue)
        {
            return Observable.Do(HashtableValue, (HashtableValueLambda) => HashtableValueLambda.Clear()).ToUnit();
        }


        public static IObservable<System.Object> Clone(this IObservable<System.Collections.Hashtable> HashtableValue)
        {
            return Observable.Select(HashtableValue, (HashtableValueLambda) => HashtableValueLambda.Clone());
        }


        public static IObservable<System.Boolean> Contains(this IObservable<System.Collections.Hashtable> HashtableValue, IObservable<System.Object> key)
        {
            return Observable.Zip(HashtableValue, key, (HashtableValueLambda, keyLambda) => HashtableValueLambda.Contains(keyLambda));
        }


        public static IObservable<System.Boolean> ContainsKey(this IObservable<System.Collections.Hashtable> HashtableValue, IObservable<System.Object> key)
        {
            return Observable.Zip(HashtableValue, key, (HashtableValueLambda, keyLambda) => HashtableValueLambda.ContainsKey(keyLambda));
        }


        public static IObservable<System.Boolean> ContainsValue(this IObservable<System.Collections.Hashtable> HashtableValue, IObservable<System.Object> value)
        {
            return Observable.Zip(HashtableValue, value, (HashtableValueLambda, valueLambda) => HashtableValueLambda.ContainsValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Collections.Hashtable> HashtableValue, IObservable<System.Array> array, IObservable<System.Int32> arrayIndex)
        {
            return ObservableExt.ZipExecute(HashtableValue, array, arrayIndex, (HashtableValueLambda, arrayLambda, arrayIndexLambda) => HashtableValueLambda.CopyTo(arrayLambda, arrayIndexLambda));
        }


        public static IObservable<System.Collections.IDictionaryEnumerator> GetEnumerator(this IObservable<System.Collections.Hashtable> HashtableValue)
        {
            return Observable.Select(HashtableValue, (HashtableValueLambda) => HashtableValueLambda.GetEnumerator());
        }


        public static IObservable<System.Reactive.Unit> Remove(this IObservable<System.Collections.Hashtable> HashtableValue, IObservable<System.Object> key)
        {
            return ObservableExt.ZipExecute(HashtableValue, key, (HashtableValueLambda, keyLambda) => HashtableValueLambda.Remove(keyLambda));
        }


        public static IObservable<System.Collections.Hashtable> Synchronized(IObservable<System.Collections.Hashtable> table)
        {
            return Observable.Select(table, (tableLambda) => System.Collections.Hashtable.Synchronized(tableLambda));
        }


        public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.Collections.Hashtable> HashtableValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(HashtableValue, info, context, (HashtableValueLambda, infoLambda, contextLambda) => HashtableValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.Reactive.Unit> OnDeserialization(this IObservable<System.Collections.Hashtable> HashtableValue, IObservable<System.Object> sender)
        {
            return ObservableExt.ZipExecute(HashtableValue, sender, (HashtableValueLambda, senderLambda) => HashtableValueLambda.OnDeserialization(senderLambda));
        }


        public static IObservable<System.Object> get_Item(this IObservable<System.Collections.Hashtable> HashtableValue, IObservable<System.Object> key)
        {
            return Observable.Zip(HashtableValue, key, (HashtableValueLambda, keyLambda) => HashtableValueLambda[keyLambda]);
        }


        public static IObservable<System.Boolean> get_IsReadOnly(this IObservable<System.Collections.Hashtable> HashtableValue)
        {
            return Observable.Select(HashtableValue, (HashtableValueLambda) => HashtableValueLambda.IsReadOnly);
        }


        public static IObservable<System.Boolean> get_IsFixedSize(this IObservable<System.Collections.Hashtable> HashtableValue)
        {
            return Observable.Select(HashtableValue, (HashtableValueLambda) => HashtableValueLambda.IsFixedSize);
        }


        public static IObservable<System.Boolean> get_IsSynchronized(this IObservable<System.Collections.Hashtable> HashtableValue)
        {
            return Observable.Select(HashtableValue, (HashtableValueLambda) => HashtableValueLambda.IsSynchronized);
        }


        public static IObservable<System.Collections.ICollection> get_Keys(this IObservable<System.Collections.Hashtable> HashtableValue)
        {
            return Observable.Select(HashtableValue, (HashtableValueLambda) => HashtableValueLambda.Keys);
        }


        public static IObservable<System.Collections.ICollection> get_Values(this IObservable<System.Collections.Hashtable> HashtableValue)
        {
            return Observable.Select(HashtableValue, (HashtableValueLambda) => HashtableValueLambda.Values);
        }


        public static IObservable<System.Object> get_SyncRoot(this IObservable<System.Collections.Hashtable> HashtableValue)
        {
            return Observable.Select(HashtableValue, (HashtableValueLambda) => HashtableValueLambda.SyncRoot);
        }


        public static IObservable<System.Int32> get_Count(this IObservable<System.Collections.Hashtable> HashtableValue)
        {
            return Observable.Select(HashtableValue, (HashtableValueLambda) => HashtableValueLambda.Count);
        }


        public static IObservable<System.Reactive.Unit> set_Item(this IObservable<System.Collections.Hashtable> HashtableValue, IObservable<System.Object> key, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(HashtableValue, key, value, (HashtableValueLambda, keyLambda, valueLambda) => HashtableValueLambda[keyLambda] = valueLambda);
        }

    }
}