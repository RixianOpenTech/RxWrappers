using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Predicate1
    {
        public static IObservable<System.Boolean> Invoke<T>(this IObservable<System.Predicate<T>> PredicateValue,
            IObservable<T> obj)
        {
            return Observable.Zip(PredicateValue, obj,
                (PredicateValueLambda, objLambda) => PredicateValueLambda.Invoke(objLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke<T>(
            this IObservable<System.Predicate<T>> PredicateValue, IObservable<T> obj,
            IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(PredicateValue, obj, callback, @object,
                (PredicateValueLambda, objLambda, callbackLambda, @objectLambda) =>
                    PredicateValueLambda.BeginInvoke(objLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Boolean> EndInvoke<T>(this IObservable<System.Predicate<T>> PredicateValue,
            IObservable<System.IAsyncResult> result)
        {
            return Observable.Zip(PredicateValue, result,
                (PredicateValueLambda, resultLambda) => PredicateValueLambda.EndInvoke(resultLambda));
        }
    }
}