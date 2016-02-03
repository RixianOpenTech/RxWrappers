using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _Boolean
{
    
public static IObservable<System.Int32> GetHashCode(this IObservable<System.Boolean> BooleanValue)
{
    return Observable.Select(BooleanValue, (BooleanValueLambda) => BooleanValueLambda.GetHashCode());
}


public static IObservable<System.String> ToString(this IObservable<System.Boolean> BooleanValue)
{
    return Observable.Select(BooleanValue, (BooleanValueLambda) => BooleanValueLambda.ToString());
}


public static IObservable<System.String> ToString(this IObservable<System.Boolean> BooleanValue, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(BooleanValue, provider, (BooleanValueLambda, providerLambda) => BooleanValueLambda.ToString(providerLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Boolean> BooleanValue, IObservable<System.Object> obj)
{
    return Observable.Zip(BooleanValue, obj, (BooleanValueLambda, objLambda) => BooleanValueLambda.Equals(objLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Boolean> BooleanValue, IObservable<System.Boolean> obj)
{
    return Observable.Zip(BooleanValue, obj, (BooleanValueLambda, objLambda) => BooleanValueLambda.Equals(objLambda));
}


public static IObservable<System.Int32> CompareTo(this IObservable<System.Boolean> BooleanValue, IObservable<System.Object> obj)
{
    return Observable.Zip(BooleanValue, obj, (BooleanValueLambda, objLambda) => BooleanValueLambda.CompareTo(objLambda));
}


public static IObservable<System.Int32> CompareTo(this IObservable<System.Boolean> BooleanValue, IObservable<System.Boolean> value)
{
    return Observable.Zip(BooleanValue, value, (BooleanValueLambda, valueLambda) => BooleanValueLambda.CompareTo(valueLambda));
}


public static IObservable<System.Boolean> Parse(IObservable<System.String> value)
{
    return Observable.Select(value, (valueLambda) => System.Boolean.Parse(valueLambda));
}


public static IObservable<Tuple<System.Boolean, System.Boolean>> TryParse(IObservable<System.String> value)
{
    return Observable.Select(value, (valueLambda) => {
System.Boolean resultOutput = default(System.Boolean);
var result = System.Boolean.TryParse(valueLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<System.TypeCode> GetTypeCode(this IObservable<System.Boolean> BooleanValue)
{
    return Observable.Select(BooleanValue, (BooleanValueLambda) => BooleanValueLambda.GetTypeCode());
}

}
}