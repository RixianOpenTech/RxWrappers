using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
public static class _ReflectionPermissionAttribute
{
    
public static IObservable<System.Security.IPermission> CreatePermission(this IObservable<System.Security.Permissions.ReflectionPermissionAttribute> ReflectionPermissionAttributeValue)
{
    return Observable.Select(ReflectionPermissionAttributeValue, (ReflectionPermissionAttributeValueLambda) => ReflectionPermissionAttributeValueLambda.CreatePermission());
}


public static IObservable<System.Security.Permissions.ReflectionPermissionFlag> get_Flags(this IObservable<System.Security.Permissions.ReflectionPermissionAttribute> ReflectionPermissionAttributeValue)
{
    return Observable.Select(ReflectionPermissionAttributeValue, (ReflectionPermissionAttributeValueLambda) => ReflectionPermissionAttributeValueLambda.Flags);
}


public static IObservable<System.Boolean> get_TypeInformation(this IObservable<System.Security.Permissions.ReflectionPermissionAttribute> ReflectionPermissionAttributeValue)
{
    return Observable.Select(ReflectionPermissionAttributeValue, (ReflectionPermissionAttributeValueLambda) => ReflectionPermissionAttributeValueLambda.TypeInformation);
}


public static IObservable<System.Boolean> get_MemberAccess(this IObservable<System.Security.Permissions.ReflectionPermissionAttribute> ReflectionPermissionAttributeValue)
{
    return Observable.Select(ReflectionPermissionAttributeValue, (ReflectionPermissionAttributeValueLambda) => ReflectionPermissionAttributeValueLambda.MemberAccess);
}


public static IObservable<System.Boolean> get_ReflectionEmit(this IObservable<System.Security.Permissions.ReflectionPermissionAttribute> ReflectionPermissionAttributeValue)
{
    return Observable.Select(ReflectionPermissionAttributeValue, (ReflectionPermissionAttributeValueLambda) => ReflectionPermissionAttributeValueLambda.ReflectionEmit);
}


public static IObservable<System.Boolean> get_RestrictedMemberAccess(this IObservable<System.Security.Permissions.ReflectionPermissionAttribute> ReflectionPermissionAttributeValue)
{
    return Observable.Select(ReflectionPermissionAttributeValue, (ReflectionPermissionAttributeValueLambda) => ReflectionPermissionAttributeValueLambda.RestrictedMemberAccess);
}


public static IObservable<System.Reactive.Unit> set_Flags(this IObservable<System.Security.Permissions.ReflectionPermissionAttribute> ReflectionPermissionAttributeValue, IObservable<System.Security.Permissions.ReflectionPermissionFlag> value)
{
    return ObservableExt.ZipExecute(ReflectionPermissionAttributeValue, value, (ReflectionPermissionAttributeValueLambda, valueLambda) => ReflectionPermissionAttributeValueLambda.Flags = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_TypeInformation(this IObservable<System.Security.Permissions.ReflectionPermissionAttribute> ReflectionPermissionAttributeValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(ReflectionPermissionAttributeValue, value, (ReflectionPermissionAttributeValueLambda, valueLambda) => ReflectionPermissionAttributeValueLambda.TypeInformation = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_MemberAccess(this IObservable<System.Security.Permissions.ReflectionPermissionAttribute> ReflectionPermissionAttributeValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(ReflectionPermissionAttributeValue, value, (ReflectionPermissionAttributeValueLambda, valueLambda) => ReflectionPermissionAttributeValueLambda.MemberAccess = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ReflectionEmit(this IObservable<System.Security.Permissions.ReflectionPermissionAttribute> ReflectionPermissionAttributeValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(ReflectionPermissionAttributeValue, value, (ReflectionPermissionAttributeValueLambda, valueLambda) => ReflectionPermissionAttributeValueLambda.ReflectionEmit = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_RestrictedMemberAccess(this IObservable<System.Security.Permissions.ReflectionPermissionAttribute> ReflectionPermissionAttributeValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(ReflectionPermissionAttributeValue, value, (ReflectionPermissionAttributeValueLambda, valueLambda) => ReflectionPermissionAttributeValueLambda.RestrictedMemberAccess = valueLambda);
}

}
}