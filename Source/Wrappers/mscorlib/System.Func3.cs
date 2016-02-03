using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Func3
    {
        public static IObservable<TResult> Invoke<T1, T2, TResult>(
            this IObservable<System.Func<T1, T2, TResult>> FuncValue, IObservable<T1> arg1, IObservable<T2> arg2)
        {
            return Observable.Zip(FuncValue, arg1, arg2,
                (FuncValueLambda, arg1Lambda, arg2Lambda) => FuncValueLambda.Invoke(arg1Lambda, arg2Lambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke<T1, T2, TResult>(
            this IObservable<System.Func<T1, T2, TResult>> FuncValue, IObservable<T1> arg1, IObservable<T2> arg2,
            IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(FuncValue, arg1, arg2, callback, @object,
                (FuncValueLambda, arg1Lambda, arg2Lambda, callbackLambda, @objectLambda) =>
                    FuncValueLambda.BeginInvoke(arg1Lambda, arg2Lambda, callbackLambda, @objectLambda));
        }


        public static IObservable<TResult> EndInvoke<T1, T2, TResult>(
            this IObservable<System.Func<T1, T2, TResult>> FuncValue, IObservable<System.IAsyncResult> result)
        {
            return Observable.Zip(FuncValue, result,
                (FuncValueLambda, resultLambda) => FuncValueLambda.EndInvoke(resultLambda));
        }
    }
}