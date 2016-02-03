using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __RSAOAEPKeyExchangeDeformatter
    {
        public static IObservable<System.Byte[]> DecryptKeyExchange(
            this IObservable<System.Security.Cryptography.RSAOAEPKeyExchangeDeformatter>
                RSAOAEPKeyExchangeDeformatterValue, IObservable<System.Byte[]> rgbData)
        {
            return Observable.Zip(RSAOAEPKeyExchangeDeformatterValue, rgbData,
                (RSAOAEPKeyExchangeDeformatterValueLambda, rgbDataLambda) =>
                    RSAOAEPKeyExchangeDeformatterValueLambda.DecryptKeyExchange(rgbDataLambda));
        }


        public static IObservable<System.Reactive.Unit> SetKey(
            this IObservable<System.Security.Cryptography.RSAOAEPKeyExchangeDeformatter>
                RSAOAEPKeyExchangeDeformatterValue, IObservable<System.Security.Cryptography.AsymmetricAlgorithm> key)
        {
            return ObservableExt.ZipExecute(RSAOAEPKeyExchangeDeformatterValue, key,
                (RSAOAEPKeyExchangeDeformatterValueLambda, keyLambda) =>
                    RSAOAEPKeyExchangeDeformatterValueLambda.SetKey(keyLambda));
        }


        public static IObservable<System.String> get_Parameters(
            this IObservable<System.Security.Cryptography.RSAOAEPKeyExchangeDeformatter>
                RSAOAEPKeyExchangeDeformatterValue)
        {
            return Observable.Select(RSAOAEPKeyExchangeDeformatterValue,
                (RSAOAEPKeyExchangeDeformatterValueLambda) => RSAOAEPKeyExchangeDeformatterValueLambda.Parameters);
        }


        public static IObservable<System.Reactive.Unit> set_Parameters(
            this IObservable<System.Security.Cryptography.RSAOAEPKeyExchangeDeformatter>
                RSAOAEPKeyExchangeDeformatterValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(RSAOAEPKeyExchangeDeformatterValue, value,
                (RSAOAEPKeyExchangeDeformatterValueLambda, valueLambda) =>
                    RSAOAEPKeyExchangeDeformatterValueLambda.Parameters = valueLambda);
        }
    }
}