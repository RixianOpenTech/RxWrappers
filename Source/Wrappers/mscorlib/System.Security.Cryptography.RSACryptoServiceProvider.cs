using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __RSACryptoServiceProvider
    {
        
        public static IObservable<System.Security.Cryptography.RSAParameters> ExportParameters(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue, IObservable<System.Boolean> includePrivateParameters)
        {
            return Observable.Zip(RSACryptoServiceProviderValue, includePrivateParameters, (RSACryptoServiceProviderValueLambda, includePrivateParametersLambda) => RSACryptoServiceProviderValueLambda.ExportParameters(includePrivateParametersLambda));
        }


        public static IObservable<System.Byte[]> ExportCspBlob(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue, IObservable<System.Boolean> includePrivateParameters)
        {
            return Observable.Zip(RSACryptoServiceProviderValue, includePrivateParameters, (RSACryptoServiceProviderValueLambda, includePrivateParametersLambda) => RSACryptoServiceProviderValueLambda.ExportCspBlob(includePrivateParametersLambda));
        }


        public static IObservable<System.Reactive.Unit> ImportParameters(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue, IObservable<System.Security.Cryptography.RSAParameters> parameters)
        {
            return ObservableExt.ZipExecute(RSACryptoServiceProviderValue, parameters, (RSACryptoServiceProviderValueLambda, parametersLambda) => RSACryptoServiceProviderValueLambda.ImportParameters(parametersLambda));
        }


        public static IObservable<System.Reactive.Unit> ImportCspBlob(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue, IObservable<System.Byte[]> keyBlob)
        {
            return ObservableExt.ZipExecute(RSACryptoServiceProviderValue, keyBlob, (RSACryptoServiceProviderValueLambda, keyBlobLambda) => RSACryptoServiceProviderValueLambda.ImportCspBlob(keyBlobLambda));
        }


        public static IObservable<System.Byte[]> SignData(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue, IObservable<System.IO.Stream> inputStream, IObservable<System.Object> halg)
        {
            return Observable.Zip(RSACryptoServiceProviderValue, inputStream, halg, (RSACryptoServiceProviderValueLambda, inputStreamLambda, halgLambda) => RSACryptoServiceProviderValueLambda.SignData(inputStreamLambda, halgLambda));
        }


        public static IObservable<System.Byte[]> SignData(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue, IObservable<System.Byte[]> buffer, IObservable<System.Object> halg)
        {
            return Observable.Zip(RSACryptoServiceProviderValue, buffer, halg, (RSACryptoServiceProviderValueLambda, bufferLambda, halgLambda) => RSACryptoServiceProviderValueLambda.SignData(bufferLambda, halgLambda));
        }


        public static IObservable<System.Byte[]> SignData(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count, IObservable<System.Object> halg)
        {
            return Observable.Zip(RSACryptoServiceProviderValue, buffer, offset, count, halg, (RSACryptoServiceProviderValueLambda, bufferLambda, offsetLambda, countLambda, halgLambda) => RSACryptoServiceProviderValueLambda.SignData(bufferLambda, offsetLambda, countLambda, halgLambda));
        }


        public static IObservable<System.Boolean> VerifyData(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue, IObservable<System.Byte[]> buffer, IObservable<System.Object> halg, IObservable<System.Byte[]> signature)
        {
            return Observable.Zip(RSACryptoServiceProviderValue, buffer, halg, signature, (RSACryptoServiceProviderValueLambda, bufferLambda, halgLambda, signatureLambda) => RSACryptoServiceProviderValueLambda.VerifyData(bufferLambda, halgLambda, signatureLambda));
        }


        public static IObservable<System.Byte[]> SignHash(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue, IObservable<System.Byte[]> rgbHash, IObservable<System.String> str)
        {
            return Observable.Zip(RSACryptoServiceProviderValue, rgbHash, str, (RSACryptoServiceProviderValueLambda, rgbHashLambda, strLambda) => RSACryptoServiceProviderValueLambda.SignHash(rgbHashLambda, strLambda));
        }


        public static IObservable<System.Boolean> VerifyHash(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue, IObservable<System.Byte[]> rgbHash, IObservable<System.String> str, IObservable<System.Byte[]> rgbSignature)
        {
            return Observable.Zip(RSACryptoServiceProviderValue, rgbHash, str, rgbSignature, (RSACryptoServiceProviderValueLambda, rgbHashLambda, strLambda, rgbSignatureLambda) => RSACryptoServiceProviderValueLambda.VerifyHash(rgbHashLambda, strLambda, rgbSignatureLambda));
        }


        public static IObservable<System.Byte[]> Encrypt(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue, IObservable<System.Byte[]> rgb, IObservable<System.Boolean> fOAEP)
        {
            return Observable.Zip(RSACryptoServiceProviderValue, rgb, fOAEP, (RSACryptoServiceProviderValueLambda, rgbLambda, fOAEPLambda) => RSACryptoServiceProviderValueLambda.Encrypt(rgbLambda, fOAEPLambda));
        }


        public static IObservable<System.Byte[]> Decrypt(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue, IObservable<System.Byte[]> rgb, IObservable<System.Boolean> fOAEP)
        {
            return Observable.Zip(RSACryptoServiceProviderValue, rgb, fOAEP, (RSACryptoServiceProviderValueLambda, rgbLambda, fOAEPLambda) => RSACryptoServiceProviderValueLambda.Decrypt(rgbLambda, fOAEPLambda));
        }


        public static IObservable<System.Byte[]> DecryptValue(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue, IObservable<System.Byte[]> rgb)
        {
            return Observable.Zip(RSACryptoServiceProviderValue, rgb, (RSACryptoServiceProviderValueLambda, rgbLambda) => RSACryptoServiceProviderValueLambda.DecryptValue(rgbLambda));
        }


        public static IObservable<System.Byte[]> EncryptValue(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue, IObservable<System.Byte[]> rgb)
        {
            return Observable.Zip(RSACryptoServiceProviderValue, rgb, (RSACryptoServiceProviderValueLambda, rgbLambda) => RSACryptoServiceProviderValueLambda.EncryptValue(rgbLambda));
        }


        public static IObservable<System.Byte[]> Encrypt(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue, IObservable<System.Byte[]> data, IObservable<System.Security.Cryptography.RSAEncryptionPadding> padding)
        {
            return Observable.Zip(RSACryptoServiceProviderValue, data, padding, (RSACryptoServiceProviderValueLambda, dataLambda, paddingLambda) => RSACryptoServiceProviderValueLambda.Encrypt(dataLambda, paddingLambda));
        }


        public static IObservable<System.Byte[]> Decrypt(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue, IObservable<System.Byte[]> data, IObservable<System.Security.Cryptography.RSAEncryptionPadding> padding)
        {
            return Observable.Zip(RSACryptoServiceProviderValue, data, padding, (RSACryptoServiceProviderValueLambda, dataLambda, paddingLambda) => RSACryptoServiceProviderValueLambda.Decrypt(dataLambda, paddingLambda));
        }


        public static IObservable<System.Byte[]> SignHash(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue, IObservable<System.Byte[]> hash, IObservable<System.Security.Cryptography.HashAlgorithmName> hashAlgorithm, IObservable<System.Security.Cryptography.RSASignaturePadding> padding)
        {
            return Observable.Zip(RSACryptoServiceProviderValue, hash, hashAlgorithm, padding, (RSACryptoServiceProviderValueLambda, hashLambda, hashAlgorithmLambda, paddingLambda) => RSACryptoServiceProviderValueLambda.SignHash(hashLambda, hashAlgorithmLambda, paddingLambda));
        }


        public static IObservable<System.Boolean> VerifyHash(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue, IObservable<System.Byte[]> hash, IObservable<System.Byte[]> signature, IObservable<System.Security.Cryptography.HashAlgorithmName> hashAlgorithm, IObservable<System.Security.Cryptography.RSASignaturePadding> padding)
        {
            return Observable.Zip(RSACryptoServiceProviderValue, hash, signature, hashAlgorithm, padding, (RSACryptoServiceProviderValueLambda, hashLambda, signatureLambda, hashAlgorithmLambda, paddingLambda) => RSACryptoServiceProviderValueLambda.VerifyHash(hashLambda, signatureLambda, hashAlgorithmLambda, paddingLambda));
        }


        public static IObservable<System.Boolean> get_PublicOnly(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue)
        {
            return Observable.Select(RSACryptoServiceProviderValue, (RSACryptoServiceProviderValueLambda) => RSACryptoServiceProviderValueLambda.PublicOnly);
        }


        public static IObservable<System.Security.Cryptography.CspKeyContainerInfo> get_CspKeyContainerInfo(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue)
        {
            return Observable.Select(RSACryptoServiceProviderValue, (RSACryptoServiceProviderValueLambda) => RSACryptoServiceProviderValueLambda.CspKeyContainerInfo);
        }


        public static IObservable<System.Int32> get_KeySize(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue)
        {
            return Observable.Select(RSACryptoServiceProviderValue, (RSACryptoServiceProviderValueLambda) => RSACryptoServiceProviderValueLambda.KeySize);
        }


        public static IObservable<System.String> get_KeyExchangeAlgorithm(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue)
        {
            return Observable.Select(RSACryptoServiceProviderValue, (RSACryptoServiceProviderValueLambda) => RSACryptoServiceProviderValueLambda.KeyExchangeAlgorithm);
        }


        public static IObservable<System.String> get_SignatureAlgorithm(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue)
        {
            return Observable.Select(RSACryptoServiceProviderValue, (RSACryptoServiceProviderValueLambda) => RSACryptoServiceProviderValueLambda.SignatureAlgorithm);
        }


        public static IObservable<System.Boolean> get_UseMachineKeyStore()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.RSACryptoServiceProvider.UseMachineKeyStore);
        }


        public static IObservable<System.Boolean> get_PersistKeyInCsp(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue)
        {
            return Observable.Select(RSACryptoServiceProviderValue, (RSACryptoServiceProviderValueLambda) => RSACryptoServiceProviderValueLambda.PersistKeyInCsp);
        }


        public static IObservable<System.Reactive.Unit> set_UseMachineKeyStore(IObservable<System.Boolean> value)
        {
            return Observable.Do(value, (valueLambda) => System.Security.Cryptography.RSACryptoServiceProvider.UseMachineKeyStore = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_PersistKeyInCsp(this IObservable<System.Security.Cryptography.RSACryptoServiceProvider> RSACryptoServiceProviderValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(RSACryptoServiceProviderValue, value, (RSACryptoServiceProviderValueLambda, valueLambda) => RSACryptoServiceProviderValueLambda.PersistKeyInCsp = valueLambda);
        }

    }
}