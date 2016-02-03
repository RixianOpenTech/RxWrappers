using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __IAppDomainSetup
    {
        
        public static IObservable<System.String> get_ApplicationBase(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue)
        {
            return Observable.Select(IAppDomainSetupValue, (IAppDomainSetupValueLambda) => IAppDomainSetupValueLambda.ApplicationBase);
        }


        public static IObservable<System.String> get_ApplicationName(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue)
        {
            return Observable.Select(IAppDomainSetupValue, (IAppDomainSetupValueLambda) => IAppDomainSetupValueLambda.ApplicationName);
        }


        public static IObservable<System.String> get_CachePath(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue)
        {
            return Observable.Select(IAppDomainSetupValue, (IAppDomainSetupValueLambda) => IAppDomainSetupValueLambda.CachePath);
        }


        public static IObservable<System.String> get_ConfigurationFile(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue)
        {
            return Observable.Select(IAppDomainSetupValue, (IAppDomainSetupValueLambda) => IAppDomainSetupValueLambda.ConfigurationFile);
        }


        public static IObservable<System.String> get_DynamicBase(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue)
        {
            return Observable.Select(IAppDomainSetupValue, (IAppDomainSetupValueLambda) => IAppDomainSetupValueLambda.DynamicBase);
        }


        public static IObservable<System.String> get_LicenseFile(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue)
        {
            return Observable.Select(IAppDomainSetupValue, (IAppDomainSetupValueLambda) => IAppDomainSetupValueLambda.LicenseFile);
        }


        public static IObservable<System.String> get_PrivateBinPath(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue)
        {
            return Observable.Select(IAppDomainSetupValue, (IAppDomainSetupValueLambda) => IAppDomainSetupValueLambda.PrivateBinPath);
        }


        public static IObservable<System.String> get_PrivateBinPathProbe(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue)
        {
            return Observable.Select(IAppDomainSetupValue, (IAppDomainSetupValueLambda) => IAppDomainSetupValueLambda.PrivateBinPathProbe);
        }


        public static IObservable<System.String> get_ShadowCopyDirectories(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue)
        {
            return Observable.Select(IAppDomainSetupValue, (IAppDomainSetupValueLambda) => IAppDomainSetupValueLambda.ShadowCopyDirectories);
        }


        public static IObservable<System.String> get_ShadowCopyFiles(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue)
        {
            return Observable.Select(IAppDomainSetupValue, (IAppDomainSetupValueLambda) => IAppDomainSetupValueLambda.ShadowCopyFiles);
        }


        public static IObservable<System.Reactive.Unit> set_ApplicationBase(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(IAppDomainSetupValue, value, (IAppDomainSetupValueLambda, valueLambda) => IAppDomainSetupValueLambda.ApplicationBase = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ApplicationName(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(IAppDomainSetupValue, value, (IAppDomainSetupValueLambda, valueLambda) => IAppDomainSetupValueLambda.ApplicationName = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_CachePath(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(IAppDomainSetupValue, value, (IAppDomainSetupValueLambda, valueLambda) => IAppDomainSetupValueLambda.CachePath = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ConfigurationFile(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(IAppDomainSetupValue, value, (IAppDomainSetupValueLambda, valueLambda) => IAppDomainSetupValueLambda.ConfigurationFile = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DynamicBase(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(IAppDomainSetupValue, value, (IAppDomainSetupValueLambda, valueLambda) => IAppDomainSetupValueLambda.DynamicBase = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_LicenseFile(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(IAppDomainSetupValue, value, (IAppDomainSetupValueLambda, valueLambda) => IAppDomainSetupValueLambda.LicenseFile = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PrivateBinPath(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(IAppDomainSetupValue, value, (IAppDomainSetupValueLambda, valueLambda) => IAppDomainSetupValueLambda.PrivateBinPath = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PrivateBinPathProbe(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(IAppDomainSetupValue, value, (IAppDomainSetupValueLambda, valueLambda) => IAppDomainSetupValueLambda.PrivateBinPathProbe = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ShadowCopyDirectories(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(IAppDomainSetupValue, value, (IAppDomainSetupValueLambda, valueLambda) => IAppDomainSetupValueLambda.ShadowCopyDirectories = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ShadowCopyFiles(this IObservable<System.IAppDomainSetup> IAppDomainSetupValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(IAppDomainSetupValue, value, (IAppDomainSetupValueLambda, valueLambda) => IAppDomainSetupValueLambda.ShadowCopyFiles = valueLambda);
        }

    }
}