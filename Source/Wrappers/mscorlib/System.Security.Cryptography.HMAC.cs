using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _HMAC
{
    
public static IObservable<System.Security.Cryptography.HMAC> Create()
{
    return ObservableExt.Factory(() => System.Security.Cryptography.HMAC.Create());
}


public static IObservable<System.Security.Cryptography.HMAC> Create(IObservable<System.String> algorithmName)
{
    return Observable.Select(algorithmName, (algorithmNameLambda) => System.Security.Cryptography.HMAC.Create(algorithmNameLambda));
}


public static IObservable<System.Reactive.Unit> Initialize(this IObservable<System.Security.Cryptography.HMAC> HMACValue)
{
    return Observable.Do(HMACValue, (HMACValueLambda) => HMACValueLambda.Initialize()).ToUnit();
}


public static IObservable<System.Byte[]> get_Key(this IObservable<System.Security.Cryptography.HMAC> HMACValue)
{
    return Observable.Select(HMACValue, (HMACValueLambda) => HMACValueLambda.Key);
}


public static IObservable<System.String> get_HashName(this IObservable<System.Security.Cryptography.HMAC> HMACValue)
{
    return Observable.Select(HMACValue, (HMACValueLambda) => HMACValueLambda.HashName);
}


public static IObservable<System.Reactive.Unit> set_Key(this IObservable<System.Security.Cryptography.HMAC> HMACValue, IObservable<System.Byte[]> value)
{
    return ObservableExt.ZipExecute(HMACValue, value, (HMACValueLambda, valueLambda) => HMACValueLambda.Key = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_HashName(this IObservable<System.Security.Cryptography.HMAC> HMACValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(HMACValue, value, (HMACValueLambda, valueLambda) => HMACValueLambda.HashName = valueLambda);
}

}
}