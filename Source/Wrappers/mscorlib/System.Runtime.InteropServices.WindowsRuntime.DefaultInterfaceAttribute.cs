using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.WindowsRuntime
{
public static class _DefaultInterfaceAttribute
{
    
public static IObservable<System.Type> get_DefaultInterface(this IObservable<System.Runtime.InteropServices.WindowsRuntime.DefaultInterfaceAttribute> DefaultInterfaceAttributeValue)
{
    return Observable.Select(DefaultInterfaceAttributeValue, (DefaultInterfaceAttributeValueLambda) => DefaultInterfaceAttributeValueLambda.DefaultInterface);
}

}
}