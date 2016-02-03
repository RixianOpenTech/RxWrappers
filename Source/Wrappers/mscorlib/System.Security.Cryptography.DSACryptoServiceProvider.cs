using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __DSACryptoServiceProvider
    {
        
        public static IObservable<System.Security.Cryptography.DSAParameters> ExportParameters(this IObservable<System.Security.Cryptography.DSACryptoServiceProvider> DSACryptoServiceProviderValue, IObservable<System.Boolean> includePrivateParameters)
        {
            return Observable.Zip(DSACryptoServiceProviderValue, includePrivateParameters, (DSACryptoServiceProviderValueLambda, includePrivateParametersLambda) => DSACryptoServiceProviderValueLambda.ExportParameters(includePrivateParametersLambda));
        }


        public static IObservable<System.Byte[]> ExportCspBlob(this IObservable<System.Security.Cryptography.DSACryptoServiceProvider> DSACryptoServiceProviderValue, IObservable<System.Boolean> includePrivateParameters)
        {
            return Observable.Zip(DSACryptoServiceProviderValue, includePrivateParameters, (DSACryptoServiceProviderValueLambda, includePrivateParametersLambda) => DSACryptoServiceProviderValueLambda.ExportCspBlob(includePrivateParametersLambda));
        }


        public static IObservable<System.Reactive.Unit> ImportParameters(this IObservable<System.Security.Cryptography.DSACryptoServiceProvider> DSACryptoServiceProviderValue, IObservable<System.Security.Cryptography.DSAParameters> parameters)
        {
            return ObservableExt.ZipExecute(DSACryptoServiceProviderValue, parameters, (DSACryptoServiceProviderValueLambda, parametersLambda) => DSACryptoServiceProviderValueLambda.ImportParameters(parametersLambda));
        }


        public static IObservable<System.Reactive.Unit> ImportCspBlob(this IObservable<System.Security.Cryptography.DSACryptoServiceProvider> DSACryptoServiceProviderValue, IObservable<System.Byte[]> keyBlob)
        {
            return ObservableExt.ZipExecute(DSACryptoServiceProviderValue, keyBlob, (DSACryptoServiceProviderValueLambda, keyBlobLambda) => DSACryptoServiceProviderValueLambda.ImportCspBlob(keyBlobLambda));
        }


        public static IObservable<System.Byte[]> SignData(this IObservable<System.Security.Cryptography.DSACryptoServiceProvider> DSACryptoServiceProviderValue, IObservable<System.IO.Stream> inputStream)
        {
            return Observable.Zip(DSACryptoServiceProviderValue, inputStream, (DSACryptoServiceProviderValueLambda, inputStreamLambda) => DSACryptoServiceProviderValueLambda.SignData(inputStreamLambda));
        }


        public static IObservable<System.Byte[]> SignData(this IObservable<System.Security.Cryptography.DSACryptoServiceProvider> DSACryptoServiceProviderValue, IObservable<System.Byte[]> buffer)
        {
            return Observable.Zip(DSACryptoServiceProviderValue, buffer, (DSACryptoServiceProviderValueLambda, bufferLambda) => DSACryptoServiceProviderValueLambda.SignData(bufferLambda));
        }


        public static IObservable<System.Byte[]> SignData(this IObservable<System.Security.Cryptography.DSACryptoServiceProvider> DSACryptoServiceProviderValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count)
        {
            return Observable.Zip(DSACryptoServiceProviderValue, buffer, offset, count, (DSACryptoServiceProviderValueLambda, bufferLambda, offsetLambda, countLambda) => DSACryptoServiceProviderValueLambda.SignData(bufferLambda, offsetLambda, countLambda));
        }


        public static IObservable<System.Boolean> VerifyData(this IObservable<System.Security.Cryptography.DSACryptoServiceProvider> DSACryptoServiceProviderValue, IObservable<System.Byte[]> rgbData, IObservable<System.Byte[]> rgbSignature)
        {
            return Observable.Zip(DSACryptoServiceProviderValue, rgbData, rgbSignature, (DSACryptoServiceProviderValueLambda, rgbDataLambda, rgbSignatureLambda) => DSACryptoServiceProviderValueLambda.VerifyData(rgbDataLambda, rgbSignatureLambda));
        }


        public static IObservable<System.Byte[]> CreateSignature(this IObservable<System.Security.Cryptography.DSACryptoServiceProvider> DSACryptoServiceProviderValue, IObservable<System.Byte[]> rgbHash)
        {
            return Observable.Zip(DSACryptoServiceProviderValue, rgbHash, (DSACryptoServiceProviderValueLambda, rgbHashLambda) => DSACryptoServiceProviderValueLambda.CreateSignature(rgbHashLambda));
        }


        public static IObservable<System.Boolean> VerifySignature(this IObservable<System.Security.Cryptography.DSACryptoServiceProvider> DSACryptoServiceProviderValue, IObservable<System.Byte[]> rgbHash, IObservable<System.Byte[]> rgbSignature)
        {
            return Observable.Zip(DSACryptoServiceProviderValue, rgbHash, rgbSignature, (DSACryptoServiceProviderValueLambda, rgbHashLambda, rgbSignatureLambda) => DSACryptoServiceProviderValueLambda.VerifySignature(rgbHashLambda, rgbSignatureLambda));
        }


        public static IObservable<System.Byte[]> SignHash(this IObservable<System.Security.Cryptography.DSACryptoServiceProvider> DSACryptoServiceProviderValue, IObservable<System.Byte[]> rgbHash, IObservable<System.String> str)
        {
            return Observable.Zip(DSACryptoServiceProviderValue, rgbHash, str, (DSACryptoServiceProviderValueLambda, rgbHashLambda, strLambda) => DSACryptoServiceProviderValueLambda.SignHash(rgbHashLambda, strLambda));
        }


        public static IObservable<System.Boolean> VerifyHash(this IObservable<System.Security.Cryptography.DSACryptoServiceProvider> DSACryptoServiceProviderValue, IObservable<System.Byte[]> rgbHash, IObservable<System.String> str, IObservable<System.Byte[]> rgbSignature)
        {
            return Observable.Zip(DSACryptoServiceProviderValue, rgbHash, str, rgbSignature, (DSACryptoServiceProviderValueLambda, rgbHashLambda, strLambda, rgbSignatureLambda) => DSACryptoServiceProviderValueLambda.VerifyHash(rgbHashLambda, strLambda, rgbSignatureLambda));
        }


        public static IObservable<System.Boolean> get_PublicOnly(this IObservable<System.Security.Cryptography.DSACryptoServiceProvider> DSACryptoServiceProviderValue)
        {
            return Observable.Select(DSACryptoServiceProviderValue, (DSACryptoServiceProviderValueLambda) => DSACryptoServiceProviderValueLambda.PublicOnly);
        }


        public static IObservable<System.Security.Cryptography.CspKeyContainerInfo> get_CspKeyContainerInfo(this IObservable<System.Security.Cryptography.DSACryptoServiceProvider> DSACryptoServiceProviderValue)
        {
            return Observable.Select(DSACryptoServiceProviderValue, (DSACryptoServiceProviderValueLambda) => DSACryptoServiceProviderValueLambda.CspKeyContainerInfo);
        }


        public static IObservable<System.Int32> get_KeySize(this IObservable<System.Security.Cryptography.DSACryptoServiceProvider> DSACryptoServiceProviderValue)
        {
            return Observable.Select(DSACryptoServiceProviderValue, (DSACryptoServiceProviderValueLambda) => DSACryptoServiceProviderValueLambda.KeySize);
        }


        public static IObservable<System.String> get_KeyExchangeAlgorithm(this IObservable<System.Security.Cryptography.DSACryptoServiceProvider> DSACryptoServiceProviderValue)
        {
            return Observable.Select(DSACryptoServiceProviderValue, (DSACryptoServiceProviderValueLambda) => DSACryptoServiceProviderValueLambda.KeyExchangeAlgorithm);
        }


        public static IObservable<System.String> get_SignatureAlgorithm(this IObservable<System.Security.Cryptography.DSACryptoServiceProvider> DSACryptoServiceProviderValue)
        {
            return Observable.Select(DSACryptoServiceProviderValue, (DSACryptoServiceProviderValueLambda) => DSACryptoServiceProviderValueLambda.SignatureAlgorithm);
        }


        public static IObservable<System.Boolean> get_UseMachineKeyStore()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.DSACryptoServiceProvider.UseMachineKeyStore);
        }


        public static IObservable<System.Boolean> get_PersistKeyInCsp(this IObservable<System.Security.Cryptography.DSACryptoServiceProvider> DSACryptoServiceProviderValue)
        {
            return Observable.Select(DSACryptoServiceProviderValue, (DSACryptoServiceProviderValueLambda) => DSACryptoServiceProviderValueLambda.PersistKeyInCsp);
        }


        public static IObservable<System.Reactive.Unit> set_UseMachineKeyStore(IObservable<System.Boolean> value)
        {
            return Observable.Do(value, (valueLambda) => System.Security.Cryptography.DSACryptoServiceProvider.UseMachineKeyStore = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_PersistKeyInCsp(this IObservable<System.Security.Cryptography.DSACryptoServiceProvider> DSACryptoServiceProviderValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(DSACryptoServiceProviderValue, value, (DSACryptoServiceProviderValueLambda, valueLambda) => DSACryptoServiceProviderValueLambda.PersistKeyInCsp = valueLambda);
        }

    }
}