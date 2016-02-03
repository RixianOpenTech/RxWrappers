using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _Array
{
    
public static IObservable<ReadOnlyCollection<T>> AsReadOnly<T>(IObservable<T[]> array)
{
    return Observable.Select(array, (arrayLambda) => System.Array.AsReadOnly(arrayLambda));
}


public static IObservable<T[]> Resize<T>(IObservable<T[]> array, IObservable<System.Int32> newSize)
{
    return Observable.Zip(array, newSize, (arrayLambda, newSizeLambda) => {
System.Array.Resize(ref arrayLambda, newSizeLambda);
return arrayLambda;
});
}


public static IObservable<System.Array> CreateInstance(IObservable<System.Type> elementType, IObservable<System.Int32> length)
{
    return Observable.Zip(elementType, length, (elementTypeLambda, lengthLambda) => System.Array.CreateInstance(elementTypeLambda, lengthLambda));
}


public static IObservable<System.Array> CreateInstance(IObservable<System.Type> elementType, IObservable<System.Int32> length1, IObservable<System.Int32> length2)
{
    return Observable.Zip(elementType, length1, length2, (elementTypeLambda, length1Lambda, length2Lambda) => System.Array.CreateInstance(elementTypeLambda, length1Lambda, length2Lambda));
}


public static IObservable<System.Array> CreateInstance(IObservable<System.Type> elementType, IObservable<System.Int32> length1, IObservable<System.Int32> length2, IObservable<System.Int32> length3)
{
    return Observable.Zip(elementType, length1, length2, length3, (elementTypeLambda, length1Lambda, length2Lambda, length3Lambda) => System.Array.CreateInstance(elementTypeLambda, length1Lambda, length2Lambda, length3Lambda));
}


public static IObservable<System.Array> CreateInstance(IObservable<System.Type> elementType, IObservable<System.Int32[]> lengths)
{
    return Observable.Zip(elementType, lengths, (elementTypeLambda, lengthsLambda) => System.Array.CreateInstance(elementTypeLambda, lengthsLambda));
}


public static IObservable<System.Array> CreateInstance(IObservable<System.Type> elementType, IObservable<System.Int64[]> lengths)
{
    return Observable.Zip(elementType, lengths, (elementTypeLambda, lengthsLambda) => System.Array.CreateInstance(elementTypeLambda, lengthsLambda));
}


public static IObservable<System.Array> CreateInstance(IObservable<System.Type> elementType, IObservable<System.Int32[]> lengths, IObservable<System.Int32[]> lowerBounds)
{
    return Observable.Zip(elementType, lengths, lowerBounds, (elementTypeLambda, lengthsLambda, lowerBoundsLambda) => System.Array.CreateInstance(elementTypeLambda, lengthsLambda, lowerBoundsLambda));
}


public static IObservable<System.Reactive.Unit> Copy(IObservable<System.Array> sourceArray, IObservable<System.Array> destinationArray, IObservable<System.Int32> length)
{
    return ObservableExt.ZipExecute(sourceArray, destinationArray, length, (sourceArrayLambda, destinationArrayLambda, lengthLambda) => System.Array.Copy(sourceArrayLambda, destinationArrayLambda, lengthLambda));
}


public static IObservable<System.Reactive.Unit> Copy(IObservable<System.Array> sourceArray, IObservable<System.Int32> sourceIndex, IObservable<System.Array> destinationArray, IObservable<System.Int32> destinationIndex, IObservable<System.Int32> length)
{
    return ObservableExt.ZipExecute(sourceArray, sourceIndex, destinationArray, destinationIndex, length, (sourceArrayLambda, sourceIndexLambda, destinationArrayLambda, destinationIndexLambda, lengthLambda) => System.Array.Copy(sourceArrayLambda, sourceIndexLambda, destinationArrayLambda, destinationIndexLambda, lengthLambda));
}


public static IObservable<System.Reactive.Unit> ConstrainedCopy(IObservable<System.Array> sourceArray, IObservable<System.Int32> sourceIndex, IObservable<System.Array> destinationArray, IObservable<System.Int32> destinationIndex, IObservable<System.Int32> length)
{
    return ObservableExt.ZipExecute(sourceArray, sourceIndex, destinationArray, destinationIndex, length, (sourceArrayLambda, sourceIndexLambda, destinationArrayLambda, destinationIndexLambda, lengthLambda) => System.Array.ConstrainedCopy(sourceArrayLambda, sourceIndexLambda, destinationArrayLambda, destinationIndexLambda, lengthLambda));
}


public static IObservable<System.Reactive.Unit> Copy(IObservable<System.Array> sourceArray, IObservable<System.Array> destinationArray, IObservable<System.Int64> length)
{
    return ObservableExt.ZipExecute(sourceArray, destinationArray, length, (sourceArrayLambda, destinationArrayLambda, lengthLambda) => System.Array.Copy(sourceArrayLambda, destinationArrayLambda, lengthLambda));
}


public static IObservable<System.Reactive.Unit> Copy(IObservable<System.Array> sourceArray, IObservable<System.Int64> sourceIndex, IObservable<System.Array> destinationArray, IObservable<System.Int64> destinationIndex, IObservable<System.Int64> length)
{
    return ObservableExt.ZipExecute(sourceArray, sourceIndex, destinationArray, destinationIndex, length, (sourceArrayLambda, sourceIndexLambda, destinationArrayLambda, destinationIndexLambda, lengthLambda) => System.Array.Copy(sourceArrayLambda, sourceIndexLambda, destinationArrayLambda, destinationIndexLambda, lengthLambda));
}


public static IObservable<System.Reactive.Unit> Clear(IObservable<System.Array> array, IObservable<System.Int32> index, IObservable<System.Int32> length)
{
    return ObservableExt.ZipExecute(array, index, length, (arrayLambda, indexLambda, lengthLambda) => System.Array.Clear(arrayLambda, indexLambda, lengthLambda));
}


public static IObservable<System.Object> GetValue(this IObservable<System.Array> ArrayValue, IObservable<System.Int32[]> indices)
{
    return Observable.Zip(ArrayValue, indices, (ArrayValueLambda, indicesLambda) => ArrayValueLambda.GetValue(indicesLambda));
}


public static IObservable<System.Object> GetValue(this IObservable<System.Array> ArrayValue, IObservable<System.Int32> index)
{
    return Observable.Zip(ArrayValue, index, (ArrayValueLambda, indexLambda) => ArrayValueLambda.GetValue(indexLambda));
}


public static IObservable<System.Object> GetValue(this IObservable<System.Array> ArrayValue, IObservable<System.Int32> index1, IObservable<System.Int32> index2)
{
    return Observable.Zip(ArrayValue, index1, index2, (ArrayValueLambda, index1Lambda, index2Lambda) => ArrayValueLambda.GetValue(index1Lambda, index2Lambda));
}


public static IObservable<System.Object> GetValue(this IObservable<System.Array> ArrayValue, IObservable<System.Int32> index1, IObservable<System.Int32> index2, IObservable<System.Int32> index3)
{
    return Observable.Zip(ArrayValue, index1, index2, index3, (ArrayValueLambda, index1Lambda, index2Lambda, index3Lambda) => ArrayValueLambda.GetValue(index1Lambda, index2Lambda, index3Lambda));
}


public static IObservable<System.Object> GetValue(this IObservable<System.Array> ArrayValue, IObservable<System.Int64> index)
{
    return Observable.Zip(ArrayValue, index, (ArrayValueLambda, indexLambda) => ArrayValueLambda.GetValue(indexLambda));
}


public static IObservable<System.Object> GetValue(this IObservable<System.Array> ArrayValue, IObservable<System.Int64> index1, IObservable<System.Int64> index2)
{
    return Observable.Zip(ArrayValue, index1, index2, (ArrayValueLambda, index1Lambda, index2Lambda) => ArrayValueLambda.GetValue(index1Lambda, index2Lambda));
}


public static IObservable<System.Object> GetValue(this IObservable<System.Array> ArrayValue, IObservable<System.Int64> index1, IObservable<System.Int64> index2, IObservable<System.Int64> index3)
{
    return Observable.Zip(ArrayValue, index1, index2, index3, (ArrayValueLambda, index1Lambda, index2Lambda, index3Lambda) => ArrayValueLambda.GetValue(index1Lambda, index2Lambda, index3Lambda));
}


public static IObservable<System.Object> GetValue(this IObservable<System.Array> ArrayValue, IObservable<System.Int64[]> indices)
{
    return Observable.Zip(ArrayValue, indices, (ArrayValueLambda, indicesLambda) => ArrayValueLambda.GetValue(indicesLambda));
}


public static IObservable<System.Reactive.Unit> SetValue(this IObservable<System.Array> ArrayValue, IObservable<System.Object> value, IObservable<System.Int32> index)
{
    return ObservableExt.ZipExecute(ArrayValue, value, index, (ArrayValueLambda, valueLambda, indexLambda) => ArrayValueLambda.SetValue(valueLambda, indexLambda));
}


public static IObservable<System.Reactive.Unit> SetValue(this IObservable<System.Array> ArrayValue, IObservable<System.Object> value, IObservable<System.Int32> index1, IObservable<System.Int32> index2)
{
    return ObservableExt.ZipExecute(ArrayValue, value, index1, index2, (ArrayValueLambda, valueLambda, index1Lambda, index2Lambda) => ArrayValueLambda.SetValue(valueLambda, index1Lambda, index2Lambda));
}


public static IObservable<System.Reactive.Unit> SetValue(this IObservable<System.Array> ArrayValue, IObservable<System.Object> value, IObservable<System.Int32> index1, IObservable<System.Int32> index2, IObservable<System.Int32> index3)
{
    return ObservableExt.ZipExecute(ArrayValue, value, index1, index2, index3, (ArrayValueLambda, valueLambda, index1Lambda, index2Lambda, index3Lambda) => ArrayValueLambda.SetValue(valueLambda, index1Lambda, index2Lambda, index3Lambda));
}


public static IObservable<System.Reactive.Unit> SetValue(this IObservable<System.Array> ArrayValue, IObservable<System.Object> value, IObservable<System.Int32[]> indices)
{
    return ObservableExt.ZipExecute(ArrayValue, value, indices, (ArrayValueLambda, valueLambda, indicesLambda) => ArrayValueLambda.SetValue(valueLambda, indicesLambda));
}


public static IObservable<System.Reactive.Unit> SetValue(this IObservable<System.Array> ArrayValue, IObservable<System.Object> value, IObservable<System.Int64> index)
{
    return ObservableExt.ZipExecute(ArrayValue, value, index, (ArrayValueLambda, valueLambda, indexLambda) => ArrayValueLambda.SetValue(valueLambda, indexLambda));
}


public static IObservable<System.Reactive.Unit> SetValue(this IObservable<System.Array> ArrayValue, IObservable<System.Object> value, IObservable<System.Int64> index1, IObservable<System.Int64> index2)
{
    return ObservableExt.ZipExecute(ArrayValue, value, index1, index2, (ArrayValueLambda, valueLambda, index1Lambda, index2Lambda) => ArrayValueLambda.SetValue(valueLambda, index1Lambda, index2Lambda));
}


public static IObservable<System.Reactive.Unit> SetValue(this IObservable<System.Array> ArrayValue, IObservable<System.Object> value, IObservable<System.Int64> index1, IObservable<System.Int64> index2, IObservable<System.Int64> index3)
{
    return ObservableExt.ZipExecute(ArrayValue, value, index1, index2, index3, (ArrayValueLambda, valueLambda, index1Lambda, index2Lambda, index3Lambda) => ArrayValueLambda.SetValue(valueLambda, index1Lambda, index2Lambda, index3Lambda));
}


public static IObservable<System.Reactive.Unit> SetValue(this IObservable<System.Array> ArrayValue, IObservable<System.Object> value, IObservable<System.Int64[]> indices)
{
    return ObservableExt.ZipExecute(ArrayValue, value, indices, (ArrayValueLambda, valueLambda, indicesLambda) => ArrayValueLambda.SetValue(valueLambda, indicesLambda));
}


public static IObservable<System.Int32> GetLength(this IObservable<System.Array> ArrayValue, IObservable<System.Int32> dimension)
{
    return Observable.Zip(ArrayValue, dimension, (ArrayValueLambda, dimensionLambda) => ArrayValueLambda.GetLength(dimensionLambda));
}


public static IObservable<System.Int64> GetLongLength(this IObservable<System.Array> ArrayValue, IObservable<System.Int32> dimension)
{
    return Observable.Zip(ArrayValue, dimension, (ArrayValueLambda, dimensionLambda) => ArrayValueLambda.GetLongLength(dimensionLambda));
}


public static IObservable<System.Int32> GetUpperBound(this IObservable<System.Array> ArrayValue, IObservable<System.Int32> dimension)
{
    return Observable.Zip(ArrayValue, dimension, (ArrayValueLambda, dimensionLambda) => ArrayValueLambda.GetUpperBound(dimensionLambda));
}


public static IObservable<System.Int32> GetLowerBound(this IObservable<System.Array> ArrayValue, IObservable<System.Int32> dimension)
{
    return Observable.Zip(ArrayValue, dimension, (ArrayValueLambda, dimensionLambda) => ArrayValueLambda.GetLowerBound(dimensionLambda));
}


public static IObservable<System.Object> Clone(this IObservable<System.Array> ArrayValue)
{
    return Observable.Select(ArrayValue, (ArrayValueLambda) => ArrayValueLambda.Clone());
}


public static IObservable<System.Int32> BinarySearch(IObservable<System.Array> array, IObservable<System.Object> value)
{
    return Observable.Zip(array, value, (arrayLambda, valueLambda) => System.Array.BinarySearch(arrayLambda, valueLambda));
}


public static IObservable<System.Int32> BinarySearch(IObservable<System.Array> array, IObservable<System.Int32> index, IObservable<System.Int32> length, IObservable<System.Object> value)
{
    return Observable.Zip(array, index, length, value, (arrayLambda, indexLambda, lengthLambda, valueLambda) => System.Array.BinarySearch(arrayLambda, indexLambda, lengthLambda, valueLambda));
}


public static IObservable<System.Int32> BinarySearch(IObservable<System.Array> array, IObservable<System.Object> value, IObservable<System.Collections.IComparer> comparer)
{
    return Observable.Zip(array, value, comparer, (arrayLambda, valueLambda, comparerLambda) => System.Array.BinarySearch(arrayLambda, valueLambda, comparerLambda));
}


public static IObservable<System.Int32> BinarySearch(IObservable<System.Array> array, IObservable<System.Int32> index, IObservable<System.Int32> length, IObservable<System.Object> value, IObservable<System.Collections.IComparer> comparer)
{
    return Observable.Zip(array, index, length, value, comparer, (arrayLambda, indexLambda, lengthLambda, valueLambda, comparerLambda) => System.Array.BinarySearch(arrayLambda, indexLambda, lengthLambda, valueLambda, comparerLambda));
}


public static IObservable<System.Int32> BinarySearch<T>(IObservable<T[]> array, IObservable<T> value)
{
    return Observable.Zip(array, value, (arrayLambda, valueLambda) => System.Array.BinarySearch(arrayLambda, valueLambda));
}


public static IObservable<System.Int32> BinarySearch<T>(IObservable<T[]> array, IObservable<T> value, IObservable<IComparer<T>> comparer)
{
    return Observable.Zip(array, value, comparer, (arrayLambda, valueLambda, comparerLambda) => System.Array.BinarySearch(arrayLambda, valueLambda, comparerLambda));
}


public static IObservable<System.Int32> BinarySearch<T>(IObservable<T[]> array, IObservable<System.Int32> index, IObservable<System.Int32> length, IObservable<T> value)
{
    return Observable.Zip(array, index, length, value, (arrayLambda, indexLambda, lengthLambda, valueLambda) => System.Array.BinarySearch(arrayLambda, indexLambda, lengthLambda, valueLambda));
}


public static IObservable<System.Int32> BinarySearch<T>(IObservable<T[]> array, IObservable<System.Int32> index, IObservable<System.Int32> length, IObservable<T> value, IObservable<IComparer<T>> comparer)
{
    return Observable.Zip(array, index, length, value, comparer, (arrayLambda, indexLambda, lengthLambda, valueLambda, comparerLambda) => System.Array.BinarySearch(arrayLambda, indexLambda, lengthLambda, valueLambda, comparerLambda));
}


public static IObservable<TOutput[]> ConvertAll<TInput, TOutput>(IObservable<TInput[]> array, IObservable<Converter<TInput, TOutput>> converter)
{
    return Observable.Zip(array, converter, (arrayLambda, converterLambda) => System.Array.ConvertAll(arrayLambda, converterLambda));
}


public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Array> ArrayValue, IObservable<System.Array> array, IObservable<System.Int32> index)
{
    return ObservableExt.ZipExecute(ArrayValue, array, index, (ArrayValueLambda, arrayLambda, indexLambda) => ArrayValueLambda.CopyTo(arrayLambda, indexLambda));
}


