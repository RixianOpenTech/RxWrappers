using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __GacIdentityPermission
    {
        public static IObservable<System.Security.IPermission> Copy(
            this IObservable<System.Security.Permissions.GacIdentityPermission> GacIdentityPermissionValue)
        {
            return Observable.Select(GacIdentityPermissionValue,
                (GacIdentityPermissionValueLambda) => GacIdentityPermissionValueLambda.Copy());
        }


        public static IObservable<System.Boolean> IsSubsetOf(
            this IObservable<System.Security.Permissions.GacIdentityPermission> GacIdentityPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(GacIdentityPermissionValue, target,
                (GacIdentityPermissionValueLambda, targetLambda) =>
                    GacIdentityPermissionValueLambda.IsSubsetOf(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Intersect(
            this IObservable<System.Security.Permissions.GacIdentityPermission> GacIdentityPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(GacIdentityPermissionValue, target,
                (GacIdentityPermissionValueLambda, targetLambda) =>
                    GacIdentityPermissionValueLambda.Intersect(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Union(
            this IObservable<System.Security.Permissions.GacIdentityPermission> GacIdentityPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(GacIdentityPermissionValue, target,
                (GacIdentityPermissionValueLambda, targetLambda) => GacIdentityPermissionValueLambda.Union(targetLambda));
        }


        public static IObservable<System.Security.SecurityElement> ToXml(
            this IObservable<System.Security.Permissions.GacIdentityPermission> GacIdentityPermissionValue)
        {
            return Observable.Select(GacIdentityPermissionValue,
                (GacIdentityPermissionValueLambda) => GacIdentityPermissionValueLambda.ToXml());
        }


        public static IObservable<System.Reactive.Unit> FromXml(
            this IObservable<System.Security.Permissions.GacIdentityPermission> GacIdentityPermissionValue,
            IObservable<System.Security.SecurityElement> securityElement)
        {
            return ObservableExt.ZipExecute(GacIdentityPermissionValue, securityElement,
                (GacIdentityPermissionValueLambda, securityElementLambda) =>
                    GacIdentityPermissionValueLambda.FromXml(securityElementLambda));
        }
    }
}