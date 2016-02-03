using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Action1
    {
        public static IObservable<System.Reactive.Unit> Invoke<T>(this IObservable<System.Action<T>> ActionValue,
            IObservable<T> obj)
        {
            return ObservableExt.ZipExecute(ActionValue, obj,
                (ActionValueLambda, objLambda) => ActionValueLambda.Invoke(objLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke<T>(this IObservable<System.Action<T>> ActionValue,
            IObservable<T> obj, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(ActionValue, obj, callback, @object,
                (ActionValueLambda, objLambda, callbackLambda, @objectLambda) =>
                    ActionValueLambda.BeginInvoke(objLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke<T>(this IObservable<System.Action<T>> ActionValue,
            IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(ActionValue, result,
                (ActionValueLambda, resultLambda) => ActionValueLambda.EndInvoke(resultLambda));
        }
    }
}