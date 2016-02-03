using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __EnvironmentPermission
    {
        public static IObservable<System.Reactive.Unit> SetPathList(
            this IObservable<System.Security.Permissions.EnvironmentPermission> EnvironmentPermissionValue,
            IObservable<System.Security.Permissions.EnvironmentPermissionAccess> flag,
            IObservable<System.String> pathList)
        {
            return ObservableExt.ZipExecute(EnvironmentPermissionValue, flag, pathList,
                (EnvironmentPermissionValueLambda, flagLambda, pathListLambda) =>
                    EnvironmentPermissionValueLambda.SetPathList(flagLambda, pathListLambda));
        }


        public static IObservable<System.Reactive.Unit> AddPathList(
            this IObservable<System.Security.Permissions.EnvironmentPermission> EnvironmentPermissionValue,
            IObservable<System.Security.Permissions.EnvironmentPermissionAccess> flag,
            IObservable<System.String> pathList)
        {
            return ObservableExt.ZipExecute(EnvironmentPermissionValue, flag, pathList,
                (EnvironmentPermissionValueLambda, flagLambda, pathListLambda) =>
                    EnvironmentPermissionValueLambda.AddPathList(flagLambda, pathListLambda));
        }


        public static IObservable<System.String> GetPathList(
            this IObservable<System.Security.Permissions.EnvironmentPermission> EnvironmentPermissionValue,
            IObservable<System.Security.Permissions.EnvironmentPermissionAccess> flag)
        {
            return Observable.Zip(EnvironmentPermissionValue, flag,
                (EnvironmentPermissionValueLambda, flagLambda) =>
                    EnvironmentPermissionValueLambda.GetPathList(flagLambda));
        }


        public static IObservable<System.Boolean> IsUnrestricted(
            this IObservable<System.Security.Permissions.EnvironmentPermission> EnvironmentPermissionValue)
        {
            return Observable.Select(EnvironmentPermissionValue,
                (EnvironmentPermissionValueLambda) => EnvironmentPermissionValueLambda.IsUnrestricted());
        }


        public static IObservable<System.Boolean> IsSubsetOf(
            this IObservable<System.Security.Permissions.EnvironmentPermission> EnvironmentPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(EnvironmentPermissionValue, target,
                (EnvironmentPermissionValueLambda, targetLambda) =>
                    EnvironmentPermissionValueLambda.IsSubsetOf(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Intersect(
            this IObservable<System.Security.Permissions.EnvironmentPermission> EnvironmentPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(EnvironmentPermissionValue, target,
                (EnvironmentPermissionValueLambda, targetLambda) =>
                    EnvironmentPermissionValueLambda.Intersect(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Union(
            this IObservable<System.Security.Permissions.EnvironmentPermission> EnvironmentPermissionValue,
            IObservable<System.Security.IPermission> other)
        {
            return Observable.Zip(EnvironmentPermissionValue, other,
                (EnvironmentPermissionValueLambda, otherLambda) => EnvironmentPermissionValueLambda.Union(otherLambda));
        }


        public static IObservable<System.Security.IPermission> Copy(
            this IObservable<System.Security.Permissions.EnvironmentPermission> EnvironmentPermissionValue)
        {
            return Observable.Select(EnvironmentPermissionValue,
                (EnvironmentPermissionValueLambda) => EnvironmentPermissionValueLambda.Copy());
        }


        public static IObservable<System.Security.SecurityElement> ToXml(
            this IObservable<System.Security.Permissions.EnvironmentPermission> EnvironmentPermissionValue)
        {
            return Observable.Select(EnvironmentPermissionValue,
                (EnvironmentPermissionValueLambda) => EnvironmentPermissionValueLambda.ToXml());
        }


        public static IObservable<System.Reactive.Unit> FromXml(
            this IObservable<System.Security.Permissions.EnvironmentPermission> EnvironmentPermissionValue,
            IObservable<System.Security.SecurityElement> esd)
        {
            return ObservableExt.ZipExecute(EnvironmentPermissionValue, esd,
                (EnvironmentPermissionValueLambda, esdLambda) => EnvironmentPermissionValueLambda.FromXml(esdLambda));
        }
    }
}