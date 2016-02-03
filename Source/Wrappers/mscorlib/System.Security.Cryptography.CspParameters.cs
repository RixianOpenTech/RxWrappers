using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _CspParameters
{
    
public static IObservable<System.Security.Cryptography.CspProviderFlags> get_Flags(this IObservable<System.Security.Cryptography.CspParameters> CspParametersValue)
{
    return Observable.Select(CspParametersValue, (CspParametersValueLambda) => CspParametersValueLambda.Flags);
}


public static IObservable<System.Security.AccessControl.CryptoKeySecurity> get_CryptoKeySecurity(this IObservable<System.Security.Cryptography.CspParameters> CspParametersValue)
{
    return Observable.Select(CspParametersValue, (CspParametersValueLambda) => CspParametersValueLambda.CryptoKeySecurity);
}


public static IObservable<System.Security.SecureString> get_KeyPassword(this IObservable<System.Security.Cryptography.CspParameters> CspParametersValue)
{
    return Observable.Select(CspParametersValue, (CspParametersValueLambda) => CspParametersValueLambda.KeyPassword);
}


public static IObservable<System.IntPtr> get_ParentWindowHandle(this IObservable<System.Security.Cryptography.CspParameters> CspParametersValue)
{
    return Observable.Select(CspParametersValue, (CspParametersValueLambda) => CspParametersValueLambda.ParentWindowHandle);
}


public static IObservable<System.Reactive.Unit> set_Flags(this IObservable<System.Security.Cryptography.CspParameters> CspParametersValue, IObservable<System.Security.Cryptography.CspProviderFlags> value)
{
    return ObservableExt.ZipExecute(CspParametersValue, value, (CspParametersValueLambda, valueLambda) => CspParametersValueLambda.Flags = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_CryptoKeySecurity(this IObservable<System.Security.Cryptography.CspParameters> CspParametersValue, IObservable<System.Security.AccessControl.CryptoKeySecurity> value)
{
    return ObservableExt.ZipExecute(CspParametersValue, value, (CspParametersValueLambda, valueLambda) => CspParametersValueLambda.CryptoKeySecurity = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_KeyPassword(this IObservable<System.Security.Cryptography.CspParameters> CspParametersValue, IObservable<System.Security.SecureString> value)
{
    return ObservableExt.ZipExecute(CspParametersValue, value, (CspParametersValueLambda, valueLambda) => CspParametersValueLambda.KeyPassword = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ParentWindowHandle(this IObservable<System.Security.Cryptography.CspParameters> CspParametersValue, IObservable<System.IntPtr> value)
{
    return ObservableExt.ZipExecute(CspParametersValue, value, (CspParametersValueLambda, valueLambda) => CspParametersValueLambda.ParentWindowHandle = valueLambda);
}

}
}