using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Func5
    {
        
        public static IObservable<TResult> Invoke<T1, T2, T3, T4, TResult>(this IObservable<System.Func<T1, T2, T3, T4, TResult>> FuncValue, IObservable<T1> arg1, IObservable<T2> arg2, IObservable<T3> arg3, IObservable<T4> arg4)
        {
            return Observable.Zip(FuncValue, arg1, arg2, arg3, arg4, (FuncValueLambda, arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda) => FuncValueLambda.Invoke(arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke<T1, T2, T3, T4, TResult>(this IObservable<System.Func<T1, T2, T3, T4, TResult>> FuncValue, IObservable<T1> arg1, IObservable<T2> arg2, IObservable<T3> arg3, IObservable<T4> arg4, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(FuncValue, arg1, arg2, arg3, arg4, callback, @object, (FuncValueLambda, arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda, callbackLambda, @objectLambda) => FuncValueLambda.BeginInvoke(arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda, callbackLambda, @objectLambda));
        }


        public static IObservable<TResult> EndInvoke<T1, T2, T3, T4, TResult>(this IObservable<System.Func<T1, T2, T3, T4, TResult>> FuncValue, IObservable<System.IAsyncResult> result)
        {
            return Observable.Zip(FuncValue, result, (FuncValueLambda, resultLambda) => FuncValueLambda.EndInvoke(resultLambda));
        }

    }
}