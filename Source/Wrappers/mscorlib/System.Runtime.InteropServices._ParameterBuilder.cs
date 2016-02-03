using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class __ParameterBuilder
{
    
public static IObservable<System.UInt32> GetTypeInfoCount(this IObservable<System.Runtime.InteropServices._ParameterBuilder> _ParameterBuilderValue)
{
    return Observable.Select(_ParameterBuilderValue, (_ParameterBuilderValueLambda) => {
System.UInt32 pcTInfoOutput = default(System.UInt32);
_ParameterBuilderValueLambda.GetTypeInfoCount(out pcTInfoOutput);
return pcTInfoOutput;
});
}


public static IObservable<System.Reactive.Unit> GetTypeInfo(this IObservable<System.Runtime.InteropServices._ParameterBuilder> _ParameterBuilderValue, IObservable<System.UInt32> iTInfo, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> ppTInfo)
{
    return ObservableExt.ZipExecute(_ParameterBuilderValue, iTInfo, lcid, ppTInfo, (_ParameterBuilderValueLambda, iTInfoLambda, lcidLambda, ppTInfoLambda) => _ParameterBuilderValueLambda.GetTypeInfo(iTInfoLambda, lcidLambda, ppTInfoLambda));
}


public static IObservable<System.Guid> GetIDsOfNames(this IObservable<System.Runtime.InteropServices._ParameterBuilder> _ParameterBuilderValue, IObservable<System.Guid> riid, IObservable<System.IntPtr> rgszNames, IObservable<System.UInt32> cNames, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> rgDispId)
{
    return Observable.Zip(_ParameterBuilderValue, riid, rgszNames, cNames, lcid, rgDispId, (_ParameterBuilderValueLambda, riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda) => {
_ParameterBuilderValueLambda.GetIDsOfNames(ref riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda);
return riidLambda;
});
}


public static IObservable<System.Guid> Invoke(this IObservable<System.Runtime.InteropServices._ParameterBuilder> _ParameterBuilderValue, IObservable<System.UInt32> dispIdMember, IObservable<System.Guid> riid, IObservable<System.UInt32> lcid, IObservable<System.Int16> wFlags, IObservable<System.IntPtr> pDispParams, IObservable<System.IntPtr> pVarResult, IObservable<System.IntPtr> pExcepInfo, IObservable<System.IntPtr> puArgErr)
{
    return Observable.Zip(_ParameterBuilderValue, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr, (_ParameterBuilderValueLambda, dispIdMemberLambda, riidLambda, lcidLambda, wFlagsLambda, pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda) => {
_ParameterBuilderValueLambda.Invoke(dispIdMemberLambda, ref riidLambda, lcidLambda, wFlagsLambda, pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda);
return riidLambda;
});
}

}
}