using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Deployment.Internal
{
    public static class __InternalActivationContextHelper
    {
        public static IObservable<System.Object> GetActivationContextData(IObservable<System.ActivationContext> appInfo)
        {
            return Observable.Select(appInfo,
                (appInfoLambda) =>
                    System.Deployment.Internal.InternalActivationContextHelper.GetActivationContextData(appInfoLambda));
        }


        public static IObservable<System.Object> GetApplicationComponentManifest(
            IObservable<System.ActivationContext> appInfo)
        {
            return Observable.Select(appInfo,
                (appInfoLambda) =>
                    System.Deployment.Internal.InternalActivationContextHelper.GetApplicationComponentManifest(
                        appInfoLambda));
        }


        public static IObservable<System.Object> GetDeploymentComponentManifest(
            IObservable<System.ActivationContext> appInfo)
        {
            return Observable.Select(appInfo,
                (appInfoLambda) =>
                    System.Deployment.Internal.InternalActivationContextHelper.GetDeploymentComponentManifest(
                        appInfoLambda));
        }


        public static IObservable<System.Reactive.Unit> PrepareForExecution(
            IObservable<System.ActivationContext> appInfo)
        {
            return
                Observable.Do(appInfo,
                    (appInfoLambda) =>
                        System.Deployment.Internal.InternalActivationContextHelper.PrepareForExecution(appInfoLambda))
                    .ToUnit();
        }


        public static IObservable<System.Boolean> IsFirstRun(IObservable<System.ActivationContext> appInfo)
        {
            return Observable.Select(appInfo,
                (appInfoLambda) => System.Deployment.Internal.InternalActivationContextHelper.IsFirstRun(appInfoLambda));
        }


        public static IObservable<System.Byte[]> GetApplicationManifestBytes(
            IObservable<System.ActivationContext> appInfo)
        {
            return Observable.Select(appInfo,
                (appInfoLambda) =>
                    System.Deployment.Internal.InternalActivationContextHelper.GetApplicationManifestBytes(appInfoLambda));
        }


        public static IObservable<System.Byte[]> GetDeploymentManifestBytes(
            IObservable<System.ActivationContext> appInfo)
        {
            return Observable.Select(appInfo,
                (appInfoLambda) =>
                    System.Deployment.Internal.InternalActivationContextHelper.GetDeploymentManifestBytes(appInfoLambda));
        }
    }
}