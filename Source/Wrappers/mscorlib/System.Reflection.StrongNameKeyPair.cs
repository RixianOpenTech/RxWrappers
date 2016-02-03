using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _StrongNameKeyPair
{
    
public static IObservable<System.Byte[]> get_PublicKey(this IObservable<System.Reflection.StrongNameKeyPair> StrongNameKeyPairValue)
{
    return Observable.Select(StrongNameKeyPairValue, (StrongNameKeyPairValueLambda) => StrongNameKeyPairValueLambda.PublicKey);
}

}
}