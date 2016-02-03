using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
public static class _StrongNameIdentityPermissionAttribute
{
    
public static IObservable<System.Security.IPermission> CreatePermission(this IObservable<System.Security.Permissions.StrongNameIdentityPermissionAttribute> StrongNameIdentityPermissionAttributeValue)
{
    return Observable.Select(StrongNameIdentityPermissionAttributeValue, (StrongNameIdentityPermissionAttributeValueLambda) => StrongNameIdentityPermissionAttributeValueLambda.CreatePermission());
}


public static IObservable<System.String> get_Name(this IObservable<System.Security.Permissions.StrongNameIdentityPermissionAttribute> StrongNameIdentityPermissionAttributeValue)
{
    return Observable.Select(StrongNameIdentityPermissionAttributeValue, (StrongNameIdentityPermissionAttributeValueLambda) => StrongNameIdentityPermissionAttributeValueLambda.Name);
}


public static IObservable<System.String> get_Version(this IObservable<System.Security.Permissions.StrongNameIdentityPermissionAttribute> StrongNameIdentityPermissionAttributeValue)
{
    return Observable.Select(StrongNameIdentityPermissionAttributeValue, (StrongNameIdentityPermissionAttributeValueLambda) => StrongNameIdentityPermissionAttributeValueLambda.Version);
}


public static IObservable<System.String> get_PublicKey(this IObservable<System.Security.Permissions.StrongNameIdentityPermissionAttribute> StrongNameIdentityPermissionAttributeValue)
{
    return Observable.Select(StrongNameIdentityPermissionAttributeValue, (StrongNameIdentityPermissionAttributeValueLambda) => StrongNameIdentityPermissionAttributeValueLambda.PublicKey);
}


public static IObservable<System.Reactive.Unit> set_Name(this IObservable<System.Security.Permissions.StrongNameIdentityPermissionAttribute> StrongNameIdentityPermissionAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(StrongNameIdentityPermissionAttributeValue, value, (StrongNameIdentityPermissionAttributeValueLambda, valueLambda) => StrongNameIdentityPermissionAttributeValueLambda.Name = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Version(this IObservable<System.Security.Permissions.StrongNameIdentityPermissionAttribute> StrongNameIdentityPermissionAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(StrongNameIdentityPermissionAttributeValue, value, (StrongNameIdentityPermissionAttributeValueLambda, valueLambda) => StrongNameIdentityPermissionAttributeValueLambda.Version = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_PublicKey(this IObservable<System.Security.Permissions.StrongNameIdentityPermissionAttribute> StrongNameIdentityPermissionAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(StrongNameIdentityPermissionAttributeValue, value, (StrongNameIdentityPermissionAttributeValueLambda, valueLambda) => StrongNameIdentityPermissionAttributeValueLambda.PublicKey = valueLambda);
}

}
}