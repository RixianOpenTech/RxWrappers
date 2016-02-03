using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __IsolatedStoragePermissionAttribute
    {
        
        public static IObservable<System.Int64> get_UserQuota(this IObservable<System.Security.Permissions.IsolatedStoragePermissionAttribute> IsolatedStoragePermissionAttributeValue)
        {
            return Observable.Select(IsolatedStoragePermissionAttributeValue, (IsolatedStoragePermissionAttributeValueLambda) => IsolatedStoragePermissionAttributeValueLambda.UserQuota);
        }


        public static IObservable<System.Security.Permissions.IsolatedStorageContainment> get_UsageAllowed(this IObservable<System.Security.Permissions.IsolatedStoragePermissionAttribute> IsolatedStoragePermissionAttributeValue)
        {
            return Observable.Select(IsolatedStoragePermissionAttributeValue, (IsolatedStoragePermissionAttributeValueLambda) => IsolatedStoragePermissionAttributeValueLambda.UsageAllowed);
        }


        public static IObservable<System.Reactive.Unit> set_UserQuota(this IObservable<System.Security.Permissions.IsolatedStoragePermissionAttribute> IsolatedStoragePermissionAttributeValue, IObservable<System.Int64> value)
        {
            return ObservableExt.ZipExecute(IsolatedStoragePermissionAttributeValue, value, (IsolatedStoragePermissionAttributeValueLambda, valueLambda) => IsolatedStoragePermissionAttributeValueLambda.UserQuota = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_UsageAllowed(this IObservable<System.Security.Permissions.IsolatedStoragePermissionAttribute> IsolatedStoragePermissionAttributeValue, IObservable<System.Security.Permissions.IsolatedStorageContainment> value)
        {
            return ObservableExt.ZipExecute(IsolatedStoragePermissionAttributeValue, value, (IsolatedStoragePermissionAttributeValueLambda, valueLambda) => IsolatedStoragePermissionAttributeValueLambda.UsageAllowed = valueLambda);
        }

    }
}