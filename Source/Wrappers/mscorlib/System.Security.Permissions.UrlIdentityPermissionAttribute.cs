using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __UrlIdentityPermissionAttribute
    {
        public static IObservable<System.Security.IPermission> CreatePermission(
            this IObservable<System.Security.Permissions.UrlIdentityPermissionAttribute>
                UrlIdentityPermissionAttributeValue)
        {
            return Observable.Select(UrlIdentityPermissionAttributeValue,
                (UrlIdentityPermissionAttributeValueLambda) =>
                    UrlIdentityPermissionAttributeValueLambda.CreatePermission());
        }


        public static IObservable<System.String> get_Url(
            this IObservable<System.Security.Permissions.UrlIdentityPermissionAttribute>
                UrlIdentityPermissionAttributeValue)
        {
            return Observable.Select(UrlIdentityPermissionAttributeValue,
                (UrlIdentityPermissionAttributeValueLambda) => UrlIdentityPermissionAttributeValueLambda.Url);
        }


        public static IObservable<System.Reactive.Unit> set_Url(
            this IObservable<System.Security.Permissions.UrlIdentityPermissionAttribute>
                UrlIdentityPermissionAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(UrlIdentityPermissionAttributeValue, value,
                (UrlIdentityPermissionAttributeValueLambda, valueLambda) =>
                    UrlIdentityPermissionAttributeValueLambda.Url = valueLambda);
        }
    }
}