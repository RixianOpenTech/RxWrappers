using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.ComTypes
{
    public static class __ITypeInfo2
    {
        public static IObservable<System.IntPtr> GetTypeAttr(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value)
        {
            return Observable.Select(ITypeInfo2Value, (ITypeInfo2ValueLambda) =>
            {
                System.IntPtr ppTypeAttrOutput = default(System.IntPtr);
                ITypeInfo2ValueLambda.GetTypeAttr(out ppTypeAttrOutput);
                return ppTypeAttrOutput;
            });
        }


        public static IObservable<System.Runtime.InteropServices.ComTypes.ITypeComp> GetTypeComp(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value)
        {
            return Observable.Select(ITypeInfo2Value, (ITypeInfo2ValueLambda) =>
            {
                System.Runtime.InteropServices.ComTypes.ITypeComp ppTCompOutput =
                    default(System.Runtime.InteropServices.ComTypes.ITypeComp);
                ITypeInfo2ValueLambda.GetTypeComp(out ppTCompOutput);
                return ppTCompOutput;
            });
        }


        public static IObservable<System.IntPtr> GetFuncDesc(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(ITypeInfo2Value, index, (ITypeInfo2ValueLambda, indexLambda) =>
            {
                System.IntPtr ppFuncDescOutput = default(System.IntPtr);
                ITypeInfo2ValueLambda.GetFuncDesc(indexLambda, out ppFuncDescOutput);
                return ppFuncDescOutput;
            });
        }


        public static IObservable<System.IntPtr> GetVarDesc(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(ITypeInfo2Value, index, (ITypeInfo2ValueLambda, indexLambda) =>
            {
                System.IntPtr ppVarDescOutput = default(System.IntPtr);
                ITypeInfo2ValueLambda.GetVarDesc(indexLambda, out ppVarDescOutput);
                return ppVarDescOutput;
            });
        }


        public static IObservable<int> GetNames(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> memid, IObservable<System.String[]> rgBstrNames,
            IObservable<System.Int32> cMaxNames)
        {
            return Observable.Zip(ITypeInfo2Value, memid, rgBstrNames, cMaxNames,
                (ITypeInfo2ValueLambda, memidLambda, rgBstrNamesLambda, cMaxNamesLambda) =>
                {
                    System.Int32 pcNamesOutput = default(System.Int32);
                    ITypeInfo2ValueLambda.GetNames(memidLambda, rgBstrNamesLambda, cMaxNamesLambda, out pcNamesOutput);
                    return pcNamesOutput;
                });
        }


        public static IObservable<System.Int32> GetRefTypeOfImplType(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(ITypeInfo2Value, index, (ITypeInfo2ValueLambda, indexLambda) =>
            {
                System.Int32 hrefOutput = default(System.Int32);
                ITypeInfo2ValueLambda.GetRefTypeOfImplType(indexLambda, out hrefOutput);
                return hrefOutput;
            });
        }


        public static IObservable<System.Runtime.InteropServices.ComTypes.IMPLTYPEFLAGS> GetImplTypeFlags(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(ITypeInfo2Value, index, (ITypeInfo2ValueLambda, indexLambda) =>
            {
                System.Runtime.InteropServices.ComTypes.IMPLTYPEFLAGS pImplTypeFlagsOutput =
                    default(System.Runtime.InteropServices.ComTypes.IMPLTYPEFLAGS);
                ITypeInfo2ValueLambda.GetImplTypeFlags(indexLambda, out pImplTypeFlagsOutput);
                return pImplTypeFlagsOutput;
            });
        }


        public static IObservable<Unit> GetIDsOfNames(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.String[]> rgszNames, IObservable<System.Int32> cNames, IObservable<System.Int32[]> pMemId)
        {
            return ObservableExt.ZipExecute(ITypeInfo2Value, rgszNames, cNames, pMemId,
                (ITypeInfo2ValueLambda, rgszNamesLambda, cNamesLambda, pMemIdLambda) =>
                    ITypeInfo2ValueLambda.GetIDsOfNames(rgszNamesLambda, cNamesLambda, pMemIdLambda));
        }


        public static IObservable<Tuple<System.Runtime.InteropServices.ComTypes.DISPPARAMS, System.Int32>> Invoke(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Object> pvInstance, IObservable<System.Int32> memid, IObservable<System.Int16> wFlags,
            IObservable<System.Runtime.InteropServices.ComTypes.DISPPARAMS> pDispParams,
            IObservable<System.IntPtr> pVarResult, IObservable<System.IntPtr> pExcepInfo)
        {
            return Observable.Zip(ITypeInfo2Value, pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfo,
                (ITypeInfo2ValueLambda, pvInstanceLambda, memidLambda, wFlagsLambda, pDispParamsLambda, pVarResultLambda,
                    pExcepInfoLambda) =>
                {
                    System.Int32 puArgErrOutput = default(System.Int32);
                    ITypeInfo2ValueLambda.Invoke(pvInstanceLambda, memidLambda, wFlagsLambda, ref pDispParamsLambda,
                        pVarResultLambda, pExcepInfoLambda, out puArgErrOutput);
                    return Tuple.Create(pDispParamsLambda, puArgErrOutput);
                });
        }


        public static IObservable<Tuple<System.String, System.String, System.Int32, System.String>> GetDocumentation(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(ITypeInfo2Value, index, (ITypeInfo2ValueLambda, indexLambda) =>
            {
                System.String strNameOutput = default(System.String);
                System.String strDocStringOutput = default(System.String);
                System.Int32 dwHelpContextOutput = default(System.Int32);
                System.String strHelpFileOutput = default(System.String);
                ITypeInfo2ValueLambda.GetDocumentation(indexLambda, out strNameOutput, out strDocStringOutput,
                    out dwHelpContextOutput, out strHelpFileOutput);
                return Tuple.Create(strNameOutput, strDocStringOutput, dwHelpContextOutput, strHelpFileOutput);
            });
        }


        public static IObservable<System.Reactive.Unit> GetDllEntry(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> memid, IObservable<System.Runtime.InteropServices.ComTypes.INVOKEKIND> invKind,
            IObservable<System.IntPtr> pBstrDllName, IObservable<System.IntPtr> pBstrName,
            IObservable<System.IntPtr> pwOrdinal)
        {
            return ObservableExt.ZipExecute(ITypeInfo2Value, memid, invKind, pBstrDllName, pBstrName, pwOrdinal,
                (ITypeInfo2ValueLambda, memidLambda, invKindLambda, pBstrDllNameLambda, pBstrNameLambda, pwOrdinalLambda)
                    =>
                    ITypeInfo2ValueLambda.GetDllEntry(memidLambda, invKindLambda, pBstrDllNameLambda, pBstrNameLambda,
                        pwOrdinalLambda));
        }


        public static IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo> GetRefTypeInfo(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> hRef)
        {
            return Observable.Zip(ITypeInfo2Value, hRef, (ITypeInfo2ValueLambda, hRefLambda) =>
            {
                System.Runtime.InteropServices.ComTypes.ITypeInfo ppTIOutput =
                    default(System.Runtime.InteropServices.ComTypes.ITypeInfo);
                ITypeInfo2ValueLambda.GetRefTypeInfo(hRefLambda, out ppTIOutput);
                return ppTIOutput;
            });
        }


        public static IObservable<System.IntPtr> AddressOfMember(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> memid, IObservable<System.Runtime.InteropServices.ComTypes.INVOKEKIND> invKind)
        {
            return Observable.Zip(ITypeInfo2Value, memid, invKind,
                (ITypeInfo2ValueLambda, memidLambda, invKindLambda) =>
                {
                    System.IntPtr ppvOutput = default(System.IntPtr);
                    ITypeInfo2ValueLambda.AddressOfMember(memidLambda, invKindLambda, out ppvOutput);
                    return ppvOutput;
                });
        }


        public static IObservable<Tuple<System.Guid, System.Object>> CreateInstance(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Object> pUnkOuter, IObservable<System.Guid> riid)
        {
            return Observable.Zip(ITypeInfo2Value, pUnkOuter, riid,
                (ITypeInfo2ValueLambda, pUnkOuterLambda, riidLambda) =>
                {
                    System.Object ppvObjOutput = default(System.Object);
                    ITypeInfo2ValueLambda.CreateInstance(pUnkOuterLambda, ref riidLambda, out ppvObjOutput);
                    return Tuple.Create(riidLambda, ppvObjOutput);
                });
        }


        public static IObservable<System.String> GetMops(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> memid)
        {
            return Observable.Zip(ITypeInfo2Value, memid, (ITypeInfo2ValueLambda, memidLambda) =>
            {
                System.String pBstrMopsOutput = default(System.String);
                ITypeInfo2ValueLambda.GetMops(memidLambda, out pBstrMopsOutput);
                return pBstrMopsOutput;
            });
        }


        public static IObservable<Tuple<System.Runtime.InteropServices.ComTypes.ITypeLib, System.Int32>>
            GetContainingTypeLib(this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value)
        {
            return Observable.Select(ITypeInfo2Value, (ITypeInfo2ValueLambda) =>
            {
                System.Runtime.InteropServices.ComTypes.ITypeLib ppTLBOutput =
                    default(System.Runtime.InteropServices.ComTypes.ITypeLib);
                System.Int32 pIndexOutput = default(System.Int32);
                ITypeInfo2ValueLambda.GetContainingTypeLib(out ppTLBOutput, out pIndexOutput);
                return Tuple.Create(ppTLBOutput, pIndexOutput);
            });
        }


        public static IObservable<System.Reactive.Unit> ReleaseTypeAttr(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.IntPtr> pTypeAttr)
        {
            return ObservableExt.ZipExecute(ITypeInfo2Value, pTypeAttr,
                (ITypeInfo2ValueLambda, pTypeAttrLambda) => ITypeInfo2ValueLambda.ReleaseTypeAttr(pTypeAttrLambda));
        }


        public static IObservable<System.Reactive.Unit> ReleaseFuncDesc(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.IntPtr> pFuncDesc)
        {
            return ObservableExt.ZipExecute(ITypeInfo2Value, pFuncDesc,
                (ITypeInfo2ValueLambda, pFuncDescLambda) => ITypeInfo2ValueLambda.ReleaseFuncDesc(pFuncDescLambda));
        }


        public static IObservable<System.Reactive.Unit> ReleaseVarDesc(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.IntPtr> pVarDesc)
        {
            return ObservableExt.ZipExecute(ITypeInfo2Value, pVarDesc,
                (ITypeInfo2ValueLambda, pVarDescLambda) => ITypeInfo2ValueLambda.ReleaseVarDesc(pVarDescLambda));
        }


        public static IObservable<System.Runtime.InteropServices.ComTypes.TYPEKIND> GetTypeKind(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value)
        {
            return Observable.Select(ITypeInfo2Value, (ITypeInfo2ValueLambda) =>
            {
                System.Runtime.InteropServices.ComTypes.TYPEKIND pTypeKindOutput =
                    default(System.Runtime.InteropServices.ComTypes.TYPEKIND);
                ITypeInfo2ValueLambda.GetTypeKind(out pTypeKindOutput);
                return pTypeKindOutput;
            });
        }


        public static IObservable<System.Int32> GetTypeFlags(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value)
        {
            return Observable.Select(ITypeInfo2Value, (ITypeInfo2ValueLambda) =>
            {
                System.Int32 pTypeFlagsOutput = default(System.Int32);
                ITypeInfo2ValueLambda.GetTypeFlags(out pTypeFlagsOutput);
                return pTypeFlagsOutput;
            });
        }


        public static IObservable<System.Int32> GetFuncIndexOfMemId(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> memid, IObservable<System.Runtime.InteropServices.ComTypes.INVOKEKIND> invKind)
        {
            return Observable.Zip(ITypeInfo2Value, memid, invKind,
                (ITypeInfo2ValueLambda, memidLambda, invKindLambda) =>
                {
                    System.Int32 pFuncIndexOutput = default(System.Int32);
                    ITypeInfo2ValueLambda.GetFuncIndexOfMemId(memidLambda, invKindLambda, out pFuncIndexOutput);
                    return pFuncIndexOutput;
                });
        }


        public static IObservable<System.Int32> GetVarIndexOfMemId(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> memid)
        {
            return Observable.Zip(ITypeInfo2Value, memid, (ITypeInfo2ValueLambda, memidLambda) =>
            {
                System.Int32 pVarIndexOutput = default(System.Int32);
                ITypeInfo2ValueLambda.GetVarIndexOfMemId(memidLambda, out pVarIndexOutput);
                return pVarIndexOutput;
            });
        }


        public static IObservable<Tuple<System.Guid, System.Object>> GetCustData(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Guid> guid)
        {
            return Observable.Zip(ITypeInfo2Value, guid, (ITypeInfo2ValueLambda, guidLambda) =>
            {
                System.Object pVarValOutput = default(System.Object);
                ITypeInfo2ValueLambda.GetCustData(ref guidLambda, out pVarValOutput);
                return Tuple.Create(guidLambda, pVarValOutput);
            });
        }


        public static IObservable<Tuple<System.Guid, System.Object>> GetFuncCustData(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> index, IObservable<System.Guid> guid)
        {
            return Observable.Zip(ITypeInfo2Value, index, guid, (ITypeInfo2ValueLambda, indexLambda, guidLambda) =>
            {
                System.Object pVarValOutput = default(System.Object);
                ITypeInfo2ValueLambda.GetFuncCustData(indexLambda, ref guidLambda, out pVarValOutput);
                return Tuple.Create(guidLambda, pVarValOutput);
            });
        }


        public static IObservable<Tuple<System.Guid, System.Object>> GetParamCustData(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> indexFunc, IObservable<System.Int32> indexParam, IObservable<System.Guid> guid)
        {
            return Observable.Zip(ITypeInfo2Value, indexFunc, indexParam, guid,
                (ITypeInfo2ValueLambda, indexFuncLambda, indexParamLambda, guidLambda) =>
                {
                    System.Object pVarValOutput = default(System.Object);
                    ITypeInfo2ValueLambda.GetParamCustData(indexFuncLambda, indexParamLambda, ref guidLambda,
                        out pVarValOutput);
                    return Tuple.Create(guidLambda, pVarValOutput);
                });
        }


        public static IObservable<Tuple<System.Guid, System.Object>> GetVarCustData(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> index, IObservable<System.Guid> guid)
        {
            return Observable.Zip(ITypeInfo2Value, index, guid, (ITypeInfo2ValueLambda, indexLambda, guidLambda) =>
            {
                System.Object pVarValOutput = default(System.Object);
                ITypeInfo2ValueLambda.GetVarCustData(indexLambda, ref guidLambda, out pVarValOutput);
                return Tuple.Create(guidLambda, pVarValOutput);
            });
        }


        public static IObservable<Tuple<System.Guid, System.Object>> GetImplTypeCustData(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> index, IObservable<System.Guid> guid)
        {
            return Observable.Zip(ITypeInfo2Value, index, guid, (ITypeInfo2ValueLambda, indexLambda, guidLambda) =>
            {
                System.Object pVarValOutput = default(System.Object);
                ITypeInfo2ValueLambda.GetImplTypeCustData(indexLambda, ref guidLambda, out pVarValOutput);
                return Tuple.Create(guidLambda, pVarValOutput);
            });
        }


        public static IObservable<Tuple<System.String, System.Int32, System.String>> GetDocumentation2(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> memid)
        {
            return Observable.Zip(ITypeInfo2Value, memid, (ITypeInfo2ValueLambda, memidLambda) =>
            {
                System.String pbstrHelpStringOutput = default(System.String);
                System.Int32 pdwHelpStringContextOutput = default(System.Int32);
                System.String pbstrHelpStringDllOutput = default(System.String);
                ITypeInfo2ValueLambda.GetDocumentation2(memidLambda, out pbstrHelpStringOutput,
                    out pdwHelpStringContextOutput, out pbstrHelpStringDllOutput);
                return Tuple.Create(pbstrHelpStringOutput, pdwHelpStringContextOutput, pbstrHelpStringDllOutput);
            });
        }


        public static IObservable<System.Reactive.Unit> GetAllCustData(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.IntPtr> pCustData)
        {
            return ObservableExt.ZipExecute(ITypeInfo2Value, pCustData,
                (ITypeInfo2ValueLambda, pCustDataLambda) => ITypeInfo2ValueLambda.GetAllCustData(pCustDataLambda));
        }


        public static IObservable<System.Reactive.Unit> GetAllFuncCustData(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> index, IObservable<System.IntPtr> pCustData)
        {
            return ObservableExt.ZipExecute(ITypeInfo2Value, index, pCustData,
                (ITypeInfo2ValueLambda, indexLambda, pCustDataLambda) =>
                    ITypeInfo2ValueLambda.GetAllFuncCustData(indexLambda, pCustDataLambda));
        }


        public static IObservable<System.Reactive.Unit> GetAllParamCustData(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> indexFunc, IObservable<System.Int32> indexParam,
            IObservable<System.IntPtr> pCustData)
        {
            return ObservableExt.ZipExecute(ITypeInfo2Value, indexFunc, indexParam, pCustData,
                (ITypeInfo2ValueLambda, indexFuncLambda, indexParamLambda, pCustDataLambda) =>
                    ITypeInfo2ValueLambda.GetAllParamCustData(indexFuncLambda, indexParamLambda, pCustDataLambda));
        }


        public static IObservable<System.Reactive.Unit> GetAllVarCustData(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> index, IObservable<System.IntPtr> pCustData)
        {
            return ObservableExt.ZipExecute(ITypeInfo2Value, index, pCustData,
                (ITypeInfo2ValueLambda, indexLambda, pCustDataLambda) =>
                    ITypeInfo2ValueLambda.GetAllVarCustData(indexLambda, pCustDataLambda));
        }


        public static IObservable<System.Reactive.Unit> GetAllImplTypeCustData(
            this IObservable<System.Runtime.InteropServices.ComTypes.ITypeInfo2> ITypeInfo2Value,
            IObservable<System.Int32> index, IObservable<System.IntPtr> pCustData)
        {
            return ObservableExt.ZipExecute(ITypeInfo2Value, index, pCustData,
                (ITypeInfo2ValueLambda, indexLambda, pCustDataLambda) =>
                    ITypeInfo2ValueLambda.GetAllImplTypeCustData(indexLambda, pCustDataLambda));
        }
    }
}