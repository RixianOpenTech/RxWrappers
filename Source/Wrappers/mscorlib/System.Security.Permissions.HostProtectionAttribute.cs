using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __HostProtectionAttribute
    {
        public static IObservable<System.Security.IPermission> CreatePermission(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue)
        {
            return Observable.Select(HostProtectionAttributeValue,
                (HostProtectionAttributeValueLambda) => HostProtectionAttributeValueLambda.CreatePermission());
        }


        public static IObservable<System.Security.Permissions.HostProtectionResource> get_Resources(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue)
        {
            return Observable.Select(HostProtectionAttributeValue,
                (HostProtectionAttributeValueLambda) => HostProtectionAttributeValueLambda.Resources);
        }


        public static IObservable<System.Boolean> get_Synchronization(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue)
        {
            return Observable.Select(HostProtectionAttributeValue,
                (HostProtectionAttributeValueLambda) => HostProtectionAttributeValueLambda.Synchronization);
        }


        public static IObservable<System.Boolean> get_SharedState(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue)
        {
            return Observable.Select(HostProtectionAttributeValue,
                (HostProtectionAttributeValueLambda) => HostProtectionAttributeValueLambda.SharedState);
        }


        public static IObservable<System.Boolean> get_ExternalProcessMgmt(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue)
        {
            return Observable.Select(HostProtectionAttributeValue,
                (HostProtectionAttributeValueLambda) => HostProtectionAttributeValueLambda.ExternalProcessMgmt);
        }


        public static IObservable<System.Boolean> get_SelfAffectingProcessMgmt(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue)
        {
            return Observable.Select(HostProtectionAttributeValue,
                (HostProtectionAttributeValueLambda) => HostProtectionAttributeValueLambda.SelfAffectingProcessMgmt);
        }


        public static IObservable<System.Boolean> get_ExternalThreading(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue)
        {
            return Observable.Select(HostProtectionAttributeValue,
                (HostProtectionAttributeValueLambda) => HostProtectionAttributeValueLambda.ExternalThreading);
        }


        public static IObservable<System.Boolean> get_SelfAffectingThreading(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue)
        {
            return Observable.Select(HostProtectionAttributeValue,
                (HostProtectionAttributeValueLambda) => HostProtectionAttributeValueLambda.SelfAffectingThreading);
        }


        public static IObservable<System.Boolean> get_SecurityInfrastructure(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue)
        {
            return Observable.Select(HostProtectionAttributeValue,
                (HostProtectionAttributeValueLambda) => HostProtectionAttributeValueLambda.SecurityInfrastructure);
        }


        public static IObservable<System.Boolean> get_UI(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue)
        {
            return Observable.Select(HostProtectionAttributeValue,
                (HostProtectionAttributeValueLambda) => HostProtectionAttributeValueLambda.UI);
        }


        public static IObservable<System.Boolean> get_MayLeakOnAbort(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue)
        {
            return Observable.Select(HostProtectionAttributeValue,
                (HostProtectionAttributeValueLambda) => HostProtectionAttributeValueLambda.MayLeakOnAbort);
        }


        public static IObservable<System.Reactive.Unit> set_Resources(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue,
            IObservable<System.Security.Permissions.HostProtectionResource> value)
        {
            return ObservableExt.ZipExecute(HostProtectionAttributeValue, value,
                (HostProtectionAttributeValueLambda, valueLambda) =>
                    HostProtectionAttributeValueLambda.Resources = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Synchronization(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue,
            IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(HostProtectionAttributeValue, value,
                (HostProtectionAttributeValueLambda, valueLambda) =>
                    HostProtectionAttributeValueLambda.Synchronization = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_SharedState(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue,
            IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(HostProtectionAttributeValue, value,
                (HostProtectionAttributeValueLambda, valueLambda) =>
                    HostProtectionAttributeValueLambda.SharedState = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ExternalProcessMgmt(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue,
            IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(HostProtectionAttributeValue, value,
                (HostProtectionAttributeValueLambda, valueLambda) =>
                    HostProtectionAttributeValueLambda.ExternalProcessMgmt = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_SelfAffectingProcessMgmt(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue,
            IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(HostProtectionAttributeValue, value,
                (HostProtectionAttributeValueLambda, valueLambda) =>
                    HostProtectionAttributeValueLambda.SelfAffectingProcessMgmt = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ExternalThreading(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue,
            IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(HostProtectionAttributeValue, value,
                (HostProtectionAttributeValueLambda, valueLambda) =>
                    HostProtectionAttributeValueLambda.ExternalThreading = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_SelfAffectingThreading(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue,
            IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(HostProtectionAttributeValue, value,
                (HostProtectionAttributeValueLambda, valueLambda) =>
                    HostProtectionAttributeValueLambda.SelfAffectingThreading = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_SecurityInfrastructure(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue,
            IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(HostProtectionAttributeValue, value,
                (HostProtectionAttributeValueLambda, valueLambda) =>
                    HostProtectionAttributeValueLambda.SecurityInfrastructure = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_UI(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue,
            IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(HostProtectionAttributeValue, value,
                (HostProtectionAttributeValueLambda, valueLambda) => HostProtectionAttributeValueLambda.UI = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MayLeakOnAbort(
            this IObservable<System.Security.Permissions.HostProtectionAttribute> HostProtectionAttributeValue,
            IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(HostProtectionAttributeValue, value,
                (HostProtectionAttributeValueLambda, valueLambda) =>
                    HostProtectionAttributeValueLambda.MayLeakOnAbort = valueLambda);
        }
    }
}