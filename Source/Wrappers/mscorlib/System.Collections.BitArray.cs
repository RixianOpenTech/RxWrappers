using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
public static class _BitArray
{
    
public static IObservable<System.Boolean> Get(this IObservable<System.Collections.BitArray> BitArrayValue, IObservable<System.Int32> index)
{
    return Observable.Zip(BitArrayValue, index, (BitArrayValueLambda, indexLambda) => BitArrayValueLambda.Get(indexLambda));
}


public static IObservable<System.Reactive.Unit> Set(this IObservable<System.Collections.BitArray> BitArrayValue, IObservable<System.Int32> index, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(BitArrayValue, index, value, (BitArrayValueLambda, indexLambda, valueLambda) => BitArrayValueLambda.Set(indexLambda, valueLambda));
}


public static IObservable<System.Reactive.Unit> SetAll(this IObservable<System.Collections.BitArray> BitArrayValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(BitArrayValue, value, (BitArrayValueLambda, valueLambda) => BitArrayValueLambda.SetAll(valueLambda));
}


public static IObservable<System.Collections.BitArray> And(this IObservable<System.Collections.BitArray> BitArrayValue, IObservable<System.Collections.BitArray> value)
{
    return Observable.Zip(BitArrayValue, value, (BitArrayValueLambda, valueLambda) => BitArrayValueLambda.And(valueLambda));
}


public static IObservable<System.Collections.BitArray> Or(this IObservable<System.Collections.BitArray> BitArrayValue, IObservable<System.Collections.BitArray> value)
{
    return Observable.Zip(BitArrayValue, value, (BitArrayValueLambda, valueLambda) => BitArrayValueLambda.Or(valueLambda));
}


public static IObservable<System.Collections.BitArray> Xor(this IObservable<System.Collections.BitArray> BitArrayValue, IObservable<System.Collections.BitArray> value)
{
    return Observable.Zip(BitArrayValue, value, (BitArrayValueLambda, valueLambda) => BitArrayValueLambda.Xor(valueLambda));
}


public static IObservable<System.Collections.BitArray> Not(this IObservable<System.Collections.BitArray> BitArrayValue)
{
    return Observable.Select(BitArrayValue, (BitArrayValueLambda) => BitArrayValueLambda.Not());
}


public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Collections.BitArray> BitArrayValue, IObservable<System.Array> array, IObservable<System.Int32> index)
{
    return ObservableExt.ZipExecute(BitArrayValue, array, index, (BitArrayValueLambda, arrayLambda, indexLambda) => BitArrayValueLambda.CopyTo(arrayLambda, indexLambda));
}


public static IObservable<System.Object> Clone(this IObservable<System.Collections.BitArray> BitArrayValue)
{
    return Observable.Select(BitArrayValue, (BitArrayValueLambda) => BitArrayValueLambda.Clone());
}


public static IObservable<System.Collections.IEnumerator> GetEnumerator(this IObservable<System.Collections.BitArray> BitArrayValue)
{
    return Observable.Select(BitArrayValue, (BitArrayValueLambda) => BitArrayValueLambda.GetEnumerator());
}


public static IObservable<System.Boolean> get_Item(this IObservable<System.Collections.BitArray> BitArrayValue, IObservable<System.Int32> index)
{
    return Observable.Zip(BitArrayValue, index, (BitArrayValueLambda, indexLambda) => BitArrayValueLambda.Item);
}


public static IObservable<System.Int32> get_Length(this IObservable<System.Collections.BitArray> BitArrayValue)
{
    return Observable.Select(BitArrayValue, (BitArrayValueLambda) => BitArrayValueLambda.Length);
}


public static IObservable<System.Int32> get_Count(this IObservable<System.Collections.BitArray> BitArrayValue)
{
    return Observable.Select(BitArrayValue, (BitArrayValueLambda) => BitArrayValueLambda.Count);
}


public static IObservable<System.Object> get_SyncRoot(this IObservable<System.Collections.BitArray> BitArrayValue)
{
    return Observable.Select(BitArrayValue, (BitArrayValueLambda) => BitArrayValueLambda.SyncRoot);
}


public static IObservable<System.Boolean> get_IsReadOnly(this IObservable<System.Collections.BitArray> BitArrayValue)
{
    return Observable.Select(BitArrayValue, (BitArrayValueLambda) => BitArrayValueLambda.IsReadOnly);
}


public static IObservable<System.Boolean> get_IsSynchronized(this IObservable<System.Collections.BitArray> BitArrayValue)
{
    return Observable.Select(BitArrayValue, (BitArrayValueLambda) => BitArrayValueLambda.IsSynchronized);
}


public static IObservable<System.Reactive.Unit> set_Item(this IObservable<System.Collections.BitArray> BitArrayValue, IObservable<System.Int32> index, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(BitArrayValue, index, value, (BitArrayValueLambda, indexLambda, valueLambda) => BitArrayValueLambda.Item = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Length(this IObservable<System.Collections.BitArray> BitArrayValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(BitArrayValue, value, (BitArrayValueLambda, valueLambda) => BitArrayValueLambda.Length = valueLambda);
}

}
}