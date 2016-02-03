using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting
{
    public static class __RemotingConfiguration
    {
        public static IObservable<System.Reactive.Unit> RegisterWellKnownServiceType(IObservable<System.Type> type,
            IObservable<System.String> objectUri, IObservable<System.Runtime.Remoting.WellKnownObjectMode> mode)
        {
            return ObservableExt.ZipExecute(type, objectUri, mode,
                (typeLambda, objectUriLambda, modeLambda) =>
                    System.Runtime.Remoting.RemotingConfiguration.RegisterWellKnownServiceType(typeLambda,
                        objectUriLambda, modeLambda));
        }


        public static IObservable<System.Reactive.Unit> RegisterWellKnownServiceType(
            IObservable<System.Runtime.Remoting.WellKnownServiceTypeEntry> entry)
        {
            return
                Observable.Do(entry,
                    (entryLambda) =>
                        System.Runtime.Remoting.RemotingConfiguration.RegisterWellKnownServiceType(entryLambda))
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Configure(IObservable<System.String> filename)
        {
            return
                Observable.Do(filename,
                    (filenameLambda) => System.Runtime.Remoting.RemotingConfiguration.Configure(filenameLambda))
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Configure(IObservable<System.String> filename,
            IObservable<System.Boolean> ensureSecurity)
        {
            return ObservableExt.ZipExecute(filename, ensureSecurity,
                (filenameLambda, ensureSecurityLambda) =>
                    System.Runtime.Remoting.RemotingConfiguration.Configure(filenameLambda, ensureSecurityLambda));
        }


        public static IObservable<System.Boolean> CustomErrorsEnabled(IObservable<System.Boolean> isLocalRequest)
        {
            return Observable.Select(isLocalRequest,
                (isLocalRequestLambda) =>
                    System.Runtime.Remoting.RemotingConfiguration.CustomErrorsEnabled(isLocalRequestLambda));
        }


        public static IObservable<System.Reactive.Unit> RegisterActivatedServiceType(IObservable<System.Type> type)
        {
            return
                Observable.Do(type,
                    (typeLambda) =>
                        System.Runtime.Remoting.RemotingConfiguration.RegisterActivatedServiceType(typeLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> RegisterActivatedServiceType(
            IObservable<System.Runtime.Remoting.ActivatedServiceTypeEntry> entry)
        {
            return
                Observable.Do(entry,
                    (entryLambda) =>
                        System.Runtime.Remoting.RemotingConfiguration.RegisterActivatedServiceType(entryLambda))
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> RegisterActivatedClientType(IObservable<System.Type> type,
            IObservable<System.String> appUrl)
        {
            return ObservableExt.ZipExecute(type, appUrl,
                (typeLambda, appUrlLambda) =>
                    System.Runtime.Remoting.RemotingConfiguration.RegisterActivatedClientType(typeLambda, appUrlLambda));
        }


        public static IObservable<System.Reactive.Unit> RegisterActivatedClientType(
            IObservable<System.Runtime.Remoting.ActivatedClientTypeEntry> entry)
        {
            return
                Observable.Do(entry,
                    (entryLambda) =>
                        System.Runtime.Remoting.RemotingConfiguration.RegisterActivatedClientType(entryLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> RegisterWellKnownClientType(IObservable<System.Type> type,
            IObservable<System.String> objectUrl)
        {
            return ObservableExt.ZipExecute(type, objectUrl,
                (typeLambda, objectUrlLambda) =>
                    System.Runtime.Remoting.RemotingConfiguration.RegisterWellKnownClientType(typeLambda,
                        objectUrlLambda));
        }


        public static IObservable<System.Reactive.Unit> RegisterWellKnownClientType(
            IObservable<System.Runtime.Remoting.WellKnownClientTypeEntry> entry)
        {
            return
                Observable.Do(entry,
                    (entryLambda) =>
                        System.Runtime.Remoting.RemotingConfiguration.RegisterWellKnownClientType(entryLambda)).ToUnit();
        }


        public static IObservable<System.Runtime.Remoting.ActivatedServiceTypeEntry[]>
            GetRegisteredActivatedServiceTypes()
        {
            return
                ObservableExt.Factory(
                    () => System.Runtime.Remoting.RemotingConfiguration.GetRegisteredActivatedServiceTypes());
        }


        public static IObservable<System.Runtime.Remoting.WellKnownServiceTypeEntry[]>
            GetRegisteredWellKnownServiceTypes()
        {
            return
                ObservableExt.Factory(
                    () => System.Runtime.Remoting.RemotingConfiguration.GetRegisteredWellKnownServiceTypes());
        }


        public static IObservable<System.Runtime.Remoting.ActivatedClientTypeEntry[]> GetRegisteredActivatedClientTypes()
        {
            return
                ObservableExt.Factory(
                    () => System.Runtime.Remoting.RemotingConfiguration.GetRegisteredActivatedClientTypes());
        }


        public static IObservable<System.Runtime.Remoting.WellKnownClientTypeEntry[]> GetRegisteredWellKnownClientTypes()
        {
            return
                ObservableExt.Factory(
                    () => System.Runtime.Remoting.RemotingConfiguration.GetRegisteredWellKnownClientTypes());
        }


        public static IObservable<System.Runtime.Remoting.ActivatedClientTypeEntry> IsRemotelyActivatedClientType(
            IObservable<System.Type> svrType)
        {
            return Observable.Select(svrType,
                (svrTypeLambda) =>
                    System.Runtime.Remoting.RemotingConfiguration.IsRemotelyActivatedClientType(svrTypeLambda));
        }


        public static IObservable<System.Runtime.Remoting.ActivatedClientTypeEntry> IsRemotelyActivatedClientType(
            IObservable<System.String> typeName, IObservable<System.String> assemblyName)
        {
            return Observable.Zip(typeName, assemblyName,
                (typeNameLambda, assemblyNameLambda) =>
                    System.Runtime.Remoting.RemotingConfiguration.IsRemotelyActivatedClientType(typeNameLambda,
                        assemblyNameLambda));
        }


        public static IObservable<System.Runtime.Remoting.WellKnownClientTypeEntry> IsWellKnownClientType(
            IObservable<System.Type> svrType)
        {
            return Observable.Select(svrType,
                (svrTypeLambda) => System.Runtime.Remoting.RemotingConfiguration.IsWellKnownClientType(svrTypeLambda));
        }


        public static IObservable<System.Runtime.Remoting.WellKnownClientTypeEntry> IsWellKnownClientType(
            IObservable<System.String> typeName, IObservable<System.String> assemblyName)
        {
            return Observable.Zip(typeName, assemblyName,
                (typeNameLambda, assemblyNameLambda) =>
                    System.Runtime.Remoting.RemotingConfiguration.IsWellKnownClientType(typeNameLambda,
                        assemblyNameLambda));
        }


        public static IObservable<System.Boolean> IsActivationAllowed(IObservable<System.Type> svrType)
        {
            return Observable.Select(svrType,
                (svrTypeLambda) => System.Runtime.Remoting.RemotingConfiguration.IsActivationAllowed(svrTypeLambda));
        }


        public static IObservable<System.String> get_ApplicationName()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.RemotingConfiguration.ApplicationName);
        }


        public static IObservable<System.String> get_ApplicationId()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.RemotingConfiguration.ApplicationId);
        }


        public static IObservable<System.String> get_ProcessId()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.RemotingConfiguration.ProcessId);
        }


        public static IObservable<System.Runtime.Remoting.CustomErrorsModes> get_CustomErrorsMode()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.RemotingConfiguration.CustomErrorsMode);
        }


        public static IObservable<System.Reactive.Unit> set_ApplicationName(IObservable<System.String> value)
        {
            return
                Observable.Do(value,
                    (valueLambda) => System.Runtime.Remoting.RemotingConfiguration.ApplicationName = valueLambda)
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_CustomErrorsMode(
            IObservable<System.Runtime.Remoting.CustomErrorsModes> value)
        {
            return
                Observable.Do(value,
                    (valueLambda) => System.Runtime.Remoting.RemotingConfiguration.CustomErrorsMode = valueLambda)
                    .ToUnit();
        }
    }
}