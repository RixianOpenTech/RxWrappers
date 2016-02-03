using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _DateTime
{
    
public static IObservable<System.DateTime> Add(this IObservable<System.DateTime> DateTimeValue, IObservable<System.TimeSpan> value)
{
    return Observable.Zip(DateTimeValue, value, (DateTimeValueLambda, valueLambda) => DateTimeValueLambda.Add(valueLambda));
}


public static IObservable<System.DateTime> AddDays(this IObservable<System.DateTime> DateTimeValue, IObservable<System.Double> value)
{
    return Observable.Zip(DateTimeValue, value, (DateTimeValueLambda, valueLambda) => DateTimeValueLambda.AddDays(valueLambda));
}


public static IObservable<System.DateTime> AddHours(this IObservable<System.DateTime> DateTimeValue, IObservable<System.Double> value)
{
    return Observable.Zip(DateTimeValue, value, (DateTimeValueLambda, valueLambda) => DateTimeValueLambda.AddHours(valueLambda));
}


public static IObservable<System.DateTime> AddMilliseconds(this IObservable<System.DateTime> DateTimeValue, IObservable<System.Double> value)
{
    return Observable.Zip(DateTimeValue, value, (DateTimeValueLambda, valueLambda) => DateTimeValueLambda.AddMilliseconds(valueLambda));
}


public static IObservable<System.DateTime> AddMinutes(this IObservable<System.DateTime> DateTimeValue, IObservable<System.Double> value)
{
    return Observable.Zip(DateTimeValue, value, (DateTimeValueLambda, valueLambda) => DateTimeValueLambda.AddMinutes(valueLambda));
}


public static IObservable<System.DateTime> AddMonths(this IObservable<System.DateTime> DateTimeValue, IObservable<System.Int32> months)
{
    return Observable.Zip(DateTimeValue, months, (DateTimeValueLambda, monthsLambda) => DateTimeValueLambda.AddMonths(monthsLambda));
}


public static IObservable<System.DateTime> AddSeconds(this IObservable<System.DateTime> DateTimeValue, IObservable<System.Double> value)
{
    return Observable.Zip(DateTimeValue, value, (DateTimeValueLambda, valueLambda) => DateTimeValueLambda.AddSeconds(valueLambda));
}


public static IObservable<System.DateTime> AddTicks(this IObservable<System.DateTime> DateTimeValue, IObservable<System.Int64> value)
{
    return Observable.Zip(DateTimeValue, value, (DateTimeValueLambda, valueLambda) => DateTimeValueLambda.AddTicks(valueLambda));
}


public static IObservable<System.DateTime> AddYears(this IObservable<System.DateTime> DateTimeValue, IObservable<System.Int32> value)
{
    return Observable.Zip(DateTimeValue, value, (DateTimeValueLambda, valueLambda) => DateTimeValueLambda.AddYears(valueLambda));
}


public static IObservable<System.Int32> Compare(IObservable<System.DateTime> t1, IObservable<System.DateTime> t2)
{
    return Observable.Zip(t1, t2, (t1Lambda, t2Lambda) => System.DateTime.Compare(t1Lambda, t2Lambda));
}


public static IObservable<System.Int32> CompareTo(this IObservable<System.DateTime> DateTimeValue, IObservable<System.Object> value)
{
    return Observable.Zip(DateTimeValue, value, (DateTimeValueLambda, valueLambda) => DateTimeValueLambda.CompareTo(valueLambda));
}


public static IObservable<System.Int32> CompareTo(this IObservable<System.DateTime> DateTimeValue, IObservable<System.DateTime> value)
{
    return Observable.Zip(DateTimeValue, value, (DateTimeValueLambda, valueLambda) => DateTimeValueLambda.CompareTo(valueLambda));
}


public static IObservable<System.Int32> DaysInMonth(IObservable<System.Int32> year, IObservable<System.Int32> month)
{
    return Observable.Zip(year, month, (yearLambda, monthLambda) => System.DateTime.DaysInMonth(yearLambda, monthLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.DateTime> DateTimeValue, IObservable<System.Object> value)
{
    return Observable.Zip(DateTimeValue, value, (DateTimeValueLambda, valueLambda) => DateTimeValueLambda.Equals(valueLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.DateTime> DateTimeValue, IObservable<System.DateTime> value)
{
    return Observable.Zip(DateTimeValue, value, (DateTimeValueLambda, valueLambda) => DateTimeValueLambda.Equals(valueLambda));
}


public static IObservable<System.Boolean> Equals(IObservable<System.DateTime> t1, IObservable<System.DateTime> t2)
{
    return Observable.Zip(t1, t2, (t1Lambda, t2Lambda) => System.DateTime.Equals(t1Lambda, t2Lambda));
}


public static IObservable<System.DateTime> FromBinary(IObservable<System.Int64> dateData)
{
    return Observable.Select(dateData, (dateDataLambda) => System.DateTime.FromBinary(dateDataLambda));
}


public static IObservable<System.DateTime> FromFileTime(IObservable<System.Int64> fileTime)
{
    return Observable.Select(fileTime, (fileTimeLambda) => System.DateTime.FromFileTime(fileTimeLambda));
}


public static IObservable<System.DateTime> FromFileTimeUtc(IObservable<System.Int64> fileTime)
{
    return Observable.Select(fileTime, (fileTimeLambda) => System.DateTime.FromFileTimeUtc(fileTimeLambda));
}


public static IObservable<System.DateTime> FromOADate(IObservable<System.Double> d)
{
    return Observable.Select(d, (dLambda) => System.DateTime.FromOADate(dLambda));
}


public static IObservable<System.Boolean> IsDaylightSavingTime(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.IsDaylightSavingTime());
}


public static IObservable<System.DateTime> SpecifyKind(IObservable<System.DateTime> value, IObservable<System.DateTimeKind> kind)
{
    return Observable.Zip(value, kind, (valueLambda, kindLambda) => System.DateTime.SpecifyKind(valueLambda, kindLambda));
}


public static IObservable<System.Int64> ToBinary(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.ToBinary());
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.GetHashCode());
}


public static IObservable<System.Boolean> IsLeapYear(IObservable<System.Int32> year)
{
    return Observable.Select(year, (yearLambda) => System.DateTime.IsLeapYear(yearLambda));
}


public static IObservable<System.DateTime> Parse(IObservable<System.String> s)
{
    return Observable.Select(s, (sLambda) => System.DateTime.Parse(sLambda));
}


public static IObservable<System.DateTime> Parse(IObservable<System.String> s, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(s, provider, (sLambda, providerLambda) => System.DateTime.Parse(sLambda, providerLambda));
}


public static IObservable<System.DateTime> Parse(IObservable<System.String> s, IObservable<System.IFormatProvider> provider, IObservable<System.Globalization.DateTimeStyles> styles)
{
    return Observable.Zip(s, provider, styles, (sLambda, providerLambda, stylesLambda) => System.DateTime.Parse(sLambda, providerLambda, stylesLambda));
}


public static IObservable<System.DateTime> ParseExact(IObservable<System.String> s, IObservable<System.String> format, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(s, format, provider, (sLambda, formatLambda, providerLambda) => System.DateTime.ParseExact(sLambda, formatLambda, providerLambda));
}


public static IObservable<System.DateTime> ParseExact(IObservable<System.String> s, IObservable<System.String> format, IObservable<System.IFormatProvider> provider, IObservable<System.Globalization.DateTimeStyles> style)
{
    return Observable.Zip(s, format, provider, style, (sLambda, formatLambda, providerLambda, styleLambda) => System.DateTime.ParseExact(sLambda, formatLambda, providerLambda, styleLambda));
}


public static IObservable<System.DateTime> ParseExact(IObservable<System.String> s, IObservable<System.String[]> formats, IObservable<System.IFormatProvider> provider, IObservable<System.Globalization.DateTimeStyles> style)
{
    return Observable.Zip(s, formats, provider, style, (sLambda, formatsLambda, providerLambda, styleLambda) => System.DateTime.ParseExact(sLambda, formatsLambda, providerLambda, styleLambda));
}


public static IObservable<System.TimeSpan> Subtract(this IObservable<System.DateTime> DateTimeValue, IObservable<System.DateTime> value)
{
    return Observable.Zip(DateTimeValue, value, (DateTimeValueLambda, valueLambda) => DateTimeValueLambda.Subtract(valueLambda));
}


public static IObservable<System.DateTime> Subtract(this IObservable<System.DateTime> DateTimeValue, IObservable<System.TimeSpan> value)
{
    return Observable.Zip(DateTimeValue, value, (DateTimeValueLambda, valueLambda) => DateTimeValueLambda.Subtract(valueLambda));
}


public static IObservable<System.Double> ToOADate(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.ToOADate());
}


public static IObservable<System.Int64> ToFileTime(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.ToFileTime());
}


