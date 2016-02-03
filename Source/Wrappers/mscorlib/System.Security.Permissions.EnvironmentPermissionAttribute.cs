using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
public static class _EnvironmentPermissionAttribute
{
    
public static IObservable<System.Security.IPermission> CreatePermission(this IObservable<System.Security.Permissions.EnvironmentPermissionAttribute> EnvironmentPermissionAttributeValue)
{
    return Observable.Select(EnvironmentPermissionAttributeValue, (EnvironmentPermissionAttributeValueLambda) => EnvironmentPermissionAttributeValueLambda.CreatePermission());
}


public static IObservable<System.String> get_Read(this IObservable<System.Security.Permissions.EnvironmentPermissionAttribute> EnvironmentPermissionAttributeValue)
{
    return Observable.Select(EnvironmentPermissionAttributeValue, (EnvironmentPermissionAttributeValueLambda) => EnvironmentPermissionAttributeValueLambda.Read);
}


public static IObservable<System.String> get_Write(this IObservable<System.Security.Permissions.EnvironmentPermissionAttribute> EnvironmentPermissionAttributeValue)
{
    return Observable.Select(EnvironmentPermissionAttributeValue, (EnvironmentPermissionAttributeValueLambda) => EnvironmentPermissionAttributeValueLambda.Write);
}


public static IObservable<System.String> get_All(this IObservable<System.Security.Permissions.EnvironmentPermissionAttribute> EnvironmentPermissionAttributeValue)
{
    return Observable.Select(EnvironmentPermissionAttributeValue, (EnvironmentPermissionAttributeValueLambda) => EnvironmentPermissionAttributeValueLambda.All);
}


public static IObservable<System.Reactive.Unit> set_Read(this IObservable<System.Security.Permissions.EnvironmentPermissionAttribute> EnvironmentPermissionAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(EnvironmentPermissionAttributeValue, value, (EnvironmentPermissionAttributeValueLambda, valueLambda) => EnvironmentPermissionAttributeValueLambda.Read = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Write(this IObservable<System.Security.Permissions.EnvironmentPermissionAttribute> EnvironmentPermissionAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(EnvironmentPermissionAttributeValue, value, (EnvironmentPermissionAttributeValueLambda, valueLambda) => EnvironmentPermissionAttributeValueLambda.Write = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_All(this IObservable<System.Security.Permissions.EnvironmentPermissionAttribute> EnvironmentPermissionAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(EnvironmentPermissionAttributeValue, value, (EnvironmentPermissionAttributeValueLambda, valueLambda) => EnvironmentPermissionAttributeValueLambda.All = valueLambda);
}

}
}