public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Array> ArrayValue, IObservable<System.Array> array, IObservable<System.Int64> index)
{
    return ObservableExt.ZipExecute(ArrayValue, array, index, (ArrayValueLambda, arrayLambda, indexLambda) => ArrayValueLambda.CopyTo(arrayLambda, indexLambda));
}


public static IObservable<T[]> Empty<T>()
{
    return ObservableExt.Factory(() => System.Array.Empty());
}


public static IObservable<System.Boolean> Exists<T>(IObservable<T[]> array, IObservable<Predicate<T>> match)
{
    return Observable.Zip(array, match, (arrayLambda, matchLambda) => System.Array.Exists(arrayLambda, matchLambda));
}


public static IObservable<T> Find<T>(IObservable<T[]> array, IObservable<Predicate<T>> match)
{
    return Observable.Zip(array, match, (arrayLambda, matchLambda) => System.Array.Find(arrayLambda, matchLambda));
}


public static IObservable<T[]> FindAll<T>(IObservable<T[]> array, IObservable<Predicate<T>> match)
{
    return Observable.Zip(array, match, (arrayLambda, matchLambda) => System.Array.FindAll(arrayLambda, matchLambda));
}


public static IObservable<System.Int32> FindIndex<T>(IObservable<T[]> array, IObservable<Predicate<T>> match)
{
    return Observable.Zip(array, match, (arrayLambda, matchLambda) => System.Array.FindIndex(arrayLambda, matchLambda));
}


