using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __ChineseLunisolarCalendar
    {
        public static IObservable<System.Int32> GetEra(
            this IObservable<System.Globalization.ChineseLunisolarCalendar> ChineseLunisolarCalendarValue,
            IObservable<System.DateTime> time)
        {
            return Observable.Zip(ChineseLunisolarCalendarValue, time,
                (ChineseLunisolarCalendarValueLambda, timeLambda) =>
                    ChineseLunisolarCalendarValueLambda.GetEra(timeLambda));
        }


        public static IObservable<System.DateTime> get_MinSupportedDateTime(
            this IObservable<System.Globalization.ChineseLunisolarCalendar> ChineseLunisolarCalendarValue)
        {
            return Observable.Select(ChineseLunisolarCalendarValue,
                (ChineseLunisolarCalendarValueLambda) => ChineseLunisolarCalendarValueLambda.MinSupportedDateTime);
        }


        public static IObservable<System.DateTime> get_MaxSupportedDateTime(
            this IObservable<System.Globalization.ChineseLunisolarCalendar> ChineseLunisolarCalendarValue)
        {
            return Observable.Select(ChineseLunisolarCalendarValue,
                (ChineseLunisolarCalendarValueLambda) => ChineseLunisolarCalendarValueLambda.MaxSupportedDateTime);
        }


        public static IObservable<System.Int32[]> get_Eras(
            this IObservable<System.Globalization.ChineseLunisolarCalendar> ChineseLunisolarCalendarValue)
        {
            return Observable.Select(ChineseLunisolarCalendarValue,
                (ChineseLunisolarCalendarValueLambda) => ChineseLunisolarCalendarValueLambda.Eras);
        }
    }
}