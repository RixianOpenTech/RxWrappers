using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Generic
{
    public static class __ICollection1
    {
        
        public static IObservable<System.Reactive.Unit> Add<T>(this IObservable<System.Collections.Generic.ICollection<T>> ICollectionValue, IObservable<T> item)
        {
            return ObservableExt.ZipExecute(ICollectionValue, item, (ICollectionValueLambda, itemLambda) => ICollectionValueLambda.Add(itemLambda));
        }


        public static IObservable<System.Reactive.Unit> Clear<T>(this IObservable<System.Collections.Generic.ICollection<T>> ICollectionValue)
        {
            return Observable.Do(ICollectionValue, (ICollectionValueLambda) => ICollectionValueLambda.Clear()).ToUnit();
        }


        public static IObservable<System.Boolean> Contains<T>(this IObservable<System.Collections.Generic.ICollection<T>> ICollectionValue, IObservable<T> item)
        {
            return Observable.Zip(ICollectionValue, item, (ICollectionValueLambda, itemLambda) => ICollectionValueLambda.Contains(itemLambda));
        }


        public static IObservable<System.Reactive.Unit> CopyTo<T>(this IObservable<System.Collections.Generic.ICollection<T>> ICollectionValue, IObservable<T[]> array, IObservable<System.Int32> arrayIndex)
        {
            return ObservableExt.ZipExecute(ICollectionValue, array, arrayIndex, (ICollectionValueLambda, arrayLambda, arrayIndexLambda) => ICollectionValueLambda.CopyTo(arrayLambda, arrayIndexLambda));
        }


        public static IObservable<System.Boolean> Remove<T>(this IObservable<System.Collections.Generic.ICollection<T>> ICollectionValue, IObservable<T> item)
        {
            return Observable.Zip(ICollectionValue, item, (ICollectionValueLambda, itemLambda) => ICollectionValueLambda.Remove(itemLambda));
        }


        public static IObservable<System.Int32> get_Count<T>(this IObservable<System.Collections.Generic.ICollection<T>> ICollectionValue)
        {
            return Observable.Select(ICollectionValue, (ICollectionValueLambda) => ICollectionValueLambda.Count);
        }


        public static IObservable<System.Boolean> get_IsReadOnly<T>(this IObservable<System.Collections.Generic.ICollection<T>> ICollectionValue)
        {
            return Observable.Select(ICollectionValue, (ICollectionValueLambda) => ICollectionValueLambda.IsReadOnly);
        }

    }
}