using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __PersianCalendar
    {
        public static IObservable<System.DateTime> AddMonths(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue,
            IObservable<System.DateTime> time, IObservable<System.Int32> months)
        {
            return Observable.Zip(PersianCalendarValue, time, months,
                (PersianCalendarValueLambda, timeLambda, monthsLambda) =>
                    PersianCalendarValueLambda.AddMonths(timeLambda, monthsLambda));
        }


        public static IObservable<System.DateTime> AddYears(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue,
            IObservable<System.DateTime> time, IObservable<System.Int32> years)
        {
            return Observable.Zip(PersianCalendarValue, time, years,
                (PersianCalendarValueLambda, timeLambda, yearsLambda) =>
                    PersianCalendarValueLambda.AddYears(timeLambda, yearsLambda));
        }


        public static IObservable<System.Int32> GetDayOfMonth(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(PersianCalendarValue, time,
                (PersianCalendarValueLambda, timeLambda) => PersianCalendarValueLambda.GetDayOfMonth(timeLambda));
        }


        public static IObservable<System.DayOfWeek> GetDayOfWeek(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(PersianCalendarValue, time,
                (PersianCalendarValueLambda, timeLambda) => PersianCalendarValueLambda.GetDayOfWeek(timeLambda));
        }


        public static IObservable<System.Int32> GetDayOfYear(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(PersianCalendarValue, time,
                (PersianCalendarValueLambda, timeLambda) => PersianCalendarValueLambda.GetDayOfYear(timeLambda));
        }


        public static IObservable<System.Int32> GetDaysInMonth(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> month, IObservable<System.Int32> era)
        {
            return Observable.Zip(PersianCalendarValue, year, month, era,
                (PersianCalendarValueLambda, yearLambda, monthLambda, eraLambda) =>
                    PersianCalendarValueLambda.GetDaysInMonth(yearLambda, monthLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetDaysInYear(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(PersianCalendarValue, year, era,
                (PersianCalendarValueLambda, yearLambda, eraLambda) =>
                    PersianCalendarValueLambda.GetDaysInYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetEra(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(PersianCalendarValue, time,
                (PersianCalendarValueLambda, timeLambda) => PersianCalendarValueLambda.GetEra(timeLambda));
        }


        public static IObservable<System.Int32> GetMonth(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(PersianCalendarValue, time,
                (PersianCalendarValueLambda, timeLambda) => PersianCalendarValueLambda.GetMonth(timeLambda));
        }


        public static IObservable<System.Int32> GetMonthsInYear(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(PersianCalendarValue, year, era,
                (PersianCalendarValueLambda, yearLambda, eraLambda) =>
                    PersianCalendarValueLambda.GetMonthsInYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetYear(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(PersianCalendarValue, time,
                (PersianCalendarValueLambda, timeLambda) => PersianCalendarValueLambda.GetYear(timeLambda));
        }


        public static IObservable<System.Boolean> IsLeapDay(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> month, IObservable<System.Int32> day, IObservable<System.Int32> era)
        {
            return Observable.Zip(PersianCalendarValue, year, month, day, era,
                (PersianCalendarValueLambda, yearLambda, monthLambda, dayLambda, eraLambda) =>
                    PersianCalendarValueLambda.IsLeapDay(yearLambda, monthLambda, dayLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetLeapMonth(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(PersianCalendarValue, year, era,
                (PersianCalendarValueLambda, yearLambda, eraLambda) =>
                    PersianCalendarValueLambda.GetLeapMonth(yearLambda, eraLambda));
        }


        public static IObservable<System.Boolean> IsLeapMonth(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> month, IObservable<System.Int32> era)
        {
            return Observable.Zip(PersianCalendarValue, year, month, era,
                (PersianCalendarValueLambda, yearLambda, monthLambda, eraLambda) =>
                    PersianCalendarValueLambda.IsLeapMonth(yearLambda, monthLambda, eraLambda));
        }


        public static IObservable<System.Boolean> IsLeapYear(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(PersianCalendarValue, year, era,
                (PersianCalendarValueLambda, yearLambda, eraLambda) =>
                    PersianCalendarValueLambda.IsLeapYear(yearLambda, eraLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> month, IObservable<System.Int32> day, IObservable<System.Int32> hour,
            IObservable<System.Int32> minute, IObservable<System.Int32> second, IObservable<System.Int32> millisecond,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(PersianCalendarValue, year, month, day, hour, minute, second, millisecond, era,
                (PersianCalendarValueLambda, yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda, secondLambda,
                    millisecondLambda, eraLambda) =>
                    PersianCalendarValueLambda.ToDateTime(yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda,
                        secondLambda, millisecondLambda, eraLambda));
        }


        public static IObservable<System.Int32> ToFourDigitYear(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue, IObservable<System.Int32> year)
        {
            return Observable.Zip(PersianCalendarValue, year,
                (PersianCalendarValueLambda, yearLambda) => PersianCalendarValueLambda.ToFourDigitYear(yearLambda));
        }


        public static IObservable<System.DateTime> get_MinSupportedDateTime(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue)
        {
            return Observable.Select(PersianCalendarValue,
                (PersianCalendarValueLambda) => PersianCalendarValueLambda.MinSupportedDateTime);
        }


        public static IObservable<System.DateTime> get_MaxSupportedDateTime(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue)
        {
            return Observable.Select(PersianCalendarValue,
                (PersianCalendarValueLambda) => PersianCalendarValueLambda.MaxSupportedDateTime);
        }


        public static IObservable<System.Globalization.CalendarAlgorithmType> get_AlgorithmType(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue)
        {
            return Observable.Select(PersianCalendarValue,
                (PersianCalendarValueLambda) => PersianCalendarValueLambda.AlgorithmType);
        }


        public static IObservable<System.Int32[]> get_Eras(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue)
        {
            return Observable.Select(PersianCalendarValue,
                (PersianCalendarValueLambda) => PersianCalendarValueLambda.Eras);
        }


        public static IObservable<System.Int32> get_TwoDigitYearMax(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue)
        {
            return Observable.Select(PersianCalendarValue,
                (PersianCalendarValueLambda) => PersianCalendarValueLambda.TwoDigitYearMax);
        }


        public static IObservable<System.Reactive.Unit> set_TwoDigitYearMax(
            this IObservable<System.Globalization.PersianCalendar> PersianCalendarValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(PersianCalendarValue, value,
                (PersianCalendarValueLambda, valueLambda) => PersianCalendarValueLambda.TwoDigitYearMax = valueLambda);
        }
    }
}