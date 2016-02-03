using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
    public static class __SecurityException
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Security.SecurityException> SecurityExceptionValue)
        {
            return Observable.Select(SecurityExceptionValue, (SecurityExceptionValueLambda) => SecurityExceptionValueLambda.ToString());
        }


        public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.Security.SecurityException> SecurityExceptionValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(SecurityExceptionValue, info, context, (SecurityExceptionValueLambda, infoLambda, contextLambda) => SecurityExceptionValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.Security.Permissions.SecurityAction> get_Action(this IObservable<System.Security.SecurityException> SecurityExceptionValue)
        {
            return Observable.Select(SecurityExceptionValue, (SecurityExceptionValueLambda) => SecurityExceptionValueLambda.Action);
        }


        public static IObservable<System.Type> get_PermissionType(this IObservable<System.Security.SecurityException> SecurityExceptionValue)
        {
            return Observable.Select(SecurityExceptionValue, (SecurityExceptionValueLambda) => SecurityExceptionValueLambda.PermissionType);
        }


        public static IObservable<System.Security.IPermission> get_FirstPermissionThatFailed(this IObservable<System.Security.SecurityException> SecurityExceptionValue)
        {
            return Observable.Select(SecurityExceptionValue, (SecurityExceptionValueLambda) => SecurityExceptionValueLambda.FirstPermissionThatFailed);
        }


        public static IObservable<System.String> get_PermissionState(this IObservable<System.Security.SecurityException> SecurityExceptionValue)
        {
            return Observable.Select(SecurityExceptionValue, (SecurityExceptionValueLambda) => SecurityExceptionValueLambda.PermissionState);
        }


        public static IObservable<System.Object> get_Demanded(this IObservable<System.Security.SecurityException> SecurityExceptionValue)
        {
            return Observable.Select(SecurityExceptionValue, (SecurityExceptionValueLambda) => SecurityExceptionValueLambda.Demanded);
        }


        public static IObservable<System.String> get_GrantedSet(this IObservable<System.Security.SecurityException> SecurityExceptionValue)
        {
            return Observable.Select(SecurityExceptionValue, (SecurityExceptionValueLambda) => SecurityExceptionValueLambda.GrantedSet);
        }


        public static IObservable<System.String> get_RefusedSet(this IObservable<System.Security.SecurityException> SecurityExceptionValue)
        {
            return Observable.Select(SecurityExceptionValue, (SecurityExceptionValueLambda) => SecurityExceptionValueLambda.RefusedSet);
        }


        public static IObservable<System.Object> get_DenySetInstance(this IObservable<System.Security.SecurityException> SecurityExceptionValue)
        {
            return Observable.Select(SecurityExceptionValue, (SecurityExceptionValueLambda) => SecurityExceptionValueLambda.DenySetInstance);
        }


        public static IObservable<System.Object> get_PermitOnlySetInstance(this IObservable<System.Security.SecurityException> SecurityExceptionValue)
        {
            return Observable.Select(SecurityExceptionValue, (SecurityExceptionValueLambda) => SecurityExceptionValueLambda.PermitOnlySetInstance);
        }


        public static IObservable<System.Reflection.AssemblyName> get_FailedAssemblyInfo(this IObservable<System.Security.SecurityException> SecurityExceptionValue)
        {
            return Observable.Select(SecurityExceptionValue, (SecurityExceptionValueLambda) => SecurityExceptionValueLambda.FailedAssemblyInfo);
        }


        public static IObservable<System.Reflection.MethodInfo> get_Method(this IObservable<System.Security.SecurityException> SecurityExceptionValue)
        {
            return Observable.Select(SecurityExceptionValue, (SecurityExceptionValueLambda) => SecurityExceptionValueLambda.Method);
        }


        public static IObservable<System.Security.SecurityZone> get_Zone(this IObservable<System.Security.SecurityException> SecurityExceptionValue)
        {
            return Observable.Select(SecurityExceptionValue, (SecurityExceptionValueLambda) => SecurityExceptionValueLambda.Zone);
        }


        public static IObservable<System.String> get_Url(this IObservable<System.Security.SecurityException> SecurityExceptionValue)
        {
            return Observable.Select(SecurityExceptionValue, (SecurityExceptionValueLambda) => SecurityExceptionValueLambda.Url);
        }


        public static IObservable<System.Reactive.Unit> set_Action(this IObservable<System.Security.SecurityException> SecurityExceptionValue, IObservable<System.Security.Permissions.SecurityAction> value)
        {
            return ObservableExt.ZipExecute(SecurityExceptionValue, value, (SecurityExceptionValueLambda, valueLambda) => SecurityExceptionValueLambda.Action = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PermissionType(this IObservable<System.Security.SecurityException> SecurityExceptionValue, IObservable<System.Type> value)
        {
            return ObservableExt.ZipExecute(SecurityExceptionValue, value, (SecurityExceptionValueLambda, valueLambda) => SecurityExceptionValueLambda.PermissionType = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_FirstPermissionThatFailed(this IObservable<System.Security.SecurityException> SecurityExceptionValue, IObservable<System.Security.IPermission> value)
        {
            return ObservableExt.ZipExecute(SecurityExceptionValue, value, (SecurityExceptionValueLambda, valueLambda) => SecurityExceptionValueLambda.FirstPermissionThatFailed = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PermissionState(this IObservable<System.Security.SecurityException> SecurityExceptionValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SecurityExceptionValue, value, (SecurityExceptionValueLambda, valueLambda) => SecurityExceptionValueLambda.PermissionState = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Demanded(this IObservable<System.Security.SecurityException> SecurityExceptionValue, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(SecurityExceptionValue, value, (SecurityExceptionValueLambda, valueLambda) => SecurityExceptionValueLambda.Demanded = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_GrantedSet(this IObservable<System.Security.SecurityException> SecurityExceptionValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SecurityExceptionValue, value, (SecurityExceptionValueLambda, valueLambda) => SecurityExceptionValueLambda.GrantedSet = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_RefusedSet(this IObservable<System.Security.SecurityException> SecurityExceptionValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SecurityExceptionValue, value, (SecurityExceptionValueLambda, valueLambda) => SecurityExceptionValueLambda.RefusedSet = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DenySetInstance(this IObservable<System.Security.SecurityException> SecurityExceptionValue, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(SecurityExceptionValue, value, (SecurityExceptionValueLambda, valueLambda) => SecurityExceptionValueLambda.DenySetInstance = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PermitOnlySetInstance(this IObservable<System.Security.SecurityException> SecurityExceptionValue, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(SecurityExceptionValue, value, (SecurityExceptionValueLambda, valueLambda) => SecurityExceptionValueLambda.PermitOnlySetInstance = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_FailedAssemblyInfo(this IObservable<System.Security.SecurityException> SecurityExceptionValue, IObservable<System.Reflection.AssemblyName> value)
        {
            return ObservableExt.ZipExecute(SecurityExceptionValue, value, (SecurityExceptionValueLambda, valueLambda) => SecurityExceptionValueLambda.FailedAssemblyInfo = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Method(this IObservable<System.Security.SecurityException> SecurityExceptionValue, IObservable<System.Reflection.MethodInfo> value)
        {
            return ObservableExt.ZipExecute(SecurityExceptionValue, value, (SecurityExceptionValueLambda, valueLambda) => SecurityExceptionValueLambda.Method = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Zone(this IObservable<System.Security.SecurityException> SecurityExceptionValue, IObservable<System.Security.SecurityZone> value)
        {
            return ObservableExt.ZipExecute(SecurityExceptionValue, value, (SecurityExceptionValueLambda, valueLambda) => SecurityExceptionValueLambda.Zone = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Url(this IObservable<System.Security.SecurityException> SecurityExceptionValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SecurityExceptionValue, value, (SecurityExceptionValueLambda, valueLambda) => SecurityExceptionValueLambda.Url = valueLambda);
        }

    }
}