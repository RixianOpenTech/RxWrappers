using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _AppDomainSetup
{
    
public static IObservable<System.Byte[]> GetConfigurationBytes(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.GetConfigurationBytes());
}


public static IObservable<System.Reactive.Unit> SetConfigurationBytes(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.Byte[]> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.SetConfigurationBytes(valueLambda));
}


public static IObservable<System.Reactive.Unit> SetCompatibilitySwitches(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.Collections.Generic.IEnumerable<System.String>> switches)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, switches, (AppDomainSetupValueLambda, switchesLambda) => AppDomainSetupValueLambda.SetCompatibilitySwitches(switchesLambda));
}


public static IObservable<System.Reactive.Unit> SetNativeFunction(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.String> functionName, IObservable<System.Int32> functionVersion, IObservable<System.IntPtr> functionPointer)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, functionName, functionVersion, functionPointer, (AppDomainSetupValueLambda, functionNameLambda, functionVersionLambda, functionPointerLambda) => AppDomainSetupValueLambda.SetNativeFunction(functionNameLambda, functionVersionLambda, functionPointerLambda));
}


public static IObservable<System.String> get_AppDomainManagerAssembly(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.AppDomainManagerAssembly);
}


public static IObservable<System.String> get_AppDomainManagerType(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.AppDomainManagerType);
}


public static IObservable<System.String[]> get_PartialTrustVisibleAssemblies(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.PartialTrustVisibleAssemblies);
}


public static IObservable<System.String> get_ApplicationBase(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.ApplicationBase);
}


public static IObservable<System.String> get_ConfigurationFile(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.ConfigurationFile);
}


public static IObservable<System.String> get_TargetFrameworkName(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.TargetFrameworkName);
}


public static IObservable<System.String> get_DynamicBase(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.DynamicBase);
}


public static IObservable<System.Boolean> get_DisallowPublisherPolicy(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.DisallowPublisherPolicy);
}


public static IObservable<System.Boolean> get_DisallowBindingRedirects(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.DisallowBindingRedirects);
}


public static IObservable<System.Boolean> get_DisallowCodeDownload(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.DisallowCodeDownload);
}


public static IObservable<System.Boolean> get_DisallowApplicationBaseProbing(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.DisallowApplicationBaseProbing);
}


public static IObservable<System.String> get_ApplicationName(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.ApplicationName);
}


public static IObservable<System.AppDomainInitializer> get_AppDomainInitializer(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.AppDomainInitializer);
}


public static IObservable<System.String[]> get_AppDomainInitializerArguments(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.AppDomainInitializerArguments);
}


public static IObservable<System.Runtime.Hosting.ActivationArguments> get_ActivationArguments(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.ActivationArguments);
}


public static IObservable<System.Security.Policy.ApplicationTrust> get_ApplicationTrust(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.ApplicationTrust);
}


public static IObservable<System.String> get_PrivateBinPath(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.PrivateBinPath);
}


public static IObservable<System.String> get_PrivateBinPathProbe(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.PrivateBinPathProbe);
}


public static IObservable<System.String> get_ShadowCopyDirectories(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.ShadowCopyDirectories);
}


public static IObservable<System.String> get_ShadowCopyFiles(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.ShadowCopyFiles);
}


public static IObservable<System.String> get_CachePath(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.CachePath);
}


public static IObservable<System.String> get_LicenseFile(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.LicenseFile);
}


public static IObservable<System.LoaderOptimization> get_LoaderOptimization(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.LoaderOptimization);
}


public static IObservable<System.Boolean> get_SandboxInterop(this IObservable<System.AppDomainSetup> AppDomainSetupValue)
{
    return Observable.Select(AppDomainSetupValue, (AppDomainSetupValueLambda) => AppDomainSetupValueLambda.SandboxInterop);
}


public static IObservable<System.Reactive.Unit> set_AppDomainManagerAssembly(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.AppDomainManagerAssembly = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_AppDomainManagerType(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.AppDomainManagerType = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_PartialTrustVisibleAssemblies(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.String[]> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.PartialTrustVisibleAssemblies = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ApplicationBase(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.ApplicationBase = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ConfigurationFile(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.ConfigurationFile = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_TargetFrameworkName(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.TargetFrameworkName = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_DynamicBase(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.DynamicBase = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_DisallowPublisherPolicy(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.DisallowPublisherPolicy = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_DisallowBindingRedirects(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.DisallowBindingRedirects = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_DisallowCodeDownload(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.DisallowCodeDownload = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_DisallowApplicationBaseProbing(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.DisallowApplicationBaseProbing = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ApplicationName(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.ApplicationName = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_AppDomainInitializer(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.AppDomainInitializer> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.AppDomainInitializer = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_AppDomainInitializerArguments(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.String[]> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.AppDomainInitializerArguments = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ActivationArguments(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.Runtime.Hosting.ActivationArguments> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.ActivationArguments = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ApplicationTrust(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.Security.Policy.ApplicationTrust> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.ApplicationTrust = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_PrivateBinPath(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.PrivateBinPath = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_PrivateBinPathProbe(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.PrivateBinPathProbe = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ShadowCopyDirectories(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.ShadowCopyDirectories = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ShadowCopyFiles(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.ShadowCopyFiles = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_CachePath(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.CachePath = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_LicenseFile(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.LicenseFile = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_LoaderOptimization(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.LoaderOptimization> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.LoaderOptimization = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_SandboxInterop(this IObservable<System.AppDomainSetup> AppDomainSetupValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(AppDomainSetupValue, value, (AppDomainSetupValueLambda, valueLambda) => AppDomainSetupValueLambda.SandboxInterop = valueLambda);
}

}
}