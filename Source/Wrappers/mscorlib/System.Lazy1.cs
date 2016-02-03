using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Lazy1
    {
        
        public static IObservable<System.String> ToString<T>(this IObservable<System.Lazy<T>> LazyValue)
        {
            return Observable.Select(LazyValue, (LazyValueLambda) => LazyValueLambda.ToString());
        }


        public static IObservable<System.Boolean> get_IsValueCreated<T>(this IObservable<System.Lazy<T>> LazyValue)
        {
            return Observable.Select(LazyValue, (LazyValueLambda) => LazyValueLambda.IsValueCreated);
        }


        public static IObservable<T> get_Value<T>(this IObservable<System.Lazy<T>> LazyValue)
        {
            return Observable.Select(LazyValue, (LazyValueLambda) => LazyValueLambda.Value);
        }

    }
}