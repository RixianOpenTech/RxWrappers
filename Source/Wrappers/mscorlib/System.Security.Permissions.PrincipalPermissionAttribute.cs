using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __PrincipalPermissionAttribute
    {
        
        public static IObservable<System.Security.IPermission> CreatePermission(this IObservable<System.Security.Permissions.PrincipalPermissionAttribute> PrincipalPermissionAttributeValue)
        {
            return Observable.Select(PrincipalPermissionAttributeValue, (PrincipalPermissionAttributeValueLambda) => PrincipalPermissionAttributeValueLambda.CreatePermission());
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Security.Permissions.PrincipalPermissionAttribute> PrincipalPermissionAttributeValue)
        {
            return Observable.Select(PrincipalPermissionAttributeValue, (PrincipalPermissionAttributeValueLambda) => PrincipalPermissionAttributeValueLambda.Name);
        }


        public static IObservable<System.String> get_Role(this IObservable<System.Security.Permissions.PrincipalPermissionAttribute> PrincipalPermissionAttributeValue)
        {
            return Observable.Select(PrincipalPermissionAttributeValue, (PrincipalPermissionAttributeValueLambda) => PrincipalPermissionAttributeValueLambda.Role);
        }


        public static IObservable<System.Boolean> get_Authenticated(this IObservable<System.Security.Permissions.PrincipalPermissionAttribute> PrincipalPermissionAttributeValue)
        {
            return Observable.Select(PrincipalPermissionAttributeValue, (PrincipalPermissionAttributeValueLambda) => PrincipalPermissionAttributeValueLambda.Authenticated);
        }


        public static IObservable<System.Reactive.Unit> set_Name(this IObservable<System.Security.Permissions.PrincipalPermissionAttribute> PrincipalPermissionAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(PrincipalPermissionAttributeValue, value, (PrincipalPermissionAttributeValueLambda, valueLambda) => PrincipalPermissionAttributeValueLambda.Name = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Role(this IObservable<System.Security.Permissions.PrincipalPermissionAttribute> PrincipalPermissionAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(PrincipalPermissionAttributeValue, value, (PrincipalPermissionAttributeValueLambda, valueLambda) => PrincipalPermissionAttributeValueLambda.Role = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Authenticated(this IObservable<System.Security.Permissions.PrincipalPermissionAttribute> PrincipalPermissionAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(PrincipalPermissionAttributeValue, value, (PrincipalPermissionAttributeValueLambda, valueLambda) => PrincipalPermissionAttributeValueLambda.Authenticated = valueLambda);
        }

    }
}