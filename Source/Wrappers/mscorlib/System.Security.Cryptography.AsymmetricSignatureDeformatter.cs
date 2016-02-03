using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _AsymmetricSignatureDeformatter
{
    
public static IObservable<System.Reactive.Unit> SetKey(this IObservable<System.Security.Cryptography.AsymmetricSignatureDeformatter> AsymmetricSignatureDeformatterValue, IObservable<System.Security.Cryptography.AsymmetricAlgorithm> key)
{
    return ObservableExt.ZipExecute(AsymmetricSignatureDeformatterValue, key, (AsymmetricSignatureDeformatterValueLambda, keyLambda) => AsymmetricSignatureDeformatterValueLambda.SetKey(keyLambda));
}


public static IObservable<System.Reactive.Unit> SetHashAlgorithm(this IObservable<System.Security.Cryptography.AsymmetricSignatureDeformatter> AsymmetricSignatureDeformatterValue, IObservable<System.String> strName)
{
    return ObservableExt.ZipExecute(AsymmetricSignatureDeformatterValue, strName, (AsymmetricSignatureDeformatterValueLambda, strNameLambda) => AsymmetricSignatureDeformatterValueLambda.SetHashAlgorithm(strNameLambda));
}


public static IObservable<System.Boolean> VerifySignature(this IObservable<System.Security.Cryptography.AsymmetricSignatureDeformatter> AsymmetricSignatureDeformatterValue, IObservable<System.Security.Cryptography.HashAlgorithm> hash, IObservable<System.Byte[]> rgbSignature)
{
    return Observable.Zip(AsymmetricSignatureDeformatterValue, hash, rgbSignature, (AsymmetricSignatureDeformatterValueLambda, hashLambda, rgbSignatureLambda) => AsymmetricSignatureDeformatterValueLambda.VerifySignature(hashLambda, rgbSignatureLambda));
}


public static IObservable<System.Boolean> VerifySignature(this IObservable<System.Security.Cryptography.AsymmetricSignatureDeformatter> AsymmetricSignatureDeformatterValue, IObservable<System.Byte[]> rgbHash, IObservable<System.Byte[]> rgbSignature)
{
    return Observable.Zip(AsymmetricSignatureDeformatterValue, rgbHash, rgbSignature, (AsymmetricSignatureDeformatterValueLambda, rgbHashLambda, rgbSignatureLambda) => AsymmetricSignatureDeformatterValueLambda.VerifySignature(rgbHashLambda, rgbSignatureLambda));
}

}
}