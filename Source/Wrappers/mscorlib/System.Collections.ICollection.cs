using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __ICollection
    {
        
        public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Collections.ICollection> ICollectionValue, IObservable<System.Array> array, IObservable<System.Int32> index)
        {
            return ObservableExt.ZipExecute(ICollectionValue, array, index, (ICollectionValueLambda, arrayLambda, indexLambda) => ICollectionValueLambda.CopyTo(arrayLambda, indexLambda));
        }


        public static IObservable<System.Int32> get_Count(this IObservable<System.Collections.ICollection> ICollectionValue)
        {
            return Observable.Select(ICollectionValue, (ICollectionValueLambda) => ICollectionValueLambda.Count);
        }


        public static IObservable<System.Object> get_SyncRoot(this IObservable<System.Collections.ICollection> ICollectionValue)
        {
            return Observable.Select(ICollectionValue, (ICollectionValueLambda) => ICollectionValueLambda.SyncRoot);
        }


        public static IObservable<System.Boolean> get_IsSynchronized(this IObservable<System.Collections.ICollection> ICollectionValue)
        {
            return Observable.Select(ICollectionValue, (ICollectionValueLambda) => ICollectionValueLambda.IsSynchronized);
        }

    }
}