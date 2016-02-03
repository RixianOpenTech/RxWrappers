using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __AsymmetricKeyExchangeFormatter
    {
        public static IObservable<System.Reactive.Unit> SetKey(
            this IObservable<System.Security.Cryptography.AsymmetricKeyExchangeFormatter>
                AsymmetricKeyExchangeFormatterValue, IObservable<System.Security.Cryptography.AsymmetricAlgorithm> key)
        {
            return ObservableExt.ZipExecute(AsymmetricKeyExchangeFormatterValue, key,
                (AsymmetricKeyExchangeFormatterValueLambda, keyLambda) =>
                    AsymmetricKeyExchangeFormatterValueLambda.SetKey(keyLambda));
        }


        public static IObservable<System.Byte[]> CreateKeyExchange(
            this IObservable<System.Security.Cryptography.AsymmetricKeyExchangeFormatter>
                AsymmetricKeyExchangeFormatterValue, IObservable<System.Byte[]> data)
        {
            return Observable.Zip(AsymmetricKeyExchangeFormatterValue, data,
                (AsymmetricKeyExchangeFormatterValueLambda, dataLambda) =>
                    AsymmetricKeyExchangeFormatterValueLambda.CreateKeyExchange(dataLambda));
        }


        public static IObservable<System.Byte[]> CreateKeyExchange(
            this IObservable<System.Security.Cryptography.AsymmetricKeyExchangeFormatter>
                AsymmetricKeyExchangeFormatterValue, IObservable<System.Byte[]> data,
            IObservable<System.Type> symAlgType)
        {
            return Observable.Zip(AsymmetricKeyExchangeFormatterValue, data, symAlgType,
                (AsymmetricKeyExchangeFormatterValueLambda, dataLambda, symAlgTypeLambda) =>
                    AsymmetricKeyExchangeFormatterValueLambda.CreateKeyExchange(dataLambda, symAlgTypeLambda));
        }


        public static IObservable<System.String> get_Parameters(
            this IObservable<System.Security.Cryptography.AsymmetricKeyExchangeFormatter>
                AsymmetricKeyExchangeFormatterValue)
        {
            return Observable.Select(AsymmetricKeyExchangeFormatterValue,
                (AsymmetricKeyExchangeFormatterValueLambda) => AsymmetricKeyExchangeFormatterValueLambda.Parameters);
        }
    }
}