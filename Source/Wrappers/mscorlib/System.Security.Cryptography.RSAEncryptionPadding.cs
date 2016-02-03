using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __RSAEncryptionPadding
    {
        
        public static IObservable<System.Security.Cryptography.RSAEncryptionPadding> CreateOaep(IObservable<System.Security.Cryptography.HashAlgorithmName> hashAlgorithm)
        {
            return Observable.Select(hashAlgorithm, (hashAlgorithmLambda) => System.Security.Cryptography.RSAEncryptionPadding.CreateOaep(hashAlgorithmLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Cryptography.RSAEncryptionPadding> RSAEncryptionPaddingValue)
        {
            return Observable.Select(RSAEncryptionPaddingValue, (RSAEncryptionPaddingValueLambda) => RSAEncryptionPaddingValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Cryptography.RSAEncryptionPadding> RSAEncryptionPaddingValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(RSAEncryptionPaddingValue, obj, (RSAEncryptionPaddingValueLambda, objLambda) => RSAEncryptionPaddingValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Cryptography.RSAEncryptionPadding> RSAEncryptionPaddingValue, IObservable<System.Security.Cryptography.RSAEncryptionPadding> other)
        {
            return Observable.Zip(RSAEncryptionPaddingValue, other, (RSAEncryptionPaddingValueLambda, otherLambda) => RSAEncryptionPaddingValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Security.Cryptography.RSAEncryptionPadding> RSAEncryptionPaddingValue)
        {
            return Observable.Select(RSAEncryptionPaddingValue, (RSAEncryptionPaddingValueLambda) => RSAEncryptionPaddingValueLambda.ToString());
        }


        public static IObservable<System.Security.Cryptography.RSAEncryptionPadding> get_Pkcs1()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.RSAEncryptionPadding.Pkcs1);
        }


        public static IObservable<System.Security.Cryptography.RSAEncryptionPadding> get_OaepSHA1()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.RSAEncryptionPadding.OaepSHA1);
        }


        public static IObservable<System.Security.Cryptography.RSAEncryptionPadding> get_OaepSHA256()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.RSAEncryptionPadding.OaepSHA256);
        }


        public static IObservable<System.Security.Cryptography.RSAEncryptionPadding> get_OaepSHA384()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.RSAEncryptionPadding.OaepSHA384);
        }


        public static IObservable<System.Security.Cryptography.RSAEncryptionPadding> get_OaepSHA512()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.RSAEncryptionPadding.OaepSHA512);
        }


        public static IObservable<System.Security.Cryptography.RSAEncryptionPaddingMode> get_Mode(this IObservable<System.Security.Cryptography.RSAEncryptionPadding> RSAEncryptionPaddingValue)
        {
            return Observable.Select(RSAEncryptionPaddingValue, (RSAEncryptionPaddingValueLambda) => RSAEncryptionPaddingValueLambda.Mode);
        }


        public static IObservable<System.Security.Cryptography.HashAlgorithmName> get_OaepHashAlgorithm(this IObservable<System.Security.Cryptography.RSAEncryptionPadding> RSAEncryptionPaddingValue)
        {
            return Observable.Select(RSAEncryptionPaddingValue, (RSAEncryptionPaddingValueLambda) => RSAEncryptionPaddingValueLambda.OaepHashAlgorithm);
        }

    }
}