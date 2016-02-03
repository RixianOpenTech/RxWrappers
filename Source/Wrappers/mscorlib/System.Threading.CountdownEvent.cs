using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __CountdownEvent
    {
        public static IObservable<System.Reactive.Unit> Dispose(
            this IObservable<System.Threading.CountdownEvent> CountdownEventValue)
        {
            return
                Observable.Do(CountdownEventValue, (CountdownEventValueLambda) => CountdownEventValueLambda.Dispose())
                    .ToUnit();
        }


        public static IObservable<System.Boolean> Signal(
            this IObservable<System.Threading.CountdownEvent> CountdownEventValue)
        {
            return Observable.Select(CountdownEventValue,
                (CountdownEventValueLambda) => CountdownEventValueLambda.Signal());
        }


        public static IObservable<System.Boolean> Signal(
            this IObservable<System.Threading.CountdownEvent> CountdownEventValue, IObservable<System.Int32> signalCount)
        {
            return Observable.Zip(CountdownEventValue, signalCount,
                (CountdownEventValueLambda, signalCountLambda) => CountdownEventValueLambda.Signal(signalCountLambda));
        }


        public static IObservable<System.Reactive.Unit> AddCount(
            this IObservable<System.Threading.CountdownEvent> CountdownEventValue)
        {
            return
                Observable.Do(CountdownEventValue, (CountdownEventValueLambda) => CountdownEventValueLambda.AddCount())
                    .ToUnit();
        }


        public static IObservable<System.Boolean> TryAddCount(
            this IObservable<System.Threading.CountdownEvent> CountdownEventValue)
        {
            return Observable.Select(CountdownEventValue,
                (CountdownEventValueLambda) => CountdownEventValueLambda.TryAddCount());
        }


        public static IObservable<System.Reactive.Unit> AddCount(
            this IObservable<System.Threading.CountdownEvent> CountdownEventValue, IObservable<System.Int32> signalCount)
        {
            return ObservableExt.ZipExecute(CountdownEventValue, signalCount,
                (CountdownEventValueLambda, signalCountLambda) => CountdownEventValueLambda.AddCount(signalCountLambda));
        }


        public static IObservable<System.Boolean> TryAddCount(
            this IObservable<System.Threading.CountdownEvent> CountdownEventValue, IObservable<System.Int32> signalCount)
        {
            return Observable.Zip(CountdownEventValue, signalCount,
                (CountdownEventValueLambda, signalCountLambda) =>
                    CountdownEventValueLambda.TryAddCount(signalCountLambda));
        }


        public static IObservable<System.Reactive.Unit> Reset(
            this IObservable<System.Threading.CountdownEvent> CountdownEventValue)
        {
            return
                Observable.Do(CountdownEventValue, (CountdownEventValueLambda) => CountdownEventValueLambda.Reset())
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Reset(
            this IObservable<System.Threading.CountdownEvent> CountdownEventValue, IObservable<System.Int32> count)
        {
            return ObservableExt.ZipExecute(CountdownEventValue, count,
                (CountdownEventValueLambda, countLambda) => CountdownEventValueLambda.Reset(countLambda));
        }


        public static IObservable<System.Reactive.Unit> Wait(
            this IObservable<System.Threading.CountdownEvent> CountdownEventValue)
        {
            return
                Observable.Do(CountdownEventValue, (CountdownEventValueLambda) => CountdownEventValueLambda.Wait())
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Wait(
            this IObservable<System.Threading.CountdownEvent> CountdownEventValue,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return ObservableExt.ZipExecute(CountdownEventValue, cancellationToken,
                (CountdownEventValueLambda, cancellationTokenLambda) =>
                    CountdownEventValueLambda.Wait(cancellationTokenLambda));
        }


        public static IObservable<System.Boolean> Wait(
            this IObservable<System.Threading.CountdownEvent> CountdownEventValue, IObservable<System.TimeSpan> timeout)
        {
            return Observable.Zip(CountdownEventValue, timeout,
                (CountdownEventValueLambda, timeoutLambda) => CountdownEventValueLambda.Wait(timeoutLambda));
        }


        public static IObservable<System.Boolean> Wait(
            this IObservable<System.Threading.CountdownEvent> CountdownEventValue, IObservable<System.TimeSpan> timeout,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(CountdownEventValue, timeout, cancellationToken,
                (CountdownEventValueLambda, timeoutLambda, cancellationTokenLambda) =>
                    CountdownEventValueLambda.Wait(timeoutLambda, cancellationTokenLambda));
        }


        public static IObservable<System.Boolean> Wait(
            this IObservable<System.Threading.CountdownEvent> CountdownEventValue,
            IObservable<System.Int32> millisecondsTimeout)
        {
            return Observable.Zip(CountdownEventValue, millisecondsTimeout,
                (CountdownEventValueLambda, millisecondsTimeoutLambda) =>
                    CountdownEventValueLambda.Wait(millisecondsTimeoutLambda));
        }


        public static IObservable<System.Boolean> Wait(
            this IObservable<System.Threading.CountdownEvent> CountdownEventValue,
            IObservable<System.Int32> millisecondsTimeout,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(CountdownEventValue, millisecondsTimeout, cancellationToken,
                (CountdownEventValueLambda, millisecondsTimeoutLambda, cancellationTokenLambda) =>
                    CountdownEventValueLambda.Wait(millisecondsTimeoutLambda, cancellationTokenLambda));
        }


        public static IObservable<System.Int32> get_CurrentCount(
            this IObservable<System.Threading.CountdownEvent> CountdownEventValue)
        {
            return Observable.Select(CountdownEventValue,
                (CountdownEventValueLambda) => CountdownEventValueLambda.CurrentCount);
        }


        public static IObservable<System.Int32> get_InitialCount(
            this IObservable<System.Threading.CountdownEvent> CountdownEventValue)
        {
            return Observable.Select(CountdownEventValue,
                (CountdownEventValueLambda) => CountdownEventValueLambda.InitialCount);
        }


        public static IObservable<System.Boolean> get_IsSet(
            this IObservable<System.Threading.CountdownEvent> CountdownEventValue)
        {
            return Observable.Select(CountdownEventValue, (CountdownEventValueLambda) => CountdownEventValueLambda.IsSet);
        }


        public static IObservable<System.Threading.WaitHandle> get_WaitHandle(
            this IObservable<System.Threading.CountdownEvent> CountdownEventValue)
        {
            return Observable.Select(CountdownEventValue,
                (CountdownEventValueLambda) => CountdownEventValueLambda.WaitHandle);
        }
    }
}