public static IObservable<System.Int64> ToFileTimeUtc(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.ToFileTimeUtc());
}


public static IObservable<System.DateTime> ToLocalTime(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.ToLocalTime());
}


public static IObservable<System.String> ToLongDateString(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.ToLongDateString());
}


public static IObservable<System.String> ToLongTimeString(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.ToLongTimeString());
}


public static IObservable<System.String> ToShortDateString(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.ToShortDateString());
}


public static IObservable<System.String> ToShortTimeString(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.ToShortTimeString());
}


public static IObservable<System.String> ToString(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.ToString());
}


public static IObservable<System.String> ToString(this IObservable<System.DateTime> DateTimeValue, IObservable<System.String> format)
{
    return Observable.Zip(DateTimeValue, format, (DateTimeValueLambda, formatLambda) => DateTimeValueLambda.ToString(formatLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.DateTime> DateTimeValue, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(DateTimeValue, provider, (DateTimeValueLambda, providerLambda) => DateTimeValueLambda.ToString(providerLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.DateTime> DateTimeValue, IObservable<System.String> format, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(DateTimeValue, format, provider, (DateTimeValueLambda, formatLambda, providerLambda) => DateTimeValueLambda.ToString(formatLambda, providerLambda));
}


public static IObservable<System.DateTime> ToUniversalTime(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.ToUniversalTime());
}


public static IObservable<Tuple<System.Boolean, System.DateTime>> TryParse(IObservable<System.String> s)
{
    return Observable.Select(s, (sLambda) => {
System.DateTime resultOutput = default(System.DateTime);
var result = System.DateTime.TryParse(sLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<Tuple<System.Boolean, System.DateTime>> TryParse(IObservable<System.String> s, IObservable<System.IFormatProvider> provider, IObservable<System.Globalization.DateTimeStyles> styles)
{
    return Observable.Zip(s, provider, styles, (sLambda, providerLambda, stylesLambda) => {
System.DateTime resultOutput = default(System.DateTime);
var result = System.DateTime.TryParse(sLambda, providerLambda, stylesLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<Tuple<System.Boolean, System.DateTime>> TryParseExact(IObservable<System.String> s, IObservable<System.String> format, IObservable<System.IFormatProvider> provider, IObservable<System.Globalization.DateTimeStyles> style)
{
    return Observable.Zip(s, format, provider, style, (sLambda, formatLambda, providerLambda, styleLambda) => {
System.DateTime resultOutput = default(System.DateTime);
var result = System.DateTime.TryParseExact(sLambda, formatLambda, providerLambda, styleLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<Tuple<System.Boolean, System.DateTime>> TryParseExact(IObservable<System.String> s, IObservable<System.String[]> formats, IObservable<System.IFormatProvider> provider, IObservable<System.Globalization.DateTimeStyles> style)
{
    return Observable.Zip(s, formats, provider, style, (sLambda, formatsLambda, providerLambda, styleLambda) => {
System.DateTime resultOutput = default(System.DateTime);
var result = System.DateTime.TryParseExact(sLambda, formatsLambda, providerLambda, styleLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<System.String[]> GetDateTimeFormats(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.GetDateTimeFormats());
}


public static IObservable<System.String[]> GetDateTimeFormats(this IObservable<System.DateTime> DateTimeValue, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(DateTimeValue, provider, (DateTimeValueLambda, providerLambda) => DateTimeValueLambda.GetDateTimeFormats(providerLambda));
}


public static IObservable<System.String[]> GetDateTimeFormats(this IObservable<System.DateTime> DateTimeValue, IObservable<System.Char> format)
{
    return Observable.Zip(DateTimeValue, format, (DateTimeValueLambda, formatLambda) => DateTimeValueLambda.GetDateTimeFormats(formatLambda));
}


public static IObservable<System.String[]> GetDateTimeFormats(this IObservable<System.DateTime> DateTimeValue, IObservable<System.Char> format, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(DateTimeValue, format, provider, (DateTimeValueLambda, formatLambda, providerLambda) => DateTimeValueLambda.GetDateTimeFormats(formatLambda, providerLambda));
}


public static IObservable<System.TypeCode> GetTypeCode(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.GetTypeCode());
}


public static IObservable<System.DateTime> get_Date(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.Date);
}


public static IObservable<System.Int32> get_Day(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.Day);
}


public static IObservable<System.DayOfWeek> get_DayOfWeek(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.DayOfWeek);
}


public static IObservable<System.Int32> get_DayOfYear(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.DayOfYear);
}


public static IObservable<System.Int32> get_Hour(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.Hour);
}


public static IObservable<System.DateTimeKind> get_Kind(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.Kind);
}


public static IObservable<System.Int32> get_Millisecond(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.Millisecond);
}


public static IObservable<System.Int32> get_Minute(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.Minute);
}


public static IObservable<System.Int32> get_Month(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.Month);
}


public static IObservable<System.DateTime> get_Now()
{
    return ObservableExt.Factory(() => System.DateTime.Now);
}


public static IObservable<System.DateTime> get_UtcNow()
{
    return ObservableExt.Factory(() => System.DateTime.UtcNow);
}


public static IObservable<System.Int32> get_Second(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.Second);
}


public static IObservable<System.Int64> get_Ticks(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.Ticks);
}


public static IObservable<System.TimeSpan> get_TimeOfDay(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.TimeOfDay);
}


public static IObservable<System.DateTime> get_Today()
{
    return ObservableExt.Factory(() => System.DateTime.Today);
}


public static IObservable<System.Int32> get_Year(this IObservable<System.DateTime> DateTimeValue)
{
    return Observable.Select(DateTimeValue, (DateTimeValueLambda) => DateTimeValueLambda.Year);
}

}
}