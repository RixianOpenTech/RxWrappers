using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __UIPermissionAttribute
    {
        public static IObservable<System.Security.IPermission> CreatePermission(
            this IObservable<System.Security.Permissions.UIPermissionAttribute> UIPermissionAttributeValue)
        {
            return Observable.Select(UIPermissionAttributeValue,
                (UIPermissionAttributeValueLambda) => UIPermissionAttributeValueLambda.CreatePermission());
        }


        public static IObservable<System.Security.Permissions.UIPermissionWindow> get_Window(
            this IObservable<System.Security.Permissions.UIPermissionAttribute> UIPermissionAttributeValue)
        {
            return Observable.Select(UIPermissionAttributeValue,
                (UIPermissionAttributeValueLambda) => UIPermissionAttributeValueLambda.Window);
        }


        public static IObservable<System.Security.Permissions.UIPermissionClipboard> get_Clipboard(
            this IObservable<System.Security.Permissions.UIPermissionAttribute> UIPermissionAttributeValue)
        {
            return Observable.Select(UIPermissionAttributeValue,
                (UIPermissionAttributeValueLambda) => UIPermissionAttributeValueLambda.Clipboard);
        }


        public static IObservable<System.Reactive.Unit> set_Window(
            this IObservable<System.Security.Permissions.UIPermissionAttribute> UIPermissionAttributeValue,
            IObservable<System.Security.Permissions.UIPermissionWindow> value)
        {
            return ObservableExt.ZipExecute(UIPermissionAttributeValue, value,
                (UIPermissionAttributeValueLambda, valueLambda) => UIPermissionAttributeValueLambda.Window = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Clipboard(
            this IObservable<System.Security.Permissions.UIPermissionAttribute> UIPermissionAttributeValue,
            IObservable<System.Security.Permissions.UIPermissionClipboard> value)
        {
            return ObservableExt.ZipExecute(UIPermissionAttributeValue, value,
                (UIPermissionAttributeValueLambda, valueLambda) =>
                    UIPermissionAttributeValueLambda.Clipboard = valueLambda);
        }
    }
}