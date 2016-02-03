using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __MemberFilter
    {
        public static IObservable<System.Boolean> Invoke(
            this IObservable<System.Reflection.MemberFilter> MemberFilterValue,
            IObservable<System.Reflection.MemberInfo> m, IObservable<System.Object> filterCriteria)
        {
            return Observable.Zip(MemberFilterValue, m, filterCriteria,
                (MemberFilterValueLambda, mLambda, filterCriteriaLambda) =>
                    MemberFilterValueLambda.Invoke(mLambda, filterCriteriaLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(
            this IObservable<System.Reflection.MemberFilter> MemberFilterValue,
            IObservable<System.Reflection.MemberInfo> m, IObservable<System.Object> filterCriteria,
            IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(MemberFilterValue, m, filterCriteria, callback, @object,
                (MemberFilterValueLambda, mLambda, filterCriteriaLambda, callbackLambda, @objectLambda) =>
                    MemberFilterValueLambda.BeginInvoke(mLambda, filterCriteriaLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Boolean> EndInvoke(
            this IObservable<System.Reflection.MemberFilter> MemberFilterValue, IObservable<System.IAsyncResult> result)
        {
            return Observable.Zip(MemberFilterValue, result,
                (MemberFilterValueLambda, resultLambda) => MemberFilterValueLambda.EndInvoke(resultLambda));
        }
    }
}