using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __GacIdentityPermissionAttribute
    {
        
        public static IObservable<System.Security.IPermission> CreatePermission(this IObservable<System.Security.Permissions.GacIdentityPermissionAttribute> GacIdentityPermissionAttributeValue)
        {
            return Observable.Select(GacIdentityPermissionAttributeValue, (GacIdentityPermissionAttributeValueLambda) => GacIdentityPermissionAttributeValueLambda.CreatePermission());
        }

    }
}