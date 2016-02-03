using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __ApplicationSecurityInfo
    {
        
        public static IObservable<System.ApplicationId> get_ApplicationId(this IObservable<System.Security.Policy.ApplicationSecurityInfo> ApplicationSecurityInfoValue)
        {
            return Observable.Select(ApplicationSecurityInfoValue, (ApplicationSecurityInfoValueLambda) => ApplicationSecurityInfoValueLambda.ApplicationId);
        }


        public static IObservable<System.ApplicationId> get_DeploymentId(this IObservable<System.Security.Policy.ApplicationSecurityInfo> ApplicationSecurityInfoValue)
        {
            return Observable.Select(ApplicationSecurityInfoValue, (ApplicationSecurityInfoValueLambda) => ApplicationSecurityInfoValueLambda.DeploymentId);
        }


        public static IObservable<System.Security.PermissionSet> get_DefaultRequestSet(this IObservable<System.Security.Policy.ApplicationSecurityInfo> ApplicationSecurityInfoValue)
        {
            return Observable.Select(ApplicationSecurityInfoValue, (ApplicationSecurityInfoValueLambda) => ApplicationSecurityInfoValueLambda.DefaultRequestSet);
        }


        public static IObservable<System.Security.Policy.Evidence> get_ApplicationEvidence(this IObservable<System.Security.Policy.ApplicationSecurityInfo> ApplicationSecurityInfoValue)
        {
            return Observable.Select(ApplicationSecurityInfoValue, (ApplicationSecurityInfoValueLambda) => ApplicationSecurityInfoValueLambda.ApplicationEvidence);
        }


        public static IObservable<System.Reactive.Unit> set_ApplicationId(this IObservable<System.Security.Policy.ApplicationSecurityInfo> ApplicationSecurityInfoValue, IObservable<System.ApplicationId> value)
        {
            return ObservableExt.ZipExecute(ApplicationSecurityInfoValue, value, (ApplicationSecurityInfoValueLambda, valueLambda) => ApplicationSecurityInfoValueLambda.ApplicationId = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DeploymentId(this IObservable<System.Security.Policy.ApplicationSecurityInfo> ApplicationSecurityInfoValue, IObservable<System.ApplicationId> value)
        {
            return ObservableExt.ZipExecute(ApplicationSecurityInfoValue, value, (ApplicationSecurityInfoValueLambda, valueLambda) => ApplicationSecurityInfoValueLambda.DeploymentId = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DefaultRequestSet(this IObservable<System.Security.Policy.ApplicationSecurityInfo> ApplicationSecurityInfoValue, IObservable<System.Security.PermissionSet> value)
        {
            return ObservableExt.ZipExecute(ApplicationSecurityInfoValue, value, (ApplicationSecurityInfoValueLambda, valueLambda) => ApplicationSecurityInfoValueLambda.DefaultRequestSet = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ApplicationEvidence(this IObservable<System.Security.Policy.ApplicationSecurityInfo> ApplicationSecurityInfoValue, IObservable<System.Security.Policy.Evidence> value)
        {
            return ObservableExt.ZipExecute(ApplicationSecurityInfoValue, value, (ApplicationSecurityInfoValueLambda, valueLambda) => ApplicationSecurityInfoValueLambda.ApplicationEvidence = valueLambda);
        }

    }
}