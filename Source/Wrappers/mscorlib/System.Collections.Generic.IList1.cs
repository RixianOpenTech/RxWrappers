using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Generic
{
public static class _IList1
{
    
public static IObservable<System.Int32> IndexOf<T>(this IObservable<System.Collections.Generic.IList<T>> IListValue, IObservable<T> item)
{
    return Observable.Zip(IListValue, item, (IListValueLambda, itemLambda) => IListValueLambda.IndexOf(itemLambda));
}


public static IObservable<System.Reactive.Unit> Insert<T>(this IObservable<System.Collections.Generic.IList<T>> IListValue, IObservable<System.Int32> index, IObservable<T> item)
{
    return ObservableExt.ZipExecute(IListValue, index, item, (IListValueLambda, indexLambda, itemLambda) => IListValueLambda.Insert(indexLambda, itemLambda));
}


public static IObservable<System.Reactive.Unit> RemoveAt<T>(this IObservable<System.Collections.Generic.IList<T>> IListValue, IObservable<System.Int32> index)
{
    return ObservableExt.ZipExecute(IListValue, index, (IListValueLambda, indexLambda) => IListValueLambda.RemoveAt(indexLambda));
}


public static IObservable<T> get_Item<T>(this IObservable<System.Collections.Generic.IList<T>> IListValue, IObservable<System.Int32> index)
{
    return Observable.Zip(IListValue, index, (IListValueLambda, indexLambda) => IListValueLambda.Item);
}


public static IObservable<System.Reactive.Unit> set_Item<T>(this IObservable<System.Collections.Generic.IList<T>> IListValue, IObservable<System.Int32> index, IObservable<T> value)
{
    return ObservableExt.ZipExecute(IListValue, index, value, (IListValueLambda, indexLambda, valueLambda) => IListValueLambda.Item = valueLambda);
}

}
}