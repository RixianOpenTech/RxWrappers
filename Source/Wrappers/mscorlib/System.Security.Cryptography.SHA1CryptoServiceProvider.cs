using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __SHA1CryptoServiceProvider
    {
        public static IObservable<System.Reactive.Unit> Initialize(
            this IObservable<System.Security.Cryptography.SHA1CryptoServiceProvider> SHA1CryptoServiceProviderValue)
        {
            return
                Observable.Do(SHA1CryptoServiceProviderValue,
                    (SHA1CryptoServiceProviderValueLambda) => SHA1CryptoServiceProviderValueLambda.Initialize())
                    .ToUnit();
        }
    }
}