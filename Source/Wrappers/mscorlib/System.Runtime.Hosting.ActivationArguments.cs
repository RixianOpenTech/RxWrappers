using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Hosting
{
    public static class __ActivationArguments
    {
        
        public static IObservable<System.Security.Policy.EvidenceBase> Clone(this IObservable<System.Runtime.Hosting.ActivationArguments> ActivationArgumentsValue)
        {
            return Observable.Select(ActivationArgumentsValue, (ActivationArgumentsValueLambda) => ActivationArgumentsValueLambda.Clone());
        }


        public static IObservable<System.ApplicationIdentity> get_ApplicationIdentity(this IObservable<System.Runtime.Hosting.ActivationArguments> ActivationArgumentsValue)
        {
            return Observable.Select(ActivationArgumentsValue, (ActivationArgumentsValueLambda) => ActivationArgumentsValueLambda.ApplicationIdentity);
        }


        public static IObservable<System.ActivationContext> get_ActivationContext(this IObservable<System.Runtime.Hosting.ActivationArguments> ActivationArgumentsValue)
        {
            return Observable.Select(ActivationArgumentsValue, (ActivationArgumentsValueLambda) => ActivationArgumentsValueLambda.ActivationContext);
        }


        public static IObservable<System.String[]> get_ActivationData(this IObservable<System.Runtime.Hosting.ActivationArguments> ActivationArgumentsValue)
        {
            return Observable.Select(ActivationArgumentsValue, (ActivationArgumentsValueLambda) => ActivationArgumentsValueLambda.ActivationData);
        }

    }
}