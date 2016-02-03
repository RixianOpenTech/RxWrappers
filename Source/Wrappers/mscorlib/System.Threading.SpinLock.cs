using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
public static class _SpinLock
{
    
public static IObservable<System.Boolean> Enter(this IObservable<System.Threading.SpinLock> SpinLockValue, IObservable<System.Boolean> lockTaken)
{
    return Observable.Zip(SpinLockValue, lockTaken, (SpinLockValueLambda, lockTakenLambda) => {
SpinLockValueLambda.Enter(ref lockTakenLambda);
return lockTakenLambda;
});
}


public static IObservable<System.Boolean> TryEnter(this IObservable<System.Threading.SpinLock> SpinLockValue, IObservable<System.Boolean> lockTaken)
{
    return Observable.Zip(SpinLockValue, lockTaken, (SpinLockValueLambda, lockTakenLambda) => {
SpinLockValueLambda.TryEnter(ref lockTakenLambda);
return lockTakenLambda;
});
}


public static IObservable<System.Boolean> TryEnter(this IObservable<System.Threading.SpinLock> SpinLockValue, IObservable<System.TimeSpan> timeout, IObservable<System.Boolean> lockTaken)
{
    return Observable.Zip(SpinLockValue, timeout, lockTaken, (SpinLockValueLambda, timeoutLambda, lockTakenLambda) => {
SpinLockValueLambda.TryEnter(timeoutLambda, ref lockTakenLambda);
return lockTakenLambda;
});
}


public static IObservable<System.Boolean> TryEnter(this IObservable<System.Threading.SpinLock> SpinLockValue, IObservable<System.Int32> millisecondsTimeout, IObservable<System.Boolean> lockTaken)
{
    return Observable.Zip(SpinLockValue, millisecondsTimeout, lockTaken, (SpinLockValueLambda, millisecondsTimeoutLambda, lockTakenLambda) => {
SpinLockValueLambda.TryEnter(millisecondsTimeoutLambda, ref lockTakenLambda);
return lockTakenLambda;
});
}


public static IObservable<System.Reactive.Unit> Exit(this IObservable<System.Threading.SpinLock> SpinLockValue)
{
    return Observable.Do(SpinLockValue, (SpinLockValueLambda) => SpinLockValueLambda.Exit()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Exit(this IObservable<System.Threading.SpinLock> SpinLockValue, IObservable<System.Boolean> useMemoryBarrier)
{
    return ObservableExt.ZipExecute(SpinLockValue, useMemoryBarrier, (SpinLockValueLambda, useMemoryBarrierLambda) => SpinLockValueLambda.Exit(useMemoryBarrierLambda));
}


public static IObservable<System.Boolean> get_IsHeld(this IObservable<System.Threading.SpinLock> SpinLockValue)
{
    return Observable.Select(SpinLockValue, (SpinLockValueLambda) => SpinLockValueLambda.IsHeld);
}


public static IObservable<System.Boolean> get_IsHeldByCurrentThread(this IObservable<System.Threading.SpinLock> SpinLockValue)
{
    return Observable.Select(SpinLockValue, (SpinLockValueLambda) => SpinLockValueLambda.IsHeldByCurrentThread);
}


public static IObservable<System.Boolean> get_IsThreadOwnerTrackingEnabled(this IObservable<System.Threading.SpinLock> SpinLockValue)
{
    return Observable.Select(SpinLockValue, (SpinLockValueLambda) => SpinLockValueLambda.IsThreadOwnerTrackingEnabled);
}

}
}