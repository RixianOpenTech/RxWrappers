using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
public static class _RegionInfo
{
    
public static IObservable<System.Boolean> Equals(this IObservable<System.Globalization.RegionInfo> RegionInfoValue, IObservable<System.Object> value)
{
    return Observable.Zip(RegionInfoValue, value, (RegionInfoValueLambda, valueLambda) => RegionInfoValueLambda.Equals(valueLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Globalization.RegionInfo> RegionInfoValue)
{
    return Observable.Select(RegionInfoValue, (RegionInfoValueLambda) => RegionInfoValueLambda.GetHashCode());
}


public static IObservable<System.String> ToString(this IObservable<System.Globalization.RegionInfo> RegionInfoValue)
{
    return Observable.Select(RegionInfoValue, (RegionInfoValueLambda) => RegionInfoValueLambda.ToString());
}


public static IObservable<System.Globalization.RegionInfo> get_CurrentRegion()
{
    return ObservableExt.Factory(() => System.Globalization.RegionInfo.CurrentRegion);
}


public static IObservable<System.String> get_Name(this IObservable<System.Globalization.RegionInfo> RegionInfoValue)
{
    return Observable.Select(RegionInfoValue, (RegionInfoValueLambda) => RegionInfoValueLambda.Name);
}


public static IObservable<System.String> get_EnglishName(this IObservable<System.Globalization.RegionInfo> RegionInfoValue)
{
    return Observable.Select(RegionInfoValue, (RegionInfoValueLambda) => RegionInfoValueLambda.EnglishName);
}


public static IObservable<System.String> get_DisplayName(this IObservable<System.Globalization.RegionInfo> RegionInfoValue)
{
    return Observable.Select(RegionInfoValue, (RegionInfoValueLambda) => RegionInfoValueLambda.DisplayName);
}


public static IObservable<System.String> get_NativeName(this IObservable<System.Globalization.RegionInfo> RegionInfoValue)
{
    return Observable.Select(RegionInfoValue, (RegionInfoValueLambda) => RegionInfoValueLambda.NativeName);
}


public static IObservable<System.String> get_TwoLetterISORegionName(this IObservable<System.Globalization.RegionInfo> RegionInfoValue)
{
    return Observable.Select(RegionInfoValue, (RegionInfoValueLambda) => RegionInfoValueLambda.TwoLetterISORegionName);
}


public static IObservable<System.String> get_ThreeLetterISORegionName(this IObservable<System.Globalization.RegionInfo> RegionInfoValue)
{
    return Observable.Select(RegionInfoValue, (RegionInfoValueLambda) => RegionInfoValueLambda.ThreeLetterISORegionName);
}


public static IObservable<System.String> get_ThreeLetterWindowsRegionName(this IObservable<System.Globalization.RegionInfo> RegionInfoValue)
{
    return Observable.Select(RegionInfoValue, (RegionInfoValueLambda) => RegionInfoValueLambda.ThreeLetterWindowsRegionName);
}


public static IObservable<System.Boolean> get_IsMetric(this IObservable<System.Globalization.RegionInfo> RegionInfoValue)
{
    return Observable.Select(RegionInfoValue, (RegionInfoValueLambda) => RegionInfoValueLambda.IsMetric);
}


public static IObservable<System.Int32> get_GeoId(this IObservable<System.Globalization.RegionInfo> RegionInfoValue)
{
    return Observable.Select(RegionInfoValue, (RegionInfoValueLambda) => RegionInfoValueLambda.GeoId);
}


public static IObservable<System.String> get_CurrencyEnglishName(this IObservable<System.Globalization.RegionInfo> RegionInfoValue)
{
    return Observable.Select(RegionInfoValue, (RegionInfoValueLambda) => RegionInfoValueLambda.CurrencyEnglishName);
}


public static IObservable<System.String> get_CurrencyNativeName(this IObservable<System.Globalization.RegionInfo> RegionInfoValue)
{
    return Observable.Select(RegionInfoValue, (RegionInfoValueLambda) => RegionInfoValueLambda.CurrencyNativeName);
}


public static IObservable<System.String> get_CurrencySymbol(this IObservable<System.Globalization.RegionInfo> RegionInfoValue)
{
    return Observable.Select(RegionInfoValue, (RegionInfoValueLambda) => RegionInfoValueLambda.CurrencySymbol);
}


public static IObservable<System.String> get_ISOCurrencySymbol(this IObservable<System.Globalization.RegionInfo> RegionInfoValue)
{
    return Observable.Select(RegionInfoValue, (RegionInfoValueLambda) => RegionInfoValueLambda.ISOCurrencySymbol);
}

}
}