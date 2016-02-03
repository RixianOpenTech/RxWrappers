using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __SendOrPostCallback
    {
        public static IObservable<System.Reactive.Unit> Invoke(
            this IObservable<System.Threading.SendOrPostCallback> SendOrPostCallbackValue,
            IObservable<System.Object> state)
        {
            return ObservableExt.ZipExecute(SendOrPostCallbackValue, state,
                (SendOrPostCallbackValueLambda, stateLambda) => SendOrPostCallbackValueLambda.Invoke(stateLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(
            this IObservable<System.Threading.SendOrPostCallback> SendOrPostCallbackValue,
            IObservable<System.Object> state, IObservable<System.AsyncCallback> callback,
            IObservable<System.Object> @object)
        {
            return Observable.Zip(SendOrPostCallbackValue, state, callback, @object,
                (SendOrPostCallbackValueLambda, stateLambda, callbackLambda, @objectLambda) =>
                    SendOrPostCallbackValueLambda.BeginInvoke(stateLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke(
            this IObservable<System.Threading.SendOrPostCallback> SendOrPostCallbackValue,
            IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(SendOrPostCallbackValue, result,
                (SendOrPostCallbackValueLambda, resultLambda) => SendOrPostCallbackValueLambda.EndInvoke(resultLambda));
        }
    }
}