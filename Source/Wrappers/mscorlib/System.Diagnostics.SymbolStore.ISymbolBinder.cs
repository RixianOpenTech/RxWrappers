using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.SymbolStore
{
public static class _ISymbolBinder
{
    
public static IObservable<System.Diagnostics.SymbolStore.ISymbolReader> GetReader(this IObservable<System.Diagnostics.SymbolStore.ISymbolBinder> ISymbolBinderValue, IObservable<System.Int32> importer, IObservable<System.String> filename, IObservable<System.String> searchPath)
{
    return Observable.Zip(ISymbolBinderValue, importer, filename, searchPath, (ISymbolBinderValueLambda, importerLambda, filenameLambda, searchPathLambda) => ISymbolBinderValueLambda.GetReader(importerLambda, filenameLambda, searchPathLambda));
}

}
}