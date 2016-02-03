using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __UIPermission
    {
        
        public static IObservable<System.Boolean> IsUnrestricted(this IObservable<System.Security.Permissions.UIPermission> UIPermissionValue)
        {
            return Observable.Select(UIPermissionValue, (UIPermissionValueLambda) => UIPermissionValueLambda.IsUnrestricted());
        }


        public static IObservable<System.Boolean> IsSubsetOf(this IObservable<System.Security.Permissions.UIPermission> UIPermissionValue, IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(UIPermissionValue, target, (UIPermissionValueLambda, targetLambda) => UIPermissionValueLambda.IsSubsetOf(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Intersect(this IObservable<System.Security.Permissions.UIPermission> UIPermissionValue, IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(UIPermissionValue, target, (UIPermissionValueLambda, targetLambda) => UIPermissionValueLambda.Intersect(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Union(this IObservable<System.Security.Permissions.UIPermission> UIPermissionValue, IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(UIPermissionValue, target, (UIPermissionValueLambda, targetLambda) => UIPermissionValueLambda.Union(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Copy(this IObservable<System.Security.Permissions.UIPermission> UIPermissionValue)
        {
            return Observable.Select(UIPermissionValue, (UIPermissionValueLambda) => UIPermissionValueLambda.Copy());
        }


        public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Permissions.UIPermission> UIPermissionValue)
        {
            return Observable.Select(UIPermissionValue, (UIPermissionValueLambda) => UIPermissionValueLambda.ToXml());
        }


        public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Permissions.UIPermission> UIPermissionValue, IObservable<System.Security.SecurityElement> esd)
        {
            return ObservableExt.ZipExecute(UIPermissionValue, esd, (UIPermissionValueLambda, esdLambda) => UIPermissionValueLambda.FromXml(esdLambda));
        }


        public static IObservable<System.Security.Permissions.UIPermissionWindow> get_Window(this IObservable<System.Security.Permissions.UIPermission> UIPermissionValue)
        {
            return Observable.Select(UIPermissionValue, (UIPermissionValueLambda) => UIPermissionValueLambda.Window);
        }


        public static IObservable<System.Security.Permissions.UIPermissionClipboard> get_Clipboard(this IObservable<System.Security.Permissions.UIPermission> UIPermissionValue)
        {
            return Observable.Select(UIPermissionValue, (UIPermissionValueLambda) => UIPermissionValueLambda.Clipboard);
        }


        public static IObservable<System.Reactive.Unit> set_Window(this IObservable<System.Security.Permissions.UIPermission> UIPermissionValue, IObservable<System.Security.Permissions.UIPermissionWindow> value)
        {
            return ObservableExt.ZipExecute(UIPermissionValue, value, (UIPermissionValueLambda, valueLambda) => UIPermissionValueLambda.Window = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Clipboard(this IObservable<System.Security.Permissions.UIPermission> UIPermissionValue, IObservable<System.Security.Permissions.UIPermissionClipboard> value)
        {
            return ObservableExt.ZipExecute(UIPermissionValue, value, (UIPermissionValueLambda, valueLambda) => UIPermissionValueLambda.Clipboard = valueLambda);
        }

    }
}