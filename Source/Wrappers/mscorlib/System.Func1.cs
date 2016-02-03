using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Func1
    {
        
        public static IObservable<TResult> Invoke<TResult>(this IObservable<System.Func<TResult>> FuncValue)
        {
            return Observable.Select(FuncValue, (FuncValueLambda) => FuncValueLambda.Invoke());
        }


        public static IObservable<System.IAsyncResult> BeginInvoke<TResult>(this IObservable<System.Func<TResult>> FuncValue, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(FuncValue, callback, @object, (FuncValueLambda, callbackLambda, @objectLambda) => FuncValueLambda.BeginInvoke(callbackLambda, @objectLambda));
        }


        public static IObservable<TResult> EndInvoke<TResult>(this IObservable<System.Func<TResult>> FuncValue, IObservable<System.IAsyncResult> result)
        {
            return Observable.Zip(FuncValue, result, (FuncValueLambda, resultLambda) => FuncValueLambda.EndInvoke(resultLambda));
        }

    }
}