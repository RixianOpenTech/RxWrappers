using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _UnmanagedFunctionPointerAttribute
{
    
public static IObservable<System.Runtime.InteropServices.CallingConvention> get_CallingConvention(this IObservable<System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute> UnmanagedFunctionPointerAttributeValue)
{
    return Observable.Select(UnmanagedFunctionPointerAttributeValue, (UnmanagedFunctionPointerAttributeValueLambda) => UnmanagedFunctionPointerAttributeValueLambda.CallingConvention);
}

}
}