using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __UmAlQuraCalendar
    {
        public static IObservable<System.DateTime> AddMonths(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue,
            IObservable<System.DateTime> time, IObservable<System.Int32> months)
        {
            return Observable.Zip(UmAlQuraCalendarValue, time, months,
                (UmAlQuraCalendarValueLambda, timeLambda, monthsLambda) =>
                    UmAlQuraCalendarValueLambda.AddMonths(timeLambda, monthsLambda));
        }


        public static IObservable<System.DateTime> AddYears(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue,
            IObservable<System.DateTime> time, IObservable<System.Int32> years)
        {
            return Observable.Zip(UmAlQuraCalendarValue, time, years,
                (UmAlQuraCalendarValueLambda, timeLambda, yearsLambda) =>
                    UmAlQuraCalendarValueLambda.AddYears(timeLambda, yearsLambda));
        }


        public static IObservable<System.Int32> GetDayOfMonth(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(UmAlQuraCalendarValue, time,
                (UmAlQuraCalendarValueLambda, timeLambda) => UmAlQuraCalendarValueLambda.GetDayOfMonth(timeLambda));
        }


        public static IObservable<System.DayOfWeek> GetDayOfWeek(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(UmAlQuraCalendarValue, time,
                (UmAlQuraCalendarValueLambda, timeLambda) => UmAlQuraCalendarValueLambda.GetDayOfWeek(timeLambda));
        }


        public static IObservable<System.Int32> GetDayOfYear(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(UmAlQuraCalendarValue, time,
                (UmAlQuraCalendarValueLambda, timeLambda) => UmAlQuraCalendarValueLambda.GetDayOfYear(timeLambda));
        }


        public static IObservable<System.Int32> GetDaysInMonth(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> era)
        {
            return Observable.Zip(UmAlQuraCalendarValue, year, month, era,
                (UmAlQuraCalendarValueLambda, yearLambda, monthLambda, eraLambda) =>
                    UmAlQuraCalendarValueLambda.GetDaysInMonth(yearLambda, monthLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetDaysInYear(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(UmAlQuraCalendarValue, year, era,
                (UmAlQuraCalendarValueLambda, yearLambda, eraLambda) =>
                    UmAlQuraCalendarValueLambda.GetDaysInYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetEra(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(UmAlQuraCalendarValue, time,
                (UmAlQuraCalendarValueLambda, timeLambda) => UmAlQuraCalendarValueLambda.GetEra(timeLambda));
        }


        public static IObservable<System.Int32> GetMonth(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(UmAlQuraCalendarValue, time,
                (UmAlQuraCalendarValueLambda, timeLambda) => UmAlQuraCalendarValueLambda.GetMonth(timeLambda));
        }


        public static IObservable<System.Int32> GetMonthsInYear(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(UmAlQuraCalendarValue, year, era,
                (UmAlQuraCalendarValueLambda, yearLambda, eraLambda) =>
                    UmAlQuraCalendarValueLambda.GetMonthsInYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetYear(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(UmAlQuraCalendarValue, time,
                (UmAlQuraCalendarValueLambda, timeLambda) => UmAlQuraCalendarValueLambda.GetYear(timeLambda));
        }


        public static IObservable<System.Boolean> IsLeapDay(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(UmAlQuraCalendarValue, year, month, day, era,
                (UmAlQuraCalendarValueLambda, yearLambda, monthLambda, dayLambda, eraLambda) =>
                    UmAlQuraCalendarValueLambda.IsLeapDay(yearLambda, monthLambda, dayLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetLeapMonth(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(UmAlQuraCalendarValue, year, era,
                (UmAlQuraCalendarValueLambda, yearLambda, eraLambda) =>
                    UmAlQuraCalendarValueLambda.GetLeapMonth(yearLambda, eraLambda));
        }


        public static IObservable<System.Boolean> IsLeapMonth(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> era)
        {
            return Observable.Zip(UmAlQuraCalendarValue, year, month, era,
                (UmAlQuraCalendarValueLambda, yearLambda, monthLambda, eraLambda) =>
                    UmAlQuraCalendarValueLambda.IsLeapMonth(yearLambda, monthLambda, eraLambda));
        }


        public static IObservable<System.Boolean> IsLeapYear(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(UmAlQuraCalendarValue, year, era,
                (UmAlQuraCalendarValueLambda, yearLambda, eraLambda) =>
                    UmAlQuraCalendarValueLambda.IsLeapYear(yearLambda, eraLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day,
            IObservable<System.Int32> hour, IObservable<System.Int32> minute, IObservable<System.Int32> second,
            IObservable<System.Int32> millisecond, IObservable<System.Int32> era)
        {
            return Observable.Zip(UmAlQuraCalendarValue, year, month, day, hour, minute, second, millisecond, era,
                (UmAlQuraCalendarValueLambda, yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda, secondLambda,
                    millisecondLambda, eraLambda) =>
                    UmAlQuraCalendarValueLambda.ToDateTime(yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda,
                        secondLambda, millisecondLambda, eraLambda));
        }


        public static IObservable<System.Int32> ToFourDigitYear(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue,
            IObservable<System.Int32> year)
        {
            return Observable.Zip(UmAlQuraCalendarValue, year,
                (UmAlQuraCalendarValueLambda, yearLambda) => UmAlQuraCalendarValueLambda.ToFourDigitYear(yearLambda));
        }


        public static IObservable<System.DateTime> get_MinSupportedDateTime(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue)
        {
            return Observable.Select(UmAlQuraCalendarValue,
                (UmAlQuraCalendarValueLambda) => UmAlQuraCalendarValueLambda.MinSupportedDateTime);
        }


        public static IObservable<System.DateTime> get_MaxSupportedDateTime(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue)
        {
            return Observable.Select(UmAlQuraCalendarValue,
                (UmAlQuraCalendarValueLambda) => UmAlQuraCalendarValueLambda.MaxSupportedDateTime);
        }


        public static IObservable<System.Globalization.CalendarAlgorithmType> get_AlgorithmType(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue)
        {
            return Observable.Select(UmAlQuraCalendarValue,
                (UmAlQuraCalendarValueLambda) => UmAlQuraCalendarValueLambda.AlgorithmType);
        }


        public static IObservable<System.Int32[]> get_Eras(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue)
        {
            return Observable.Select(UmAlQuraCalendarValue,
                (UmAlQuraCalendarValueLambda) => UmAlQuraCalendarValueLambda.Eras);
        }


        public static IObservable<System.Int32> get_TwoDigitYearMax(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue)
        {
            return Observable.Select(UmAlQuraCalendarValue,
                (UmAlQuraCalendarValueLambda) => UmAlQuraCalendarValueLambda.TwoDigitYearMax);
        }


        public static IObservable<System.Reactive.Unit> set_TwoDigitYearMax(
            this IObservable<System.Globalization.UmAlQuraCalendar> UmAlQuraCalendarValue,
            IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(UmAlQuraCalendarValue, value,
                (UmAlQuraCalendarValueLambda, valueLambda) => UmAlQuraCalendarValueLambda.TwoDigitYearMax = valueLambda);
        }
    }
}