using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __IList
    {
        public static IObservable<System.Int32> Add(this IObservable<System.Collections.IList> IListValue,
            IObservable<System.Object> value)
        {
            return Observable.Zip(IListValue, value,
                (IListValueLambda, valueLambda) => IListValueLambda.Add(valueLambda));
        }


        public static IObservable<System.Boolean> Contains(this IObservable<System.Collections.IList> IListValue,
            IObservable<System.Object> value)
        {
            return Observable.Zip(IListValue, value,
                (IListValueLambda, valueLambda) => IListValueLambda.Contains(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Clear(this IObservable<System.Collections.IList> IListValue)
        {
            return Observable.Do(IListValue, (IListValueLambda) => IListValueLambda.Clear()).ToUnit();
        }


        public static IObservable<System.Int32> IndexOf(this IObservable<System.Collections.IList> IListValue,
            IObservable<System.Object> value)
        {
            return Observable.Zip(IListValue, value,
                (IListValueLambda, valueLambda) => IListValueLambda.IndexOf(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Insert(this IObservable<System.Collections.IList> IListValue,
            IObservable<System.Int32> index, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(IListValue, index, value,
                (IListValueLambda, indexLambda, valueLambda) => IListValueLambda.Insert(indexLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Remove(this IObservable<System.Collections.IList> IListValue,
            IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(IListValue, value,
                (IListValueLambda, valueLambda) => IListValueLambda.Remove(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAt(this IObservable<System.Collections.IList> IListValue,
            IObservable<System.Int32> index)
        {
            return ObservableExt.ZipExecute(IListValue, index,
                (IListValueLambda, indexLambda) => IListValueLambda.RemoveAt(indexLambda));
        }


        public static IObservable<System.Object> get_Item(this IObservable<System.Collections.IList> IListValue,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(IListValue, index, (IListValueLambda, indexLambda) => IListValueLambda[indexLambda]);
        }


        public static IObservable<System.Boolean> get_IsReadOnly(this IObservable<System.Collections.IList> IListValue)
        {
            return Observable.Select(IListValue, (IListValueLambda) => IListValueLambda.IsReadOnly);
        }


        public static IObservable<System.Boolean> get_IsFixedSize(this IObservable<System.Collections.IList> IListValue)
        {
            return Observable.Select(IListValue, (IListValueLambda) => IListValueLambda.IsFixedSize);
        }


        public static IObservable<System.Reactive.Unit> set_Item(this IObservable<System.Collections.IList> IListValue,
            IObservable<System.Int32> index, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(IListValue, index, value,
                (IListValueLambda, indexLambda, valueLambda) => IListValueLambda[indexLambda] = valueLambda);
        }
    }
}