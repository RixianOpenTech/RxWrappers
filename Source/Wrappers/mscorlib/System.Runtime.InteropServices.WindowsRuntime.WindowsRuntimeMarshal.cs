using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.WindowsRuntime
{
public static class _WindowsRuntimeMarshal
{
    
public static IObservable<System.Reactive.Unit> AddEventHandler<T>(IObservable<Func<T, System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>> addMethod, IObservable<System.Action<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>> removeMethod, IObservable<T> handler)
{
    return ObservableExt.ZipExecute(addMethod, removeMethod, handler, (addMethodLambda, removeMethodLambda, handlerLambda) => System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal.AddEventHandler(addMethodLambda, removeMethodLambda, handlerLambda));
}


public static IObservable<System.Reactive.Unit> RemoveEventHandler<T>(IObservable<System.Action<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>> removeMethod, IObservable<T> handler)
{
    return ObservableExt.ZipExecute(removeMethod, handler, (removeMethodLambda, handlerLambda) => System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal.RemoveEventHandler(removeMethodLambda, handlerLambda));
}


public static IObservable<System.Reactive.Unit> RemoveAllEventHandlers(IObservable<System.Action<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>> removeMethod)
{
    return Observable.Do(removeMethod, (removeMethodLambda) => System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal.RemoveAllEventHandlers(removeMethodLambda)).ToUnit();
}


public static IObservable<System.Runtime.InteropServices.WindowsRuntime.IActivationFactory> GetActivationFactory(IObservable<System.Type> type)
{
    return Observable.Select(type, (typeLambda) => System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal.GetActivationFactory(typeLambda));
}


public static IObservable<System.IntPtr> StringToHString(IObservable<System.String> s)
{
    return Observable.Select(s, (sLambda) => System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal.StringToHString(sLambda));
}


public static IObservable<System.String> PtrToStringHString(IObservable<System.IntPtr> ptr)
{
    return Observable.Select(ptr, (ptrLambda) => System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal.PtrToStringHString(ptrLambda));
}


public static IObservable<System.Reactive.Unit> FreeHString(IObservable<System.IntPtr> ptr)
{
    return Observable.Do(ptr, (ptrLambda) => System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMarshal.FreeHString(ptrLambda)).ToUnit();
}

}
}