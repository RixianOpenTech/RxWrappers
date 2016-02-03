using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __WaitCallback
    {
        
        public static IObservable<System.Reactive.Unit> Invoke(this IObservable<System.Threading.WaitCallback> WaitCallbackValue, IObservable<System.Object> state)
        {
            return ObservableExt.ZipExecute(WaitCallbackValue, state, (WaitCallbackValueLambda, stateLambda) => WaitCallbackValueLambda.Invoke(stateLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(this IObservable<System.Threading.WaitCallback> WaitCallbackValue, IObservable<System.Object> state, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(WaitCallbackValue, state, callback, @object, (WaitCallbackValueLambda, stateLambda, callbackLambda, @objectLambda) => WaitCallbackValueLambda.BeginInvoke(stateLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke(this IObservable<System.Threading.WaitCallback> WaitCallbackValue, IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(WaitCallbackValue, result, (WaitCallbackValueLambda, resultLambda) => WaitCallbackValueLambda.EndInvoke(resultLambda));
        }

    }
}