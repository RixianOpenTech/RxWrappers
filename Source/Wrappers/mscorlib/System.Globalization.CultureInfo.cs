using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
public static class _CultureInfo
{
    
public static IObservable<System.Globalization.CultureInfo> CreateSpecificCulture(IObservable<System.String> name)
{
    return Observable.Select(name, (nameLambda) => System.Globalization.CultureInfo.CreateSpecificCulture(nameLambda));
}


public static IObservable<System.Globalization.CultureInfo[]> GetCultures(IObservable<System.Globalization.CultureTypes> types)
{
    return Observable.Select(types, (typesLambda) => System.Globalization.CultureInfo.GetCultures(typesLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Globalization.CultureInfo> CultureInfoValue, IObservable<System.Object> value)
{
    return Observable.Zip(CultureInfoValue, value, (CultureInfoValueLambda, valueLambda) => CultureInfoValueLambda.Equals(valueLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.GetHashCode());
}


public static IObservable<System.String> ToString(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.ToString());
}


public static IObservable<System.Object> GetFormat(this IObservable<System.Globalization.CultureInfo> CultureInfoValue, IObservable<System.Type> formatType)
{
    return Observable.Zip(CultureInfoValue, formatType, (CultureInfoValueLambda, formatTypeLambda) => CultureInfoValueLambda.GetFormat(formatTypeLambda));
}


public static IObservable<System.Reactive.Unit> ClearCachedData(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Do(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.ClearCachedData()).ToUnit();
}


public static IObservable<System.Globalization.CultureInfo> GetConsoleFallbackUICulture(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.GetConsoleFallbackUICulture());
}


public static IObservable<System.Object> Clone(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.Clone());
}


public static IObservable<System.Globalization.CultureInfo> ReadOnly(IObservable<System.Globalization.CultureInfo> ci)
{
    return Observable.Select(ci, (ciLambda) => System.Globalization.CultureInfo.ReadOnly(ciLambda));
}


public static IObservable<System.Globalization.CultureInfo> GetCultureInfo(IObservable<System.Int32> culture)
{
    return Observable.Select(culture, (cultureLambda) => System.Globalization.CultureInfo.GetCultureInfo(cultureLambda));
}


public static IObservable<System.Globalization.CultureInfo> GetCultureInfo(IObservable<System.String> name)
{
    return Observable.Select(name, (nameLambda) => System.Globalization.CultureInfo.GetCultureInfo(nameLambda));
}


public static IObservable<System.Globalization.CultureInfo> GetCultureInfo(IObservable<System.String> name, IObservable<System.String> altName)
{
    return Observable.Zip(name, altName, (nameLambda, altNameLambda) => System.Globalization.CultureInfo.GetCultureInfo(nameLambda, altNameLambda));
}


public static IObservable<System.Globalization.CultureInfo> GetCultureInfoByIetfLanguageTag(IObservable<System.String> name)
{
    return Observable.Select(name, (nameLambda) => System.Globalization.CultureInfo.GetCultureInfoByIetfLanguageTag(nameLambda));
}


public static IObservable<System.Globalization.CultureInfo> get_CurrentCulture()
{
    return ObservableExt.Factory(() => System.Globalization.CultureInfo.CurrentCulture);
}


public static IObservable<System.Globalization.CultureInfo> get_CurrentUICulture()
{
    return ObservableExt.Factory(() => System.Globalization.CultureInfo.CurrentUICulture);
}


public static IObservable<System.Globalization.CultureInfo> get_InstalledUICulture()
{
    return ObservableExt.Factory(() => System.Globalization.CultureInfo.InstalledUICulture);
}


public static IObservable<System.Globalization.CultureInfo> get_DefaultThreadCurrentCulture()
{
    return ObservableExt.Factory(() => System.Globalization.CultureInfo.DefaultThreadCurrentCulture);
}


public static IObservable<System.Globalization.CultureInfo> get_DefaultThreadCurrentUICulture()
{
    return ObservableExt.Factory(() => System.Globalization.CultureInfo.DefaultThreadCurrentUICulture);
}


public static IObservable<System.Globalization.CultureInfo> get_InvariantCulture()
{
    return ObservableExt.Factory(() => System.Globalization.CultureInfo.InvariantCulture);
}


public static IObservable<System.Globalization.CultureInfo> get_Parent(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.Parent);
}


