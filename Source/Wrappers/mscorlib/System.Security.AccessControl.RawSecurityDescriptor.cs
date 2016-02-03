using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
public static class _RawSecurityDescriptor
{
    
public static IObservable<System.Reactive.Unit> SetFlags(this IObservable<System.Security.AccessControl.RawSecurityDescriptor> RawSecurityDescriptorValue, IObservable<System.Security.AccessControl.ControlFlags> flags)
{
    return ObservableExt.ZipExecute(RawSecurityDescriptorValue, flags, (RawSecurityDescriptorValueLambda, flagsLambda) => RawSecurityDescriptorValueLambda.SetFlags(flagsLambda));
}


public static IObservable<System.Security.AccessControl.ControlFlags> get_ControlFlags(this IObservable<System.Security.AccessControl.RawSecurityDescriptor> RawSecurityDescriptorValue)
{
    return Observable.Select(RawSecurityDescriptorValue, (RawSecurityDescriptorValueLambda) => RawSecurityDescriptorValueLambda.ControlFlags);
}


public static IObservable<System.Security.Principal.SecurityIdentifier> get_Owner(this IObservable<System.Security.AccessControl.RawSecurityDescriptor> RawSecurityDescriptorValue)
{
    return Observable.Select(RawSecurityDescriptorValue, (RawSecurityDescriptorValueLambda) => RawSecurityDescriptorValueLambda.Owner);
}


public static IObservable<System.Security.Principal.SecurityIdentifier> get_Group(this IObservable<System.Security.AccessControl.RawSecurityDescriptor> RawSecurityDescriptorValue)
{
    return Observable.Select(RawSecurityDescriptorValue, (RawSecurityDescriptorValueLambda) => RawSecurityDescriptorValueLambda.Group);
}


public static IObservable<System.Security.AccessControl.RawAcl> get_SystemAcl(this IObservable<System.Security.AccessControl.RawSecurityDescriptor> RawSecurityDescriptorValue)
{
    return Observable.Select(RawSecurityDescriptorValue, (RawSecurityDescriptorValueLambda) => RawSecurityDescriptorValueLambda.SystemAcl);
}


public static IObservable<System.Security.AccessControl.RawAcl> get_DiscretionaryAcl(this IObservable<System.Security.AccessControl.RawSecurityDescriptor> RawSecurityDescriptorValue)
{
    return Observable.Select(RawSecurityDescriptorValue, (RawSecurityDescriptorValueLambda) => RawSecurityDescriptorValueLambda.DiscretionaryAcl);
}


public static IObservable<System.Byte> get_ResourceManagerControl(this IObservable<System.Security.AccessControl.RawSecurityDescriptor> RawSecurityDescriptorValue)
{
    return Observable.Select(RawSecurityDescriptorValue, (RawSecurityDescriptorValueLambda) => RawSecurityDescriptorValueLambda.ResourceManagerControl);
}


public static IObservable<System.Reactive.Unit> set_Owner(this IObservable<System.Security.AccessControl.RawSecurityDescriptor> RawSecurityDescriptorValue, IObservable<System.Security.Principal.SecurityIdentifier> value)
{
    return ObservableExt.ZipExecute(RawSecurityDescriptorValue, value, (RawSecurityDescriptorValueLambda, valueLambda) => RawSecurityDescriptorValueLambda.Owner = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Group(this IObservable<System.Security.AccessControl.RawSecurityDescriptor> RawSecurityDescriptorValue, IObservable<System.Security.Principal.SecurityIdentifier> value)
{
    return ObservableExt.ZipExecute(RawSecurityDescriptorValue, value, (RawSecurityDescriptorValueLambda, valueLambda) => RawSecurityDescriptorValueLambda.Group = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_SystemAcl(this IObservable<System.Security.AccessControl.RawSecurityDescriptor> RawSecurityDescriptorValue, IObservable<System.Security.AccessControl.RawAcl> value)
{
    return ObservableExt.ZipExecute(RawSecurityDescriptorValue, value, (RawSecurityDescriptorValueLambda, valueLambda) => RawSecurityDescriptorValueLambda.SystemAcl = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_DiscretionaryAcl(this IObservable<System.Security.AccessControl.RawSecurityDescriptor> RawSecurityDescriptorValue, IObservable<System.Security.AccessControl.RawAcl> value)
{
    return ObservableExt.ZipExecute(RawSecurityDescriptorValue, value, (RawSecurityDescriptorValueLambda, valueLambda) => RawSecurityDescriptorValueLambda.DiscretionaryAcl = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ResourceManagerControl(this IObservable<System.Security.AccessControl.RawSecurityDescriptor> RawSecurityDescriptorValue, IObservable<System.Byte> value)
{
    return ObservableExt.ZipExecute(RawSecurityDescriptorValue, value, (RawSecurityDescriptorValueLambda, valueLambda) => RawSecurityDescriptorValueLambda.ResourceManagerControl = valueLambda);
}

}
}