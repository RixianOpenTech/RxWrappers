using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Principal
{
public static class _WindowsImpersonationContext
{
    
public static IObservable<System.Reactive.Unit> Undo(this IObservable<System.Security.Principal.WindowsImpersonationContext> WindowsImpersonationContextValue)
{
    return Observable.Do(WindowsImpersonationContextValue, (WindowsImpersonationContextValueLambda) => WindowsImpersonationContextValueLambda.Undo()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Security.Principal.WindowsImpersonationContext> WindowsImpersonationContextValue)
{
    return Observable.Do(WindowsImpersonationContextValue, (WindowsImpersonationContextValueLambda) => WindowsImpersonationContextValueLambda.Dispose()).ToUnit();
}

}
}