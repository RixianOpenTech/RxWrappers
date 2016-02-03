using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
public static class _ZoneIdentityPermissionAttribute
{
    
public static IObservable<System.Security.IPermission> CreatePermission(this IObservable<System.Security.Permissions.ZoneIdentityPermissionAttribute> ZoneIdentityPermissionAttributeValue)
{
    return Observable.Select(ZoneIdentityPermissionAttributeValue, (ZoneIdentityPermissionAttributeValueLambda) => ZoneIdentityPermissionAttributeValueLambda.CreatePermission());
}


public static IObservable<System.Security.SecurityZone> get_Zone(this IObservable<System.Security.Permissions.ZoneIdentityPermissionAttribute> ZoneIdentityPermissionAttributeValue)
{
    return Observable.Select(ZoneIdentityPermissionAttributeValue, (ZoneIdentityPermissionAttributeValueLambda) => ZoneIdentityPermissionAttributeValueLambda.Zone);
}


public static IObservable<System.Reactive.Unit> set_Zone(this IObservable<System.Security.Permissions.ZoneIdentityPermissionAttribute> ZoneIdentityPermissionAttributeValue, IObservable<System.Security.SecurityZone> value)
{
    return ObservableExt.ZipExecute(ZoneIdentityPermissionAttributeValue, value, (ZoneIdentityPermissionAttributeValueLambda, valueLambda) => ZoneIdentityPermissionAttributeValueLambda.Zone = valueLambda);
}

}
}