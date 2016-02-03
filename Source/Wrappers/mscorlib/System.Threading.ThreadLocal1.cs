using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __ThreadLocal1
    {
        
        public static IObservable<System.Reactive.Unit> Dispose<T>(this IObservable<System.Threading.ThreadLocal<T>> ThreadLocalValue)
        {
            return Observable.Do(ThreadLocalValue, (ThreadLocalValueLambda) => ThreadLocalValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.String> ToString<T>(this IObservable<System.Threading.ThreadLocal<T>> ThreadLocalValue)
        {
            return Observable.Select(ThreadLocalValue, (ThreadLocalValueLambda) => ThreadLocalValueLambda.ToString());
        }


        public static IObservable<T> get_Value<T>(this IObservable<System.Threading.ThreadLocal<T>> ThreadLocalValue)
        {
            return Observable.Select(ThreadLocalValue, (ThreadLocalValueLambda) => ThreadLocalValueLambda.Value);
        }


        public static IObservable<IList<T>> get_Values<T>(this IObservable<System.Threading.ThreadLocal<T>> ThreadLocalValue)
        {
            return Observable.Select(ThreadLocalValue, (ThreadLocalValueLambda) => ThreadLocalValueLambda.Values);
        }


        public static IObservable<System.Boolean> get_IsValueCreated<T>(this IObservable<System.Threading.ThreadLocal<T>> ThreadLocalValue)
        {
            return Observable.Select(ThreadLocalValue, (ThreadLocalValueLambda) => ThreadLocalValueLambda.IsValueCreated);
        }


        public static IObservable<System.Reactive.Unit> set_Value<T>(this IObservable<System.Threading.ThreadLocal<T>> ThreadLocalValue, IObservable<T> value)
        {
            return ObservableExt.ZipExecute(ThreadLocalValue, value, (ThreadLocalValueLambda, valueLambda) => ThreadLocalValueLambda.Value = valueLambda);
        }

    }
}