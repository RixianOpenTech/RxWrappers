using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _RNGCryptoServiceProvider
{
    
public static IObservable<System.Reactive.Unit> GetBytes(this IObservable<System.Security.Cryptography.RNGCryptoServiceProvider> RNGCryptoServiceProviderValue, IObservable<System.Byte[]> data)
{
    return ObservableExt.ZipExecute(RNGCryptoServiceProviderValue, data, (RNGCryptoServiceProviderValueLambda, dataLambda) => RNGCryptoServiceProviderValueLambda.GetBytes(dataLambda));
}


public static IObservable<System.Reactive.Unit> GetNonZeroBytes(this IObservable<System.Security.Cryptography.RNGCryptoServiceProvider> RNGCryptoServiceProviderValue, IObservable<System.Byte[]> data)
{
    return ObservableExt.ZipExecute(RNGCryptoServiceProviderValue, data, (RNGCryptoServiceProviderValueLambda, dataLambda) => RNGCryptoServiceProviderValueLambda.GetNonZeroBytes(dataLambda));
}

}
}