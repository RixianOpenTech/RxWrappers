using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Func7
    {
        public static IObservable<TResult> Invoke<T1, T2, T3, T4, T5, T6, TResult>(
            this IObservable<System.Func<T1, T2, T3, T4, T5, T6, TResult>> FuncValue, IObservable<T1> arg1,
            IObservable<T2> arg2, IObservable<T3> arg3, IObservable<T4> arg4, IObservable<T5> arg5, IObservable<T6> arg6)
        {
            return Observable.Zip(FuncValue, arg1, arg2, arg3, arg4, arg5, arg6,
                (FuncValueLambda, arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda, arg5Lambda, arg6Lambda) =>
                    FuncValueLambda.Invoke(arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda, arg5Lambda, arg6Lambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke<T1, T2, T3, T4, T5, T6, TResult>(
            this IObservable<System.Func<T1, T2, T3, T4, T5, T6, TResult>> FuncValue, IObservable<T1> arg1,
            IObservable<T2> arg2, IObservable<T3> arg3, IObservable<T4> arg4, IObservable<T5> arg5, IObservable<T6> arg6,
            IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(FuncValue, arg1, arg2, arg3, arg4, arg5, arg6, callback, @object,
                (FuncValueLambda, arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda, arg5Lambda, arg6Lambda, callbackLambda,
                    @objectLambda) =>
                    FuncValueLambda.BeginInvoke(arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda, arg5Lambda, arg6Lambda,
                        callbackLambda, @objectLambda));
        }


        public static IObservable<TResult> EndInvoke<T1, T2, T3, T4, T5, T6, TResult>(
            this IObservable<System.Func<T1, T2, T3, T4, T5, T6, TResult>> FuncValue,
            IObservable<System.IAsyncResult> result)
        {
            return Observable.Zip(FuncValue, result,
                (FuncValueLambda, resultLambda) => FuncValueLambda.EndInvoke(resultLambda));
        }
    }
}