using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _MarshalAsAttribute
{
    
public static IObservable<System.Runtime.InteropServices.UnmanagedType> get_Value(this IObservable<System.Runtime.InteropServices.MarshalAsAttribute> MarshalAsAttributeValue)
{
    return Observable.Select(MarshalAsAttributeValue, (MarshalAsAttributeValueLambda) => MarshalAsAttributeValueLambda.Value);
}

}
}