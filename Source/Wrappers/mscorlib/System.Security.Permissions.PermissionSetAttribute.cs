using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __PermissionSetAttribute
    {
        
        public static IObservable<System.Security.IPermission> CreatePermission(this IObservable<System.Security.Permissions.PermissionSetAttribute> PermissionSetAttributeValue)
        {
            return Observable.Select(PermissionSetAttributeValue, (PermissionSetAttributeValueLambda) => PermissionSetAttributeValueLambda.CreatePermission());
        }


        public static IObservable<System.Security.PermissionSet> CreatePermissionSet(this IObservable<System.Security.Permissions.PermissionSetAttribute> PermissionSetAttributeValue)
        {
            return Observable.Select(PermissionSetAttributeValue, (PermissionSetAttributeValueLambda) => PermissionSetAttributeValueLambda.CreatePermissionSet());
        }


        public static IObservable<System.String> get_File(this IObservable<System.Security.Permissions.PermissionSetAttribute> PermissionSetAttributeValue)
        {
            return Observable.Select(PermissionSetAttributeValue, (PermissionSetAttributeValueLambda) => PermissionSetAttributeValueLambda.File);
        }


        public static IObservable<System.Boolean> get_UnicodeEncoded(this IObservable<System.Security.Permissions.PermissionSetAttribute> PermissionSetAttributeValue)
        {
            return Observable.Select(PermissionSetAttributeValue, (PermissionSetAttributeValueLambda) => PermissionSetAttributeValueLambda.UnicodeEncoded);
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Security.Permissions.PermissionSetAttribute> PermissionSetAttributeValue)
        {
            return Observable.Select(PermissionSetAttributeValue, (PermissionSetAttributeValueLambda) => PermissionSetAttributeValueLambda.Name);
        }


        public static IObservable<System.String> get_XML(this IObservable<System.Security.Permissions.PermissionSetAttribute> PermissionSetAttributeValue)
        {
            return Observable.Select(PermissionSetAttributeValue, (PermissionSetAttributeValueLambda) => PermissionSetAttributeValueLambda.XML);
        }


        public static IObservable<System.String> get_Hex(this IObservable<System.Security.Permissions.PermissionSetAttribute> PermissionSetAttributeValue)
        {
            return Observable.Select(PermissionSetAttributeValue, (PermissionSetAttributeValueLambda) => PermissionSetAttributeValueLambda.Hex);
        }


        public static IObservable<System.Reactive.Unit> set_File(this IObservable<System.Security.Permissions.PermissionSetAttribute> PermissionSetAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(PermissionSetAttributeValue, value, (PermissionSetAttributeValueLambda, valueLambda) => PermissionSetAttributeValueLambda.File = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_UnicodeEncoded(this IObservable<System.Security.Permissions.PermissionSetAttribute> PermissionSetAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(PermissionSetAttributeValue, value, (PermissionSetAttributeValueLambda, valueLambda) => PermissionSetAttributeValueLambda.UnicodeEncoded = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Name(this IObservable<System.Security.Permissions.PermissionSetAttribute> PermissionSetAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(PermissionSetAttributeValue, value, (PermissionSetAttributeValueLambda, valueLambda) => PermissionSetAttributeValueLambda.Name = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_XML(this IObservable<System.Security.Permissions.PermissionSetAttribute> PermissionSetAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(PermissionSetAttributeValue, value, (PermissionSetAttributeValueLambda, valueLambda) => PermissionSetAttributeValueLambda.XML = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Hex(this IObservable<System.Security.Permissions.PermissionSetAttribute> PermissionSetAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(PermissionSetAttributeValue, value, (PermissionSetAttributeValueLambda, valueLambda) => PermissionSetAttributeValueLambda.Hex = valueLambda);
        }

    }
}