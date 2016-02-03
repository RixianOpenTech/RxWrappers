using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __KeyContainerPermission
    {
        public static IObservable<System.Boolean> IsUnrestricted(
            this IObservable<System.Security.Permissions.KeyContainerPermission> KeyContainerPermissionValue)
        {
            return Observable.Select(KeyContainerPermissionValue,
                (KeyContainerPermissionValueLambda) => KeyContainerPermissionValueLambda.IsUnrestricted());
        }


        public static IObservable<System.Boolean> IsSubsetOf(
            this IObservable<System.Security.Permissions.KeyContainerPermission> KeyContainerPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(KeyContainerPermissionValue, target,
                (KeyContainerPermissionValueLambda, targetLambda) =>
                    KeyContainerPermissionValueLambda.IsSubsetOf(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Intersect(
            this IObservable<System.Security.Permissions.KeyContainerPermission> KeyContainerPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(KeyContainerPermissionValue, target,
                (KeyContainerPermissionValueLambda, targetLambda) =>
                    KeyContainerPermissionValueLambda.Intersect(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Union(
            this IObservable<System.Security.Permissions.KeyContainerPermission> KeyContainerPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(KeyContainerPermissionValue, target,
                (KeyContainerPermissionValueLambda, targetLambda) =>
                    KeyContainerPermissionValueLambda.Union(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Copy(
            this IObservable<System.Security.Permissions.KeyContainerPermission> KeyContainerPermissionValue)
        {
            return Observable.Select(KeyContainerPermissionValue,
                (KeyContainerPermissionValueLambda) => KeyContainerPermissionValueLambda.Copy());
        }


        public static IObservable<System.Security.SecurityElement> ToXml(
            this IObservable<System.Security.Permissions.KeyContainerPermission> KeyContainerPermissionValue)
        {
            return Observable.Select(KeyContainerPermissionValue,
                (KeyContainerPermissionValueLambda) => KeyContainerPermissionValueLambda.ToXml());
        }


        public static IObservable<System.Reactive.Unit> FromXml(
            this IObservable<System.Security.Permissions.KeyContainerPermission> KeyContainerPermissionValue,
            IObservable<System.Security.SecurityElement> securityElement)
        {
            return ObservableExt.ZipExecute(KeyContainerPermissionValue, securityElement,
                (KeyContainerPermissionValueLambda, securityElementLambda) =>
                    KeyContainerPermissionValueLambda.FromXml(securityElementLambda));
        }


        public static IObservable<System.Security.Permissions.KeyContainerPermissionFlags> get_Flags(
            this IObservable<System.Security.Permissions.KeyContainerPermission> KeyContainerPermissionValue)
        {
            return Observable.Select(KeyContainerPermissionValue,
                (KeyContainerPermissionValueLambda) => KeyContainerPermissionValueLambda.Flags);
        }


        public static IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntryCollection>
            get_AccessEntries(
            this IObservable<System.Security.Permissions.KeyContainerPermission> KeyContainerPermissionValue)
        {
            return Observable.Select(KeyContainerPermissionValue,
                (KeyContainerPermissionValueLambda) => KeyContainerPermissionValueLambda.AccessEntries);
        }
    }
}