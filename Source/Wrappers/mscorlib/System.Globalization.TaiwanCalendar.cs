using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
public static class _TaiwanCalendar
{
    
public static IObservable<System.DateTime> AddMonths(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue, IObservable<System.DateTime> time, IObservable<System.Int32> months)
{
    return Observable.Zip(TaiwanCalendarValue, time, months, (TaiwanCalendarValueLambda, timeLambda, monthsLambda) => TaiwanCalendarValueLambda.AddMonths(timeLambda, monthsLambda));
}


public static IObservable<System.DateTime> AddYears(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue, IObservable<System.DateTime> time, IObservable<System.Int32> years)
{
    return Observable.Zip(TaiwanCalendarValue, time, years, (TaiwanCalendarValueLambda, timeLambda, yearsLambda) => TaiwanCalendarValueLambda.AddYears(timeLambda, yearsLambda));
}


public static IObservable<System.Int32> GetDaysInMonth(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> era)
{
    return Observable.Zip(TaiwanCalendarValue, year, month, era, (TaiwanCalendarValueLambda, yearLambda, monthLambda, eraLambda) => TaiwanCalendarValueLambda.GetDaysInMonth(yearLambda, monthLambda, eraLambda));
}


public static IObservable<System.Int32> GetDaysInYear(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
{
    return Observable.Zip(TaiwanCalendarValue, year, era, (TaiwanCalendarValueLambda, yearLambda, eraLambda) => TaiwanCalendarValueLambda.GetDaysInYear(yearLambda, eraLambda));
}


public static IObservable<System.Int32> GetDayOfMonth(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(TaiwanCalendarValue, time, (TaiwanCalendarValueLambda, timeLambda) => TaiwanCalendarValueLambda.GetDayOfMonth(timeLambda));
}


public static IObservable<System.DayOfWeek> GetDayOfWeek(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(TaiwanCalendarValue, time, (TaiwanCalendarValueLambda, timeLambda) => TaiwanCalendarValueLambda.GetDayOfWeek(timeLambda));
}


public static IObservable<System.Int32> GetDayOfYear(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(TaiwanCalendarValue, time, (TaiwanCalendarValueLambda, timeLambda) => TaiwanCalendarValueLambda.GetDayOfYear(timeLambda));
}


public static IObservable<System.Int32> GetMonthsInYear(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
{
    return Observable.Zip(TaiwanCalendarValue, year, era, (TaiwanCalendarValueLambda, yearLambda, eraLambda) => TaiwanCalendarValueLambda.GetMonthsInYear(yearLambda, eraLambda));
}


public static IObservable<System.Int32> GetWeekOfYear(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue, IObservable<System.DateTime> time, IObservable<System.Globalization.CalendarWeekRule> rule, IObservable<System.DayOfWeek> firstDayOfWeek)
{
    return Observable.Zip(TaiwanCalendarValue, time, rule, firstDayOfWeek, (TaiwanCalendarValueLambda, timeLambda, ruleLambda, firstDayOfWeekLambda) => TaiwanCalendarValueLambda.GetWeekOfYear(timeLambda, ruleLambda, firstDayOfWeekLambda));
}


public static IObservable<System.Int32> GetEra(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(TaiwanCalendarValue, time, (TaiwanCalendarValueLambda, timeLambda) => TaiwanCalendarValueLambda.GetEra(timeLambda));
}


public static IObservable<System.Int32> GetMonth(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(TaiwanCalendarValue, time, (TaiwanCalendarValueLambda, timeLambda) => TaiwanCalendarValueLambda.GetMonth(timeLambda));
}


public static IObservable<System.Int32> GetYear(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(TaiwanCalendarValue, time, (TaiwanCalendarValueLambda, timeLambda) => TaiwanCalendarValueLambda.GetYear(timeLambda));
}


public static IObservable<System.Boolean> IsLeapDay(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day, IObservable<System.Int32> era)
{
    return Observable.Zip(TaiwanCalendarValue, year, month, day, era, (TaiwanCalendarValueLambda, yearLambda, monthLambda, dayLambda, eraLambda) => TaiwanCalendarValueLambda.IsLeapDay(yearLambda, monthLambda, dayLambda, eraLambda));
}


public static IObservable<System.Boolean> IsLeapYear(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
{
    return Observable.Zip(TaiwanCalendarValue, year, era, (TaiwanCalendarValueLambda, yearLambda, eraLambda) => TaiwanCalendarValueLambda.IsLeapYear(yearLambda, eraLambda));
}


public static IObservable<System.Int32> GetLeapMonth(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
{
    return Observable.Zip(TaiwanCalendarValue, year, era, (TaiwanCalendarValueLambda, yearLambda, eraLambda) => TaiwanCalendarValueLambda.GetLeapMonth(yearLambda, eraLambda));
}


public static IObservable<System.Boolean> IsLeapMonth(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> era)
{
    return Observable.Zip(TaiwanCalendarValue, year, month, era, (TaiwanCalendarValueLambda, yearLambda, monthLambda, eraLambda) => TaiwanCalendarValueLambda.IsLeapMonth(yearLambda, monthLambda, eraLambda));
}


public static IObservable<System.DateTime> ToDateTime(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day, IObservable<System.Int32> hour, IObservable<System.Int32> minute, IObservable<System.Int32> second, IObservable<System.Int32> millisecond, IObservable<System.Int32> era)
{
    return Observable.Zip(TaiwanCalendarValue, year, month, day, hour, minute, second, millisecond, era, (TaiwanCalendarValueLambda, yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda, secondLambda, millisecondLambda, eraLambda) => TaiwanCalendarValueLambda.ToDateTime(yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda, secondLambda, millisecondLambda, eraLambda));
}


public static IObservable<System.Int32> ToFourDigitYear(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue, IObservable<System.Int32> year)
{
    return Observable.Zip(TaiwanCalendarValue, year, (TaiwanCalendarValueLambda, yearLambda) => TaiwanCalendarValueLambda.ToFourDigitYear(yearLambda));
}


public static IObservable<System.DateTime> get_MinSupportedDateTime(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue)
{
    return Observable.Select(TaiwanCalendarValue, (TaiwanCalendarValueLambda) => TaiwanCalendarValueLambda.MinSupportedDateTime);
}


public static IObservable<System.DateTime> get_MaxSupportedDateTime(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue)
{
    return Observable.Select(TaiwanCalendarValue, (TaiwanCalendarValueLambda) => TaiwanCalendarValueLambda.MaxSupportedDateTime);
}


public static IObservable<System.Globalization.CalendarAlgorithmType> get_AlgorithmType(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue)
{
    return Observable.Select(TaiwanCalendarValue, (TaiwanCalendarValueLambda) => TaiwanCalendarValueLambda.AlgorithmType);
}


public static IObservable<System.Int32[]> get_Eras(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue)
{
    return Observable.Select(TaiwanCalendarValue, (TaiwanCalendarValueLambda) => TaiwanCalendarValueLambda.Eras);
}


public static IObservable<System.Int32> get_TwoDigitYearMax(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue)
{
    return Observable.Select(TaiwanCalendarValue, (TaiwanCalendarValueLambda) => TaiwanCalendarValueLambda.TwoDigitYearMax);
}


public static IObservable<System.Reactive.Unit> set_TwoDigitYearMax(this IObservable<System.Globalization.TaiwanCalendar> TaiwanCalendarValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(TaiwanCalendarValue, value, (TaiwanCalendarValueLambda, valueLambda) => TaiwanCalendarValueLambda.TwoDigitYearMax = valueLambda);
}

}
}