public static IObservable<System.Int32> get_LCID(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.LCID);
}


public static IObservable<System.Int32> get_KeyboardLayoutId(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.KeyboardLayoutId);
}


public static IObservable<System.String> get_Name(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.Name);
}


public static IObservable<System.String> get_IetfLanguageTag(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.IetfLanguageTag);
}


public static IObservable<System.String> get_DisplayName(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.DisplayName);
}


public static IObservable<System.String> get_NativeName(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.NativeName);
}


public static IObservable<System.String> get_EnglishName(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.EnglishName);
}


public static IObservable<System.String> get_TwoLetterISOLanguageName(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.TwoLetterISOLanguageName);
}


public static IObservable<System.String> get_ThreeLetterISOLanguageName(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.ThreeLetterISOLanguageName);
}


public static IObservable<System.String> get_ThreeLetterWindowsLanguageName(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.ThreeLetterWindowsLanguageName);
}


public static IObservable<System.Globalization.CompareInfo> get_CompareInfo(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.CompareInfo);
}


public static IObservable<System.Globalization.TextInfo> get_TextInfo(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.TextInfo);
}


public static IObservable<System.Boolean> get_IsNeutralCulture(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.IsNeutralCulture);
}


public static IObservable<System.Globalization.CultureTypes> get_CultureTypes(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.CultureTypes);
}


public static IObservable<System.Globalization.NumberFormatInfo> get_NumberFormat(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.NumberFormat);
}


public static IObservable<System.Globalization.DateTimeFormatInfo> get_DateTimeFormat(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.DateTimeFormat);
}


public static IObservable<System.Globalization.Calendar> get_Calendar(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.Calendar);
}


public static IObservable<System.Globalization.Calendar[]> get_OptionalCalendars(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.OptionalCalendars);
}


public static IObservable<System.Boolean> get_UseUserOverride(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.UseUserOverride);
}


public static IObservable<System.Boolean> get_IsReadOnly(this IObservable<System.Globalization.CultureInfo> CultureInfoValue)
{
    return Observable.Select(CultureInfoValue, (CultureInfoValueLambda) => CultureInfoValueLambda.IsReadOnly);
}


public static IObservable<System.Reactive.Unit> set_CurrentCulture(IObservable<System.Globalization.CultureInfo> value)
{
    return Observable.Do(value, (valueLambda) => System.Globalization.CultureInfo.CurrentCulture = valueLambda).ToUnit();
}


public static IObservable<System.Reactive.Unit> set_CurrentUICulture(IObservable<System.Globalization.CultureInfo> value)
{
    return Observable.Do(value, (valueLambda) => System.Globalization.CultureInfo.CurrentUICulture = valueLambda).ToUnit();
}


public static IObservable<System.Reactive.Unit> set_DefaultThreadCurrentCulture(IObservable<System.Globalization.CultureInfo> value)
{
    return Observable.Do(value, (valueLambda) => System.Globalization.CultureInfo.DefaultThreadCurrentCulture = valueLambda).ToUnit();
}


public static IObservable<System.Reactive.Unit> set_DefaultThreadCurrentUICulture(IObservable<System.Globalization.CultureInfo> value)
{
    return Observable.Do(value, (valueLambda) => System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = valueLambda).ToUnit();
}


public static IObservable<System.Reactive.Unit> set_NumberFormat(this IObservable<System.Globalization.CultureInfo> CultureInfoValue, IObservable<System.Globalization.NumberFormatInfo> value)
{
    return ObservableExt.ZipExecute(CultureInfoValue, value, (CultureInfoValueLambda, valueLambda) => CultureInfoValueLambda.NumberFormat = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_DateTimeFormat(this IObservable<System.Globalization.CultureInfo> CultureInfoValue, IObservable<System.Globalization.DateTimeFormatInfo> value)
{
    return ObservableExt.ZipExecute(CultureInfoValue, value, (CultureInfoValueLambda, valueLambda) => CultureInfoValueLambda.DateTimeFormat = valueLambda);
}

}
}