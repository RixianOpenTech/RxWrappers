using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __CrossAppDomainDelegate
    {
        public static IObservable<System.Reactive.Unit> Invoke(
            this IObservable<System.CrossAppDomainDelegate> CrossAppDomainDelegateValue)
        {
            return
                Observable.Do(CrossAppDomainDelegateValue,
                    (CrossAppDomainDelegateValueLambda) => CrossAppDomainDelegateValueLambda.Invoke()).ToUnit();
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(
            this IObservable<System.CrossAppDomainDelegate> CrossAppDomainDelegateValue,
            IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(CrossAppDomainDelegateValue, callback, @object,
                (CrossAppDomainDelegateValueLambda, callbackLambda, @objectLambda) =>
                    CrossAppDomainDelegateValueLambda.BeginInvoke(callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke(
            this IObservable<System.CrossAppDomainDelegate> CrossAppDomainDelegateValue,
            IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(CrossAppDomainDelegateValue, result,
                (CrossAppDomainDelegateValueLambda, resultLambda) =>
                    CrossAppDomainDelegateValueLambda.EndInvoke(resultLambda));
        }
    }
}