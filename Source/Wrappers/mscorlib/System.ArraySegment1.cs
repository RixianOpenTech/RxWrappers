using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _ArraySegment1
{
    
public static IObservable<System.Int32> GetHashCode<T>(this IObservable<System.ArraySegment<T>> ArraySegmentValue)
{
    return Observable.Select(ArraySegmentValue, (ArraySegmentValueLambda) => ArraySegmentValueLambda.GetHashCode());
}


public static IObservable<System.Boolean> Equals<T>(this IObservable<System.ArraySegment<T>> ArraySegmentValue, IObservable<System.Object> obj)
{
    return Observable.Zip(ArraySegmentValue, obj, (ArraySegmentValueLambda, objLambda) => ArraySegmentValueLambda.Equals(objLambda));
}


public static IObservable<System.Boolean> Equals<T>(this IObservable<System.ArraySegment<T>> ArraySegmentValue, IObservable<System.ArraySegment<T>> obj)
{
    return Observable.Zip(ArraySegmentValue, obj, (ArraySegmentValueLambda, objLambda) => ArraySegmentValueLambda.Equals(objLambda));
}


public static IObservable<T[]> get_Array<T>(this IObservable<System.ArraySegment<T>> ArraySegmentValue)
{
    return Observable.Select(ArraySegmentValue, (ArraySegmentValueLambda) => ArraySegmentValueLambda.Array);
}


public static IObservable<System.Int32> get_Offset<T>(this IObservable<System.ArraySegment<T>> ArraySegmentValue)
{
    return Observable.Select(ArraySegmentValue, (ArraySegmentValueLambda) => ArraySegmentValueLambda.Offset);
}


public static IObservable<System.Int32> get_Count<T>(this IObservable<System.ArraySegment<T>> ArraySegmentValue)
{
    return Observable.Select(ArraySegmentValue, (ArraySegmentValueLambda) => ArraySegmentValueLambda.Count);
}

}
}