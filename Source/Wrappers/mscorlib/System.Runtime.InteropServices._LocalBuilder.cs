using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class ___LocalBuilder
    {
        public static IObservable<System.UInt32> GetTypeInfoCount(
            this IObservable<System.Runtime.InteropServices._LocalBuilder> _LocalBuilderValue)
        {
            return Observable.Select(_LocalBuilderValue, (_LocalBuilderValueLambda) =>
            {
                System.UInt32 pcTInfoOutput = default(System.UInt32);
                _LocalBuilderValueLambda.GetTypeInfoCount(out pcTInfoOutput);
                return pcTInfoOutput;
            });
        }


        public static IObservable<System.Reactive.Unit> GetTypeInfo(
            this IObservable<System.Runtime.InteropServices._LocalBuilder> _LocalBuilderValue,
            IObservable<System.UInt32> iTInfo, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> ppTInfo)
        {
            return ObservableExt.ZipExecute(_LocalBuilderValue, iTInfo, lcid, ppTInfo,
                (_LocalBuilderValueLambda, iTInfoLambda, lcidLambda, ppTInfoLambda) =>
                    _LocalBuilderValueLambda.GetTypeInfo(iTInfoLambda, lcidLambda, ppTInfoLambda));
        }


        public static IObservable<System.Guid> GetIDsOfNames(
            this IObservable<System.Runtime.InteropServices._LocalBuilder> _LocalBuilderValue,
            IObservable<System.Guid> riid, IObservable<System.IntPtr> rgszNames, IObservable<System.UInt32> cNames,
            IObservable<System.UInt32> lcid, IObservable<System.IntPtr> rgDispId)
        {
            return Observable.Zip(_LocalBuilderValue, riid, rgszNames, cNames, lcid, rgDispId,
                (_LocalBuilderValueLambda, riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda) =>
                {
                    _LocalBuilderValueLambda.GetIDsOfNames(ref riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda,
                        rgDispIdLambda);
                    return riidLambda;
                });
        }


        public static IObservable<System.Guid> Invoke(
            this IObservable<System.Runtime.InteropServices._LocalBuilder> _LocalBuilderValue,
            IObservable<System.UInt32> dispIdMember, IObservable<System.Guid> riid, IObservable<System.UInt32> lcid,
            IObservable<System.Int16> wFlags, IObservable<System.IntPtr> pDispParams,
            IObservable<System.IntPtr> pVarResult, IObservable<System.IntPtr> pExcepInfo,
            IObservable<System.IntPtr> puArgErr)
        {
            return Observable.Zip(_LocalBuilderValue, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult,
                pExcepInfo, puArgErr,
                (_LocalBuilderValueLambda, dispIdMemberLambda, riidLambda, lcidLambda, wFlagsLambda, pDispParamsLambda,
                    pVarResultLambda, pExcepInfoLambda, puArgErrLambda) =>
                {
                    _LocalBuilderValueLambda.Invoke(dispIdMemberLambda, ref riidLambda, lcidLambda, wFlagsLambda,
                        pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda);
                    return riidLambda;
                });
        }
    }
}