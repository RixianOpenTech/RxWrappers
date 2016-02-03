using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.ObjectModel
{
    public static class __ReadOnlyCollection1
    {
        
        public static IObservable<System.Boolean> Contains<T>(this IObservable<System.Collections.ObjectModel.ReadOnlyCollection<T>> ReadOnlyCollectionValue, IObservable<T> value)
        {
            return Observable.Zip(ReadOnlyCollectionValue, value, (ReadOnlyCollectionValueLambda, valueLambda) => ReadOnlyCollectionValueLambda.Contains(valueLambda));
        }


        public static IObservable<IEnumerator<T>> GetEnumerator<T>(this IObservable<System.Collections.ObjectModel.ReadOnlyCollection<T>> ReadOnlyCollectionValue)
        {
            return Observable.Select(ReadOnlyCollectionValue, (ReadOnlyCollectionValueLambda) => ReadOnlyCollectionValueLambda.GetEnumerator());
        }


        public static IObservable<System.Int32> IndexOf<T>(this IObservable<System.Collections.ObjectModel.ReadOnlyCollection<T>> ReadOnlyCollectionValue, IObservable<T> value)
        {
            return Observable.Zip(ReadOnlyCollectionValue, value, (ReadOnlyCollectionValueLambda, valueLambda) => ReadOnlyCollectionValueLambda.IndexOf(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> CopyTo<T>(this IObservable<System.Collections.ObjectModel.ReadOnlyCollection<T>> ReadOnlyCollectionValue, IObservable<T[]> array, IObservable<System.Int32> index)
        {
            return ObservableExt.ZipExecute(ReadOnlyCollectionValue, array, index, (ReadOnlyCollectionValueLambda, arrayLambda, indexLambda) => ReadOnlyCollectionValueLambda.CopyTo(arrayLambda, indexLambda));
        }


        public static IObservable<System.Int32> get_Count<T>(this IObservable<System.Collections.ObjectModel.ReadOnlyCollection<T>> ReadOnlyCollectionValue)
        {
            return Observable.Select(ReadOnlyCollectionValue, (ReadOnlyCollectionValueLambda) => ReadOnlyCollectionValueLambda.Count);
        }


        public static IObservable<T> get_Item<T>(this IObservable<System.Collections.ObjectModel.ReadOnlyCollection<T>> ReadOnlyCollectionValue, IObservable<System.Int32> index)
        {
            return Observable.Zip(ReadOnlyCollectionValue, index, (ReadOnlyCollectionValueLambda, indexLambda) => ReadOnlyCollectionValueLambda[indexLambda]);
        }

    }
}