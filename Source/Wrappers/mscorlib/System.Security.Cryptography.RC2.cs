using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _RC2
{
    
public static IObservable<System.Security.Cryptography.RC2> Create()
{
    return ObservableExt.Factory(() => System.Security.Cryptography.RC2.Create());
}


public static IObservable<System.Security.Cryptography.RC2> Create(IObservable<System.String> AlgName)
{
    return Observable.Select(AlgName, (AlgNameLambda) => System.Security.Cryptography.RC2.Create(AlgNameLambda));
}


public static IObservable<System.Int32> get_EffectiveKeySize(this IObservable<System.Security.Cryptography.RC2> RC2Value)
{
    return Observable.Select(RC2Value, (RC2ValueLambda) => RC2ValueLambda.EffectiveKeySize);
}


public static IObservable<System.Int32> get_KeySize(this IObservable<System.Security.Cryptography.RC2> RC2Value)
{
    return Observable.Select(RC2Value, (RC2ValueLambda) => RC2ValueLambda.KeySize);
}


public static IObservable<System.Reactive.Unit> set_EffectiveKeySize(this IObservable<System.Security.Cryptography.RC2> RC2Value, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(RC2Value, value, (RC2ValueLambda, valueLambda) => RC2ValueLambda.EffectiveKeySize = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_KeySize(this IObservable<System.Security.Cryptography.RC2> RC2Value, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(RC2Value, value, (RC2ValueLambda, valueLambda) => RC2ValueLambda.KeySize = valueLambda);
}

}
}