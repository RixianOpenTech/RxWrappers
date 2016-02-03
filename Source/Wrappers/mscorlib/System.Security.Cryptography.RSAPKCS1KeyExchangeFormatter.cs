using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __RSAPKCS1KeyExchangeFormatter
    {
        public static IObservable<System.Reactive.Unit> SetKey(
            this IObservable<System.Security.Cryptography.RSAPKCS1KeyExchangeFormatter>
                RSAPKCS1KeyExchangeFormatterValue, IObservable<System.Security.Cryptography.AsymmetricAlgorithm> key)
        {
            return ObservableExt.ZipExecute(RSAPKCS1KeyExchangeFormatterValue, key,
                (RSAPKCS1KeyExchangeFormatterValueLambda, keyLambda) =>
                    RSAPKCS1KeyExchangeFormatterValueLambda.SetKey(keyLambda));
        }


        public static IObservable<System.Byte[]> CreateKeyExchange(
            this IObservable<System.Security.Cryptography.RSAPKCS1KeyExchangeFormatter>
                RSAPKCS1KeyExchangeFormatterValue, IObservable<System.Byte[]> rgbData)
        {
            return Observable.Zip(RSAPKCS1KeyExchangeFormatterValue, rgbData,
                (RSAPKCS1KeyExchangeFormatterValueLambda, rgbDataLambda) =>
                    RSAPKCS1KeyExchangeFormatterValueLambda.CreateKeyExchange(rgbDataLambda));
        }


        public static IObservable<System.Byte[]> CreateKeyExchange(
            this IObservable<System.Security.Cryptography.RSAPKCS1KeyExchangeFormatter>
                RSAPKCS1KeyExchangeFormatterValue, IObservable<System.Byte[]> rgbData,
            IObservable<System.Type> symAlgType)
        {
            return Observable.Zip(RSAPKCS1KeyExchangeFormatterValue, rgbData, symAlgType,
                (RSAPKCS1KeyExchangeFormatterValueLambda, rgbDataLambda, symAlgTypeLambda) =>
                    RSAPKCS1KeyExchangeFormatterValueLambda.CreateKeyExchange(rgbDataLambda, symAlgTypeLambda));
        }


        public static IObservable<System.String> get_Parameters(
            this IObservable<System.Security.Cryptography.RSAPKCS1KeyExchangeFormatter>
                RSAPKCS1KeyExchangeFormatterValue)
        {
            return Observable.Select(RSAPKCS1KeyExchangeFormatterValue,
                (RSAPKCS1KeyExchangeFormatterValueLambda) => RSAPKCS1KeyExchangeFormatterValueLambda.Parameters);
        }


        public static IObservable<System.Security.Cryptography.RandomNumberGenerator> get_Rng(
            this IObservable<System.Security.Cryptography.RSAPKCS1KeyExchangeFormatter>
                RSAPKCS1KeyExchangeFormatterValue)
        {
            return Observable.Select(RSAPKCS1KeyExchangeFormatterValue,
                (RSAPKCS1KeyExchangeFormatterValueLambda) => RSAPKCS1KeyExchangeFormatterValueLambda.Rng);
        }


        public static IObservable<System.Reactive.Unit> set_Rng(
            this IObservable<System.Security.Cryptography.RSAPKCS1KeyExchangeFormatter>
                RSAPKCS1KeyExchangeFormatterValue, IObservable<System.Security.Cryptography.RandomNumberGenerator> value)
        {
            return ObservableExt.ZipExecute(RSAPKCS1KeyExchangeFormatterValue, value,
                (RSAPKCS1KeyExchangeFormatterValueLambda, valueLambda) =>
                    RSAPKCS1KeyExchangeFormatterValueLambda.Rng = valueLambda);
        }
    }
}