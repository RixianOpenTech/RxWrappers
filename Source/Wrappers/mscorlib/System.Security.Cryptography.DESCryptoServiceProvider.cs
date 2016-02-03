using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _DESCryptoServiceProvider
{
    
public static IObservable<System.Security.Cryptography.ICryptoTransform> CreateEncryptor(this IObservable<System.Security.Cryptography.DESCryptoServiceProvider> DESCryptoServiceProviderValue, IObservable<System.Byte[]> rgbKey, IObservable<System.Byte[]> rgbIV)
{
    return Observable.Zip(DESCryptoServiceProviderValue, rgbKey, rgbIV, (DESCryptoServiceProviderValueLambda, rgbKeyLambda, rgbIVLambda) => DESCryptoServiceProviderValueLambda.CreateEncryptor(rgbKeyLambda, rgbIVLambda));
}


public static IObservable<System.Security.Cryptography.ICryptoTransform> CreateDecryptor(this IObservable<System.Security.Cryptography.DESCryptoServiceProvider> DESCryptoServiceProviderValue, IObservable<System.Byte[]> rgbKey, IObservable<System.Byte[]> rgbIV)
{
    return Observable.Zip(DESCryptoServiceProviderValue, rgbKey, rgbIV, (DESCryptoServiceProviderValueLambda, rgbKeyLambda, rgbIVLambda) => DESCryptoServiceProviderValueLambda.CreateDecryptor(rgbKeyLambda, rgbIVLambda));
}


public static IObservable<System.Reactive.Unit> GenerateKey(this IObservable<System.Security.Cryptography.DESCryptoServiceProvider> DESCryptoServiceProviderValue)
{
    return Observable.Do(DESCryptoServiceProviderValue, (DESCryptoServiceProviderValueLambda) => DESCryptoServiceProviderValueLambda.GenerateKey()).ToUnit();
}


public static IObservable<System.Reactive.Unit> GenerateIV(this IObservable<System.Security.Cryptography.DESCryptoServiceProvider> DESCryptoServiceProviderValue)
{
    return Observable.Do(DESCryptoServiceProviderValue, (DESCryptoServiceProviderValueLambda) => DESCryptoServiceProviderValueLambda.GenerateIV()).ToUnit();
}

}
}