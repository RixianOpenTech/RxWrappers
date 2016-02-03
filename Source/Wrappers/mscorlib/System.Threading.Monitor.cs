using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __Monitor
    {
        public static IObservable<System.Reactive.Unit> Enter(IObservable<System.Object> obj)
        {
            return Observable.Do(obj, (objLambda) => System.Threading.Monitor.Enter(objLambda)).ToUnit();
        }


        public static IObservable<System.Boolean> Enter(IObservable<System.Object> obj,
            IObservable<System.Boolean> lockTaken)
        {
            return Observable.Zip(obj, lockTaken, (objLambda, lockTakenLambda) =>
            {
                System.Threading.Monitor.Enter(objLambda, ref lockTakenLambda);
                return lockTakenLambda;
            });
        }


        public static IObservable<System.Reactive.Unit> Exit(IObservable<System.Object> obj)
        {
            return Observable.Do(obj, (objLambda) => System.Threading.Monitor.Exit(objLambda)).ToUnit();
        }


        public static IObservable<System.Boolean> TryEnter(IObservable<System.Object> obj)
        {
            return Observable.Select(obj, (objLambda) => System.Threading.Monitor.TryEnter(objLambda));
        }


        public static IObservable<System.Boolean> TryEnter(IObservable<System.Object> obj,
            IObservable<System.Boolean> lockTaken)
        {
            return Observable.Zip(obj, lockTaken, (objLambda, lockTakenLambda) =>
            {
                System.Threading.Monitor.TryEnter(objLambda, ref lockTakenLambda);
                return lockTakenLambda;
            });
        }


        public static IObservable<System.Boolean> TryEnter(IObservable<System.Object> obj,
            IObservable<System.Int32> millisecondsTimeout)
        {
            return Observable.Zip(obj, millisecondsTimeout,
                (objLambda, millisecondsTimeoutLambda) =>
                    System.Threading.Monitor.TryEnter(objLambda, millisecondsTimeoutLambda));
        }


        public static IObservable<System.Boolean> TryEnter(IObservable<System.Object> obj,
            IObservable<System.TimeSpan> timeout)
        {
            return Observable.Zip(obj, timeout,
                (objLambda, timeoutLambda) => System.Threading.Monitor.TryEnter(objLambda, timeoutLambda));
        }


        public static IObservable<System.Boolean> TryEnter(IObservable<System.Object> obj,
            IObservable<System.Int32> millisecondsTimeout, IObservable<System.Boolean> lockTaken)
        {
            return Observable.Zip(obj, millisecondsTimeout, lockTaken,
                (objLambda, millisecondsTimeoutLambda, lockTakenLambda) =>
                {
                    System.Threading.Monitor.TryEnter(objLambda, millisecondsTimeoutLambda, ref lockTakenLambda);
                    return lockTakenLambda;
                });
        }


        public static IObservable<System.Boolean> TryEnter(IObservable<System.Object> obj,
            IObservable<System.TimeSpan> timeout, IObservable<System.Boolean> lockTaken)
        {
            return Observable.Zip(obj, timeout, lockTaken, (objLambda, timeoutLambda, lockTakenLambda) =>
            {
                System.Threading.Monitor.TryEnter(objLambda, timeoutLambda, ref lockTakenLambda);
                return lockTakenLambda;
            });
        }


        public static IObservable<System.Boolean> IsEntered(IObservable<System.Object> obj)
        {
            return Observable.Select(obj, (objLambda) => System.Threading.Monitor.IsEntered(objLambda));
        }


        public static IObservable<System.Boolean> Wait(IObservable<System.Object> obj,
            IObservable<System.Int32> millisecondsTimeout, IObservable<System.Boolean> exitContext)
        {
            return Observable.Zip(obj, millisecondsTimeout, exitContext,
                (objLambda, millisecondsTimeoutLambda, exitContextLambda) =>
                    System.Threading.Monitor.Wait(objLambda, millisecondsTimeoutLambda, exitContextLambda));
        }


        public static IObservable<System.Boolean> Wait(IObservable<System.Object> obj,
            IObservable<System.TimeSpan> timeout, IObservable<System.Boolean> exitContext)
        {
            return Observable.Zip(obj, timeout, exitContext,
                (objLambda, timeoutLambda, exitContextLambda) =>
                    System.Threading.Monitor.Wait(objLambda, timeoutLambda, exitContextLambda));
        }


        public static IObservable<System.Boolean> Wait(IObservable<System.Object> obj,
            IObservable<System.Int32> millisecondsTimeout)
        {
            return Observable.Zip(obj, millisecondsTimeout,
                (objLambda, millisecondsTimeoutLambda) =>
                    System.Threading.Monitor.Wait(objLambda, millisecondsTimeoutLambda));
        }


        public static IObservable<System.Boolean> Wait(IObservable<System.Object> obj,
            IObservable<System.TimeSpan> timeout)
        {
            return Observable.Zip(obj, timeout,
                (objLambda, timeoutLambda) => System.Threading.Monitor.Wait(objLambda, timeoutLambda));
        }


        public static IObservable<System.Boolean> Wait(IObservable<System.Object> obj)
        {
            return Observable.Select(obj, (objLambda) => System.Threading.Monitor.Wait(objLambda));
        }


        public static IObservable<System.Reactive.Unit> Pulse(IObservable<System.Object> obj)
        {
            return Observable.Do(obj, (objLambda) => System.Threading.Monitor.Pulse(objLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> PulseAll(IObservable<System.Object> obj)
        {
            return Observable.Do(obj, (objLambda) => System.Threading.Monitor.PulseAll(objLambda)).ToUnit();
        }
    }
}