using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __CollectionBase
    {
        public static IObservable<System.Reactive.Unit> Clear(
            this IObservable<System.Collections.CollectionBase> CollectionBaseValue)
        {
            return
                Observable.Do(CollectionBaseValue, (CollectionBaseValueLambda) => CollectionBaseValueLambda.Clear())
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> RemoveAt(
            this IObservable<System.Collections.CollectionBase> CollectionBaseValue, IObservable<System.Int32> index)
        {
            return ObservableExt.ZipExecute(CollectionBaseValue, index,
                (CollectionBaseValueLambda, indexLambda) => CollectionBaseValueLambda.RemoveAt(indexLambda));
        }


        public static IObservable<System.Collections.IEnumerator> GetEnumerator(
            this IObservable<System.Collections.CollectionBase> CollectionBaseValue)
        {
            return Observable.Select(CollectionBaseValue,
                (CollectionBaseValueLambda) => CollectionBaseValueLambda.GetEnumerator());
        }


        public static IObservable<System.Int32> get_Capacity(
            this IObservable<System.Collections.CollectionBase> CollectionBaseValue)
        {
            return Observable.Select(CollectionBaseValue,
                (CollectionBaseValueLambda) => CollectionBaseValueLambda.Capacity);
        }


        public static IObservable<System.Int32> get_Count(
            this IObservable<System.Collections.CollectionBase> CollectionBaseValue)
        {
            return Observable.Select(CollectionBaseValue, (CollectionBaseValueLambda) => CollectionBaseValueLambda.Count);
        }


        public static IObservable<System.Reactive.Unit> set_Capacity(
            this IObservable<System.Collections.CollectionBase> CollectionBaseValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(CollectionBaseValue, value,
                (CollectionBaseValueLambda, valueLambda) => CollectionBaseValueLambda.Capacity = valueLambda);
        }
    }
}