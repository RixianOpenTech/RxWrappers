using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __IsolatedStorageFilePermission
    {
        
        public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Permissions.IsolatedStorageFilePermission> IsolatedStorageFilePermissionValue)
        {
            return Observable.Select(IsolatedStorageFilePermissionValue, (IsolatedStorageFilePermissionValueLambda) => IsolatedStorageFilePermissionValueLambda.ToXml());
        }


        public static IObservable<System.Security.IPermission> Union(this IObservable<System.Security.Permissions.IsolatedStorageFilePermission> IsolatedStorageFilePermissionValue, IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(IsolatedStorageFilePermissionValue, target, (IsolatedStorageFilePermissionValueLambda, targetLambda) => IsolatedStorageFilePermissionValueLambda.Union(targetLambda));
        }


        public static IObservable<System.Boolean> IsSubsetOf(this IObservable<System.Security.Permissions.IsolatedStorageFilePermission> IsolatedStorageFilePermissionValue, IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(IsolatedStorageFilePermissionValue, target, (IsolatedStorageFilePermissionValueLambda, targetLambda) => IsolatedStorageFilePermissionValueLambda.IsSubsetOf(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Intersect(this IObservable<System.Security.Permissions.IsolatedStorageFilePermission> IsolatedStorageFilePermissionValue, IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(IsolatedStorageFilePermissionValue, target, (IsolatedStorageFilePermissionValueLambda, targetLambda) => IsolatedStorageFilePermissionValueLambda.Intersect(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Copy(this IObservable<System.Security.Permissions.IsolatedStorageFilePermission> IsolatedStorageFilePermissionValue)
        {
            return Observable.Select(IsolatedStorageFilePermissionValue, (IsolatedStorageFilePermissionValueLambda) => IsolatedStorageFilePermissionValueLambda.Copy());
        }

    }
}