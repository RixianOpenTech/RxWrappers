using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _MD5CryptoServiceProvider
{
    
public static IObservable<System.Reactive.Unit> Initialize(this IObservable<System.Security.Cryptography.MD5CryptoServiceProvider> MD5CryptoServiceProviderValue)
{
    return Observable.Do(MD5CryptoServiceProviderValue, (MD5CryptoServiceProviderValueLambda) => MD5CryptoServiceProviderValueLambda.Initialize()).ToUnit();
}

}
}