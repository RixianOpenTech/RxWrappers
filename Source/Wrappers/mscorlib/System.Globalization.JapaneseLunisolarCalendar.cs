using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
public static class _JapaneseLunisolarCalendar
{
    
public static IObservable<System.Int32> GetEra(this IObservable<System.Globalization.JapaneseLunisolarCalendar> JapaneseLunisolarCalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(JapaneseLunisolarCalendarValue, time, (JapaneseLunisolarCalendarValueLambda, timeLambda) => JapaneseLunisolarCalendarValueLambda.GetEra(timeLambda));
}


public static IObservable<System.DateTime> get_MinSupportedDateTime(this IObservable<System.Globalization.JapaneseLunisolarCalendar> JapaneseLunisolarCalendarValue)
{
    return Observable.Select(JapaneseLunisolarCalendarValue, (JapaneseLunisolarCalendarValueLambda) => JapaneseLunisolarCalendarValueLambda.MinSupportedDateTime);
}


public static IObservable<System.DateTime> get_MaxSupportedDateTime(this IObservable<System.Globalization.JapaneseLunisolarCalendar> JapaneseLunisolarCalendarValue)
{
    return Observable.Select(JapaneseLunisolarCalendarValue, (JapaneseLunisolarCalendarValueLambda) => JapaneseLunisolarCalendarValueLambda.MaxSupportedDateTime);
}


public static IObservable<System.Int32[]> get_Eras(this IObservable<System.Globalization.JapaneseLunisolarCalendar> JapaneseLunisolarCalendarValue)
{
    return Observable.Select(JapaneseLunisolarCalendarValue, (JapaneseLunisolarCalendarValueLambda) => JapaneseLunisolarCalendarValueLambda.Eras);
}

}
}