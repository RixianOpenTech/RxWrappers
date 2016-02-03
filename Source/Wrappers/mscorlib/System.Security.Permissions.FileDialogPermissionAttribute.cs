using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
public static class _FileDialogPermissionAttribute
{
    
public static IObservable<System.Security.IPermission> CreatePermission(this IObservable<System.Security.Permissions.FileDialogPermissionAttribute> FileDialogPermissionAttributeValue)
{
    return Observable.Select(FileDialogPermissionAttributeValue, (FileDialogPermissionAttributeValueLambda) => FileDialogPermissionAttributeValueLambda.CreatePermission());
}


public static IObservable<System.Boolean> get_Open(this IObservable<System.Security.Permissions.FileDialogPermissionAttribute> FileDialogPermissionAttributeValue)
{
    return Observable.Select(FileDialogPermissionAttributeValue, (FileDialogPermissionAttributeValueLambda) => FileDialogPermissionAttributeValueLambda.Open);
}


public static IObservable<System.Boolean> get_Save(this IObservable<System.Security.Permissions.FileDialogPermissionAttribute> FileDialogPermissionAttributeValue)
{
    return Observable.Select(FileDialogPermissionAttributeValue, (FileDialogPermissionAttributeValueLambda) => FileDialogPermissionAttributeValueLambda.Save);
}


public static IObservable<System.Reactive.Unit> set_Open(this IObservable<System.Security.Permissions.FileDialogPermissionAttribute> FileDialogPermissionAttributeValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(FileDialogPermissionAttributeValue, value, (FileDialogPermissionAttributeValueLambda, valueLambda) => FileDialogPermissionAttributeValueLambda.Open = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Save(this IObservable<System.Security.Permissions.FileDialogPermissionAttribute> FileDialogPermissionAttributeValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(FileDialogPermissionAttributeValue, value, (FileDialogPermissionAttributeValueLambda, valueLambda) => FileDialogPermissionAttributeValueLambda.Save = valueLambda);
}

}
}