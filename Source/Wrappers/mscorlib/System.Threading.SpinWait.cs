using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
public static class _SpinWait
{
    
public static IObservable<System.Reactive.Unit> SpinOnce(this IObservable<System.Threading.SpinWait> SpinWaitValue)
{
    return Observable.Do(SpinWaitValue, (SpinWaitValueLambda) => SpinWaitValueLambda.SpinOnce()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Reset(this IObservable<System.Threading.SpinWait> SpinWaitValue)
{
    return Observable.Do(SpinWaitValue, (SpinWaitValueLambda) => SpinWaitValueLambda.Reset()).ToUnit();
}


public static IObservable<System.Reactive.Unit> SpinUntil(IObservable<System.Func<System.Boolean>> condition)
{
    return Observable.Do(condition, (conditionLambda) => System.Threading.SpinWait.SpinUntil(conditionLambda)).ToUnit();
}


public static IObservable<System.Boolean> SpinUntil(IObservable<System.Func<System.Boolean>> condition, IObservable<System.TimeSpan> timeout)
{
    return Observable.Zip(condition, timeout, (conditionLambda, timeoutLambda) => System.Threading.SpinWait.SpinUntil(conditionLambda, timeoutLambda));
}


public static IObservable<System.Boolean> SpinUntil(IObservable<System.Func<System.Boolean>> condition, IObservable<System.Int32> millisecondsTimeout)
{
    return Observable.Zip(condition, millisecondsTimeout, (conditionLambda, millisecondsTimeoutLambda) => System.Threading.SpinWait.SpinUntil(conditionLambda, millisecondsTimeoutLambda));
}


public static IObservable<System.Int32> get_Count(this IObservable<System.Threading.SpinWait> SpinWaitValue)
{
    return Observable.Select(SpinWaitValue, (SpinWaitValueLambda) => SpinWaitValueLambda.Count);
}


public static IObservable<System.Boolean> get_NextSpinWillYield(this IObservable<System.Threading.SpinWait> SpinWaitValue)
{
    return Observable.Select(SpinWaitValue, (SpinWaitValueLambda) => SpinWaitValueLambda.NextSpinWillYield);
}

}
}