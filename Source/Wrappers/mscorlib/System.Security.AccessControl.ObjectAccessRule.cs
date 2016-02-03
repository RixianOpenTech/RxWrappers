using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __ObjectAccessRule
    {
        
        public static IObservable<System.Guid> get_ObjectType(this IObservable<System.Security.AccessControl.ObjectAccessRule> ObjectAccessRuleValue)
        {
            return Observable.Select(ObjectAccessRuleValue, (ObjectAccessRuleValueLambda) => ObjectAccessRuleValueLambda.ObjectType);
        }


        public static IObservable<System.Guid> get_InheritedObjectType(this IObservable<System.Security.AccessControl.ObjectAccessRule> ObjectAccessRuleValue)
        {
            return Observable.Select(ObjectAccessRuleValue, (ObjectAccessRuleValueLambda) => ObjectAccessRuleValueLambda.InheritedObjectType);
        }


        public static IObservable<System.Security.AccessControl.ObjectAceFlags> get_ObjectFlags(this IObservable<System.Security.AccessControl.ObjectAccessRule> ObjectAccessRuleValue)
        {
            return Observable.Select(ObjectAccessRuleValue, (ObjectAccessRuleValueLambda) => ObjectAccessRuleValueLambda.ObjectFlags);
        }

    }
}