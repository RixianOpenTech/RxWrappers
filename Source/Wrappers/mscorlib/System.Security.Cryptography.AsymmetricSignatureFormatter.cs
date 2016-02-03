using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __AsymmetricSignatureFormatter
    {
        
        public static IObservable<System.Reactive.Unit> SetKey(this IObservable<System.Security.Cryptography.AsymmetricSignatureFormatter> AsymmetricSignatureFormatterValue, IObservable<System.Security.Cryptography.AsymmetricAlgorithm> key)
        {
            return ObservableExt.ZipExecute(AsymmetricSignatureFormatterValue, key, (AsymmetricSignatureFormatterValueLambda, keyLambda) => AsymmetricSignatureFormatterValueLambda.SetKey(keyLambda));
        }


        public static IObservable<System.Reactive.Unit> SetHashAlgorithm(this IObservable<System.Security.Cryptography.AsymmetricSignatureFormatter> AsymmetricSignatureFormatterValue, IObservable<System.String> strName)
        {
            return ObservableExt.ZipExecute(AsymmetricSignatureFormatterValue, strName, (AsymmetricSignatureFormatterValueLambda, strNameLambda) => AsymmetricSignatureFormatterValueLambda.SetHashAlgorithm(strNameLambda));
        }


        public static IObservable<System.Byte[]> CreateSignature(this IObservable<System.Security.Cryptography.AsymmetricSignatureFormatter> AsymmetricSignatureFormatterValue, IObservable<System.Security.Cryptography.HashAlgorithm> hash)
        {
            return Observable.Zip(AsymmetricSignatureFormatterValue, hash, (AsymmetricSignatureFormatterValueLambda, hashLambda) => AsymmetricSignatureFormatterValueLambda.CreateSignature(hashLambda));
        }


        public static IObservable<System.Byte[]> CreateSignature(this IObservable<System.Security.Cryptography.AsymmetricSignatureFormatter> AsymmetricSignatureFormatterValue, IObservable<System.Byte[]> rgbHash)
        {
            return Observable.Zip(AsymmetricSignatureFormatterValue, rgbHash, (AsymmetricSignatureFormatterValueLambda, rgbHashLambda) => AsymmetricSignatureFormatterValueLambda.CreateSignature(rgbHashLambda));
        }

    }
}