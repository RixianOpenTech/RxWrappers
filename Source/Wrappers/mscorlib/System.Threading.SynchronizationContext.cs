using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __SynchronizationContext
    {
        public static IObservable<System.Boolean> IsWaitNotificationRequired(
            this IObservable<System.Threading.SynchronizationContext> SynchronizationContextValue)
        {
            return Observable.Select(SynchronizationContextValue,
                (SynchronizationContextValueLambda) => SynchronizationContextValueLambda.IsWaitNotificationRequired());
        }


        public static IObservable<System.Reactive.Unit> Send(
            this IObservable<System.Threading.SynchronizationContext> SynchronizationContextValue,
            IObservable<System.Threading.SendOrPostCallback> d, IObservable<System.Object> state)
        {
            return ObservableExt.ZipExecute(SynchronizationContextValue, d, state,
                (SynchronizationContextValueLambda, dLambda, stateLambda) =>
                    SynchronizationContextValueLambda.Send(dLambda, stateLambda));
        }


        public static IObservable<System.Reactive.Unit> Post(
            this IObservable<System.Threading.SynchronizationContext> SynchronizationContextValue,
            IObservable<System.Threading.SendOrPostCallback> d, IObservable<System.Object> state)
        {
            return ObservableExt.ZipExecute(SynchronizationContextValue, d, state,
                (SynchronizationContextValueLambda, dLambda, stateLambda) =>
                    SynchronizationContextValueLambda.Post(dLambda, stateLambda));
        }


        public static IObservable<System.Reactive.Unit> OperationStarted(
            this IObservable<System.Threading.SynchronizationContext> SynchronizationContextValue)
        {
            return
                Observable.Do(SynchronizationContextValue,
                    (SynchronizationContextValueLambda) => SynchronizationContextValueLambda.OperationStarted())
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> OperationCompleted(
            this IObservable<System.Threading.SynchronizationContext> SynchronizationContextValue)
        {
            return
                Observable.Do(SynchronizationContextValue,
                    (SynchronizationContextValueLambda) => SynchronizationContextValueLambda.OperationCompleted())
                    .ToUnit();
        }


        public static IObservable<System.Int32> Wait(
            this IObservable<System.Threading.SynchronizationContext> SynchronizationContextValue,
            IObservable<System.IntPtr[]> waitHandles, IObservable<System.Boolean> waitAll,
            IObservable<System.Int32> millisecondsTimeout)
        {
            return Observable.Zip(SynchronizationContextValue, waitHandles, waitAll, millisecondsTimeout,
                (SynchronizationContextValueLambda, waitHandlesLambda, waitAllLambda, millisecondsTimeoutLambda) =>
                    SynchronizationContextValueLambda.Wait(waitHandlesLambda, waitAllLambda, millisecondsTimeoutLambda));
        }


        public static IObservable<System.Reactive.Unit> SetSynchronizationContext(
            IObservable<System.Threading.SynchronizationContext> syncContext)
        {
            return
                Observable.Do(syncContext,
                    (syncContextLambda) =>
                        System.Threading.SynchronizationContext.SetSynchronizationContext(syncContextLambda)).ToUnit();
        }


        public static IObservable<System.Threading.SynchronizationContext> CreateCopy(
            this IObservable<System.Threading.SynchronizationContext> SynchronizationContextValue)
        {
            return Observable.Select(SynchronizationContextValue,
                (SynchronizationContextValueLambda) => SynchronizationContextValueLambda.CreateCopy());
        }


        public static IObservable<System.Threading.SynchronizationContext> get_Current()
        {
            return ObservableExt.Factory(() => System.Threading.SynchronizationContext.Current);
        }
    }
}