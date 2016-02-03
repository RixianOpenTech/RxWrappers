using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.SymbolStore
{
    public static class __ISymbolDocumentWriter
    {
        public static IObservable<System.Reactive.Unit> SetSource(
            this IObservable<System.Diagnostics.SymbolStore.ISymbolDocumentWriter> ISymbolDocumentWriterValue,
            IObservable<System.Byte[]> source)
        {
            return ObservableExt.ZipExecute(ISymbolDocumentWriterValue, source,
                (ISymbolDocumentWriterValueLambda, sourceLambda) =>
                    ISymbolDocumentWriterValueLambda.SetSource(sourceLambda));
        }


        public static IObservable<System.Reactive.Unit> SetCheckSum(
            this IObservable<System.Diagnostics.SymbolStore.ISymbolDocumentWriter> ISymbolDocumentWriterValue,
            IObservable<System.Guid> algorithmId, IObservable<System.Byte[]> checkSum)
        {
            return ObservableExt.ZipExecute(ISymbolDocumentWriterValue, algorithmId, checkSum,
                (ISymbolDocumentWriterValueLambda, algorithmIdLambda, checkSumLambda) =>
                    ISymbolDocumentWriterValueLambda.SetCheckSum(algorithmIdLambda, checkSumLambda));
        }
    }
}