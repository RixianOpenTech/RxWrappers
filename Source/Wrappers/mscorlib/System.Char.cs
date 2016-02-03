using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _Char
{
    
public static IObservable<System.Int32> GetHashCode(this IObservable<System.Char> CharValue)
{
    return Observable.Select(CharValue, (CharValueLambda) => CharValueLambda.GetHashCode());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Char> CharValue, IObservable<System.Object> obj)
{
    return Observable.Zip(CharValue, obj, (CharValueLambda, objLambda) => CharValueLambda.Equals(objLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Char> CharValue, IObservable<System.Char> obj)
{
    return Observable.Zip(CharValue, obj, (CharValueLambda, objLambda) => CharValueLambda.Equals(objLambda));
}


public static IObservable<System.Int32> CompareTo(this IObservable<System.Char> CharValue, IObservable<System.Object> value)
{
    return Observable.Zip(CharValue, value, (CharValueLambda, valueLambda) => CharValueLambda.CompareTo(valueLambda));
}


public static IObservable<System.Int32> CompareTo(this IObservable<System.Char> CharValue, IObservable<System.Char> value)
{
    return Observable.Zip(CharValue, value, (CharValueLambda, valueLambda) => CharValueLambda.CompareTo(valueLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.Char> CharValue)
{
    return Observable.Select(CharValue, (CharValueLambda) => CharValueLambda.ToString());
}


public static IObservable<System.String> ToString(this IObservable<System.Char> CharValue, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(CharValue, provider, (CharValueLambda, providerLambda) => CharValueLambda.ToString(providerLambda));
}


public static IObservable<System.String> ToString(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.ToString(cLambda));
}


public static IObservable<System.Char> Parse(IObservable<System.String> s)
{
    return Observable.Select(s, (sLambda) => System.Char.Parse(sLambda));
}


public static IObservable<Tuple<System.Boolean, System.Char>> TryParse(IObservable<System.String> s)
{
    return Observable.Select(s, (sLambda) => {
System.Char resultOutput = default(System.Char);
var result = System.Char.TryParse(sLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<System.Boolean> IsDigit(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.IsDigit(cLambda));
}


public static IObservable<System.Boolean> IsLetter(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.IsLetter(cLambda));
}


public static IObservable<System.Boolean> IsWhiteSpace(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.IsWhiteSpace(cLambda));
}


public static IObservable<System.Boolean> IsUpper(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.IsUpper(cLambda));
}


public static IObservable<System.Boolean> IsLower(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.IsLower(cLambda));
}


public static IObservable<System.Boolean> IsPunctuation(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.IsPunctuation(cLambda));
}


public static IObservable<System.Boolean> IsLetterOrDigit(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.IsLetterOrDigit(cLambda));
}


public static IObservable<System.Char> ToUpper(IObservable<System.Char> c, IObservable<System.Globalization.CultureInfo> culture)
{
    return Observable.Zip(c, culture, (cLambda, cultureLambda) => System.Char.ToUpper(cLambda, cultureLambda));
}


public static IObservable<System.Char> ToUpper(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.ToUpper(cLambda));
}


public static IObservable<System.Char> ToUpperInvariant(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.ToUpperInvariant(cLambda));
}


public static IObservable<System.Char> ToLower(IObservable<System.Char> c, IObservable<System.Globalization.CultureInfo> culture)
{
    return Observable.Zip(c, culture, (cLambda, cultureLambda) => System.Char.ToLower(cLambda, cultureLambda));
}


public static IObservable<System.Char> ToLower(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.ToLower(cLambda));
}


public static IObservable<System.Char> ToLowerInvariant(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.ToLowerInvariant(cLambda));
}


public static IObservable<System.TypeCode> GetTypeCode(this IObservable<System.Char> CharValue)
{
    return Observable.Select(CharValue, (CharValueLambda) => CharValueLambda.GetTypeCode());
}


public static IObservable<System.Boolean> IsControl(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.IsControl(cLambda));
}


public static IObservable<System.Boolean> IsControl(IObservable<System.String> s, IObservable<System.Int32> index)
{
    return Observable.Zip(s, index, (sLambda, indexLambda) => System.Char.IsControl(sLambda, indexLambda));
}


public static IObservable<System.Boolean> IsDigit(IObservable<System.String> s, IObservable<System.Int32> index)
{
    return Observable.Zip(s, index, (sLambda, indexLambda) => System.Char.IsDigit(sLambda, indexLambda));
}


public static IObservable<System.Boolean> IsLetter(IObservable<System.String> s, IObservable<System.Int32> index)
{
    return Observable.Zip(s, index, (sLambda, indexLambda) => System.Char.IsLetter(sLambda, indexLambda));
}


public static IObservable<System.Boolean> IsLetterOrDigit(IObservable<System.String> s, IObservable<System.Int32> index)
{
    return Observable.Zip(s, index, (sLambda, indexLambda) => System.Char.IsLetterOrDigit(sLambda, indexLambda));
}


public static IObservable<System.Boolean> IsLower(IObservable<System.String> s, IObservable<System.Int32> index)
{
    return Observable.Zip(s, index, (sLambda, indexLambda) => System.Char.IsLower(sLambda, indexLambda));
}


public static IObservable<System.Boolean> IsNumber(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.IsNumber(cLambda));
}