public static IObservable<System.Int32> FindIndex<T>(IObservable<T[]> array, IObservable<System.Int32> startIndex, IObservable<Predicate<T>> match)
{
    return Observable.Zip(array, startIndex, match, (arrayLambda, startIndexLambda, matchLambda) => System.Array.FindIndex(arrayLambda, startIndexLambda, matchLambda));
}


public static IObservable<System.Int32> FindIndex<T>(IObservable<T[]> array, IObservable<System.Int32> startIndex, IObservable<System.Int32> count, IObservable<Predicate<T>> match)
{
    return Observable.Zip(array, startIndex, count, match, (arrayLambda, startIndexLambda, countLambda, matchLambda) => System.Array.FindIndex(arrayLambda, startIndexLambda, countLambda, matchLambda));
}


public static IObservable<T> FindLast<T>(IObservable<T[]> array, IObservable<Predicate<T>> match)
{
    return Observable.Zip(array, match, (arrayLambda, matchLambda) => System.Array.FindLast(arrayLambda, matchLambda));
}


public static IObservable<System.Int32> FindLastIndex<T>(IObservable<T[]> array, IObservable<Predicate<T>> match)
{
    return Observable.Zip(array, match, (arrayLambda, matchLambda) => System.Array.FindLastIndex(arrayLambda, matchLambda));
}


