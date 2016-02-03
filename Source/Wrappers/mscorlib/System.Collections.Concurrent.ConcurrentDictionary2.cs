using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Concurrent
{
    public static class __ConcurrentDictionary2
    {
        public static IObservable<System.Boolean> TryAdd<TKey, TValue>(
            this IObservable<System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>> ConcurrentDictionaryValue,
            IObservable<TKey> key, IObservable<TValue> value)
        {
            return Observable.Zip(ConcurrentDictionaryValue, key, value,
                (ConcurrentDictionaryValueLambda, keyLambda, valueLambda) =>
                    ConcurrentDictionaryValueLambda.TryAdd(keyLambda, valueLambda));
        }


        public static IObservable<System.Boolean> ContainsKey<TKey, TValue>(
            this IObservable<System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>> ConcurrentDictionaryValue,
            IObservable<TKey> key)
        {
            return Observable.Zip(ConcurrentDictionaryValue, key,
                (ConcurrentDictionaryValueLambda, keyLambda) => ConcurrentDictionaryValueLambda.ContainsKey(keyLambda));
        }


        public static IObservable<Tuple<System.Boolean, TValue>> TryGetValue<TKey, TValue>(
            this IObservable<System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>> ConcurrentDictionaryValue,
            IObservable<TKey> key)
        {
            return Observable.Zip(ConcurrentDictionaryValue, key, (ConcurrentDictionaryValueLambda, keyLambda) =>
            {
                TValue valueOutput = default(TValue);
                var result = ConcurrentDictionaryValueLambda.TryGetValue(keyLambda, out valueOutput);
                return Tuple.Create(result, valueOutput);
            });
        }


        public static IObservable<IEnumerator<KeyValuePair<TKey, TValue>>> GetEnumerator<TKey, TValue>(
            this IObservable<System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>> ConcurrentDictionaryValue)
        {
            return Observable.Select(ConcurrentDictionaryValue,
                (ConcurrentDictionaryValueLambda) => ConcurrentDictionaryValueLambda.GetEnumerator());
        }


        public static IObservable<TValue> GetOrAdd<TKey, TValue>(
            this IObservable<System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>> ConcurrentDictionaryValue,
            IObservable<TKey> key, IObservable<Func<TKey, TValue>> valueFactory)
        {
            return Observable.Zip(ConcurrentDictionaryValue, key, valueFactory,
                (ConcurrentDictionaryValueLambda, keyLambda, valueFactoryLambda) =>
                    ConcurrentDictionaryValueLambda.GetOrAdd(keyLambda, valueFactoryLambda));
        }


        public static IObservable<Tuple<System.Boolean, TValue>> TryRemove<TKey, TValue>(
            this IObservable<System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>> ConcurrentDictionaryValue,
            IObservable<TKey> key)
        {
            return Observable.Zip(ConcurrentDictionaryValue, key, (ConcurrentDictionaryValueLambda, keyLambda) =>
            {
                TValue valueOutput = default(TValue);
                var result = ConcurrentDictionaryValueLambda.TryRemove(keyLambda, out valueOutput);
                return Tuple.Create(result, valueOutput);
            });
        }


        public static IObservable<System.Boolean> TryUpdate<TKey, TValue>(
            this IObservable<System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>> ConcurrentDictionaryValue,
            IObservable<TKey> key, IObservable<TValue> newValue, IObservable<TValue> comparisonValue)
        {
            return Observable.Zip(ConcurrentDictionaryValue, key, newValue, comparisonValue,
                (ConcurrentDictionaryValueLambda, keyLambda, newValueLambda, comparisonValueLambda) =>
                    ConcurrentDictionaryValueLambda.TryUpdate(keyLambda, newValueLambda, comparisonValueLambda));
        }


        public static IObservable<System.Reactive.Unit> Clear<TKey, TValue>(
            this IObservable<System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>> ConcurrentDictionaryValue)
        {
            return
                Observable.Do(ConcurrentDictionaryValue,
                    (ConcurrentDictionaryValueLambda) => ConcurrentDictionaryValueLambda.Clear()).ToUnit();
        }


        public static IObservable<KeyValuePair<TKey, TValue>[]> ToArray<TKey, TValue>(
            this IObservable<System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>> ConcurrentDictionaryValue)
        {
            return Observable.Select(ConcurrentDictionaryValue,
                (ConcurrentDictionaryValueLambda) => ConcurrentDictionaryValueLambda.ToArray());
        }


        public static IObservable<TValue> GetOrAdd<TKey, TValue>(
            this IObservable<System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>> ConcurrentDictionaryValue,
            IObservable<TKey> key, IObservable<TValue> value)
        {
            return Observable.Zip(ConcurrentDictionaryValue, key, value,
                (ConcurrentDictionaryValueLambda, keyLambda, valueLambda) =>
                    ConcurrentDictionaryValueLambda.GetOrAdd(keyLambda, valueLambda));
        }


        public static IObservable<TValue> AddOrUpdate<TKey, TValue>(
            this IObservable<System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>> ConcurrentDictionaryValue,
            IObservable<TKey> key, IObservable<Func<TKey, TValue>> addValueFactory,
            IObservable<Func<TKey, TValue, TValue>> updateValueFactory)
        {
            return Observable.Zip(ConcurrentDictionaryValue, key, addValueFactory, updateValueFactory,
                (ConcurrentDictionaryValueLambda, keyLambda, addValueFactoryLambda, updateValueFactoryLambda) =>
                    ConcurrentDictionaryValueLambda.AddOrUpdate(keyLambda, addValueFactoryLambda,
                        updateValueFactoryLambda));
        }


        public static IObservable<TValue> AddOrUpdate<TKey, TValue>(
            this IObservable<System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>> ConcurrentDictionaryValue,
            IObservable<TKey> key, IObservable<TValue> addValue,
            IObservable<Func<TKey, TValue, TValue>> updateValueFactory)
        {
            return Observable.Zip(ConcurrentDictionaryValue, key, addValue, updateValueFactory,
                (ConcurrentDictionaryValueLambda, keyLambda, addValueLambda, updateValueFactoryLambda) =>
                    ConcurrentDictionaryValueLambda.AddOrUpdate(keyLambda, addValueLambda, updateValueFactoryLambda));
        }


        public static IObservable<TValue> get_Item<TKey, TValue>(
            this IObservable<System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>> ConcurrentDictionaryValue,
            IObservable<TKey> key)
        {
            return Observable.Zip(ConcurrentDictionaryValue, key,
                (ConcurrentDictionaryValueLambda, keyLambda) => ConcurrentDictionaryValueLambda[keyLambda]);
        }


        public static IObservable<System.Int32> get_Count<TKey, TValue>(
            this IObservable<System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>> ConcurrentDictionaryValue)
        {
            return Observable.Select(ConcurrentDictionaryValue,
                (ConcurrentDictionaryValueLambda) => ConcurrentDictionaryValueLambda.Count);
        }


        public static IObservable<System.Boolean> get_IsEmpty<TKey, TValue>(
            this IObservable<System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>> ConcurrentDictionaryValue)
        {
            return Observable.Select(ConcurrentDictionaryValue,
                (ConcurrentDictionaryValueLambda) => ConcurrentDictionaryValueLambda.IsEmpty);
        }


        public static IObservable<ICollection<TKey>> get_Keys<TKey, TValue>(
            this IObservable<System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>> ConcurrentDictionaryValue)
        {
            return Observable.Select(ConcurrentDictionaryValue,
                (ConcurrentDictionaryValueLambda) => ConcurrentDictionaryValueLambda.Keys);
        }


        public static IObservable<ICollection<TValue>> get_Values<TKey, TValue>(
            this IObservable<System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>> ConcurrentDictionaryValue)
        {
            return Observable.Select(ConcurrentDictionaryValue,
                (ConcurrentDictionaryValueLambda) => ConcurrentDictionaryValueLambda.Values);
        }


        public static IObservable<System.Reactive.Unit> set_Item<TKey, TValue>(
            this IObservable<System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>> ConcurrentDictionaryValue,
            IObservable<TKey> key, IObservable<TValue> value)
        {
            return ObservableExt.ZipExecute(ConcurrentDictionaryValue, key, value,
                (ConcurrentDictionaryValueLambda, keyLambda, valueLambda) =>
                    ConcurrentDictionaryValueLambda[keyLambda] = valueLambda);
        }
    }
}