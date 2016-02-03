using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __AccessRule
    {
        
        public static IObservable<System.Security.AccessControl.AccessControlType> get_AccessControlType(this IObservable<System.Security.AccessControl.AccessRule> AccessRuleValue)
        {
            return Observable.Select(AccessRuleValue, (AccessRuleValueLambda) => AccessRuleValueLambda.AccessControlType);
        }

    }
}