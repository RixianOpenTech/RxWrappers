using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __RSAOAEPKeyExchangeFormatter
    {
        public static IObservable<System.Reactive.Unit> SetKey(
            this IObservable<System.Security.Cryptography.RSAOAEPKeyExchangeFormatter> RSAOAEPKeyExchangeFormatterValue,
            IObservable<System.Security.Cryptography.AsymmetricAlgorithm> key)
        {
            return ObservableExt.ZipExecute(RSAOAEPKeyExchangeFormatterValue, key,
                (RSAOAEPKeyExchangeFormatterValueLambda, keyLambda) =>
                    RSAOAEPKeyExchangeFormatterValueLambda.SetKey(keyLambda));
        }


        public static IObservable<System.Byte[]> CreateKeyExchange(
            this IObservable<System.Security.Cryptography.RSAOAEPKeyExchangeFormatter> RSAOAEPKeyExchangeFormatterValue,
            IObservable<System.Byte[]> rgbData)
        {
            return Observable.Zip(RSAOAEPKeyExchangeFormatterValue, rgbData,
                (RSAOAEPKeyExchangeFormatterValueLambda, rgbDataLambda) =>
                    RSAOAEPKeyExchangeFormatterValueLambda.CreateKeyExchange(rgbDataLambda));
        }


        public static IObservable<System.Byte[]> CreateKeyExchange(
            this IObservable<System.Security.Cryptography.RSAOAEPKeyExchangeFormatter> RSAOAEPKeyExchangeFormatterValue,
            IObservable<System.Byte[]> rgbData, IObservable<System.Type> symAlgType)
        {
            return Observable.Zip(RSAOAEPKeyExchangeFormatterValue, rgbData, symAlgType,
                (RSAOAEPKeyExchangeFormatterValueLambda, rgbDataLambda, symAlgTypeLambda) =>
                    RSAOAEPKeyExchangeFormatterValueLambda.CreateKeyExchange(rgbDataLambda, symAlgTypeLambda));
        }


        public static IObservable<System.Byte[]> get_Parameter(
            this IObservable<System.Security.Cryptography.RSAOAEPKeyExchangeFormatter> RSAOAEPKeyExchangeFormatterValue)
        {
            return Observable.Select(RSAOAEPKeyExchangeFormatterValue,
                (RSAOAEPKeyExchangeFormatterValueLambda) => RSAOAEPKeyExchangeFormatterValueLambda.Parameter);
        }


        public static IObservable<System.String> get_Parameters(
            this IObservable<System.Security.Cryptography.RSAOAEPKeyExchangeFormatter> RSAOAEPKeyExchangeFormatterValue)
        {
            return Observable.Select(RSAOAEPKeyExchangeFormatterValue,
                (RSAOAEPKeyExchangeFormatterValueLambda) => RSAOAEPKeyExchangeFormatterValueLambda.Parameters);
        }


        public static IObservable<System.Security.Cryptography.RandomNumberGenerator> get_Rng(
            this IObservable<System.Security.Cryptography.RSAOAEPKeyExchangeFormatter> RSAOAEPKeyExchangeFormatterValue)
        {
            return Observable.Select(RSAOAEPKeyExchangeFormatterValue,
                (RSAOAEPKeyExchangeFormatterValueLambda) => RSAOAEPKeyExchangeFormatterValueLambda.Rng);
        }


        public static IObservable<System.Reactive.Unit> set_Parameter(
            this IObservable<System.Security.Cryptography.RSAOAEPKeyExchangeFormatter> RSAOAEPKeyExchangeFormatterValue,
            IObservable<System.Byte[]> value)
        {
            return ObservableExt.ZipExecute(RSAOAEPKeyExchangeFormatterValue, value,
                (RSAOAEPKeyExchangeFormatterValueLambda, valueLambda) =>
                    RSAOAEPKeyExchangeFormatterValueLambda.Parameter = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Rng(
            this IObservable<System.Security.Cryptography.RSAOAEPKeyExchangeFormatter> RSAOAEPKeyExchangeFormatterValue,
            IObservable<System.Security.Cryptography.RandomNumberGenerator> value)
        {
            return ObservableExt.ZipExecute(RSAOAEPKeyExchangeFormatterValue, value,
                (RSAOAEPKeyExchangeFormatterValueLambda, valueLambda) =>
                    RSAOAEPKeyExchangeFormatterValueLambda.Rng = valueLambda);
        }
    }
}