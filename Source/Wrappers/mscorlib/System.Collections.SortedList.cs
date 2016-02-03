using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __SortedList
    {
        
        public static IObservable<System.Reactive.Unit> Add(this IObservable<System.Collections.SortedList> SortedListValue, IObservable<System.Object> key, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(SortedListValue, key, value, (SortedListValueLambda, keyLambda, valueLambda) => SortedListValueLambda.Add(keyLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Clear(this IObservable<System.Collections.SortedList> SortedListValue)
        {
            return Observable.Do(SortedListValue, (SortedListValueLambda) => SortedListValueLambda.Clear()).ToUnit();
        }


        public static IObservable<System.Object> Clone(this IObservable<System.Collections.SortedList> SortedListValue)
        {
            return Observable.Select(SortedListValue, (SortedListValueLambda) => SortedListValueLambda.Clone());
        }


        public static IObservable<System.Boolean> Contains(this IObservable<System.Collections.SortedList> SortedListValue, IObservable<System.Object> key)
        {
            return Observable.Zip(SortedListValue, key, (SortedListValueLambda, keyLambda) => SortedListValueLambda.Contains(keyLambda));
        }


        public static IObservable<System.Boolean> ContainsKey(this IObservable<System.Collections.SortedList> SortedListValue, IObservable<System.Object> key)
        {
            return Observable.Zip(SortedListValue, key, (SortedListValueLambda, keyLambda) => SortedListValueLambda.ContainsKey(keyLambda));
        }


        public static IObservable<System.Boolean> ContainsValue(this IObservable<System.Collections.SortedList> SortedListValue, IObservable<System.Object> value)
        {
            return Observable.Zip(SortedListValue, value, (SortedListValueLambda, valueLambda) => SortedListValueLambda.ContainsValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Collections.SortedList> SortedListValue, IObservable<System.Array> array, IObservable<System.Int32> arrayIndex)
        {
            return ObservableExt.ZipExecute(SortedListValue, array, arrayIndex, (SortedListValueLambda, arrayLambda, arrayIndexLambda) => SortedListValueLambda.CopyTo(arrayLambda, arrayIndexLambda));
        }


        public static IObservable<System.Object> GetByIndex(this IObservable<System.Collections.SortedList> SortedListValue, IObservable<System.Int32> index)
        {
            return Observable.Zip(SortedListValue, index, (SortedListValueLambda, indexLambda) => SortedListValueLambda.GetByIndex(indexLambda));
        }


        public static IObservable<System.Collections.IDictionaryEnumerator> GetEnumerator(this IObservable<System.Collections.SortedList> SortedListValue)
        {
            return Observable.Select(SortedListValue, (SortedListValueLambda) => SortedListValueLambda.GetEnumerator());
        }


        public static IObservable<System.Object> GetKey(this IObservable<System.Collections.SortedList> SortedListValue, IObservable<System.Int32> index)
        {
            return Observable.Zip(SortedListValue, index, (SortedListValueLambda, indexLambda) => SortedListValueLambda.GetKey(indexLambda));
        }


        public static IObservable<System.Collections.IList> GetKeyList(this IObservable<System.Collections.SortedList> SortedListValue)
        {
            return Observable.Select(SortedListValue, (SortedListValueLambda) => SortedListValueLambda.GetKeyList());
        }


        public static IObservable<System.Collections.IList> GetValueList(this IObservable<System.Collections.SortedList> SortedListValue)
        {
            return Observable.Select(SortedListValue, (SortedListValueLambda) => SortedListValueLambda.GetValueList());
        }


        public static IObservable<System.Int32> IndexOfKey(this IObservable<System.Collections.SortedList> SortedListValue, IObservable<System.Object> key)
        {
            return Observable.Zip(SortedListValue, key, (SortedListValueLambda, keyLambda) => SortedListValueLambda.IndexOfKey(keyLambda));
        }


        public static IObservable<System.Int32> IndexOfValue(this IObservable<System.Collections.SortedList> SortedListValue, IObservable<System.Object> value)
        {
            return Observable.Zip(SortedListValue, value, (SortedListValueLambda, valueLambda) => SortedListValueLambda.IndexOfValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAt(this IObservable<System.Collections.SortedList> SortedListValue, IObservable<System.Int32> index)
        {
            return ObservableExt.ZipExecute(SortedListValue, index, (SortedListValueLambda, indexLambda) => SortedListValueLambda.RemoveAt(indexLambda));
        }


        public static IObservable<System.Reactive.Unit> Remove(this IObservable<System.Collections.SortedList> SortedListValue, IObservable<System.Object> key)
        {
            return ObservableExt.ZipExecute(SortedListValue, key, (SortedListValueLambda, keyLambda) => SortedListValueLambda.Remove(keyLambda));
        }


        public static IObservable<System.Reactive.Unit> SetByIndex(this IObservable<System.Collections.SortedList> SortedListValue, IObservable<System.Int32> index, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(SortedListValue, index, value, (SortedListValueLambda, indexLambda, valueLambda) => SortedListValueLambda.SetByIndex(indexLambda, valueLambda));
        }


        public static IObservable<System.Collections.SortedList> Synchronized(IObservable<System.Collections.SortedList> list)
        {
            return Observable.Select(list, (listLambda) => System.Collections.SortedList.Synchronized(listLambda));
        }


        public static IObservable<System.Reactive.Unit> TrimToSize(this IObservable<System.Collections.SortedList> SortedListValue)
        {
            return Observable.Do(SortedListValue, (SortedListValueLambda) => SortedListValueLambda.TrimToSize()).ToUnit();
        }


        public static IObservable<System.Int32> get_Capacity(this IObservable<System.Collections.SortedList> SortedListValue)
        {
            return Observable.Select(SortedListValue, (SortedListValueLambda) => SortedListValueLambda.Capacity);
        }


        public static IObservable<System.Int32> get_Count(this IObservable<System.Collections.SortedList> SortedListValue)
        {
            return Observable.Select(SortedListValue, (SortedListValueLambda) => SortedListValueLambda.Count);
        }


        public static IObservable<System.Collections.ICollection> get_Keys(this IObservable<System.Collections.SortedList> SortedListValue)
        {
            return Observable.Select(SortedListValue, (SortedListValueLambda) => SortedListValueLambda.Keys);
        }


        public static IObservable<System.Collections.ICollection> get_Values(this IObservable<System.Collections.SortedList> SortedListValue)
        {
            return Observable.Select(SortedListValue, (SortedListValueLambda) => SortedListValueLambda.Values);
        }


        public static IObservable<System.Boolean> get_IsReadOnly(this IObservable<System.Collections.SortedList> SortedListValue)
        {
            return Observable.Select(SortedListValue, (SortedListValueLambda) => SortedListValueLambda.IsReadOnly);
        }


        public static IObservable<System.Boolean> get_IsFixedSize(this IObservable<System.Collections.SortedList> SortedListValue)
        {
            return Observable.Select(SortedListValue, (SortedListValueLambda) => SortedListValueLambda.IsFixedSize);
        }


        public static IObservable<System.Boolean> get_IsSynchronized(this IObservable<System.Collections.SortedList> SortedListValue)
        {
            return Observable.Select(SortedListValue, (SortedListValueLambda) => SortedListValueLambda.IsSynchronized);
        }


        public static IObservable<System.Object> get_SyncRoot(this IObservable<System.Collections.SortedList> SortedListValue)
        {
            return Observable.Select(SortedListValue, (SortedListValueLambda) => SortedListValueLambda.SyncRoot);
        }


        public static IObservable<System.Object> get_Item(this IObservable<System.Collections.SortedList> SortedListValue, IObservable<System.Object> key)
        {
            return Observable.Zip(SortedListValue, key, (SortedListValueLambda, keyLambda) => SortedListValueLambda[keyLambda]);
        }


        public static IObservable<System.Reactive.Unit> set_Capacity(this IObservable<System.Collections.SortedList> SortedListValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(SortedListValue, value, (SortedListValueLambda, valueLambda) => SortedListValueLambda.Capacity = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Item(this IObservable<System.Collections.SortedList> SortedListValue, IObservable<System.Object> key, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(SortedListValue, key, value, (SortedListValueLambda, keyLambda, valueLambda) => SortedListValueLambda[keyLambda] = valueLambda);
        }

    }
}