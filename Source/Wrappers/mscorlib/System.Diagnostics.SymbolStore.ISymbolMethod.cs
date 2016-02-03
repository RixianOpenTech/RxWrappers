using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.SymbolStore
{
    public static class __ISymbolMethod
    {
        public static IObservable<System.Reactive.Unit> GetSequencePoints(
            this IObservable<System.Diagnostics.SymbolStore.ISymbolMethod> ISymbolMethodValue,
            IObservable<System.Int32[]> offsets, IObservable<System.Diagnostics.SymbolStore.ISymbolDocument[]> documents,
            IObservable<System.Int32[]> lines, IObservable<System.Int32[]> columns, IObservable<System.Int32[]> endLines,
            IObservable<System.Int32[]> endColumns)
        {
            return ObservableExt.ZipExecute(ISymbolMethodValue, offsets, documents, lines, columns, endLines, endColumns,
                (ISymbolMethodValueLambda, offsetsLambda, documentsLambda, linesLambda, columnsLambda, endLinesLambda,
                    endColumnsLambda) =>
                    ISymbolMethodValueLambda.GetSequencePoints(offsetsLambda, documentsLambda, linesLambda,
                        columnsLambda, endLinesLambda, endColumnsLambda));
        }


        public static IObservable<System.Diagnostics.SymbolStore.ISymbolScope> GetScope(
            this IObservable<System.Diagnostics.SymbolStore.ISymbolMethod> ISymbolMethodValue,
            IObservable<System.Int32> offset)
        {
            return Observable.Zip(ISymbolMethodValue, offset,
                (ISymbolMethodValueLambda, offsetLambda) => ISymbolMethodValueLambda.GetScope(offsetLambda));
        }


        public static IObservable<System.Int32> GetOffset(
            this IObservable<System.Diagnostics.SymbolStore.ISymbolMethod> ISymbolMethodValue,
            IObservable<System.Diagnostics.SymbolStore.ISymbolDocument> document, IObservable<System.Int32> line,
            IObservable<System.Int32> column)
        {
            return Observable.Zip(ISymbolMethodValue, document, line, column,
                (ISymbolMethodValueLambda, documentLambda, lineLambda, columnLambda) =>
                    ISymbolMethodValueLambda.GetOffset(documentLambda, lineLambda, columnLambda));
        }


        public static IObservable<System.Int32[]> GetRanges(
            this IObservable<System.Diagnostics.SymbolStore.ISymbolMethod> ISymbolMethodValue,
            IObservable<System.Diagnostics.SymbolStore.ISymbolDocument> document, IObservable<System.Int32> line,
            IObservable<System.Int32> column)
        {
            return Observable.Zip(ISymbolMethodValue, document, line, column,
                (ISymbolMethodValueLambda, documentLambda, lineLambda, columnLambda) =>
                    ISymbolMethodValueLambda.GetRanges(documentLambda, lineLambda, columnLambda));
        }


        public static IObservable<System.Diagnostics.SymbolStore.ISymbolVariable[]> GetParameters(
            this IObservable<System.Diagnostics.SymbolStore.ISymbolMethod> ISymbolMethodValue)
        {
            return Observable.Select(ISymbolMethodValue,
                (ISymbolMethodValueLambda) => ISymbolMethodValueLambda.GetParameters());
        }


        public static IObservable<System.Diagnostics.SymbolStore.ISymbolNamespace> GetNamespace(
            this IObservable<System.Diagnostics.SymbolStore.ISymbolMethod> ISymbolMethodValue)
        {
            return Observable.Select(ISymbolMethodValue,
                (ISymbolMethodValueLambda) => ISymbolMethodValueLambda.GetNamespace());
        }


        public static IObservable<System.Boolean> GetSourceStartEnd(
            this IObservable<System.Diagnostics.SymbolStore.ISymbolMethod> ISymbolMethodValue,
            IObservable<System.Diagnostics.SymbolStore.ISymbolDocument[]> docs, IObservable<System.Int32[]> lines,
            IObservable<System.Int32[]> columns)
        {
            return Observable.Zip(ISymbolMethodValue, docs, lines, columns,
                (ISymbolMethodValueLambda, docsLambda, linesLambda, columnsLambda) =>
                    ISymbolMethodValueLambda.GetSourceStartEnd(docsLambda, linesLambda, columnsLambda));
        }


        public static IObservable<System.Diagnostics.SymbolStore.SymbolToken> get_Token(
            this IObservable<System.Diagnostics.SymbolStore.ISymbolMethod> ISymbolMethodValue)
        {
            return Observable.Select(ISymbolMethodValue, (ISymbolMethodValueLambda) => ISymbolMethodValueLambda.Token);
        }


        public static IObservable<System.Int32> get_SequencePointCount(
            this IObservable<System.Diagnostics.SymbolStore.ISymbolMethod> ISymbolMethodValue)
        {
            return Observable.Select(ISymbolMethodValue,
                (ISymbolMethodValueLambda) => ISymbolMethodValueLambda.SequencePointCount);
        }


        public static IObservable<System.Diagnostics.SymbolStore.ISymbolScope> get_RootScope(
            this IObservable<System.Diagnostics.SymbolStore.ISymbolMethod> ISymbolMethodValue)
        {
            return Observable.Select(ISymbolMethodValue,
                (ISymbolMethodValueLambda) => ISymbolMethodValueLambda.RootScope);
        }
    }
}