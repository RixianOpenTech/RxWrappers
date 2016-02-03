using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __CommonObjectSecurity
    {
        public static IObservable<System.Security.AccessControl.AuthorizationRuleCollection> GetAccessRules(
            this IObservable<System.Security.AccessControl.CommonObjectSecurity> CommonObjectSecurityValue,
            IObservable<System.Boolean> includeExplicit, IObservable<System.Boolean> includeInherited,
            IObservable<System.Type> targetType)
        {
            return Observable.Zip(CommonObjectSecurityValue, includeExplicit, includeInherited, targetType,
                (CommonObjectSecurityValueLambda, includeExplicitLambda, includeInheritedLambda, targetTypeLambda) =>
                    CommonObjectSecurityValueLambda.GetAccessRules(includeExplicitLambda, includeInheritedLambda,
                        targetTypeLambda));
        }


        public static IObservable<System.Security.AccessControl.AuthorizationRuleCollection> GetAuditRules(
            this IObservable<System.Security.AccessControl.CommonObjectSecurity> CommonObjectSecurityValue,
            IObservable<System.Boolean> includeExplicit, IObservable<System.Boolean> includeInherited,
            IObservable<System.Type> targetType)
        {
            return Observable.Zip(CommonObjectSecurityValue, includeExplicit, includeInherited, targetType,
                (CommonObjectSecurityValueLambda, includeExplicitLambda, includeInheritedLambda, targetTypeLambda) =>
                    CommonObjectSecurityValueLambda.GetAuditRules(includeExplicitLambda, includeInheritedLambda,
                        targetTypeLambda));
        }
    }
}