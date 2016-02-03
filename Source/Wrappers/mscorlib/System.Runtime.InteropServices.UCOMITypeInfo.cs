using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __UCOMITypeInfo
    {
        public static IObservable<System.IntPtr> GetTypeAttr(
            this IObservable<System.Runtime.InteropServices.UCOMITypeInfo> UCOMITypeInfoValue)
        {
            return Observable.Select(UCOMITypeInfoValue, (UCOMITypeInfoValueLambda) =>
            {
                System.IntPtr ppTypeAttrOutput = default(System.IntPtr);
                UCOMITypeInfoValueLambda.GetTypeAttr(out ppTypeAttrOutput);
                return ppTypeAttrOutput;
            });
        }


        public static IObservable<System.Runtime.InteropServices.UCOMITypeComp> GetTypeComp(
            this IObservable<System.Runtime.InteropServices.UCOMITypeInfo> UCOMITypeInfoValue)
        {
            return Observable.Select(UCOMITypeInfoValue, (UCOMITypeInfoValueLambda) =>
            {
                System.Runtime.InteropServices.UCOMITypeComp ppTCompOutput =
                    default(System.Runtime.InteropServices.UCOMITypeComp);
                UCOMITypeInfoValueLambda.GetTypeComp(out ppTCompOutput);
                return ppTCompOutput;
            });
        }


        public static IObservable<System.IntPtr> GetFuncDesc(
            this IObservable<System.Runtime.InteropServices.UCOMITypeInfo> UCOMITypeInfoValue,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(UCOMITypeInfoValue, index, (UCOMITypeInfoValueLambda, indexLambda) =>
            {
                System.IntPtr ppFuncDescOutput = default(System.IntPtr);
                UCOMITypeInfoValueLambda.GetFuncDesc(indexLambda, out ppFuncDescOutput);
                return ppFuncDescOutput;
            });
        }


        public static IObservable<System.IntPtr> GetVarDesc(
            this IObservable<System.Runtime.InteropServices.UCOMITypeInfo> UCOMITypeInfoValue,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(UCOMITypeInfoValue, index, (UCOMITypeInfoValueLambda, indexLambda) =>
            {
                System.IntPtr ppVarDescOutput = default(System.IntPtr);
                UCOMITypeInfoValueLambda.GetVarDesc(indexLambda, out ppVarDescOutput);
                return ppVarDescOutput;
            });
        }


        public static IObservable<int> GetNames(
            this IObservable<System.Runtime.InteropServices.UCOMITypeInfo> UCOMITypeInfoValue,
            IObservable<System.Int32> memid, IObservable<System.String[]> rgBstrNames,
            IObservable<System.Int32> cMaxNames)
        {
            return Observable.Zip(UCOMITypeInfoValue, memid, rgBstrNames, cMaxNames,
                (UCOMITypeInfoValueLambda, memidLambda, rgBstrNamesLambda, cMaxNamesLambda) =>
                {
                    System.Int32 pcNamesOutput = default(System.Int32);
                    UCOMITypeInfoValueLambda.GetNames(memidLambda, rgBstrNamesLambda, cMaxNamesLambda, out pcNamesOutput);
                    return pcNamesOutput;
                });
        }


        public static IObservable<System.Int32> GetRefTypeOfImplType(
            this IObservable<System.Runtime.InteropServices.UCOMITypeInfo> UCOMITypeInfoValue,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(UCOMITypeInfoValue, index, (UCOMITypeInfoValueLambda, indexLambda) =>
            {
                System.Int32 hrefOutput = default(System.Int32);
                UCOMITypeInfoValueLambda.GetRefTypeOfImplType(indexLambda, out hrefOutput);
                return hrefOutput;
            });
        }


        public static IObservable<System.Int32> GetImplTypeFlags(
            this IObservable<System.Runtime.InteropServices.UCOMITypeInfo> UCOMITypeInfoValue,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(UCOMITypeInfoValue, index, (UCOMITypeInfoValueLambda, indexLambda) =>
            {
                System.Int32 pImplTypeFlagsOutput = default(System.Int32);
                UCOMITypeInfoValueLambda.GetImplTypeFlags(indexLambda, out pImplTypeFlagsOutput);
                return pImplTypeFlagsOutput;
            });
        }


        public static IObservable<Unit> GetIDsOfNames(
            this IObservable<System.Runtime.InteropServices.UCOMITypeInfo> UCOMITypeInfoValue,
            IObservable<System.String[]> rgszNames, IObservable<System.Int32> cNames, IObservable<System.Int32[]> pMemId)
        {
            return ObservableExt.ZipExecute(UCOMITypeInfoValue, rgszNames, cNames, pMemId,
                (UCOMITypeInfoValueLambda, rgszNamesLambda, cNamesLambda, pMemIdLambda) =>
                    UCOMITypeInfoValueLambda.GetIDsOfNames(rgszNamesLambda, cNamesLambda, pMemIdLambda));
        }


        public static
            IObservable
                <
                    Tuple
                        <System.Runtime.InteropServices.DISPPARAMS, System.Object,
                            System.Runtime.InteropServices.EXCEPINFO, System.Int32>> Invoke(
            this IObservable<System.Runtime.InteropServices.UCOMITypeInfo> UCOMITypeInfoValue,
            IObservable<System.Object> pvInstance, IObservable<System.Int32> memid, IObservable<System.Int16> wFlags,
            IObservable<System.Runtime.InteropServices.DISPPARAMS> pDispParams)
        {
            return Observable.Zip(UCOMITypeInfoValue, pvInstance, memid, wFlags, pDispParams,
                (UCOMITypeInfoValueLambda, pvInstanceLambda, memidLambda, wFlagsLambda, pDispParamsLambda) =>
                {
                    System.Object pVarResultOutput = default(System.Object);
                    System.Runtime.InteropServices.EXCEPINFO pExcepInfoOutput =
                        default(System.Runtime.InteropServices.EXCEPINFO);
                    System.Int32 puArgErrOutput = default(System.Int32);
                    UCOMITypeInfoValueLambda.Invoke(pvInstanceLambda, memidLambda, wFlagsLambda, ref pDispParamsLambda,
                        out pVarResultOutput, out pExcepInfoOutput, out puArgErrOutput);
                    return Tuple.Create(pDispParamsLambda, pVarResultOutput, pExcepInfoOutput, puArgErrOutput);
                });
        }


        public static IObservable<Tuple<System.String, System.String, System.Int32, System.String>> GetDocumentation(
            this IObservable<System.Runtime.InteropServices.UCOMITypeInfo> UCOMITypeInfoValue,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(UCOMITypeInfoValue, index, (UCOMITypeInfoValueLambda, indexLambda) =>
            {
                System.String strNameOutput = default(System.String);
                System.String strDocStringOutput = default(System.String);
                System.Int32 dwHelpContextOutput = default(System.Int32);
                System.String strHelpFileOutput = default(System.String);
                UCOMITypeInfoValueLambda.GetDocumentation(indexLambda, out strNameOutput, out strDocStringOutput,
                    out dwHelpContextOutput, out strHelpFileOutput);
                return Tuple.Create(strNameOutput, strDocStringOutput, dwHelpContextOutput, strHelpFileOutput);
            });
        }


        public static IObservable<Tuple<System.String, System.String, System.Int16>> GetDllEntry(
            this IObservable<System.Runtime.InteropServices.UCOMITypeInfo> UCOMITypeInfoValue,
            IObservable<System.Int32> memid, IObservable<System.Runtime.InteropServices.INVOKEKIND> invKind)
        {
            return Observable.Zip(UCOMITypeInfoValue, memid, invKind,
                (UCOMITypeInfoValueLambda, memidLambda, invKindLambda) =>
                {
                    System.String pBstrDllNameOutput = default(System.String);
                    System.String pBstrNameOutput = default(System.String);
                    System.Int16 pwOrdinalOutput = default(System.Int16);
                    UCOMITypeInfoValueLambda.GetDllEntry(memidLambda, invKindLambda, out pBstrDllNameOutput,
                        out pBstrNameOutput, out pwOrdinalOutput);
                    return Tuple.Create(pBstrDllNameOutput, pBstrNameOutput, pwOrdinalOutput);
                });
        }


        public static IObservable<System.Runtime.InteropServices.UCOMITypeInfo> GetRefTypeInfo(
            this IObservable<System.Runtime.InteropServices.UCOMITypeInfo> UCOMITypeInfoValue,
            IObservable<System.Int32> hRef)
        {
            return Observable.Zip(UCOMITypeInfoValue, hRef, (UCOMITypeInfoValueLambda, hRefLambda) =>
            {
                System.Runtime.InteropServices.UCOMITypeInfo ppTIOutput =
                    default(System.Runtime.InteropServices.UCOMITypeInfo);
                UCOMITypeInfoValueLambda.GetRefTypeInfo(hRefLambda, out ppTIOutput);
                return ppTIOutput;
            });
        }


        public static IObservable<System.IntPtr> AddressOfMember(
            this IObservable<System.Runtime.InteropServices.UCOMITypeInfo> UCOMITypeInfoValue,
            IObservable<System.Int32> memid, IObservable<System.Runtime.InteropServices.INVOKEKIND> invKind)
        {
            return Observable.Zip(UCOMITypeInfoValue, memid, invKind,
                (UCOMITypeInfoValueLambda, memidLambda, invKindLambda) =>
                {
                    System.IntPtr ppvOutput = default(System.IntPtr);
                    UCOMITypeInfoValueLambda.AddressOfMember(memidLambda, invKindLambda, out ppvOutput);
                    return ppvOutput;
                });
        }


        public static IObservable<Tuple<System.Guid, System.Object>> CreateInstance(
            this IObservable<System.Runtime.InteropServices.UCOMITypeInfo> UCOMITypeInfoValue,
            IObservable<System.Object> pUnkOuter, IObservable<System.Guid> riid)
        {
            return Observable.Zip(UCOMITypeInfoValue, pUnkOuter, riid,
                (UCOMITypeInfoValueLambda, pUnkOuterLambda, riidLambda) =>
                {
                    System.Object ppvObjOutput = default(System.Object);
                    UCOMITypeInfoValueLambda.CreateInstance(pUnkOuterLambda, ref riidLambda, out ppvObjOutput);
                    return Tuple.Create(riidLambda, ppvObjOutput);
                });
        }


        public static IObservable<System.String> GetMops(
            this IObservable<System.Runtime.InteropServices.UCOMITypeInfo> UCOMITypeInfoValue,
            IObservable<System.Int32> memid)
        {
            return Observable.Zip(UCOMITypeInfoValue, memid, (UCOMITypeInfoValueLambda, memidLambda) =>
            {
                System.String pBstrMopsOutput = default(System.String);
                UCOMITypeInfoValueLambda.GetMops(memidLambda, out pBstrMopsOutput);
                return pBstrMopsOutput;
            });
        }


        public static IObservable<Tuple<System.Runtime.InteropServices.UCOMITypeLib, System.Int32>> GetContainingTypeLib
            (this IObservable<System.Runtime.InteropServices.UCOMITypeInfo> UCOMITypeInfoValue)
        {
            return Observable.Select(UCOMITypeInfoValue, (UCOMITypeInfoValueLambda) =>
            {
                System.Runtime.InteropServices.UCOMITypeLib ppTLBOutput =
                    default(System.Runtime.InteropServices.UCOMITypeLib);
                System.Int32 pIndexOutput = default(System.Int32);
                UCOMITypeInfoValueLambda.GetContainingTypeLib(out ppTLBOutput, out pIndexOutput);
                return Tuple.Create(ppTLBOutput, pIndexOutput);
            });
        }


        public static IObservable<System.Reactive.Unit> ReleaseTypeAttr(
            this IObservable<System.Runtime.InteropServices.UCOMITypeInfo> UCOMITypeInfoValue,
            IObservable<System.IntPtr> pTypeAttr)
        {
            return ObservableExt.ZipExecute(UCOMITypeInfoValue, pTypeAttr,
                (UCOMITypeInfoValueLambda, pTypeAttrLambda) => UCOMITypeInfoValueLambda.ReleaseTypeAttr(pTypeAttrLambda));
        }


        public static IObservable<System.Reactive.Unit> ReleaseFuncDesc(
            this IObservable<System.Runtime.InteropServices.UCOMITypeInfo> UCOMITypeInfoValue,
            IObservable<System.IntPtr> pFuncDesc)
        {
            return ObservableExt.ZipExecute(UCOMITypeInfoValue, pFuncDesc,
                (UCOMITypeInfoValueLambda, pFuncDescLambda) => UCOMITypeInfoValueLambda.ReleaseFuncDesc(pFuncDescLambda));
        }


        public static IObservable<System.Reactive.Unit> ReleaseVarDesc(
            this IObservable<System.Runtime.InteropServices.UCOMITypeInfo> UCOMITypeInfoValue,
            IObservable<System.IntPtr> pVarDesc)
        {
            return ObservableExt.ZipExecute(UCOMITypeInfoValue, pVarDesc,
                (UCOMITypeInfoValueLambda, pVarDescLambda) => UCOMITypeInfoValueLambda.ReleaseVarDesc(pVarDescLambda));
        }
    }
}