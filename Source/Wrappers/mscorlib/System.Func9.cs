using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Func9
    {
        
        public static IObservable<TResult> Invoke<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this IObservable<System.Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> FuncValue, IObservable<T1> arg1, IObservable<T2> arg2, IObservable<T3> arg3, IObservable<T4> arg4, IObservable<T5> arg5, IObservable<T6> arg6, IObservable<T7> arg7, IObservable<T8> arg8)
        {
            return Observable.Zip(FuncValue, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, (FuncValueLambda, arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda, arg5Lambda, arg6Lambda, arg7Lambda, arg8Lambda) => FuncValueLambda.Invoke(arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda, arg5Lambda, arg6Lambda, arg7Lambda, arg8Lambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this IObservable<System.Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> FuncValue, IObservable<T1> arg1, IObservable<T2> arg2, IObservable<T3> arg3, IObservable<T4> arg4, IObservable<T5> arg5, IObservable<T6> arg6, IObservable<T7> arg7, IObservable<T8> arg8, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(FuncValue, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, callback, @object, (FuncValueLambda, arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda, arg5Lambda, arg6Lambda, arg7Lambda, arg8Lambda, callbackLambda, @objectLambda) => FuncValueLambda.BeginInvoke(arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda, arg5Lambda, arg6Lambda, arg7Lambda, arg8Lambda, callbackLambda, @objectLambda));
        }


        public static IObservable<TResult> EndInvoke<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this IObservable<System.Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> FuncValue, IObservable<System.IAsyncResult> result)
        {
            return Observable.Zip(FuncValue, result, (FuncValueLambda, resultLambda) => FuncValueLambda.EndInvoke(resultLambda));
        }

    }
}