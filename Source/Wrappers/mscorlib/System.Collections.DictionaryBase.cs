using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __DictionaryBase
    {
        public static IObservable<System.Reactive.Unit> CopyTo(
            this IObservable<System.Collections.DictionaryBase> DictionaryBaseValue, IObservable<System.Array> array,
            IObservable<System.Int32> index)
        {
            return ObservableExt.ZipExecute(DictionaryBaseValue, array, index,
                (DictionaryBaseValueLambda, arrayLambda, indexLambda) =>
                    DictionaryBaseValueLambda.CopyTo(arrayLambda, indexLambda));
        }


        public static IObservable<System.Reactive.Unit> Clear(
            this IObservable<System.Collections.DictionaryBase> DictionaryBaseValue)
        {
            return
                Observable.Do(DictionaryBaseValue, (DictionaryBaseValueLambda) => DictionaryBaseValueLambda.Clear())
                    .ToUnit();
        }


        public static IObservable<System.Collections.IDictionaryEnumerator> GetEnumerator(
            this IObservable<System.Collections.DictionaryBase> DictionaryBaseValue)
        {
            return Observable.Select(DictionaryBaseValue,
                (DictionaryBaseValueLambda) => DictionaryBaseValueLambda.GetEnumerator());
        }


        public static IObservable<System.Int32> get_Count(
            this IObservable<System.Collections.DictionaryBase> DictionaryBaseValue)
        {
            return Observable.Select(DictionaryBaseValue, (DictionaryBaseValueLambda) => DictionaryBaseValueLambda.Count);
        }
    }
}