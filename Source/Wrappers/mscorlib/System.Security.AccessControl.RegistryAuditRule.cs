using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __RegistryAuditRule
    {
        
        public static IObservable<System.Security.AccessControl.RegistryRights> get_RegistryRights(this IObservable<System.Security.AccessControl.RegistryAuditRule> RegistryAuditRuleValue)
        {
            return Observable.Select(RegistryAuditRuleValue, (RegistryAuditRuleValueLambda) => RegistryAuditRuleValueLambda.RegistryRights);
        }

    }
}