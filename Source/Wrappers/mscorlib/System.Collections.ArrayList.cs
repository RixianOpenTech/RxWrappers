using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
public static class _ArrayList
{
    
public static IObservable<System.Collections.ArrayList> Adapter(IObservable<System.Collections.IList> list)
{
    return Observable.Select(list, (listLambda) => System.Collections.ArrayList.Adapter(listLambda));
}


public static IObservable<System.Int32> Add(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Object> value)
{
    return Observable.Zip(ArrayListValue, value, (ArrayListValueLambda, valueLambda) => ArrayListValueLambda.Add(valueLambda));
}


public static IObservable<System.Reactive.Unit> AddRange(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Collections.ICollection> c)
{
    return ObservableExt.ZipExecute(ArrayListValue, c, (ArrayListValueLambda, cLambda) => ArrayListValueLambda.AddRange(cLambda));
}


public static IObservable<System.Int32> BinarySearch(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Int32> index, IObservable<System.Int32> count, IObservable<System.Object> value, IObservable<System.Collections.IComparer> comparer)
{
    return Observable.Zip(ArrayListValue, index, count, value, comparer, (ArrayListValueLambda, indexLambda, countLambda, valueLambda, comparerLambda) => ArrayListValueLambda.BinarySearch(indexLambda, countLambda, valueLambda, comparerLambda));
}


public static IObservable<System.Int32> BinarySearch(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Object> value)
{
    return Observable.Zip(ArrayListValue, value, (ArrayListValueLambda, valueLambda) => ArrayListValueLambda.BinarySearch(valueLambda));
}


public static IObservable<System.Int32> BinarySearch(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Object> value, IObservable<System.Collections.IComparer> comparer)
{
    return Observable.Zip(ArrayListValue, value, comparer, (ArrayListValueLambda, valueLambda, comparerLambda) => ArrayListValueLambda.BinarySearch(valueLambda, comparerLambda));
}


public static IObservable<System.Reactive.Unit> Clear(this IObservable<System.Collections.ArrayList> ArrayListValue)
{
    return Observable.Do(ArrayListValue, (ArrayListValueLambda) => ArrayListValueLambda.Clear()).ToUnit();
}


public static IObservable<System.Object> Clone(this IObservable<System.Collections.ArrayList> ArrayListValue)
{
    return Observable.Select(ArrayListValue, (ArrayListValueLambda) => ArrayListValueLambda.Clone());
}


public static IObservable<System.Boolean> Contains(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Object> item)
{
    return Observable.Zip(ArrayListValue, item, (ArrayListValueLambda, itemLambda) => ArrayListValueLambda.Contains(itemLambda));
}


public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Array> array)
{
    return ObservableExt.ZipExecute(ArrayListValue, array, (ArrayListValueLambda, arrayLambda) => ArrayListValueLambda.CopyTo(arrayLambda));
}


public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Array> array, IObservable<System.Int32> arrayIndex)
{
    return ObservableExt.ZipExecute(ArrayListValue, array, arrayIndex, (ArrayListValueLambda, arrayLambda, arrayIndexLambda) => ArrayListValueLambda.CopyTo(arrayLambda, arrayIndexLambda));
}


public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Int32> index, IObservable<System.Array> array, IObservable<System.Int32> arrayIndex, IObservable<System.Int32> count)
{
    return ObservableExt.ZipExecute(ArrayListValue, index, array, arrayIndex, count, (ArrayListValueLambda, indexLambda, arrayLambda, arrayIndexLambda, countLambda) => ArrayListValueLambda.CopyTo(indexLambda, arrayLambda, arrayIndexLambda, countLambda));
}


public static IObservable<System.Collections.IList> FixedSize(IObservable<System.Collections.IList> list)
{
    return Observable.Select(list, (listLambda) => System.Collections.ArrayList.FixedSize(listLambda));
}


public static IObservable<System.Collections.ArrayList> FixedSize(IObservable<System.Collections.ArrayList> list)
{
    return Observable.Select(list, (listLambda) => System.Collections.ArrayList.FixedSize(listLambda));
}


public static IObservable<System.Collections.IEnumerator> GetEnumerator(this IObservable<System.Collections.ArrayList> ArrayListValue)
{
    return Observable.Select(ArrayListValue, (ArrayListValueLambda) => ArrayListValueLambda.GetEnumerator());
}