public static IObservable<System.Boolean> IsNumber(IObservable<System.String> s, IObservable<System.Int32> index)
{
    return Observable.Zip(s, index, (sLambda, indexLambda) => System.Char.IsNumber(sLambda, indexLambda));
}


public static IObservable<System.Boolean> IsPunctuation(IObservable<System.String> s, IObservable<System.Int32> index)
{
    return Observable.Zip(s, index, (sLambda, indexLambda) => System.Char.IsPunctuation(sLambda, indexLambda));
}


public static IObservable<System.Boolean> IsSeparator(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.IsSeparator(cLambda));
}


public static IObservable<System.Boolean> IsSeparator(IObservable<System.String> s, IObservable<System.Int32> index)
{
    return Observable.Zip(s, index, (sLambda, indexLambda) => System.Char.IsSeparator(sLambda, indexLambda));
}


public static IObservable<System.Boolean> IsSurrogate(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.IsSurrogate(cLambda));
}


public static IObservable<System.Boolean> IsSurrogate(IObservable<System.String> s, IObservable<System.Int32> index)
{
    return Observable.Zip(s, index, (sLambda, indexLambda) => System.Char.IsSurrogate(sLambda, indexLambda));
}


public static IObservable<System.Boolean> IsSymbol(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.IsSymbol(cLambda));
}


public static IObservable<System.Boolean> IsSymbol(IObservable<System.String> s, IObservable<System.Int32> index)
{
    return Observable.Zip(s, index, (sLambda, indexLambda) => System.Char.IsSymbol(sLambda, indexLambda));
}


public static IObservable<System.Boolean> IsUpper(IObservable<System.String> s, IObservable<System.Int32> index)
{
    return Observable.Zip(s, index, (sLambda, indexLambda) => System.Char.IsUpper(sLambda, indexLambda));
}


public static IObservable<System.Boolean> IsWhiteSpace(IObservable<System.String> s, IObservable<System.Int32> index)
{
    return Observable.Zip(s, index, (sLambda, indexLambda) => System.Char.IsWhiteSpace(sLambda, indexLambda));
}


public static IObservable<System.Globalization.UnicodeCategory> GetUnicodeCategory(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.GetUnicodeCategory(cLambda));
}


public static IObservable<System.Globalization.UnicodeCategory> GetUnicodeCategory(IObservable<System.String> s, IObservable<System.Int32> index)
{
    return Observable.Zip(s, index, (sLambda, indexLambda) => System.Char.GetUnicodeCategory(sLambda, indexLambda));
}


public static IObservable<System.Double> GetNumericValue(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.GetNumericValue(cLambda));
}


public static IObservable<System.Double> GetNumericValue(IObservable<System.String> s, IObservable<System.Int32> index)
{
    return Observable.Zip(s, index, (sLambda, indexLambda) => System.Char.GetNumericValue(sLambda, indexLambda));
}


public static IObservable<System.Boolean> IsHighSurrogate(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.IsHighSurrogate(cLambda));
}


public static IObservable<System.Boolean> IsHighSurrogate(IObservable<System.String> s, IObservable<System.Int32> index)
{
    return Observable.Zip(s, index, (sLambda, indexLambda) => System.Char.IsHighSurrogate(sLambda, indexLambda));
}


public static IObservable<System.Boolean> IsLowSurrogate(IObservable<System.Char> c)
{
    return Observable.Select(c, (cLambda) => System.Char.IsLowSurrogate(cLambda));
}


public static IObservable<System.Boolean> IsLowSurrogate(IObservable<System.String> s, IObservable<System.Int32> index)
{
    return Observable.Zip(s, index, (sLambda, indexLambda) => System.Char.IsLowSurrogate(sLambda, indexLambda));
}


public static IObservable<System.Boolean> IsSurrogatePair(IObservable<System.String> s, IObservable<System.Int32> index)
{
    return Observable.Zip(s, index, (sLambda, indexLambda) => System.Char.IsSurrogatePair(sLambda, indexLambda));
}


public static IObservable<System.Boolean> IsSurrogatePair(IObservable<System.Char> highSurrogate, IObservable<System.Char> lowSurrogate)
{
    return Observable.Zip(highSurrogate, lowSurrogate, (highSurrogateLambda, lowSurrogateLambda) => System.Char.IsSurrogatePair(highSurrogateLambda, lowSurrogateLambda));
}


public static IObservable<System.String> ConvertFromUtf32(IObservable<System.Int32> utf32)
{
    return Observable.Select(utf32, (utf32Lambda) => System.Char.ConvertFromUtf32(utf32Lambda));
}


public static IObservable<System.Int32> ConvertToUtf32(IObservable<System.Char> highSurrogate, IObservable<System.Char> lowSurrogate)
{
    return Observable.Zip(highSurrogate, lowSurrogate, (highSurrogateLambda, lowSurrogateLambda) => System.Char.ConvertToUtf32(highSurrogateLambda, lowSurrogateLambda));
}


public static IObservable<System.Int32> ConvertToUtf32(IObservable<System.String> s, IObservable<System.Int32> index)
{
    return Observable.Zip(s, index, (sLambda, indexLambda) => System.Char.ConvertToUtf32(sLambda, indexLambda));
}

}
}