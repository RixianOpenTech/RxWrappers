using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class ___ILGenerator
    {
        
        public static IObservable<System.UInt32> GetTypeInfoCount(this IObservable<System.Runtime.InteropServices._ILGenerator> _ILGeneratorValue)
        {
            return Observable.Select(_ILGeneratorValue, (_ILGeneratorValueLambda) => {
System.UInt32 pcTInfoOutput = default(System.UInt32);
_ILGeneratorValueLambda.GetTypeInfoCount(out pcTInfoOutput);
return pcTInfoOutput;
});
        }


        public static IObservable<System.Reactive.Unit> GetTypeInfo(this IObservable<System.Runtime.InteropServices._ILGenerator> _ILGeneratorValue, IObservable<System.UInt32> iTInfo, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> ppTInfo)
        {
            return ObservableExt.ZipExecute(_ILGeneratorValue, iTInfo, lcid, ppTInfo, (_ILGeneratorValueLambda, iTInfoLambda, lcidLambda, ppTInfoLambda) => _ILGeneratorValueLambda.GetTypeInfo(iTInfoLambda, lcidLambda, ppTInfoLambda));
        }


        public static IObservable<System.Guid> GetIDsOfNames(this IObservable<System.Runtime.InteropServices._ILGenerator> _ILGeneratorValue, IObservable<System.Guid> riid, IObservable<System.IntPtr> rgszNames, IObservable<System.UInt32> cNames, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> rgDispId)
        {
            return Observable.Zip(_ILGeneratorValue, riid, rgszNames, cNames, lcid, rgDispId, (_ILGeneratorValueLambda, riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda) => {
_ILGeneratorValueLambda.GetIDsOfNames(ref riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda);
return riidLambda;
});
        }


        public static IObservable<System.Guid> Invoke(this IObservable<System.Runtime.InteropServices._ILGenerator> _ILGeneratorValue, IObservable<System.UInt32> dispIdMember, IObservable<System.Guid> riid, IObservable<System.UInt32> lcid, IObservable<System.Int16> wFlags, IObservable<System.IntPtr> pDispParams, IObservable<System.IntPtr> pVarResult, IObservable<System.IntPtr> pExcepInfo, IObservable<System.IntPtr> puArgErr)
        {
            return Observable.Zip(_ILGeneratorValue, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr, (_ILGeneratorValueLambda, dispIdMemberLambda, riidLambda, lcidLambda, wFlagsLambda, pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda) => {
_ILGeneratorValueLambda.Invoke(dispIdMemberLambda, ref riidLambda, lcidLambda, wFlagsLambda, pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda);
return riidLambda;
});
        }

    }
}