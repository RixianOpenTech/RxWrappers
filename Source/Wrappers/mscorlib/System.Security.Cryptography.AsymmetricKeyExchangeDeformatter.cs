using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _AsymmetricKeyExchangeDeformatter
{
    
public static IObservable<System.Reactive.Unit> SetKey(this IObservable<System.Security.Cryptography.AsymmetricKeyExchangeDeformatter> AsymmetricKeyExchangeDeformatterValue, IObservable<System.Security.Cryptography.AsymmetricAlgorithm> key)
{
    return ObservableExt.ZipExecute(AsymmetricKeyExchangeDeformatterValue, key, (AsymmetricKeyExchangeDeformatterValueLambda, keyLambda) => AsymmetricKeyExchangeDeformatterValueLambda.SetKey(keyLambda));
}


public static IObservable<System.Byte[]> DecryptKeyExchange(this IObservable<System.Security.Cryptography.AsymmetricKeyExchangeDeformatter> AsymmetricKeyExchangeDeformatterValue, IObservable<System.Byte[]> rgb)
{
    return Observable.Zip(AsymmetricKeyExchangeDeformatterValue, rgb, (AsymmetricKeyExchangeDeformatterValueLambda, rgbLambda) => AsymmetricKeyExchangeDeformatterValueLambda.DecryptKeyExchange(rgbLambda));
}


public static IObservable<System.String> get_Parameters(this IObservable<System.Security.Cryptography.AsymmetricKeyExchangeDeformatter> AsymmetricKeyExchangeDeformatterValue)
{
    return Observable.Select(AsymmetricKeyExchangeDeformatterValue, (AsymmetricKeyExchangeDeformatterValueLambda) => AsymmetricKeyExchangeDeformatterValueLambda.Parameters);
}


public static IObservable<System.Reactive.Unit> set_Parameters(this IObservable<System.Security.Cryptography.AsymmetricKeyExchangeDeformatter> AsymmetricKeyExchangeDeformatterValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(AsymmetricKeyExchangeDeformatterValue, value, (AsymmetricKeyExchangeDeformatterValueLambda, valueLambda) => AsymmetricKeyExchangeDeformatterValueLambda.Parameters = valueLambda);
}

}
}