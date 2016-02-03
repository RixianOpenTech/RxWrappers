using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class __MethodInfo
{
    
public static IObservable<System.UInt32> GetTypeInfoCount(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => {
System.UInt32 pcTInfoOutput = default(System.UInt32);
_MethodInfoValueLambda.GetTypeInfoCount(out pcTInfoOutput);
return pcTInfoOutput;
});
}


public static IObservable<System.Reactive.Unit> GetTypeInfo(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue, IObservable<System.UInt32> iTInfo, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> ppTInfo)
{
    return ObservableExt.ZipExecute(_MethodInfoValue, iTInfo, lcid, ppTInfo, (_MethodInfoValueLambda, iTInfoLambda, lcidLambda, ppTInfoLambda) => _MethodInfoValueLambda.GetTypeInfo(iTInfoLambda, lcidLambda, ppTInfoLambda));
}


public static IObservable<System.Guid> GetIDsOfNames(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue, IObservable<System.Guid> riid, IObservable<System.IntPtr> rgszNames, IObservable<System.UInt32> cNames, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> rgDispId)
{
    return Observable.Zip(_MethodInfoValue, riid, rgszNames, cNames, lcid, rgDispId, (_MethodInfoValueLambda, riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda) => {
_MethodInfoValueLambda.GetIDsOfNames(ref riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda);
return riidLambda;
});
}


public static IObservable<System.Guid> Invoke(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue, IObservable<System.UInt32> dispIdMember, IObservable<System.Guid> riid, IObservable<System.UInt32> lcid, IObservable<System.Int16> wFlags, IObservable<System.IntPtr> pDispParams, IObservable<System.IntPtr> pVarResult, IObservable<System.IntPtr> pExcepInfo, IObservable<System.IntPtr> puArgErr)
{
    return Observable.Zip(_MethodInfoValue, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr, (_MethodInfoValueLambda, dispIdMemberLambda, riidLambda, lcidLambda, wFlagsLambda, pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda) => {
_MethodInfoValueLambda.Invoke(dispIdMemberLambda, ref riidLambda, lcidLambda, wFlagsLambda, pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda);
return riidLambda;
});
}


public static IObservable<System.String> ToString(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.ToString());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue, IObservable<System.Object> other)
{
    return Observable.Zip(_MethodInfoValue, other, (_MethodInfoValueLambda, otherLambda) => _MethodInfoValueLambda.Equals(otherLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.GetHashCode());
}


public static IObservable<System.Type> GetType(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.GetType());
}


public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(_MethodInfoValue, attributeType, inherit, (_MethodInfoValueLambda, attributeTypeLambda, inheritLambda) => _MethodInfoValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(_MethodInfoValue, inherit, (_MethodInfoValueLambda, inheritLambda) => _MethodInfoValueLambda.GetCustomAttributes(inheritLambda));
}


public static IObservable<System.Boolean> IsDefined(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(_MethodInfoValue, attributeType, inherit, (_MethodInfoValueLambda, attributeTypeLambda, inheritLambda) => _MethodInfoValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Reflection.ParameterInfo[]> GetParameters(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.GetParameters());
}


public static IObservable<System.Reflection.MethodImplAttributes> GetMethodImplementationFlags(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.GetMethodImplementationFlags());
}


public static IObservable<System.Object> Invoke(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue, IObservable<System.Object> obj, IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> parameters, IObservable<System.Globalization.CultureInfo> culture)
{
    return Observable.Zip(_MethodInfoValue, obj, invokeAttr, binder, parameters, culture, (_MethodInfoValueLambda, objLambda, invokeAttrLambda, binderLambda, parametersLambda, cultureLambda) => _MethodInfoValueLambda.Invoke(objLambda, invokeAttrLambda, binderLambda, parametersLambda, cultureLambda));
}


public static IObservable<System.Object> Invoke(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue, IObservable<System.Object> obj, IObservable<System.Object[]> parameters)
{
    return Observable.Zip(_MethodInfoValue, obj, parameters, (_MethodInfoValueLambda, objLambda, parametersLambda) => _MethodInfoValueLambda.Invoke(objLambda, parametersLambda));
}


public static IObservable<System.Reflection.MethodInfo> GetBaseDefinition(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.GetBaseDefinition());
}


public static IObservable<System.Reflection.MemberTypes> get_MemberType(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.MemberType);
}


public static IObservable<System.String> get_Name(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.Name);
}


public static IObservable<System.Type> get_DeclaringType(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.DeclaringType);
}


public static IObservable<System.Type> get_ReflectedType(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.ReflectedType);
}


public static IObservable<System.RuntimeMethodHandle> get_MethodHandle(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.MethodHandle);
}


public static IObservable<System.Reflection.MethodAttributes> get_Attributes(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.Attributes);
}


public static IObservable<System.Reflection.CallingConventions> get_CallingConvention(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.CallingConvention);
}


public static IObservable<System.Boolean> get_IsPublic(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.IsPublic);
}


public static IObservable<System.Boolean> get_IsPrivate(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.IsPrivate);
}


public static IObservable<System.Boolean> get_IsFamily(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.IsFamily);
}


public static IObservable<System.Boolean> get_IsAssembly(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.IsAssembly);
}


public static IObservable<System.Boolean> get_IsFamilyAndAssembly(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.IsFamilyAndAssembly);
}


public static IObservable<System.Boolean> get_IsFamilyOrAssembly(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.IsFamilyOrAssembly);
}


public static IObservable<System.Boolean> get_IsStatic(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.IsStatic);
}


public static IObservable<System.Boolean> get_IsFinal(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.IsFinal);
}


public static IObservable<System.Boolean> get_IsVirtual(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.IsVirtual);
}


public static IObservable<System.Boolean> get_IsHideBySig(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.IsHideBySig);
}


public static IObservable<System.Boolean> get_IsAbstract(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.IsAbstract);
}


public static IObservable<System.Boolean> get_IsSpecialName(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.IsSpecialName);
}


public static IObservable<System.Boolean> get_IsConstructor(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.IsConstructor);
}


public static IObservable<System.Type> get_ReturnType(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.ReturnType);
}


public static IObservable<System.Reflection.ICustomAttributeProvider> get_ReturnTypeCustomAttributes(this IObservable<System.Runtime.InteropServices._MethodInfo> _MethodInfoValue)
{
    return Observable.Select(_MethodInfoValue, (_MethodInfoValueLambda) => _MethodInfoValueLambda.ReturnTypeCustomAttributes);
}

}
}