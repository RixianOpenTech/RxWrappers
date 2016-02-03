using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
public static class _GenericSecurityDescriptor
{
    
public static IObservable<System.Reactive.Unit> GetBinaryForm(this IObservable<System.Security.AccessControl.GenericSecurityDescriptor> GenericSecurityDescriptorValue, IObservable<System.Byte[]> binaryForm, IObservable<System.Int32> offset)
{
    return ObservableExt.ZipExecute(GenericSecurityDescriptorValue, binaryForm, offset, (GenericSecurityDescriptorValueLambda, binaryFormLambda, offsetLambda) => GenericSecurityDescriptorValueLambda.GetBinaryForm(binaryFormLambda, offsetLambda));
}


public static IObservable<System.Boolean> IsSddlConversionSupported()
{
    return ObservableExt.Factory(() => System.Security.AccessControl.GenericSecurityDescriptor.IsSddlConversionSupported());
}


public static IObservable<System.String> GetSddlForm(this IObservable<System.Security.AccessControl.GenericSecurityDescriptor> GenericSecurityDescriptorValue, IObservable<System.Security.AccessControl.AccessControlSections> includeSections)
{
    return Observable.Zip(GenericSecurityDescriptorValue, includeSections, (GenericSecurityDescriptorValueLambda, includeSectionsLambda) => GenericSecurityDescriptorValueLambda.GetSddlForm(includeSectionsLambda));
}


public static IObservable<System.Byte> get_Revision()
{
    return ObservableExt.Factory(() => System.Security.AccessControl.GenericSecurityDescriptor.Revision);
}


public static IObservable<System.Security.AccessControl.ControlFlags> get_ControlFlags(this IObservable<System.Security.AccessControl.GenericSecurityDescriptor> GenericSecurityDescriptorValue)
{
    return Observable.Select(GenericSecurityDescriptorValue, (GenericSecurityDescriptorValueLambda) => GenericSecurityDescriptorValueLambda.ControlFlags);
}


public static IObservable<System.Security.Principal.SecurityIdentifier> get_Owner(this IObservable<System.Security.AccessControl.GenericSecurityDescriptor> GenericSecurityDescriptorValue)
{
    return Observable.Select(GenericSecurityDescriptorValue, (GenericSecurityDescriptorValueLambda) => GenericSecurityDescriptorValueLambda.Owner);
}


public static IObservable<System.Security.Principal.SecurityIdentifier> get_Group(this IObservable<System.Security.AccessControl.GenericSecurityDescriptor> GenericSecurityDescriptorValue)
{
    return Observable.Select(GenericSecurityDescriptorValue, (GenericSecurityDescriptorValueLambda) => GenericSecurityDescriptorValueLambda.Group);
}


public static IObservable<System.Int32> get_BinaryLength(this IObservable<System.Security.AccessControl.GenericSecurityDescriptor> GenericSecurityDescriptorValue)
{
    return Observable.Select(GenericSecurityDescriptorValue, (GenericSecurityDescriptorValueLambda) => GenericSecurityDescriptorValueLambda.BinaryLength);
}


public static IObservable<System.Reactive.Unit> set_Owner(this IObservable<System.Security.AccessControl.GenericSecurityDescriptor> GenericSecurityDescriptorValue, IObservable<System.Security.Principal.SecurityIdentifier> value)
{
    return ObservableExt.ZipExecute(GenericSecurityDescriptorValue, value, (GenericSecurityDescriptorValueLambda, valueLambda) => GenericSecurityDescriptorValueLambda.Owner = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Group(this IObservable<System.Security.AccessControl.GenericSecurityDescriptor> GenericSecurityDescriptorValue, IObservable<System.Security.Principal.SecurityIdentifier> value)
{
    return ObservableExt.ZipExecute(GenericSecurityDescriptorValue, value, (GenericSecurityDescriptorValueLambda, valueLambda) => GenericSecurityDescriptorValueLambda.Group = valueLambda);
}

}
}