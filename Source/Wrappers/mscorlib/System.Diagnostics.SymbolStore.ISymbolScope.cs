using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.SymbolStore
{
public static class _ISymbolScope
{
    
public static IObservable<System.Diagnostics.SymbolStore.ISymbolScope[]> GetChildren(this IObservable<System.Diagnostics.SymbolStore.ISymbolScope> ISymbolScopeValue)
{
    return Observable.Select(ISymbolScopeValue, (ISymbolScopeValueLambda) => ISymbolScopeValueLambda.GetChildren());
}


public static IObservable<System.Diagnostics.SymbolStore.ISymbolVariable[]> GetLocals(this IObservable<System.Diagnostics.SymbolStore.ISymbolScope> ISymbolScopeValue)
{
    return Observable.Select(ISymbolScopeValue, (ISymbolScopeValueLambda) => ISymbolScopeValueLambda.GetLocals());
}


public static IObservable<System.Diagnostics.SymbolStore.ISymbolNamespace[]> GetNamespaces(this IObservable<System.Diagnostics.SymbolStore.ISymbolScope> ISymbolScopeValue)
{
    return Observable.Select(ISymbolScopeValue, (ISymbolScopeValueLambda) => ISymbolScopeValueLambda.GetNamespaces());
}


public static IObservable<System.Diagnostics.SymbolStore.ISymbolMethod> get_Method(this IObservable<System.Diagnostics.SymbolStore.ISymbolScope> ISymbolScopeValue)
{
    return Observable.Select(ISymbolScopeValue, (ISymbolScopeValueLambda) => ISymbolScopeValueLambda.Method);
}


public static IObservable<System.Diagnostics.SymbolStore.ISymbolScope> get_Parent(this IObservable<System.Diagnostics.SymbolStore.ISymbolScope> ISymbolScopeValue)
{
    return Observable.Select(ISymbolScopeValue, (ISymbolScopeValueLambda) => ISymbolScopeValueLambda.Parent);
}


public static IObservable<System.Int32> get_StartOffset(this IObservable<System.Diagnostics.SymbolStore.ISymbolScope> ISymbolScopeValue)
{
    return Observable.Select(ISymbolScopeValue, (ISymbolScopeValueLambda) => ISymbolScopeValueLambda.StartOffset);
}


public static IObservable<System.Int32> get_EndOffset(this IObservable<System.Diagnostics.SymbolStore.ISymbolScope> ISymbolScopeValue)
{
    return Observable.Select(ISymbolScopeValue, (ISymbolScopeValueLambda) => ISymbolScopeValueLambda.EndOffset);
}

}
}