using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __TimerCallback
    {
        public static IObservable<System.Reactive.Unit> Invoke(
            this IObservable<System.Threading.TimerCallback> TimerCallbackValue, IObservable<System.Object> state)
        {
            return ObservableExt.ZipExecute(TimerCallbackValue, state,
                (TimerCallbackValueLambda, stateLambda) => TimerCallbackValueLambda.Invoke(stateLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(
            this IObservable<System.Threading.TimerCallback> TimerCallbackValue, IObservable<System.Object> state,
            IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(TimerCallbackValue, state, callback, @object,
                (TimerCallbackValueLambda, stateLambda, callbackLambda, @objectLambda) =>
                    TimerCallbackValueLambda.BeginInvoke(stateLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke(
            this IObservable<System.Threading.TimerCallback> TimerCallbackValue, IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(TimerCallbackValue, result,
                (TimerCallbackValueLambda, resultLambda) => TimerCallbackValueLambda.EndInvoke(resultLambda));
        }
    }
}