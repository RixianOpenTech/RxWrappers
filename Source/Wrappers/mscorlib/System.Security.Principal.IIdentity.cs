using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Principal
{
public static class _IIdentity
{
    
public static IObservable<System.String> get_Name(this IObservable<System.Security.Principal.IIdentity> IIdentityValue)
{
    return Observable.Select(IIdentityValue, (IIdentityValueLambda) => IIdentityValueLambda.Name);
}


public static IObservable<System.String> get_AuthenticationType(this IObservable<System.Security.Principal.IIdentity> IIdentityValue)
{
    return Observable.Select(IIdentityValue, (IIdentityValueLambda) => IIdentityValueLambda.AuthenticationType);
}


public static IObservable<System.Boolean> get_IsAuthenticated(this IObservable<System.Security.Principal.IIdentity> IIdentityValue)
{
    return Observable.Select(IIdentityValue, (IIdentityValueLambda) => IIdentityValueLambda.IsAuthenticated);
}

}
}