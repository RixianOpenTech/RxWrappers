using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _AppDomainManager
{
    
public static IObservable<System.AppDomain> CreateDomain(this IObservable<System.AppDomainManager> AppDomainManagerValue, IObservable<System.String> friendlyName, IObservable<System.Security.Policy.Evidence> securityInfo, IObservable<System.AppDomainSetup> appDomainInfo)
{
    return Observable.Zip(AppDomainManagerValue, friendlyName, securityInfo, appDomainInfo, (AppDomainManagerValueLambda, friendlyNameLambda, securityInfoLambda, appDomainInfoLambda) => AppDomainManagerValueLambda.CreateDomain(friendlyNameLambda, securityInfoLambda, appDomainInfoLambda));
}


public static IObservable<System.Reactive.Unit> InitializeNewDomain(this IObservable<System.AppDomainManager> AppDomainManagerValue, IObservable<System.AppDomainSetup> appDomainInfo)
{
    return ObservableExt.ZipExecute(AppDomainManagerValue, appDomainInfo, (AppDomainManagerValueLambda, appDomainInfoLambda) => AppDomainManagerValueLambda.InitializeNewDomain(appDomainInfoLambda));
}


public static IObservable<System.Boolean> CheckSecuritySettings(this IObservable<System.AppDomainManager> AppDomainManagerValue, IObservable<System.Security.SecurityState> state)
{
    return Observable.Zip(AppDomainManagerValue, state, (AppDomainManagerValueLambda, stateLambda) => AppDomainManagerValueLambda.CheckSecuritySettings(stateLambda));
}


public static IObservable<System.AppDomainManagerInitializationOptions> get_InitializationFlags(this IObservable<System.AppDomainManager> AppDomainManagerValue)
{
    return Observable.Select(AppDomainManagerValue, (AppDomainManagerValueLambda) => AppDomainManagerValueLambda.InitializationFlags);
}


public static IObservable<System.Runtime.Hosting.ApplicationActivator> get_ApplicationActivator(this IObservable<System.AppDomainManager> AppDomainManagerValue)
{
    return Observable.Select(AppDomainManagerValue, (AppDomainManagerValueLambda) => AppDomainManagerValueLambda.ApplicationActivator);
}


public static IObservable<System.Security.HostSecurityManager> get_HostSecurityManager(this IObservable<System.AppDomainManager> AppDomainManagerValue)
{
    return Observable.Select(AppDomainManagerValue, (AppDomainManagerValueLambda) => AppDomainManagerValueLambda.HostSecurityManager);
}


public static IObservable<System.Threading.HostExecutionContextManager> get_HostExecutionContextManager(this IObservable<System.AppDomainManager> AppDomainManagerValue)
{
    return Observable.Select(AppDomainManagerValue, (AppDomainManagerValueLambda) => AppDomainManagerValueLambda.HostExecutionContextManager);
}


public static IObservable<System.Reflection.Assembly> get_EntryAssembly(this IObservable<System.AppDomainManager> AppDomainManagerValue)
{
    return Observable.Select(AppDomainManagerValue, (AppDomainManagerValueLambda) => AppDomainManagerValueLambda.EntryAssembly);
}


public static IObservable<System.Reactive.Unit> set_InitializationFlags(this IObservable<System.AppDomainManager> AppDomainManagerValue, IObservable<System.AppDomainManagerInitializationOptions> value)
{
    return ObservableExt.ZipExecute(AppDomainManagerValue, value, (AppDomainManagerValueLambda, valueLambda) => AppDomainManagerValueLambda.InitializationFlags = valueLambda);
}

}
}