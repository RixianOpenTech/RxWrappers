using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __JapaneseCalendar
    {
        
        public static IObservable<System.DateTime> AddMonths(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue, IObservable<System.DateTime> time, IObservable<System.Int32> months)
        {
            return Observable.Zip(JapaneseCalendarValue, time, months, (JapaneseCalendarValueLambda, timeLambda, monthsLambda) => JapaneseCalendarValueLambda.AddMonths(timeLambda, monthsLambda));
        }


        public static IObservable<System.DateTime> AddYears(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue, IObservable<System.DateTime> time, IObservable<System.Int32> years)
        {
            return Observable.Zip(JapaneseCalendarValue, time, years, (JapaneseCalendarValueLambda, timeLambda, yearsLambda) => JapaneseCalendarValueLambda.AddYears(timeLambda, yearsLambda));
        }


        public static IObservable<System.Int32> GetDaysInMonth(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> era)
        {
            return Observable.Zip(JapaneseCalendarValue, year, month, era, (JapaneseCalendarValueLambda, yearLambda, monthLambda, eraLambda) => JapaneseCalendarValueLambda.GetDaysInMonth(yearLambda, monthLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetDaysInYear(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(JapaneseCalendarValue, year, era, (JapaneseCalendarValueLambda, yearLambda, eraLambda) => JapaneseCalendarValueLambda.GetDaysInYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetDayOfMonth(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(JapaneseCalendarValue, time, (JapaneseCalendarValueLambda, timeLambda) => JapaneseCalendarValueLambda.GetDayOfMonth(timeLambda));
        }


        public static IObservable<System.DayOfWeek> GetDayOfWeek(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(JapaneseCalendarValue, time, (JapaneseCalendarValueLambda, timeLambda) => JapaneseCalendarValueLambda.GetDayOfWeek(timeLambda));
        }


        public static IObservable<System.Int32> GetDayOfYear(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(JapaneseCalendarValue, time, (JapaneseCalendarValueLambda, timeLambda) => JapaneseCalendarValueLambda.GetDayOfYear(timeLambda));
        }


        public static IObservable<System.Int32> GetMonthsInYear(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(JapaneseCalendarValue, year, era, (JapaneseCalendarValueLambda, yearLambda, eraLambda) => JapaneseCalendarValueLambda.GetMonthsInYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetWeekOfYear(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue, IObservable<System.DateTime> time, IObservable<System.Globalization.CalendarWeekRule> rule, IObservable<System.DayOfWeek> firstDayOfWeek)
        {
            return Observable.Zip(JapaneseCalendarValue, time, rule, firstDayOfWeek, (JapaneseCalendarValueLambda, timeLambda, ruleLambda, firstDayOfWeekLambda) => JapaneseCalendarValueLambda.GetWeekOfYear(timeLambda, ruleLambda, firstDayOfWeekLambda));
        }


        public static IObservable<System.Int32> GetEra(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(JapaneseCalendarValue, time, (JapaneseCalendarValueLambda, timeLambda) => JapaneseCalendarValueLambda.GetEra(timeLambda));
        }


        public static IObservable<System.Int32> GetMonth(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(JapaneseCalendarValue, time, (JapaneseCalendarValueLambda, timeLambda) => JapaneseCalendarValueLambda.GetMonth(timeLambda));
        }


        public static IObservable<System.Int32> GetYear(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(JapaneseCalendarValue, time, (JapaneseCalendarValueLambda, timeLambda) => JapaneseCalendarValueLambda.GetYear(timeLambda));
        }


        public static IObservable<System.Boolean> IsLeapDay(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day, IObservable<System.Int32> era)
        {
            return Observable.Zip(JapaneseCalendarValue, year, month, day, era, (JapaneseCalendarValueLambda, yearLambda, monthLambda, dayLambda, eraLambda) => JapaneseCalendarValueLambda.IsLeapDay(yearLambda, monthLambda, dayLambda, eraLambda));
        }


        public static IObservable<System.Boolean> IsLeapYear(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(JapaneseCalendarValue, year, era, (JapaneseCalendarValueLambda, yearLambda, eraLambda) => JapaneseCalendarValueLambda.IsLeapYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetLeapMonth(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(JapaneseCalendarValue, year, era, (JapaneseCalendarValueLambda, yearLambda, eraLambda) => JapaneseCalendarValueLambda.GetLeapMonth(yearLambda, eraLambda));
        }


        public static IObservable<System.Boolean> IsLeapMonth(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> era)
        {
            return Observable.Zip(JapaneseCalendarValue, year, month, era, (JapaneseCalendarValueLambda, yearLambda, monthLambda, eraLambda) => JapaneseCalendarValueLambda.IsLeapMonth(yearLambda, monthLambda, eraLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day, IObservable<System.Int32> hour, IObservable<System.Int32> minute, IObservable<System.Int32> second, IObservable<System.Int32> millisecond, IObservable<System.Int32> era)
        {
            return Observable.Zip(JapaneseCalendarValue, year, month, day, hour, minute, second, millisecond, era, (JapaneseCalendarValueLambda, yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda, secondLambda, millisecondLambda, eraLambda) => JapaneseCalendarValueLambda.ToDateTime(yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda, secondLambda, millisecondLambda, eraLambda));
        }


        public static IObservable<System.Int32> ToFourDigitYear(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue, IObservable<System.Int32> year)
        {
            return Observable.Zip(JapaneseCalendarValue, year, (JapaneseCalendarValueLambda, yearLambda) => JapaneseCalendarValueLambda.ToFourDigitYear(yearLambda));
        }


        public static IObservable<System.DateTime> get_MinSupportedDateTime(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue)
        {
            return Observable.Select(JapaneseCalendarValue, (JapaneseCalendarValueLambda) => JapaneseCalendarValueLambda.MinSupportedDateTime);
        }


        public static IObservable<System.DateTime> get_MaxSupportedDateTime(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue)
        {
            return Observable.Select(JapaneseCalendarValue, (JapaneseCalendarValueLambda) => JapaneseCalendarValueLambda.MaxSupportedDateTime);
        }


        public static IObservable<System.Globalization.CalendarAlgorithmType> get_AlgorithmType(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue)
        {
            return Observable.Select(JapaneseCalendarValue, (JapaneseCalendarValueLambda) => JapaneseCalendarValueLambda.AlgorithmType);
        }


        public static IObservable<System.Int32[]> get_Eras(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue)
        {
            return Observable.Select(JapaneseCalendarValue, (JapaneseCalendarValueLambda) => JapaneseCalendarValueLambda.Eras);
        }


        public static IObservable<System.Int32> get_TwoDigitYearMax(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue)
        {
            return Observable.Select(JapaneseCalendarValue, (JapaneseCalendarValueLambda) => JapaneseCalendarValueLambda.TwoDigitYearMax);
        }


        public static IObservable<System.Reactive.Unit> set_TwoDigitYearMax(this IObservable<System.Globalization.JapaneseCalendar> JapaneseCalendarValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(JapaneseCalendarValue, value, (JapaneseCalendarValueLambda, valueLambda) => JapaneseCalendarValueLambda.TwoDigitYearMax = valueLambda);
        }

    }
}