using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class ___MemberInfo
    {
        
        public static IObservable<System.UInt32> GetTypeInfoCount(this IObservable<System.Runtime.InteropServices._MemberInfo> _MemberInfoValue)
        {
            return Observable.Select(_MemberInfoValue, (_MemberInfoValueLambda) => {
System.UInt32 pcTInfoOutput = default(System.UInt32);
_MemberInfoValueLambda.GetTypeInfoCount(out pcTInfoOutput);
return pcTInfoOutput;
});
        }


        public static IObservable<System.Reactive.Unit> GetTypeInfo(this IObservable<System.Runtime.InteropServices._MemberInfo> _MemberInfoValue, IObservable<System.UInt32> iTInfo, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> ppTInfo)
        {
            return ObservableExt.ZipExecute(_MemberInfoValue, iTInfo, lcid, ppTInfo, (_MemberInfoValueLambda, iTInfoLambda, lcidLambda, ppTInfoLambda) => _MemberInfoValueLambda.GetTypeInfo(iTInfoLambda, lcidLambda, ppTInfoLambda));
        }


        public static IObservable<System.Guid> GetIDsOfNames(this IObservable<System.Runtime.InteropServices._MemberInfo> _MemberInfoValue, IObservable<System.Guid> riid, IObservable<System.IntPtr> rgszNames, IObservable<System.UInt32> cNames, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> rgDispId)
        {
            return Observable.Zip(_MemberInfoValue, riid, rgszNames, cNames, lcid, rgDispId, (_MemberInfoValueLambda, riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda) => {
_MemberInfoValueLambda.GetIDsOfNames(ref riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda);
return riidLambda;
});
        }


        public static IObservable<System.Guid> Invoke(this IObservable<System.Runtime.InteropServices._MemberInfo> _MemberInfoValue, IObservable<System.UInt32> dispIdMember, IObservable<System.Guid> riid, IObservable<System.UInt32> lcid, IObservable<System.Int16> wFlags, IObservable<System.IntPtr> pDispParams, IObservable<System.IntPtr> pVarResult, IObservable<System.IntPtr> pExcepInfo, IObservable<System.IntPtr> puArgErr)
        {
            return Observable.Zip(_MemberInfoValue, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr, (_MemberInfoValueLambda, dispIdMemberLambda, riidLambda, lcidLambda, wFlagsLambda, pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda) => {
_MemberInfoValueLambda.Invoke(dispIdMemberLambda, ref riidLambda, lcidLambda, wFlagsLambda, pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda);
return riidLambda;
});
        }


        public static IObservable<System.String> ToString(this IObservable<System.Runtime.InteropServices._MemberInfo> _MemberInfoValue)
        {
            return Observable.Select(_MemberInfoValue, (_MemberInfoValueLambda) => _MemberInfoValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Runtime.InteropServices._MemberInfo> _MemberInfoValue, IObservable<System.Object> other)
        {
            return Observable.Zip(_MemberInfoValue, other, (_MemberInfoValueLambda, otherLambda) => _MemberInfoValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Runtime.InteropServices._MemberInfo> _MemberInfoValue)
        {
            return Observable.Select(_MemberInfoValue, (_MemberInfoValueLambda) => _MemberInfoValueLambda.GetHashCode());
        }


        public static IObservable<System.Type> GetType(this IObservable<System.Runtime.InteropServices._MemberInfo> _MemberInfoValue)
        {
            return Observable.Select(_MemberInfoValue, (_MemberInfoValueLambda) => _MemberInfoValueLambda.GetType());
        }


        public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Runtime.InteropServices._MemberInfo> _MemberInfoValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_MemberInfoValue, attributeType, inherit, (_MemberInfoValueLambda, attributeTypeLambda, inheritLambda) => _MemberInfoValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Runtime.InteropServices._MemberInfo> _MemberInfoValue, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_MemberInfoValue, inherit, (_MemberInfoValueLambda, inheritLambda) => _MemberInfoValueLambda.GetCustomAttributes(inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(this IObservable<System.Runtime.InteropServices._MemberInfo> _MemberInfoValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_MemberInfoValue, attributeType, inherit, (_MemberInfoValueLambda, attributeTypeLambda, inheritLambda) => _MemberInfoValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Reflection.MemberTypes> get_MemberType(this IObservable<System.Runtime.InteropServices._MemberInfo> _MemberInfoValue)
        {
            return Observable.Select(_MemberInfoValue, (_MemberInfoValueLambda) => _MemberInfoValueLambda.MemberType);
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Runtime.InteropServices._MemberInfo> _MemberInfoValue)
        {
            return Observable.Select(_MemberInfoValue, (_MemberInfoValueLambda) => _MemberInfoValueLambda.Name);
        }


        public static IObservable<System.Type> get_DeclaringType(this IObservable<System.Runtime.InteropServices._MemberInfo> _MemberInfoValue)
        {
            return Observable.Select(_MemberInfoValue, (_MemberInfoValueLambda) => _MemberInfoValueLambda.DeclaringType);
        }


        public static IObservable<System.Type> get_ReflectedType(this IObservable<System.Runtime.InteropServices._MemberInfo> _MemberInfoValue)
        {
            return Observable.Select(_MemberInfoValue, (_MemberInfoValueLambda) => _MemberInfoValueLambda.ReflectedType);
        }

    }
}