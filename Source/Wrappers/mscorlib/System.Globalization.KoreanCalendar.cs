using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __KoreanCalendar
    {
        public static IObservable<System.DateTime> AddMonths(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue, IObservable<System.DateTime> time,
            IObservable<System.Int32> months)
        {
            return Observable.Zip(KoreanCalendarValue, time, months,
                (KoreanCalendarValueLambda, timeLambda, monthsLambda) =>
                    KoreanCalendarValueLambda.AddMonths(timeLambda, monthsLambda));
        }


        public static IObservable<System.DateTime> AddYears(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue, IObservable<System.DateTime> time,
            IObservable<System.Int32> years)
        {
            return Observable.Zip(KoreanCalendarValue, time, years,
                (KoreanCalendarValueLambda, timeLambda, yearsLambda) =>
                    KoreanCalendarValueLambda.AddYears(timeLambda, yearsLambda));
        }


        public static IObservable<System.Int32> GetDaysInMonth(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> month, IObservable<System.Int32> era)
        {
            return Observable.Zip(KoreanCalendarValue, year, month, era,
                (KoreanCalendarValueLambda, yearLambda, monthLambda, eraLambda) =>
                    KoreanCalendarValueLambda.GetDaysInMonth(yearLambda, monthLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetDaysInYear(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(KoreanCalendarValue, year, era,
                (KoreanCalendarValueLambda, yearLambda, eraLambda) =>
                    KoreanCalendarValueLambda.GetDaysInYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetDayOfMonth(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(KoreanCalendarValue, time,
                (KoreanCalendarValueLambda, timeLambda) => KoreanCalendarValueLambda.GetDayOfMonth(timeLambda));
        }


        public static IObservable<System.DayOfWeek> GetDayOfWeek(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(KoreanCalendarValue, time,
                (KoreanCalendarValueLambda, timeLambda) => KoreanCalendarValueLambda.GetDayOfWeek(timeLambda));
        }


        public static IObservable<System.Int32> GetDayOfYear(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(KoreanCalendarValue, time,
                (KoreanCalendarValueLambda, timeLambda) => KoreanCalendarValueLambda.GetDayOfYear(timeLambda));
        }


        public static IObservable<System.Int32> GetMonthsInYear(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(KoreanCalendarValue, year, era,
                (KoreanCalendarValueLambda, yearLambda, eraLambda) =>
                    KoreanCalendarValueLambda.GetMonthsInYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetWeekOfYear(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue, IObservable<System.DateTime> time,
            IObservable<System.Globalization.CalendarWeekRule> rule, IObservable<System.DayOfWeek> firstDayOfWeek)
        {
            return Observable.Zip(KoreanCalendarValue, time, rule, firstDayOfWeek,
                (KoreanCalendarValueLambda, timeLambda, ruleLambda, firstDayOfWeekLambda) =>
                    KoreanCalendarValueLambda.GetWeekOfYear(timeLambda, ruleLambda, firstDayOfWeekLambda));
        }


        public static IObservable<System.Int32> GetEra(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(KoreanCalendarValue, time,
                (KoreanCalendarValueLambda, timeLambda) => KoreanCalendarValueLambda.GetEra(timeLambda));
        }


        public static IObservable<System.Int32> GetMonth(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(KoreanCalendarValue, time,
                (KoreanCalendarValueLambda, timeLambda) => KoreanCalendarValueLambda.GetMonth(timeLambda));
        }


        public static IObservable<System.Int32> GetYear(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(KoreanCalendarValue, time,
                (KoreanCalendarValueLambda, timeLambda) => KoreanCalendarValueLambda.GetYear(timeLambda));
        }


        public static IObservable<System.Boolean> IsLeapDay(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> month, IObservable<System.Int32> day, IObservable<System.Int32> era)
        {
            return Observable.Zip(KoreanCalendarValue, year, month, day, era,
                (KoreanCalendarValueLambda, yearLambda, monthLambda, dayLambda, eraLambda) =>
                    KoreanCalendarValueLambda.IsLeapDay(yearLambda, monthLambda, dayLambda, eraLambda));
        }


        public static IObservable<System.Boolean> IsLeapYear(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(KoreanCalendarValue, year, era,
                (KoreanCalendarValueLambda, yearLambda, eraLambda) =>
                    KoreanCalendarValueLambda.IsLeapYear(yearLambda, eraLambda));
        }


        public static IObservable<System.Int32> GetLeapMonth(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(KoreanCalendarValue, year, era,
                (KoreanCalendarValueLambda, yearLambda, eraLambda) =>
                    KoreanCalendarValueLambda.GetLeapMonth(yearLambda, eraLambda));
        }


        public static IObservable<System.Boolean> IsLeapMonth(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> month, IObservable<System.Int32> era)
        {
            return Observable.Zip(KoreanCalendarValue, year, month, era,
                (KoreanCalendarValueLambda, yearLambda, monthLambda, eraLambda) =>
                    KoreanCalendarValueLambda.IsLeapMonth(yearLambda, monthLambda, eraLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue, IObservable<System.Int32> year,
            IObservable<System.Int32> month, IObservable<System.Int32> day, IObservable<System.Int32> hour,
            IObservable<System.Int32> minute, IObservable<System.Int32> second, IObservable<System.Int32> millisecond,
            IObservable<System.Int32> era)
        {
            return Observable.Zip(KoreanCalendarValue, year, month, day, hour, minute, second, millisecond, era,
                (KoreanCalendarValueLambda, yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda, secondLambda,
                    millisecondLambda, eraLambda) =>
                    KoreanCalendarValueLambda.ToDateTime(yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda,
                        secondLambda, millisecondLambda, eraLambda));
        }


        public static IObservable<System.Int32> ToFourDigitYear(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue, IObservable<System.Int32> year)
        {
            return Observable.Zip(KoreanCalendarValue, year,
                (KoreanCalendarValueLambda, yearLambda) => KoreanCalendarValueLambda.ToFourDigitYear(yearLambda));
        }


        public static IObservable<System.DateTime> get_MinSupportedDateTime(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue)
        {
            return Observable.Select(KoreanCalendarValue,
                (KoreanCalendarValueLambda) => KoreanCalendarValueLambda.MinSupportedDateTime);
        }


        public static IObservable<System.DateTime> get_MaxSupportedDateTime(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue)
        {
            return Observable.Select(KoreanCalendarValue,
                (KoreanCalendarValueLambda) => KoreanCalendarValueLambda.MaxSupportedDateTime);
        }


        public static IObservable<System.Globalization.CalendarAlgorithmType> get_AlgorithmType(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue)
        {
            return Observable.Select(KoreanCalendarValue,
                (KoreanCalendarValueLambda) => KoreanCalendarValueLambda.AlgorithmType);
        }


        public static IObservable<System.Int32[]> get_Eras(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue)
        {
            return Observable.Select(KoreanCalendarValue, (KoreanCalendarValueLambda) => KoreanCalendarValueLambda.Eras);
        }


        public static IObservable<System.Int32> get_TwoDigitYearMax(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue)
        {
            return Observable.Select(KoreanCalendarValue,
                (KoreanCalendarValueLambda) => KoreanCalendarValueLambda.TwoDigitYearMax);
        }


        public static IObservable<System.Reactive.Unit> set_TwoDigitYearMax(
            this IObservable<System.Globalization.KoreanCalendar> KoreanCalendarValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(KoreanCalendarValue, value,
                (KoreanCalendarValueLambda, valueLambda) => KoreanCalendarValueLambda.TwoDigitYearMax = valueLambda);
        }
    }
}