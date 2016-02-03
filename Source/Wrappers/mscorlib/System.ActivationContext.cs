using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __ActivationContext
    {
        
        public static IObservable<System.ActivationContext> CreatePartialActivationContext(IObservable<System.ApplicationIdentity> identity)
        {
            return Observable.Select(identity, (identityLambda) => System.ActivationContext.CreatePartialActivationContext(identityLambda));
        }


        public static IObservable<System.ActivationContext> CreatePartialActivationContext(IObservable<System.ApplicationIdentity> identity, IObservable<System.String[]> manifestPaths)
        {
            return Observable.Zip(identity, manifestPaths, (identityLambda, manifestPathsLambda) => System.ActivationContext.CreatePartialActivationContext(identityLambda, manifestPathsLambda));
        }


        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.ActivationContext> ActivationContextValue)
        {
            return Observable.Do(ActivationContextValue, (ActivationContextValueLambda) => ActivationContextValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.ApplicationIdentity> get_Identity(this IObservable<System.ActivationContext> ActivationContextValue)
        {
            return Observable.Select(ActivationContextValue, (ActivationContextValueLambda) => ActivationContextValueLambda.Identity);
        }


        public static IObservable<System.ActivationContext.ContextForm> get_Form(this IObservable<System.ActivationContext> ActivationContextValue)
        {
            return Observable.Select(ActivationContextValue, (ActivationContextValueLambda) => ActivationContextValueLambda.Form);
        }


        public static IObservable<System.Byte[]> get_ApplicationManifestBytes(this IObservable<System.ActivationContext> ActivationContextValue)
        {
            return Observable.Select(ActivationContextValue, (ActivationContextValueLambda) => ActivationContextValueLambda.ApplicationManifestBytes);
        }


        public static IObservable<System.Byte[]> get_DeploymentManifestBytes(this IObservable<System.ActivationContext> ActivationContextValue)
        {
            return Observable.Select(ActivationContextValue, (ActivationContextValueLambda) => ActivationContextValueLambda.DeploymentManifestBytes);
        }

    }
}