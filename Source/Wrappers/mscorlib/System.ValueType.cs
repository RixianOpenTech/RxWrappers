using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _ValueType
{
    
public static IObservable<System.Boolean> Equals(this IObservable<System.ValueType> ValueTypeValue, IObservable<System.Object> obj)
{
    return Observable.Zip(ValueTypeValue, obj, (ValueTypeValueLambda, objLambda) => ValueTypeValueLambda.Equals(objLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.ValueType> ValueTypeValue)
{
    return Observable.Select(ValueTypeValue, (ValueTypeValueLambda) => ValueTypeValueLambda.GetHashCode());
}


public static IObservable<System.String> ToString(this IObservable<System.ValueType> ValueTypeValue)
{
    return Observable.Select(ValueTypeValue, (ValueTypeValueLambda) => ValueTypeValueLambda.ToString());
}

}
}