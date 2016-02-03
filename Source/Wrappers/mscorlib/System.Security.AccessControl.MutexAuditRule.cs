using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __MutexAuditRule
    {
        
        public static IObservable<System.Security.AccessControl.MutexRights> get_MutexRights(this IObservable<System.Security.AccessControl.MutexAuditRule> MutexAuditRuleValue)
        {
            return Observable.Select(MutexAuditRuleValue, (MutexAuditRuleValueLambda) => MutexAuditRuleValueLambda.MutexRights);
        }

    }
}