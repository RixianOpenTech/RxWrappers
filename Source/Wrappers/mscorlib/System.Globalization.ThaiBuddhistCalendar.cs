using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __ThaiBuddhistCalendar
    {
        public static IObservable<System.DateTime> AddMonths(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue,
            IObservable<System.DateTime> time, IObservable<System.Int32> months)
        {
            return Observable.Zip(ThaiBuddhistCalendarValue, time, months,
                (ThaiBuddhistCalendarValueLambda, timeLambda, monthsLambda) =>
                    ThaiBuddhistCalendarValueLambda.AddMonths(timeLambda, monthsLambda));
        }


        public static IObservable<System.DateTime> AddYears(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue,
            IObservable<System.DateTime> time, IObservable<System.Int32> years)
        {
            return Observable.Zip(ThaiBuddhistCalendarValue, time, years,
                (ThaiBuddhistCalendarValueLambda, timeLambda, yearsLambda) =>
                    ThaiBuddhistCalendarValueLambda.AddYears(timeLambda, yearsLambda));
        }


        public static IObservable<System.Int32> GetDaysInMonth(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> era)
        {
            return Observable.Zip(ThaiBuddhistCalendarValue, year, month, era,
                (ThaiBuddhistCalendarValueLambda, yearLambda, monthLambda, eraLambda) =>
                    ThaiBuddhistCalendarValueLambda.GetDaysInMonth(yearLambda, monthLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetDaysInYear(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(ThaiBuddhistCalendarValue, year, era,
                (ThaiBuddhistCalendarValueLambda, yearLambda, eraLambda) =>
                    ThaiBuddhistCalendarValueLambda.GetDaysInYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetDayOfMonth(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(ThaiBuddhistCalendarValue, time,
                (ThaiBuddhistCalendarValueLambda, timeLambda) =>
                    ThaiBuddhistCalendarValueLambda.GetDayOfMonth(timeLambda));
        }


        public static IObservable<System.DayOfWeek> GetDayOfWeek(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(ThaiBuddhistCalendarValue, time,
                (ThaiBuddhistCalendarValueLambda, timeLambda) =>
                    ThaiBuddhistCalendarValueLambda.GetDayOfWeek(timeLambda));
        }


        public static IObservable<System.Int32> GetDayOfYear(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(ThaiBuddhistCalendarValue, time,
                (ThaiBuddhistCalendarValueLambda, timeLambda) =>
                    ThaiBuddhistCalendarValueLambda.GetDayOfYear(timeLambda));
        }


        public static IObservable<System.Int32> GetMonthsInYear(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(ThaiBuddhistCalendarValue, year, era,
                (ThaiBuddhistCalendarValueLambda, yearLambda, eraLambda) =>
                    ThaiBuddhistCalendarValueLambda.GetMonthsInYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetWeekOfYear(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue,
            IObservable<System.DateTime> time, IObservable<System.Globalization.CalendarWeekRule> rule,
            IObservable<System.DayOfWeek> firstDayOfWeek)
        {
            return Observable.Zip(ThaiBuddhistCalendarValue, time, rule, firstDayOfWeek,
                (ThaiBuddhistCalendarValueLambda, timeLambda, ruleLambda, firstDayOfWeekLambda) =>
                    ThaiBuddhistCalendarValueLambda.GetWeekOfYear(timeLambda, ruleLambda, firstDayOfWeekLambda));
        }


        public static IObservable<System.Int32> GetEra(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(ThaiBuddhistCalendarValue, time,
                (ThaiBuddhistCalendarValueLambda, timeLambda) => ThaiBuddhistCalendarValueLambda.GetEra(timeLambda));
        }


        public static IObservable<System.Int32> GetMonth(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(ThaiBuddhistCalendarValue, time,
                (ThaiBuddhistCalendarValueLambda, timeLambda) => ThaiBuddhistCalendarValueLambda.GetMonth(timeLambda));
        }


        public static IObservable<System.Int32> GetYear(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(ThaiBuddhistCalendarValue, time,
                (ThaiBuddhistCalendarValueLambda, timeLambda) => ThaiBuddhistCalendarValueLambda.GetYear(timeLambda));
        }


        public static IObservable<System.Boolean> IsLeapDay(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(ThaiBuddhistCalendarValue, year, month, day, era,
                (ThaiBuddhistCalendarValueLambda, yearLambda, monthLambda, dayLambda, eraLambda) =>
                    ThaiBuddhistCalendarValueLambda.IsLeapDay(yearLambda, monthLambda, dayLambda, eraLambda));
        }


        public static IObservable<System.Boolean> IsLeapYear(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(ThaiBuddhistCalendarValue, year, era,
                (ThaiBuddhistCalendarValueLambda, yearLambda, eraLambda) =>
                    ThaiBuddhistCalendarValueLambda.IsLeapYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetLeapMonth(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> era)
        {
            return Observable.Zip(ThaiBuddhistCalendarValue, year, era,
                (ThaiBuddhistCalendarValueLambda, yearLambda, eraLambda) =>
                    ThaiBuddhistCalendarValueLambda.GetLeapMonth(yearLambda, eraLambda));
        }


        public static IObservable<System.Boolean> IsLeapMonth(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> era)
        {
            return Observable.Zip(ThaiBuddhistCalendarValue, year, month, era,
                (ThaiBuddhistCalendarValueLambda, yearLambda, monthLambda, eraLambda) =>
                    ThaiBuddhistCalendarValueLambda.IsLeapMonth(yearLambda, monthLambda, eraLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue,
            IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day,
            IObservable<System.Int32> hour, IObservable<System.Int32> minute, IObservable<System.Int32> second,
            IObservable<System.Int32> millisecond, IObservable<System.Int32> era)
        {
            return Observable.Zip(ThaiBuddhistCalendarValue, year, month, day, hour, minute, second, millisecond, era,
                (ThaiBuddhistCalendarValueLambda, yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda,
                    secondLambda, millisecondLambda, eraLambda) =>
                    ThaiBuddhistCalendarValueLambda.ToDateTime(yearLambda, monthLambda, dayLambda, hourLambda,
                        minuteLambda, secondLambda, millisecondLambda, eraLambda));
        }


        public static IObservable<System.Int32> ToFourDigitYear(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue,
            IObservable<System.Int32> year)
        {
            return Observable.Zip(ThaiBuddhistCalendarValue, year,
                (ThaiBuddhistCalendarValueLambda, yearLambda) =>
                    ThaiBuddhistCalendarValueLambda.ToFourDigitYear(yearLambda));
        }


        public static IObservable<System.DateTime> get_MinSupportedDateTime(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue)
        {
            return Observable.Select(ThaiBuddhistCalendarValue,
                (ThaiBuddhistCalendarValueLambda) => ThaiBuddhistCalendarValueLambda.MinSupportedDateTime);
        }


        public static IObservable<System.DateTime> get_MaxSupportedDateTime(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue)
        {
            return Observable.Select(ThaiBuddhistCalendarValue,
                (ThaiBuddhistCalendarValueLambda) => ThaiBuddhistCalendarValueLambda.MaxSupportedDateTime);
        }


        public static IObservable<System.Globalization.CalendarAlgorithmType> get_AlgorithmType(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue)
        {
            return Observable.Select(ThaiBuddhistCalendarValue,
                (ThaiBuddhistCalendarValueLambda) => ThaiBuddhistCalendarValueLambda.AlgorithmType);
        }


        public static IObservable<System.Int32[]> get_Eras(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue)
        {
            return Observable.Select(ThaiBuddhistCalendarValue,
                (ThaiBuddhistCalendarValueLambda) => ThaiBuddhistCalendarValueLambda.Eras);
        }


        public static IObservable<System.Int32> get_TwoDigitYearMax(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue)
        {
            return Observable.Select(ThaiBuddhistCalendarValue,
                (ThaiBuddhistCalendarValueLambda) => ThaiBuddhistCalendarValueLambda.TwoDigitYearMax);
        }


        public static IObservable<System.Reactive.Unit> set_TwoDigitYearMax(
            this IObservable<System.Globalization.ThaiBuddhistCalendar> ThaiBuddhistCalendarValue,
            IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(ThaiBuddhistCalendarValue, value,
                (ThaiBuddhistCalendarValueLambda, valueLambda) =>
                    ThaiBuddhistCalendarValueLambda.TwoDigitYearMax = valueLambda);
        }
    }
}