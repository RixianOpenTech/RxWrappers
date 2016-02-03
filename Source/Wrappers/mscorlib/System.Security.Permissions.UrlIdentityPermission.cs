using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __UrlIdentityPermission
    {
        
        public static IObservable<System.Security.IPermission> Copy(this IObservable<System.Security.Permissions.UrlIdentityPermission> UrlIdentityPermissionValue)
        {
            return Observable.Select(UrlIdentityPermissionValue, (UrlIdentityPermissionValueLambda) => UrlIdentityPermissionValueLambda.Copy());
        }


        public static IObservable<System.Boolean> IsSubsetOf(this IObservable<System.Security.Permissions.UrlIdentityPermission> UrlIdentityPermissionValue, IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(UrlIdentityPermissionValue, target, (UrlIdentityPermissionValueLambda, targetLambda) => UrlIdentityPermissionValueLambda.IsSubsetOf(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Intersect(this IObservable<System.Security.Permissions.UrlIdentityPermission> UrlIdentityPermissionValue, IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(UrlIdentityPermissionValue, target, (UrlIdentityPermissionValueLambda, targetLambda) => UrlIdentityPermissionValueLambda.Intersect(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Union(this IObservable<System.Security.Permissions.UrlIdentityPermission> UrlIdentityPermissionValue, IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(UrlIdentityPermissionValue, target, (UrlIdentityPermissionValueLambda, targetLambda) => UrlIdentityPermissionValueLambda.Union(targetLambda));
        }


        public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Permissions.UrlIdentityPermission> UrlIdentityPermissionValue, IObservable<System.Security.SecurityElement> esd)
        {
            return ObservableExt.ZipExecute(UrlIdentityPermissionValue, esd, (UrlIdentityPermissionValueLambda, esdLambda) => UrlIdentityPermissionValueLambda.FromXml(esdLambda));
        }


        public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Permissions.UrlIdentityPermission> UrlIdentityPermissionValue)
        {
            return Observable.Select(UrlIdentityPermissionValue, (UrlIdentityPermissionValueLambda) => UrlIdentityPermissionValueLambda.ToXml());
        }


        public static IObservable<System.String> get_Url(this IObservable<System.Security.Permissions.UrlIdentityPermission> UrlIdentityPermissionValue)
        {
            return Observable.Select(UrlIdentityPermissionValue, (UrlIdentityPermissionValueLambda) => UrlIdentityPermissionValueLambda.Url);
        }


        public static IObservable<System.Reactive.Unit> set_Url(this IObservable<System.Security.Permissions.UrlIdentityPermission> UrlIdentityPermissionValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(UrlIdentityPermissionValue, value, (UrlIdentityPermissionValueLambda, valueLambda) => UrlIdentityPermissionValueLambda.Url = valueLambda);
        }

    }
}