using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __TaiwanLunisolarCalendar
    {
        
        public static IObservable<System.Int32> GetEra(this IObservable<System.Globalization.TaiwanLunisolarCalendar> TaiwanLunisolarCalendarValue, IObservable<System.DateTime> time)
        {
            return Observable.Zip(TaiwanLunisolarCalendarValue, time, (TaiwanLunisolarCalendarValueLambda, timeLambda) => TaiwanLunisolarCalendarValueLambda.GetEra(timeLambda));
        }


        public static IObservable<System.DateTime> get_MinSupportedDateTime(this IObservable<System.Globalization.TaiwanLunisolarCalendar> TaiwanLunisolarCalendarValue)
        {
            return Observable.Select(TaiwanLunisolarCalendarValue, (TaiwanLunisolarCalendarValueLambda) => TaiwanLunisolarCalendarValueLambda.MinSupportedDateTime);
        }


        public static IObservable<System.DateTime> get_MaxSupportedDateTime(this IObservable<System.Globalization.TaiwanLunisolarCalendar> TaiwanLunisolarCalendarValue)
        {
            return Observable.Select(TaiwanLunisolarCalendarValue, (TaiwanLunisolarCalendarValueLambda) => TaiwanLunisolarCalendarValueLambda.MaxSupportedDateTime);
        }


        public static IObservable<System.Int32[]> get_Eras(this IObservable<System.Globalization.TaiwanLunisolarCalendar> TaiwanLunisolarCalendarValue)
        {
            return Observable.Select(TaiwanLunisolarCalendarValue, (TaiwanLunisolarCalendarValueLambda) => TaiwanLunisolarCalendarValueLambda.Eras);
        }

    }
}