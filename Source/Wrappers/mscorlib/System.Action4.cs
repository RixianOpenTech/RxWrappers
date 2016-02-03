using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _Action4
{
    
public static IObservable<System.Reactive.Unit> Invoke<T1, T2, T3, T4>(this IObservable<System.Action<T1, T2, T3, T4>> ActionValue, IObservable<T1> arg1, IObservable<T2> arg2, IObservable<T3> arg3, IObservable<T4> arg4)
{
    return ObservableExt.ZipExecute(ActionValue, arg1, arg2, arg3, arg4, (ActionValueLambda, arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda) => ActionValueLambda.Invoke(arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda));
}


public static IObservable<System.IAsyncResult> BeginInvoke<T1, T2, T3, T4>(this IObservable<System.Action<T1, T2, T3, T4>> ActionValue, IObservable<T1> arg1, IObservable<T2> arg2, IObservable<T3> arg3, IObservable<T4> arg4, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
{
    return Observable.Zip(ActionValue, arg1, arg2, arg3, arg4, callback, @object, (ActionValueLambda, arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda, callbackLambda, @objectLambda) => ActionValueLambda.BeginInvoke(arg1Lambda, arg2Lambda, arg3Lambda, arg4Lambda, callbackLambda, @objectLambda));
}


public static IObservable<System.Reactive.Unit> EndInvoke<T1, T2, T3, T4>(this IObservable<System.Action<T1, T2, T3, T4>> ActionValue, IObservable<System.IAsyncResult> result)
{
    return ObservableExt.ZipExecute(ActionValue, result, (ActionValueLambda, resultLambda) => ActionValueLambda.EndInvoke(resultLambda));
}

}
}