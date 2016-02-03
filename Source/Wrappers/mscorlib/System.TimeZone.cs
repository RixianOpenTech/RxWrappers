using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __TimeZone
    {
        
        public static IObservable<System.TimeSpan> GetUtcOffset(this IObservable<System.TimeZone> TimeZoneValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(TimeZoneValue, time, (TimeZoneValueLambda, timeLambda) => TimeZoneValueLambda.GetUtcOffset(timeLambda));
        }


        public static IObservable<System.DateTime> ToUniversalTime(this IObservable<System.TimeZone> TimeZoneValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(TimeZoneValue, time, (TimeZoneValueLambda, timeLambda) => TimeZoneValueLambda.ToUniversalTime(timeLambda));
        }


        public static IObservable<System.DateTime> ToLocalTime(this IObservable<System.TimeZone> TimeZoneValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(TimeZoneValue, time, (TimeZoneValueLambda, timeLambda) => TimeZoneValueLambda.ToLocalTime(timeLambda));
        }


        public static IObservable<System.Globalization.DaylightTime> GetDaylightChanges(this IObservable<System.TimeZone> TimeZoneValue, IObservable<System.Int32> year)
        {
            return Observable.Zip(TimeZoneValue, year, (TimeZoneValueLambda, yearLambda) => TimeZoneValueLambda.GetDaylightChanges(yearLambda));
        }


        public static IObservable<System.Boolean> IsDaylightSavingTime(this IObservable<System.TimeZone> TimeZoneValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(TimeZoneValue, time, (TimeZoneValueLambda, timeLambda) => TimeZoneValueLambda.IsDaylightSavingTime(timeLambda));
        }


        public static IObservable<System.Boolean> IsDaylightSavingTime(IObservable<System.DateTime> time, IObservable<System.Globalization.DaylightTime> daylightTimes)
        {
            return Observable.Zip(time, daylightTimes, (timeLambda, daylightTimesLambda) => System.TimeZone.IsDaylightSavingTime(timeLambda, daylightTimesLambda));
        }


        public static IObservable<System.TimeZone> get_CurrentTimeZone()
        {
            return ObservableExt.Factory(() => System.TimeZone.CurrentTimeZone);
        }


        public static IObservable<System.String> get_StandardName(this IObservable<System.TimeZone> TimeZoneValue)
        {
            return Observable.Select(TimeZoneValue, (TimeZoneValueLambda) => TimeZoneValueLambda.StandardName);
        }


        public static IObservable<System.String> get_DaylightName(this IObservable<System.TimeZone> TimeZoneValue)
        {
            return Observable.Select(TimeZoneValue, (TimeZoneValueLambda) => TimeZoneValueLambda.DaylightName);
        }

    }
}