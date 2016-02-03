using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __RSA
    {
        
        public static IObservable<System.Security.Cryptography.RSA> Create()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.RSA.Create());
        }


        public static IObservable<System.Security.Cryptography.RSA> Create(IObservable<System.String> algName)
        {
            return Observable.Select(algName, (algNameLambda) => System.Security.Cryptography.RSA.Create(algNameLambda));
        }


        public static IObservable<System.Byte[]> Encrypt(this IObservable<System.Security.Cryptography.RSA> RSAValue, IObservable<System.Byte[]> data, IObservable<System.Security.Cryptography.RSAEncryptionPadding> padding)
        {
            return Observable.Zip(RSAValue, data, padding, (RSAValueLambda, dataLambda, paddingLambda) => RSAValueLambda.Encrypt(dataLambda, paddingLambda));
        }


        public static IObservable<System.Byte[]> Decrypt(this IObservable<System.Security.Cryptography.RSA> RSAValue, IObservable<System.Byte[]> data, IObservable<System.Security.Cryptography.RSAEncryptionPadding> padding)
        {
            return Observable.Zip(RSAValue, data, padding, (RSAValueLambda, dataLambda, paddingLambda) => RSAValueLambda.Decrypt(dataLambda, paddingLambda));
        }


        public static IObservable<System.Byte[]> SignHash(this IObservable<System.Security.Cryptography.RSA> RSAValue, IObservable<System.Byte[]> hash, IObservable<System.Security.Cryptography.HashAlgorithmName> hashAlgorithm, IObservable<System.Security.Cryptography.RSASignaturePadding> padding)
        {
            return Observable.Zip(RSAValue, hash, hashAlgorithm, padding, (RSAValueLambda, hashLambda, hashAlgorithmLambda, paddingLambda) => RSAValueLambda.SignHash(hashLambda, hashAlgorithmLambda, paddingLambda));
        }


        public static IObservable<System.Boolean> VerifyHash(this IObservable<System.Security.Cryptography.RSA> RSAValue, IObservable<System.Byte[]> hash, IObservable<System.Byte[]> signature, IObservable<System.Security.Cryptography.HashAlgorithmName> hashAlgorithm, IObservable<System.Security.Cryptography.RSASignaturePadding> padding)
        {
            return Observable.Zip(RSAValue, hash, signature, hashAlgorithm, padding, (RSAValueLambda, hashLambda, signatureLambda, hashAlgorithmLambda, paddingLambda) => RSAValueLambda.VerifyHash(hashLambda, signatureLambda, hashAlgorithmLambda, paddingLambda));
        }


        public static IObservable<System.Byte[]> SignData(this IObservable<System.Security.Cryptography.RSA> RSAValue, IObservable<System.Byte[]> data, IObservable<System.Security.Cryptography.HashAlgorithmName> hashAlgorithm, IObservable<System.Security.Cryptography.RSASignaturePadding> padding)
        {
            return Observable.Zip(RSAValue, data, hashAlgorithm, padding, (RSAValueLambda, dataLambda, hashAlgorithmLambda, paddingLambda) => RSAValueLambda.SignData(dataLambda, hashAlgorithmLambda, paddingLambda));
        }


        public static IObservable<System.Byte[]> SignData(this IObservable<System.Security.Cryptography.RSA> RSAValue, IObservable<System.Byte[]> data, IObservable<System.Int32> offset, IObservable<System.Int32> count, IObservable<System.Security.Cryptography.HashAlgorithmName> hashAlgorithm, IObservable<System.Security.Cryptography.RSASignaturePadding> padding)
        {
            return Observable.Zip(RSAValue, data, offset, count, hashAlgorithm, padding, (RSAValueLambda, dataLambda, offsetLambda, countLambda, hashAlgorithmLambda, paddingLambda) => RSAValueLambda.SignData(dataLambda, offsetLambda, countLambda, hashAlgorithmLambda, paddingLambda));
        }


        public static IObservable<System.Byte[]> SignData(this IObservable<System.Security.Cryptography.RSA> RSAValue, IObservable<System.IO.Stream> data, IObservable<System.Security.Cryptography.HashAlgorithmName> hashAlgorithm, IObservable<System.Security.Cryptography.RSASignaturePadding> padding)
        {
            return Observable.Zip(RSAValue, data, hashAlgorithm, padding, (RSAValueLambda, dataLambda, hashAlgorithmLambda, paddingLambda) => RSAValueLambda.SignData(dataLambda, hashAlgorithmLambda, paddingLambda));
        }


        public static IObservable<System.Boolean> VerifyData(this IObservable<System.Security.Cryptography.RSA> RSAValue, IObservable<System.Byte[]> data, IObservable<System.Byte[]> signature, IObservable<System.Security.Cryptography.HashAlgorithmName> hashAlgorithm, IObservable<System.Security.Cryptography.RSASignaturePadding> padding)
        {
            return Observable.Zip(RSAValue, data, signature, hashAlgorithm, padding, (RSAValueLambda, dataLambda, signatureLambda, hashAlgorithmLambda, paddingLambda) => RSAValueLambda.VerifyData(dataLambda, signatureLambda, hashAlgorithmLambda, paddingLambda));
        }


        public static IObservable<System.Boolean> VerifyData(this IObservable<System.Security.Cryptography.RSA> RSAValue, IObservable<System.Byte[]> data, IObservable<System.Int32> offset, IObservable<System.Int32> count, IObservable<System.Byte[]> signature, IObservable<System.Security.Cryptography.HashAlgorithmName> hashAlgorithm, IObservable<System.Security.Cryptography.RSASignaturePadding> padding)
        {
            return Observable.Zip(RSAValue, data, offset, count, signature, hashAlgorithm, padding, (RSAValueLambda, dataLambda, offsetLambda, countLambda, signatureLambda, hashAlgorithmLambda, paddingLambda) => RSAValueLambda.VerifyData(dataLambda, offsetLambda, countLambda, signatureLambda, hashAlgorithmLambda, paddingLambda));
        }


        public static IObservable<System.Boolean> VerifyData(this IObservable<System.Security.Cryptography.RSA> RSAValue, IObservable<System.IO.Stream> data, IObservable<System.Byte[]> signature, IObservable<System.Security.Cryptography.HashAlgorithmName> hashAlgorithm, IObservable<System.Security.Cryptography.RSASignaturePadding> padding)
        {
            return Observable.Zip(RSAValue, data, signature, hashAlgorithm, padding, (RSAValueLambda, dataLambda, signatureLambda, hashAlgorithmLambda, paddingLambda) => RSAValueLambda.VerifyData(dataLambda, signatureLambda, hashAlgorithmLambda, paddingLambda));
        }


        public static IObservable<System.Byte[]> DecryptValue(this IObservable<System.Security.Cryptography.RSA> RSAValue, IObservable<System.Byte[]> rgb)
        {
            return Observable.Zip(RSAValue, rgb, (RSAValueLambda, rgbLambda) => RSAValueLambda.DecryptValue(rgbLambda));
        }


        public static IObservable<System.Byte[]> EncryptValue(this IObservable<System.Security.Cryptography.RSA> RSAValue, IObservable<System.Byte[]> rgb)
        {
            return Observable.Zip(RSAValue, rgb, (RSAValueLambda, rgbLambda) => RSAValueLambda.EncryptValue(rgbLambda));
        }


        public static IObservable<System.Reactive.Unit> FromXmlString(this IObservable<System.Security.Cryptography.RSA> RSAValue, IObservable<System.String> xmlString)
        {
            return ObservableExt.ZipExecute(RSAValue, xmlString, (RSAValueLambda, xmlStringLambda) => RSAValueLambda.FromXmlString(xmlStringLambda));
        }


        public static IObservable<System.String> ToXmlString(this IObservable<System.Security.Cryptography.RSA> RSAValue, IObservable<System.Boolean> includePrivateParameters)
        {
            return Observable.Zip(RSAValue, includePrivateParameters, (RSAValueLambda, includePrivateParametersLambda) => RSAValueLambda.ToXmlString(includePrivateParametersLambda));
        }


        public static IObservable<System.Security.Cryptography.RSAParameters> ExportParameters(this IObservable<System.Security.Cryptography.RSA> RSAValue, IObservable<System.Boolean> includePrivateParameters)
        {
            return Observable.Zip(RSAValue, includePrivateParameters, (RSAValueLambda, includePrivateParametersLambda) => RSAValueLambda.ExportParameters(includePrivateParametersLambda));
        }


        public static IObservable<System.Reactive.Unit> ImportParameters(this IObservable<System.Security.Cryptography.RSA> RSAValue, IObservable<System.Security.Cryptography.RSAParameters> parameters)
        {
            return ObservableExt.ZipExecute(RSAValue, parameters, (RSAValueLambda, parametersLambda) => RSAValueLambda.ImportParameters(parametersLambda));
        }


        public static IObservable<System.String> get_KeyExchangeAlgorithm(this IObservable<System.Security.Cryptography.RSA> RSAValue)
        {
            return Observable.Select(RSAValue, (RSAValueLambda) => RSAValueLambda.KeyExchangeAlgorithm);
        }


        public static IObservable<System.String> get_SignatureAlgorithm(this IObservable<System.Security.Cryptography.RSA> RSAValue)
        {
            return Observable.Select(RSAValue, (RSAValueLambda) => RSAValueLambda.SignatureAlgorithm);
        }

    }
}