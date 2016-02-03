using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
public static class _ReaderWriterLock
{
    
public static IObservable<System.Reactive.Unit> AcquireReaderLock(this IObservable<System.Threading.ReaderWriterLock> ReaderWriterLockValue, IObservable<System.Int32> millisecondsTimeout)
{
    return ObservableExt.ZipExecute(ReaderWriterLockValue, millisecondsTimeout, (ReaderWriterLockValueLambda, millisecondsTimeoutLambda) => ReaderWriterLockValueLambda.AcquireReaderLock(millisecondsTimeoutLambda));
}


public static IObservable<System.Reactive.Unit> AcquireReaderLock(this IObservable<System.Threading.ReaderWriterLock> ReaderWriterLockValue, IObservable<System.TimeSpan> timeout)
{
    return ObservableExt.ZipExecute(ReaderWriterLockValue, timeout, (ReaderWriterLockValueLambda, timeoutLambda) => ReaderWriterLockValueLambda.AcquireReaderLock(timeoutLambda));
}


public static IObservable<System.Reactive.Unit> AcquireWriterLock(this IObservable<System.Threading.ReaderWriterLock> ReaderWriterLockValue, IObservable<System.Int32> millisecondsTimeout)
{
    return ObservableExt.ZipExecute(ReaderWriterLockValue, millisecondsTimeout, (ReaderWriterLockValueLambda, millisecondsTimeoutLambda) => ReaderWriterLockValueLambda.AcquireWriterLock(millisecondsTimeoutLambda));
}


public static IObservable<System.Reactive.Unit> AcquireWriterLock(this IObservable<System.Threading.ReaderWriterLock> ReaderWriterLockValue, IObservable<System.TimeSpan> timeout)
{
    return ObservableExt.ZipExecute(ReaderWriterLockValue, timeout, (ReaderWriterLockValueLambda, timeoutLambda) => ReaderWriterLockValueLambda.AcquireWriterLock(timeoutLambda));
}


public static IObservable<System.Reactive.Unit> ReleaseReaderLock(this IObservable<System.Threading.ReaderWriterLock> ReaderWriterLockValue)
{
    return Observable.Do(ReaderWriterLockValue, (ReaderWriterLockValueLambda) => ReaderWriterLockValueLambda.ReleaseReaderLock()).ToUnit();
}


public static IObservable<System.Reactive.Unit> ReleaseWriterLock(this IObservable<System.Threading.ReaderWriterLock> ReaderWriterLockValue)
{
    return Observable.Do(ReaderWriterLockValue, (ReaderWriterLockValueLambda) => ReaderWriterLockValueLambda.ReleaseWriterLock()).ToUnit();
}


public static IObservable<System.Threading.LockCookie> UpgradeToWriterLock(this IObservable<System.Threading.ReaderWriterLock> ReaderWriterLockValue, IObservable<System.Int32> millisecondsTimeout)
{
    return Observable.Zip(ReaderWriterLockValue, millisecondsTimeout, (ReaderWriterLockValueLambda, millisecondsTimeoutLambda) => ReaderWriterLockValueLambda.UpgradeToWriterLock(millisecondsTimeoutLambda));
}


public static IObservable<System.Threading.LockCookie> UpgradeToWriterLock(this IObservable<System.Threading.ReaderWriterLock> ReaderWriterLockValue, IObservable<System.TimeSpan> timeout)
{
    return Observable.Zip(ReaderWriterLockValue, timeout, (ReaderWriterLockValueLambda, timeoutLambda) => ReaderWriterLockValueLambda.UpgradeToWriterLock(timeoutLambda));
}


public static IObservable<System.Threading.LockCookie> DowngradeFromWriterLock(this IObservable<System.Threading.ReaderWriterLock> ReaderWriterLockValue, IObservable<System.Threading.LockCookie> lockCookie)
{
    return Observable.Zip(ReaderWriterLockValue, lockCookie, (ReaderWriterLockValueLambda, lockCookieLambda) => {
ReaderWriterLockValueLambda.DowngradeFromWriterLock(ref lockCookieLambda);
return lockCookieLambda;
});
}


public static IObservable<System.Threading.LockCookie> ReleaseLock(this IObservable<System.Threading.ReaderWriterLock> ReaderWriterLockValue)
{
    return Observable.Select(ReaderWriterLockValue, (ReaderWriterLockValueLambda) => ReaderWriterLockValueLambda.ReleaseLock());
}


public static IObservable<System.Threading.LockCookie> RestoreLock(this IObservable<System.Threading.ReaderWriterLock> ReaderWriterLockValue, IObservable<System.Threading.LockCookie> lockCookie)
{
    return Observable.Zip(ReaderWriterLockValue, lockCookie, (ReaderWriterLockValueLambda, lockCookieLambda) => {
ReaderWriterLockValueLambda.RestoreLock(ref lockCookieLambda);
return lockCookieLambda;
});
}


public static IObservable<System.Boolean> AnyWritersSince(this IObservable<System.Threading.ReaderWriterLock> ReaderWriterLockValue, IObservable<System.Int32> seqNum)
{
    return Observable.Zip(ReaderWriterLockValue, seqNum, (ReaderWriterLockValueLambda, seqNumLambda) => ReaderWriterLockValueLambda.AnyWritersSince(seqNumLambda));
}


public static IObservable<System.Boolean> get_IsReaderLockHeld(this IObservable<System.Threading.ReaderWriterLock> ReaderWriterLockValue)
{
    return Observable.Select(ReaderWriterLockValue, (ReaderWriterLockValueLambda) => ReaderWriterLockValueLambda.IsReaderLockHeld);
}


public static IObservable<System.Boolean> get_IsWriterLockHeld(this IObservable<System.Threading.ReaderWriterLock> ReaderWriterLockValue)
{
    return Observable.Select(ReaderWriterLockValue, (ReaderWriterLockValueLambda) => ReaderWriterLockValueLambda.IsWriterLockHeld);
}


public static IObservable<System.Int32> get_WriterSeqNum(this IObservable<System.Threading.ReaderWriterLock> ReaderWriterLockValue)
{
    return Observable.Select(ReaderWriterLockValue, (ReaderWriterLockValueLambda) => ReaderWriterLockValueLambda.WriterSeqNum);
}

}
}