using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
    public static class __IPermission
    {
        public static IObservable<System.Security.IPermission> Copy(
            this IObservable<System.Security.IPermission> IPermissionValue)
        {
            return Observable.Select(IPermissionValue, (IPermissionValueLambda) => IPermissionValueLambda.Copy());
        }


        public static IObservable<System.Security.IPermission> Intersect(
            this IObservable<System.Security.IPermission> IPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(IPermissionValue, target,
                (IPermissionValueLambda, targetLambda) => IPermissionValueLambda.Intersect(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Union(
            this IObservable<System.Security.IPermission> IPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(IPermissionValue, target,
                (IPermissionValueLambda, targetLambda) => IPermissionValueLambda.Union(targetLambda));
        }


        public static IObservable<System.Boolean> IsSubsetOf(
            this IObservable<System.Security.IPermission> IPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(IPermissionValue, target,
                (IPermissionValueLambda, targetLambda) => IPermissionValueLambda.IsSubsetOf(targetLambda));
        }


        public static IObservable<System.Reactive.Unit> Demand(
            this IObservable<System.Security.IPermission> IPermissionValue)
        {
            return Observable.Do(IPermissionValue, (IPermissionValueLambda) => IPermissionValueLambda.Demand()).ToUnit();
        }
    }
}