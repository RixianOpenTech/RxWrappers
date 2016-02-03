using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __FileIOPermissionAttribute
    {
        
        public static IObservable<System.Security.IPermission> CreatePermission(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue)
        {
            return Observable.Select(FileIOPermissionAttributeValue, (FileIOPermissionAttributeValueLambda) => FileIOPermissionAttributeValueLambda.CreatePermission());
        }


        public static IObservable<System.String> get_Read(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue)
        {
            return Observable.Select(FileIOPermissionAttributeValue, (FileIOPermissionAttributeValueLambda) => FileIOPermissionAttributeValueLambda.Read);
        }


        public static IObservable<System.String> get_Write(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue)
        {
            return Observable.Select(FileIOPermissionAttributeValue, (FileIOPermissionAttributeValueLambda) => FileIOPermissionAttributeValueLambda.Write);
        }


        public static IObservable<System.String> get_Append(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue)
        {
            return Observable.Select(FileIOPermissionAttributeValue, (FileIOPermissionAttributeValueLambda) => FileIOPermissionAttributeValueLambda.Append);
        }


        public static IObservable<System.String> get_PathDiscovery(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue)
        {
            return Observable.Select(FileIOPermissionAttributeValue, (FileIOPermissionAttributeValueLambda) => FileIOPermissionAttributeValueLambda.PathDiscovery);
        }


        public static IObservable<System.String> get_ViewAccessControl(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue)
        {
            return Observable.Select(FileIOPermissionAttributeValue, (FileIOPermissionAttributeValueLambda) => FileIOPermissionAttributeValueLambda.ViewAccessControl);
        }


        public static IObservable<System.String> get_ChangeAccessControl(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue)
        {
            return Observable.Select(FileIOPermissionAttributeValue, (FileIOPermissionAttributeValueLambda) => FileIOPermissionAttributeValueLambda.ChangeAccessControl);
        }


        public static IObservable<System.String> get_All(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue)
        {
            return Observable.Select(FileIOPermissionAttributeValue, (FileIOPermissionAttributeValueLambda) => FileIOPermissionAttributeValueLambda.All);
        }


        public static IObservable<System.String> get_ViewAndModify(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue)
        {
            return Observable.Select(FileIOPermissionAttributeValue, (FileIOPermissionAttributeValueLambda) => FileIOPermissionAttributeValueLambda.ViewAndModify);
        }


        public static IObservable<System.Security.Permissions.FileIOPermissionAccess> get_AllFiles(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue)
        {
            return Observable.Select(FileIOPermissionAttributeValue, (FileIOPermissionAttributeValueLambda) => FileIOPermissionAttributeValueLambda.AllFiles);
        }


        public static IObservable<System.Security.Permissions.FileIOPermissionAccess> get_AllLocalFiles(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue)
        {
            return Observable.Select(FileIOPermissionAttributeValue, (FileIOPermissionAttributeValueLambda) => FileIOPermissionAttributeValueLambda.AllLocalFiles);
        }


        public static IObservable<System.Reactive.Unit> set_Read(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(FileIOPermissionAttributeValue, value, (FileIOPermissionAttributeValueLambda, valueLambda) => FileIOPermissionAttributeValueLambda.Read = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Write(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(FileIOPermissionAttributeValue, value, (FileIOPermissionAttributeValueLambda, valueLambda) => FileIOPermissionAttributeValueLambda.Write = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Append(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(FileIOPermissionAttributeValue, value, (FileIOPermissionAttributeValueLambda, valueLambda) => FileIOPermissionAttributeValueLambda.Append = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PathDiscovery(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(FileIOPermissionAttributeValue, value, (FileIOPermissionAttributeValueLambda, valueLambda) => FileIOPermissionAttributeValueLambda.PathDiscovery = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ViewAccessControl(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(FileIOPermissionAttributeValue, value, (FileIOPermissionAttributeValueLambda, valueLambda) => FileIOPermissionAttributeValueLambda.ViewAccessControl = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ChangeAccessControl(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(FileIOPermissionAttributeValue, value, (FileIOPermissionAttributeValueLambda, valueLambda) => FileIOPermissionAttributeValueLambda.ChangeAccessControl = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_All(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(FileIOPermissionAttributeValue, value, (FileIOPermissionAttributeValueLambda, valueLambda) => FileIOPermissionAttributeValueLambda.All = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ViewAndModify(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(FileIOPermissionAttributeValue, value, (FileIOPermissionAttributeValueLambda, valueLambda) => FileIOPermissionAttributeValueLambda.ViewAndModify = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_AllFiles(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue, IObservable<System.Security.Permissions.FileIOPermissionAccess> value)
        {
            return ObservableExt.ZipExecute(FileIOPermissionAttributeValue, value, (FileIOPermissionAttributeValueLambda, valueLambda) => FileIOPermissionAttributeValueLambda.AllFiles = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_AllLocalFiles(this IObservable<System.Security.Permissions.FileIOPermissionAttribute> FileIOPermissionAttributeValue, IObservable<System.Security.Permissions.FileIOPermissionAccess> value)
        {
            return ObservableExt.ZipExecute(FileIOPermissionAttributeValue, value, (FileIOPermissionAttributeValueLambda, valueLambda) => FileIOPermissionAttributeValueLambda.AllLocalFiles = valueLambda);
        }

    }
}