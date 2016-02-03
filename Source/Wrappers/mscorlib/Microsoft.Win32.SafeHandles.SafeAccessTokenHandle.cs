using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Microsoft.Win32.SafeHandles
{
public static class _SafeAccessTokenHandle
{
    
public static IObservable<Microsoft.Win32.SafeHandles.SafeAccessTokenHandle> get_InvalidHandle()
{
    return ObservableExt.Factory(() => Microsoft.Win32.SafeHandles.SafeAccessTokenHandle.InvalidHandle);
}


public static IObservable<System.Boolean> get_IsInvalid(this IObservable<Microsoft.Win32.SafeHandles.SafeAccessTokenHandle> SafeAccessTokenHandleValue)
{
    return Observable.Select(SafeAccessTokenHandleValue, (SafeAccessTokenHandleValueLambda) => SafeAccessTokenHandleValueLambda.IsInvalid);
}

}
}