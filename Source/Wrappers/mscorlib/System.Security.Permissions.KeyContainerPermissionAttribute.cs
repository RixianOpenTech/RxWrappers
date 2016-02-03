using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
public static class _KeyContainerPermissionAttribute
{
    
public static IObservable<System.Security.IPermission> CreatePermission(this IObservable<System.Security.Permissions.KeyContainerPermissionAttribute> KeyContainerPermissionAttributeValue)
{
    return Observable.Select(KeyContainerPermissionAttributeValue, (KeyContainerPermissionAttributeValueLambda) => KeyContainerPermissionAttributeValueLambda.CreatePermission());
}


public static IObservable<System.String> get_KeyStore(this IObservable<System.Security.Permissions.KeyContainerPermissionAttribute> KeyContainerPermissionAttributeValue)
{
    return Observable.Select(KeyContainerPermissionAttributeValue, (KeyContainerPermissionAttributeValueLambda) => KeyContainerPermissionAttributeValueLambda.KeyStore);
}


public static IObservable<System.String> get_ProviderName(this IObservable<System.Security.Permissions.KeyContainerPermissionAttribute> KeyContainerPermissionAttributeValue)
{
    return Observable.Select(KeyContainerPermissionAttributeValue, (KeyContainerPermissionAttributeValueLambda) => KeyContainerPermissionAttributeValueLambda.ProviderName);
}


public static IObservable<System.Int32> get_ProviderType(this IObservable<System.Security.Permissions.KeyContainerPermissionAttribute> KeyContainerPermissionAttributeValue)
{
    return Observable.Select(KeyContainerPermissionAttributeValue, (KeyContainerPermissionAttributeValueLambda) => KeyContainerPermissionAttributeValueLambda.ProviderType);
}


public static IObservable<System.String> get_KeyContainerName(this IObservable<System.Security.Permissions.KeyContainerPermissionAttribute> KeyContainerPermissionAttributeValue)
{
    return Observable.Select(KeyContainerPermissionAttributeValue, (KeyContainerPermissionAttributeValueLambda) => KeyContainerPermissionAttributeValueLambda.KeyContainerName);
}


public static IObservable<System.Int32> get_KeySpec(this IObservable<System.Security.Permissions.KeyContainerPermissionAttribute> KeyContainerPermissionAttributeValue)
{
    return Observable.Select(KeyContainerPermissionAttributeValue, (KeyContainerPermissionAttributeValueLambda) => KeyContainerPermissionAttributeValueLambda.KeySpec);
}


public static IObservable<System.Security.Permissions.KeyContainerPermissionFlags> get_Flags(this IObservable<System.Security.Permissions.KeyContainerPermissionAttribute> KeyContainerPermissionAttributeValue)
{
    return Observable.Select(KeyContainerPermissionAttributeValue, (KeyContainerPermissionAttributeValueLambda) => KeyContainerPermissionAttributeValueLambda.Flags);
}


public static IObservable<System.Reactive.Unit> set_KeyStore(this IObservable<System.Security.Permissions.KeyContainerPermissionAttribute> KeyContainerPermissionAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(KeyContainerPermissionAttributeValue, value, (KeyContainerPermissionAttributeValueLambda, valueLambda) => KeyContainerPermissionAttributeValueLambda.KeyStore = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ProviderName(this IObservable<System.Security.Permissions.KeyContainerPermissionAttribute> KeyContainerPermissionAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(KeyContainerPermissionAttributeValue, value, (KeyContainerPermissionAttributeValueLambda, valueLambda) => KeyContainerPermissionAttributeValueLambda.ProviderName = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ProviderType(this IObservable<System.Security.Permissions.KeyContainerPermissionAttribute> KeyContainerPermissionAttributeValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(KeyContainerPermissionAttributeValue, value, (KeyContainerPermissionAttributeValueLambda, valueLambda) => KeyContainerPermissionAttributeValueLambda.ProviderType = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_KeyContainerName(this IObservable<System.Security.Permissions.KeyContainerPermissionAttribute> KeyContainerPermissionAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(KeyContainerPermissionAttributeValue, value, (KeyContainerPermissionAttributeValueLambda, valueLambda) => KeyContainerPermissionAttributeValueLambda.KeyContainerName = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_KeySpec(this IObservable<System.Security.Permissions.KeyContainerPermissionAttribute> KeyContainerPermissionAttributeValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(KeyContainerPermissionAttributeValue, value, (KeyContainerPermissionAttributeValueLambda, valueLambda) => KeyContainerPermissionAttributeValueLambda.KeySpec = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Flags(this IObservable<System.Security.Permissions.KeyContainerPermissionAttribute> KeyContainerPermissionAttributeValue, IObservable<System.Security.Permissions.KeyContainerPermissionFlags> value)
{
    return ObservableExt.ZipExecute(KeyContainerPermissionAttributeValue, value, (KeyContainerPermissionAttributeValueLambda, valueLambda) => KeyContainerPermissionAttributeValueLambda.Flags = valueLambda);
}

}
}