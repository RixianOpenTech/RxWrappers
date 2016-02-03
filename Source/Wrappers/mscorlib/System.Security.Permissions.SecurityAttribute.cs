using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
public static class _SecurityAttribute
{
    
public static IObservable<System.Security.IPermission> CreatePermission(this IObservable<System.Security.Permissions.SecurityAttribute> SecurityAttributeValue)
{
    return Observable.Select(SecurityAttributeValue, (SecurityAttributeValueLambda) => SecurityAttributeValueLambda.CreatePermission());
}


public static IObservable<System.Security.Permissions.SecurityAction> get_Action(this IObservable<System.Security.Permissions.SecurityAttribute> SecurityAttributeValue)
{
    return Observable.Select(SecurityAttributeValue, (SecurityAttributeValueLambda) => SecurityAttributeValueLambda.Action);
}


public static IObservable<System.Boolean> get_Unrestricted(this IObservable<System.Security.Permissions.SecurityAttribute> SecurityAttributeValue)
{
    return Observable.Select(SecurityAttributeValue, (SecurityAttributeValueLambda) => SecurityAttributeValueLambda.Unrestricted);
}


public static IObservable<System.Reactive.Unit> set_Action(this IObservable<System.Security.Permissions.SecurityAttribute> SecurityAttributeValue, IObservable<System.Security.Permissions.SecurityAction> value)
{
    return ObservableExt.ZipExecute(SecurityAttributeValue, value, (SecurityAttributeValueLambda, valueLambda) => SecurityAttributeValueLambda.Action = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Unrestricted(this IObservable<System.Security.Permissions.SecurityAttribute> SecurityAttributeValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(SecurityAttributeValue, value, (SecurityAttributeValueLambda, valueLambda) => SecurityAttributeValueLambda.Unrestricted = valueLambda);
}

}
}