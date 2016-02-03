using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _SafeHandle
{
    
public static IObservable<System.IntPtr> DangerousGetHandle(this IObservable<System.Runtime.InteropServices.SafeHandle> SafeHandleValue)
{
    return Observable.Select(SafeHandleValue, (SafeHandleValueLambda) => SafeHandleValueLambda.DangerousGetHandle());
}


public static IObservable<System.Reactive.Unit> Close(this IObservable<System.Runtime.InteropServices.SafeHandle> SafeHandleValue)
{
    return Observable.Do(SafeHandleValue, (SafeHandleValueLambda) => SafeHandleValueLambda.Close()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Runtime.InteropServices.SafeHandle> SafeHandleValue)
{
    return Observable.Do(SafeHandleValue, (SafeHandleValueLambda) => SafeHandleValueLambda.Dispose()).ToUnit();
}


public static IObservable<System.Reactive.Unit> SetHandleAsInvalid(this IObservable<System.Runtime.InteropServices.SafeHandle> SafeHandleValue)
{
    return Observable.Do(SafeHandleValue, (SafeHandleValueLambda) => SafeHandleValueLambda.SetHandleAsInvalid()).ToUnit();
}


public static IObservable<System.Boolean> DangerousAddRef(this IObservable<System.Runtime.InteropServices.SafeHandle> SafeHandleValue, IObservable<System.Boolean> success)
{
    return Observable.Zip(SafeHandleValue, success, (SafeHandleValueLambda, successLambda) => {
SafeHandleValueLambda.DangerousAddRef(ref successLambda);
return successLambda;
});
}


public static IObservable<System.Reactive.Unit> DangerousRelease(this IObservable<System.Runtime.InteropServices.SafeHandle> SafeHandleValue)
{
    return Observable.Do(SafeHandleValue, (SafeHandleValueLambda) => SafeHandleValueLambda.DangerousRelease()).ToUnit();
}


public static IObservable<System.Boolean> get_IsClosed(this IObservable<System.Runtime.InteropServices.SafeHandle> SafeHandleValue)
{
    return Observable.Select(SafeHandleValue, (SafeHandleValueLambda) => SafeHandleValueLambda.IsClosed);
}


public static IObservable<System.Boolean> get_IsInvalid(this IObservable<System.Runtime.InteropServices.SafeHandle> SafeHandleValue)
{
    return Observable.Select(SafeHandleValue, (SafeHandleValueLambda) => SafeHandleValueLambda.IsInvalid);
}

}
}