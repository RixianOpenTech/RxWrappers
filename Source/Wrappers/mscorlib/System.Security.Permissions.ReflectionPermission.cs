using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __ReflectionPermission
    {
        
        public static IObservable<System.Boolean> IsUnrestricted(this IObservable<System.Security.Permissions.ReflectionPermission> ReflectionPermissionValue)
        {
            return Observable.Select(ReflectionPermissionValue, (ReflectionPermissionValueLambda) => ReflectionPermissionValueLambda.IsUnrestricted());
        }


        public static IObservable<System.Security.IPermission> Union(this IObservable<System.Security.Permissions.ReflectionPermission> ReflectionPermissionValue, IObservable<System.Security.IPermission> other)
        {
            return Observable.Zip(ReflectionPermissionValue, other, (ReflectionPermissionValueLambda, otherLambda) => ReflectionPermissionValueLambda.Union(otherLambda));
        }


        public static IObservable<System.Boolean> IsSubsetOf(this IObservable<System.Security.Permissions.ReflectionPermission> ReflectionPermissionValue, IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(ReflectionPermissionValue, target, (ReflectionPermissionValueLambda, targetLambda) => ReflectionPermissionValueLambda.IsSubsetOf(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Intersect(this IObservable<System.Security.Permissions.ReflectionPermission> ReflectionPermissionValue, IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(ReflectionPermissionValue, target, (ReflectionPermissionValueLambda, targetLambda) => ReflectionPermissionValueLambda.Intersect(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Copy(this IObservable<System.Security.Permissions.ReflectionPermission> ReflectionPermissionValue)
        {
            return Observable.Select(ReflectionPermissionValue, (ReflectionPermissionValueLambda) => ReflectionPermissionValueLambda.Copy());
        }


        public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Permissions.ReflectionPermission> ReflectionPermissionValue)
        {
            return Observable.Select(ReflectionPermissionValue, (ReflectionPermissionValueLambda) => ReflectionPermissionValueLambda.ToXml());
        }


        public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Permissions.ReflectionPermission> ReflectionPermissionValue, IObservable<System.Security.SecurityElement> esd)
        {
            return ObservableExt.ZipExecute(ReflectionPermissionValue, esd, (ReflectionPermissionValueLambda, esdLambda) => ReflectionPermissionValueLambda.FromXml(esdLambda));
        }


        public static IObservable<System.Security.Permissions.ReflectionPermissionFlag> get_Flags(this IObservable<System.Security.Permissions.ReflectionPermission> ReflectionPermissionValue)
        {
            return Observable.Select(ReflectionPermissionValue, (ReflectionPermissionValueLambda) => ReflectionPermissionValueLambda.Flags);
        }


        public static IObservable<System.Reactive.Unit> set_Flags(this IObservable<System.Security.Permissions.ReflectionPermission> ReflectionPermissionValue, IObservable<System.Security.Permissions.ReflectionPermissionFlag> value)
        {
            return ObservableExt.ZipExecute(ReflectionPermissionValue, value, (ReflectionPermissionValueLambda, valueLambda) => ReflectionPermissionValueLambda.Flags = valueLambda);
        }

    }
}