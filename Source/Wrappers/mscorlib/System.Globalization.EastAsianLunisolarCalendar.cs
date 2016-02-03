using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __EastAsianLunisolarCalendar
    {
        
        public static IObservable<System.Int32> GetSexagenaryYear(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(EastAsianLunisolarCalendarValue, time, (EastAsianLunisolarCalendarValueLambda, timeLambda) => EastAsianLunisolarCalendarValueLambda.GetSexagenaryYear(timeLambda));
        }


        public static IObservable<System.Int32> GetCelestialStem(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.Int32> sexagenaryYear)
        {
            return Observable.Zip(EastAsianLunisolarCalendarValue, sexagenaryYear, (EastAsianLunisolarCalendarValueLambda, sexagenaryYearLambda) => EastAsianLunisolarCalendarValueLambda.GetCelestialStem(sexagenaryYearLambda));
        }


        public static IObservable<System.Int32> GetTerrestrialBranch(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.Int32> sexagenaryYear)
        {
            return Observable.Zip(EastAsianLunisolarCalendarValue, sexagenaryYear, (EastAsianLunisolarCalendarValueLambda, sexagenaryYearLambda) => EastAsianLunisolarCalendarValueLambda.GetTerrestrialBranch(sexagenaryYearLambda));
        }


        public static IObservable<System.Int32> GetDaysInMonth(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> era)
        {
            return Observable.Zip(EastAsianLunisolarCalendarValue, year, month, era, (EastAsianLunisolarCalendarValueLambda, yearLambda, monthLambda, eraLambda) => EastAsianLunisolarCalendarValueLambda.GetDaysInMonth(yearLambda, monthLambda, eraLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day, IObservable<System.Int32> hour, IObservable<System.Int32> minute, IObservable<System.Int32> second, IObservable<System.Int32> millisecond, IObservable<System.Int32> era)
        {
            return Observable.Zip(EastAsianLunisolarCalendarValue, year, month, day, hour, minute, second, millisecond, era, (EastAsianLunisolarCalendarValueLambda, yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda, secondLambda, millisecondLambda, eraLambda) => EastAsianLunisolarCalendarValueLambda.ToDateTime(yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda, secondLambda, millisecondLambda, eraLambda));
        }


        public static IObservable<System.DateTime> AddMonths(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.DateTime> time, IObservable<System.Int32> months)
        {
            return Observable.Zip(EastAsianLunisolarCalendarValue, time, months, (EastAsianLunisolarCalendarValueLambda, timeLambda, monthsLambda) => EastAsianLunisolarCalendarValueLambda.AddMonths(timeLambda, monthsLambda));
        }


        public static IObservable<System.DateTime> AddYears(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.DateTime> time, IObservable<System.Int32> years)
        {
            return Observable.Zip(EastAsianLunisolarCalendarValue, time, years, (EastAsianLunisolarCalendarValueLambda, timeLambda, yearsLambda) => EastAsianLunisolarCalendarValueLambda.AddYears(timeLambda, yearsLambda));
        }


        public static IObservable<System.Int32> GetDayOfYear(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(EastAsianLunisolarCalendarValue, time, (EastAsianLunisolarCalendarValueLambda, timeLambda) => EastAsianLunisolarCalendarValueLambda.GetDayOfYear(timeLambda));
        }


        public static IObservable<System.Int32> GetDayOfMonth(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(EastAsianLunisolarCalendarValue, time, (EastAsianLunisolarCalendarValueLambda, timeLambda) => EastAsianLunisolarCalendarValueLambda.GetDayOfMonth(timeLambda));
        }


        public static IObservable<System.Int32> GetDaysInYear(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(EastAsianLunisolarCalendarValue, year, era, (EastAsianLunisolarCalendarValueLambda, yearLambda, eraLambda) => EastAsianLunisolarCalendarValueLambda.GetDaysInYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetMonth(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(EastAsianLunisolarCalendarValue, time, (EastAsianLunisolarCalendarValueLambda, timeLambda) => EastAsianLunisolarCalendarValueLambda.GetMonth(timeLambda));
        }


        public static IObservable<System.Int32> GetYear(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(EastAsianLunisolarCalendarValue, time, (EastAsianLunisolarCalendarValueLambda, timeLambda) => EastAsianLunisolarCalendarValueLambda.GetYear(timeLambda));
        }


        public static IObservable<System.DayOfWeek> GetDayOfWeek(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(EastAsianLunisolarCalendarValue, time, (EastAsianLunisolarCalendarValueLambda, timeLambda) => EastAsianLunisolarCalendarValueLambda.GetDayOfWeek(timeLambda));
        }


        public static IObservable<System.Int32> GetMonthsInYear(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(EastAsianLunisolarCalendarValue, year, era, (EastAsianLunisolarCalendarValueLambda, yearLambda, eraLambda) => EastAsianLunisolarCalendarValueLambda.GetMonthsInYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Boolean> IsLeapDay(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day, IObservable<System.Int32> era)
        {
            return Observable.Zip(EastAsianLunisolarCalendarValue, year, month, day, era, (EastAsianLunisolarCalendarValueLambda, yearLambda, monthLambda, dayLambda, eraLambda) => EastAsianLunisolarCalendarValueLambda.IsLeapDay(yearLambda, monthLambda, dayLambda, eraLambda));
        }


        public static IObservable<System.Boolean> IsLeapMonth(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> era)
        {
            return Observable.Zip(EastAsianLunisolarCalendarValue, year, month, era, (EastAsianLunisolarCalendarValueLambda, yearLambda, monthLambda, eraLambda) => EastAsianLunisolarCalendarValueLambda.IsLeapMonth(yearLambda, monthLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetLeapMonth(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(EastAsianLunisolarCalendarValue, year, era, (EastAsianLunisolarCalendarValueLambda, yearLambda, eraLambda) => EastAsianLunisolarCalendarValueLambda.GetLeapMonth(yearLambda, eraLambda));
        }


        public static IObservable<System.Boolean> IsLeapYear(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(EastAsianLunisolarCalendarValue, year, era, (EastAsianLunisolarCalendarValueLambda, yearLambda, eraLambda) => EastAsianLunisolarCalendarValueLambda.IsLeapYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> ToFourDigitYear(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.Int32> year)
        {
            return Observable.Zip(EastAsianLunisolarCalendarValue, year, (EastAsianLunisolarCalendarValueLambda, yearLambda) => EastAsianLunisolarCalendarValueLambda.ToFourDigitYear(yearLambda));
        }


        public static IObservable<System.Globalization.CalendarAlgorithmType> get_AlgorithmType(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue)
        {
            return Observable.Select(EastAsianLunisolarCalendarValue, (EastAsianLunisolarCalendarValueLambda) => EastAsianLunisolarCalendarValueLambda.AlgorithmType);
        }


        public static IObservable<System.Int32> get_TwoDigitYearMax(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue)
        {
            return Observable.Select(EastAsianLunisolarCalendarValue, (EastAsianLunisolarCalendarValueLambda) => EastAsianLunisolarCalendarValueLambda.TwoDigitYearMax);
        }


        public static IObservable<System.Reactive.Unit> set_TwoDigitYearMax(this IObservable<System.Globalization.EastAsianLunisolarCalendar> EastAsianLunisolarCalendarValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(EastAsianLunisolarCalendarValue, value, (EastAsianLunisolarCalendarValueLambda, valueLambda) => EastAsianLunisolarCalendarValueLambda.TwoDigitYearMax = valueLambda);
        }

    }
}