using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __JulianCalendar
    {
        public static IObservable<System.DateTime> AddMonths(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue, IObservable<System.DateTime> time,
            IObservable<System.Int32> months)
        {
            return Observable.Zip(JulianCalendarValue, time, months,
                (JulianCalendarValueLambda, timeLambda, monthsLambda) =>
                    JulianCalendarValueLambda.AddMonths(timeLambda, monthsLambda));
        }


        public static IObservable<System.DateTime> AddYears(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue, IObservable<System.DateTime> time,
            IObservable<System.Int32> years)
        {
            return Observable.Zip(JulianCalendarValue, time, years,
                (JulianCalendarValueLambda, timeLambda, yearsLambda) =>
                    JulianCalendarValueLambda.AddYears(timeLambda, yearsLambda));
        }


        public static IObservable<System.Int32> GetDayOfMonth(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(JulianCalendarValue, time,
                (JulianCalendarValueLambda, timeLambda) => JulianCalendarValueLambda.GetDayOfMonth(timeLambda));
        }


        public static IObservable<System.DayOfWeek> GetDayOfWeek(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(JulianCalendarValue, time,
                (JulianCalendarValueLambda, timeLambda) => JulianCalendarValueLambda.GetDayOfWeek(timeLambda));
        }


        public static IObservable<System.Int32> GetDayOfYear(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(JulianCalendarValue, time,
                (JulianCalendarValueLambda, timeLambda) => JulianCalendarValueLambda.GetDayOfYear(timeLambda));
        }


        public static IObservable<System.Int32> GetDaysInMonth(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> month, IObservable<System.Int32> era)
        {
            return Observable.Zip(JulianCalendarValue, year, month, era,
                (JulianCalendarValueLambda, yearLambda, monthLambda, eraLambda) =>
                    JulianCalendarValueLambda.GetDaysInMonth(yearLambda, monthLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetDaysInYear(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(JulianCalendarValue, year, era,
                (JulianCalendarValueLambda, yearLambda, eraLambda) =>
                    JulianCalendarValueLambda.GetDaysInYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetEra(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(JulianCalendarValue, time,
                (JulianCalendarValueLambda, timeLambda) => JulianCalendarValueLambda.GetEra(timeLambda));
        }


        public static IObservable<System.Int32> GetMonth(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(JulianCalendarValue, time,
                (JulianCalendarValueLambda, timeLambda) => JulianCalendarValueLambda.GetMonth(timeLambda));
        }


        public static IObservable<System.Int32> GetMonthsInYear(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(JulianCalendarValue, year, era,
                (JulianCalendarValueLambda, yearLambda, eraLambda) =>
                    JulianCalendarValueLambda.GetMonthsInYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetYear(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(JulianCalendarValue, time,
                (JulianCalendarValueLambda, timeLambda) => JulianCalendarValueLambda.GetYear(timeLambda));
        }


        public static IObservable<System.Boolean> IsLeapDay(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> month, IObservable<System.Int32> day, IObservable<System.Int32> era)
        {
            return Observable.Zip(JulianCalendarValue, year, month, day, era,
                (JulianCalendarValueLambda, yearLambda, monthLambda, dayLambda, eraLambda) =>
                    JulianCalendarValueLambda.IsLeapDay(yearLambda, monthLambda, dayLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetLeapMonth(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(JulianCalendarValue, year, era,
                (JulianCalendarValueLambda, yearLambda, eraLambda) =>
                    JulianCalendarValueLambda.GetLeapMonth(yearLambda, eraLambda));
        }


        public static IObservable<System.Boolean> IsLeapMonth(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> month, IObservable<System.Int32> era)
        {
            return Observable.Zip(JulianCalendarValue, year, month, era,
                (JulianCalendarValueLambda, yearLambda, monthLambda, eraLambda) =>
                    JulianCalendarValueLambda.IsLeapMonth(yearLambda, monthLambda, eraLambda));
        }


        public static IObservable<System.Boolean> IsLeapYear(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(JulianCalendarValue, year, era,
                (JulianCalendarValueLambda, yearLambda, eraLambda) =>
                    JulianCalendarValueLambda.IsLeapYear(yearLambda, eraLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> month, IObservable<System.Int32> day, IObservable<System.Int32> hour,
            IObservable<System.Int32> minute, IObservable<System.Int32> second, IObservable<System.Int32> millisecond,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(JulianCalendarValue, year, month, day, hour, minute, second, millisecond, era,
                (JulianCalendarValueLambda, yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda, secondLambda,
                    millisecondLambda, eraLambda) =>
                    JulianCalendarValueLambda.ToDateTime(yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda,
                        secondLambda, millisecondLambda, eraLambda));
        }


        public static IObservable<System.Int32> ToFourDigitYear(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue, IObservable<System.Int32> year)
        {
            return Observable.Zip(JulianCalendarValue, year,
                (JulianCalendarValueLambda, yearLambda) => JulianCalendarValueLambda.ToFourDigitYear(yearLambda));
        }


        public static IObservable<System.DateTime> get_MinSupportedDateTime(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue)
        {
            return Observable.Select(JulianCalendarValue,
                (JulianCalendarValueLambda) => JulianCalendarValueLambda.MinSupportedDateTime);
        }


        public static IObservable<System.DateTime> get_MaxSupportedDateTime(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue)
        {
            return Observable.Select(JulianCalendarValue,
                (JulianCalendarValueLambda) => JulianCalendarValueLambda.MaxSupportedDateTime);
        }


        public static IObservable<System.Globalization.CalendarAlgorithmType> get_AlgorithmType(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue)
        {
            return Observable.Select(JulianCalendarValue,
                (JulianCalendarValueLambda) => JulianCalendarValueLambda.AlgorithmType);
        }


        public static IObservable<System.Int32[]> get_Eras(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue)
        {
            return Observable.Select(JulianCalendarValue, (JulianCalendarValueLambda) => JulianCalendarValueLambda.Eras);
        }


        public static IObservable<System.Int32> get_TwoDigitYearMax(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue)
        {
            return Observable.Select(JulianCalendarValue,
                (JulianCalendarValueLambda) => JulianCalendarValueLambda.TwoDigitYearMax);
        }


        public static IObservable<System.Reactive.Unit> set_TwoDigitYearMax(
            this IObservable<System.Globalization.JulianCalendar> JulianCalendarValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(JulianCalendarValue, value,
                (JulianCalendarValueLambda, valueLambda) => JulianCalendarValueLambda.TwoDigitYearMax = valueLambda);
        }
    }
}