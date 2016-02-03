using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Microsoft.Win32.SafeHandles
{
public static class _SafeHandleMinusOneIsInvalid
{
    
public static IObservable<System.Boolean> get_IsInvalid(this IObservable<Microsoft.Win32.SafeHandles.SafeHandleMinusOneIsInvalid> SafeHandleMinusOneIsInvalidValue)
{
    return Observable.Select(SafeHandleMinusOneIsInvalidValue, (SafeHandleMinusOneIsInvalidValueLambda) => SafeHandleMinusOneIsInvalidValueLambda.IsInvalid);
}

}
}