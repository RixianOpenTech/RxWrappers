using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Principal
{
public static class _WindowsIdentity
{
    
public static IObservable<System.Security.Principal.WindowsIdentity> GetCurrent()
{
    return ObservableExt.Factory(() => System.Security.Principal.WindowsIdentity.GetCurrent());
}


public static IObservable<System.Security.Principal.WindowsIdentity> GetCurrent(IObservable<System.Boolean> ifImpersonating)
{
    return Observable.Select(ifImpersonating, (ifImpersonatingLambda) => System.Security.Principal.WindowsIdentity.GetCurrent(ifImpersonatingLambda));
}


public static IObservable<System.Security.Principal.WindowsIdentity> GetCurrent(IObservable<System.Security.Principal.TokenAccessLevels> desiredAccess)
{
    return Observable.Select(desiredAccess, (desiredAccessLambda) => System.Security.Principal.WindowsIdentity.GetCurrent(desiredAccessLambda));
}


public static IObservable<System.Security.Principal.WindowsIdentity> GetAnonymous()
{
    return ObservableExt.Factory(() => System.Security.Principal.WindowsIdentity.GetAnonymous());
}


public static IObservable<System.Reactive.Unit> RunImpersonated(IObservable<Microsoft.Win32.SafeHandles.SafeAccessTokenHandle> safeAccessTokenHandle, IObservable<System.Action> action)
{
    return ObservableExt.ZipExecute(safeAccessTokenHandle, action, (safeAccessTokenHandleLambda, actionLambda) => System.Security.Principal.WindowsIdentity.RunImpersonated(safeAccessTokenHandleLambda, actionLambda));
}


public static IObservable<T> RunImpersonated<T>(IObservable<Microsoft.Win32.SafeHandles.SafeAccessTokenHandle> safeAccessTokenHandle, IObservable<Func<T>> func)
{
    return Observable.Zip(safeAccessTokenHandle, func, (safeAccessTokenHandleLambda, funcLambda) => System.Security.Principal.WindowsIdentity.RunImpersonated(safeAccessTokenHandleLambda, funcLambda));
}


public static IObservable<System.Security.Principal.WindowsImpersonationContext> Impersonate(this IObservable<System.Security.Principal.WindowsIdentity> WindowsIdentityValue)
{
    return Observable.Select(WindowsIdentityValue, (WindowsIdentityValueLambda) => WindowsIdentityValueLambda.Impersonate());
}


public static IObservable<System.Security.Principal.WindowsImpersonationContext> Impersonate(IObservable<System.IntPtr> userToken)
{
    return Observable.Select(userToken, (userTokenLambda) => System.Security.Principal.WindowsIdentity.Impersonate(userTokenLambda));
}


public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Security.Principal.WindowsIdentity> WindowsIdentityValue)
{
    return Observable.Do(WindowsIdentityValue, (WindowsIdentityValueLambda) => WindowsIdentityValueLambda.Dispose()).ToUnit();
}


public static IObservable<System.Security.Claims.ClaimsIdentity> Clone(this IObservable<System.Security.Principal.WindowsIdentity> WindowsIdentityValue)
{
    return Observable.Select(WindowsIdentityValue, (WindowsIdentityValueLambda) => WindowsIdentityValueLambda.Clone());
}


public static IObservable<System.String> get_AuthenticationType(this IObservable<System.Security.Principal.WindowsIdentity> WindowsIdentityValue)
{
    return Observable.Select(WindowsIdentityValue, (WindowsIdentityValueLambda) => WindowsIdentityValueLambda.AuthenticationType);
}


public static IObservable<System.Security.Principal.TokenImpersonationLevel> get_ImpersonationLevel(this IObservable<System.Security.Principal.WindowsIdentity> WindowsIdentityValue)
{
    return Observable.Select(WindowsIdentityValue, (WindowsIdentityValueLambda) => WindowsIdentityValueLambda.ImpersonationLevel);
}


public static IObservable<System.Boolean> get_IsAuthenticated(this IObservable<System.Security.Principal.WindowsIdentity> WindowsIdentityValue)
{
    return Observable.Select(WindowsIdentityValue, (WindowsIdentityValueLambda) => WindowsIdentityValueLambda.IsAuthenticated);
}


public static IObservable<System.Boolean> get_IsGuest(this IObservable<System.Security.Principal.WindowsIdentity> WindowsIdentityValue)
{
    return Observable.Select(WindowsIdentityValue, (WindowsIdentityValueLambda) => WindowsIdentityValueLambda.IsGuest);
}


public static IObservable<System.Boolean> get_IsSystem(this IObservable<System.Security.Principal.WindowsIdentity> WindowsIdentityValue)
{
    return Observable.Select(WindowsIdentityValue, (WindowsIdentityValueLambda) => WindowsIdentityValueLambda.IsSystem);
}


public static IObservable<System.Boolean> get_IsAnonymous(this IObservable<System.Security.Principal.WindowsIdentity> WindowsIdentityValue)
{
    return Observable.Select(WindowsIdentityValue, (WindowsIdentityValueLambda) => WindowsIdentityValueLambda.IsAnonymous);
}


public static IObservable<System.String> get_Name(this IObservable<System.Security.Principal.WindowsIdentity> WindowsIdentityValue)
{
    return Observable.Select(WindowsIdentityValue, (WindowsIdentityValueLambda) => WindowsIdentityValueLambda.Name);
}


public static IObservable<System.Security.Principal.SecurityIdentifier> get_Owner(this IObservable<System.Security.Principal.WindowsIdentity> WindowsIdentityValue)
{
    return Observable.Select(WindowsIdentityValue, (WindowsIdentityValueLambda) => WindowsIdentityValueLambda.Owner);
}


public static IObservable<System.Security.Principal.SecurityIdentifier> get_User(this IObservable<System.Security.Principal.WindowsIdentity> WindowsIdentityValue)
{
    return Observable.Select(WindowsIdentityValue, (WindowsIdentityValueLambda) => WindowsIdentityValueLambda.User);
}


public static IObservable<System.Security.Principal.IdentityReferenceCollection> get_Groups(this IObservable<System.Security.Principal.WindowsIdentity> WindowsIdentityValue)
{
    return Observable.Select(WindowsIdentityValue, (WindowsIdentityValueLambda) => WindowsIdentityValueLambda.Groups);
}


public static IObservable<System.IntPtr> get_Token(this IObservable<System.Security.Principal.WindowsIdentity> WindowsIdentityValue)
{
    return Observable.Select(WindowsIdentityValue, (WindowsIdentityValueLambda) => WindowsIdentityValueLambda.Token);
}


public static IObservable<Microsoft.Win32.SafeHandles.SafeAccessTokenHandle> get_AccessToken(this IObservable<System.Security.Principal.WindowsIdentity> WindowsIdentityValue)
{
    return Observable.Select(WindowsIdentityValue, (WindowsIdentityValueLambda) => WindowsIdentityValueLambda.AccessToken);
}


public static IObservable<System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>> get_UserClaims(this IObservable<System.Security.Principal.WindowsIdentity> WindowsIdentityValue)
{
    return Observable.Select(WindowsIdentityValue, (WindowsIdentityValueLambda) => WindowsIdentityValueLambda.UserClaims);
}


public static IObservable<System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>> get_DeviceClaims(this IObservable<System.Security.Principal.WindowsIdentity> WindowsIdentityValue)
{
    return Observable.Select(WindowsIdentityValue, (WindowsIdentityValueLambda) => WindowsIdentityValueLambda.DeviceClaims);
}


public static IObservable<System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>> get_Claims(this IObservable<System.Security.Principal.WindowsIdentity> WindowsIdentityValue)
{
    return Observable.Select(WindowsIdentityValue, (WindowsIdentityValueLambda) => WindowsIdentityValueLambda.Claims);
}

}
}