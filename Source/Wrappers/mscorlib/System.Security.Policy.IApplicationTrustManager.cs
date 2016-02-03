using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __IApplicationTrustManager
    {
        public static IObservable<System.Security.Policy.ApplicationTrust> DetermineApplicationTrust(
            this IObservable<System.Security.Policy.IApplicationTrustManager> IApplicationTrustManagerValue,
            IObservable<System.ActivationContext> activationContext,
            IObservable<System.Security.Policy.TrustManagerContext> context)
        {
            return Observable.Zip(IApplicationTrustManagerValue, activationContext, context,
                (IApplicationTrustManagerValueLambda, activationContextLambda, contextLambda) =>
                    IApplicationTrustManagerValueLambda.DetermineApplicationTrust(activationContextLambda, contextLambda));
        }
    }
}