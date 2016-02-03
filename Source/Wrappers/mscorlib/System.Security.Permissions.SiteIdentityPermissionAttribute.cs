using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __SiteIdentityPermissionAttribute
    {
        public static IObservable<System.Security.IPermission> CreatePermission(
            this IObservable<System.Security.Permissions.SiteIdentityPermissionAttribute>
                SiteIdentityPermissionAttributeValue)
        {
            return Observable.Select(SiteIdentityPermissionAttributeValue,
                (SiteIdentityPermissionAttributeValueLambda) =>
                    SiteIdentityPermissionAttributeValueLambda.CreatePermission());
        }


        public static IObservable<System.String> get_Site(
            this IObservable<System.Security.Permissions.SiteIdentityPermissionAttribute>
                SiteIdentityPermissionAttributeValue)
        {
            return Observable.Select(SiteIdentityPermissionAttributeValue,
                (SiteIdentityPermissionAttributeValueLambda) => SiteIdentityPermissionAttributeValueLambda.Site);
        }


        public static IObservable<System.Reactive.Unit> set_Site(
            this IObservable<System.Security.Permissions.SiteIdentityPermissionAttribute>
                SiteIdentityPermissionAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SiteIdentityPermissionAttributeValue, value,
                (SiteIdentityPermissionAttributeValueLambda, valueLambda) =>
                    SiteIdentityPermissionAttributeValueLambda.Site = valueLambda);
        }
    }
}