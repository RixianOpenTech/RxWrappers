using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
public static class _SiteIdentityPermission
{
    
public static IObservable<System.Security.IPermission> Copy(this IObservable<System.Security.Permissions.SiteIdentityPermission> SiteIdentityPermissionValue)
{
    return Observable.Select(SiteIdentityPermissionValue, (SiteIdentityPermissionValueLambda) => SiteIdentityPermissionValueLambda.Copy());
}


public static IObservable<System.Boolean> IsSubsetOf(this IObservable<System.Security.Permissions.SiteIdentityPermission> SiteIdentityPermissionValue, IObservable<System.Security.IPermission> target)
{
    return Observable.Zip(SiteIdentityPermissionValue, target, (SiteIdentityPermissionValueLambda, targetLambda) => SiteIdentityPermissionValueLambda.IsSubsetOf(targetLambda));
}


public static IObservable<System.Security.IPermission> Intersect(this IObservable<System.Security.Permissions.SiteIdentityPermission> SiteIdentityPermissionValue, IObservable<System.Security.IPermission> target)
{
    return Observable.Zip(SiteIdentityPermissionValue, target, (SiteIdentityPermissionValueLambda, targetLambda) => SiteIdentityPermissionValueLambda.Intersect(targetLambda));
}


public static IObservable<System.Security.IPermission> Union(this IObservable<System.Security.Permissions.SiteIdentityPermission> SiteIdentityPermissionValue, IObservable<System.Security.IPermission> target)
{
    return Observable.Zip(SiteIdentityPermissionValue, target, (SiteIdentityPermissionValueLambda, targetLambda) => SiteIdentityPermissionValueLambda.Union(targetLambda));
}


public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Permissions.SiteIdentityPermission> SiteIdentityPermissionValue, IObservable<System.Security.SecurityElement> esd)
{
    return ObservableExt.ZipExecute(SiteIdentityPermissionValue, esd, (SiteIdentityPermissionValueLambda, esdLambda) => SiteIdentityPermissionValueLambda.FromXml(esdLambda));
}


public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Permissions.SiteIdentityPermission> SiteIdentityPermissionValue)
{
    return Observable.Select(SiteIdentityPermissionValue, (SiteIdentityPermissionValueLambda) => SiteIdentityPermissionValueLambda.ToXml());
}


public static IObservable<System.String> get_Site(this IObservable<System.Security.Permissions.SiteIdentityPermission> SiteIdentityPermissionValue)
{
    return Observable.Select(SiteIdentityPermissionValue, (SiteIdentityPermissionValueLambda) => SiteIdentityPermissionValueLambda.Site);
}


public static IObservable<System.Reactive.Unit> set_Site(this IObservable<System.Security.Permissions.SiteIdentityPermission> SiteIdentityPermissionValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SiteIdentityPermissionValue, value, (SiteIdentityPermissionValueLambda, valueLambda) => SiteIdentityPermissionValueLambda.Site = valueLambda);
}

}
}