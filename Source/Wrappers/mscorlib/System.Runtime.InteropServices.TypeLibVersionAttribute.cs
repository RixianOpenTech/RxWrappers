using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _TypeLibVersionAttribute
{
    
public static IObservable<System.Int32> get_MajorVersion(this IObservable<System.Runtime.InteropServices.TypeLibVersionAttribute> TypeLibVersionAttributeValue)
{
    return Observable.Select(TypeLibVersionAttributeValue, (TypeLibVersionAttributeValueLambda) => TypeLibVersionAttributeValueLambda.MajorVersion);
}


public static IObservable<System.Int32> get_MinorVersion(this IObservable<System.Runtime.InteropServices.TypeLibVersionAttribute> TypeLibVersionAttributeValue)
{
    return Observable.Select(TypeLibVersionAttributeValue, (TypeLibVersionAttributeValueLambda) => TypeLibVersionAttributeValueLambda.MinorVersion);
}

}
}