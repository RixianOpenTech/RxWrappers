using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __AppDomainInitializer
    {
        public static IObservable<System.Reactive.Unit> Invoke(
            this IObservable<System.AppDomainInitializer> AppDomainInitializerValue, IObservable<System.String[]> args)
        {
            return ObservableExt.ZipExecute(AppDomainInitializerValue, args,
                (AppDomainInitializerValueLambda, argsLambda) => AppDomainInitializerValueLambda.Invoke(argsLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(
            this IObservable<System.AppDomainInitializer> AppDomainInitializerValue, IObservable<System.String[]> args,
            IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(AppDomainInitializerValue, args, callback, @object,
                (AppDomainInitializerValueLambda, argsLambda, callbackLambda, @objectLambda) =>
                    AppDomainInitializerValueLambda.BeginInvoke(argsLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke(
            this IObservable<System.AppDomainInitializer> AppDomainInitializerValue,
            IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(AppDomainInitializerValue, result,
                (AppDomainInitializerValueLambda, resultLambda) =>
                    AppDomainInitializerValueLambda.EndInvoke(resultLambda));
        }
    }
}