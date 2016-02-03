using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __ManualResetEventSlim
    {
        public static IObservable<System.Reactive.Unit> Set(
            this IObservable<System.Threading.ManualResetEventSlim> ManualResetEventSlimValue)
        {
            return
                Observable.Do(ManualResetEventSlimValue,
                    (ManualResetEventSlimValueLambda) => ManualResetEventSlimValueLambda.Set()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Reset(
            this IObservable<System.Threading.ManualResetEventSlim> ManualResetEventSlimValue)
        {
            return
                Observable.Do(ManualResetEventSlimValue,
                    (ManualResetEventSlimValueLambda) => ManualResetEventSlimValueLambda.Reset()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Wait(
            this IObservable<System.Threading.ManualResetEventSlim> ManualResetEventSlimValue)
        {
            return
                Observable.Do(ManualResetEventSlimValue,
                    (ManualResetEventSlimValueLambda) => ManualResetEventSlimValueLambda.Wait()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Wait(
            this IObservable<System.Threading.ManualResetEventSlim> ManualResetEventSlimValue,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return ObservableExt.ZipExecute(ManualResetEventSlimValue, cancellationToken,
                (ManualResetEventSlimValueLambda, cancellationTokenLambda) =>
                    ManualResetEventSlimValueLambda.Wait(cancellationTokenLambda));
        }


        public static IObservable<System.Boolean> Wait(
            this IObservable<System.Threading.ManualResetEventSlim> ManualResetEventSlimValue,
            IObservable<System.TimeSpan> timeout)
        {
            return Observable.Zip(ManualResetEventSlimValue, timeout,
                (ManualResetEventSlimValueLambda, timeoutLambda) => ManualResetEventSlimValueLambda.Wait(timeoutLambda));
        }


        public static IObservable<System.Boolean> Wait(
            this IObservable<System.Threading.ManualResetEventSlim> ManualResetEventSlimValue,
            IObservable<System.TimeSpan> timeout, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(ManualResetEventSlimValue, timeout, cancellationToken,
                (ManualResetEventSlimValueLambda, timeoutLambda, cancellationTokenLambda) =>
                    ManualResetEventSlimValueLambda.Wait(timeoutLambda, cancellationTokenLambda));
        }


        public static IObservable<System.Boolean> Wait(
            this IObservable<System.Threading.ManualResetEventSlim> ManualResetEventSlimValue,
            IObservable<System.Int32> millisecondsTimeout)
        {
            return Observable.Zip(ManualResetEventSlimValue, millisecondsTimeout,
                (ManualResetEventSlimValueLambda, millisecondsTimeoutLambda) =>
                    ManualResetEventSlimValueLambda.Wait(millisecondsTimeoutLambda));
        }


        public static IObservable<System.Boolean> Wait(
            this IObservable<System.Threading.ManualResetEventSlim> ManualResetEventSlimValue,
            IObservable<System.Int32> millisecondsTimeout,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(ManualResetEventSlimValue, millisecondsTimeout, cancellationToken,
                (ManualResetEventSlimValueLambda, millisecondsTimeoutLambda, cancellationTokenLambda) =>
                    ManualResetEventSlimValueLambda.Wait(millisecondsTimeoutLambda, cancellationTokenLambda));
        }


        public static IObservable<System.Reactive.Unit> Dispose(
            this IObservable<System.Threading.ManualResetEventSlim> ManualResetEventSlimValue)
        {
            return
                Observable.Do(ManualResetEventSlimValue,
                    (ManualResetEventSlimValueLambda) => ManualResetEventSlimValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Threading.WaitHandle> get_WaitHandle(
            this IObservable<System.Threading.ManualResetEventSlim> ManualResetEventSlimValue)
        {
            return Observable.Select(ManualResetEventSlimValue,
                (ManualResetEventSlimValueLambda) => ManualResetEventSlimValueLambda.WaitHandle);
        }


        public static IObservable<System.Boolean> get_IsSet(
            this IObservable<System.Threading.ManualResetEventSlim> ManualResetEventSlimValue)
        {
            return Observable.Select(ManualResetEventSlimValue,
                (ManualResetEventSlimValueLambda) => ManualResetEventSlimValueLambda.IsSet);
        }


        public static IObservable<System.Int32> get_SpinCount(
            this IObservable<System.Threading.ManualResetEventSlim> ManualResetEventSlimValue)
        {
            return Observable.Select(ManualResetEventSlimValue,
                (ManualResetEventSlimValueLambda) => ManualResetEventSlimValueLambda.SpinCount);
        }
    }
}