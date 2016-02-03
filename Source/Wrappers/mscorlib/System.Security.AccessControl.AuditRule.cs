using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __AuditRule
    {
        public static IObservable<System.Security.AccessControl.AuditFlags> get_AuditFlags(
            this IObservable<System.Security.AccessControl.AuditRule> AuditRuleValue)
        {
            return Observable.Select(AuditRuleValue, (AuditRuleValueLambda) => AuditRuleValueLambda.AuditFlags);
        }
    }
}