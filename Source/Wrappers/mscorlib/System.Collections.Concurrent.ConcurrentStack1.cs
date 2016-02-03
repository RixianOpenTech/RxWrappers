using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Concurrent
{
public static class _ConcurrentStack1
{
    
public static IObservable<System.Reactive.Unit> Push<T>(this IObservable<System.Collections.Concurrent.ConcurrentStack<T>> ConcurrentStackValue, IObservable<T> item)
{
    return ObservableExt.ZipExecute(ConcurrentStackValue, item, (ConcurrentStackValueLambda, itemLambda) => ConcurrentStackValueLambda.Push(itemLambda));
}


public static IObservable<Tuple<System.Boolean, T>> TryPop<T>(this IObservable<System.Collections.Concurrent.ConcurrentStack<T>> ConcurrentStackValue)
{
    return Observable.Select(ConcurrentStackValue, (ConcurrentStackValueLambda) => {
T resultOutput = default(T);
var result = ConcurrentStackValueLambda.TryPop(out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<IEnumerator<T>> GetEnumerator<T>(this IObservable<System.Collections.Concurrent.ConcurrentStack<T>> ConcurrentStackValue)
{
    return Observable.Select(ConcurrentStackValue, (ConcurrentStackValueLambda) => ConcurrentStackValueLambda.GetEnumerator());
}


public static IObservable<System.Reactive.Unit> Clear<T>(this IObservable<System.Collections.Concurrent.ConcurrentStack<T>> ConcurrentStackValue)
{
    return Observable.Do(ConcurrentStackValue, (ConcurrentStackValueLambda) => ConcurrentStackValueLambda.Clear()).ToUnit();
}


public static IObservable<System.Reactive.Unit> CopyTo<T>(this IObservable<System.Collections.Concurrent.ConcurrentStack<T>> ConcurrentStackValue, IObservable<T[]> array, IObservable<System.Int32> index)
{
    return ObservableExt.ZipExecute(ConcurrentStackValue, array, index, (ConcurrentStackValueLambda, arrayLambda, indexLambda) => ConcurrentStackValueLambda.CopyTo(arrayLambda, indexLambda));
}


public static IObservable<System.Reactive.Unit> PushRange<T>(this IObservable<System.Collections.Concurrent.ConcurrentStack<T>> ConcurrentStackValue, IObservable<T[]> items)
{
    return ObservableExt.ZipExecute(ConcurrentStackValue, items, (ConcurrentStackValueLambda, itemsLambda) => ConcurrentStackValueLambda.PushRange(itemsLambda));
}


public static IObservable<System.Reactive.Unit> PushRange<T>(this IObservable<System.Collections.Concurrent.ConcurrentStack<T>> ConcurrentStackValue, IObservable<T[]> items, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return ObservableExt.ZipExecute(ConcurrentStackValue, items, startIndex, count, (ConcurrentStackValueLambda, itemsLambda, startIndexLambda, countLambda) => ConcurrentStackValueLambda.PushRange(itemsLambda, startIndexLambda, countLambda));
}


public static IObservable<Tuple<System.Boolean, T>> TryPeek<T>(this IObservable<System.Collections.Concurrent.ConcurrentStack<T>> ConcurrentStackValue)
{
    return Observable.Select(ConcurrentStackValue, (ConcurrentStackValueLambda) => {
T resultOutput = default(T);
var result = ConcurrentStackValueLambda.TryPeek(out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<System.Int32> TryPopRange<T>(this IObservable<System.Collections.Concurrent.ConcurrentStack<T>> ConcurrentStackValue, IObservable<T[]> items)
{
    return Observable.Zip(ConcurrentStackValue, items, (ConcurrentStackValueLambda, itemsLambda) => ConcurrentStackValueLambda.TryPopRange(itemsLambda));
}


public static IObservable<System.Int32> TryPopRange<T>(this IObservable<System.Collections.Concurrent.ConcurrentStack<T>> ConcurrentStackValue, IObservable<T[]> items, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(ConcurrentStackValue, items, startIndex, count, (ConcurrentStackValueLambda, itemsLambda, startIndexLambda, countLambda) => ConcurrentStackValueLambda.TryPopRange(itemsLambda, startIndexLambda, countLambda));
}


public static IObservable<T[]> ToArray<T>(this IObservable<System.Collections.Concurrent.ConcurrentStack<T>> ConcurrentStackValue)
{
    return Observable.Select(ConcurrentStackValue, (ConcurrentStackValueLambda) => ConcurrentStackValueLambda.ToArray());
}


public static IObservable<System.Boolean> get_IsEmpty<T>(this IObservable<System.Collections.Concurrent.ConcurrentStack<T>> ConcurrentStackValue)
{
    return Observable.Select(ConcurrentStackValue, (ConcurrentStackValueLambda) => ConcurrentStackValueLambda.IsEmpty);
}


public static IObservable<System.Int32> get_Count<T>(this IObservable<System.Collections.Concurrent.ConcurrentStack<T>> ConcurrentStackValue)
{
    return Observable.Select(ConcurrentStackValue, (ConcurrentStackValueLambda) => ConcurrentStackValueLambda.Count);
}

}
}