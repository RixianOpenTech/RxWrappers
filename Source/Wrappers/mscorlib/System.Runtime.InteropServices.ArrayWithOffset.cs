using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _ArrayWithOffset
{
    
public static IObservable<System.Object> GetArray(this IObservable<System.Runtime.InteropServices.ArrayWithOffset> ArrayWithOffsetValue)
{
    return Observable.Select(ArrayWithOffsetValue, (ArrayWithOffsetValueLambda) => ArrayWithOffsetValueLambda.GetArray());
}


public static IObservable<System.Int32> GetOffset(this IObservable<System.Runtime.InteropServices.ArrayWithOffset> ArrayWithOffsetValue)
{
    return Observable.Select(ArrayWithOffsetValue, (ArrayWithOffsetValueLambda) => ArrayWithOffsetValueLambda.GetOffset());
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Runtime.InteropServices.ArrayWithOffset> ArrayWithOffsetValue)
{
    return Observable.Select(ArrayWithOffsetValue, (ArrayWithOffsetValueLambda) => ArrayWithOffsetValueLambda.GetHashCode());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Runtime.InteropServices.ArrayWithOffset> ArrayWithOffsetValue, IObservable<System.Object> obj)
{
    return Observable.Zip(ArrayWithOffsetValue, obj, (ArrayWithOffsetValueLambda, objLambda) => ArrayWithOffsetValueLambda.Equals(objLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Runtime.InteropServices.ArrayWithOffset> ArrayWithOffsetValue, IObservable<System.Runtime.InteropServices.ArrayWithOffset> obj)
{
    return Observable.Zip(ArrayWithOffsetValue, obj, (ArrayWithOffsetValueLambda, objLambda) => ArrayWithOffsetValueLambda.Equals(objLambda));
}

}
}