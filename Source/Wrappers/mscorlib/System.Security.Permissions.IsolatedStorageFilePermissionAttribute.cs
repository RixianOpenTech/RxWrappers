using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __IsolatedStorageFilePermissionAttribute
    {
        public static IObservable<System.Security.IPermission> CreatePermission(
            this IObservable<System.Security.Permissions.IsolatedStorageFilePermissionAttribute>
                IsolatedStorageFilePermissionAttributeValue)
        {
            return Observable.Select(IsolatedStorageFilePermissionAttributeValue,
                (IsolatedStorageFilePermissionAttributeValueLambda) =>
                    IsolatedStorageFilePermissionAttributeValueLambda.CreatePermission());
        }
    }
}