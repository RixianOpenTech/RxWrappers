using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _TripleDES
{
    
public static IObservable<System.Security.Cryptography.TripleDES> Create()
{
    return ObservableExt.Factory(() => System.Security.Cryptography.TripleDES.Create());
}


public static IObservable<System.Security.Cryptography.TripleDES> Create(IObservable<System.String> str)
{
    return Observable.Select(str, (strLambda) => System.Security.Cryptography.TripleDES.Create(strLambda));
}


public static IObservable<System.Boolean> IsWeakKey(IObservable<System.Byte[]> rgbKey)
{
    return Observable.Select(rgbKey, (rgbKeyLambda) => System.Security.Cryptography.TripleDES.IsWeakKey(rgbKeyLambda));
}


public static IObservable<System.Byte[]> get_Key(this IObservable<System.Security.Cryptography.TripleDES> TripleDESValue)
{
    return Observable.Select(TripleDESValue, (TripleDESValueLambda) => TripleDESValueLambda.Key);
}


public static IObservable<System.Reactive.Unit> set_Key(this IObservable<System.Security.Cryptography.TripleDES> TripleDESValue, IObservable<System.Byte[]> value)
{
    return ObservableExt.ZipExecute(TripleDESValue, value, (TripleDESValueLambda, valueLambda) => TripleDESValueLambda.Key = valueLambda);
}

}
}