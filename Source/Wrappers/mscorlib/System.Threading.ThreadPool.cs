using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __ThreadPool
    {
        
        public static IObservable<System.Boolean> SetMaxThreads(IObservable<System.Int32> workerThreads, IObservable<System.Int32> completionPortThreads)
        {
            return Observable.Zip(workerThreads, completionPortThreads, (workerThreadsLambda, completionPortThreadsLambda) => System.Threading.ThreadPool.SetMaxThreads(workerThreadsLambda, completionPortThreadsLambda));
        }


        public static IObservable<Tuple<System.Int32, System.Int32>> GetMaxThreads()
        {
            return ObservableExt.Factory(() => {
System.Int32 workerThreadsOutput = default(System.Int32);
System.Int32 completionPortThreadsOutput = default(System.Int32);
System.Threading.ThreadPool.GetMaxThreads(out workerThreadsOutput, out completionPortThreadsOutput);
return Tuple.Create(workerThreadsOutput, completionPortThreadsOutput);
});
        }


        public static IObservable<System.Boolean> SetMinThreads(IObservable<System.Int32> workerThreads, IObservable<System.Int32> completionPortThreads)
        {
            return Observable.Zip(workerThreads, completionPortThreads, (workerThreadsLambda, completionPortThreadsLambda) => System.Threading.ThreadPool.SetMinThreads(workerThreadsLambda, completionPortThreadsLambda));
        }


        public static IObservable<Tuple<System.Int32, System.Int32>> GetMinThreads()
        {
            return ObservableExt.Factory(() => {
System.Int32 workerThreadsOutput = default(System.Int32);
System.Int32 completionPortThreadsOutput = default(System.Int32);
System.Threading.ThreadPool.GetMinThreads(out workerThreadsOutput, out completionPortThreadsOutput);
return Tuple.Create(workerThreadsOutput, completionPortThreadsOutput);
});
        }


        public static IObservable<Tuple<System.Int32, System.Int32>> GetAvailableThreads()
        {
            return ObservableExt.Factory(() => {
System.Int32 workerThreadsOutput = default(System.Int32);
System.Int32 completionPortThreadsOutput = default(System.Int32);
System.Threading.ThreadPool.GetAvailableThreads(out workerThreadsOutput, out completionPortThreadsOutput);
return Tuple.Create(workerThreadsOutput, completionPortThreadsOutput);
});
        }


        public static IObservable<System.Threading.RegisteredWaitHandle> RegisterWaitForSingleObject(IObservable<System.Threading.WaitHandle> waitObject, IObservable<System.Threading.WaitOrTimerCallback> callBack, IObservable<System.Object> state, IObservable<System.UInt32> millisecondsTimeOutInterval, IObservable<System.Boolean> executeOnlyOnce)
        {
            return Observable.Zip(waitObject, callBack, state, millisecondsTimeOutInterval, executeOnlyOnce, (waitObjectLambda, callBackLambda, stateLambda, millisecondsTimeOutIntervalLambda, executeOnlyOnceLambda) => System.Threading.ThreadPool.RegisterWaitForSingleObject(waitObjectLambda, callBackLambda, stateLambda, millisecondsTimeOutIntervalLambda, executeOnlyOnceLambda));
        }


        public static IObservable<System.Threading.RegisteredWaitHandle> UnsafeRegisterWaitForSingleObject(IObservable<System.Threading.WaitHandle> waitObject, IObservable<System.Threading.WaitOrTimerCallback> callBack, IObservable<System.Object> state, IObservable<System.UInt32> millisecondsTimeOutInterval, IObservable<System.Boolean> executeOnlyOnce)
        {
            return Observable.Zip(waitObject, callBack, state, millisecondsTimeOutInterval, executeOnlyOnce, (waitObjectLambda, callBackLambda, stateLambda, millisecondsTimeOutIntervalLambda, executeOnlyOnceLambda) => System.Threading.ThreadPool.UnsafeRegisterWaitForSingleObject(waitObjectLambda, callBackLambda, stateLambda, millisecondsTimeOutIntervalLambda, executeOnlyOnceLambda));
        }


        public static IObservable<System.Threading.RegisteredWaitHandle> RegisterWaitForSingleObject(IObservable<System.Threading.WaitHandle> waitObject, IObservable<System.Threading.WaitOrTimerCallback> callBack, IObservable<System.Object> state, IObservable<System.Int32> millisecondsTimeOutInterval, IObservable<System.Boolean> executeOnlyOnce)
        {
            return Observable.Zip(waitObject, callBack, state, millisecondsTimeOutInterval, executeOnlyOnce, (waitObjectLambda, callBackLambda, stateLambda, millisecondsTimeOutIntervalLambda, executeOnlyOnceLambda) => System.Threading.ThreadPool.RegisterWaitForSingleObject(waitObjectLambda, callBackLambda, stateLambda, millisecondsTimeOutIntervalLambda, executeOnlyOnceLambda));
        }


        public static IObservable<System.Threading.RegisteredWaitHandle> UnsafeRegisterWaitForSingleObject(IObservable<System.Threading.WaitHandle> waitObject, IObservable<System.Threading.WaitOrTimerCallback> callBack, IObservable<System.Object> state, IObservable<System.Int32> millisecondsTimeOutInterval, IObservable<System.Boolean> executeOnlyOnce)
        {
            return Observable.Zip(waitObject, callBack, state, millisecondsTimeOutInterval, executeOnlyOnce, (waitObjectLambda, callBackLambda, stateLambda, millisecondsTimeOutIntervalLambda, executeOnlyOnceLambda) => System.Threading.ThreadPool.UnsafeRegisterWaitForSingleObject(waitObjectLambda, callBackLambda, stateLambda, millisecondsTimeOutIntervalLambda, executeOnlyOnceLambda));
        }


        public static IObservable<System.Threading.RegisteredWaitHandle> RegisterWaitForSingleObject(IObservable<System.Threading.WaitHandle> waitObject, IObservable<System.Threading.WaitOrTimerCallback> callBack, IObservable<System.Object> state, IObservable<System.Int64> millisecondsTimeOutInterval, IObservable<System.Boolean> executeOnlyOnce)
        {
            return Observable.Zip(waitObject, callBack, state, millisecondsTimeOutInterval, executeOnlyOnce, (waitObjectLambda, callBackLambda, stateLambda, millisecondsTimeOutIntervalLambda, executeOnlyOnceLambda) => System.Threading.ThreadPool.RegisterWaitForSingleObject(waitObjectLambda, callBackLambda, stateLambda, millisecondsTimeOutIntervalLambda, executeOnlyOnceLambda));
        }


        public static IObservable<System.Threading.RegisteredWaitHandle> UnsafeRegisterWaitForSingleObject(IObservable<System.Threading.WaitHandle> waitObject, IObservable<System.Threading.WaitOrTimerCallback> callBack, IObservable<System.Object> state, IObservable<System.Int64> millisecondsTimeOutInterval, IObservable<System.Boolean> executeOnlyOnce)
        {
            return Observable.Zip(waitObject, callBack, state, millisecondsTimeOutInterval, executeOnlyOnce, (waitObjectLambda, callBackLambda, stateLambda, millisecondsTimeOutIntervalLambda, executeOnlyOnceLambda) => System.Threading.ThreadPool.UnsafeRegisterWaitForSingleObject(waitObjectLambda, callBackLambda, stateLambda, millisecondsTimeOutIntervalLambda, executeOnlyOnceLambda));
        }


        public static IObservable<System.Threading.RegisteredWaitHandle> RegisterWaitForSingleObject(IObservable<System.Threading.WaitHandle> waitObject, IObservable<System.Threading.WaitOrTimerCallback> callBack, IObservable<System.Object> state, IObservable<System.TimeSpan> timeout, IObservable<System.Boolean> executeOnlyOnce)
        {
            return Observable.Zip(waitObject, callBack, state, timeout, executeOnlyOnce, (waitObjectLambda, callBackLambda, stateLambda, timeoutLambda, executeOnlyOnceLambda) => System.Threading.ThreadPool.RegisterWaitForSingleObject(waitObjectLambda, callBackLambda, stateLambda, timeoutLambda, executeOnlyOnceLambda));
        }


        public static IObservable<System.Threading.RegisteredWaitHandle> UnsafeRegisterWaitForSingleObject(IObservable<System.Threading.WaitHandle> waitObject, IObservable<System.Threading.WaitOrTimerCallback> callBack, IObservable<System.Object> state, IObservable<System.TimeSpan> timeout, IObservable<System.Boolean> executeOnlyOnce)
        {
            return Observable.Zip(waitObject, callBack, state, timeout, executeOnlyOnce, (waitObjectLambda, callBackLambda, stateLambda, timeoutLambda, executeOnlyOnceLambda) => System.Threading.ThreadPool.UnsafeRegisterWaitForSingleObject(waitObjectLambda, callBackLambda, stateLambda, timeoutLambda, executeOnlyOnceLambda));
        }


        public static IObservable<System.Boolean> QueueUserWorkItem(IObservable<System.Threading.WaitCallback> callBack, IObservable<System.Object> state)
        {
            return Observable.Zip(callBack, state, (callBackLambda, stateLambda) => System.Threading.ThreadPool.QueueUserWorkItem(callBackLambda, stateLambda));
        }


        public static IObservable<System.Boolean> QueueUserWorkItem(IObservable<System.Threading.WaitCallback> callBack)
        {
            return Observable.Select(callBack, (callBackLambda) => System.Threading.ThreadPool.QueueUserWorkItem(callBackLambda));
        }


        public static IObservable<System.Boolean> UnsafeQueueUserWorkItem(IObservable<System.Threading.WaitCallback> callBack, IObservable<System.Object> state)
        {
            return Observable.Zip(callBack, state, (callBackLambda, stateLambda) => System.Threading.ThreadPool.UnsafeQueueUserWorkItem(callBackLambda, stateLambda));
        }


        public static IObservable<System.Boolean> BindHandle(IObservable<System.IntPtr> osHandle)
        {
            return Observable.Select(osHandle, (osHandleLambda) => System.Threading.ThreadPool.BindHandle(osHandleLambda));
        }


        public static IObservable<System.Boolean> BindHandle(IObservable<System.Runtime.InteropServices.SafeHandle> osHandle)
        {
            return Observable.Select(osHandle, (osHandleLambda) => System.Threading.ThreadPool.BindHandle(osHandleLambda));
        }

    }
}