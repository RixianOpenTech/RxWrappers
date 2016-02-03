using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __SecurityPermissionAttribute
    {
        
        public static IObservable<System.Security.IPermission> CreatePermission(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue)
        {
            return Observable.Select(SecurityPermissionAttributeValue, (SecurityPermissionAttributeValueLambda) => SecurityPermissionAttributeValueLambda.CreatePermission());
        }


        public static IObservable<System.Security.Permissions.SecurityPermissionFlag> get_Flags(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue)
        {
            return Observable.Select(SecurityPermissionAttributeValue, (SecurityPermissionAttributeValueLambda) => SecurityPermissionAttributeValueLambda.Flags);
        }


        public static IObservable<System.Boolean> get_Assertion(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue)
        {
            return Observable.Select(SecurityPermissionAttributeValue, (SecurityPermissionAttributeValueLambda) => SecurityPermissionAttributeValueLambda.Assertion);
        }


        public static IObservable<System.Boolean> get_UnmanagedCode(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue)
        {
            return Observable.Select(SecurityPermissionAttributeValue, (SecurityPermissionAttributeValueLambda) => SecurityPermissionAttributeValueLambda.UnmanagedCode);
        }


        public static IObservable<System.Boolean> get_SkipVerification(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue)
        {
            return Observable.Select(SecurityPermissionAttributeValue, (SecurityPermissionAttributeValueLambda) => SecurityPermissionAttributeValueLambda.SkipVerification);
        }


        public static IObservable<System.Boolean> get_Execution(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue)
        {
            return Observable.Select(SecurityPermissionAttributeValue, (SecurityPermissionAttributeValueLambda) => SecurityPermissionAttributeValueLambda.Execution);
        }


        public static IObservable<System.Boolean> get_ControlThread(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue)
        {
            return Observable.Select(SecurityPermissionAttributeValue, (SecurityPermissionAttributeValueLambda) => SecurityPermissionAttributeValueLambda.ControlThread);
        }


        public static IObservable<System.Boolean> get_ControlEvidence(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue)
        {
            return Observable.Select(SecurityPermissionAttributeValue, (SecurityPermissionAttributeValueLambda) => SecurityPermissionAttributeValueLambda.ControlEvidence);
        }


        public static IObservable<System.Boolean> get_ControlPolicy(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue)
        {
            return Observable.Select(SecurityPermissionAttributeValue, (SecurityPermissionAttributeValueLambda) => SecurityPermissionAttributeValueLambda.ControlPolicy);
        }


        public static IObservable<System.Boolean> get_SerializationFormatter(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue)
        {
            return Observable.Select(SecurityPermissionAttributeValue, (SecurityPermissionAttributeValueLambda) => SecurityPermissionAttributeValueLambda.SerializationFormatter);
        }


        public static IObservable<System.Boolean> get_ControlDomainPolicy(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue)
        {
            return Observable.Select(SecurityPermissionAttributeValue, (SecurityPermissionAttributeValueLambda) => SecurityPermissionAttributeValueLambda.ControlDomainPolicy);
        }


        public static IObservable<System.Boolean> get_ControlPrincipal(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue)
        {
            return Observable.Select(SecurityPermissionAttributeValue, (SecurityPermissionAttributeValueLambda) => SecurityPermissionAttributeValueLambda.ControlPrincipal);
        }


        public static IObservable<System.Boolean> get_ControlAppDomain(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue)
        {
            return Observable.Select(SecurityPermissionAttributeValue, (SecurityPermissionAttributeValueLambda) => SecurityPermissionAttributeValueLambda.ControlAppDomain);
        }


        public static IObservable<System.Boolean> get_RemotingConfiguration(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue)
        {
            return Observable.Select(SecurityPermissionAttributeValue, (SecurityPermissionAttributeValueLambda) => SecurityPermissionAttributeValueLambda.RemotingConfiguration);
        }


        public static IObservable<System.Boolean> get_Infrastructure(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue)
        {
            return Observable.Select(SecurityPermissionAttributeValue, (SecurityPermissionAttributeValueLambda) => SecurityPermissionAttributeValueLambda.Infrastructure);
        }


        public static IObservable<System.Boolean> get_BindingRedirects(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue)
        {
            return Observable.Select(SecurityPermissionAttributeValue, (SecurityPermissionAttributeValueLambda) => SecurityPermissionAttributeValueLambda.BindingRedirects);
        }


        public static IObservable<System.Reactive.Unit> set_Flags(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue, IObservable<System.Security.Permissions.SecurityPermissionFlag> value)
        {
            return ObservableExt.ZipExecute(SecurityPermissionAttributeValue, value, (SecurityPermissionAttributeValueLambda, valueLambda) => SecurityPermissionAttributeValueLambda.Flags = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Assertion(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(SecurityPermissionAttributeValue, value, (SecurityPermissionAttributeValueLambda, valueLambda) => SecurityPermissionAttributeValueLambda.Assertion = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_UnmanagedCode(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(SecurityPermissionAttributeValue, value, (SecurityPermissionAttributeValueLambda, valueLambda) => SecurityPermissionAttributeValueLambda.UnmanagedCode = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_SkipVerification(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(SecurityPermissionAttributeValue, value, (SecurityPermissionAttributeValueLambda, valueLambda) => SecurityPermissionAttributeValueLambda.SkipVerification = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Execution(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(SecurityPermissionAttributeValue, value, (SecurityPermissionAttributeValueLambda, valueLambda) => SecurityPermissionAttributeValueLambda.Execution = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ControlThread(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(SecurityPermissionAttributeValue, value, (SecurityPermissionAttributeValueLambda, valueLambda) => SecurityPermissionAttributeValueLambda.ControlThread = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ControlEvidence(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(SecurityPermissionAttributeValue, value, (SecurityPermissionAttributeValueLambda, valueLambda) => SecurityPermissionAttributeValueLambda.ControlEvidence = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ControlPolicy(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(SecurityPermissionAttributeValue, value, (SecurityPermissionAttributeValueLambda, valueLambda) => SecurityPermissionAttributeValueLambda.ControlPolicy = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_SerializationFormatter(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(SecurityPermissionAttributeValue, value, (SecurityPermissionAttributeValueLambda, valueLambda) => SecurityPermissionAttributeValueLambda.SerializationFormatter = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ControlDomainPolicy(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(SecurityPermissionAttributeValue, value, (SecurityPermissionAttributeValueLambda, valueLambda) => SecurityPermissionAttributeValueLambda.ControlDomainPolicy = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ControlPrincipal(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(SecurityPermissionAttributeValue, value, (SecurityPermissionAttributeValueLambda, valueLambda) => SecurityPermissionAttributeValueLambda.ControlPrincipal = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ControlAppDomain(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(SecurityPermissionAttributeValue, value, (SecurityPermissionAttributeValueLambda, valueLambda) => SecurityPermissionAttributeValueLambda.ControlAppDomain = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_RemotingConfiguration(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(SecurityPermissionAttributeValue, value, (SecurityPermissionAttributeValueLambda, valueLambda) => SecurityPermissionAttributeValueLambda.RemotingConfiguration = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Infrastructure(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(SecurityPermissionAttributeValue, value, (SecurityPermissionAttributeValueLambda, valueLambda) => SecurityPermissionAttributeValueLambda.Infrastructure = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_BindingRedirects(this IObservable<System.Security.Permissions.SecurityPermissionAttribute> SecurityPermissionAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(SecurityPermissionAttributeValue, value, (SecurityPermissionAttributeValueLambda, valueLambda) => SecurityPermissionAttributeValueLambda.BindingRedirects = valueLambda);
        }

    }
}