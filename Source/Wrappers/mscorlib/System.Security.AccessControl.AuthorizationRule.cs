using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
public static class _AuthorizationRule
{
    
public static IObservable<System.Security.Principal.IdentityReference> get_IdentityReference(this IObservable<System.Security.AccessControl.AuthorizationRule> AuthorizationRuleValue)
{
    return Observable.Select(AuthorizationRuleValue, (AuthorizationRuleValueLambda) => AuthorizationRuleValueLambda.IdentityReference);
}


public static IObservable<System.Boolean> get_IsInherited(this IObservable<System.Security.AccessControl.AuthorizationRule> AuthorizationRuleValue)
{
    return Observable.Select(AuthorizationRuleValue, (AuthorizationRuleValueLambda) => AuthorizationRuleValueLambda.IsInherited);
}


public static IObservable<System.Security.AccessControl.InheritanceFlags> get_InheritanceFlags(this IObservable<System.Security.AccessControl.AuthorizationRule> AuthorizationRuleValue)
{
    return Observable.Select(AuthorizationRuleValue, (AuthorizationRuleValueLambda) => AuthorizationRuleValueLambda.InheritanceFlags);
}


public static IObservable<System.Security.AccessControl.PropagationFlags> get_PropagationFlags(this IObservable<System.Security.AccessControl.AuthorizationRule> AuthorizationRuleValue)
{
    return Observable.Select(AuthorizationRuleValue, (AuthorizationRuleValueLambda) => AuthorizationRuleValueLambda.PropagationFlags);
}

}
}