using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __ZoneIdentityPermission
    {
        public static IObservable<System.Security.IPermission> Copy(
            this IObservable<System.Security.Permissions.ZoneIdentityPermission> ZoneIdentityPermissionValue)
        {
            return Observable.Select(ZoneIdentityPermissionValue,
                (ZoneIdentityPermissionValueLambda) => ZoneIdentityPermissionValueLambda.Copy());
        }


        public static IObservable<System.Boolean> IsSubsetOf(
            this IObservable<System.Security.Permissions.ZoneIdentityPermission> ZoneIdentityPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(ZoneIdentityPermissionValue, target,
                (ZoneIdentityPermissionValueLambda, targetLambda) =>
                    ZoneIdentityPermissionValueLambda.IsSubsetOf(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Intersect(
            this IObservable<System.Security.Permissions.ZoneIdentityPermission> ZoneIdentityPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(ZoneIdentityPermissionValue, target,
                (ZoneIdentityPermissionValueLambda, targetLambda) =>
                    ZoneIdentityPermissionValueLambda.Intersect(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Union(
            this IObservable<System.Security.Permissions.ZoneIdentityPermission> ZoneIdentityPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(ZoneIdentityPermissionValue, target,
                (ZoneIdentityPermissionValueLambda, targetLambda) =>
                    ZoneIdentityPermissionValueLambda.Union(targetLambda));
        }


        public static IObservable<System.Security.SecurityElement> ToXml(
            this IObservable<System.Security.Permissions.ZoneIdentityPermission> ZoneIdentityPermissionValue)
        {
            return Observable.Select(ZoneIdentityPermissionValue,
                (ZoneIdentityPermissionValueLambda) => ZoneIdentityPermissionValueLambda.ToXml());
        }


        public static IObservable<System.Reactive.Unit> FromXml(
            this IObservable<System.Security.Permissions.ZoneIdentityPermission> ZoneIdentityPermissionValue,
            IObservable<System.Security.SecurityElement> esd)
        {
            return ObservableExt.ZipExecute(ZoneIdentityPermissionValue, esd,
                (ZoneIdentityPermissionValueLambda, esdLambda) => ZoneIdentityPermissionValueLambda.FromXml(esdLambda));
        }


        public static IObservable<System.Security.SecurityZone> get_SecurityZone(
            this IObservable<System.Security.Permissions.ZoneIdentityPermission> ZoneIdentityPermissionValue)
        {
            return Observable.Select(ZoneIdentityPermissionValue,
                (ZoneIdentityPermissionValueLambda) => ZoneIdentityPermissionValueLambda.SecurityZone);
        }


        public static IObservable<System.Reactive.Unit> set_SecurityZone(
            this IObservable<System.Security.Permissions.ZoneIdentityPermission> ZoneIdentityPermissionValue,
            IObservable<System.Security.SecurityZone> value)
        {
            return ObservableExt.ZipExecute(ZoneIdentityPermissionValue, value,
                (ZoneIdentityPermissionValueLambda, valueLambda) =>
                    ZoneIdentityPermissionValueLambda.SecurityZone = valueLambda);
        }
    }
}