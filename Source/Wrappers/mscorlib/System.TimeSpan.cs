using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _TimeSpan
{
    
public static IObservable<System.TimeSpan> Add(this IObservable<System.TimeSpan> TimeSpanValue, IObservable<System.TimeSpan> ts)
{
    return Observable.Zip(TimeSpanValue, ts, (TimeSpanValueLambda, tsLambda) => TimeSpanValueLambda.Add(tsLambda));
}


public static IObservable<System.Int32> Compare(IObservable<System.TimeSpan> t1, IObservable<System.TimeSpan> t2)
{
    return Observable.Zip(t1, t2, (t1Lambda, t2Lambda) => System.TimeSpan.Compare(t1Lambda, t2Lambda));
}


public static IObservable<System.Int32> CompareTo(this IObservable<System.TimeSpan> TimeSpanValue, IObservable<System.Object> value)
{
    return Observable.Zip(TimeSpanValue, value, (TimeSpanValueLambda, valueLambda) => TimeSpanValueLambda.CompareTo(valueLambda));
}


public static IObservable<System.Int32> CompareTo(this IObservable<System.TimeSpan> TimeSpanValue, IObservable<System.TimeSpan> value)
{
    return Observable.Zip(TimeSpanValue, value, (TimeSpanValueLambda, valueLambda) => TimeSpanValueLambda.CompareTo(valueLambda));
}


public static IObservable<System.TimeSpan> FromDays(IObservable<System.Double> value)
{
    return Observable.Select(value, (valueLambda) => System.TimeSpan.FromDays(valueLambda));
}


public static IObservable<System.TimeSpan> Duration(this IObservable<System.TimeSpan> TimeSpanValue)
{
    return Observable.Select(TimeSpanValue, (TimeSpanValueLambda) => TimeSpanValueLambda.Duration());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.TimeSpan> TimeSpanValue, IObservable<System.Object> value)
{
    return Observable.Zip(TimeSpanValue, value, (TimeSpanValueLambda, valueLambda) => TimeSpanValueLambda.Equals(valueLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.TimeSpan> TimeSpanValue, IObservable<System.TimeSpan> obj)
{
    return Observable.Zip(TimeSpanValue, obj, (TimeSpanValueLambda, objLambda) => TimeSpanValueLambda.Equals(objLambda));
}


public static IObservable<System.Boolean> Equals(IObservable<System.TimeSpan> t1, IObservable<System.TimeSpan> t2)
{
    return Observable.Zip(t1, t2, (t1Lambda, t2Lambda) => System.TimeSpan.Equals(t1Lambda, t2Lambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.TimeSpan> TimeSpanValue)
{
    return Observable.Select(TimeSpanValue, (TimeSpanValueLambda) => TimeSpanValueLambda.GetHashCode());
}


public static IObservable<System.TimeSpan> FromHours(IObservable<System.Double> value)
{
    return Observable.Select(value, (valueLambda) => System.TimeSpan.FromHours(valueLambda));
}


public static IObservable<System.TimeSpan> FromMilliseconds(IObservable<System.Double> value)
{
    return Observable.Select(value, (valueLambda) => System.TimeSpan.FromMilliseconds(valueLambda));
}


public static IObservable<System.TimeSpan> FromMinutes(IObservable<System.Double> value)
{
    return Observable.Select(value, (valueLambda) => System.TimeSpan.FromMinutes(valueLambda));
}


public static IObservable<System.TimeSpan> Negate(this IObservable<System.TimeSpan> TimeSpanValue)
{
    return Observable.Select(TimeSpanValue, (TimeSpanValueLambda) => TimeSpanValueLambda.Negate());
}


public static IObservable<System.TimeSpan> FromSeconds(IObservable<System.Double> value)
{
    return Observable.Select(value, (valueLambda) => System.TimeSpan.FromSeconds(valueLambda));
}


public static IObservable<System.TimeSpan> Subtract(this IObservable<System.TimeSpan> TimeSpanValue, IObservable<System.TimeSpan> ts)
{
    return Observable.Zip(TimeSpanValue, ts, (TimeSpanValueLambda, tsLambda) => TimeSpanValueLambda.Subtract(tsLambda));
}


public static IObservable<System.TimeSpan> FromTicks(IObservable<System.Int64> value)
{
    return Observable.Select(value, (valueLambda) => System.TimeSpan.FromTicks(valueLambda));
}


public static IObservable<System.TimeSpan> Parse(IObservable<System.String> s)
{
    return Observable.Select(s, (sLambda) => System.TimeSpan.Parse(sLambda));
}


public static IObservable<System.TimeSpan> Parse(IObservable<System.String> input, IObservable<System.IFormatProvider> formatProvider)
{
    return Observable.Zip(input, formatProvider, (inputLambda, formatProviderLambda) => System.TimeSpan.Parse(inputLambda, formatProviderLambda));
}


public static IObservable<System.TimeSpan> ParseExact(IObservable<System.String> input, IObservable<System.String> format, IObservable<System.IFormatProvider> formatProvider)
{
    return Observable.Zip(input, format, formatProvider, (inputLambda, formatLambda, formatProviderLambda) => System.TimeSpan.ParseExact(inputLambda, formatLambda, formatProviderLambda));
}


public static IObservable<System.TimeSpan> ParseExact(IObservable<System.String> input, IObservable<System.String[]> formats, IObservable<System.IFormatProvider> formatProvider)
{
    return Observable.Zip(input, formats, formatProvider, (inputLambda, formatsLambda, formatProviderLambda) => System.TimeSpan.ParseExact(inputLambda, formatsLambda, formatProviderLambda));
}


public static IObservable<System.TimeSpan> ParseExact(IObservable<System.String> input, IObservable<System.String> format, IObservable<System.IFormatProvider> formatProvider, IObservable<System.Globalization.TimeSpanStyles> styles)
{
    return Observable.Zip(input, format, formatProvider, styles, (inputLambda, formatLambda, formatProviderLambda, stylesLambda) => System.TimeSpan.ParseExact(inputLambda, formatLambda, formatProviderLambda, stylesLambda));
}


public static IObservable<System.TimeSpan> ParseExact(IObservable<System.String> input, IObservable<System.String[]> formats, IObservable<System.IFormatProvider> formatProvider, IObservable<System.Globalization.TimeSpanStyles> styles)
{
    return Observable.Zip(input, formats, formatProvider, styles, (inputLambda, formatsLambda, formatProviderLambda, stylesLambda) => System.TimeSpan.ParseExact(inputLambda, formatsLambda, formatProviderLambda, stylesLambda));
}


public static IObservable<Tuple<System.Boolean, System.TimeSpan>> TryParse(IObservable<System.String> s)
{
    return Observable.Select(s, (sLambda) => {
System.TimeSpan resultOutput = default(System.TimeSpan);
var result = System.TimeSpan.TryParse(sLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<Tuple<System.Boolean, System.TimeSpan>> TryParse(IObservable<System.String> input, IObservable<System.IFormatProvider> formatProvider)
{
    return Observable.Zip(input, formatProvider, (inputLambda, formatProviderLambda) => {
System.TimeSpan resultOutput = default(System.TimeSpan);
var result = System.TimeSpan.TryParse(inputLambda, formatProviderLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<Tuple<System.Boolean, System.TimeSpan>> TryParseExact(IObservable<System.String> input, IObservable<System.String> format, IObservable<System.IFormatProvider> formatProvider)
{
    return Observable.Zip(input, format, formatProvider, (inputLambda, formatLambda, formatProviderLambda) => {
System.TimeSpan resultOutput = default(System.TimeSpan);
var result = System.TimeSpan.TryParseExact(inputLambda, formatLambda, formatProviderLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<Tuple<System.Boolean, System.TimeSpan>> TryParseExact(IObservable<System.String> input, IObservable<System.String[]> formats, IObservable<System.IFormatProvider> formatProvider)
{
    return Observable.Zip(input, formats, formatProvider, (inputLambda, formatsLambda, formatProviderLambda) => {
System.TimeSpan resultOutput = default(System.TimeSpan);
var result = System.TimeSpan.TryParseExact(inputLambda, formatsLambda, formatProviderLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<Tuple<System.Boolean, System.TimeSpan>> TryParseExact(IObservable<System.String> input, IObservable<System.String> format, IObservable<System.IFormatProvider> formatProvider, IObservable<System.Globalization.TimeSpanStyles> styles)
{
    return Observable.Zip(input, format, formatProvider, styles, (inputLambda, formatLambda, formatProviderLambda, stylesLambda) => {
System.TimeSpan resultOutput = default(System.TimeSpan);
var result = System.TimeSpan.TryParseExact(inputLambda, formatLambda, formatProviderLambda, stylesLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<Tuple<System.Boolean, System.TimeSpan>> TryParseExact(IObservable<System.String> input, IObservable<System.String[]> formats, IObservable<System.IFormatProvider> formatProvider, IObservable<System.Globalization.TimeSpanStyles> styles)
{
    return Observable.Zip(input, formats, formatProvider, styles, (inputLambda, formatsLambda, formatProviderLambda, stylesLambda) => {
System.TimeSpan resultOutput = default(System.TimeSpan);
var result = System.TimeSpan.TryParseExact(inputLambda, formatsLambda, formatProviderLambda, stylesLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<System.String> ToString(this IObservable<System.TimeSpan> TimeSpanValue)
{
    return Observable.Select(TimeSpanValue, (TimeSpanValueLambda) => TimeSpanValueLambda.ToString());
}


public static IObservable<System.String> ToString(this IObservable<System.TimeSpan> TimeSpanValue, IObservable<System.String> format)
{
    return Observable.Zip(TimeSpanValue, format, (TimeSpanValueLambda, formatLambda) => TimeSpanValueLambda.ToString(formatLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.TimeSpan> TimeSpanValue, IObservable<System.String> format, IObservable<System.IFormatProvider> formatProvider)
{
    return Observable.Zip(TimeSpanValue, format, formatProvider, (TimeSpanValueLambda, formatLambda, formatProviderLambda) => TimeSpanValueLambda.ToString(formatLambda, formatProviderLambda));
}


public static IObservable<System.Int64> get_Ticks(this IObservable<System.TimeSpan> TimeSpanValue)
{
    return Observable.Select(TimeSpanValue, (TimeSpanValueLambda) => TimeSpanValueLambda.Ticks);
}


public static IObservable<System.Int32> get_Days(this IObservable<System.TimeSpan> TimeSpanValue)
{
    return Observable.Select(TimeSpanValue, (TimeSpanValueLambda) => TimeSpanValueLambda.Days);
}


public static IObservable<System.Int32> get_Hours(this IObservable<System.TimeSpan> TimeSpanValue)
{
    return Observable.Select(TimeSpanValue, (TimeSpanValueLambda) => TimeSpanValueLambda.Hours);
}


public static IObservable<System.Int32> get_Milliseconds(this IObservable<System.TimeSpan> TimeSpanValue)
{
    return Observable.Select(TimeSpanValue, (TimeSpanValueLambda) => TimeSpanValueLambda.Milliseconds);
}


public static IObservable<System.Int32> get_Minutes(this IObservable<System.TimeSpan> TimeSpanValue)
{
    return Observable.Select(TimeSpanValue, (TimeSpanValueLambda) => TimeSpanValueLambda.Minutes);
}


public static IObservable<System.Int32> get_Seconds(this IObservable<System.TimeSpan> TimeSpanValue)
{
    return Observable.Select(TimeSpanValue, (TimeSpanValueLambda) => TimeSpanValueLambda.Seconds);
}


public static IObservable<System.Double> get_TotalDays(this IObservable<System.TimeSpan> TimeSpanValue)
{
    return Observable.Select(TimeSpanValue, (TimeSpanValueLambda) => TimeSpanValueLambda.TotalDays);
}


public static IObservable<System.Double> get_TotalHours(this IObservable<System.TimeSpan> TimeSpanValue)
{
    return Observable.Select(TimeSpanValue, (TimeSpanValueLambda) => TimeSpanValueLambda.TotalHours);
}


public static IObservable<System.Double> get_TotalMilliseconds(this IObservable<System.TimeSpan> TimeSpanValue)
{
    return Observable.Select(TimeSpanValue, (TimeSpanValueLambda) => TimeSpanValueLambda.TotalMilliseconds);
}


public static IObservable<System.Double> get_TotalMinutes(this IObservable<System.TimeSpan> TimeSpanValue)
{
    return Observable.Select(TimeSpanValue, (TimeSpanValueLambda) => TimeSpanValueLambda.TotalMinutes);
}


public static IObservable<System.Double> get_TotalSeconds(this IObservable<System.TimeSpan> TimeSpanValue)
{
    return Observable.Select(TimeSpanValue, (TimeSpanValueLambda) => TimeSpanValueLambda.TotalSeconds);
}

}
}