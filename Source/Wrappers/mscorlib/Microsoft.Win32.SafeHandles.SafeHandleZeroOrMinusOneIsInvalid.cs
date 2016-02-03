using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Microsoft.Win32.SafeHandles
{
public static class _SafeHandleZeroOrMinusOneIsInvalid
{
    
public static IObservable<System.Boolean> get_IsInvalid(this IObservable<Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid> SafeHandleZeroOrMinusOneIsInvalidValue)
{
    return Observable.Select(SafeHandleZeroOrMinusOneIsInvalidValue, (SafeHandleZeroOrMinusOneIsInvalidValueLambda) => SafeHandleZeroOrMinusOneIsInvalidValueLambda.IsInvalid);
}

}
}