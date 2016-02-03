using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _PrimaryInteropAssemblyAttribute
{
    
public static IObservable<System.Int32> get_MajorVersion(this IObservable<System.Runtime.InteropServices.PrimaryInteropAssemblyAttribute> PrimaryInteropAssemblyAttributeValue)
{
    return Observable.Select(PrimaryInteropAssemblyAttributeValue, (PrimaryInteropAssemblyAttributeValueLambda) => PrimaryInteropAssemblyAttributeValueLambda.MajorVersion);
}


public static IObservable<System.Int32> get_MinorVersion(this IObservable<System.Runtime.InteropServices.PrimaryInteropAssemblyAttribute> PrimaryInteropAssemblyAttributeValue)
{
    return Observable.Select(PrimaryInteropAssemblyAttributeValue, (PrimaryInteropAssemblyAttributeValueLambda) => PrimaryInteropAssemblyAttributeValueLambda.MinorVersion);
}

}
}