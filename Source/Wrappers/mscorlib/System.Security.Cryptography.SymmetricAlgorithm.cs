using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __SymmetricAlgorithm
    {
        
        public static IObservable<System.Boolean> ValidKeySize(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue, IObservable<System.Int32> bitLength)
        {
            return Observable.Zip(SymmetricAlgorithmValue, bitLength, (SymmetricAlgorithmValueLambda, bitLengthLambda) => SymmetricAlgorithmValueLambda.ValidKeySize(bitLengthLambda));
        }


        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue)
        {
            return Observable.Do(SymmetricAlgorithmValue, (SymmetricAlgorithmValueLambda) => SymmetricAlgorithmValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Clear(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue)
        {
            return Observable.Do(SymmetricAlgorithmValue, (SymmetricAlgorithmValueLambda) => SymmetricAlgorithmValueLambda.Clear()).ToUnit();
        }


        public static IObservable<System.Security.Cryptography.SymmetricAlgorithm> Create()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.SymmetricAlgorithm.Create());
        }


        public static IObservable<System.Security.Cryptography.SymmetricAlgorithm> Create(IObservable<System.String> algName)
        {
            return Observable.Select(algName, (algNameLambda) => System.Security.Cryptography.SymmetricAlgorithm.Create(algNameLambda));
        }


        public static IObservable<System.Security.Cryptography.ICryptoTransform> CreateEncryptor(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue)
        {
            return Observable.Select(SymmetricAlgorithmValue, (SymmetricAlgorithmValueLambda) => SymmetricAlgorithmValueLambda.CreateEncryptor());
        }


        public static IObservable<System.Security.Cryptography.ICryptoTransform> CreateEncryptor(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue, IObservable<System.Byte[]> rgbKey, IObservable<System.Byte[]> rgbIV)
        {
            return Observable.Zip(SymmetricAlgorithmValue, rgbKey, rgbIV, (SymmetricAlgorithmValueLambda, rgbKeyLambda, rgbIVLambda) => SymmetricAlgorithmValueLambda.CreateEncryptor(rgbKeyLambda, rgbIVLambda));
        }


        public static IObservable<System.Security.Cryptography.ICryptoTransform> CreateDecryptor(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue)
        {
            return Observable.Select(SymmetricAlgorithmValue, (SymmetricAlgorithmValueLambda) => SymmetricAlgorithmValueLambda.CreateDecryptor());
        }


        public static IObservable<System.Security.Cryptography.ICryptoTransform> CreateDecryptor(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue, IObservable<System.Byte[]> rgbKey, IObservable<System.Byte[]> rgbIV)
        {
            return Observable.Zip(SymmetricAlgorithmValue, rgbKey, rgbIV, (SymmetricAlgorithmValueLambda, rgbKeyLambda, rgbIVLambda) => SymmetricAlgorithmValueLambda.CreateDecryptor(rgbKeyLambda, rgbIVLambda));
        }


        public static IObservable<System.Reactive.Unit> GenerateKey(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue)
        {
            return Observable.Do(SymmetricAlgorithmValue, (SymmetricAlgorithmValueLambda) => SymmetricAlgorithmValueLambda.GenerateKey()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> GenerateIV(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue)
        {
            return Observable.Do(SymmetricAlgorithmValue, (SymmetricAlgorithmValueLambda) => SymmetricAlgorithmValueLambda.GenerateIV()).ToUnit();
        }


        public static IObservable<System.Int32> get_BlockSize(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue)
        {
            return Observable.Select(SymmetricAlgorithmValue, (SymmetricAlgorithmValueLambda) => SymmetricAlgorithmValueLambda.BlockSize);
        }


        public static IObservable<System.Int32> get_FeedbackSize(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue)
        {
            return Observable.Select(SymmetricAlgorithmValue, (SymmetricAlgorithmValueLambda) => SymmetricAlgorithmValueLambda.FeedbackSize);
        }


        public static IObservable<System.Byte[]> get_IV(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue)
        {
            return Observable.Select(SymmetricAlgorithmValue, (SymmetricAlgorithmValueLambda) => SymmetricAlgorithmValueLambda.IV);
        }


        public static IObservable<System.Byte[]> get_Key(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue)
        {
            return Observable.Select(SymmetricAlgorithmValue, (SymmetricAlgorithmValueLambda) => SymmetricAlgorithmValueLambda.Key);
        }


        public static IObservable<System.Security.Cryptography.KeySizes[]> get_LegalBlockSizes(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue)
        {
            return Observable.Select(SymmetricAlgorithmValue, (SymmetricAlgorithmValueLambda) => SymmetricAlgorithmValueLambda.LegalBlockSizes);
        }


        public static IObservable<System.Security.Cryptography.KeySizes[]> get_LegalKeySizes(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue)
        {
            return Observable.Select(SymmetricAlgorithmValue, (SymmetricAlgorithmValueLambda) => SymmetricAlgorithmValueLambda.LegalKeySizes);
        }


        public static IObservable<System.Int32> get_KeySize(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue)
        {
            return Observable.Select(SymmetricAlgorithmValue, (SymmetricAlgorithmValueLambda) => SymmetricAlgorithmValueLambda.KeySize);
        }


        public static IObservable<System.Security.Cryptography.CipherMode> get_Mode(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue)
        {
            return Observable.Select(SymmetricAlgorithmValue, (SymmetricAlgorithmValueLambda) => SymmetricAlgorithmValueLambda.Mode);
        }


        public static IObservable<System.Security.Cryptography.PaddingMode> get_Padding(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue)
        {
            return Observable.Select(SymmetricAlgorithmValue, (SymmetricAlgorithmValueLambda) => SymmetricAlgorithmValueLambda.Padding);
        }


        public static IObservable<System.Reactive.Unit> set_BlockSize(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(SymmetricAlgorithmValue, value, (SymmetricAlgorithmValueLambda, valueLambda) => SymmetricAlgorithmValueLambda.BlockSize = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_FeedbackSize(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(SymmetricAlgorithmValue, value, (SymmetricAlgorithmValueLambda, valueLambda) => SymmetricAlgorithmValueLambda.FeedbackSize = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_IV(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue, IObservable<System.Byte[]> value)
        {
            return ObservableExt.ZipExecute(SymmetricAlgorithmValue, value, (SymmetricAlgorithmValueLambda, valueLambda) => SymmetricAlgorithmValueLambda.IV = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Key(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue, IObservable<System.Byte[]> value)
        {
            return ObservableExt.ZipExecute(SymmetricAlgorithmValue, value, (SymmetricAlgorithmValueLambda, valueLambda) => SymmetricAlgorithmValueLambda.Key = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_KeySize(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(SymmetricAlgorithmValue, value, (SymmetricAlgorithmValueLambda, valueLambda) => SymmetricAlgorithmValueLambda.KeySize = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Mode(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue, IObservable<System.Security.Cryptography.CipherMode> value)
        {
            return ObservableExt.ZipExecute(SymmetricAlgorithmValue, value, (SymmetricAlgorithmValueLambda, valueLambda) => SymmetricAlgorithmValueLambda.Mode = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Padding(this IObservable<System.Security.Cryptography.SymmetricAlgorithm> SymmetricAlgorithmValue, IObservable<System.Security.Cryptography.PaddingMode> value)
        {
            return ObservableExt.ZipExecute(SymmetricAlgorithmValue, value, (SymmetricAlgorithmValueLambda, valueLambda) => SymmetricAlgorithmValueLambda.Padding = valueLambda);
        }

    }
}