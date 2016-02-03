using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.SymbolStore
{
public static class _ISymbolNamespace
{
    
public static IObservable<System.Diagnostics.SymbolStore.ISymbolNamespace[]> GetNamespaces(this IObservable<System.Diagnostics.SymbolStore.ISymbolNamespace> ISymbolNamespaceValue)
{
    return Observable.Select(ISymbolNamespaceValue, (ISymbolNamespaceValueLambda) => ISymbolNamespaceValueLambda.GetNamespaces());
}


public static IObservable<System.Diagnostics.SymbolStore.ISymbolVariable[]> GetVariables(this IObservable<System.Diagnostics.SymbolStore.ISymbolNamespace> ISymbolNamespaceValue)
{
    return Observable.Select(ISymbolNamespaceValue, (ISymbolNamespaceValueLambda) => ISymbolNamespaceValueLambda.GetVariables());
}


public static IObservable<System.String> get_Name(this IObservable<System.Diagnostics.SymbolStore.ISymbolNamespace> ISymbolNamespaceValue)
{
    return Observable.Select(ISymbolNamespaceValue, (ISymbolNamespaceValueLambda) => ISymbolNamespaceValueLambda.Name);
}

}
}