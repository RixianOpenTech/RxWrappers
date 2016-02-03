using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _DES
{
    
public static IObservable<System.Security.Cryptography.DES> Create()
{
    return ObservableExt.Factory(() => System.Security.Cryptography.DES.Create());
}


public static IObservable<System.Security.Cryptography.DES> Create(IObservable<System.String> algName)
{
    return Observable.Select(algName, (algNameLambda) => System.Security.Cryptography.DES.Create(algNameLambda));
}


public static IObservable<System.Boolean> IsWeakKey(IObservable<System.Byte[]> rgbKey)
{
    return Observable.Select(rgbKey, (rgbKeyLambda) => System.Security.Cryptography.DES.IsWeakKey(rgbKeyLambda));
}


public static IObservable<System.Boolean> IsSemiWeakKey(IObservable<System.Byte[]> rgbKey)
{
    return Observable.Select(rgbKey, (rgbKeyLambda) => System.Security.Cryptography.DES.IsSemiWeakKey(rgbKeyLambda));
}


public static IObservable<System.Byte[]> get_Key(this IObservable<System.Security.Cryptography.DES> DESValue)
{
    return Observable.Select(DESValue, (DESValueLambda) => DESValueLambda.Key);
}


public static IObservable<System.Reactive.Unit> set_Key(this IObservable<System.Security.Cryptography.DES> DESValue, IObservable<System.Byte[]> value)
{
    return ObservableExt.ZipExecute(DESValue, value, (DESValueLambda, valueLambda) => DESValueLambda.Key = valueLambda);
}

}
}