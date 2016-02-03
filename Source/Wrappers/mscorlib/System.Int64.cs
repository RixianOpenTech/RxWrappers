using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _Int64
{
    
public static IObservable<System.Int32> CompareTo(this IObservable<System.Int64> Int64Value, IObservable<System.Object> value)
{
    return Observable.Zip(Int64Value, value, (Int64ValueLambda, valueLambda) => Int64ValueLambda.CompareTo(valueLambda));
}


public static IObservable<System.Int32> CompareTo(this IObservable<System.Int64> Int64Value, IObservable<System.Int64> value)
{
    return Observable.Zip(Int64Value, value, (Int64ValueLambda, valueLambda) => Int64ValueLambda.CompareTo(valueLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Int64> Int64Value, IObservable<System.Object> obj)
{
    return Observable.Zip(Int64Value, obj, (Int64ValueLambda, objLambda) => Int64ValueLambda.Equals(objLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Int64> Int64Value, IObservable<System.Int64> obj)
{
    return Observable.Zip(Int64Value, obj, (Int64ValueLambda, objLambda) => Int64ValueLambda.Equals(objLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Int64> Int64Value)
{
    return Observable.Select(Int64Value, (Int64ValueLambda) => Int64ValueLambda.GetHashCode());
}


public static IObservable<System.String> ToString(this IObservable<System.Int64> Int64Value)
{
    return Observable.Select(Int64Value, (Int64ValueLambda) => Int64ValueLambda.ToString());
}


public static IObservable<System.String> ToString(this IObservable<System.Int64> Int64Value, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(Int64Value, provider, (Int64ValueLambda, providerLambda) => Int64ValueLambda.ToString(providerLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.Int64> Int64Value, IObservable<System.String> format)
{
    return Observable.Zip(Int64Value, format, (Int64ValueLambda, formatLambda) => Int64ValueLambda.ToString(formatLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.Int64> Int64Value, IObservable<System.String> format, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(Int64Value, format, provider, (Int64ValueLambda, formatLambda, providerLambda) => Int64ValueLambda.ToString(formatLambda, providerLambda));
}


public static IObservable<System.Int64> Parse(IObservable<System.String> s)
{
    return Observable.Select(s, (sLambda) => System.Int64.Parse(sLambda));
}


public static IObservable<System.Int64> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style)
{
    return Observable.Zip(s, style, (sLambda, styleLambda) => System.Int64.Parse(sLambda, styleLambda));
}


public static IObservable<System.Int64> Parse(IObservable<System.String> s, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(s, provider, (sLambda, providerLambda) => System.Int64.Parse(sLambda, providerLambda));
}


public static IObservable<System.Int64> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => System.Int64.Parse(sLambda, styleLambda, providerLambda));
}


public static IObservable<Tuple<System.Boolean, System.Int64>> TryParse(IObservable<System.String> s)
{
    return Observable.Select(s, (sLambda) => {
System.Int64 resultOutput = default(System.Int64);
var result = System.Int64.TryParse(sLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<Tuple<System.Boolean, System.Int64>> TryParse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => {
System.Int64 resultOutput = default(System.Int64);
var result = System.Int64.TryParse(sLambda, styleLambda, providerLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<System.TypeCode> GetTypeCode(this IObservable<System.Int64> Int64Value)
{
    return Observable.Select(Int64Value, (Int64ValueLambda) => Int64ValueLambda.GetTypeCode());
}

}
}