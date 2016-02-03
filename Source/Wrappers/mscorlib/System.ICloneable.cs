using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _ICloneable
{
    
public static IObservable<System.Object> Clone(this IObservable<System.ICloneable> ICloneableValue)
{
    return Observable.Select(ICloneableValue, (ICloneableValueLambda) => ICloneableValueLambda.Clone());
}

}
}