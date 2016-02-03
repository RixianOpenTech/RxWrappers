using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __ObjectAuditRule
    {
        
        public static IObservable<System.Guid> get_ObjectType(this IObservable<System.Security.AccessControl.ObjectAuditRule> ObjectAuditRuleValue)
        {
            return Observable.Select(ObjectAuditRuleValue, (ObjectAuditRuleValueLambda) => ObjectAuditRuleValueLambda.ObjectType);
        }


        public static IObservable<System.Guid> get_InheritedObjectType(this IObservable<System.Security.AccessControl.ObjectAuditRule> ObjectAuditRuleValue)
        {
            return Observable.Select(ObjectAuditRuleValue, (ObjectAuditRuleValueLambda) => ObjectAuditRuleValueLambda.InheritedObjectType);
        }


        public static IObservable<System.Security.AccessControl.ObjectAceFlags> get_ObjectFlags(this IObservable<System.Security.AccessControl.ObjectAuditRule> ObjectAuditRuleValue)
        {
            return Observable.Select(ObjectAuditRuleValue, (ObjectAuditRuleValueLambda) => ObjectAuditRuleValueLambda.ObjectFlags);
        }

    }
}