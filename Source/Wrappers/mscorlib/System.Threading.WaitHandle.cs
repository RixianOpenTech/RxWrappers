using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __WaitHandle
    {
        
        public static IObservable<System.Boolean> WaitOne(this IObservable<System.Threading.WaitHandle> WaitHandleValue, IObservable<System.Int32> millisecondsTimeout, IObservable<System.Boolean> exitContext)
        {
            return Observable.Zip(WaitHandleValue, millisecondsTimeout, exitContext, (WaitHandleValueLambda, millisecondsTimeoutLambda, exitContextLambda) => WaitHandleValueLambda.WaitOne(millisecondsTimeoutLambda, exitContextLambda));
        }


        public static IObservable<System.Boolean> WaitOne(this IObservable<System.Threading.WaitHandle> WaitHandleValue, IObservable<System.TimeSpan> timeout, IObservable<System.Boolean> exitContext)
        {
            return Observable.Zip(WaitHandleValue, timeout, exitContext, (WaitHandleValueLambda, timeoutLambda, exitContextLambda) => WaitHandleValueLambda.WaitOne(timeoutLambda, exitContextLambda));
        }


        public static IObservable<System.Boolean> WaitOne(this IObservable<System.Threading.WaitHandle> WaitHandleValue)
        {
            return Observable.Select(WaitHandleValue, (WaitHandleValueLambda) => WaitHandleValueLambda.WaitOne());
        }


        public static IObservable<System.Boolean> WaitOne(this IObservable<System.Threading.WaitHandle> WaitHandleValue, IObservable<System.Int32> millisecondsTimeout)
        {
            return Observable.Zip(WaitHandleValue, millisecondsTimeout, (WaitHandleValueLambda, millisecondsTimeoutLambda) => WaitHandleValueLambda.WaitOne(millisecondsTimeoutLambda));
        }


        public static IObservable<System.Boolean> WaitOne(this IObservable<System.Threading.WaitHandle> WaitHandleValue, IObservable<System.TimeSpan> timeout)
        {
            return Observable.Zip(WaitHandleValue, timeout, (WaitHandleValueLambda, timeoutLambda) => WaitHandleValueLambda.WaitOne(timeoutLambda));
        }


        public static IObservable<System.Boolean> WaitAll(IObservable<System.Threading.WaitHandle[]> waitHandles, IObservable<System.Int32> millisecondsTimeout, IObservable<System.Boolean> exitContext)
        {
            return Observable.Zip(waitHandles, millisecondsTimeout, exitContext, (waitHandlesLambda, millisecondsTimeoutLambda, exitContextLambda) => System.Threading.WaitHandle.WaitAll(waitHandlesLambda, millisecondsTimeoutLambda, exitContextLambda));
        }


        public static IObservable<System.Boolean> WaitAll(IObservable<System.Threading.WaitHandle[]> waitHandles, IObservable<System.TimeSpan> timeout, IObservable<System.Boolean> exitContext)
        {
            return Observable.Zip(waitHandles, timeout, exitContext, (waitHandlesLambda, timeoutLambda, exitContextLambda) => System.Threading.WaitHandle.WaitAll(waitHandlesLambda, timeoutLambda, exitContextLambda));
        }


        public static IObservable<System.Boolean> WaitAll(IObservable<System.Threading.WaitHandle[]> waitHandles)
        {
            return Observable.Select(waitHandles, (waitHandlesLambda) => System.Threading.WaitHandle.WaitAll(waitHandlesLambda));
        }


        public static IObservable<System.Boolean> WaitAll(IObservable<System.Threading.WaitHandle[]> waitHandles, IObservable<System.Int32> millisecondsTimeout)
        {
            return Observable.Zip(waitHandles, millisecondsTimeout, (waitHandlesLambda, millisecondsTimeoutLambda) => System.Threading.WaitHandle.WaitAll(waitHandlesLambda, millisecondsTimeoutLambda));
        }


        public static IObservable<System.Boolean> WaitAll(IObservable<System.Threading.WaitHandle[]> waitHandles, IObservable<System.TimeSpan> timeout)
        {
            return Observable.Zip(waitHandles, timeout, (waitHandlesLambda, timeoutLambda) => System.Threading.WaitHandle.WaitAll(waitHandlesLambda, timeoutLambda));
        }


        public static IObservable<System.Int32> WaitAny(IObservable<System.Threading.WaitHandle[]> waitHandles, IObservable<System.Int32> millisecondsTimeout, IObservable<System.Boolean> exitContext)
        {
            return Observable.Zip(waitHandles, millisecondsTimeout, exitContext, (waitHandlesLambda, millisecondsTimeoutLambda, exitContextLambda) => System.Threading.WaitHandle.WaitAny(waitHandlesLambda, millisecondsTimeoutLambda, exitContextLambda));
        }


        public static IObservable<System.Int32> WaitAny(IObservable<System.Threading.WaitHandle[]> waitHandles, IObservable<System.TimeSpan> timeout, IObservable<System.Boolean> exitContext)
        {
            return Observable.Zip(waitHandles, timeout, exitContext, (waitHandlesLambda, timeoutLambda, exitContextLambda) => System.Threading.WaitHandle.WaitAny(waitHandlesLambda, timeoutLambda, exitContextLambda));
        }


        public static IObservable<System.Int32> WaitAny(IObservable<System.Threading.WaitHandle[]> waitHandles, IObservable<System.TimeSpan> timeout)
        {
            return Observable.Zip(waitHandles, timeout, (waitHandlesLambda, timeoutLambda) => System.Threading.WaitHandle.WaitAny(waitHandlesLambda, timeoutLambda));
        }


        public static IObservable<System.Int32> WaitAny(IObservable<System.Threading.WaitHandle[]> waitHandles)
        {
            return Observable.Select(waitHandles, (waitHandlesLambda) => System.Threading.WaitHandle.WaitAny(waitHandlesLambda));
        }


        public static IObservable<System.Int32> WaitAny(IObservable<System.Threading.WaitHandle[]> waitHandles, IObservable<System.Int32> millisecondsTimeout)
        {
            return Observable.Zip(waitHandles, millisecondsTimeout, (waitHandlesLambda, millisecondsTimeoutLambda) => System.Threading.WaitHandle.WaitAny(waitHandlesLambda, millisecondsTimeoutLambda));
        }


        public static IObservable<System.Boolean> SignalAndWait(IObservable<System.Threading.WaitHandle> toSignal, IObservable<System.Threading.WaitHandle> toWaitOn)
        {
            return Observable.Zip(toSignal, toWaitOn, (toSignalLambda, toWaitOnLambda) => System.Threading.WaitHandle.SignalAndWait(toSignalLambda, toWaitOnLambda));
        }


        public static IObservable<System.Boolean> SignalAndWait(IObservable<System.Threading.WaitHandle> toSignal, IObservable<System.Threading.WaitHandle> toWaitOn, IObservable<System.TimeSpan> timeout, IObservable<System.Boolean> exitContext)
        {
            return Observable.Zip(toSignal, toWaitOn, timeout, exitContext, (toSignalLambda, toWaitOnLambda, timeoutLambda, exitContextLambda) => System.Threading.WaitHandle.SignalAndWait(toSignalLambda, toWaitOnLambda, timeoutLambda, exitContextLambda));
        }


        public static IObservable<System.Boolean> SignalAndWait(IObservable<System.Threading.WaitHandle> toSignal, IObservable<System.Threading.WaitHandle> toWaitOn, IObservable<System.Int32> millisecondsTimeout, IObservable<System.Boolean> exitContext)
        {
            return Observable.Zip(toSignal, toWaitOn, millisecondsTimeout, exitContext, (toSignalLambda, toWaitOnLambda, millisecondsTimeoutLambda, exitContextLambda) => System.Threading.WaitHandle.SignalAndWait(toSignalLambda, toWaitOnLambda, millisecondsTimeoutLambda, exitContextLambda));
        }


        public static IObservable<System.Reactive.Unit> Close(this IObservable<System.Threading.WaitHandle> WaitHandleValue)
        {
            return Observable.Do(WaitHandleValue, (WaitHandleValueLambda) => WaitHandleValueLambda.Close()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Threading.WaitHandle> WaitHandleValue)
        {
            return Observable.Do(WaitHandleValue, (WaitHandleValueLambda) => WaitHandleValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.IntPtr> get_Handle(this IObservable<System.Threading.WaitHandle> WaitHandleValue)
        {
            return Observable.Select(WaitHandleValue, (WaitHandleValueLambda) => WaitHandleValueLambda.Handle);
        }


        public static IObservable<Microsoft.Win32.SafeHandles.SafeWaitHandle> get_SafeWaitHandle(this IObservable<System.Threading.WaitHandle> WaitHandleValue)
        {
            return Observable.Select(WaitHandleValue, (WaitHandleValueLambda) => WaitHandleValueLambda.SafeWaitHandle);
        }


        public static IObservable<System.Reactive.Unit> set_Handle(this IObservable<System.Threading.WaitHandle> WaitHandleValue, IObservable<System.IntPtr> value)
        {
            return ObservableExt.ZipExecute(WaitHandleValue, value, (WaitHandleValueLambda, valueLambda) => WaitHandleValueLambda.Handle = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_SafeWaitHandle(this IObservable<System.Threading.WaitHandle> WaitHandleValue, IObservable<Microsoft.Win32.SafeHandles.SafeWaitHandle> value)
        {
            return ObservableExt.ZipExecute(WaitHandleValue, value, (WaitHandleValueLambda, valueLambda) => WaitHandleValueLambda.SafeWaitHandle = valueLambda);
        }

    }
}