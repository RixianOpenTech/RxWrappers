using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __RSAPKCS1KeyExchangeDeformatter
    {
        
        public static IObservable<System.Byte[]> DecryptKeyExchange(this IObservable<System.Security.Cryptography.RSAPKCS1KeyExchangeDeformatter> RSAPKCS1KeyExchangeDeformatterValue, IObservable<System.Byte[]> rgbIn)
        {
            return Observable.Zip(RSAPKCS1KeyExchangeDeformatterValue, rgbIn, (RSAPKCS1KeyExchangeDeformatterValueLambda, rgbInLambda) => RSAPKCS1KeyExchangeDeformatterValueLambda.DecryptKeyExchange(rgbInLambda));
        }


        public static IObservable<System.Reactive.Unit> SetKey(this IObservable<System.Security.Cryptography.RSAPKCS1KeyExchangeDeformatter> RSAPKCS1KeyExchangeDeformatterValue, IObservable<System.Security.Cryptography.AsymmetricAlgorithm> key)
        {
            return ObservableExt.ZipExecute(RSAPKCS1KeyExchangeDeformatterValue, key, (RSAPKCS1KeyExchangeDeformatterValueLambda, keyLambda) => RSAPKCS1KeyExchangeDeformatterValueLambda.SetKey(keyLambda));
        }


        public static IObservable<System.Security.Cryptography.RandomNumberGenerator> get_RNG(this IObservable<System.Security.Cryptography.RSAPKCS1KeyExchangeDeformatter> RSAPKCS1KeyExchangeDeformatterValue)
        {
            return Observable.Select(RSAPKCS1KeyExchangeDeformatterValue, (RSAPKCS1KeyExchangeDeformatterValueLambda) => RSAPKCS1KeyExchangeDeformatterValueLambda.RNG);
        }


        public static IObservable<System.String> get_Parameters(this IObservable<System.Security.Cryptography.RSAPKCS1KeyExchangeDeformatter> RSAPKCS1KeyExchangeDeformatterValue)
        {
            return Observable.Select(RSAPKCS1KeyExchangeDeformatterValue, (RSAPKCS1KeyExchangeDeformatterValueLambda) => RSAPKCS1KeyExchangeDeformatterValueLambda.Parameters);
        }


        public static IObservable<System.Reactive.Unit> set_RNG(this IObservable<System.Security.Cryptography.RSAPKCS1KeyExchangeDeformatter> RSAPKCS1KeyExchangeDeformatterValue, IObservable<System.Security.Cryptography.RandomNumberGenerator> value)
        {
            return ObservableExt.ZipExecute(RSAPKCS1KeyExchangeDeformatterValue, value, (RSAPKCS1KeyExchangeDeformatterValueLambda, valueLambda) => RSAPKCS1KeyExchangeDeformatterValueLambda.RNG = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Parameters(this IObservable<System.Security.Cryptography.RSAPKCS1KeyExchangeDeformatter> RSAPKCS1KeyExchangeDeformatterValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(RSAPKCS1KeyExchangeDeformatterValue, value, (RSAPKCS1KeyExchangeDeformatterValueLambda, valueLambda) => RSAPKCS1KeyExchangeDeformatterValueLambda.Parameters = valueLambda);
        }

    }
}