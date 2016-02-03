using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
public static class _HebrewCalendar
{
    
public static IObservable<System.DateTime> AddMonths(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue, IObservable<System.DateTime> time, IObservable<System.Int32> months)
{
    return Observable.Zip(HebrewCalendarValue, time, months, (HebrewCalendarValueLambda, timeLambda, monthsLambda) => HebrewCalendarValueLambda.AddMonths(timeLambda, monthsLambda));
}


public static IObservable<System.DateTime> AddYears(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue, IObservable<System.DateTime> time, IObservable<System.Int32> years)
{
    return Observable.Zip(HebrewCalendarValue, time, years, (HebrewCalendarValueLambda, timeLambda, yearsLambda) => HebrewCalendarValueLambda.AddYears(timeLambda, yearsLambda));
}


public static IObservable<System.Int32> GetDayOfMonth(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(HebrewCalendarValue, time, (HebrewCalendarValueLambda, timeLambda) => HebrewCalendarValueLambda.GetDayOfMonth(timeLambda));
}


public static IObservable<System.DayOfWeek> GetDayOfWeek(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(HebrewCalendarValue, time, (HebrewCalendarValueLambda, timeLambda) => HebrewCalendarValueLambda.GetDayOfWeek(timeLambda));
}


public static IObservable<System.Int32> GetDayOfYear(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(HebrewCalendarValue, time, (HebrewCalendarValueLambda, timeLambda) => HebrewCalendarValueLambda.GetDayOfYear(timeLambda));
}


public static IObservable<System.Int32> GetDaysInMonth(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> era)
{
    return Observable.Zip(HebrewCalendarValue, year, month, era, (HebrewCalendarValueLambda, yearLambda, monthLambda, eraLambda) => HebrewCalendarValueLambda.GetDaysInMonth(yearLambda, monthLambda, eraLambda));
}


public static IObservable<System.Int32> GetDaysInYear(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
{
    return Observable.Zip(HebrewCalendarValue, year, era, (HebrewCalendarValueLambda, yearLambda, eraLambda) => HebrewCalendarValueLambda.GetDaysInYear(yearLambda, eraLambda));
}


public static IObservable<System.Int32> GetEra(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(HebrewCalendarValue, time, (HebrewCalendarValueLambda, timeLambda) => HebrewCalendarValueLambda.GetEra(timeLambda));
}


public static IObservable<System.Int32> GetMonth(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(HebrewCalendarValue, time, (HebrewCalendarValueLambda, timeLambda) => HebrewCalendarValueLambda.GetMonth(timeLambda));
}


public static IObservable<System.Int32> GetMonthsInYear(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
{
    return Observable.Zip(HebrewCalendarValue, year, era, (HebrewCalendarValueLambda, yearLambda, eraLambda) => HebrewCalendarValueLambda.GetMonthsInYear(yearLambda, eraLambda));
}


public static IObservable<System.Int32> GetYear(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(HebrewCalendarValue, time, (HebrewCalendarValueLambda, timeLambda) => HebrewCalendarValueLambda.GetYear(timeLambda));
}


public static IObservable<System.Boolean> IsLeapDay(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day, IObservable<System.Int32> era)
{
    return Observable.Zip(HebrewCalendarValue, year, month, day, era, (HebrewCalendarValueLambda, yearLambda, monthLambda, dayLambda, eraLambda) => HebrewCalendarValueLambda.IsLeapDay(yearLambda, monthLambda, dayLambda, eraLambda));
}


public static IObservable<System.Int32> GetLeapMonth(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
{
    return Observable.Zip(HebrewCalendarValue, year, era, (HebrewCalendarValueLambda, yearLambda, eraLambda) => HebrewCalendarValueLambda.GetLeapMonth(yearLambda, eraLambda));
}


public static IObservable<System.Boolean> IsLeapMonth(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> era)
{
    return Observable.Zip(HebrewCalendarValue, year, month, era, (HebrewCalendarValueLambda, yearLambda, monthLambda, eraLambda) => HebrewCalendarValueLambda.IsLeapMonth(yearLambda, monthLambda, eraLambda));
}


public static IObservable<System.Boolean> IsLeapYear(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
{
    return Observable.Zip(HebrewCalendarValue, year, era, (HebrewCalendarValueLambda, yearLambda, eraLambda) => HebrewCalendarValueLambda.IsLeapYear(yearLambda, eraLambda));
}


public static IObservable<System.DateTime> ToDateTime(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day, IObservable<System.Int32> hour, IObservable<System.Int32> minute, IObservable<System.Int32> second, IObservable<System.Int32> millisecond, IObservable<System.Int32> era)
{
    return Observable.Zip(HebrewCalendarValue, year, month, day, hour, minute, second, millisecond, era, (HebrewCalendarValueLambda, yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda, secondLambda, millisecondLambda, eraLambda) => HebrewCalendarValueLambda.ToDateTime(yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda, secondLambda, millisecondLambda, eraLambda));
}


public static IObservable<System.Int32> ToFourDigitYear(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue, IObservable<System.Int32> year)
{
    return Observable.Zip(HebrewCalendarValue, year, (HebrewCalendarValueLambda, yearLambda) => HebrewCalendarValueLambda.ToFourDigitYear(yearLambda));
}


public static IObservable<System.DateTime> get_MinSupportedDateTime(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue)
{
    return Observable.Select(HebrewCalendarValue, (HebrewCalendarValueLambda) => HebrewCalendarValueLambda.MinSupportedDateTime);
}


public static IObservable<System.DateTime> get_MaxSupportedDateTime(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue)
{
    return Observable.Select(HebrewCalendarValue, (HebrewCalendarValueLambda) => HebrewCalendarValueLambda.MaxSupportedDateTime);
}


public static IObservable<System.Globalization.CalendarAlgorithmType> get_AlgorithmType(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue)
{
    return Observable.Select(HebrewCalendarValue, (HebrewCalendarValueLambda) => HebrewCalendarValueLambda.AlgorithmType);
}


public static IObservable<System.Int32[]> get_Eras(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue)
{
    return Observable.Select(HebrewCalendarValue, (HebrewCalendarValueLambda) => HebrewCalendarValueLambda.Eras);
}


public static IObservable<System.Int32> get_TwoDigitYearMax(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue)
{
    return Observable.Select(HebrewCalendarValue, (HebrewCalendarValueLambda) => HebrewCalendarValueLambda.TwoDigitYearMax);
}


public static IObservable<System.Reactive.Unit> set_TwoDigitYearMax(this IObservable<System.Globalization.HebrewCalendar> HebrewCalendarValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(HebrewCalendarValue, value, (HebrewCalendarValueLambda, valueLambda) => HebrewCalendarValueLambda.TwoDigitYearMax = valueLambda);
}

}
}