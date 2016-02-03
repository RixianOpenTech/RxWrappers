using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __ContextCallback
    {
        public static IObservable<System.Reactive.Unit> Invoke(
            this IObservable<System.Threading.ContextCallback> ContextCallbackValue, IObservable<System.Object> state)
        {
            return ObservableExt.ZipExecute(ContextCallbackValue, state,
                (ContextCallbackValueLambda, stateLambda) => ContextCallbackValueLambda.Invoke(stateLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(
            this IObservable<System.Threading.ContextCallback> ContextCallbackValue, IObservable<System.Object> state,
            IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(ContextCallbackValue, state, callback, @object,
                (ContextCallbackValueLambda, stateLambda, callbackLambda, @objectLambda) =>
                    ContextCallbackValueLambda.BeginInvoke(stateLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke(
            this IObservable<System.Threading.ContextCallback> ContextCallbackValue,
            IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(ContextCallbackValue, result,
                (ContextCallbackValueLambda, resultLambda) => ContextCallbackValueLambda.EndInvoke(resultLambda));
        }
    }
}