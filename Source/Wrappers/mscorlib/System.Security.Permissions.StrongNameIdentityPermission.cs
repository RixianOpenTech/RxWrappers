using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __StrongNameIdentityPermission
    {
        public static IObservable<System.Security.IPermission> Copy(
            this IObservable<System.Security.Permissions.StrongNameIdentityPermission> StrongNameIdentityPermissionValue)
        {
            return Observable.Select(StrongNameIdentityPermissionValue,
                (StrongNameIdentityPermissionValueLambda) => StrongNameIdentityPermissionValueLambda.Copy());
        }


        public static IObservable<System.Boolean> IsSubsetOf(
            this IObservable<System.Security.Permissions.StrongNameIdentityPermission> StrongNameIdentityPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(StrongNameIdentityPermissionValue, target,
                (StrongNameIdentityPermissionValueLambda, targetLambda) =>
                    StrongNameIdentityPermissionValueLambda.IsSubsetOf(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Intersect(
            this IObservable<System.Security.Permissions.StrongNameIdentityPermission> StrongNameIdentityPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(StrongNameIdentityPermissionValue, target,
                (StrongNameIdentityPermissionValueLambda, targetLambda) =>
                    StrongNameIdentityPermissionValueLambda.Intersect(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Union(
            this IObservable<System.Security.Permissions.StrongNameIdentityPermission> StrongNameIdentityPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(StrongNameIdentityPermissionValue, target,
                (StrongNameIdentityPermissionValueLambda, targetLambda) =>
                    StrongNameIdentityPermissionValueLambda.Union(targetLambda));
        }


        public static IObservable<System.Reactive.Unit> FromXml(
            this IObservable<System.Security.Permissions.StrongNameIdentityPermission> StrongNameIdentityPermissionValue,
            IObservable<System.Security.SecurityElement> e)
        {
            return ObservableExt.ZipExecute(StrongNameIdentityPermissionValue, e,
                (StrongNameIdentityPermissionValueLambda, eLambda) =>
                    StrongNameIdentityPermissionValueLambda.FromXml(eLambda));
        }


        public static IObservable<System.Security.SecurityElement> ToXml(
            this IObservable<System.Security.Permissions.StrongNameIdentityPermission> StrongNameIdentityPermissionValue)
        {
            return Observable.Select(StrongNameIdentityPermissionValue,
                (StrongNameIdentityPermissionValueLambda) => StrongNameIdentityPermissionValueLambda.ToXml());
        }


        public static IObservable<System.Security.Permissions.StrongNamePublicKeyBlob> get_PublicKey(
            this IObservable<System.Security.Permissions.StrongNameIdentityPermission> StrongNameIdentityPermissionValue)
        {
            return Observable.Select(StrongNameIdentityPermissionValue,
                (StrongNameIdentityPermissionValueLambda) => StrongNameIdentityPermissionValueLambda.PublicKey);
        }


        public static IObservable<System.String> get_Name(
            this IObservable<System.Security.Permissions.StrongNameIdentityPermission> StrongNameIdentityPermissionValue)
        {
            return Observable.Select(StrongNameIdentityPermissionValue,
                (StrongNameIdentityPermissionValueLambda) => StrongNameIdentityPermissionValueLambda.Name);
        }


        public static IObservable<System.Version> get_Version(
            this IObservable<System.Security.Permissions.StrongNameIdentityPermission> StrongNameIdentityPermissionValue)
        {
            return Observable.Select(StrongNameIdentityPermissionValue,
                (StrongNameIdentityPermissionValueLambda) => StrongNameIdentityPermissionValueLambda.Version);
        }


        public static IObservable<System.Reactive.Unit> set_PublicKey(
            this IObservable<System.Security.Permissions.StrongNameIdentityPermission> StrongNameIdentityPermissionValue,
            IObservable<System.Security.Permissions.StrongNamePublicKeyBlob> value)
        {
            return ObservableExt.ZipExecute(StrongNameIdentityPermissionValue, value,
                (StrongNameIdentityPermissionValueLambda, valueLambda) =>
                    StrongNameIdentityPermissionValueLambda.PublicKey = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Name(
            this IObservable<System.Security.Permissions.StrongNameIdentityPermission> StrongNameIdentityPermissionValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(StrongNameIdentityPermissionValue, value,
                (StrongNameIdentityPermissionValueLambda, valueLambda) =>
                    StrongNameIdentityPermissionValueLambda.Name = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Version(
            this IObservable<System.Security.Permissions.StrongNameIdentityPermission> StrongNameIdentityPermissionValue,
            IObservable<System.Version> value)
        {
            return ObservableExt.ZipExecute(StrongNameIdentityPermissionValue, value,
                (StrongNameIdentityPermissionValueLambda, valueLambda) =>
                    StrongNameIdentityPermissionValueLambda.Version = valueLambda);
        }
    }
}