public static IObservable<System.Collections.IEnumerator> GetEnumerator(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return Observable.Zip(ArrayListValue, index, count, (ArrayListValueLambda, indexLambda, countLambda) => ArrayListValueLambda.GetEnumerator(indexLambda, countLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Object> value)
{
    return Observable.Zip(ArrayListValue, value, (ArrayListValueLambda, valueLambda) => ArrayListValueLambda.IndexOf(valueLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Object> value, IObservable<System.Int32> startIndex)
{
    return Observable.Zip(ArrayListValue, value, startIndex, (ArrayListValueLambda, valueLambda, startIndexLambda) => ArrayListValueLambda.IndexOf(valueLambda, startIndexLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Object> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(ArrayListValue, value, startIndex, count, (ArrayListValueLambda, valueLambda, startIndexLambda, countLambda) => ArrayListValueLambda.IndexOf(valueLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Reactive.Unit> Insert(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Int32> index, IObservable<System.Object> value)
{
    return ObservableExt.ZipExecute(ArrayListValue, index, value, (ArrayListValueLambda, indexLambda, valueLambda) => ArrayListValueLambda.Insert(indexLambda, valueLambda));
}


public static IObservable<System.Reactive.Unit> InsertRange(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Int32> index, IObservable<System.Collections.ICollection> c)
{
    return ObservableExt.ZipExecute(ArrayListValue, index, c, (ArrayListValueLambda, indexLambda, cLambda) => ArrayListValueLambda.InsertRange(indexLambda, cLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Object> value)
{
    return Observable.Zip(ArrayListValue, value, (ArrayListValueLambda, valueLambda) => ArrayListValueLambda.LastIndexOf(valueLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Object> value, IObservable<System.Int32> startIndex)
{
    return Observable.Zip(ArrayListValue, value, startIndex, (ArrayListValueLambda, valueLambda, startIndexLambda) => ArrayListValueLambda.LastIndexOf(valueLambda, startIndexLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Object> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(ArrayListValue, value, startIndex, count, (ArrayListValueLambda, valueLambda, startIndexLambda, countLambda) => ArrayListValueLambda.LastIndexOf(valueLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Collections.IList> ReadOnly(IObservable<System.Collections.IList> list)
{
    return Observable.Select(list, (listLambda) => System.Collections.ArrayList.ReadOnly(listLambda));
}


public static IObservable<System.Collections.ArrayList> ReadOnly(IObservable<System.Collections.ArrayList> list)
{
    return Observable.Select(list, (listLambda) => System.Collections.ArrayList.ReadOnly(listLambda));
}


public static IObservable<System.Reactive.Unit> Remove(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Object> obj)
{
    return ObservableExt.ZipExecute(ArrayListValue, obj, (ArrayListValueLambda, objLambda) => ArrayListValueLambda.Remove(objLambda));
}


public static IObservable<System.Reactive.Unit> RemoveAt(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Int32> index)
{
    return ObservableExt.ZipExecute(ArrayListValue, index, (ArrayListValueLambda, indexLambda) => ArrayListValueLambda.RemoveAt(indexLambda));
}


public static IObservable<System.Reactive.Unit> RemoveRange(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return ObservableExt.ZipExecute(ArrayListValue, index, count, (ArrayListValueLambda, indexLambda, countLambda) => ArrayListValueLambda.RemoveRange(indexLambda, countLambda));
}


public static IObservable<System.Collections.ArrayList> Repeat(IObservable<System.Object> value, IObservable<System.Int32> count)
{
    return Observable.Zip(value, count, (valueLambda, countLambda) => System.Collections.ArrayList.Repeat(valueLambda, countLambda));
}


public static IObservable<System.Reactive.Unit> Reverse(this IObservable<System.Collections.ArrayList> ArrayListValue)
{
    return Observable.Do(ArrayListValue, (ArrayListValueLambda) => ArrayListValueLambda.Reverse()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Reverse(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return ObservableExt.ZipExecute(ArrayListValue, index, count, (ArrayListValueLambda, indexLambda, countLambda) => ArrayListValueLambda.Reverse(indexLambda, countLambda));
}


public static IObservable<System.Reactive.Unit> SetRange(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Int32> index, IObservable<System.Collections.ICollection> c)
{
    return ObservableExt.ZipExecute(ArrayListValue, index, c, (ArrayListValueLambda, indexLambda, cLambda) => ArrayListValueLambda.SetRange(indexLambda, cLambda));
}


public static IObservable<System.Collections.ArrayList> GetRange(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return Observable.Zip(ArrayListValue, index, count, (ArrayListValueLambda, indexLambda, countLambda) => ArrayListValueLambda.GetRange(indexLambda, countLambda));
}


public static IObservable<System.Reactive.Unit> Sort(this IObservable<System.Collections.ArrayList> ArrayListValue)
{
    return Observable.Do(ArrayListValue, (ArrayListValueLambda) => ArrayListValueLambda.Sort()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Sort(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Collections.IComparer> comparer)
{
    return ObservableExt.ZipExecute(ArrayListValue, comparer, (ArrayListValueLambda, comparerLambda) => ArrayListValueLambda.Sort(comparerLambda));
}


public static IObservable<System.Reactive.Unit> Sort(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Int32> index, IObservable<System.Int32> count, IObservable<System.Collections.IComparer> comparer)
{
    return ObservableExt.ZipExecute(ArrayListValue, index, count, comparer, (ArrayListValueLambda, indexLambda, countLambda, comparerLambda) => ArrayListValueLambda.Sort(indexLambda, countLambda, comparerLambda));
}


public static IObservable<System.Collections.IList> Synchronized(IObservable<System.Collections.IList> list)
{
    return Observable.Select(list, (listLambda) => System.Collections.ArrayList.Synchronized(listLambda));
}


public static IObservable<System.Collections.ArrayList> Synchronized(IObservable<System.Collections.ArrayList> list)
{
    return Observable.Select(list, (listLambda) => System.Collections.ArrayList.Synchronized(listLambda));
}


public static IObservable<System.Object[]> ToArray(this IObservable<System.Collections.ArrayList> ArrayListValue)
{
    return Observable.Select(ArrayListValue, (ArrayListValueLambda) => ArrayListValueLambda.ToArray());
}


public static IObservable<System.Array> ToArray(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Type> type)
{
    return Observable.Zip(ArrayListValue, type, (ArrayListValueLambda, typeLambda) => ArrayListValueLambda.ToArray(typeLambda));
}


public static IObservable<System.Reactive.Unit> TrimToSize(this IObservable<System.Collections.ArrayList> ArrayListValue)
{
    return Observable.Do(ArrayListValue, (ArrayListValueLambda) => ArrayListValueLambda.TrimToSize()).ToUnit();
}


public static IObservable<System.Int32> get_Capacity(this IObservable<System.Collections.ArrayList> ArrayListValue)
{
    return Observable.Select(ArrayListValue, (ArrayListValueLambda) => ArrayListValueLambda.Capacity);
}


public static IObservable<System.Int32> get_Count(this IObservable<System.Collections.ArrayList> ArrayListValue)
{
    return Observable.Select(ArrayListValue, (ArrayListValueLambda) => ArrayListValueLambda.Count);
}


public static IObservable<System.Boolean> get_IsFixedSize(this IObservable<System.Collections.ArrayList> ArrayListValue)
{
    return Observable.Select(ArrayListValue, (ArrayListValueLambda) => ArrayListValueLambda.IsFixedSize);
}


public static IObservable<System.Boolean> get_IsReadOnly(this IObservable<System.Collections.ArrayList> ArrayListValue)
{
    return Observable.Select(ArrayListValue, (ArrayListValueLambda) => ArrayListValueLambda.IsReadOnly);
}


public static IObservable<System.Boolean> get_IsSynchronized(this IObservable<System.Collections.ArrayList> ArrayListValue)
{
    return Observable.Select(ArrayListValue, (ArrayListValueLambda) => ArrayListValueLambda.IsSynchronized);
}


public static IObservable<System.Object> get_SyncRoot(this IObservable<System.Collections.ArrayList> ArrayListValue)
{
    return Observable.Select(ArrayListValue, (ArrayListValueLambda) => ArrayListValueLambda.SyncRoot);
}


public static IObservable<System.Object> get_Item(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Int32> index)
{
    return Observable.Zip(ArrayListValue, index, (ArrayListValueLambda, indexLambda) => ArrayListValueLambda.Item);
}


public static IObservable<System.Reactive.Unit> set_Capacity(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(ArrayListValue, value, (ArrayListValueLambda, valueLambda) => ArrayListValueLambda.Capacity = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Item(this IObservable<System.Collections.ArrayList> ArrayListValue, IObservable<System.Int32> index, IObservable<System.Object> value)
{
    return ObservableExt.ZipExecute(ArrayListValue, index, value, (ArrayListValueLambda, indexLambda, valueLambda) => ArrayListValueLambda.Item = valueLambda);
}

}
}