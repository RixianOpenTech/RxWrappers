using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _Byte
{
    
public static IObservable<System.Int32> CompareTo(this IObservable<System.Byte> ByteValue, IObservable<System.Object> value)
{
    return Observable.Zip(ByteValue, value, (ByteValueLambda, valueLambda) => ByteValueLambda.CompareTo(valueLambda));
}


public static IObservable<System.Int32> CompareTo(this IObservable<System.Byte> ByteValue, IObservable<System.Byte> value)
{
    return Observable.Zip(ByteValue, value, (ByteValueLambda, valueLambda) => ByteValueLambda.CompareTo(valueLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Byte> ByteValue, IObservable<System.Object> obj)
{
    return Observable.Zip(ByteValue, obj, (ByteValueLambda, objLambda) => ByteValueLambda.Equals(objLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Byte> ByteValue, IObservable<System.Byte> obj)
{
    return Observable.Zip(ByteValue, obj, (ByteValueLambda, objLambda) => ByteValueLambda.Equals(objLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Byte> ByteValue)
{
    return Observable.Select(ByteValue, (ByteValueLambda) => ByteValueLambda.GetHashCode());
}


public static IObservable<System.Byte> Parse(IObservable<System.String> s)
{
    return Observable.Select(s, (sLambda) => System.Byte.Parse(sLambda));
}


public static IObservable<System.Byte> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style)
{
    return Observable.Zip(s, style, (sLambda, styleLambda) => System.Byte.Parse(sLambda, styleLambda));
}


public static IObservable<System.Byte> Parse(IObservable<System.String> s, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(s, provider, (sLambda, providerLambda) => System.Byte.Parse(sLambda, providerLambda));
}


public static IObservable<System.Byte> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => System.Byte.Parse(sLambda, styleLambda, providerLambda));
}


public static IObservable<Tuple<System.Boolean, System.Byte>> TryParse(IObservable<System.String> s)
{
    return Observable.Select(s, (sLambda) => {
System.Byte resultOutput = default(System.Byte);
var result = System.Byte.TryParse(sLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<Tuple<System.Boolean, System.Byte>> TryParse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => {
System.Byte resultOutput = default(System.Byte);
var result = System.Byte.TryParse(sLambda, styleLambda, providerLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<System.String> ToString(this IObservable<System.Byte> ByteValue)
{
    return Observable.Select(ByteValue, (ByteValueLambda) => ByteValueLambda.ToString());
}


public static IObservable<System.String> ToString(this IObservable<System.Byte> ByteValue, IObservable<System.String> format)
{
    return Observable.Zip(ByteValue, format, (ByteValueLambda, formatLambda) => ByteValueLambda.ToString(formatLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.Byte> ByteValue, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(ByteValue, provider, (ByteValueLambda, providerLambda) => ByteValueLambda.ToString(providerLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.Byte> ByteValue, IObservable<System.String> format, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(ByteValue, format, provider, (ByteValueLambda, formatLambda, providerLambda) => ByteValueLambda.ToString(formatLambda, providerLambda));
}


public static IObservable<System.TypeCode> GetTypeCode(this IObservable<System.Byte> ByteValue)
{
    return Observable.Select(ByteValue, (ByteValueLambda) => ByteValueLambda.GetTypeCode());
}

}
}