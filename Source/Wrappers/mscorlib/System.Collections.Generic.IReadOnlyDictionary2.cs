using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Generic
{
    public static class __IReadOnlyDictionary2
    {
        public static IObservable<System.Boolean> ContainsKey<TKey, TValue>(
            this IObservable<System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>> IReadOnlyDictionaryValue,
            IObservable<TKey> key)
        {
            return Observable.Zip(IReadOnlyDictionaryValue, key,
                (IReadOnlyDictionaryValueLambda, keyLambda) => IReadOnlyDictionaryValueLambda.ContainsKey(keyLambda));
        }


        public static IObservable<Tuple<System.Boolean, TValue>> TryGetValue<TKey, TValue>(
            this IObservable<System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>> IReadOnlyDictionaryValue,
            IObservable<TKey> key)
        {
            return Observable.Zip(IReadOnlyDictionaryValue, key, (IReadOnlyDictionaryValueLambda, keyLambda) =>
            {
                TValue valueOutput = default(TValue);
                var result = IReadOnlyDictionaryValueLambda.TryGetValue(keyLambda, out valueOutput);
                return Tuple.Create(result, valueOutput);
            });
        }


        public static IObservable<TValue> get_Item<TKey, TValue>(
            this IObservable<System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>> IReadOnlyDictionaryValue,
            IObservable<TKey> key)
        {
            return Observable.Zip(IReadOnlyDictionaryValue, key,
                (IReadOnlyDictionaryValueLambda, keyLambda) => IReadOnlyDictionaryValueLambda[keyLambda]);
        }


        public static IObservable<IEnumerable<TKey>> get_Keys<TKey, TValue>(
            this IObservable<System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>> IReadOnlyDictionaryValue)
        {
            return Observable.Select(IReadOnlyDictionaryValue,
                (IReadOnlyDictionaryValueLambda) => IReadOnlyDictionaryValueLambda.Keys);
        }


        public static IObservable<IEnumerable<TValue>> get_Values<TKey, TValue>(
            this IObservable<System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>> IReadOnlyDictionaryValue)
        {
            return Observable.Select(IReadOnlyDictionaryValue,
                (IReadOnlyDictionaryValueLambda) => IReadOnlyDictionaryValueLambda.Values);
        }
    }
}