public static IObservable<System.Int32> FindLastIndex<T>(IObservable<T[]> array, IObservable<System.Int32> startIndex, IObservable<Predicate<T>> match)
{
    return Observable.Zip(array, startIndex, match, (arrayLambda, startIndexLambda, matchLambda) => System.Array.FindLastIndex(arrayLambda, startIndexLambda, matchLambda));
}


public static IObservable<System.Int32> FindLastIndex<T>(IObservable<T[]> array, IObservable<System.Int32> startIndex, IObservable<System.Int32> count, IObservable<Predicate<T>> match)
{
    return Observable.Zip(array, startIndex, count, match, (arrayLambda, startIndexLambda, countLambda, matchLambda) => System.Array.FindLastIndex(arrayLambda, startIndexLambda, countLambda, matchLambda));
}


public static IObservable<System.Reactive.Unit> ForEach<T>(IObservable<T[]> array, IObservable<Action<T>> action)
{
    return ObservableExt.ZipExecute(array, action, (arrayLambda, actionLambda) => System.Array.ForEach(arrayLambda, actionLambda));
}


public static IObservable<System.Collections.IEnumerator> GetEnumerator(this IObservable<System.Array> ArrayValue)
{
    return Observable.Select(ArrayValue, (ArrayValueLambda) => ArrayValueLambda.GetEnumerator());
}


