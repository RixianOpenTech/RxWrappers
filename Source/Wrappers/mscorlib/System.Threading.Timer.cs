using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
public static class _Timer
{
    
public static IObservable<System.Boolean> Change(this IObservable<System.Threading.Timer> TimerValue, IObservable<System.Int32> dueTime, IObservable<System.Int32> period)
{
    return Observable.Zip(TimerValue, dueTime, period, (TimerValueLambda, dueTimeLambda, periodLambda) => TimerValueLambda.Change(dueTimeLambda, periodLambda));
}


public static IObservable<System.Boolean> Change(this IObservable<System.Threading.Timer> TimerValue, IObservable<System.TimeSpan> dueTime, IObservable<System.TimeSpan> period)
{
    return Observable.Zip(TimerValue, dueTime, period, (TimerValueLambda, dueTimeLambda, periodLambda) => TimerValueLambda.Change(dueTimeLambda, periodLambda));
}


public static IObservable<System.Boolean> Change(this IObservable<System.Threading.Timer> TimerValue, IObservable<System.UInt32> dueTime, IObservable<System.UInt32> period)
{
    return Observable.Zip(TimerValue, dueTime, period, (TimerValueLambda, dueTimeLambda, periodLambda) => TimerValueLambda.Change(dueTimeLambda, periodLambda));
}


public static IObservable<System.Boolean> Change(this IObservable<System.Threading.Timer> TimerValue, IObservable<System.Int64> dueTime, IObservable<System.Int64> period)
{
    return Observable.Zip(TimerValue, dueTime, period, (TimerValueLambda, dueTimeLambda, periodLambda) => TimerValueLambda.Change(dueTimeLambda, periodLambda));
}


public static IObservable<System.Boolean> Dispose(this IObservable<System.Threading.Timer> TimerValue, IObservable<System.Threading.WaitHandle> notifyObject)
{
    return Observable.Zip(TimerValue, notifyObject, (TimerValueLambda, notifyObjectLambda) => TimerValueLambda.Dispose(notifyObjectLambda));
}


public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Threading.Timer> TimerValue)
{
    return Observable.Do(TimerValue, (TimerValueLambda) => TimerValueLambda.Dispose()).ToUnit();
}

}
}