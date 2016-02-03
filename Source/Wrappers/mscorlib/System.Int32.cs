using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _Int32
{
    
public static IObservable<System.Int32> CompareTo(this IObservable<System.Int32> Int32Value, IObservable<System.Object> value)
{
    return Observable.Zip(Int32Value, value, (Int32ValueLambda, valueLambda) => Int32ValueLambda.CompareTo(valueLambda));
}


public static IObservable<System.Int32> CompareTo(this IObservable<System.Int32> Int32Value, IObservable<System.Int32> value)
{
    return Observable.Zip(Int32Value, value, (Int32ValueLambda, valueLambda) => Int32ValueLambda.CompareTo(valueLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Int32> Int32Value, IObservable<System.Object> obj)
{
    return Observable.Zip(Int32Value, obj, (Int32ValueLambda, objLambda) => Int32ValueLambda.Equals(objLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Int32> Int32Value, IObservable<System.Int32> obj)
{
    return Observable.Zip(Int32Value, obj, (Int32ValueLambda, objLambda) => Int32ValueLambda.Equals(objLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Int32> Int32Value)
{
    return Observable.Select(Int32Value, (Int32ValueLambda) => Int32ValueLambda.GetHashCode());
}


public static IObservable<System.String> ToString(this IObservable<System.Int32> Int32Value)
{
    return Observable.Select(Int32Value, (Int32ValueLambda) => Int32ValueLambda.ToString());
}


public static IObservable<System.String> ToString(this IObservable<System.Int32> Int32Value, IObservable<System.String> format)
{
    return Observable.Zip(Int32Value, format, (Int32ValueLambda, formatLambda) => Int32ValueLambda.ToString(formatLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.Int32> Int32Value, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(Int32Value, provider, (Int32ValueLambda, providerLambda) => Int32ValueLambda.ToString(providerLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.Int32> Int32Value, IObservable<System.String> format, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(Int32Value, format, provider, (Int32ValueLambda, formatLambda, providerLambda) => Int32ValueLambda.ToString(formatLambda, providerLambda));
}


public static IObservable<System.Int32> Parse(IObservable<System.String> s)
{
    return Observable.Select(s, (sLambda) => System.Int32.Parse(sLambda));
}


public static IObservable<System.Int32> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style)
{
    return Observable.Zip(s, style, (sLambda, styleLambda) => System.Int32.Parse(sLambda, styleLambda));
}


public static IObservable<System.Int32> Parse(IObservable<System.String> s, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(s, provider, (sLambda, providerLambda) => System.Int32.Parse(sLambda, providerLambda));
}


public static IObservable<System.Int32> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => System.Int32.Parse(sLambda, styleLambda, providerLambda));
}


public static IObservable<Tuple<System.Boolean, System.Int32>> TryParse(IObservable<System.String> s)
{
    return Observable.Select(s, (sLambda) => {
System.Int32 resultOutput = default(System.Int32);
var result = System.Int32.TryParse(sLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<Tuple<System.Boolean, System.Int32>> TryParse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => {
System.Int32 resultOutput = default(System.Int32);
var result = System.Int32.TryParse(sLambda, styleLambda, providerLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<System.TypeCode> GetTypeCode(this IObservable<System.Int32> Int32Value)
{
    return Observable.Select(Int32Value, (Int32ValueLambda) => Int32ValueLambda.GetTypeCode());
}

}
}