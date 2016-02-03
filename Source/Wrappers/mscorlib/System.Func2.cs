using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Func2
    {
        public static IObservable<TResult> Invoke<T, TResult>(this IObservable<System.Func<T, TResult>> FuncValue,
            IObservable<T> arg)
        {
            return Observable.Zip(FuncValue, arg, (FuncValueLambda, argLambda) => FuncValueLambda.Invoke(argLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke<T, TResult>(
            this IObservable<System.Func<T, TResult>> FuncValue, IObservable<T> arg,
            IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(FuncValue, arg, callback, @object,
                (FuncValueLambda, argLambda, callbackLambda, @objectLambda) =>
                    FuncValueLambda.BeginInvoke(argLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<TResult> EndInvoke<T, TResult>(this IObservable<System.Func<T, TResult>> FuncValue,
            IObservable<System.IAsyncResult> result)
        {
            return Observable.Zip(FuncValue, result,
                (FuncValueLambda, resultLambda) => FuncValueLambda.EndInvoke(resultLambda));
        }
    }
}