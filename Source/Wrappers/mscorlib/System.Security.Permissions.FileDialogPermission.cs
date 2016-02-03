using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __FileDialogPermission
    {
        public static IObservable<System.Reactive.Unit> FromXml(
            this IObservable<System.Security.Permissions.FileDialogPermission> FileDialogPermissionValue,
            IObservable<System.Security.SecurityElement> esd)
        {
            return ObservableExt.ZipExecute(FileDialogPermissionValue, esd,
                (FileDialogPermissionValueLambda, esdLambda) => FileDialogPermissionValueLambda.FromXml(esdLambda));
        }


        public static IObservable<System.Security.IPermission> Copy(
            this IObservable<System.Security.Permissions.FileDialogPermission> FileDialogPermissionValue)
        {
            return Observable.Select(FileDialogPermissionValue,
                (FileDialogPermissionValueLambda) => FileDialogPermissionValueLambda.Copy());
        }


        public static IObservable<System.Security.IPermission> Intersect(
            this IObservable<System.Security.Permissions.FileDialogPermission> FileDialogPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(FileDialogPermissionValue, target,
                (FileDialogPermissionValueLambda, targetLambda) =>
                    FileDialogPermissionValueLambda.Intersect(targetLambda));
        }


        public static IObservable<System.Boolean> IsSubsetOf(
            this IObservable<System.Security.Permissions.FileDialogPermission> FileDialogPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(FileDialogPermissionValue, target,
                (FileDialogPermissionValueLambda, targetLambda) =>
                    FileDialogPermissionValueLambda.IsSubsetOf(targetLambda));
        }


        public static IObservable<System.Boolean> IsUnrestricted(
            this IObservable<System.Security.Permissions.FileDialogPermission> FileDialogPermissionValue)
        {
            return Observable.Select(FileDialogPermissionValue,
                (FileDialogPermissionValueLambda) => FileDialogPermissionValueLambda.IsUnrestricted());
        }


        public static IObservable<System.Security.SecurityElement> ToXml(
            this IObservable<System.Security.Permissions.FileDialogPermission> FileDialogPermissionValue)
        {
            return Observable.Select(FileDialogPermissionValue,
                (FileDialogPermissionValueLambda) => FileDialogPermissionValueLambda.ToXml());
        }


        public static IObservable<System.Security.IPermission> Union(
            this IObservable<System.Security.Permissions.FileDialogPermission> FileDialogPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(FileDialogPermissionValue, target,
                (FileDialogPermissionValueLambda, targetLambda) => FileDialogPermissionValueLambda.Union(targetLambda));
        }


        public static IObservable<System.Security.Permissions.FileDialogPermissionAccess> get_Access(
            this IObservable<System.Security.Permissions.FileDialogPermission> FileDialogPermissionValue)
        {
            return Observable.Select(FileDialogPermissionValue,
                (FileDialogPermissionValueLambda) => FileDialogPermissionValueLambda.Access);
        }


        public static IObservable<System.Reactive.Unit> set_Access(
            this IObservable<System.Security.Permissions.FileDialogPermission> FileDialogPermissionValue,
            IObservable<System.Security.Permissions.FileDialogPermissionAccess> value)
        {
            return ObservableExt.ZipExecute(FileDialogPermissionValue, value,
                (FileDialogPermissionValueLambda, valueLambda) => FileDialogPermissionValueLambda.Access = valueLambda);
        }
    }
}