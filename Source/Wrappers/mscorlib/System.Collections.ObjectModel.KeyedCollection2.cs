using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.ObjectModel
{
    public static class __KeyedCollection2
    {
        
        public static IObservable<System.Boolean> Contains<TKey, TItem>(this IObservable<System.Collections.ObjectModel.KeyedCollection<TKey, TItem>> KeyedCollectionValue, IObservable<TKey> key)
        {
            return Observable.Zip(KeyedCollectionValue, key, (KeyedCollectionValueLambda, keyLambda) => KeyedCollectionValueLambda.Contains(keyLambda));
        }


        public static IObservable<System.Boolean> Remove<TKey, TItem>(this IObservable<System.Collections.ObjectModel.KeyedCollection<TKey, TItem>> KeyedCollectionValue, IObservable<TKey> key)
        {
            return Observable.Zip(KeyedCollectionValue, key, (KeyedCollectionValueLambda, keyLambda) => KeyedCollectionValueLambda.Remove(keyLambda));
        }


        public static IObservable<IEqualityComparer<TKey>> get_Comparer<TKey, TItem>(this IObservable<System.Collections.ObjectModel.KeyedCollection<TKey, TItem>> KeyedCollectionValue)
        {
            return Observable.Select(KeyedCollectionValue, (KeyedCollectionValueLambda) => KeyedCollectionValueLambda.Comparer);
        }


        public static IObservable<TItem> get_Item<TKey, TItem>(this IObservable<System.Collections.ObjectModel.KeyedCollection<TKey, TItem>> KeyedCollectionValue, IObservable<TKey> key)
        {
            return Observable.Zip(KeyedCollectionValue, key, (KeyedCollectionValueLambda, keyLambda) => KeyedCollectionValueLambda[keyLambda]);
        }

    }
}