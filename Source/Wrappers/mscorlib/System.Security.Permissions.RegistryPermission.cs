using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __RegistryPermission
    {
        
        public static IObservable<System.Reactive.Unit> SetPathList(this IObservable<System.Security.Permissions.RegistryPermission> RegistryPermissionValue, IObservable<System.Security.Permissions.RegistryPermissionAccess> access, IObservable<System.String> pathList)
        {
            return ObservableExt.ZipExecute(RegistryPermissionValue, access, pathList, (RegistryPermissionValueLambda, accessLambda, pathListLambda) => RegistryPermissionValueLambda.SetPathList(accessLambda, pathListLambda));
        }


        public static IObservable<System.Reactive.Unit> AddPathList(this IObservable<System.Security.Permissions.RegistryPermission> RegistryPermissionValue, IObservable<System.Security.Permissions.RegistryPermissionAccess> access, IObservable<System.String> pathList)
        {
            return ObservableExt.ZipExecute(RegistryPermissionValue, access, pathList, (RegistryPermissionValueLambda, accessLambda, pathListLambda) => RegistryPermissionValueLambda.AddPathList(accessLambda, pathListLambda));
        }


        public static IObservable<System.Reactive.Unit> AddPathList(this IObservable<System.Security.Permissions.RegistryPermission> RegistryPermissionValue, IObservable<System.Security.Permissions.RegistryPermissionAccess> access, IObservable<System.Security.AccessControl.AccessControlActions> control, IObservable<System.String> pathList)
        {
            return ObservableExt.ZipExecute(RegistryPermissionValue, access, control, pathList, (RegistryPermissionValueLambda, accessLambda, controlLambda, pathListLambda) => RegistryPermissionValueLambda.AddPathList(accessLambda, controlLambda, pathListLambda));
        }


        public static IObservable<System.String> GetPathList(this IObservable<System.Security.Permissions.RegistryPermission> RegistryPermissionValue, IObservable<System.Security.Permissions.RegistryPermissionAccess> access)
        {
            return Observable.Zip(RegistryPermissionValue, access, (RegistryPermissionValueLambda, accessLambda) => RegistryPermissionValueLambda.GetPathList(accessLambda));
        }


        public static IObservable<System.Boolean> IsUnrestricted(this IObservable<System.Security.Permissions.RegistryPermission> RegistryPermissionValue)
        {
            return Observable.Select(RegistryPermissionValue, (RegistryPermissionValueLambda) => RegistryPermissionValueLambda.IsUnrestricted());
        }


        public static IObservable<System.Boolean> IsSubsetOf(this IObservable<System.Security.Permissions.RegistryPermission> RegistryPermissionValue, IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(RegistryPermissionValue, target, (RegistryPermissionValueLambda, targetLambda) => RegistryPermissionValueLambda.IsSubsetOf(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Intersect(this IObservable<System.Security.Permissions.RegistryPermission> RegistryPermissionValue, IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(RegistryPermissionValue, target, (RegistryPermissionValueLambda, targetLambda) => RegistryPermissionValueLambda.Intersect(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Union(this IObservable<System.Security.Permissions.RegistryPermission> RegistryPermissionValue, IObservable<System.Security.IPermission> other)
        {
            return Observable.Zip(RegistryPermissionValue, other, (RegistryPermissionValueLambda, otherLambda) => RegistryPermissionValueLambda.Union(otherLambda));
        }


        public static IObservable<System.Security.IPermission> Copy(this IObservable<System.Security.Permissions.RegistryPermission> RegistryPermissionValue)
        {
            return Observable.Select(RegistryPermissionValue, (RegistryPermissionValueLambda) => RegistryPermissionValueLambda.Copy());
        }


        public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Permissions.RegistryPermission> RegistryPermissionValue)
        {
            return Observable.Select(RegistryPermissionValue, (RegistryPermissionValueLambda) => RegistryPermissionValueLambda.ToXml());
        }


        public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Permissions.RegistryPermission> RegistryPermissionValue, IObservable<System.Security.SecurityElement> esd)
        {
            return ObservableExt.ZipExecute(RegistryPermissionValue, esd, (RegistryPermissionValueLambda, esdLambda) => RegistryPermissionValueLambda.FromXml(esdLambda));
        }

    }
}