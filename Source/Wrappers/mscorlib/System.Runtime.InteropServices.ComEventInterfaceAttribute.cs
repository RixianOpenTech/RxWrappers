using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _ComEventInterfaceAttribute
{
    
public static IObservable<System.Type> get_SourceInterface(this IObservable<System.Runtime.InteropServices.ComEventInterfaceAttribute> ComEventInterfaceAttributeValue)
{
    return Observable.Select(ComEventInterfaceAttributeValue, (ComEventInterfaceAttributeValueLambda) => ComEventInterfaceAttributeValueLambda.SourceInterface);
}


public static IObservable<System.Type> get_EventProvider(this IObservable<System.Runtime.InteropServices.ComEventInterfaceAttribute> ComEventInterfaceAttributeValue)
{
    return Observable.Select(ComEventInterfaceAttributeValue, (ComEventInterfaceAttributeValueLambda) => ComEventInterfaceAttributeValueLambda.EventProvider);
}

}
}