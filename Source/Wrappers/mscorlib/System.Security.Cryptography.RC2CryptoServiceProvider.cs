using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _RC2CryptoServiceProvider
{
    
public static IObservable<System.Security.Cryptography.ICryptoTransform> CreateEncryptor(this IObservable<System.Security.Cryptography.RC2CryptoServiceProvider> RC2CryptoServiceProviderValue, IObservable<System.Byte[]> rgbKey, IObservable<System.Byte[]> rgbIV)
{
    return Observable.Zip(RC2CryptoServiceProviderValue, rgbKey, rgbIV, (RC2CryptoServiceProviderValueLambda, rgbKeyLambda, rgbIVLambda) => RC2CryptoServiceProviderValueLambda.CreateEncryptor(rgbKeyLambda, rgbIVLambda));
}


public static IObservable<System.Security.Cryptography.ICryptoTransform> CreateDecryptor(this IObservable<System.Security.Cryptography.RC2CryptoServiceProvider> RC2CryptoServiceProviderValue, IObservable<System.Byte[]> rgbKey, IObservable<System.Byte[]> rgbIV)
{
    return Observable.Zip(RC2CryptoServiceProviderValue, rgbKey, rgbIV, (RC2CryptoServiceProviderValueLambda, rgbKeyLambda, rgbIVLambda) => RC2CryptoServiceProviderValueLambda.CreateDecryptor(rgbKeyLambda, rgbIVLambda));
}


public static IObservable<System.Reactive.Unit> GenerateKey(this IObservable<System.Security.Cryptography.RC2CryptoServiceProvider> RC2CryptoServiceProviderValue)
{
    return Observable.Do(RC2CryptoServiceProviderValue, (RC2CryptoServiceProviderValueLambda) => RC2CryptoServiceProviderValueLambda.GenerateKey()).ToUnit();
}


public static IObservable<System.Reactive.Unit> GenerateIV(this IObservable<System.Security.Cryptography.RC2CryptoServiceProvider> RC2CryptoServiceProviderValue)
{
    return Observable.Do(RC2CryptoServiceProviderValue, (RC2CryptoServiceProviderValueLambda) => RC2CryptoServiceProviderValueLambda.GenerateIV()).ToUnit();
}


public static IObservable<System.Int32> get_EffectiveKeySize(this IObservable<System.Security.Cryptography.RC2CryptoServiceProvider> RC2CryptoServiceProviderValue)
{
    return Observable.Select(RC2CryptoServiceProviderValue, (RC2CryptoServiceProviderValueLambda) => RC2CryptoServiceProviderValueLambda.EffectiveKeySize);
}


public static IObservable<System.Boolean> get_UseSalt(this IObservable<System.Security.Cryptography.RC2CryptoServiceProvider> RC2CryptoServiceProviderValue)
{
    return Observable.Select(RC2CryptoServiceProviderValue, (RC2CryptoServiceProviderValueLambda) => RC2CryptoServiceProviderValueLambda.UseSalt);
}


public static IObservable<System.Reactive.Unit> set_EffectiveKeySize(this IObservable<System.Security.Cryptography.RC2CryptoServiceProvider> RC2CryptoServiceProviderValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(RC2CryptoServiceProviderValue, value, (RC2CryptoServiceProviderValueLambda, valueLambda) => RC2CryptoServiceProviderValueLambda.EffectiveKeySize = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_UseSalt(this IObservable<System.Security.Cryptography.RC2CryptoServiceProvider> RC2CryptoServiceProviderValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(RC2CryptoServiceProviderValue, value, (RC2CryptoServiceProviderValueLambda, valueLambda) => RC2CryptoServiceProviderValueLambda.UseSalt = valueLambda);
}

}
}