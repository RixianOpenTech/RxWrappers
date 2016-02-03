using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __DateTimeFormatInfo
    {
        public static IObservable<System.Globalization.DateTimeFormatInfo> GetInstance(
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Select(provider,
                (providerLambda) => System.Globalization.DateTimeFormatInfo.GetInstance(providerLambda));
        }


        public static IObservable<System.Object> GetFormat(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.Type> formatType)
        {
            return Observable.Zip(DateTimeFormatInfoValue, formatType,
                (DateTimeFormatInfoValueLambda, formatTypeLambda) =>
                    DateTimeFormatInfoValueLambda.GetFormat(formatTypeLambda));
        }


        public static IObservable<System.Object> Clone(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.Clone());
        }


        public static IObservable<System.Int32> GetEra(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String> eraName)
        {
            return Observable.Zip(DateTimeFormatInfoValue, eraName,
                (DateTimeFormatInfoValueLambda, eraNameLambda) => DateTimeFormatInfoValueLambda.GetEra(eraNameLambda));
        }


        public static IObservable<System.String> GetEraName(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(DateTimeFormatInfoValue, era,
                (DateTimeFormatInfoValueLambda, eraLambda) => DateTimeFormatInfoValueLambda.GetEraName(eraLambda));
        }


        public static IObservable<System.String> GetAbbreviatedEraName(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(DateTimeFormatInfoValue, era,
                (DateTimeFormatInfoValueLambda, eraLambda) =>
                    DateTimeFormatInfoValueLambda.GetAbbreviatedEraName(eraLambda));
        }


        public static IObservable<System.String> GetAbbreviatedDayName(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.DayOfWeek> dayofweek)
        {
            return Observable.Zip(DateTimeFormatInfoValue, dayofweek,
                (DateTimeFormatInfoValueLambda, dayofweekLambda) =>
                    DateTimeFormatInfoValueLambda.GetAbbreviatedDayName(dayofweekLambda));
        }


        public static IObservable<System.String> GetShortestDayName(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.DayOfWeek> dayOfWeek)
        {
            return Observable.Zip(DateTimeFormatInfoValue, dayOfWeek,
                (DateTimeFormatInfoValueLambda, dayOfWeekLambda) =>
                    DateTimeFormatInfoValueLambda.GetShortestDayName(dayOfWeekLambda));
        }


        public static IObservable<System.String[]> GetAllDateTimePatterns(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.GetAllDateTimePatterns());
        }


        public static IObservable<System.String[]> GetAllDateTimePatterns(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.Char> format)
        {
            return Observable.Zip(DateTimeFormatInfoValue, format,
                (DateTimeFormatInfoValueLambda, formatLambda) =>
                    DateTimeFormatInfoValueLambda.GetAllDateTimePatterns(formatLambda));
        }


        public static IObservable<System.String> GetDayName(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.DayOfWeek> dayofweek)
        {
            return Observable.Zip(DateTimeFormatInfoValue, dayofweek,
                (DateTimeFormatInfoValueLambda, dayofweekLambda) =>
                    DateTimeFormatInfoValueLambda.GetDayName(dayofweekLambda));
        }


        public static IObservable<System.String> GetAbbreviatedMonthName(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.Int32> month)
        {
            return Observable.Zip(DateTimeFormatInfoValue, month,
                (DateTimeFormatInfoValueLambda, monthLambda) =>
                    DateTimeFormatInfoValueLambda.GetAbbreviatedMonthName(monthLambda));
        }


        public static IObservable<System.String> GetMonthName(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.Int32> month)
        {
            return Observable.Zip(DateTimeFormatInfoValue, month,
                (DateTimeFormatInfoValueLambda, monthLambda) => DateTimeFormatInfoValueLambda.GetMonthName(monthLambda));
        }


        public static IObservable<System.Globalization.DateTimeFormatInfo> ReadOnly(
            IObservable<System.Globalization.DateTimeFormatInfo> dtfi)
        {
            return Observable.Select(dtfi, (dtfiLambda) => System.Globalization.DateTimeFormatInfo.ReadOnly(dtfiLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAllDateTimePatterns(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String[]> patterns, IObservable<System.Char> format)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, patterns, format,
                (DateTimeFormatInfoValueLambda, patternsLambda, formatLambda) =>
                    DateTimeFormatInfoValueLambda.SetAllDateTimePatterns(patternsLambda, formatLambda));
        }


        public static IObservable<System.Globalization.DateTimeFormatInfo> get_InvariantInfo()
        {
            return ObservableExt.Factory(() => System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }


        public static IObservable<System.Globalization.DateTimeFormatInfo> get_CurrentInfo()
        {
            return ObservableExt.Factory(() => System.Globalization.DateTimeFormatInfo.CurrentInfo);
        }


        public static IObservable<System.String> get_AMDesignator(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.AMDesignator);
        }


        public static IObservable<System.Globalization.Calendar> get_Calendar(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.Calendar);
        }


        public static IObservable<System.String> get_DateSeparator(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.DateSeparator);
        }


        public static IObservable<System.DayOfWeek> get_FirstDayOfWeek(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.FirstDayOfWeek);
        }


        public static IObservable<System.Globalization.CalendarWeekRule> get_CalendarWeekRule(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.CalendarWeekRule);
        }


        public static IObservable<System.String> get_FullDateTimePattern(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.FullDateTimePattern);
        }


        public static IObservable<System.String> get_LongDatePattern(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.LongDatePattern);
        }


        public static IObservable<System.String> get_LongTimePattern(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.LongTimePattern);
        }


        public static IObservable<System.String> get_MonthDayPattern(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.MonthDayPattern);
        }


        public static IObservable<System.String> get_PMDesignator(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.PMDesignator);
        }


        public static IObservable<System.String> get_RFC1123Pattern(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.RFC1123Pattern);
        }


        public static IObservable<System.String> get_ShortDatePattern(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.ShortDatePattern);
        }


        public static IObservable<System.String> get_ShortTimePattern(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.ShortTimePattern);
        }


        public static IObservable<System.String> get_SortableDateTimePattern(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.SortableDateTimePattern);
        }


        public static IObservable<System.String> get_TimeSeparator(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.TimeSeparator);
        }


        public static IObservable<System.String> get_UniversalSortableDateTimePattern(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.UniversalSortableDateTimePattern);
        }


        public static IObservable<System.String> get_YearMonthPattern(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.YearMonthPattern);
        }


        public static IObservable<System.String[]> get_AbbreviatedDayNames(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.AbbreviatedDayNames);
        }


        public static IObservable<System.String[]> get_ShortestDayNames(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.ShortestDayNames);
        }


        public static IObservable<System.String[]> get_DayNames(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.DayNames);
        }


        public static IObservable<System.String[]> get_AbbreviatedMonthNames(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.AbbreviatedMonthNames);
        }


        public static IObservable<System.String[]> get_MonthNames(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.MonthNames);
        }


        public static IObservable<System.Boolean> get_IsReadOnly(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.IsReadOnly);
        }


        public static IObservable<System.String> get_NativeCalendarName(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.NativeCalendarName);
        }


        public static IObservable<System.String[]> get_AbbreviatedMonthGenitiveNames(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.AbbreviatedMonthGenitiveNames);
        }


        public static IObservable<System.String[]> get_MonthGenitiveNames(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue)
        {
            return Observable.Select(DateTimeFormatInfoValue,
                (DateTimeFormatInfoValueLambda) => DateTimeFormatInfoValueLambda.MonthGenitiveNames);
        }


        public static IObservable<System.Reactive.Unit> set_AMDesignator(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) => DateTimeFormatInfoValueLambda.AMDesignator = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Calendar(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.Globalization.Calendar> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) => DateTimeFormatInfoValueLambda.Calendar = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DateSeparator(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) =>
                    DateTimeFormatInfoValueLambda.DateSeparator = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_FirstDayOfWeek(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.DayOfWeek> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) =>
                    DateTimeFormatInfoValueLambda.FirstDayOfWeek = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_CalendarWeekRule(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.Globalization.CalendarWeekRule> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) =>
                    DateTimeFormatInfoValueLambda.CalendarWeekRule = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_FullDateTimePattern(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) =>
                    DateTimeFormatInfoValueLambda.FullDateTimePattern = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_LongDatePattern(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) =>
                    DateTimeFormatInfoValueLambda.LongDatePattern = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_LongTimePattern(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) =>
                    DateTimeFormatInfoValueLambda.LongTimePattern = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MonthDayPattern(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) =>
                    DateTimeFormatInfoValueLambda.MonthDayPattern = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PMDesignator(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) => DateTimeFormatInfoValueLambda.PMDesignator = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ShortDatePattern(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) =>
                    DateTimeFormatInfoValueLambda.ShortDatePattern = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ShortTimePattern(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) =>
                    DateTimeFormatInfoValueLambda.ShortTimePattern = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_TimeSeparator(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) =>
                    DateTimeFormatInfoValueLambda.TimeSeparator = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_YearMonthPattern(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) =>
                    DateTimeFormatInfoValueLambda.YearMonthPattern = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_AbbreviatedDayNames(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String[]> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) =>
                    DateTimeFormatInfoValueLambda.AbbreviatedDayNames = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ShortestDayNames(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String[]> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) =>
                    DateTimeFormatInfoValueLambda.ShortestDayNames = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DayNames(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String[]> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) => DateTimeFormatInfoValueLambda.DayNames = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_AbbreviatedMonthNames(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String[]> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) =>
                    DateTimeFormatInfoValueLambda.AbbreviatedMonthNames = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MonthNames(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String[]> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) => DateTimeFormatInfoValueLambda.MonthNames = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_AbbreviatedMonthGenitiveNames(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String[]> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) =>
                    DateTimeFormatInfoValueLambda.AbbreviatedMonthGenitiveNames = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MonthGenitiveNames(
            this IObservable<System.Globalization.DateTimeFormatInfo> DateTimeFormatInfoValue,
            IObservable<System.String[]> value)
        {
            return ObservableExt.ZipExecute(DateTimeFormatInfoValue, value,
                (DateTimeFormatInfoValueLambda, valueLambda) =>
                    DateTimeFormatInfoValueLambda.MonthGenitiveNames = valueLambda);
        }
    }
}