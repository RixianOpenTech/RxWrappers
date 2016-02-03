using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.SymbolStore
{
public static class _ISymbolWriter
{
    
public static IObservable<System.Reactive.Unit> Initialize(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue, IObservable<System.IntPtr> emitter, IObservable<System.String> filename, IObservable<System.Boolean> fFullBuild)
{
    return ObservableExt.ZipExecute(ISymbolWriterValue, emitter, filename, fFullBuild, (ISymbolWriterValueLambda, emitterLambda, filenameLambda, fFullBuildLambda) => ISymbolWriterValueLambda.Initialize(emitterLambda, filenameLambda, fFullBuildLambda));
}


public static IObservable<System.Diagnostics.SymbolStore.ISymbolDocumentWriter> DefineDocument(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue, IObservable<System.String> url, IObservable<System.Guid> language, IObservable<System.Guid> languageVendor, IObservable<System.Guid> documentType)
{
    return Observable.Zip(ISymbolWriterValue, url, language, languageVendor, documentType, (ISymbolWriterValueLambda, urlLambda, languageLambda, languageVendorLambda, documentTypeLambda) => ISymbolWriterValueLambda.DefineDocument(urlLambda, languageLambda, languageVendorLambda, documentTypeLambda));
}


public static IObservable<System.Reactive.Unit> SetUserEntryPoint(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue, IObservable<System.Diagnostics.SymbolStore.SymbolToken> entryMethod)
{
    return ObservableExt.ZipExecute(ISymbolWriterValue, entryMethod, (ISymbolWriterValueLambda, entryMethodLambda) => ISymbolWriterValueLambda.SetUserEntryPoint(entryMethodLambda));
}


public static IObservable<System.Reactive.Unit> OpenMethod(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue, IObservable<System.Diagnostics.SymbolStore.SymbolToken> method)
{
    return ObservableExt.ZipExecute(ISymbolWriterValue, method, (ISymbolWriterValueLambda, methodLambda) => ISymbolWriterValueLambda.OpenMethod(methodLambda));
}


public static IObservable<System.Reactive.Unit> CloseMethod(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue)
{
    return Observable.Do(ISymbolWriterValue, (ISymbolWriterValueLambda) => ISymbolWriterValueLambda.CloseMethod()).ToUnit();
}


public static IObservable<System.Reactive.Unit> DefineSequencePoints(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue, IObservable<System.Diagnostics.SymbolStore.ISymbolDocumentWriter> document, IObservable<System.Int32[]> offsets, IObservable<System.Int32[]> lines, IObservable<System.Int32[]> columns, IObservable<System.Int32[]> endLines, IObservable<System.Int32[]> endColumns)
{
    return ObservableExt.ZipExecute(ISymbolWriterValue, document, offsets, lines, columns, endLines, endColumns, (ISymbolWriterValueLambda, documentLambda, offsetsLambda, linesLambda, columnsLambda, endLinesLambda, endColumnsLambda) => ISymbolWriterValueLambda.DefineSequencePoints(documentLambda, offsetsLambda, linesLambda, columnsLambda, endLinesLambda, endColumnsLambda));
}


public static IObservable<System.Int32> OpenScope(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue, IObservable<System.Int32> startOffset)
{
    return Observable.Zip(ISymbolWriterValue, startOffset, (ISymbolWriterValueLambda, startOffsetLambda) => ISymbolWriterValueLambda.OpenScope(startOffsetLambda));
}


public static IObservable<System.Reactive.Unit> CloseScope(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue, IObservable<System.Int32> endOffset)
{
    return ObservableExt.ZipExecute(ISymbolWriterValue, endOffset, (ISymbolWriterValueLambda, endOffsetLambda) => ISymbolWriterValueLambda.CloseScope(endOffsetLambda));
}


public static IObservable<System.Reactive.Unit> SetScopeRange(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue, IObservable<System.Int32> scopeID, IObservable<System.Int32> startOffset, IObservable<System.Int32> endOffset)
{
    return ObservableExt.ZipExecute(ISymbolWriterValue, scopeID, startOffset, endOffset, (ISymbolWriterValueLambda, scopeIDLambda, startOffsetLambda, endOffsetLambda) => ISymbolWriterValueLambda.SetScopeRange(scopeIDLambda, startOffsetLambda, endOffsetLambda));
}


public static IObservable<System.Reactive.Unit> DefineLocalVariable(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue, IObservable<System.String> name, IObservable<System.Reflection.FieldAttributes> attributes, IObservable<System.Byte[]> signature, IObservable<System.Diagnostics.SymbolStore.SymAddressKind> addrKind, IObservable<System.Int32> addr1, IObservable<System.Int32> addr2, IObservable<System.Int32> addr3, IObservable<System.Int32> startOffset, IObservable<System.Int32> endOffset)
{
    return ObservableExt.ZipExecute(ISymbolWriterValue, name, attributes, signature, addrKind, addr1, addr2, addr3, startOffset, endOffset, (ISymbolWriterValueLambda, nameLambda, attributesLambda, signatureLambda, addrKindLambda, addr1Lambda, addr2Lambda, addr3Lambda, startOffsetLambda, endOffsetLambda) => ISymbolWriterValueLambda.DefineLocalVariable(nameLambda, attributesLambda, signatureLambda, addrKindLambda, addr1Lambda, addr2Lambda, addr3Lambda, startOffsetLambda, endOffsetLambda));
}


public static IObservable<System.Reactive.Unit> DefineParameter(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue, IObservable<System.String> name, IObservable<System.Reflection.ParameterAttributes> attributes, IObservable<System.Int32> sequence, IObservable<System.Diagnostics.SymbolStore.SymAddressKind> addrKind, IObservable<System.Int32> addr1, IObservable<System.Int32> addr2, IObservable<System.Int32> addr3)
{
    return ObservableExt.ZipExecute(ISymbolWriterValue, name, attributes, sequence, addrKind, addr1, addr2, addr3, (ISymbolWriterValueLambda, nameLambda, attributesLambda, sequenceLambda, addrKindLambda, addr1Lambda, addr2Lambda, addr3Lambda) => ISymbolWriterValueLambda.DefineParameter(nameLambda, attributesLambda, sequenceLambda, addrKindLambda, addr1Lambda, addr2Lambda, addr3Lambda));
}


public static IObservable<System.Reactive.Unit> DefineField(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue, IObservable<System.Diagnostics.SymbolStore.SymbolToken> parent, IObservable<System.String> name, IObservable<System.Reflection.FieldAttributes> attributes, IObservable<System.Byte[]> signature, IObservable<System.Diagnostics.SymbolStore.SymAddressKind> addrKind, IObservable<System.Int32> addr1, IObservable<System.Int32> addr2, IObservable<System.Int32> addr3)
{
    return ObservableExt.ZipExecute(ISymbolWriterValue, parent, name, attributes, signature, addrKind, addr1, addr2, addr3, (ISymbolWriterValueLambda, parentLambda, nameLambda, attributesLambda, signatureLambda, addrKindLambda, addr1Lambda, addr2Lambda, addr3Lambda) => ISymbolWriterValueLambda.DefineField(parentLambda, nameLambda, attributesLambda, signatureLambda, addrKindLambda, addr1Lambda, addr2Lambda, addr3Lambda));
}


public static IObservable<System.Reactive.Unit> DefineGlobalVariable(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue, IObservable<System.String> name, IObservable<System.Reflection.FieldAttributes> attributes, IObservable<System.Byte[]> signature, IObservable<System.Diagnostics.SymbolStore.SymAddressKind> addrKind, IObservable<System.Int32> addr1, IObservable<System.Int32> addr2, IObservable<System.Int32> addr3)
{
    return ObservableExt.ZipExecute(ISymbolWriterValue, name, attributes, signature, addrKind, addr1, addr2, addr3, (ISymbolWriterValueLambda, nameLambda, attributesLambda, signatureLambda, addrKindLambda, addr1Lambda, addr2Lambda, addr3Lambda) => ISymbolWriterValueLambda.DefineGlobalVariable(nameLambda, attributesLambda, signatureLambda, addrKindLambda, addr1Lambda, addr2Lambda, addr3Lambda));
}


public static IObservable<System.Reactive.Unit> Close(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue)
{
    return Observable.Do(ISymbolWriterValue, (ISymbolWriterValueLambda) => ISymbolWriterValueLambda.Close()).ToUnit();
}


public static IObservable<System.Reactive.Unit> SetSymAttribute(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue, IObservable<System.Diagnostics.SymbolStore.SymbolToken> parent, IObservable<System.String> name, IObservable<System.Byte[]> data)
{
    return ObservableExt.ZipExecute(ISymbolWriterValue, parent, name, data, (ISymbolWriterValueLambda, parentLambda, nameLambda, dataLambda) => ISymbolWriterValueLambda.SetSymAttribute(parentLambda, nameLambda, dataLambda));
}


public static IObservable<System.Reactive.Unit> OpenNamespace(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue, IObservable<System.String> name)
{
    return ObservableExt.ZipExecute(ISymbolWriterValue, name, (ISymbolWriterValueLambda, nameLambda) => ISymbolWriterValueLambda.OpenNamespace(nameLambda));
}


public static IObservable<System.Reactive.Unit> CloseNamespace(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue)
{
    return Observable.Do(ISymbolWriterValue, (ISymbolWriterValueLambda) => ISymbolWriterValueLambda.CloseNamespace()).ToUnit();
}


public static IObservable<System.Reactive.Unit> UsingNamespace(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue, IObservable<System.String> fullName)
{
    return ObservableExt.ZipExecute(ISymbolWriterValue, fullName, (ISymbolWriterValueLambda, fullNameLambda) => ISymbolWriterValueLambda.UsingNamespace(fullNameLambda));
}


public static IObservable<System.Reactive.Unit> SetMethodSourceRange(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue, IObservable<System.Diagnostics.SymbolStore.ISymbolDocumentWriter> startDoc, IObservable<System.Int32> startLine, IObservable<System.Int32> startColumn, IObservable<System.Diagnostics.SymbolStore.ISymbolDocumentWriter> endDoc, IObservable<System.Int32> endLine, IObservable<System.Int32> endColumn)
{
    return ObservableExt.ZipExecute(ISymbolWriterValue, startDoc, startLine, startColumn, endDoc, endLine, endColumn, (ISymbolWriterValueLambda, startDocLambda, startLineLambda, startColumnLambda, endDocLambda, endLineLambda, endColumnLambda) => ISymbolWriterValueLambda.SetMethodSourceRange(startDocLambda, startLineLambda, startColumnLambda, endDocLambda, endLineLambda, endColumnLambda));
}


public static IObservable<System.Reactive.Unit> SetUnderlyingWriter(this IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> ISymbolWriterValue, IObservable<System.IntPtr> underlyingWriter)
{
    return ObservableExt.ZipExecute(ISymbolWriterValue, underlyingWriter, (ISymbolWriterValueLambda, underlyingWriterLambda) => ISymbolWriterValueLambda.SetUnderlyingWriter(underlyingWriterLambda));
}

}
}