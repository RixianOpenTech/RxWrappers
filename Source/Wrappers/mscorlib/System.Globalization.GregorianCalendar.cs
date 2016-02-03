using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __GregorianCalendar
    {
        public static IObservable<System.DateTime> AddMonths(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue,
            IObservable<System.DateTime> time, IObservable<System.Int32> months)
        {
            return Observable.Zip(GregorianCalendarValue, time, months,
                (GregorianCalendarValueLambda, timeLambda, monthsLambda) =>
                    GregorianCalendarValueLambda.AddMonths(timeLambda, monthsLambda));
        }


        public static IObservable<System.DateTime> AddYears(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue,
            IObservable<System.DateTime> time, IObservable<System.Int32> years)
        {
            return Observable.Zip(GregorianCalendarValue, time, years,
                (GregorianCalendarValueLambda, timeLambda, yearsLambda) =>
                    GregorianCalendarValueLambda.AddYears(timeLambda, yearsLambda));
        }


        public static IObservable<System.Int32> GetDayOfMonth(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(GregorianCalendarValue, time,
                (GregorianCalendarValueLambda, timeLambda) => GregorianCalendarValueLambda.GetDayOfMonth(timeLambda));
        }


        public static IObservable<System.DayOfWeek> GetDayOfWeek(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(GregorianCalendarValue, time,
                (GregorianCalendarValueLambda, timeLambda) => GregorianCalendarValueLambda.GetDayOfWeek(timeLambda));
        }


        public static IObservable<System.Int32> GetDayOfYear(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(GregorianCalendarValue, time,
                (GregorianCalendarValueLambda, timeLambda) => GregorianCalendarValueLambda.GetDayOfYear(timeLambda));
        }


        public static IObservable<System.Int32> GetDaysInMonth(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> era)
        {
            return Observable.Zip(GregorianCalendarValue, year, month, era,
                (GregorianCalendarValueLambda, yearLambda, monthLambda, eraLambda) =>
                    GregorianCalendarValueLambda.GetDaysInMonth(yearLambda, monthLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetDaysInYear(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(GregorianCalendarValue, year, era,
                (GregorianCalendarValueLambda, yearLambda, eraLambda) =>
                    GregorianCalendarValueLambda.GetDaysInYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetEra(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(GregorianCalendarValue, time,
                (GregorianCalendarValueLambda, timeLambda) => GregorianCalendarValueLambda.GetEra(timeLambda));
        }


        public static IObservable<System.Int32> GetMonth(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(GregorianCalendarValue, time,
                (GregorianCalendarValueLambda, timeLambda) => GregorianCalendarValueLambda.GetMonth(timeLambda));
        }


        public static IObservable<System.Int32> GetMonthsInYear(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(GregorianCalendarValue, year, era,
                (GregorianCalendarValueLambda, yearLambda, eraLambda) =>
                    GregorianCalendarValueLambda.GetMonthsInYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetYear(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(GregorianCalendarValue, time,
                (GregorianCalendarValueLambda, timeLambda) => GregorianCalendarValueLambda.GetYear(timeLambda));
        }


        public static IObservable<System.Boolean> IsLeapDay(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(GregorianCalendarValue, year, month, day, era,
                (GregorianCalendarValueLambda, yearLambda, monthLambda, dayLambda, eraLambda) =>
                    GregorianCalendarValueLambda.IsLeapDay(yearLambda, monthLambda, dayLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetLeapMonth(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(GregorianCalendarValue, year, era,
                (GregorianCalendarValueLambda, yearLambda, eraLambda) =>
                    GregorianCalendarValueLambda.GetLeapMonth(yearLambda, eraLambda));
        }


        public static IObservable<System.Boolean> IsLeapMonth(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> era)
        {
            return Observable.Zip(GregorianCalendarValue, year, month, era,
                (GregorianCalendarValueLambda, yearLambda, monthLambda, eraLambda) =>
                    GregorianCalendarValueLambda.IsLeapMonth(yearLambda, monthLambda, eraLambda));
        }


        public static IObservable<System.Boolean> IsLeapYear(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(GregorianCalendarValue, year, era,
                (GregorianCalendarValueLambda, yearLambda, eraLambda) =>
                    GregorianCalendarValueLambda.IsLeapYear(yearLambda, eraLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day,
            IObservable<System.Int32> hour, IObservable<System.Int32> minute, IObservable<System.Int32> second,
            IObservable<System.Int32> millisecond, IObservable<System.Int32> era)
        {
            return Observable.Zip(GregorianCalendarValue, year, month, day, hour, minute, second, millisecond, era,
                (GregorianCalendarValueLambda, yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda,
                    secondLambda, millisecondLambda, eraLambda) =>
                    GregorianCalendarValueLambda.ToDateTime(yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda,
                        secondLambda, millisecondLambda, eraLambda));
        }


        public static IObservable<System.Int32> ToFourDigitYear(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue,
            IObservable<System.Int32> year)
        {
            return Observable.Zip(GregorianCalendarValue, year,
                (GregorianCalendarValueLambda, yearLambda) => GregorianCalendarValueLambda.ToFourDigitYear(yearLambda));
        }


        public static IObservable<System.DateTime> get_MinSupportedDateTime(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue)
        {
            return Observable.Select(GregorianCalendarValue,
                (GregorianCalendarValueLambda) => GregorianCalendarValueLambda.MinSupportedDateTime);
        }


        public static IObservable<System.DateTime> get_MaxSupportedDateTime(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue)
        {
            return Observable.Select(GregorianCalendarValue,
                (GregorianCalendarValueLambda) => GregorianCalendarValueLambda.MaxSupportedDateTime);
        }


        public static IObservable<System.Globalization.CalendarAlgorithmType> get_AlgorithmType(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue)
        {
            return Observable.Select(GregorianCalendarValue,
                (GregorianCalendarValueLambda) => GregorianCalendarValueLambda.AlgorithmType);
        }


        public static IObservable<System.Globalization.GregorianCalendarTypes> get_CalendarType(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue)
        {
            return Observable.Select(GregorianCalendarValue,
                (GregorianCalendarValueLambda) => GregorianCalendarValueLambda.CalendarType);
        }


        public static IObservable<System.Int32[]> get_Eras(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue)
        {
            return Observable.Select(GregorianCalendarValue,
                (GregorianCalendarValueLambda) => GregorianCalendarValueLambda.Eras);
        }


        public static IObservable<System.Int32> get_TwoDigitYearMax(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue)
        {
            return Observable.Select(GregorianCalendarValue,
                (GregorianCalendarValueLambda) => GregorianCalendarValueLambda.TwoDigitYearMax);
        }


        public static IObservable<System.Reactive.Unit> set_CalendarType(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue,
            IObservable<System.Globalization.GregorianCalendarTypes> value)
        {
            return ObservableExt.ZipExecute(GregorianCalendarValue, value,
                (GregorianCalendarValueLambda, valueLambda) => GregorianCalendarValueLambda.CalendarType = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_TwoDigitYearMax(
            this IObservable<System.Globalization.GregorianCalendar> GregorianCalendarValue,
            IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(GregorianCalendarValue, value,
                (GregorianCalendarValueLambda, valueLambda) =>
                    GregorianCalendarValueLambda.TwoDigitYearMax = valueLambda);
        }
    }
}