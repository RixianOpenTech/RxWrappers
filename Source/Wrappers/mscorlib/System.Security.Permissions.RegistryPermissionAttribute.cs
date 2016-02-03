using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __RegistryPermissionAttribute
    {
        public static IObservable<System.Security.IPermission> CreatePermission(
            this IObservable<System.Security.Permissions.RegistryPermissionAttribute> RegistryPermissionAttributeValue)
        {
            return Observable.Select(RegistryPermissionAttributeValue,
                (RegistryPermissionAttributeValueLambda) => RegistryPermissionAttributeValueLambda.CreatePermission());
        }


        public static IObservable<System.String> get_Read(
            this IObservable<System.Security.Permissions.RegistryPermissionAttribute> RegistryPermissionAttributeValue)
        {
            return Observable.Select(RegistryPermissionAttributeValue,
                (RegistryPermissionAttributeValueLambda) => RegistryPermissionAttributeValueLambda.Read);
        }


        public static IObservable<System.String> get_Write(
            this IObservable<System.Security.Permissions.RegistryPermissionAttribute> RegistryPermissionAttributeValue)
        {
            return Observable.Select(RegistryPermissionAttributeValue,
                (RegistryPermissionAttributeValueLambda) => RegistryPermissionAttributeValueLambda.Write);
        }


        public static IObservable<System.String> get_Create(
            this IObservable<System.Security.Permissions.RegistryPermissionAttribute> RegistryPermissionAttributeValue)
        {
            return Observable.Select(RegistryPermissionAttributeValue,
                (RegistryPermissionAttributeValueLambda) => RegistryPermissionAttributeValueLambda.Create);
        }


        public static IObservable<System.String> get_ViewAccessControl(
            this IObservable<System.Security.Permissions.RegistryPermissionAttribute> RegistryPermissionAttributeValue)
        {
            return Observable.Select(RegistryPermissionAttributeValue,
                (RegistryPermissionAttributeValueLambda) => RegistryPermissionAttributeValueLambda.ViewAccessControl);
        }


        public static IObservable<System.String> get_ChangeAccessControl(
            this IObservable<System.Security.Permissions.RegistryPermissionAttribute> RegistryPermissionAttributeValue)
        {
            return Observable.Select(RegistryPermissionAttributeValue,
                (RegistryPermissionAttributeValueLambda) => RegistryPermissionAttributeValueLambda.ChangeAccessControl);
        }


        public static IObservable<System.String> get_ViewAndModify(
            this IObservable<System.Security.Permissions.RegistryPermissionAttribute> RegistryPermissionAttributeValue)
        {
            return Observable.Select(RegistryPermissionAttributeValue,
                (RegistryPermissionAttributeValueLambda) => RegistryPermissionAttributeValueLambda.ViewAndModify);
        }


        public static IObservable<System.String> get_All(
            this IObservable<System.Security.Permissions.RegistryPermissionAttribute> RegistryPermissionAttributeValue)
        {
            return Observable.Select(RegistryPermissionAttributeValue,
                (RegistryPermissionAttributeValueLambda) => RegistryPermissionAttributeValueLambda.All);
        }


        public static IObservable<System.Reactive.Unit> set_Read(
            this IObservable<System.Security.Permissions.RegistryPermissionAttribute> RegistryPermissionAttributeValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(RegistryPermissionAttributeValue, value,
                (RegistryPermissionAttributeValueLambda, valueLambda) =>
                    RegistryPermissionAttributeValueLambda.Read = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Write(
            this IObservable<System.Security.Permissions.RegistryPermissionAttribute> RegistryPermissionAttributeValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(RegistryPermissionAttributeValue, value,
                (RegistryPermissionAttributeValueLambda, valueLambda) =>
                    RegistryPermissionAttributeValueLambda.Write = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Create(
            this IObservable<System.Security.Permissions.RegistryPermissionAttribute> RegistryPermissionAttributeValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(RegistryPermissionAttributeValue, value,
                (RegistryPermissionAttributeValueLambda, valueLambda) =>
                    RegistryPermissionAttributeValueLambda.Create = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ViewAccessControl(
            this IObservable<System.Security.Permissions.RegistryPermissionAttribute> RegistryPermissionAttributeValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(RegistryPermissionAttributeValue, value,
                (RegistryPermissionAttributeValueLambda, valueLambda) =>
                    RegistryPermissionAttributeValueLambda.ViewAccessControl = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ChangeAccessControl(
            this IObservable<System.Security.Permissions.RegistryPermissionAttribute> RegistryPermissionAttributeValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(RegistryPermissionAttributeValue, value,
                (RegistryPermissionAttributeValueLambda, valueLambda) =>
                    RegistryPermissionAttributeValueLambda.ChangeAccessControl = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ViewAndModify(
            this IObservable<System.Security.Permissions.RegistryPermissionAttribute> RegistryPermissionAttributeValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(RegistryPermissionAttributeValue, value,
                (RegistryPermissionAttributeValueLambda, valueLambda) =>
                    RegistryPermissionAttributeValueLambda.ViewAndModify = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_All(
            this IObservable<System.Security.Permissions.RegistryPermissionAttribute> RegistryPermissionAttributeValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(RegistryPermissionAttributeValue, value,
                (RegistryPermissionAttributeValueLambda, valueLambda) =>
                    RegistryPermissionAttributeValueLambda.All = valueLambda);
        }
    }
}