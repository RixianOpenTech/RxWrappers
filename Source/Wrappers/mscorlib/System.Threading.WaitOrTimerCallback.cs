using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __WaitOrTimerCallback
    {
        
        public static IObservable<System.Reactive.Unit> Invoke(this IObservable<System.Threading.WaitOrTimerCallback> WaitOrTimerCallbackValue, IObservable<System.Object> state, IObservable<System.Boolean> timedOut)
        {
            return ObservableExt.ZipExecute(WaitOrTimerCallbackValue, state, timedOut, (WaitOrTimerCallbackValueLambda, stateLambda, timedOutLambda) => WaitOrTimerCallbackValueLambda.Invoke(stateLambda, timedOutLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(this IObservable<System.Threading.WaitOrTimerCallback> WaitOrTimerCallbackValue, IObservable<System.Object> state, IObservable<System.Boolean> timedOut, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(WaitOrTimerCallbackValue, state, timedOut, callback, @object, (WaitOrTimerCallbackValueLambda, stateLambda, timedOutLambda, callbackLambda, @objectLambda) => WaitOrTimerCallbackValueLambda.BeginInvoke(stateLambda, timedOutLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke(this IObservable<System.Threading.WaitOrTimerCallback> WaitOrTimerCallbackValue, IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(WaitOrTimerCallbackValue, result, (WaitOrTimerCallbackValueLambda, resultLambda) => WaitOrTimerCallbackValueLambda.EndInvoke(resultLambda));
        }

    }
}