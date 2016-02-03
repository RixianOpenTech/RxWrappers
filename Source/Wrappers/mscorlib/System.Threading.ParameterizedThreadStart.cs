using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __ParameterizedThreadStart
    {
        public static IObservable<System.Reactive.Unit> Invoke(
            this IObservable<System.Threading.ParameterizedThreadStart> ParameterizedThreadStartValue,
            IObservable<System.Object> obj)
        {
            return ObservableExt.ZipExecute(ParameterizedThreadStartValue, obj,
                (ParameterizedThreadStartValueLambda, objLambda) =>
                    ParameterizedThreadStartValueLambda.Invoke(objLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(
            this IObservable<System.Threading.ParameterizedThreadStart> ParameterizedThreadStartValue,
            IObservable<System.Object> obj, IObservable<System.AsyncCallback> callback,
            IObservable<System.Object> @object)
        {
            return Observable.Zip(ParameterizedThreadStartValue, obj, callback, @object,
                (ParameterizedThreadStartValueLambda, objLambda, callbackLambda, @objectLambda) =>
                    ParameterizedThreadStartValueLambda.BeginInvoke(objLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke(
            this IObservable<System.Threading.ParameterizedThreadStart> ParameterizedThreadStartValue,
            IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(ParameterizedThreadStartValue, result,
                (ParameterizedThreadStartValueLambda, resultLambda) =>
                    ParameterizedThreadStartValueLambda.EndInvoke(resultLambda));
        }
    }
}