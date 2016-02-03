using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.ObjectModel
{
public static class _Collection1
{
    
public static IObservable<System.Reactive.Unit> Add<T>(this IObservable<System.Collections.ObjectModel.Collection<T>> CollectionValue, IObservable<T> item)
{
    return ObservableExt.ZipExecute(CollectionValue, item, (CollectionValueLambda, itemLambda) => CollectionValueLambda.Add(itemLambda));
}


public static IObservable<System.Reactive.Unit> Clear<T>(this IObservable<System.Collections.ObjectModel.Collection<T>> CollectionValue)
{
    return Observable.Do(CollectionValue, (CollectionValueLambda) => CollectionValueLambda.Clear()).ToUnit();
}


public static IObservable<System.Boolean> Contains<T>(this IObservable<System.Collections.ObjectModel.Collection<T>> CollectionValue, IObservable<T> item)
{
    return Observable.Zip(CollectionValue, item, (CollectionValueLambda, itemLambda) => CollectionValueLambda.Contains(itemLambda));
}


public static IObservable<IEnumerator<T>> GetEnumerator<T>(this IObservable<System.Collections.ObjectModel.Collection<T>> CollectionValue)
{
    return Observable.Select(CollectionValue, (CollectionValueLambda) => CollectionValueLambda.GetEnumerator());
}


public static IObservable<System.Int32> IndexOf<T>(this IObservable<System.Collections.ObjectModel.Collection<T>> CollectionValue, IObservable<T> item)
{
    return Observable.Zip(CollectionValue, item, (CollectionValueLambda, itemLambda) => CollectionValueLambda.IndexOf(itemLambda));
}


public static IObservable<System.Reactive.Unit> Insert<T>(this IObservable<System.Collections.ObjectModel.Collection<T>> CollectionValue, IObservable<System.Int32> index, IObservable<T> item)
{
    return ObservableExt.ZipExecute(CollectionValue, index, item, (CollectionValueLambda, indexLambda, itemLambda) => CollectionValueLambda.Insert(indexLambda, itemLambda));
}


public static IObservable<System.Boolean> Remove<T>(this IObservable<System.Collections.ObjectModel.Collection<T>> CollectionValue, IObservable<T> item)
{
    return Observable.Zip(CollectionValue, item, (CollectionValueLambda, itemLambda) => CollectionValueLambda.Remove(itemLambda));
}


public static IObservable<System.Reactive.Unit> RemoveAt<T>(this IObservable<System.Collections.ObjectModel.Collection<T>> CollectionValue, IObservable<System.Int32> index)
{
    return ObservableExt.ZipExecute(CollectionValue, index, (CollectionValueLambda, indexLambda) => CollectionValueLambda.RemoveAt(indexLambda));
}


public static IObservable<System.Reactive.Unit> CopyTo<T>(this IObservable<System.Collections.ObjectModel.Collection<T>> CollectionValue, IObservable<T[]> array, IObservable<System.Int32> index)
{
    return ObservableExt.ZipExecute(CollectionValue, array, index, (CollectionValueLambda, arrayLambda, indexLambda) => CollectionValueLambda.CopyTo(arrayLambda, indexLambda));
}


public static IObservable<System.Int32> get_Count<T>(this IObservable<System.Collections.ObjectModel.Collection<T>> CollectionValue)
{
    return Observable.Select(CollectionValue, (CollectionValueLambda) => CollectionValueLambda.Count);
}


public static IObservable<T> get_Item<T>(this IObservable<System.Collections.ObjectModel.Collection<T>> CollectionValue, IObservable<System.Int32> index)
{
    return Observable.Zip(CollectionValue, index, (CollectionValueLambda, indexLambda) => CollectionValueLambda.Item);
}


public static IObservable<System.Reactive.Unit> set_Item<T>(this IObservable<System.Collections.ObjectModel.Collection<T>> CollectionValue, IObservable<System.Int32> index, IObservable<T> value)
{
    return ObservableExt.ZipExecute(CollectionValue, index, value, (CollectionValueLambda, indexLambda, valueLambda) => CollectionValueLambda.Item = valueLambda);
}

}
}