using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Generic
{
    public static class __IDictionary2
    {
        public static IObservable<System.Boolean> ContainsKey<TKey, TValue>(
            this IObservable<System.Collections.Generic.IDictionary<TKey, TValue>> IDictionaryValue,
            IObservable<TKey> key)
        {
            return Observable.Zip(IDictionaryValue, key,
                (IDictionaryValueLambda, keyLambda) => IDictionaryValueLambda.ContainsKey(keyLambda));
        }


        public static IObservable<System.Reactive.Unit> Add<TKey, TValue>(
            this IObservable<System.Collections.Generic.IDictionary<TKey, TValue>> IDictionaryValue,
            IObservable<TKey> key, IObservable<TValue> value)
        {
            return ObservableExt.ZipExecute(IDictionaryValue, key, value,
                (IDictionaryValueLambda, keyLambda, valueLambda) => IDictionaryValueLambda.Add(keyLambda, valueLambda));
        }


        public static IObservable<System.Boolean> Remove<TKey, TValue>(
            this IObservable<System.Collections.Generic.IDictionary<TKey, TValue>> IDictionaryValue,
            IObservable<TKey> key)
        {
            return Observable.Zip(IDictionaryValue, key,
                (IDictionaryValueLambda, keyLambda) => IDictionaryValueLambda.Remove(keyLambda));
        }


        public static IObservable<Tuple<System.Boolean, TValue>> TryGetValue<TKey, TValue>(
            this IObservable<System.Collections.Generic.IDictionary<TKey, TValue>> IDictionaryValue,
            IObservable<TKey> key)
        {
            return Observable.Zip(IDictionaryValue, key, (IDictionaryValueLambda, keyLambda) =>
            {
                TValue valueOutput = default(TValue);
                var result = IDictionaryValueLambda.TryGetValue(keyLambda, out valueOutput);
                return Tuple.Create(result, valueOutput);
            });
        }


        public static IObservable<TValue> get_Item<TKey, TValue>(
            this IObservable<System.Collections.Generic.IDictionary<TKey, TValue>> IDictionaryValue,
            IObservable<TKey> key)
        {
            return Observable.Zip(IDictionaryValue, key,
                (IDictionaryValueLambda, keyLambda) => IDictionaryValueLambda[keyLambda]);
        }


        public static IObservable<ICollection<TKey>> get_Keys<TKey, TValue>(
            this IObservable<System.Collections.Generic.IDictionary<TKey, TValue>> IDictionaryValue)
        {
            return Observable.Select(IDictionaryValue, (IDictionaryValueLambda) => IDictionaryValueLambda.Keys);
        }


        public static IObservable<ICollection<TValue>> get_Values<TKey, TValue>(
            this IObservable<System.Collections.Generic.IDictionary<TKey, TValue>> IDictionaryValue)
        {
            return Observable.Select(IDictionaryValue, (IDictionaryValueLambda) => IDictionaryValueLambda.Values);
        }


        public static IObservable<System.Reactive.Unit> set_Item<TKey, TValue>(
            this IObservable<System.Collections.Generic.IDictionary<TKey, TValue>> IDictionaryValue,
            IObservable<TKey> key, IObservable<TValue> value)
        {
            return ObservableExt.ZipExecute(IDictionaryValue, key, value,
                (IDictionaryValueLambda, keyLambda, valueLambda) => IDictionaryValueLambda[keyLambda] = valueLambda);
        }
    }
}