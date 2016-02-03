using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.WindowsRuntime
{
public static class _InterfaceImplementedInVersionAttribute
{
    
public static IObservable<System.Type> get_InterfaceType(this IObservable<System.Runtime.InteropServices.WindowsRuntime.InterfaceImplementedInVersionAttribute> InterfaceImplementedInVersionAttributeValue)
{
    return Observable.Select(InterfaceImplementedInVersionAttributeValue, (InterfaceImplementedInVersionAttributeValueLambda) => InterfaceImplementedInVersionAttributeValueLambda.InterfaceType);
}


public static IObservable<System.Byte> get_MajorVersion(this IObservable<System.Runtime.InteropServices.WindowsRuntime.InterfaceImplementedInVersionAttribute> InterfaceImplementedInVersionAttributeValue)
{
    return Observable.Select(InterfaceImplementedInVersionAttributeValue, (InterfaceImplementedInVersionAttributeValueLambda) => InterfaceImplementedInVersionAttributeValueLambda.MajorVersion);
}


public static IObservable<System.Byte> get_MinorVersion(this IObservable<System.Runtime.InteropServices.WindowsRuntime.InterfaceImplementedInVersionAttribute> InterfaceImplementedInVersionAttributeValue)
{
    return Observable.Select(InterfaceImplementedInVersionAttributeValue, (InterfaceImplementedInVersionAttributeValueLambda) => InterfaceImplementedInVersionAttributeValueLambda.MinorVersion);
}


public static IObservable<System.Byte> get_BuildVersion(this IObservable<System.Runtime.InteropServices.WindowsRuntime.InterfaceImplementedInVersionAttribute> InterfaceImplementedInVersionAttributeValue)
{
    return Observable.Select(InterfaceImplementedInVersionAttributeValue, (InterfaceImplementedInVersionAttributeValueLambda) => InterfaceImplementedInVersionAttributeValueLambda.BuildVersion);
}


public static IObservable<System.Byte> get_RevisionVersion(this IObservable<System.Runtime.InteropServices.WindowsRuntime.InterfaceImplementedInVersionAttribute> InterfaceImplementedInVersionAttributeValue)
{
    return Observable.Select(InterfaceImplementedInVersionAttributeValue, (InterfaceImplementedInVersionAttributeValueLambda) => InterfaceImplementedInVersionAttributeValueLambda.RevisionVersion);
}

}
}