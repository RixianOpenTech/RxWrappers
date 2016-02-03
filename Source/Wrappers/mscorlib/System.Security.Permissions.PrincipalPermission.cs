using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __PrincipalPermission
    {
        
        public static IObservable<System.Boolean> IsUnrestricted(this IObservable<System.Security.Permissions.PrincipalPermission> PrincipalPermissionValue)
        {
            return Observable.Select(PrincipalPermissionValue, (PrincipalPermissionValueLambda) => PrincipalPermissionValueLambda.IsUnrestricted());
        }


        public static IObservable<System.Boolean> IsSubsetOf(this IObservable<System.Security.Permissions.PrincipalPermission> PrincipalPermissionValue, IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(PrincipalPermissionValue, target, (PrincipalPermissionValueLambda, targetLambda) => PrincipalPermissionValueLambda.IsSubsetOf(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Intersect(this IObservable<System.Security.Permissions.PrincipalPermission> PrincipalPermissionValue, IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(PrincipalPermissionValue, target, (PrincipalPermissionValueLambda, targetLambda) => PrincipalPermissionValueLambda.Intersect(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Union(this IObservable<System.Security.Permissions.PrincipalPermission> PrincipalPermissionValue, IObservable<System.Security.IPermission> other)
        {
            return Observable.Zip(PrincipalPermissionValue, other, (PrincipalPermissionValueLambda, otherLambda) => PrincipalPermissionValueLambda.Union(otherLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Permissions.PrincipalPermission> PrincipalPermissionValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(PrincipalPermissionValue, obj, (PrincipalPermissionValueLambda, objLambda) => PrincipalPermissionValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Permissions.PrincipalPermission> PrincipalPermissionValue)
        {
            return Observable.Select(PrincipalPermissionValue, (PrincipalPermissionValueLambda) => PrincipalPermissionValueLambda.GetHashCode());
        }


        public static IObservable<System.Security.IPermission> Copy(this IObservable<System.Security.Permissions.PrincipalPermission> PrincipalPermissionValue)
        {
            return Observable.Select(PrincipalPermissionValue, (PrincipalPermissionValueLambda) => PrincipalPermissionValueLambda.Copy());
        }


        public static IObservable<System.Reactive.Unit> Demand(this IObservable<System.Security.Permissions.PrincipalPermission> PrincipalPermissionValue)
        {
            return Observable.Do(PrincipalPermissionValue, (PrincipalPermissionValueLambda) => PrincipalPermissionValueLambda.Demand()).ToUnit();
        }


        public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Permissions.PrincipalPermission> PrincipalPermissionValue)
        {
            return Observable.Select(PrincipalPermissionValue, (PrincipalPermissionValueLambda) => PrincipalPermissionValueLambda.ToXml());
        }


        public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Permissions.PrincipalPermission> PrincipalPermissionValue, IObservable<System.Security.SecurityElement> elem)
        {
            return ObservableExt.ZipExecute(PrincipalPermissionValue, elem, (PrincipalPermissionValueLambda, elemLambda) => PrincipalPermissionValueLambda.FromXml(elemLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Security.Permissions.PrincipalPermission> PrincipalPermissionValue)
        {
            return Observable.Select(PrincipalPermissionValue, (PrincipalPermissionValueLambda) => PrincipalPermissionValueLambda.ToString());
        }

    }
}