public static IObservable<System.Int32> IndexOf(IObservable<System.Array> array, IObservable<System.Object> value)
{
    return Observable.Zip(array, value, (arrayLambda, valueLambda) => System.Array.IndexOf(arrayLambda, valueLambda));
}


public static IObservable<System.Int32> IndexOf(IObservable<System.Array> array, IObservable<System.Object> value, IObservable<System.Int32> startIndex)
{
    return Observable.Zip(array, value, startIndex, (arrayLambda, valueLambda, startIndexLambda) => System.Array.IndexOf(arrayLambda, valueLambda, startIndexLambda));
}


public static IObservable<System.Int32> IndexOf(IObservable<System.Array> array, IObservable<System.Object> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(array, value, startIndex, count, (arrayLambda, valueLambda, startIndexLambda, countLambda) => System.Array.IndexOf(arrayLambda, valueLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Int32> IndexOf<T>(IObservable<T[]> array, IObservable<T> value)
{
    return Observable.Zip(array, value, (arrayLambda, valueLambda) => System.Array.IndexOf(arrayLambda, valueLambda));
}


public static IObservable<System.Int32> IndexOf<T>(IObservable<T[]> array, IObservable<T> value, IObservable<System.Int32> startIndex)
{
    return Observable.Zip(array, value, startIndex, (arrayLambda, valueLambda, startIndexLambda) => System.Array.IndexOf(arrayLambda, valueLambda, startIndexLambda));
}


public static IObservable<System.Int32> IndexOf<T>(IObservable<T[]> array, IObservable<T> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(array, value, startIndex, count, (arrayLambda, valueLambda, startIndexLambda, countLambda) => System.Array.IndexOf(arrayLambda, valueLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Int32> LastIndexOf(IObservable<System.Array> array, IObservable<System.Object> value)
{
    return Observable.Zip(array, value, (arrayLambda, valueLambda) => System.Array.LastIndexOf(arrayLambda, valueLambda));
}


public static IObservable<System.Int32> LastIndexOf(IObservable<System.Array> array, IObservable<System.Object> value, IObservable<System.Int32> startIndex)
{
    return Observable.Zip(array, value, startIndex, (arrayLambda, valueLambda, startIndexLambda) => System.Array.LastIndexOf(arrayLambda, valueLambda, startIndexLambda));
}


public static IObservable<System.Int32> LastIndexOf(IObservable<System.Array> array, IObservable<System.Object> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(array, value, startIndex, count, (arrayLambda, valueLambda, startIndexLambda, countLambda) => System.Array.LastIndexOf(arrayLambda, valueLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Int32> LastIndexOf<T>(IObservable<T[]> array, IObservable<T> value)
{
    return Observable.Zip(array, value, (arrayLambda, valueLambda) => System.Array.LastIndexOf(arrayLambda, valueLambda));
}


public static IObservable<System.Int32> LastIndexOf<T>(IObservable<T[]> array, IObservable<T> value, IObservable<System.Int32> startIndex)
{
    return Observable.Zip(array, value, startIndex, (arrayLambda, valueLambda, startIndexLambda) => System.Array.LastIndexOf(arrayLambda, valueLambda, startIndexLambda));
}


public static IObservable<System.Int32> LastIndexOf<T>(IObservable<T[]> array, IObservable<T> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(array, value, startIndex, count, (arrayLambda, valueLambda, startIndexLambda, countLambda) => System.Array.LastIndexOf(arrayLambda, valueLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Reactive.Unit> Reverse(IObservable<System.Array> array)
{
    return Observable.Do(array, (arrayLambda) => System.Array.Reverse(arrayLambda)).ToUnit();
}


public static IObservable<System.Reactive.Unit> Reverse(IObservable<System.Array> array, IObservable<System.Int32> index, IObservable<System.Int32> length)
{
    return ObservableExt.ZipExecute(array, index, length, (arrayLambda, indexLambda, lengthLambda) => System.Array.Reverse(arrayLambda, indexLambda, lengthLambda));
}


public static IObservable<System.Reactive.Unit> Sort(IObservable<System.Array> array)
{
    return Observable.Do(array, (arrayLambda) => System.Array.Sort(arrayLambda)).ToUnit();
}


public static IObservable<System.Reactive.Unit> Sort(IObservable<System.Array> keys, IObservable<System.Array> items)
{
    return ObservableExt.ZipExecute(keys, items, (keysLambda, itemsLambda) => System.Array.Sort(keysLambda, itemsLambda));
}


public static IObservable<System.Reactive.Unit> Sort(IObservable<System.Array> array, IObservable<System.Int32> index, IObservable<System.Int32> length)
{
    return ObservableExt.ZipExecute(array, index, length, (arrayLambda, indexLambda, lengthLambda) => System.Array.Sort(arrayLambda, indexLambda, lengthLambda));
}


public static IObservable<System.Reactive.Unit> Sort(IObservable<System.Array> keys, IObservable<System.Array> items, IObservable<System.Int32> index, IObservable<System.Int32> length)
{
    return ObservableExt.ZipExecute(keys, items, index, length, (keysLambda, itemsLambda, indexLambda, lengthLambda) => System.Array.Sort(keysLambda, itemsLambda, indexLambda, lengthLambda));
}


public static IObservable<System.Reactive.Unit> Sort(IObservable<System.Array> array, IObservable<System.Collections.IComparer> comparer)
{
    return ObservableExt.ZipExecute(array, comparer, (arrayLambda, comparerLambda) => System.Array.Sort(arrayLambda, comparerLambda));
}


public static IObservable<System.Reactive.Unit> Sort(IObservable<System.Array> keys, IObservable<System.Array> items, IObservable<System.Collections.IComparer> comparer)
{
    return ObservableExt.ZipExecute(keys, items, comparer, (keysLambda, itemsLambda, comparerLambda) => System.Array.Sort(keysLambda, itemsLambda, comparerLambda));
}


public static IObservable<System.Reactive.Unit> Sort(IObservable<System.Array> array, IObservable<System.Int32> index, IObservable<System.Int32> length, IObservable<System.Collections.IComparer> comparer)
{
    return ObservableExt.ZipExecute(array, index, length, comparer, (arrayLambda, indexLambda, lengthLambda, comparerLambda) => System.Array.Sort(arrayLambda, indexLambda, lengthLambda, comparerLambda));
}


public static IObservable<System.Reactive.Unit> Sort(IObservable<System.Array> keys, IObservable<System.Array> items, IObservable<System.Int32> index, IObservable<System.Int32> length, IObservable<System.Collections.IComparer> comparer)
{
    return ObservableExt.ZipExecute(keys, items, index, length, comparer, (keysLambda, itemsLambda, indexLambda, lengthLambda, comparerLambda) => System.Array.Sort(keysLambda, itemsLambda, indexLambda, lengthLambda, comparerLambda));
}


public static IObservable<System.Reactive.Unit> Sort<T>(IObservable<T[]> array)
{
    return Observable.Do(array, (arrayLambda) => System.Array.Sort(arrayLambda)).ToUnit();
}


public static IObservable<System.Reactive.Unit> Sort<TKey, TValue>(IObservable<TKey[]> keys, IObservable<TValue[]> items)
{
    return ObservableExt.ZipExecute(keys, items, (keysLambda, itemsLambda) => System.Array.Sort(keysLambda, itemsLambda));
}


public static IObservable<System.Reactive.Unit> Sort<T>(IObservable<T[]> array, IObservable<System.Int32> index, IObservable<System.Int32> length)
{
    return ObservableExt.ZipExecute(array, index, length, (arrayLambda, indexLambda, lengthLambda) => System.Array.Sort(arrayLambda, indexLambda, lengthLambda));
}


public static IObservable<System.Reactive.Unit> Sort<TKey, TValue>(IObservable<TKey[]> keys, IObservable<TValue[]> items, IObservable<System.Int32> index, IObservable<System.Int32> length)
{
    return ObservableExt.ZipExecute(keys, items, index, length, (keysLambda, itemsLambda, indexLambda, lengthLambda) => System.Array.Sort(keysLambda, itemsLambda, indexLambda, lengthLambda));
}


public static IObservable<System.Reactive.Unit> Sort<T>(IObservable<T[]> array, IObservable<IComparer<T>> comparer)
{
    return ObservableExt.ZipExecute(array, comparer, (arrayLambda, comparerLambda) => System.Array.Sort(arrayLambda, comparerLambda));
}


public static IObservable<System.Reactive.Unit> Sort<TKey, TValue>(IObservable<TKey[]> keys, IObservable<TValue[]> items, IObservable<IComparer<TKey>> comparer)
{
    return ObservableExt.ZipExecute(keys, items, comparer, (keysLambda, itemsLambda, comparerLambda) => System.Array.Sort(keysLambda, itemsLambda, comparerLambda));
}


public static IObservable<System.Reactive.Unit> Sort<T>(IObservable<T[]> array, IObservable<System.Int32> index, IObservable<System.Int32> length, IObservable<IComparer<T>> comparer)
{
    return ObservableExt.ZipExecute(array, index, length, comparer, (arrayLambda, indexLambda, lengthLambda, comparerLambda) => System.Array.Sort(arrayLambda, indexLambda, lengthLambda, comparerLambda));
}


public static IObservable<System.Reactive.Unit> Sort<TKey, TValue>(IObservable<TKey[]> keys, IObservable<TValue[]> items, IObservable<System.Int32> index, IObservable<System.Int32> length, IObservable<IComparer<TKey>> comparer)
{
    return ObservableExt.ZipExecute(keys, items, index, length, comparer, (keysLambda, itemsLambda, indexLambda, lengthLambda, comparerLambda) => System.Array.Sort(keysLambda, itemsLambda, indexLambda, lengthLambda, comparerLambda));
}


public static IObservable<System.Reactive.Unit> Sort<T>(IObservable<T[]> array, IObservable<Comparison<T>> comparison)
{
    return ObservableExt.ZipExecute(array, comparison, (arrayLambda, comparisonLambda) => System.Array.Sort(arrayLambda, comparisonLambda));
}


public static IObservable<System.Boolean> TrueForAll<T>(IObservable<T[]> array, IObservable<Predicate<T>> match)
{
    return Observable.Zip(array, match, (arrayLambda, matchLambda) => System.Array.TrueForAll(arrayLambda, matchLambda));
}


public static IObservable<System.Reactive.Unit> Initialize(this IObservable<System.Array> ArrayValue)
{
    return Observable.Do(ArrayValue, (ArrayValueLambda) => ArrayValueLambda.Initialize()).ToUnit();
}


public static IObservable<System.Int32> get_Length(this IObservable<System.Array> ArrayValue)
{
    return Observable.Select(ArrayValue, (ArrayValueLambda) => ArrayValueLambda.Length);
}


public static IObservable<System.Int64> get_LongLength(this IObservable<System.Array> ArrayValue)
{
    return Observable.Select(ArrayValue, (ArrayValueLambda) => ArrayValueLambda.LongLength);
}


public static IObservable<System.Int32> get_Rank(this IObservable<System.Array> ArrayValue)
{
    return Observable.Select(ArrayValue, (ArrayValueLambda) => ArrayValueLambda.Rank);
}


public static IObservable<System.Object> get_SyncRoot(this IObservable<System.Array> ArrayValue)
{
    return Observable.Select(ArrayValue, (ArrayValueLambda) => ArrayValueLambda.SyncRoot);
}


public static IObservable<System.Boolean> get_IsReadOnly(this IObservable<System.Array> ArrayValue)
{
    return Observable.Select(ArrayValue, (ArrayValueLambda) => ArrayValueLambda.IsReadOnly);
}


public static IObservable<System.Boolean> get_IsFixedSize(this IObservable<System.Array> ArrayValue)
{
    return Observable.Select(ArrayValue, (ArrayValueLambda) => ArrayValueLambda.IsFixedSize);
}


public static IObservable<System.Boolean> get_IsSynchronized(this IObservable<System.Array> ArrayValue)
{
    return Observable.Select(ArrayValue, (ArrayValueLambda) => ArrayValueLambda.IsSynchronized);
}

}
}