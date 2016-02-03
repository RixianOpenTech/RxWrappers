using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __DateTimeOffset
    {
        public static IObservable<System.DateTimeOffset> ToOffset(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue, IObservable<System.TimeSpan> offset)
        {
            return Observable.Zip(DateTimeOffsetValue, offset,
                (DateTimeOffsetValueLambda, offsetLambda) => DateTimeOffsetValueLambda.ToOffset(offsetLambda));
        }


        public static IObservable<System.DateTimeOffset> Add(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue, IObservable<System.TimeSpan> timeSpan)
        {
            return Observable.Zip(DateTimeOffsetValue, timeSpan,
                (DateTimeOffsetValueLambda, timeSpanLambda) => DateTimeOffsetValueLambda.Add(timeSpanLambda));
        }


        public static IObservable<System.DateTimeOffset> AddDays(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue, IObservable<System.Double> days)
        {
            return Observable.Zip(DateTimeOffsetValue, days,
                (DateTimeOffsetValueLambda, daysLambda) => DateTimeOffsetValueLambda.AddDays(daysLambda));
        }


        public static IObservable<System.DateTimeOffset> AddHours(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue, IObservable<System.Double> hours)
        {
            return Observable.Zip(DateTimeOffsetValue, hours,
                (DateTimeOffsetValueLambda, hoursLambda) => DateTimeOffsetValueLambda.AddHours(hoursLambda));
        }


        public static IObservable<System.DateTimeOffset> AddMilliseconds(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue, IObservable<System.Double> milliseconds)
        {
            return Observable.Zip(DateTimeOffsetValue, milliseconds,
                (DateTimeOffsetValueLambda, millisecondsLambda) =>
                    DateTimeOffsetValueLambda.AddMilliseconds(millisecondsLambda));
        }


        public static IObservable<System.DateTimeOffset> AddMinutes(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue, IObservable<System.Double> minutes)
        {
            return Observable.Zip(DateTimeOffsetValue, minutes,
                (DateTimeOffsetValueLambda, minutesLambda) => DateTimeOffsetValueLambda.AddMinutes(minutesLambda));
        }


        public static IObservable<System.DateTimeOffset> AddMonths(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue, IObservable<System.Int32> months)
        {
            return Observable.Zip(DateTimeOffsetValue, months,
                (DateTimeOffsetValueLambda, monthsLambda) => DateTimeOffsetValueLambda.AddMonths(monthsLambda));
        }


        public static IObservable<System.DateTimeOffset> AddSeconds(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue, IObservable<System.Double> seconds)
        {
            return Observable.Zip(DateTimeOffsetValue, seconds,
                (DateTimeOffsetValueLambda, secondsLambda) => DateTimeOffsetValueLambda.AddSeconds(secondsLambda));
        }


        public static IObservable<System.DateTimeOffset> AddTicks(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue, IObservable<System.Int64> ticks)
        {
            return Observable.Zip(DateTimeOffsetValue, ticks,
                (DateTimeOffsetValueLambda, ticksLambda) => DateTimeOffsetValueLambda.AddTicks(ticksLambda));
        }


        public static IObservable<System.DateTimeOffset> AddYears(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue, IObservable<System.Int32> years)
        {
            return Observable.Zip(DateTimeOffsetValue, years,
                (DateTimeOffsetValueLambda, yearsLambda) => DateTimeOffsetValueLambda.AddYears(yearsLambda));
        }


        public static IObservable<System.Int32> Compare(IObservable<System.DateTimeOffset> first,
            IObservable<System.DateTimeOffset> second)
        {
            return Observable.Zip(first, second,
                (firstLambda, secondLambda) => System.DateTimeOffset.Compare(firstLambda, secondLambda));
        }


        public static IObservable<System.Int32> CompareTo(this IObservable<System.DateTimeOffset> DateTimeOffsetValue,
            IObservable<System.DateTimeOffset> other)
        {
            return Observable.Zip(DateTimeOffsetValue, other,
                (DateTimeOffsetValueLambda, otherLambda) => DateTimeOffsetValueLambda.CompareTo(otherLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.DateTimeOffset> DateTimeOffsetValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(DateTimeOffsetValue, obj,
                (DateTimeOffsetValueLambda, objLambda) => DateTimeOffsetValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.DateTimeOffset> DateTimeOffsetValue,
            IObservable<System.DateTimeOffset> other)
        {
            return Observable.Zip(DateTimeOffsetValue, other,
                (DateTimeOffsetValueLambda, otherLambda) => DateTimeOffsetValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Boolean> EqualsExact(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue, IObservable<System.DateTimeOffset> other)
        {
            return Observable.Zip(DateTimeOffsetValue, other,
                (DateTimeOffsetValueLambda, otherLambda) => DateTimeOffsetValueLambda.EqualsExact(otherLambda));
        }


        public static IObservable<System.DateTimeOffset> FromFileTime(IObservable<System.Int64> fileTime)
        {
            return Observable.Select(fileTime, (fileTimeLambda) => System.DateTimeOffset.FromFileTime(fileTimeLambda));
        }


        public static IObservable<System.DateTimeOffset> FromUnixTimeSeconds(IObservable<System.Int64> seconds)
        {
            return Observable.Select(seconds,
                (secondsLambda) => System.DateTimeOffset.FromUnixTimeSeconds(secondsLambda));
        }


        public static IObservable<System.DateTimeOffset> FromUnixTimeMilliseconds(IObservable<System.Int64> milliseconds)
        {
            return Observable.Select(milliseconds,
                (millisecondsLambda) => System.DateTimeOffset.FromUnixTimeMilliseconds(millisecondsLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue,
                (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.GetHashCode());
        }


        public static IObservable<System.DateTimeOffset> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.DateTimeOffset.Parse(inputLambda));
        }


        public static IObservable<System.DateTimeOffset> Parse(IObservable<System.String> input,
            IObservable<System.IFormatProvider> formatProvider)
        {
            return Observable.Zip(input, formatProvider,
                (inputLambda, formatProviderLambda) => System.DateTimeOffset.Parse(inputLambda, formatProviderLambda));
        }


        public static IObservable<System.DateTimeOffset> Parse(IObservable<System.String> input,
            IObservable<System.IFormatProvider> formatProvider, IObservable<System.Globalization.DateTimeStyles> styles)
        {
            return Observable.Zip(input, formatProvider, styles,
                (inputLambda, formatProviderLambda, stylesLambda) =>
                    System.DateTimeOffset.Parse(inputLambda, formatProviderLambda, stylesLambda));
        }


        public static IObservable<System.DateTimeOffset> ParseExact(IObservable<System.String> input,
            IObservable<System.String> format, IObservable<System.IFormatProvider> formatProvider)
        {
            return Observable.Zip(input, format, formatProvider,
                (inputLambda, formatLambda, formatProviderLambda) =>
                    System.DateTimeOffset.ParseExact(inputLambda, formatLambda, formatProviderLambda));
        }


        public static IObservable<System.DateTimeOffset> ParseExact(IObservable<System.String> input,
            IObservable<System.String> format, IObservable<System.IFormatProvider> formatProvider,
            IObservable<System.Globalization.DateTimeStyles> styles)
        {
            return Observable.Zip(input, format, formatProvider, styles,
                (inputLambda, formatLambda, formatProviderLambda, stylesLambda) =>
                    System.DateTimeOffset.ParseExact(inputLambda, formatLambda, formatProviderLambda, stylesLambda));
        }


        public static IObservable<System.DateTimeOffset> ParseExact(IObservable<System.String> input,
            IObservable<System.String[]> formats, IObservable<System.IFormatProvider> formatProvider,
            IObservable<System.Globalization.DateTimeStyles> styles)
        {
            return Observable.Zip(input, formats, formatProvider, styles,
                (inputLambda, formatsLambda, formatProviderLambda, stylesLambda) =>
                    System.DateTimeOffset.ParseExact(inputLambda, formatsLambda, formatProviderLambda, stylesLambda));
        }


        public static IObservable<System.TimeSpan> Subtract(this IObservable<System.DateTimeOffset> DateTimeOffsetValue,
            IObservable<System.DateTimeOffset> value)
        {
            return Observable.Zip(DateTimeOffsetValue, value,
                (DateTimeOffsetValueLambda, valueLambda) => DateTimeOffsetValueLambda.Subtract(valueLambda));
        }


        public static IObservable<System.DateTimeOffset> Subtract(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue, IObservable<System.TimeSpan> value)
        {
            return Observable.Zip(DateTimeOffsetValue, value,
                (DateTimeOffsetValueLambda, valueLambda) => DateTimeOffsetValueLambda.Subtract(valueLambda));
        }


        public static IObservable<System.Int64> ToFileTime(this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue,
                (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.ToFileTime());
        }


        public static IObservable<System.Int64> ToUnixTimeSeconds(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue,
                (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.ToUnixTimeSeconds());
        }


        public static IObservable<System.Int64> ToUnixTimeMilliseconds(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue,
                (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.ToUnixTimeMilliseconds());
        }


        public static IObservable<System.DateTimeOffset> ToLocalTime(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue,
                (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.ToLocalTime());
        }


        public static IObservable<System.String> ToString(this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue,
                (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.ToString());
        }


        public static IObservable<System.String> ToString(this IObservable<System.DateTimeOffset> DateTimeOffsetValue,
            IObservable<System.String> format)
        {
            return Observable.Zip(DateTimeOffsetValue, format,
                (DateTimeOffsetValueLambda, formatLambda) => DateTimeOffsetValueLambda.ToString(formatLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.DateTimeOffset> DateTimeOffsetValue,
            IObservable<System.IFormatProvider> formatProvider)
        {
            return Observable.Zip(DateTimeOffsetValue, formatProvider,
                (DateTimeOffsetValueLambda, formatProviderLambda) =>
                    DateTimeOffsetValueLambda.ToString(formatProviderLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.DateTimeOffset> DateTimeOffsetValue,
            IObservable<System.String> format, IObservable<System.IFormatProvider> formatProvider)
        {
            return Observable.Zip(DateTimeOffsetValue, format, formatProvider,
                (DateTimeOffsetValueLambda, formatLambda, formatProviderLambda) =>
                    DateTimeOffsetValueLambda.ToString(formatLambda, formatProviderLambda));
        }


        public static IObservable<System.DateTimeOffset> ToUniversalTime(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue,
                (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.ToUniversalTime());
        }


        public static IObservable<Tuple<System.Boolean, System.DateTimeOffset>> TryParse(
            IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) =>
            {
                System.DateTimeOffset resultOutput = default(System.DateTimeOffset);
                var result = System.DateTimeOffset.TryParse(inputLambda, out resultOutput);
                return Tuple.Create(result, resultOutput);
            });
        }


        public static IObservable<Tuple<System.Boolean, System.DateTimeOffset>> TryParse(
            IObservable<System.String> input, IObservable<System.IFormatProvider> formatProvider,
            IObservable<System.Globalization.DateTimeStyles> styles)
        {
            return Observable.Zip(input, formatProvider, styles, (inputLambda, formatProviderLambda, stylesLambda) =>
            {
                System.DateTimeOffset resultOutput = default(System.DateTimeOffset);
                var result = System.DateTimeOffset.TryParse(inputLambda, formatProviderLambda, stylesLambda,
                    out resultOutput);
                return Tuple.Create(result, resultOutput);
            });
        }


        public static IObservable<Tuple<System.Boolean, System.DateTimeOffset>> TryParseExact(
            IObservable<System.String> input, IObservable<System.String> format,
            IObservable<System.IFormatProvider> formatProvider, IObservable<System.Globalization.DateTimeStyles> styles)
        {
            return Observable.Zip(input, format, formatProvider, styles,
                (inputLambda, formatLambda, formatProviderLambda, stylesLambda) =>
                {
                    System.DateTimeOffset resultOutput = default(System.DateTimeOffset);
                    var result = System.DateTimeOffset.TryParseExact(inputLambda, formatLambda, formatProviderLambda,
                        stylesLambda, out resultOutput);
                    return Tuple.Create(result, resultOutput);
                });
        }


        public static IObservable<Tuple<System.Boolean, System.DateTimeOffset>> TryParseExact(
            IObservable<System.String> input, IObservable<System.String[]> formats,
            IObservable<System.IFormatProvider> formatProvider, IObservable<System.Globalization.DateTimeStyles> styles)
        {
            return Observable.Zip(input, formats, formatProvider, styles,
                (inputLambda, formatsLambda, formatProviderLambda, stylesLambda) =>
                {
                    System.DateTimeOffset resultOutput = default(System.DateTimeOffset);
                    var result = System.DateTimeOffset.TryParseExact(inputLambda, formatsLambda, formatProviderLambda,
                        stylesLambda, out resultOutput);
                    return Tuple.Create(result, resultOutput);
                });
        }


        public static IObservable<System.DateTimeOffset> get_Now()
        {
            return ObservableExt.Factory(() => System.DateTimeOffset.Now);
        }


        public static IObservable<System.DateTimeOffset> get_UtcNow()
        {
            return ObservableExt.Factory(() => System.DateTimeOffset.UtcNow);
        }


        public static IObservable<System.DateTime> get_DateTime(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue,
                (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.DateTime);
        }


        public static IObservable<System.DateTime> get_UtcDateTime(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue,
                (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.UtcDateTime);
        }


        public static IObservable<System.DateTime> get_LocalDateTime(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue,
                (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.LocalDateTime);
        }


        public static IObservable<System.DateTime> get_Date(this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue, (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.Date);
        }


        public static IObservable<System.Int32> get_Day(this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue, (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.Day);
        }


        public static IObservable<System.DayOfWeek> get_DayOfWeek(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue,
                (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.DayOfWeek);
        }


        public static IObservable<System.Int32> get_DayOfYear(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue,
                (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.DayOfYear);
        }


        public static IObservable<System.Int32> get_Hour(this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue, (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.Hour);
        }


        public static IObservable<System.Int32> get_Millisecond(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue,
                (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.Millisecond);
        }


        public static IObservable<System.Int32> get_Minute(this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue,
                (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.Minute);
        }


        public static IObservable<System.Int32> get_Month(this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue, (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.Month);
        }


        public static IObservable<System.TimeSpan> get_Offset(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue,
                (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.Offset);
        }


        public static IObservable<System.Int32> get_Second(this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue,
                (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.Second);
        }


        public static IObservable<System.Int64> get_Ticks(this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue, (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.Ticks);
        }


        public static IObservable<System.Int64> get_UtcTicks(this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue,
                (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.UtcTicks);
        }


        public static IObservable<System.TimeSpan> get_TimeOfDay(
            this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue,
                (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.TimeOfDay);
        }


        public static IObservable<System.Int32> get_Year(this IObservable<System.DateTimeOffset> DateTimeOffsetValue)
        {
            return Observable.Select(DateTimeOffsetValue, (DateTimeOffsetValueLambda) => DateTimeOffsetValueLambda.Year);
        }
    }
}