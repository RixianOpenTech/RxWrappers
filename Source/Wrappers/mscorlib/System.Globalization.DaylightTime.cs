using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __DaylightTime
    {
        public static IObservable<System.DateTime> get_Start(
            this IObservable<System.Globalization.DaylightTime> DaylightTimeValue)
        {
            return Observable.Select(DaylightTimeValue, (DaylightTimeValueLambda) => DaylightTimeValueLambda.Start);
        }


        public static IObservable<System.DateTime> get_End(
            this IObservable<System.Globalization.DaylightTime> DaylightTimeValue)
        {
            return Observable.Select(DaylightTimeValue, (DaylightTimeValueLambda) => DaylightTimeValueLambda.End);
        }


        public static IObservable<System.TimeSpan> get_Delta(
            this IObservable<System.Globalization.DaylightTime> DaylightTimeValue)
        {
            return Observable.Select(DaylightTimeValue, (DaylightTimeValueLambda) => DaylightTimeValueLambda.Delta);
        }
    }
}