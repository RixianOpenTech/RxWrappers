using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class ___MethodBase
    {
        
        public static IObservable<System.UInt32> GetTypeInfoCount(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => {
System.UInt32 pcTInfoOutput = default(System.UInt32);
_MethodBaseValueLambda.GetTypeInfoCount(out pcTInfoOutput);
return pcTInfoOutput;
});
        }


        public static IObservable<System.Reactive.Unit> GetTypeInfo(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue, IObservable<System.UInt32> iTInfo, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> ppTInfo)
        {
            return ObservableExt.ZipExecute(_MethodBaseValue, iTInfo, lcid, ppTInfo, (_MethodBaseValueLambda, iTInfoLambda, lcidLambda, ppTInfoLambda) => _MethodBaseValueLambda.GetTypeInfo(iTInfoLambda, lcidLambda, ppTInfoLambda));
        }


        public static IObservable<System.Guid> GetIDsOfNames(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue, IObservable<System.Guid> riid, IObservable<System.IntPtr> rgszNames, IObservable<System.UInt32> cNames, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> rgDispId)
        {
            return Observable.Zip(_MethodBaseValue, riid, rgszNames, cNames, lcid, rgDispId, (_MethodBaseValueLambda, riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda) => {
_MethodBaseValueLambda.GetIDsOfNames(ref riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda);
return riidLambda;
});
        }


        public static IObservable<System.Guid> Invoke(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue, IObservable<System.UInt32> dispIdMember, IObservable<System.Guid> riid, IObservable<System.UInt32> lcid, IObservable<System.Int16> wFlags, IObservable<System.IntPtr> pDispParams, IObservable<System.IntPtr> pVarResult, IObservable<System.IntPtr> pExcepInfo, IObservable<System.IntPtr> puArgErr)
        {
            return Observable.Zip(_MethodBaseValue, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr, (_MethodBaseValueLambda, dispIdMemberLambda, riidLambda, lcidLambda, wFlagsLambda, pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda) => {
_MethodBaseValueLambda.Invoke(dispIdMemberLambda, ref riidLambda, lcidLambda, wFlagsLambda, pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda);
return riidLambda;
});
        }


        public static IObservable<System.String> ToString(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue, IObservable<System.Object> other)
        {
            return Observable.Zip(_MethodBaseValue, other, (_MethodBaseValueLambda, otherLambda) => _MethodBaseValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.GetHashCode());
        }


        public static IObservable<System.Type> GetType(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.GetType());
        }


        public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_MethodBaseValue, attributeType, inherit, (_MethodBaseValueLambda, attributeTypeLambda, inheritLambda) => _MethodBaseValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_MethodBaseValue, inherit, (_MethodBaseValueLambda, inheritLambda) => _MethodBaseValueLambda.GetCustomAttributes(inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_MethodBaseValue, attributeType, inherit, (_MethodBaseValueLambda, attributeTypeLambda, inheritLambda) => _MethodBaseValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Reflection.ParameterInfo[]> GetParameters(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.GetParameters());
        }


        public static IObservable<System.Reflection.MethodImplAttributes> GetMethodImplementationFlags(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.GetMethodImplementationFlags());
        }


        public static IObservable<System.Object> Invoke(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue, IObservable<System.Object> obj, IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> parameters, IObservable<System.Globalization.CultureInfo> culture)
        {
            return Observable.Zip(_MethodBaseValue, obj, invokeAttr, binder, parameters, culture, (_MethodBaseValueLambda, objLambda, invokeAttrLambda, binderLambda, parametersLambda, cultureLambda) => _MethodBaseValueLambda.Invoke(objLambda, invokeAttrLambda, binderLambda, parametersLambda, cultureLambda));
        }


        public static IObservable<System.Object> Invoke(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue, IObservable<System.Object> obj, IObservable<System.Object[]> parameters)
        {
            return Observable.Zip(_MethodBaseValue, obj, parameters, (_MethodBaseValueLambda, objLambda, parametersLambda) => _MethodBaseValueLambda.Invoke(objLambda, parametersLambda));
        }


        public static IObservable<System.Reflection.MemberTypes> get_MemberType(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.MemberType);
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.Name);
        }


        public static IObservable<System.Type> get_DeclaringType(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.DeclaringType);
        }


        public static IObservable<System.Type> get_ReflectedType(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.ReflectedType);
        }


        public static IObservable<System.RuntimeMethodHandle> get_MethodHandle(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.MethodHandle);
        }


        public static IObservable<System.Reflection.MethodAttributes> get_Attributes(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.Attributes);
        }


        public static IObservable<System.Reflection.CallingConventions> get_CallingConvention(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.CallingConvention);
        }


        public static IObservable<System.Boolean> get_IsPublic(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.IsPublic);
        }


        public static IObservable<System.Boolean> get_IsPrivate(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.IsPrivate);
        }


        public static IObservable<System.Boolean> get_IsFamily(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.IsFamily);
        }


        public static IObservable<System.Boolean> get_IsAssembly(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.IsAssembly);
        }


        public static IObservable<System.Boolean> get_IsFamilyAndAssembly(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.IsFamilyAndAssembly);
        }


        public static IObservable<System.Boolean> get_IsFamilyOrAssembly(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.IsFamilyOrAssembly);
        }


        public static IObservable<System.Boolean> get_IsStatic(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.IsStatic);
        }


        public static IObservable<System.Boolean> get_IsFinal(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.IsFinal);
        }


        public static IObservable<System.Boolean> get_IsVirtual(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.IsVirtual);
        }


        public static IObservable<System.Boolean> get_IsHideBySig(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.IsHideBySig);
        }


        public static IObservable<System.Boolean> get_IsAbstract(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.IsAbstract);
        }


        public static IObservable<System.Boolean> get_IsSpecialName(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.IsSpecialName);
        }


        public static IObservable<System.Boolean> get_IsConstructor(this IObservable<System.Runtime.InteropServices._MethodBase> _MethodBaseValue)
        {
            return Observable.Select(_MethodBaseValue, (_MethodBaseValueLambda) => _MethodBaseValueLambda.IsConstructor);
        }

    }
}