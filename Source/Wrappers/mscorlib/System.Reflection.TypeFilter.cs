using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __TypeFilter
    {
        public static IObservable<System.Boolean> Invoke(this IObservable<System.Reflection.TypeFilter> TypeFilterValue,
            IObservable<System.Type> m, IObservable<System.Object> filterCriteria)
        {
            return Observable.Zip(TypeFilterValue, m, filterCriteria,
                (TypeFilterValueLambda, mLambda, filterCriteriaLambda) =>
                    TypeFilterValueLambda.Invoke(mLambda, filterCriteriaLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(
            this IObservable<System.Reflection.TypeFilter> TypeFilterValue, IObservable<System.Type> m,
            IObservable<System.Object> filterCriteria, IObservable<System.AsyncCallback> callback,
            IObservable<System.Object> @object)
        {
            return Observable.Zip(TypeFilterValue, m, filterCriteria, callback, @object,
                (TypeFilterValueLambda, mLambda, filterCriteriaLambda, callbackLambda, @objectLambda) =>
                    TypeFilterValueLambda.BeginInvoke(mLambda, filterCriteriaLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Boolean> EndInvoke(
            this IObservable<System.Reflection.TypeFilter> TypeFilterValue, IObservable<System.IAsyncResult> result)
        {
            return Observable.Zip(TypeFilterValue, result,
                (TypeFilterValueLambda, resultLambda) => TypeFilterValueLambda.EndInvoke(resultLambda));
        }
    }
}