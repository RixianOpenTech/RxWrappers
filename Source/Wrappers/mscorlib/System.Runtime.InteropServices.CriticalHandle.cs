using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _CriticalHandle
{
    
public static IObservable<System.Reactive.Unit> Close(this IObservable<System.Runtime.InteropServices.CriticalHandle> CriticalHandleValue)
{
    return Observable.Do(CriticalHandleValue, (CriticalHandleValueLambda) => CriticalHandleValueLambda.Close()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Runtime.InteropServices.CriticalHandle> CriticalHandleValue)
{
    return Observable.Do(CriticalHandleValue, (CriticalHandleValueLambda) => CriticalHandleValueLambda.Dispose()).ToUnit();
}


public static IObservable<System.Reactive.Unit> SetHandleAsInvalid(this IObservable<System.Runtime.InteropServices.CriticalHandle> CriticalHandleValue)
{
    return Observable.Do(CriticalHandleValue, (CriticalHandleValueLambda) => CriticalHandleValueLambda.SetHandleAsInvalid()).ToUnit();
}


public static IObservable<System.Boolean> get_IsClosed(this IObservable<System.Runtime.InteropServices.CriticalHandle> CriticalHandleValue)
{
    return Observable.Select(CriticalHandleValue, (CriticalHandleValueLambda) => CriticalHandleValueLambda.IsClosed);
}


public static IObservable<System.Boolean> get_IsInvalid(this IObservable<System.Runtime.InteropServices.CriticalHandle> CriticalHandleValue)
{
    return Observable.Select(CriticalHandleValue, (CriticalHandleValueLambda) => CriticalHandleValueLambda.IsInvalid);
}

}
}