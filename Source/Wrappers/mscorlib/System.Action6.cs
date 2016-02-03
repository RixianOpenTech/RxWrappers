using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Action6
    {
        public static IObservable<System.Reactive.Unit> Invoke<T1, T2, T3, T4, T5, T6>(
            this IObservable<System.Action<T1, T2, T3, T4, T5, T6>> ActionValue, IObservable<T1> arg1,
            IObservable<T2> arg2, IObservable<T3> arg3, IObservable<T4> arg4, IObservable<T5> arg5, IObservable<T6> arg6)
        {
            return ObservableExt.ZipExecute(ActionValue, arg1, arg2, arg3, arg4, arg5, arg6,
                (ActionValueLambda, arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda, arg5Lambda, arg6Lambda) =>
                    ActionValueLambda.Invoke(arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda, arg5Lambda, arg6Lambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke<T1, T2, T3, T4, T5, T6>(
            this IObservable<System.Action<T1, T2, T3, T4, T5, T6>> ActionValue, IObservable<T1> arg1,
            IObservable<T2> arg2, IObservable<T3> arg3, IObservable<T4> arg4, IObservable<T5> arg5, IObservable<T6> arg6,
            IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(ActionValue, arg1, arg2, arg3, arg4, arg5, arg6, callback, @object,
                (ActionValueLambda, arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda, arg5Lambda, arg6Lambda,
                    callbackLambda, @objectLambda) =>
                    ActionValueLambda.BeginInvoke(arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda, arg5Lambda, arg6Lambda,
                        callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke<T1, T2, T3, T4, T5, T6>(
            this IObservable<System.Action<T1, T2, T3, T4, T5, T6>> ActionValue, IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(ActionValue, result,
                (ActionValueLambda, resultLambda) => ActionValueLambda.EndInvoke(resultLambda));
        }
    }
}