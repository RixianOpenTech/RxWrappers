using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Principal
{
public static class _IPrincipal
{
    
public static IObservable<System.Boolean> IsInRole(this IObservable<System.Security.Principal.IPrincipal> IPrincipalValue, IObservable<System.String> role)
{
    return Observable.Zip(IPrincipalValue, role, (IPrincipalValueLambda, roleLambda) => IPrincipalValueLambda.IsInRole(roleLambda));
}


public static IObservable<System.Security.Principal.IIdentity> get_Identity(this IObservable<System.Security.Principal.IPrincipal> IPrincipalValue)
{
    return Observable.Select(IPrincipalValue, (IPrincipalValueLambda) => IPrincipalValueLambda.Identity);
}

}
}