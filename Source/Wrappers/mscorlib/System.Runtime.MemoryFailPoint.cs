using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime
{
public static class _MemoryFailPoint
{
    
public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Runtime.MemoryFailPoint> MemoryFailPointValue)
{
    return Observable.Do(MemoryFailPointValue, (MemoryFailPointValueLambda) => MemoryFailPointValueLambda.Dispose()).ToUnit();
}

}
}