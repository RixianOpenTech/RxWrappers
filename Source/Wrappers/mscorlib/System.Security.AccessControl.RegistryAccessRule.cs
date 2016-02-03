using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __RegistryAccessRule
    {
        
        public static IObservable<System.Security.AccessControl.RegistryRights> get_RegistryRights(this IObservable<System.Security.AccessControl.RegistryAccessRule> RegistryAccessRuleValue)
        {
            return Observable.Select(RegistryAccessRuleValue, (RegistryAccessRuleValueLambda) => RegistryAccessRuleValueLambda.RegistryRights);
        }

    }
}