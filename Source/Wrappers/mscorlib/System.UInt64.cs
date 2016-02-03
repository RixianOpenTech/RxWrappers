using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _UInt64
{
    
public static IObservable<System.Int32> CompareTo(this IObservable<System.UInt64> UInt64Value, IObservable<System.Object> value)
{
    return Observable.Zip(UInt64Value, value, (UInt64ValueLambda, valueLambda) => UInt64ValueLambda.CompareTo(valueLambda));
}


public static IObservable<System.Int32> CompareTo(this IObservable<System.UInt64> UInt64Value, IObservable<System.UInt64> value)
{
    return Observable.Zip(UInt64Value, value, (UInt64ValueLambda, valueLambda) => UInt64ValueLambda.CompareTo(valueLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.UInt64> UInt64Value, IObservable<System.Object> obj)
{
    return Observable.Zip(UInt64Value, obj, (UInt64ValueLambda, objLambda) => UInt64ValueLambda.Equals(objLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.UInt64> UInt64Value, IObservable<System.UInt64> obj)
{
    return Observable.Zip(UInt64Value, obj, (UInt64ValueLambda, objLambda) => UInt64ValueLambda.Equals(objLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.UInt64> UInt64Value)
{
    return Observable.Select(UInt64Value, (UInt64ValueLambda) => UInt64ValueLambda.GetHashCode());
}


public static IObservable<System.String> ToString(this IObservable<System.UInt64> UInt64Value)
{
    return Observable.Select(UInt64Value, (UInt64ValueLambda) => UInt64ValueLambda.ToString());
}


public static IObservable<System.String> ToString(this IObservable<System.UInt64> UInt64Value, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(UInt64Value, provider, (UInt64ValueLambda, providerLambda) => UInt64ValueLambda.ToString(providerLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.UInt64> UInt64Value, IObservable<System.String> format)
{
    return Observable.Zip(UInt64Value, format, (UInt64ValueLambda, formatLambda) => UInt64ValueLambda.ToString(formatLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.UInt64> UInt64Value, IObservable<System.String> format, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(UInt64Value, format, provider, (UInt64ValueLambda, formatLambda, providerLambda) => UInt64ValueLambda.ToString(formatLambda, providerLambda));
}


public static IObservable<System.UInt64> Parse(IObservable<System.String> s)
{
    return Observable.Select(s, (sLambda) => System.UInt64.Parse(sLambda));
}


public static IObservable<System.UInt64> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style)
{
    return Observable.Zip(s, style, (sLambda, styleLambda) => System.UInt64.Parse(sLambda, styleLambda));
}


public static IObservable<System.UInt64> Parse(IObservable<System.String> s, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(s, provider, (sLambda, providerLambda) => System.UInt64.Parse(sLambda, providerLambda));
}


public static IObservable<System.UInt64> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => System.UInt64.Parse(sLambda, styleLambda, providerLambda));
}


public static IObservable<Tuple<System.Boolean, System.UInt64>> TryParse(IObservable<System.String> s)
{
    return Observable.Select(s, (sLambda) => {
System.UInt64 resultOutput = default(System.UInt64);
var result = System.UInt64.TryParse(sLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<Tuple<System.Boolean, System.UInt64>> TryParse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => {
System.UInt64 resultOutput = default(System.UInt64);
var result = System.UInt64.TryParse(sLambda, styleLambda, providerLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<System.TypeCode> GetTypeCode(this IObservable<System.UInt64> UInt64Value)
{
    return Observable.Select(UInt64Value, (UInt64ValueLambda) => UInt64ValueLambda.GetTypeCode());
}

}
}