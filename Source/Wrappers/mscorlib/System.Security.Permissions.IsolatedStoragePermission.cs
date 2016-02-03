using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
public static class _IsolatedStoragePermission
{
    
public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Permissions.IsolatedStoragePermission> IsolatedStoragePermissionValue, IObservable<System.Security.SecurityElement> esd)
{
    return ObservableExt.ZipExecute(IsolatedStoragePermissionValue, esd, (IsolatedStoragePermissionValueLambda, esdLambda) => IsolatedStoragePermissionValueLambda.FromXml(esdLambda));
}


public static IObservable<System.Boolean> IsUnrestricted(this IObservable<System.Security.Permissions.IsolatedStoragePermission> IsolatedStoragePermissionValue)
{
    return Observable.Select(IsolatedStoragePermissionValue, (IsolatedStoragePermissionValueLambda) => IsolatedStoragePermissionValueLambda.IsUnrestricted());
}


public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Permissions.IsolatedStoragePermission> IsolatedStoragePermissionValue)
{
    return Observable.Select(IsolatedStoragePermissionValue, (IsolatedStoragePermissionValueLambda) => IsolatedStoragePermissionValueLambda.ToXml());
}


public static IObservable<System.Int64> get_UserQuota(this IObservable<System.Security.Permissions.IsolatedStoragePermission> IsolatedStoragePermissionValue)
{
    return Observable.Select(IsolatedStoragePermissionValue, (IsolatedStoragePermissionValueLambda) => IsolatedStoragePermissionValueLambda.UserQuota);
}


public static IObservable<System.Security.Permissions.IsolatedStorageContainment> get_UsageAllowed(this IObservable<System.Security.Permissions.IsolatedStoragePermission> IsolatedStoragePermissionValue)
{
    return Observable.Select(IsolatedStoragePermissionValue, (IsolatedStoragePermissionValueLambda) => IsolatedStoragePermissionValueLambda.UsageAllowed);
}


public static IObservable<System.Reactive.Unit> set_UserQuota(this IObservable<System.Security.Permissions.IsolatedStoragePermission> IsolatedStoragePermissionValue, IObservable<System.Int64> value)
{
    return ObservableExt.ZipExecute(IsolatedStoragePermissionValue, value, (IsolatedStoragePermissionValueLambda, valueLambda) => IsolatedStoragePermissionValueLambda.UserQuota = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_UsageAllowed(this IObservable<System.Security.Permissions.IsolatedStoragePermission> IsolatedStoragePermissionValue, IObservable<System.Security.Permissions.IsolatedStorageContainment> value)
{
    return ObservableExt.ZipExecute(IsolatedStoragePermissionValue, value, (IsolatedStoragePermissionValueLambda, valueLambda) => IsolatedStoragePermissionValueLambda.UsageAllowed = valueLambda);
}

}
}