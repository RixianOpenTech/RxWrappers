using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __RSAPKCS1SignatureFormatter
    {
        
        public static IObservable<System.Reactive.Unit> SetKey(this IObservable<System.Security.Cryptography.RSAPKCS1SignatureFormatter> RSAPKCS1SignatureFormatterValue, IObservable<System.Security.Cryptography.AsymmetricAlgorithm> key)
        {
            return ObservableExt.ZipExecute(RSAPKCS1SignatureFormatterValue, key, (RSAPKCS1SignatureFormatterValueLambda, keyLambda) => RSAPKCS1SignatureFormatterValueLambda.SetKey(keyLambda));
        }


        public static IObservable<System.Reactive.Unit> SetHashAlgorithm(this IObservable<System.Security.Cryptography.RSAPKCS1SignatureFormatter> RSAPKCS1SignatureFormatterValue, IObservable<System.String> strName)
        {
            return ObservableExt.ZipExecute(RSAPKCS1SignatureFormatterValue, strName, (RSAPKCS1SignatureFormatterValueLambda, strNameLambda) => RSAPKCS1SignatureFormatterValueLambda.SetHashAlgorithm(strNameLambda));
        }


        public static IObservable<System.Byte[]> CreateSignature(this IObservable<System.Security.Cryptography.RSAPKCS1SignatureFormatter> RSAPKCS1SignatureFormatterValue, IObservable<System.Byte[]> rgbHash)
        {
            return Observable.Zip(RSAPKCS1SignatureFormatterValue, rgbHash, (RSAPKCS1SignatureFormatterValueLambda, rgbHashLambda) => RSAPKCS1SignatureFormatterValueLambda.CreateSignature(rgbHashLambda));
        }

    }
}