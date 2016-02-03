using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.SymbolStore
{
    public static class __ISymbolDocument
    {
        
        public static IObservable<System.Byte[]> GetCheckSum(this IObservable<System.Diagnostics.SymbolStore.ISymbolDocument> ISymbolDocumentValue)
        {
            return Observable.Select(ISymbolDocumentValue, (ISymbolDocumentValueLambda) => ISymbolDocumentValueLambda.GetCheckSum());
        }


        public static IObservable<System.Int32> FindClosestLine(this IObservable<System.Diagnostics.SymbolStore.ISymbolDocument> ISymbolDocumentValue, IObservable<System.Int32> line)
        {
            return Observable.Zip(ISymbolDocumentValue, line, (ISymbolDocumentValueLambda, lineLambda) => ISymbolDocumentValueLambda.FindClosestLine(lineLambda));
        }


        public static IObservable<System.Byte[]> GetSourceRange(this IObservable<System.Diagnostics.SymbolStore.ISymbolDocument> ISymbolDocumentValue, IObservable<System.Int32> startLine, IObservable<System.Int32> startColumn, IObservable<System.Int32> endLine, IObservable<System.Int32> endColumn)
        {
            return Observable.Zip(ISymbolDocumentValue, startLine, startColumn, endLine, endColumn, (ISymbolDocumentValueLambda, startLineLambda, startColumnLambda, endLineLambda, endColumnLambda) => ISymbolDocumentValueLambda.GetSourceRange(startLineLambda, startColumnLambda, endLineLambda, endColumnLambda));
        }


        public static IObservable<System.String> get_URL(this IObservable<System.Diagnostics.SymbolStore.ISymbolDocument> ISymbolDocumentValue)
        {
            return Observable.Select(ISymbolDocumentValue, (ISymbolDocumentValueLambda) => ISymbolDocumentValueLambda.URL);
        }


        public static IObservable<System.Guid> get_DocumentType(this IObservable<System.Diagnostics.SymbolStore.ISymbolDocument> ISymbolDocumentValue)
        {
            return Observable.Select(ISymbolDocumentValue, (ISymbolDocumentValueLambda) => ISymbolDocumentValueLambda.DocumentType);
        }


        public static IObservable<System.Guid> get_Language(this IObservable<System.Diagnostics.SymbolStore.ISymbolDocument> ISymbolDocumentValue)
        {
            return Observable.Select(ISymbolDocumentValue, (ISymbolDocumentValueLambda) => ISymbolDocumentValueLambda.Language);
        }


        public static IObservable<System.Guid> get_LanguageVendor(this IObservable<System.Diagnostics.SymbolStore.ISymbolDocument> ISymbolDocumentValue)
        {
            return Observable.Select(ISymbolDocumentValue, (ISymbolDocumentValueLambda) => ISymbolDocumentValueLambda.LanguageVendor);
        }


        public static IObservable<System.Guid> get_CheckSumAlgorithmId(this IObservable<System.Diagnostics.SymbolStore.ISymbolDocument> ISymbolDocumentValue)
        {
            return Observable.Select(ISymbolDocumentValue, (ISymbolDocumentValueLambda) => ISymbolDocumentValueLambda.CheckSumAlgorithmId);
        }


        public static IObservable<System.Boolean> get_HasEmbeddedSource(this IObservable<System.Diagnostics.SymbolStore.ISymbolDocument> ISymbolDocumentValue)
        {
            return Observable.Select(ISymbolDocumentValue, (ISymbolDocumentValueLambda) => ISymbolDocumentValueLambda.HasEmbeddedSource);
        }


        public static IObservable<System.Int32> get_SourceLength(this IObservable<System.Diagnostics.SymbolStore.ISymbolDocument> ISymbolDocumentValue)
        {
            return Observable.Select(ISymbolDocumentValue, (ISymbolDocumentValueLambda) => ISymbolDocumentValueLambda.SourceLength);
        }

    }
}