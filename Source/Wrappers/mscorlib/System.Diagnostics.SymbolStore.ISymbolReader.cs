using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.SymbolStore
{
public static class _ISymbolReader
{
    
public static IObservable<System.Diagnostics.SymbolStore.ISymbolDocument> GetDocument(this IObservable<System.Diagnostics.SymbolStore.ISymbolReader> ISymbolReaderValue, IObservable<System.String> url, IObservable<System.Guid> language, IObservable<System.Guid> languageVendor, IObservable<System.Guid> documentType)
{
    return Observable.Zip(ISymbolReaderValue, url, language, languageVendor, documentType, (ISymbolReaderValueLambda, urlLambda, languageLambda, languageVendorLambda, documentTypeLambda) => ISymbolReaderValueLambda.GetDocument(urlLambda, languageLambda, languageVendorLambda, documentTypeLambda));
}


public static IObservable<System.Diagnostics.SymbolStore.ISymbolDocument[]> GetDocuments(this IObservable<System.Diagnostics.SymbolStore.ISymbolReader> ISymbolReaderValue)
{
    return Observable.Select(ISymbolReaderValue, (ISymbolReaderValueLambda) => ISymbolReaderValueLambda.GetDocuments());
}


public static IObservable<System.Diagnostics.SymbolStore.ISymbolMethod> GetMethod(this IObservable<System.Diagnostics.SymbolStore.ISymbolReader> ISymbolReaderValue, IObservable<System.Diagnostics.SymbolStore.SymbolToken> method)
{
    return Observable.Zip(ISymbolReaderValue, method, (ISymbolReaderValueLambda, methodLambda) => ISymbolReaderValueLambda.GetMethod(methodLambda));
}


public static IObservable<System.Diagnostics.SymbolStore.ISymbolMethod> GetMethod(this IObservable<System.Diagnostics.SymbolStore.ISymbolReader> ISymbolReaderValue, IObservable<System.Diagnostics.SymbolStore.SymbolToken> method, IObservable<System.Int32> version)
{
    return Observable.Zip(ISymbolReaderValue, method, version, (ISymbolReaderValueLambda, methodLambda, versionLambda) => ISymbolReaderValueLambda.GetMethod(methodLambda, versionLambda));
}


public static IObservable<System.Diagnostics.SymbolStore.ISymbolVariable[]> GetVariables(this IObservable<System.Diagnostics.SymbolStore.ISymbolReader> ISymbolReaderValue, IObservable<System.Diagnostics.SymbolStore.SymbolToken> parent)
{
    return Observable.Zip(ISymbolReaderValue, parent, (ISymbolReaderValueLambda, parentLambda) => ISymbolReaderValueLambda.GetVariables(parentLambda));
}


public static IObservable<System.Diagnostics.SymbolStore.ISymbolVariable[]> GetGlobalVariables(this IObservable<System.Diagnostics.SymbolStore.ISymbolReader> ISymbolReaderValue)
{
    return Observable.Select(ISymbolReaderValue, (ISymbolReaderValueLambda) => ISymbolReaderValueLambda.GetGlobalVariables());
}


public static IObservable<System.Diagnostics.SymbolStore.ISymbolMethod> GetMethodFromDocumentPosition(this IObservable<System.Diagnostics.SymbolStore.ISymbolReader> ISymbolReaderValue, IObservable<System.Diagnostics.SymbolStore.ISymbolDocument> document, IObservable<System.Int32> line, IObservable<System.Int32> column)
{
    return Observable.Zip(ISymbolReaderValue, document, line, column, (ISymbolReaderValueLambda, documentLambda, lineLambda, columnLambda) => ISymbolReaderValueLambda.GetMethodFromDocumentPosition(documentLambda, lineLambda, columnLambda));
}


public static IObservable<System.Byte[]> GetSymAttribute(this IObservable<System.Diagnostics.SymbolStore.ISymbolReader> ISymbolReaderValue, IObservable<System.Diagnostics.SymbolStore.SymbolToken> parent, IObservable<System.String> name)
{
    return Observable.Zip(ISymbolReaderValue, parent, name, (ISymbolReaderValueLambda, parentLambda, nameLambda) => ISymbolReaderValueLambda.GetSymAttribute(parentLambda, nameLambda));
}


public static IObservable<System.Diagnostics.SymbolStore.ISymbolNamespace[]> GetNamespaces(this IObservable<System.Diagnostics.SymbolStore.ISymbolReader> ISymbolReaderValue)
{
    return Observable.Select(ISymbolReaderValue, (ISymbolReaderValueLambda) => ISymbolReaderValueLambda.GetNamespaces());
}


public static IObservable<System.Diagnostics.SymbolStore.SymbolToken> get_UserEntryPoint(this IObservable<System.Diagnostics.SymbolStore.ISymbolReader> ISymbolReaderValue)
{
    return Observable.Select(ISymbolReaderValue, (ISymbolReaderValueLambda) => ISymbolReaderValueLambda.UserEntryPoint);
}

}
}