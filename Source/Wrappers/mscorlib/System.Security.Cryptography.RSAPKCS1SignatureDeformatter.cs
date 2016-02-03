using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __RSAPKCS1SignatureDeformatter
    {
        public static IObservable<System.Reactive.Unit> SetKey(
            this IObservable<System.Security.Cryptography.RSAPKCS1SignatureDeformatter>
                RSAPKCS1SignatureDeformatterValue, IObservable<System.Security.Cryptography.AsymmetricAlgorithm> key)
        {
            return ObservableExt.ZipExecute(RSAPKCS1SignatureDeformatterValue, key,
                (RSAPKCS1SignatureDeformatterValueLambda, keyLambda) =>
                    RSAPKCS1SignatureDeformatterValueLambda.SetKey(keyLambda));
        }


        public static IObservable<System.Reactive.Unit> SetHashAlgorithm(
            this IObservable<System.Security.Cryptography.RSAPKCS1SignatureDeformatter>
                RSAPKCS1SignatureDeformatterValue, IObservable<System.String> strName)
        {
            return ObservableExt.ZipExecute(RSAPKCS1SignatureDeformatterValue, strName,
                (RSAPKCS1SignatureDeformatterValueLambda, strNameLambda) =>
                    RSAPKCS1SignatureDeformatterValueLambda.SetHashAlgorithm(strNameLambda));
        }


        public static IObservable<System.Boolean> VerifySignature(
            this IObservable<System.Security.Cryptography.RSAPKCS1SignatureDeformatter>
                RSAPKCS1SignatureDeformatterValue, IObservable<System.Byte[]> rgbHash,
            IObservable<System.Byte[]> rgbSignature)
        {
            return Observable.Zip(RSAPKCS1SignatureDeformatterValue, rgbHash, rgbSignature,
                (RSAPKCS1SignatureDeformatterValueLambda, rgbHashLambda, rgbSignatureLambda) =>
                    RSAPKCS1SignatureDeformatterValueLambda.VerifySignature(rgbHashLambda, rgbSignatureLambda));
        }
    }
}