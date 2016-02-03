using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __TransitionTime
    {
        
        public static IObservable<System.Boolean> Equals(this IObservable<System.TimeZoneInfo.TransitionTime> TransitionTimeValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(TransitionTimeValue, obj, (TransitionTimeValueLambda, objLambda) => TransitionTimeValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.TimeZoneInfo.TransitionTime> TransitionTimeValue, IObservable<System.TimeZoneInfo.TransitionTime> other)
        {
            return Observable.Zip(TransitionTimeValue, other, (TransitionTimeValueLambda, otherLambda) => TransitionTimeValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.TimeZoneInfo.TransitionTime> TransitionTimeValue)
        {
            return Observable.Select(TransitionTimeValue, (TransitionTimeValueLambda) => TransitionTimeValueLambda.GetHashCode());
        }


        public static IObservable<System.TimeZoneInfo.TransitionTime> CreateFixedDateRule(IObservable<System.DateTime> timeOfDay, IObservable<System.Int32> month, IObservable<System.Int32> day)
        {
            return Observable.Zip(timeOfDay, month, day, (timeOfDayLambda, monthLambda, dayLambda) => System.TimeZoneInfo.TransitionTime.CreateFixedDateRule(timeOfDayLambda, monthLambda, dayLambda));
        }


        public static IObservable<System.TimeZoneInfo.TransitionTime> CreateFloatingDateRule(IObservable<System.DateTime> timeOfDay, IObservable<System.Int32> month, IObservable<System.Int32> week, IObservable<System.DayOfWeek> dayOfWeek)
        {
            return Observable.Zip(timeOfDay, month, week, dayOfWeek, (timeOfDayLambda, monthLambda, weekLambda, dayOfWeekLambda) => System.TimeZoneInfo.TransitionTime.CreateFloatingDateRule(timeOfDayLambda, monthLambda, weekLambda, dayOfWeekLambda));
        }


        public static IObservable<System.DateTime> get_TimeOfDay(this IObservable<System.TimeZoneInfo.TransitionTime> TransitionTimeValue)
        {
            return Observable.Select(TransitionTimeValue, (TransitionTimeValueLambda) => TransitionTimeValueLambda.TimeOfDay);
        }


        public static IObservable<System.Int32> get_Month(this IObservable<System.TimeZoneInfo.TransitionTime> TransitionTimeValue)
        {
            return Observable.Select(TransitionTimeValue, (TransitionTimeValueLambda) => TransitionTimeValueLambda.Month);
        }


        public static IObservable<System.Int32> get_Week(this IObservable<System.TimeZoneInfo.TransitionTime> TransitionTimeValue)
        {
            return Observable.Select(TransitionTimeValue, (TransitionTimeValueLambda) => TransitionTimeValueLambda.Week);
        }


        public static IObservable<System.Int32> get_Day(this IObservable<System.TimeZoneInfo.TransitionTime> TransitionTimeValue)
        {
            return Observable.Select(TransitionTimeValue, (TransitionTimeValueLambda) => TransitionTimeValueLambda.Day);
        }


        public static IObservable<System.DayOfWeek> get_DayOfWeek(this IObservable<System.TimeZoneInfo.TransitionTime> TransitionTimeValue)
        {
            return Observable.Select(TransitionTimeValue, (TransitionTimeValueLambda) => TransitionTimeValueLambda.DayOfWeek);
        }


        public static IObservable<System.Boolean> get_IsFixedDateRule(this IObservable<System.TimeZoneInfo.TransitionTime> TransitionTimeValue)
        {
            return Observable.Select(TransitionTimeValue, (TransitionTimeValueLambda) => TransitionTimeValueLambda.IsFixedDateRule);
        }

    }
}