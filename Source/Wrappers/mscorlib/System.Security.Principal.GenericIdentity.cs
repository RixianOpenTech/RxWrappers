using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Principal
{
public static class _GenericIdentity
{
    
public static IObservable<System.Security.Claims.ClaimsIdentity> Clone(this IObservable<System.Security.Principal.GenericIdentity> GenericIdentityValue)
{
    return Observable.Select(GenericIdentityValue, (GenericIdentityValueLambda) => GenericIdentityValueLambda.Clone());
}


public static IObservable<System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>> get_Claims(this IObservable<System.Security.Principal.GenericIdentity> GenericIdentityValue)
{
    return Observable.Select(GenericIdentityValue, (GenericIdentityValueLambda) => GenericIdentityValueLambda.Claims);
}


public static IObservable<System.String> get_Name(this IObservable<System.Security.Principal.GenericIdentity> GenericIdentityValue)
{
    return Observable.Select(GenericIdentityValue, (GenericIdentityValueLambda) => GenericIdentityValueLambda.Name);
}


public static IObservable<System.String> get_AuthenticationType(this IObservable<System.Security.Principal.GenericIdentity> GenericIdentityValue)
{
    return Observable.Select(GenericIdentityValue, (GenericIdentityValueLambda) => GenericIdentityValueLambda.AuthenticationType);
}


public static IObservable<System.Boolean> get_IsAuthenticated(this IObservable<System.Security.Principal.GenericIdentity> GenericIdentityValue)
{
    return Observable.Select(GenericIdentityValue, (GenericIdentityValueLambda) => GenericIdentityValueLambda.IsAuthenticated);
}

}
}