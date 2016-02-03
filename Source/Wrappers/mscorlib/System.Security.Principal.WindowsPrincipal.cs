using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Principal
{
public static class _WindowsPrincipal
{
    
public static IObservable<System.Boolean> IsInRole(this IObservable<System.Security.Principal.WindowsPrincipal> WindowsPrincipalValue, IObservable<System.String> role)
{
    return Observable.Zip(WindowsPrincipalValue, role, (WindowsPrincipalValueLambda, roleLambda) => WindowsPrincipalValueLambda.IsInRole(roleLambda));
}


public static IObservable<System.Boolean> IsInRole(this IObservable<System.Security.Principal.WindowsPrincipal> WindowsPrincipalValue, IObservable<System.Security.Principal.WindowsBuiltInRole> role)
{
    return Observable.Zip(WindowsPrincipalValue, role, (WindowsPrincipalValueLambda, roleLambda) => WindowsPrincipalValueLambda.IsInRole(roleLambda));
}


public static IObservable<System.Boolean> IsInRole(this IObservable<System.Security.Principal.WindowsPrincipal> WindowsPrincipalValue, IObservable<System.Int32> rid)
{
    return Observable.Zip(WindowsPrincipalValue, rid, (WindowsPrincipalValueLambda, ridLambda) => WindowsPrincipalValueLambda.IsInRole(ridLambda));
}


public static IObservable<System.Boolean> IsInRole(this IObservable<System.Security.Principal.WindowsPrincipal> WindowsPrincipalValue, IObservable<System.Security.Principal.SecurityIdentifier> sid)
{
    return Observable.Zip(WindowsPrincipalValue, sid, (WindowsPrincipalValueLambda, sidLambda) => WindowsPrincipalValueLambda.IsInRole(sidLambda));
}


public static IObservable<System.Security.Principal.IIdentity> get_Identity(this IObservable<System.Security.Principal.WindowsPrincipal> WindowsPrincipalValue)
{
    return Observable.Select(WindowsPrincipalValue, (WindowsPrincipalValueLambda) => WindowsPrincipalValueLambda.Identity);
}


public static IObservable<System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>> get_UserClaims(this IObservable<System.Security.Principal.WindowsPrincipal> WindowsPrincipalValue)
{
    return Observable.Select(WindowsPrincipalValue, (WindowsPrincipalValueLambda) => WindowsPrincipalValueLambda.UserClaims);
}


public static IObservable<System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>> get_DeviceClaims(this IObservable<System.Security.Principal.WindowsPrincipal> WindowsPrincipalValue)
{
    return Observable.Select(WindowsPrincipalValue, (WindowsPrincipalValueLambda) => WindowsPrincipalValueLambda.DeviceClaims);
}

}
}