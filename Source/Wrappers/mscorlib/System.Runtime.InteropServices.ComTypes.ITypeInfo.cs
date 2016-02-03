using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.ComTypes
{
public static class _ITypeInfo
{
    
public static IObservable<System.IntPtr> GetTypeAttr(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> ITypeInfoValue)
{
    return Observable.Select(ITypeInfoValue, (ITypeInfoValueLambda) => {
System.IntPtr ppTypeAttrOutput = default(System.IntPtr);
ITypeInfoValueLambda.GetTypeAttr(out ppTypeAttrOutput);
return ppTypeAttrOutput;
});
}


public static IObservable<System.Runtime.InteropServices.ComTypes.ITypeComp> GetTypeComp(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> ITypeInfoValue)
{
    return Observable.Select(ITypeInfoValue, (ITypeInfoValueLambda) => {
System.Runtime.InteropServices.ComTypes.ITypeComp ppTCompOutput = default(System.Runtime.InteropServices.ComTypes.ITypeComp);
ITypeInfoValueLambda.GetTypeComp(out ppTCompOutput);
return ppTCompOutput;
});
}


public static IObservable<System.IntPtr> GetFuncDesc(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> ITypeInfoValue, IObservable<System.Int32> index)
{
    return Observable.Zip(ITypeInfoValue, index, (ITypeInfoValueLambda, indexLambda) => {
System.IntPtr ppFuncDescOutput = default(System.IntPtr);
ITypeInfoValueLambda.GetFuncDesc(indexLambda, out ppFuncDescOutput);
return ppFuncDescOutput;
});
}


public static IObservable<System.IntPtr> GetVarDesc(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> ITypeInfoValue, IObservable<System.Int32> index)
{
    return Observable.Zip(ITypeInfoValue, index, (ITypeInfoValueLambda, indexLambda) => {
System.IntPtr ppVarDescOutput = default(System.IntPtr);
ITypeInfoValueLambda.GetVarDesc(indexLambda, out ppVarDescOutput);
return ppVarDescOutput;
});
}


public static IObservable<Tuple<System.String, System.Int32>> GetNames(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> ITypeInfoValue, IObservable<System.Int32> memid, IObservable<System.String[]> rgBstrNames, IObservable<System.Int32> cMaxNames)
{
    return Observable.Zip(ITypeInfoValue, memid, rgBstrNames, cMaxNames, (ITypeInfoValueLambda, memidLambda, rgBstrNamesLambda, cMaxNamesLambda) => {
System.Int32 pcNamesOutput = default(System.Int32);
ITypeInfoValueLambda.GetNames(memidLambda, rgBstrNamesLambda, cMaxNamesLambda, out pcNamesOutput);
return pcNamesOutput;
});
}


public static IObservable<System.Int32> GetRefTypeOfImplType(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> ITypeInfoValue, IObservable<System.Int32> index)
{
    return Observable.Zip(ITypeInfoValue, index, (ITypeInfoValueLambda, indexLambda) => {
System.Int32 hrefOutput = default(System.Int32);
ITypeInfoValueLambda.GetRefTypeOfImplType(indexLambda, out hrefOutput);
return hrefOutput;
});
}


public static IObservable<System.Runtime.InteropServices.ComTypes.IMPLTYPEFLAGS> GetImplTypeFlags(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> ITypeInfoValue, IObservable<System.Int32> index)
{
    return Observable.Zip(ITypeInfoValue, index, (ITypeInfoValueLambda, indexLambda) => {
System.Runtime.InteropServices.ComTypes.IMPLTYPEFLAGS pImplTypeFlagsOutput = default(System.Runtime.InteropServices.ComTypes.IMPLTYPEFLAGS);
ITypeInfoValueLambda.GetImplTypeFlags(indexLambda, out pImplTypeFlagsOutput);
return pImplTypeFlagsOutput;
});
}


public static IObservable<System.Int32> GetIDsOfNames(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> ITypeInfoValue, IObservable<System.String[]> rgszNames, IObservable<System.Int32> cNames, IObservable<System.Int32[]> pMemId)
{
    return Observable.Zip(ITypeInfoValue, rgszNames, cNames, pMemId, (ITypeInfoValueLambda, rgszNamesLambda, cNamesLambda, pMemIdLambda) => ITypeInfoValueLambda.GetIDsOfNames(rgszNamesLambda, cNamesLambda, pMemIdLambda));
}


public static IObservable<Tuple<System.Runtime.InteropServices.ComTypes.DISPPARAMS, System.Int32>> Invoke(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> ITypeInfoValue, IObservable<System.Object> pvInstance, IObservable<System.Int32> memid, IObservable<System.Int16> wFlags, IObservable<System.Runtime.InteropServices.ComTypes.DISPPARAMS> pDispParams, IObservable<System.IntPtr> pVarResult, IObservable<System.IntPtr> pExcepInfo)
{
    return Observable.Zip(ITypeInfoValue, pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfo, (ITypeInfoValueLambda, pvInstanceLambda, memidLambda, wFlagsLambda, pDispParamsLambda, pVarResultLambda, pExcepInfoLambda) => {
System.Int32 puArgErrOutput = default(System.Int32);
ITypeInfoValueLambda.Invoke(pvInstanceLambda, memidLambda, wFlagsLambda, ref pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, out puArgErrOutput);
return Tuple.Create(pDispParamsLambda, puArgErrOutput);
});
}


public static IObservable<Tuple<System.String, System.String, System.Int32, System.String>> GetDocumentation(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> ITypeInfoValue, IObservable<System.Int32> index)
{
    return Observable.Zip(ITypeInfoValue, index, (ITypeInfoValueLambda, indexLambda) => {
System.String strNameOutput = default(System.String);
System.String strDocStringOutput = default(System.String);
System.Int32 dwHelpContextOutput = default(System.Int32);
System.String strHelpFileOutput = default(System.String);
ITypeInfoValueLambda.GetDocumentation(indexLambda, out strNameOutput, out strDocStringOutput, out dwHelpContextOutput, out strHelpFileOutput);
return Tuple.Create(strNameOutput, strDocStringOutput, dwHelpContextOutput, strHelpFileOutput);
});
}


public static IObservable<System.Reactive.Unit> GetDllEntry(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> ITypeInfoValue, IObservable<System.Int32> memid, IObservable<System.Runtime.InteropServices.ComTypes.INVOKEKIND> invKind, IObservable<System.IntPtr> pBstrDllName, IObservable<System.IntPtr> pBstrName, IObservable<System.IntPtr> pwOrdinal)
{
    return ObservableExt.ZipExecute(ITypeInfoValue, memid, invKind, pBstrDllName, pBstrName, pwOrdinal, (ITypeInfoValueLambda, memidLambda, invKindLambda, pBstrDllNameLambda, pBstrNameLambda, pwOrdinalLambda) => ITypeInfoValueLambda.GetDllEntry(memidLambda, invKindLambda, pBstrDllNameLambda, pBstrNameLambda, pwOrdinalLambda));
}


public static IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> GetRefTypeInfo(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> ITypeInfoValue, IObservable<System.Int32> hRef)
{
    return Observable.Zip(ITypeInfoValue, hRef, (ITypeInfoValueLambda, hRefLambda) => {
System.Runtime.InteropServices.ComTypes.ITypeInfo ppTIOutput = default(System.Runtime.InteropServices.ComTypes.ITypeInfo);
ITypeInfoValueLambda.GetRefTypeInfo(hRefLambda, out ppTIOutput);
return ppTIOutput;
});
}


public static IObservable<System.IntPtr> AddressOfMember(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> ITypeInfoValue, IObservable<System.Int32> memid, IObservable<System.Runtime.InteropServices.ComTypes.INVOKEKIND> invKind)
{
    return Observable.Zip(ITypeInfoValue, memid, invKind, (ITypeInfoValueLambda, memidLambda, invKindLambda) => {
System.IntPtr ppvOutput = default(System.IntPtr);
ITypeInfoValueLambda.AddressOfMember(memidLambda, invKindLambda, out ppvOutput);
return ppvOutput;
});
}


public static IObservable<Tuple<System.Guid, System.Object>> CreateInstance(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> ITypeInfoValue, IObservable<System.Object> pUnkOuter, IObservable<System.Guid> riid)
{
    return Observable.Zip(ITypeInfoValue, pUnkOuter, riid, (ITypeInfoValueLambda, pUnkOuterLambda, riidLambda) => {
System.Object ppvObjOutput = default(System.Object);
ITypeInfoValueLambda.CreateInstance(pUnkOuterLambda, ref riidLambda, out ppvObjOutput);
return Tuple.Create(riidLambda, ppvObjOutput);
});
}


public static IObservable<System.String> GetMops(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> ITypeInfoValue, IObservable<System.Int32> memid)
{
    return Observable.Zip(ITypeInfoValue, memid, (ITypeInfoValueLambda, memidLambda) => {
System.String pBstrMopsOutput = default(System.String);
ITypeInfoValueLambda.GetMops(memidLambda, out pBstrMopsOutput);
return pBstrMopsOutput;
});
}


public static IObservable<Tuple<System.Runtime.InteropServices.ComTypes.ITypeLib, System.Int32>> GetContainingTypeLib(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> ITypeInfoValue)
{
    return Observable.Select(ITypeInfoValue, (ITypeInfoValueLambda) => {
System.Runtime.InteropServices.ComTypes.ITypeLib ppTLBOutput = default(System.Runtime.InteropServices.ComTypes.ITypeLib);
System.Int32 pIndexOutput = default(System.Int32);
ITypeInfoValueLambda.GetContainingTypeLib(out ppTLBOutput, out pIndexOutput);
return Tuple.Create(ppTLBOutput, pIndexOutput);
});
}


public static IObservable<System.Reactive.Unit> ReleaseTypeAttr(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> ITypeInfoValue, IObservable<System.IntPtr> pTypeAttr)
{
    return ObservableExt.ZipExecute(ITypeInfoValue, pTypeAttr, (ITypeInfoValueLambda, pTypeAttrLambda) => ITypeInfoValueLambda.ReleaseTypeAttr(pTypeAttrLambda));
}


public static IObservable<System.Reactive.Unit> ReleaseFuncDesc(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> ITypeInfoValue, IObservable<System.IntPtr> pFuncDesc)
{
    return ObservableExt.ZipExecute(ITypeInfoValue, pFuncDesc, (ITypeInfoValueLambda, pFuncDescLambda) => ITypeInfoValueLambda.ReleaseFuncDesc(pFuncDescLambda));
}


public static IObservable<System.Reactive.Unit> ReleaseVarDesc(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> ITypeInfoValue, IObservable<System.IntPtr> pVarDesc)
{
    return ObservableExt.ZipExecute(ITypeInfoValue, pVarDesc, (ITypeInfoValueLambda, pVarDescLambda) => ITypeInfoValueLambda.ReleaseVarDesc(pVarDescLambda));
}

}
}