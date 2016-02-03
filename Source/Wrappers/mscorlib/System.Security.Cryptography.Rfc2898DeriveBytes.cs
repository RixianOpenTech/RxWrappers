using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __Rfc2898DeriveBytes
    {
        
        public static IObservable<System.Byte[]> GetBytes(this IObservable<System.Security.Cryptography.Rfc2898DeriveBytes> Rfc2898DeriveBytesValue, IObservable<System.Int32> cb)
        {
            return Observable.Zip(Rfc2898DeriveBytesValue, cb, (Rfc2898DeriveBytesValueLambda, cbLambda) => Rfc2898DeriveBytesValueLambda.GetBytes(cbLambda));
        }


        public static IObservable<System.Reactive.Unit> Reset(this IObservable<System.Security.Cryptography.Rfc2898DeriveBytes> Rfc2898DeriveBytesValue)
        {
            return Observable.Do(Rfc2898DeriveBytesValue, (Rfc2898DeriveBytesValueLambda) => Rfc2898DeriveBytesValueLambda.Reset()).ToUnit();
        }


        public static IObservable<System.Byte[]> CryptDeriveKey(this IObservable<System.Security.Cryptography.Rfc2898DeriveBytes> Rfc2898DeriveBytesValue, IObservable<System.String> algname, IObservable<System.String> alghashname, IObservable<System.Int32> keySize, IObservable<System.Byte[]> rgbIV)
        {
            return Observable.Zip(Rfc2898DeriveBytesValue, algname, alghashname, keySize, rgbIV, (Rfc2898DeriveBytesValueLambda, algnameLambda, alghashnameLambda, keySizeLambda, rgbIVLambda) => Rfc2898DeriveBytesValueLambda.CryptDeriveKey(algnameLambda, alghashnameLambda, keySizeLambda, rgbIVLambda));
        }


        public static IObservable<System.Int32> get_IterationCount(this IObservable<System.Security.Cryptography.Rfc2898DeriveBytes> Rfc2898DeriveBytesValue)
        {
            return Observable.Select(Rfc2898DeriveBytesValue, (Rfc2898DeriveBytesValueLambda) => Rfc2898DeriveBytesValueLambda.IterationCount);
        }


        public static IObservable<System.Byte[]> get_Salt(this IObservable<System.Security.Cryptography.Rfc2898DeriveBytes> Rfc2898DeriveBytesValue)
        {
            return Observable.Select(Rfc2898DeriveBytesValue, (Rfc2898DeriveBytesValueLambda) => Rfc2898DeriveBytesValueLambda.Salt);
        }


        public static IObservable<System.Reactive.Unit> set_IterationCount(this IObservable<System.Security.Cryptography.Rfc2898DeriveBytes> Rfc2898DeriveBytesValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(Rfc2898DeriveBytesValue, value, (Rfc2898DeriveBytesValueLambda, valueLambda) => Rfc2898DeriveBytesValueLambda.IterationCount = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Salt(this IObservable<System.Security.Cryptography.Rfc2898DeriveBytes> Rfc2898DeriveBytesValue, IObservable<System.Byte[]> value)
        {
            return ObservableExt.ZipExecute(Rfc2898DeriveBytesValue, value, (Rfc2898DeriveBytesValueLambda, valueLambda) => Rfc2898DeriveBytesValueLambda.Salt = valueLambda);
        }

    }
}