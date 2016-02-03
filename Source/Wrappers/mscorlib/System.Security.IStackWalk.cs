using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
public static class _IStackWalk
{
    
public static IObservable<System.Reactive.Unit> Assert(this IObservable<System.Security.IStackWalk> IStackWalkValue)
{
    return Observable.Do(IStackWalkValue, (IStackWalkValueLambda) => IStackWalkValueLambda.Assert()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Demand(this IObservable<System.Security.IStackWalk> IStackWalkValue)
{
    return Observable.Do(IStackWalkValue, (IStackWalkValueLambda) => IStackWalkValueLambda.Demand()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Deny(this IObservable<System.Security.IStackWalk> IStackWalkValue)
{
    return Observable.Do(IStackWalkValue, (IStackWalkValueLambda) => IStackWalkValueLambda.Deny()).ToUnit();
}


public static IObservable<System.Reactive.Unit> PermitOnly(this IObservable<System.Security.IStackWalk> IStackWalkValue)
{
    return Observable.Do(IStackWalkValue, (IStackWalkValueLambda) => IStackWalkValueLambda.PermitOnly()).ToUnit();
}

}
}