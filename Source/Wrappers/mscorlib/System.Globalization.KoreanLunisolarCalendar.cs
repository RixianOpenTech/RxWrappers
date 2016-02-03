using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
public static class _KoreanLunisolarCalendar
{
    
public static IObservable<System.Int32> GetEra(this IObservable<System.Globalization.KoreanLunisolarCalendar> KoreanLunisolarCalendarValue, IObservable<System.DateTime> time)
{
    return Observable.Zip(KoreanLunisolarCalendarValue, time, (KoreanLunisolarCalendarValueLambda, timeLambda) => KoreanLunisolarCalendarValueLambda.GetEra(timeLambda));
}


public static IObservable<System.DateTime> get_MinSupportedDateTime(this IObservable<System.Globalization.KoreanLunisolarCalendar> KoreanLunisolarCalendarValue)
{
    return Observable.Select(KoreanLunisolarCalendarValue, (KoreanLunisolarCalendarValueLambda) => KoreanLunisolarCalendarValueLambda.MinSupportedDateTime);
}


public static IObservable<System.DateTime> get_MaxSupportedDateTime(this IObservable<System.Globalization.KoreanLunisolarCalendar> KoreanLunisolarCalendarValue)
{
    return Observable.Select(KoreanLunisolarCalendarValue, (KoreanLunisolarCalendarValueLambda) => KoreanLunisolarCalendarValueLambda.MaxSupportedDateTime);
}


public static IObservable<System.Int32[]> get_Eras(this IObservable<System.Globalization.KoreanLunisolarCalendar> KoreanLunisolarCalendarValue)
{
    return Observable.Select(KoreanLunisolarCalendarValue, (KoreanLunisolarCalendarValueLambda) => KoreanLunisolarCalendarValueLambda.Eras);
}

}
}