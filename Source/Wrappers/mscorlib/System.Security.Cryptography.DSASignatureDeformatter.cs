using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _DSASignatureDeformatter
{
    
public static IObservable<System.Reactive.Unit> SetKey(this IObservable<System.Security.Cryptography.DSASignatureDeformatter> DSASignatureDeformatterValue, IObservable<System.Security.Cryptography.AsymmetricAlgorithm> key)
{
    return ObservableExt.ZipExecute(DSASignatureDeformatterValue, key, (DSASignatureDeformatterValueLambda, keyLambda) => DSASignatureDeformatterValueLambda.SetKey(keyLambda));
}


public static IObservable<System.Reactive.Unit> SetHashAlgorithm(this IObservable<System.Security.Cryptography.DSASignatureDeformatter> DSASignatureDeformatterValue, IObservable<System.String> strName)
{
    return ObservableExt.ZipExecute(DSASignatureDeformatterValue, strName, (DSASignatureDeformatterValueLambda, strNameLambda) => DSASignatureDeformatterValueLambda.SetHashAlgorithm(strNameLambda));
}


public static IObservable<System.Boolean> VerifySignature(this IObservable<System.Security.Cryptography.DSASignatureDeformatter> DSASignatureDeformatterValue, IObservable<System.Byte[]> rgbHash, IObservable<System.Byte[]> rgbSignature)
{
    return Observable.Zip(DSASignatureDeformatterValue, rgbHash, rgbSignature, (DSASignatureDeformatterValueLambda, rgbHashLambda, rgbSignatureLambda) => DSASignatureDeformatterValueLambda.VerifySignature(rgbHashLambda, rgbSignatureLambda));
}

}
}