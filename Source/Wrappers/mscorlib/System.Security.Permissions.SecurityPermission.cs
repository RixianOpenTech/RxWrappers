using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
public static class _SecurityPermission
{
    
public static IObservable<System.Boolean> IsSubsetOf(this IObservable<System.Security.Permissions.SecurityPermission> SecurityPermissionValue, IObservable<System.Security.IPermission> target)
{
    return Observable.Zip(SecurityPermissionValue, target, (SecurityPermissionValueLambda, targetLambda) => SecurityPermissionValueLambda.IsSubsetOf(targetLambda));
}


public static IObservable<System.Security.IPermission> Union(this IObservable<System.Security.Permissions.SecurityPermission> SecurityPermissionValue, IObservable<System.Security.IPermission> target)
{
    return Observable.Zip(SecurityPermissionValue, target, (SecurityPermissionValueLambda, targetLambda) => SecurityPermissionValueLambda.Union(targetLambda));
}


public static IObservable<System.Security.IPermission> Intersect(this IObservable<System.Security.Permissions.SecurityPermission> SecurityPermissionValue, IObservable<System.Security.IPermission> target)
{
    return Observable.Zip(SecurityPermissionValue, target, (SecurityPermissionValueLambda, targetLambda) => SecurityPermissionValueLambda.Intersect(targetLambda));
}


public static IObservable<System.Security.IPermission> Copy(this IObservable<System.Security.Permissions.SecurityPermission> SecurityPermissionValue)
{
    return Observable.Select(SecurityPermissionValue, (SecurityPermissionValueLambda) => SecurityPermissionValueLambda.Copy());
}


public static IObservable<System.Boolean> IsUnrestricted(this IObservable<System.Security.Permissions.SecurityPermission> SecurityPermissionValue)
{
    return Observable.Select(SecurityPermissionValue, (SecurityPermissionValueLambda) => SecurityPermissionValueLambda.IsUnrestricted());
}


public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Permissions.SecurityPermission> SecurityPermissionValue)
{
    return Observable.Select(SecurityPermissionValue, (SecurityPermissionValueLambda) => SecurityPermissionValueLambda.ToXml());
}


public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Permissions.SecurityPermission> SecurityPermissionValue, IObservable<System.Security.SecurityElement> esd)
{
    return ObservableExt.ZipExecute(SecurityPermissionValue, esd, (SecurityPermissionValueLambda, esdLambda) => SecurityPermissionValueLambda.FromXml(esdLambda));
}


public static IObservable<System.Security.Permissions.SecurityPermissionFlag> get_Flags(this IObservable<System.Security.Permissions.SecurityPermission> SecurityPermissionValue)
{
    return Observable.Select(SecurityPermissionValue, (SecurityPermissionValueLambda) => SecurityPermissionValueLambda.Flags);
}


public static IObservable<System.Reactive.Unit> set_Flags(this IObservable<System.Security.Permissions.SecurityPermission> SecurityPermissionValue, IObservable<System.Security.Permissions.SecurityPermissionFlag> value)
{
    return ObservableExt.ZipExecute(SecurityPermissionValue, value, (SecurityPermissionValueLambda, valueLambda) => SecurityPermissionValueLambda.Flags = valueLambda);
}

}
}