using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __TripleDESCryptoServiceProvider
    {
        
        public static IObservable<System.Security.Cryptography.ICryptoTransform> CreateEncryptor(this IObservable<System.Security.Cryptography.TripleDESCryptoServiceProvider> TripleDESCryptoServiceProviderValue, IObservable<System.Byte[]> rgbKey, IObservable<System.Byte[]> rgbIV)
        {
            return Observable.Zip(TripleDESCryptoServiceProviderValue, rgbKey, rgbIV, (TripleDESCryptoServiceProviderValueLambda, rgbKeyLambda, rgbIVLambda) => TripleDESCryptoServiceProviderValueLambda.CreateEncryptor(rgbKeyLambda, rgbIVLambda));
        }


        public static IObservable<System.Security.Cryptography.ICryptoTransform> CreateDecryptor(this IObservable<System.Security.Cryptography.TripleDESCryptoServiceProvider> TripleDESCryptoServiceProviderValue, IObservable<System.Byte[]> rgbKey, IObservable<System.Byte[]> rgbIV)
        {
            return Observable.Zip(TripleDESCryptoServiceProviderValue, rgbKey, rgbIV, (TripleDESCryptoServiceProviderValueLambda, rgbKeyLambda, rgbIVLambda) => TripleDESCryptoServiceProviderValueLambda.CreateDecryptor(rgbKeyLambda, rgbIVLambda));
        }


        public static IObservable<System.Reactive.Unit> GenerateKey(this IObservable<System.Security.Cryptography.TripleDESCryptoServiceProvider> TripleDESCryptoServiceProviderValue)
        {
            return Observable.Do(TripleDESCryptoServiceProviderValue, (TripleDESCryptoServiceProviderValueLambda) => TripleDESCryptoServiceProviderValueLambda.GenerateKey()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> GenerateIV(this IObservable<System.Security.Cryptography.TripleDESCryptoServiceProvider> TripleDESCryptoServiceProviderValue)
        {
            return Observable.Do(TripleDESCryptoServiceProviderValue, (TripleDESCryptoServiceProviderValueLambda) => TripleDESCryptoServiceProviderValueLambda.GenerateIV()).ToUnit();
        }

    }
}