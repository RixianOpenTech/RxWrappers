using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
    public static class __SecurityContext
    {
        
        public static IObservable<System.Reactive.Unit> Run(IObservable<System.Security.SecurityContext> securityContext, IObservable<System.Threading.ContextCallback> callback, IObservable<System.Object> state)
        {
            return ObservableExt.ZipExecute(securityContext, callback, state, (securityContextLambda, callbackLambda, stateLambda) => System.Security.SecurityContext.Run(securityContextLambda, callbackLambda, stateLambda));
        }


        public static IObservable<System.Security.SecurityContext> CreateCopy(this IObservable<System.Security.SecurityContext> SecurityContextValue)
        {
            return Observable.Select(SecurityContextValue, (SecurityContextValueLambda) => SecurityContextValueLambda.CreateCopy());
        }


        public static IObservable<System.Security.SecurityContext> Capture()
        {
            return ObservableExt.Factory(() => System.Security.SecurityContext.Capture());
        }


        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Security.SecurityContext> SecurityContextValue)
        {
            return Observable.Do(SecurityContextValue, (SecurityContextValueLambda) => SecurityContextValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Threading.AsyncFlowControl> SuppressFlow()
        {
            return ObservableExt.Factory(() => System.Security.SecurityContext.SuppressFlow());
        }


        public static IObservable<System.Threading.AsyncFlowControl> SuppressFlowWindowsIdentity()
        {
            return ObservableExt.Factory(() => System.Security.SecurityContext.SuppressFlowWindowsIdentity());
        }


        public static IObservable<System.Reactive.Unit> RestoreFlow()
        {
            return ObservableExt.Factory(() => System.Security.SecurityContext.RestoreFlow());
        }


        public static IObservable<System.Boolean> IsFlowSuppressed()
        {
            return ObservableExt.Factory(() => System.Security.SecurityContext.IsFlowSuppressed());
        }


        public static IObservable<System.Boolean> IsWindowsIdentityFlowSuppressed()
        {
            return ObservableExt.Factory(() => System.Security.SecurityContext.IsWindowsIdentityFlowSuppressed());
        }

    }
}