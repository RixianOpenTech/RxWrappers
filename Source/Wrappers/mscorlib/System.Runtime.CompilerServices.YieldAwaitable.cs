using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
public static class _YieldAwaitable
{
    
public static IObservable<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter> GetAwaiter(this IObservable<System.Runtime.CompilerServices.YieldAwaitable> YieldAwaitableValue)
{
    return Observable.Select(YieldAwaitableValue, (YieldAwaitableValueLambda) => YieldAwaitableValueLambda.GetAwaiter());
}

}
}