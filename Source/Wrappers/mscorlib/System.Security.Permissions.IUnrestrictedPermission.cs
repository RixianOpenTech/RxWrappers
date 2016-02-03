using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
public static class _IUnrestrictedPermission
{
    
public static IObservable<System.Boolean> IsUnrestricted(this IObservable<System.Security.Permissions.IUnrestrictedPermission> IUnrestrictedPermissionValue)
{
    return Observable.Select(IUnrestrictedPermissionValue, (IUnrestrictedPermissionValueLambda) => IUnrestrictedPermissionValueLambda.IsUnrestricted());
}

}
}