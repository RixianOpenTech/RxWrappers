using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __DSASignatureFormatter
    {
        public static IObservable<System.Reactive.Unit> SetKey(
            this IObservable<System.Security.Cryptography.DSASignatureFormatter> DSASignatureFormatterValue,
            IObservable<System.Security.Cryptography.AsymmetricAlgorithm> key)
        {
            return ObservableExt.ZipExecute(DSASignatureFormatterValue, key,
                (DSASignatureFormatterValueLambda, keyLambda) => DSASignatureFormatterValueLambda.SetKey(keyLambda));
        }


        public static IObservable<System.Reactive.Unit> SetHashAlgorithm(
            this IObservable<System.Security.Cryptography.DSASignatureFormatter> DSASignatureFormatterValue,
            IObservable<System.String> strName)
        {
            return ObservableExt.ZipExecute(DSASignatureFormatterValue, strName,
                (DSASignatureFormatterValueLambda, strNameLambda) =>
                    DSASignatureFormatterValueLambda.SetHashAlgorithm(strNameLambda));
        }


        public static IObservable<System.Byte[]> CreateSignature(
            this IObservable<System.Security.Cryptography.DSASignatureFormatter> DSASignatureFormatterValue,
            IObservable<System.Byte[]> rgbHash)
        {
            return Observable.Zip(DSASignatureFormatterValue, rgbHash,
                (DSASignatureFormatterValueLambda, rgbHashLambda) =>
                    DSASignatureFormatterValueLambda.CreateSignature(rgbHashLambda));
        }
    }
}