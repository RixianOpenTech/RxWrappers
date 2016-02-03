using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __ApplicationSecurityManager
    {
        
        public static IObservable<System.Boolean> DetermineApplicationTrust(IObservable<System.ActivationContext> activationContext, IObservable<System.Security.Policy.TrustManagerContext> context)
        {
            return Observable.Zip(activationContext, context, (activationContextLambda, contextLambda) => System.Security.Policy.ApplicationSecurityManager.DetermineApplicationTrust(activationContextLambda, contextLambda));
        }


        public static IObservable<System.Security.Policy.ApplicationTrustCollection> get_UserApplicationTrusts()
        {
            return ObservableExt.Factory(() => System.Security.Policy.ApplicationSecurityManager.UserApplicationTrusts);
        }


        public static IObservable<System.Security.Policy.IApplicationTrustManager> get_ApplicationTrustManager()
        {
            return ObservableExt.Factory(() => System.Security.Policy.ApplicationSecurityManager.ApplicationTrustManager);
        }

    }
}