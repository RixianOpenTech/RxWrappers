using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __SemaphoreSlim
    {
        
        public static IObservable<System.Reactive.Unit> Wait(this IObservable<System.Threading.SemaphoreSlim> SemaphoreSlimValue)
        {
            return Observable.Do(SemaphoreSlimValue, (SemaphoreSlimValueLambda) => SemaphoreSlimValueLambda.Wait()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Wait(this IObservable<System.Threading.SemaphoreSlim> SemaphoreSlimValue, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return ObservableExt.ZipExecute(SemaphoreSlimValue, cancellationToken, (SemaphoreSlimValueLambda, cancellationTokenLambda) => SemaphoreSlimValueLambda.Wait(cancellationTokenLambda));
        }


        public static IObservable<System.Boolean> Wait(this IObservable<System.Threading.SemaphoreSlim> SemaphoreSlimValue, IObservable<System.TimeSpan> timeout)
        {
            return Observable.Zip(SemaphoreSlimValue, timeout, (SemaphoreSlimValueLambda, timeoutLambda) => SemaphoreSlimValueLambda.Wait(timeoutLambda));
        }


        public static IObservable<System.Boolean> Wait(this IObservable<System.Threading.SemaphoreSlim> SemaphoreSlimValue, IObservable<System.TimeSpan> timeout, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(SemaphoreSlimValue, timeout, cancellationToken, (SemaphoreSlimValueLambda, timeoutLambda, cancellationTokenLambda) => SemaphoreSlimValueLambda.Wait(timeoutLambda, cancellationTokenLambda));
        }


        public static IObservable<System.Boolean> Wait(this IObservable<System.Threading.SemaphoreSlim> SemaphoreSlimValue, IObservable<System.Int32> millisecondsTimeout)
        {
            return Observable.Zip(SemaphoreSlimValue, millisecondsTimeout, (SemaphoreSlimValueLambda, millisecondsTimeoutLambda) => SemaphoreSlimValueLambda.Wait(millisecondsTimeoutLambda));
        }


        public static IObservable<System.Boolean> Wait(this IObservable<System.Threading.SemaphoreSlim> SemaphoreSlimValue, IObservable<System.Int32> millisecondsTimeout, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(SemaphoreSlimValue, millisecondsTimeout, cancellationToken, (SemaphoreSlimValueLambda, millisecondsTimeoutLambda, cancellationTokenLambda) => SemaphoreSlimValueLambda.Wait(millisecondsTimeoutLambda, cancellationTokenLambda));
        }


        public static IObservable<System.Reactive.Unit> WaitAsync(this IObservable<System.Threading.SemaphoreSlim> SemaphoreSlimValue)
        {
            return Observable.Select(SemaphoreSlimValue, (SemaphoreSlimValueLambda) => SemaphoreSlimValueLambda.WaitAsync().ToObservable()).Flatten().ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WaitAsync(this IObservable<System.Threading.SemaphoreSlim> SemaphoreSlimValue, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(SemaphoreSlimValue, cancellationToken, (SemaphoreSlimValueLambda, cancellationTokenLambda) => SemaphoreSlimValueLambda.WaitAsync(cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Boolean> WaitAsync(this IObservable<System.Threading.SemaphoreSlim> SemaphoreSlimValue, IObservable<System.Int32> millisecondsTimeout)
        {
            return Observable.Zip(SemaphoreSlimValue, millisecondsTimeout, (SemaphoreSlimValueLambda, millisecondsTimeoutLambda) => SemaphoreSlimValueLambda.WaitAsync(millisecondsTimeoutLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Boolean> WaitAsync(this IObservable<System.Threading.SemaphoreSlim> SemaphoreSlimValue, IObservable<System.TimeSpan> timeout)
        {
            return Observable.Zip(SemaphoreSlimValue, timeout, (SemaphoreSlimValueLambda, timeoutLambda) => SemaphoreSlimValueLambda.WaitAsync(timeoutLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Boolean> WaitAsync(this IObservable<System.Threading.SemaphoreSlim> SemaphoreSlimValue, IObservable<System.TimeSpan> timeout, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(SemaphoreSlimValue, timeout, cancellationToken, (SemaphoreSlimValueLambda, timeoutLambda, cancellationTokenLambda) => SemaphoreSlimValueLambda.WaitAsync(timeoutLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Boolean> WaitAsync(this IObservable<System.Threading.SemaphoreSlim> SemaphoreSlimValue, IObservable<System.Int32> millisecondsTimeout, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(SemaphoreSlimValue, millisecondsTimeout, cancellationToken, (SemaphoreSlimValueLambda, millisecondsTimeoutLambda, cancellationTokenLambda) => SemaphoreSlimValueLambda.WaitAsync(millisecondsTimeoutLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Int32> Release(this IObservable<System.Threading.SemaphoreSlim> SemaphoreSlimValue)
        {
            return Observable.Select(SemaphoreSlimValue, (SemaphoreSlimValueLambda) => SemaphoreSlimValueLambda.Release());
        }


        public static IObservable<System.Int32> Release(this IObservable<System.Threading.SemaphoreSlim> SemaphoreSlimValue, IObservable<System.Int32> releaseCount)
        {
            return Observable.Zip(SemaphoreSlimValue, releaseCount, (SemaphoreSlimValueLambda, releaseCountLambda) => SemaphoreSlimValueLambda.Release(releaseCountLambda));
        }


        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Threading.SemaphoreSlim> SemaphoreSlimValue)
        {
            return Observable.Do(SemaphoreSlimValue, (SemaphoreSlimValueLambda) => SemaphoreSlimValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Int32> get_CurrentCount(this IObservable<System.Threading.SemaphoreSlim> SemaphoreSlimValue)
        {
            return Observable.Select(SemaphoreSlimValue, (SemaphoreSlimValueLambda) => SemaphoreSlimValueLambda.CurrentCount);
        }


        public static IObservable<System.Threading.WaitHandle> get_AvailableWaitHandle(this IObservable<System.Threading.SemaphoreSlim> SemaphoreSlimValue)
        {
            return Observable.Select(SemaphoreSlimValue, (SemaphoreSlimValueLambda) => SemaphoreSlimValueLambda.AvailableWaitHandle);
        }

    }
}