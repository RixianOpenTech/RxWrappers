using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Action
    {
        
        public static IObservable<System.Reactive.Unit> Invoke(this IObservable<System.Action> ActionValue)
        {
            return Observable.Do(ActionValue, (ActionValueLambda) => ActionValueLambda.Invoke()).ToUnit();
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(this IObservable<System.Action> ActionValue, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(ActionValue, callback, @object, (ActionValueLambda, callbackLambda, @objectLambda) => ActionValueLambda.BeginInvoke(callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke(this IObservable<System.Action> ActionValue, IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(ActionValue, result, (ActionValueLambda, resultLambda) => ActionValueLambda.EndInvoke(resultLambda));
        }

    }
}