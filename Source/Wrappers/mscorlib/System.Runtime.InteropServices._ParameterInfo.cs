using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class ___ParameterInfo
    {
        public static IObservable<System.UInt32> GetTypeInfoCount(
            this IObservable<System.Runtime.InteropServices._ParameterInfo> _ParameterInfoValue)
        {
            return Observable.Select(_ParameterInfoValue, (_ParameterInfoValueLambda) =>
            {
                System.UInt32 pcTInfoOutput = default(System.UInt32);
                _ParameterInfoValueLambda.GetTypeInfoCount(out pcTInfoOutput);
                return pcTInfoOutput;
            });
        }


        public static IObservable<System.Reactive.Unit> GetTypeInfo(
            this IObservable<System.Runtime.InteropServices._ParameterInfo> _ParameterInfoValue,
            IObservable<System.UInt32> iTInfo, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> ppTInfo)
        {
            return ObservableExt.ZipExecute(_ParameterInfoValue, iTInfo, lcid, ppTInfo,
                (_ParameterInfoValueLambda, iTInfoLambda, lcidLambda, ppTInfoLambda) =>
                    _ParameterInfoValueLambda.GetTypeInfo(iTInfoLambda, lcidLambda, ppTInfoLambda));
        }


        public static IObservable<System.Guid> GetIDsOfNames(
            this IObservable<System.Runtime.InteropServices._ParameterInfo> _ParameterInfoValue,
            IObservable<System.Guid> riid, IObservable<System.IntPtr> rgszNames, IObservable<System.UInt32> cNames,
            IObservable<System.UInt32> lcid, IObservable<System.IntPtr> rgDispId)
        {
            return Observable.Zip(_ParameterInfoValue, riid, rgszNames, cNames, lcid, rgDispId,
                (_ParameterInfoValueLambda, riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda) =>
                {
                    _ParameterInfoValueLambda.GetIDsOfNames(ref riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda,
                        rgDispIdLambda);
                    return riidLambda;
                });
        }


        public static IObservable<System.Guid> Invoke(
            this IObservable<System.Runtime.InteropServices._ParameterInfo> _ParameterInfoValue,
            IObservable<System.UInt32> dispIdMember, IObservable<System.Guid> riid, IObservable<System.UInt32> lcid,
            IObservable<System.Int16> wFlags, IObservable<System.IntPtr> pDispParams,
            IObservable<System.IntPtr> pVarResult, IObservable<System.IntPtr> pExcepInfo,
            IObservable<System.IntPtr> puArgErr)
        {
            return Observable.Zip(_ParameterInfoValue, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult,
                pExcepInfo, puArgErr,
                (_ParameterInfoValueLambda, dispIdMemberLambda, riidLambda, lcidLambda, wFlagsLambda, pDispParamsLambda,
                    pVarResultLambda, pExcepInfoLambda, puArgErrLambda) =>
                {
                    _ParameterInfoValueLambda.Invoke(dispIdMemberLambda, ref riidLambda, lcidLambda, wFlagsLambda,
                        pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda);
                    return riidLambda;
                });
        }
    }
}