using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.SymbolStore
{
    public static class __ISymbolBinder1
    {
        public static IObservable<System.Diagnostics.SymbolStore.ISymbolReader> GetReader(
            this IObservable<System.Diagnostics.SymbolStore.ISymbolBinder1> ISymbolBinder1Value,
            IObservable<System.IntPtr> importer, IObservable<System.String> filename,
            IObservable<System.String> searchPath)
        {
            return Observable.Zip(ISymbolBinder1Value, importer, filename, searchPath,
                (ISymbolBinder1ValueLambda, importerLambda, filenameLambda, searchPathLambda) =>
                    ISymbolBinder1ValueLambda.GetReader(importerLambda, filenameLambda, searchPathLambda));
        }
    }
}