using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __HijriCalendar
    {
        
        public static IObservable<System.DateTime> AddMonths(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue, IObservable<System.DateTime> time, IObservable<System.Int32> months)
        {
            return Observable.Zip(HijriCalendarValue, time, months, (HijriCalendarValueLambda, timeLambda, monthsLambda) => HijriCalendarValueLambda.AddMonths(timeLambda, monthsLambda));
        }


        public static IObservable<System.DateTime> AddYears(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue, IObservable<System.DateTime> time, IObservable<System.Int32> years)
        {
            return Observable.Zip(HijriCalendarValue, time, years, (HijriCalendarValueLambda, timeLambda, yearsLambda) => HijriCalendarValueLambda.AddYears(timeLambda, yearsLambda));
        }


        public static IObservable<System.Int32> GetDayOfMonth(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(HijriCalendarValue, time, (HijriCalendarValueLambda, timeLambda) => HijriCalendarValueLambda.GetDayOfMonth(timeLambda));
        }


        public static IObservable<System.DayOfWeek> GetDayOfWeek(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(HijriCalendarValue, time, (HijriCalendarValueLambda, timeLambda) => HijriCalendarValueLambda.GetDayOfWeek(timeLambda));
        }


        public static IObservable<System.Int32> GetDayOfYear(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(HijriCalendarValue, time, (HijriCalendarValueLambda, timeLambda) => HijriCalendarValueLambda.GetDayOfYear(timeLambda));
        }


        public static IObservable<System.Int32> GetDaysInMonth(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> era)
        {
            return Observable.Zip(HijriCalendarValue, year, month, era, (HijriCalendarValueLambda, yearLambda, monthLambda, eraLambda) => HijriCalendarValueLambda.GetDaysInMonth(yearLambda, monthLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetDaysInYear(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(HijriCalendarValue, year, era, (HijriCalendarValueLambda, yearLambda, eraLambda) => HijriCalendarValueLambda.GetDaysInYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetEra(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(HijriCalendarValue, time, (HijriCalendarValueLambda, timeLambda) => HijriCalendarValueLambda.GetEra(timeLambda));
        }


        public static IObservable<System.Int32> GetMonth(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(HijriCalendarValue, time, (HijriCalendarValueLambda, timeLambda) => HijriCalendarValueLambda.GetMonth(timeLambda));
        }


        public static IObservable<System.Int32> GetMonthsInYear(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(HijriCalendarValue, year, era, (HijriCalendarValueLambda, yearLambda, eraLambda) => HijriCalendarValueLambda.GetMonthsInYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetYear(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(HijriCalendarValue, time, (HijriCalendarValueLambda, timeLambda) => HijriCalendarValueLambda.GetYear(timeLambda));
        }


        public static IObservable<System.Boolean> IsLeapDay(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day, IObservable<System.Int32> era)
        {
            return Observable.Zip(HijriCalendarValue, year, month, day, era, (HijriCalendarValueLambda, yearLambda, monthLambda, dayLambda, eraLambda) => HijriCalendarValueLambda.IsLeapDay(yearLambda, monthLambda, dayLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetLeapMonth(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(HijriCalendarValue, year, era, (HijriCalendarValueLambda, yearLambda, eraLambda) => HijriCalendarValueLambda.GetLeapMonth(yearLambda, eraLambda));
        }


        public static IObservable<System.Boolean> IsLeapMonth(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> era)
        {
            return Observable.Zip(HijriCalendarValue, year, month, era, (HijriCalendarValueLambda, yearLambda, monthLambda, eraLambda) => HijriCalendarValueLambda.IsLeapMonth(yearLambda, monthLambda, eraLambda));
        }


        public static IObservable<System.Boolean> IsLeapYear(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(HijriCalendarValue, year, era, (HijriCalendarValueLambda, yearLambda, eraLambda) => HijriCalendarValueLambda.IsLeapYear(yearLambda, eraLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day, IObservable<System.Int32> hour, IObservable<System.Int32> minute, IObservable<System.Int32> second, IObservable<System.Int32> millisecond, IObservable<System.Int32> era)
        {
            return Observable.Zip(HijriCalendarValue, year, month, day, hour, minute, second, millisecond, era, (HijriCalendarValueLambda, yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda, secondLambda, millisecondLambda, eraLambda) => HijriCalendarValueLambda.ToDateTime(yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda, secondLambda, millisecondLambda, eraLambda));
        }


        public static IObservable<System.Int32> ToFourDigitYear(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue, IObservable<System.Int32> year)
        {
            return Observable.Zip(HijriCalendarValue, year, (HijriCalendarValueLambda, yearLambda) => HijriCalendarValueLambda.ToFourDigitYear(yearLambda));
        }


        public static IObservable<System.DateTime> get_MinSupportedDateTime(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue)
        {
            return Observable.Select(HijriCalendarValue, (HijriCalendarValueLambda) => HijriCalendarValueLambda.MinSupportedDateTime);
        }


        public static IObservable<System.DateTime> get_MaxSupportedDateTime(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue)
        {
            return Observable.Select(HijriCalendarValue, (HijriCalendarValueLambda) => HijriCalendarValueLambda.MaxSupportedDateTime);
        }


        public static IObservable<System.Globalization.CalendarAlgorithmType> get_AlgorithmType(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue)
        {
            return Observable.Select(HijriCalendarValue, (HijriCalendarValueLambda) => HijriCalendarValueLambda.AlgorithmType);
        }


        public static IObservable<System.Int32> get_HijriAdjustment(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue)
        {
            return Observable.Select(HijriCalendarValue, (HijriCalendarValueLambda) => HijriCalendarValueLambda.HijriAdjustment);
        }


        public static IObservable<System.Int32[]> get_Eras(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue)
        {
            return Observable.Select(HijriCalendarValue, (HijriCalendarValueLambda) => HijriCalendarValueLambda.Eras);
        }


        public static IObservable<System.Int32> get_TwoDigitYearMax(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue)
        {
            return Observable.Select(HijriCalendarValue, (HijriCalendarValueLambda) => HijriCalendarValueLambda.TwoDigitYearMax);
        }


        public static IObservable<System.Reactive.Unit> set_HijriAdjustment(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(HijriCalendarValue, value, (HijriCalendarValueLambda, valueLambda) => HijriCalendarValueLambda.HijriAdjustment = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_TwoDigitYearMax(this IObservable<System.Globalization.HijriCalendar> HijriCalendarValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(HijriCalendarValue, value, (HijriCalendarValueLambda, valueLambda) => HijriCalendarValueLambda.TwoDigitYearMax = valueLambda);
        }

    }
}