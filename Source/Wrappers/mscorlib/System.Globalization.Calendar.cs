using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
public static class _Calendar
{
    
public static IObservable<System.Object> Clone(this IObservable<System.Globalization.Calendar> CalendarValue)
{
    return Observable.Select(CalendarValue, (CalendarValueLambda) => CalendarValueLambda.Clone());
}


public static IObservable<System.Globalization.Calendar> ReadOnly(IObservable<System.Globalization.Calendar> calendar)
{
    return Observable.Select(calendar, (calendarLambda) => System.Globalization.Calendar.ReadOnly(calendarLambda));
}


public static IObservable<System.DateTime> AddMilliseconds(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.DateTime> time, IObservable<System.Double> milliseconds)
{
    return Observable.Zip(CalendarValue, time, milliseconds, (CalendarValueLambda, timeLambda, millisecondsLambda) => CalendarValueLambda.AddMilliseconds(timeLambda, millisecondsLambda));
}


public static IObservable<System.DateTime> AddDays(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.DateTime> time, IObservable<System.Int32> days)
{
    return Observable.Zip(CalendarValue, time, days, (CalendarValueLambda, timeLambda, daysLambda) => CalendarValueLambda.AddDays(timeLambda, daysLambda));
}


public static IObservable<System.DateTime> AddHours(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.DateTime> time, IObservable<System.Int32> hours)
{
    return Observable.Zip(CalendarValue, time, hours, (CalendarValueLambda, timeLambda, hoursLambda) => CalendarValueLambda.AddHours(timeLambda, hoursLambda));
}


public static IObservable<System.DateTime> AddMinutes(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.DateTime> time, IObservable<System.Int32> minutes)
{
    return Observable.Zip(CalendarValue, time, minutes, (CalendarValueLambda, timeLambda, minutesLambda) => CalendarValueLambda.AddMinutes(timeLambda, minutesLambda));
}


public static IObservable<System.DateTime> AddMonths(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.DateTime> time, IObservable<System.Int32> months)
{
    return Observable.Zip(CalendarValue, time, months, (CalendarValueLambda, timeLambda, monthsLambda) => CalendarValueLambda.AddMonths(timeLambda, monthsLambda));
}


public static IObservable<System.DateTime> AddSeconds(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.DateTime> time, IObservable<System.Int32> seconds)
{
    return Observable.Zip(CalendarValue, time, seconds, (CalendarValueLambda, timeLambda, secondsLambda) => CalendarValueLambda.AddSeconds(timeLambda, secondsLambda));
}


public static IObservable<System.DateTime> AddWeeks(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.DateTime> time, IObservable<System.Int32> weeks)
{
    return Observable.Zip(CalendarValue, time, weeks, (CalendarValueLambda, timeLambda, weeksLambda) => CalendarValueLambda.AddWeeks(timeLambda, weeksLambda));
}


public static IObservable<System.DateTime> AddYears(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.DateTime> time, IObservable<System.Int32> years)
{
    return Observable.Zip(CalendarValue, time, years, (CalendarValueLambda, timeLambda, yearsLambda) => CalendarValueLambda.AddYears(timeLambda, yearsLambda));
}


public static IObservable<System.Int32> GetDayOfMonth(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(CalendarValue, time, (CalendarValueLambda, timeLambda) => CalendarValueLambda.GetDayOfMonth(timeLambda));
}


public static IObservable<System.DayOfWeek> GetDayOfWeek(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(CalendarValue, time, (CalendarValueLambda, timeLambda) => CalendarValueLambda.GetDayOfWeek(timeLambda));
}


public static IObservable<System.Int32> GetDayOfYear(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(CalendarValue, time, (CalendarValueLambda, timeLambda) => CalendarValueLambda.GetDayOfYear(timeLambda));
}


public static IObservable<System.Int32> GetDaysInMonth(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month)
{
    return Observable.Zip(CalendarValue, year, month, (CalendarValueLambda, yearLambda, monthLambda) => CalendarValueLambda.GetDaysInMonth(yearLambda, monthLambda));
}


public static IObservable<System.Int32> GetDaysInMonth(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> era)
{
    return Observable.Zip(CalendarValue, year, month, era, (CalendarValueLambda, yearLambda, monthLambda, eraLambda) => CalendarValueLambda.GetDaysInMonth(yearLambda, monthLambda, eraLambda));
}


public static IObservable<System.Int32> GetDaysInYear(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.Int32> year)
{
    return Observable.Zip(CalendarValue, year, (CalendarValueLambda, yearLambda) => CalendarValueLambda.GetDaysInYear(yearLambda));
}


public static IObservable<System.Int32> GetDaysInYear(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
{
    return Observable.Zip(CalendarValue, year, era, (CalendarValueLambda, yearLambda, eraLambda) => CalendarValueLambda.GetDaysInYear(yearLambda, eraLambda));
}


public static IObservable<System.Int32> GetEra(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(CalendarValue, time, (CalendarValueLambda, timeLambda) => CalendarValueLambda.GetEra(timeLambda));
}


public static IObservable<System.Int32> GetHour(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(CalendarValue, time, (CalendarValueLambda, timeLambda) => CalendarValueLambda.GetHour(timeLambda));
}


public static IObservable<System.Double> GetMilliseconds(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(CalendarValue, time, (CalendarValueLambda, timeLambda) => CalendarValueLambda.GetMilliseconds(timeLambda));
}


public static IObservable<System.Int32> GetMinute(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(CalendarValue, time, (CalendarValueLambda, timeLambda) => CalendarValueLambda.GetMinute(timeLambda));
}


public static IObservable<System.Int32> GetMonth(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(CalendarValue, time, (CalendarValueLambda, timeLambda) => CalendarValueLambda.GetMonth(timeLambda));
}


public static IObservable<System.Int32> GetMonthsInYear(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.Int32> year)
{
    return Observable.Zip(CalendarValue, year, (CalendarValueLambda, yearLambda) => CalendarValueLambda.GetMonthsInYear(yearLambda));
}


public static IObservable<System.Int32> GetMonthsInYear(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
{
    return Observable.Zip(CalendarValue, year, era, (CalendarValueLambda, yearLambda, eraLambda) => CalendarValueLambda.GetMonthsInYear(yearLambda, eraLambda));
}


public static IObservable<System.Int32> GetSecond(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(CalendarValue, time, (CalendarValueLambda, timeLambda) => CalendarValueLambda.GetSecond(timeLambda));
}


public static IObservable<System.Int32> GetWeekOfYear(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.DateTime> time, IObservable<System.Globalization.CalendarWeekRule> rule, IObservable<System.DayOfWeek> firstDayOfWeek)
{
    return Observable.Zip(CalendarValue, time, rule, firstDayOfWeek, (CalendarValueLambda, timeLambda, ruleLambda, firstDayOfWeekLambda) => CalendarValueLambda.GetWeekOfYear(timeLambda, ruleLambda, firstDayOfWeekLambda));
}


public static IObservable<System.Int32> GetYear(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(CalendarValue, time, (CalendarValueLambda, timeLambda) => CalendarValueLambda.GetYear(timeLambda));
}


public static IObservable<System.Boolean> IsLeapDay(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day)
{
    return Observable.Zip(CalendarValue, year, month, day, (CalendarValueLambda, yearLambda, monthLambda, dayLambda) => CalendarValueLambda.IsLeapDay(yearLambda, monthLambda, dayLambda));
}


public static IObservable<System.Boolean> IsLeapDay(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day, IObservable<System.Int32> era)
{
    return Observable.Zip(CalendarValue, year, month, day, era, (CalendarValueLambda, yearLambda, monthLambda, dayLambda, eraLambda) => CalendarValueLambda.IsLeapDay(yearLambda, monthLambda, dayLambda, eraLambda));
}


public static IObservable<System.Boolean> IsLeapMonth(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month)
{
    return Observable.Zip(CalendarValue, year, month, (CalendarValueLambda, yearLambda, monthLambda) => CalendarValueLambda.IsLeapMonth(yearLambda, monthLambda));
}


public static IObservable<System.Boolean> IsLeapMonth(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> era)
{
    return Observable.Zip(CalendarValue, year, month, era, (CalendarValueLambda, yearLambda, monthLambda, eraLambda) => CalendarValueLambda.IsLeapMonth(yearLambda, monthLambda, eraLambda));
}


public static IObservable<System.Int32> GetLeapMonth(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.Int32> year)
{
    return Observable.Zip(CalendarValue, year, (CalendarValueLambda, yearLambda) => CalendarValueLambda.GetLeapMonth(yearLambda));
}


public static IObservable<System.Int32> GetLeapMonth(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
{
    return Observable.Zip(CalendarValue, year, era, (CalendarValueLambda, yearLambda, eraLambda) => CalendarValueLambda.GetLeapMonth(yearLambda, eraLambda));
}


public static IObservable<System.Boolean> IsLeapYear(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.Int32> year)
{
    return Observable.Zip(CalendarValue, year, (CalendarValueLambda, yearLambda) => CalendarValueLambda.IsLeapYear(yearLambda));
}


public static IObservable<System.Boolean> IsLeapYear(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> era)
{
    return Observable.Zip(CalendarValue, year, era, (CalendarValueLambda, yearLambda, eraLambda) => CalendarValueLambda.IsLeapYear(yearLambda, eraLambda));
}


public static IObservable<System.DateTime> ToDateTime(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day, IObservable<System.Int32> hour, IObservable<System.Int32> minute, IObservable<System.Int32> second, IObservable<System.Int32> millisecond)
{
    return Observable.Zip(CalendarValue, year, month, day, hour, minute, second, millisecond, (CalendarValueLambda, yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda, secondLambda, millisecondLambda) => CalendarValueLambda.ToDateTime(yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda, secondLambda, millisecondLambda));
}


public static IObservable<System.DateTime> ToDateTime(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.Int32> year, IObservable<System.Int32> month, IObservable<System.Int32> day, IObservable<System.Int32> hour, IObservable<System.Int32> minute, IObservable<System.Int32> second, IObservable<System.Int32> millisecond, IObservable<System.Int32> era)
{
    return Observable.Zip(CalendarValue, year, month, day, hour, minute, second, millisecond, era, (CalendarValueLambda, yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda, secondLambda, millisecondLambda, eraLambda) => CalendarValueLambda.ToDateTime(yearLambda, monthLambda, dayLambda, hourLambda, minuteLambda, secondLambda, millisecondLambda, eraLambda));
}


public static IObservable<System.Int32> ToFourDigitYear(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.Int32> year)
{
    return Observable.Zip(CalendarValue, year, (CalendarValueLambda, yearLambda) => CalendarValueLambda.ToFourDigitYear(yearLambda));
}


public static IObservable<System.DateTime> get_MinSupportedDateTime(this IObservable<System.Globalization.Calendar> CalendarValue)
{
    return Observable.Select(CalendarValue, (CalendarValueLambda) => CalendarValueLambda.MinSupportedDateTime);
}


public static IObservable<System.DateTime> get_MaxSupportedDateTime(this IObservable<System.Globalization.Calendar> CalendarValue)
{
    return Observable.Select(CalendarValue, (CalendarValueLambda) => CalendarValueLambda.MaxSupportedDateTime);
}


public static IObservable<System.Globalization.CalendarAlgorithmType> get_AlgorithmType(this IObservable<System.Globalization.Calendar> CalendarValue)
{
    return Observable.Select(CalendarValue, (CalendarValueLambda) => CalendarValueLambda.AlgorithmType);
}


public static IObservable<System.Boolean> get_IsReadOnly(this IObservable<System.Globalization.Calendar> CalendarValue)
{
    return Observable.Select(CalendarValue, (CalendarValueLambda) => CalendarValueLambda.IsReadOnly);
}


public static IObservable<System.Int32[]> get_Eras(this IObservable<System.Globalization.Calendar> CalendarValue)
{
    return Observable.Select(CalendarValue, (CalendarValueLambda) => CalendarValueLambda.Eras);
}


public static IObservable<System.Int32> get_TwoDigitYearMax(this IObservable<System.Globalization.Calendar> CalendarValue)
{
    return Observable.Select(CalendarValue, (CalendarValueLambda) => CalendarValueLambda.TwoDigitYearMax);
}


public static IObservable<System.Reactive.Unit> set_TwoDigitYearMax(this IObservable<System.Globalization.Calendar> CalendarValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(CalendarValue, value, (CalendarValueLambda, valueLambda) => CalendarValueLambda.TwoDigitYearMax = valueLambda);
}

}
}