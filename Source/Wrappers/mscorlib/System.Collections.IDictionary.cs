using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __IDictionary
    {
        public static IObservable<System.Boolean> Contains(
            this IObservable<System.Collections.IDictionary> IDictionaryValue, IObservable<System.Object> key)
        {
            return Observable.Zip(IDictionaryValue, key,
                (IDictionaryValueLambda, keyLambda) => IDictionaryValueLambda.Contains(keyLambda));
        }


        public static IObservable<System.Reactive.Unit> Add(
            this IObservable<System.Collections.IDictionary> IDictionaryValue, IObservable<System.Object> key,
            IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(IDictionaryValue, key, value,
                (IDictionaryValueLambda, keyLambda, valueLambda) => IDictionaryValueLambda.Add(keyLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Clear(
            this IObservable<System.Collections.IDictionary> IDictionaryValue)
        {
            return Observable.Do(IDictionaryValue, (IDictionaryValueLambda) => IDictionaryValueLambda.Clear()).ToUnit();
        }


        public static IObservable<System.Collections.IDictionaryEnumerator> GetEnumerator(
            this IObservable<System.Collections.IDictionary> IDictionaryValue)
        {
            return Observable.Select(IDictionaryValue,
                (IDictionaryValueLambda) => IDictionaryValueLambda.GetEnumerator());
        }


        public static IObservable<System.Reactive.Unit> Remove(
            this IObservable<System.Collections.IDictionary> IDictionaryValue, IObservable<System.Object> key)
        {
            return ObservableExt.ZipExecute(IDictionaryValue, key,
                (IDictionaryValueLambda, keyLambda) => IDictionaryValueLambda.Remove(keyLambda));
        }


        public static IObservable<System.Object> get_Item(
            this IObservable<System.Collections.IDictionary> IDictionaryValue, IObservable<System.Object> key)
        {
            return Observable.Zip(IDictionaryValue, key,
                (IDictionaryValueLambda, keyLambda) => IDictionaryValueLambda[keyLambda]);
        }


        public static IObservable<System.Collections.ICollection> get_Keys(
            this IObservable<System.Collections.IDictionary> IDictionaryValue)
        {
            return Observable.Select(IDictionaryValue, (IDictionaryValueLambda) => IDictionaryValueLambda.Keys);
        }


        public static IObservable<System.Collections.ICollection> get_Values(
            this IObservable<System.Collections.IDictionary> IDictionaryValue)
        {
            return Observable.Select(IDictionaryValue, (IDictionaryValueLambda) => IDictionaryValueLambda.Values);
        }


        public static IObservable<System.Boolean> get_IsReadOnly(
            this IObservable<System.Collections.IDictionary> IDictionaryValue)
        {
            return Observable.Select(IDictionaryValue, (IDictionaryValueLambda) => IDictionaryValueLambda.IsReadOnly);
        }


        public static IObservable<System.Boolean> get_IsFixedSize(
            this IObservable<System.Collections.IDictionary> IDictionaryValue)
        {
            return Observable.Select(IDictionaryValue, (IDictionaryValueLambda) => IDictionaryValueLambda.IsFixedSize);
        }


        public static IObservable<System.Reactive.Unit> set_Item(
            this IObservable<System.Collections.IDictionary> IDictionaryValue, IObservable<System.Object> key,
            IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(IDictionaryValue, key, value,
                (IDictionaryValueLambda, keyLambda, valueLambda) => IDictionaryValueLambda[keyLambda] = valueLambda);
        }
    }
}