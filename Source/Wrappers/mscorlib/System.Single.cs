using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _Single
{
    
public static IObservable<System.Boolean> IsInfinity(IObservable<System.Single> f)
{
    return Observable.Select(f, (fLambda) => System.Single.IsInfinity(fLambda));
}


public static IObservable<System.Boolean> IsPositiveInfinity(IObservable<System.Single> f)
{
    return Observable.Select(f, (fLambda) => System.Single.IsPositiveInfinity(fLambda));
}


public static IObservable<System.Boolean> IsNegativeInfinity(IObservable<System.Single> f)
{
    return Observable.Select(f, (fLambda) => System.Single.IsNegativeInfinity(fLambda));
}


public static IObservable<System.Boolean> IsNaN(IObservable<System.Single> f)
{
    return Observable.Select(f, (fLambda) => System.Single.IsNaN(fLambda));
}


public static IObservable<System.Int32> CompareTo(this IObservable<System.Single> SingleValue, IObservable<System.Object> value)
{
    return Observable.Zip(SingleValue, value, (SingleValueLambda, valueLambda) => SingleValueLambda.CompareTo(valueLambda));
}


public static IObservable<System.Int32> CompareTo(this IObservable<System.Single> SingleValue, IObservable<System.Single> value)
{
    return Observable.Zip(SingleValue, value, (SingleValueLambda, valueLambda) => SingleValueLambda.CompareTo(valueLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Single> SingleValue, IObservable<System.Object> obj)
{
    return Observable.Zip(SingleValue, obj, (SingleValueLambda, objLambda) => SingleValueLambda.Equals(objLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Single> SingleValue, IObservable<System.Single> obj)
{
    return Observable.Zip(SingleValue, obj, (SingleValueLambda, objLambda) => SingleValueLambda.Equals(objLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Single> SingleValue)
{
    return Observable.Select(SingleValue, (SingleValueLambda) => SingleValueLambda.GetHashCode());
}


public static IObservable<System.String> ToString(this IObservable<System.Single> SingleValue)
{
    return Observable.Select(SingleValue, (SingleValueLambda) => SingleValueLambda.ToString());
}


public static IObservable<System.String> ToString(this IObservable<System.Single> SingleValue, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(SingleValue, provider, (SingleValueLambda, providerLambda) => SingleValueLambda.ToString(providerLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.Single> SingleValue, IObservable<System.String> format)
{
    return Observable.Zip(SingleValue, format, (SingleValueLambda, formatLambda) => SingleValueLambda.ToString(formatLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.Single> SingleValue, IObservable<System.String> format, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(SingleValue, format, provider, (SingleValueLambda, formatLambda, providerLambda) => SingleValueLambda.ToString(formatLambda, providerLambda));
}


public static IObservable<System.Single> Parse(IObservable<System.String> s)
{
    return Observable.Select(s, (sLambda) => System.Single.Parse(sLambda));
}


public static IObservable<System.Single> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style)
{
    return Observable.Zip(s, style, (sLambda, styleLambda) => System.Single.Parse(sLambda, styleLambda));
}


public static IObservable<System.Single> Parse(IObservable<System.String> s, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(s, provider, (sLambda, providerLambda) => System.Single.Parse(sLambda, providerLambda));
}


public static IObservable<System.Single> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => System.Single.Parse(sLambda, styleLambda, providerLambda));
}


public static IObservable<Tuple<System.Boolean, System.Single>> TryParse(IObservable<System.String> s)
{
    return Observable.Select(s, (sLambda) => {
System.Single resultOutput = default(System.Single);
var result = System.Single.TryParse(sLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<Tuple<System.Boolean, System.Single>> TryParse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => {
System.Single resultOutput = default(System.Single);
var result = System.Single.TryParse(sLambda, styleLambda, providerLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<System.TypeCode> GetTypeCode(this IObservable<System.Single> SingleValue)
{
    return Observable.Select(SingleValue, (SingleValueLambda) => SingleValueLambda.GetTypeCode());
}

}
}