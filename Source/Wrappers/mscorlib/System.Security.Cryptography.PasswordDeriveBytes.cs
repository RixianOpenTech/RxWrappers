using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _PasswordDeriveBytes
{
    
public static IObservable<System.Byte[]> GetBytes(this IObservable<System.Security.Cryptography.PasswordDeriveBytes> PasswordDeriveBytesValue, IObservable<System.Int32> cb)
{
    return Observable.Zip(PasswordDeriveBytesValue, cb, (PasswordDeriveBytesValueLambda, cbLambda) => PasswordDeriveBytesValueLambda.GetBytes(cbLambda));
}


public static IObservable<System.Reactive.Unit> Reset(this IObservable<System.Security.Cryptography.PasswordDeriveBytes> PasswordDeriveBytesValue)
{
    return Observable.Do(PasswordDeriveBytesValue, (PasswordDeriveBytesValueLambda) => PasswordDeriveBytesValueLambda.Reset()).ToUnit();
}


public static IObservable<System.Byte[]> CryptDeriveKey(this IObservable<System.Security.Cryptography.PasswordDeriveBytes> PasswordDeriveBytesValue, IObservable<System.String> algname, IObservable<System.String> alghashname, IObservable<System.Int32> keySize, IObservable<System.Byte[]> rgbIV)
{
    return Observable.Zip(PasswordDeriveBytesValue, algname, alghashname, keySize, rgbIV, (PasswordDeriveBytesValueLambda, algnameLambda, alghashnameLambda, keySizeLambda, rgbIVLambda) => PasswordDeriveBytesValueLambda.CryptDeriveKey(algnameLambda, alghashnameLambda, keySizeLambda, rgbIVLambda));
}


public static IObservable<System.String> get_HashName(this IObservable<System.Security.Cryptography.PasswordDeriveBytes> PasswordDeriveBytesValue)
{
    return Observable.Select(PasswordDeriveBytesValue, (PasswordDeriveBytesValueLambda) => PasswordDeriveBytesValueLambda.HashName);
}


public static IObservable<System.Int32> get_IterationCount(this IObservable<System.Security.Cryptography.PasswordDeriveBytes> PasswordDeriveBytesValue)
{
    return Observable.Select(PasswordDeriveBytesValue, (PasswordDeriveBytesValueLambda) => PasswordDeriveBytesValueLambda.IterationCount);
}


public static IObservable<System.Byte[]> get_Salt(this IObservable<System.Security.Cryptography.PasswordDeriveBytes> PasswordDeriveBytesValue)
{
    return Observable.Select(PasswordDeriveBytesValue, (PasswordDeriveBytesValueLambda) => PasswordDeriveBytesValueLambda.Salt);
}


public static IObservable<System.Reactive.Unit> set_HashName(this IObservable<System.Security.Cryptography.PasswordDeriveBytes> PasswordDeriveBytesValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(PasswordDeriveBytesValue, value, (PasswordDeriveBytesValueLambda, valueLambda) => PasswordDeriveBytesValueLambda.HashName = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_IterationCount(this IObservable<System.Security.Cryptography.PasswordDeriveBytes> PasswordDeriveBytesValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(PasswordDeriveBytesValue, value, (PasswordDeriveBytesValueLambda, valueLambda) => PasswordDeriveBytesValueLambda.IterationCount = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Salt(this IObservable<System.Security.Cryptography.PasswordDeriveBytes> PasswordDeriveBytesValue, IObservable<System.Byte[]> value)
{
    return ObservableExt.ZipExecute(PasswordDeriveBytesValue, value, (PasswordDeriveBytesValueLambda, valueLambda) => PasswordDeriveBytesValueLambda.Salt = valueLambda);
}

}
}