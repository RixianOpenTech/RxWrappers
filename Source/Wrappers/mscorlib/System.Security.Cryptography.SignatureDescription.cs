using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _SignatureDescription
{
    
public static IObservable<System.Security.Cryptography.AsymmetricSignatureDeformatter> CreateDeformatter(this IObservable<System.Security.Cryptography.SignatureDescription> SignatureDescriptionValue, IObservable<System.Security.Cryptography.AsymmetricAlgorithm> key)
{
    return Observable.Zip(SignatureDescriptionValue, key, (SignatureDescriptionValueLambda, keyLambda) => SignatureDescriptionValueLambda.CreateDeformatter(keyLambda));
}


public static IObservable<System.Security.Cryptography.AsymmetricSignatureFormatter> CreateFormatter(this IObservable<System.Security.Cryptography.SignatureDescription> SignatureDescriptionValue, IObservable<System.Security.Cryptography.AsymmetricAlgorithm> key)
{
    return Observable.Zip(SignatureDescriptionValue, key, (SignatureDescriptionValueLambda, keyLambda) => SignatureDescriptionValueLambda.CreateFormatter(keyLambda));
}


public static IObservable<System.Security.Cryptography.HashAlgorithm> CreateDigest(this IObservable<System.Security.Cryptography.SignatureDescription> SignatureDescriptionValue)
{
    return Observable.Select(SignatureDescriptionValue, (SignatureDescriptionValueLambda) => SignatureDescriptionValueLambda.CreateDigest());
}


public static IObservable<System.String> get_KeyAlgorithm(this IObservable<System.Security.Cryptography.SignatureDescription> SignatureDescriptionValue)
{
    return Observable.Select(SignatureDescriptionValue, (SignatureDescriptionValueLambda) => SignatureDescriptionValueLambda.KeyAlgorithm);
}


public static IObservable<System.String> get_DigestAlgorithm(this IObservable<System.Security.Cryptography.SignatureDescription> SignatureDescriptionValue)
{
    return Observable.Select(SignatureDescriptionValue, (SignatureDescriptionValueLambda) => SignatureDescriptionValueLambda.DigestAlgorithm);
}


public static IObservable<System.String> get_FormatterAlgorithm(this IObservable<System.Security.Cryptography.SignatureDescription> SignatureDescriptionValue)
{
    return Observable.Select(SignatureDescriptionValue, (SignatureDescriptionValueLambda) => SignatureDescriptionValueLambda.FormatterAlgorithm);
}


public static IObservable<System.String> get_DeformatterAlgorithm(this IObservable<System.Security.Cryptography.SignatureDescription> SignatureDescriptionValue)
{
    return Observable.Select(SignatureDescriptionValue, (SignatureDescriptionValueLambda) => SignatureDescriptionValueLambda.DeformatterAlgorithm);
}


public static IObservable<System.Reactive.Unit> set_KeyAlgorithm(this IObservable<System.Security.Cryptography.SignatureDescription> SignatureDescriptionValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SignatureDescriptionValue, value, (SignatureDescriptionValueLambda, valueLambda) => SignatureDescriptionValueLambda.KeyAlgorithm = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_DigestAlgorithm(this IObservable<System.Security.Cryptography.SignatureDescription> SignatureDescriptionValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SignatureDescriptionValue, value, (SignatureDescriptionValueLambda, valueLambda) => SignatureDescriptionValueLambda.DigestAlgorithm = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_FormatterAlgorithm(this IObservable<System.Security.Cryptography.SignatureDescription> SignatureDescriptionValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SignatureDescriptionValue, value, (SignatureDescriptionValueLambda, valueLambda) => SignatureDescriptionValueLambda.FormatterAlgorithm = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_DeformatterAlgorithm(this IObservable<System.Security.Cryptography.SignatureDescription> SignatureDescriptionValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SignatureDescriptionValue, value, (SignatureDescriptionValueLambda, valueLambda) => SignatureDescriptionValueLambda.DeformatterAlgorithm = valueLambda);
}

}
}