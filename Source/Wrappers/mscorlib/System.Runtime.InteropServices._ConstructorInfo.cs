using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class ___ConstructorInfo
    {
        public static IObservable<System.UInt32> GetTypeInfoCount(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue, (_ConstructorInfoValueLambda) =>
            {
                System.UInt32 pcTInfoOutput = default(System.UInt32);
                _ConstructorInfoValueLambda.GetTypeInfoCount(out pcTInfoOutput);
                return pcTInfoOutput;
            });
        }


        public static IObservable<System.Reactive.Unit> GetTypeInfo(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue,
            IObservable<System.UInt32> iTInfo, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> ppTInfo)
        {
            return ObservableExt.ZipExecute(_ConstructorInfoValue, iTInfo, lcid, ppTInfo,
                (_ConstructorInfoValueLambda, iTInfoLambda, lcidLambda, ppTInfoLambda) =>
                    _ConstructorInfoValueLambda.GetTypeInfo(iTInfoLambda, lcidLambda, ppTInfoLambda));
        }


        public static IObservable<System.Guid> GetIDsOfNames(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue,
            IObservable<System.Guid> riid, IObservable<System.IntPtr> rgszNames, IObservable<System.UInt32> cNames,
            IObservable<System.UInt32> lcid, IObservable<System.IntPtr> rgDispId)
        {
            return Observable.Zip(_ConstructorInfoValue, riid, rgszNames, cNames, lcid, rgDispId,
                (_ConstructorInfoValueLambda, riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda) =>
                {
                    _ConstructorInfoValueLambda.GetIDsOfNames(ref riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda,
                        rgDispIdLambda);
                    return riidLambda;
                });
        }


        public static IObservable<System.Guid> Invoke(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue,
            IObservable<System.UInt32> dispIdMember, IObservable<System.Guid> riid, IObservable<System.UInt32> lcid,
            IObservable<System.Int16> wFlags, IObservable<System.IntPtr> pDispParams,
            IObservable<System.IntPtr> pVarResult, IObservable<System.IntPtr> pExcepInfo,
            IObservable<System.IntPtr> puArgErr)
        {
            return Observable.Zip(_ConstructorInfoValue, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult,
                pExcepInfo, puArgErr,
                (_ConstructorInfoValueLambda, dispIdMemberLambda, riidLambda, lcidLambda, wFlagsLambda,
                    pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda) =>
                {
                    _ConstructorInfoValueLambda.Invoke(dispIdMemberLambda, ref riidLambda, lcidLambda, wFlagsLambda,
                        pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda);
                    return riidLambda;
                });
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue,
            IObservable<System.Object> other)
        {
            return Observable.Zip(_ConstructorInfoValue, other,
                (_ConstructorInfoValueLambda, otherLambda) => _ConstructorInfoValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.GetHashCode());
        }


        public static IObservable<System.Type> GetType(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.GetType());
        }


        public static IObservable<System.Object[]> GetCustomAttributes(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_ConstructorInfoValue, attributeType, inherit,
                (_ConstructorInfoValueLambda, attributeTypeLambda, inheritLambda) =>
                    _ConstructorInfoValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Object[]> GetCustomAttributes(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue,
            IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_ConstructorInfoValue, inherit,
                (_ConstructorInfoValueLambda, inheritLambda) =>
                    _ConstructorInfoValueLambda.GetCustomAttributes(inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_ConstructorInfoValue, attributeType, inherit,
                (_ConstructorInfoValueLambda, attributeTypeLambda, inheritLambda) =>
                    _ConstructorInfoValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Reflection.ParameterInfo[]> GetParameters(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.GetParameters());
        }


        public static IObservable<System.Reflection.MethodImplAttributes> GetMethodImplementationFlags(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.GetMethodImplementationFlags());
        }


        public static IObservable<System.Object> Invoke_2(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue,
            IObservable<System.Object> obj, IObservable<System.Reflection.BindingFlags> invokeAttr,
            IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> parameters,
            IObservable<System.Globalization.CultureInfo> culture)
        {
            return Observable.Zip(_ConstructorInfoValue, obj, invokeAttr, binder, parameters, culture,
                (_ConstructorInfoValueLambda, objLambda, invokeAttrLambda, binderLambda, parametersLambda, cultureLambda)
                    =>
                    _ConstructorInfoValueLambda.Invoke_2(objLambda, invokeAttrLambda, binderLambda, parametersLambda,
                        cultureLambda));
        }


        public static IObservable<System.Object> Invoke_3(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue,
            IObservable<System.Object> obj, IObservable<System.Object[]> parameters)
        {
            return Observable.Zip(_ConstructorInfoValue, obj, parameters,
                (_ConstructorInfoValueLambda, objLambda, parametersLambda) =>
                    _ConstructorInfoValueLambda.Invoke_3(objLambda, parametersLambda));
        }


        public static IObservable<System.Object> Invoke_4(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue,
            IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder,
            IObservable<System.Object[]> parameters, IObservable<System.Globalization.CultureInfo> culture)
        {
            return Observable.Zip(_ConstructorInfoValue, invokeAttr, binder, parameters, culture,
                (_ConstructorInfoValueLambda, invokeAttrLambda, binderLambda, parametersLambda, cultureLambda) =>
                    _ConstructorInfoValueLambda.Invoke_4(invokeAttrLambda, binderLambda, parametersLambda, cultureLambda));
        }


        public static IObservable<System.Object> Invoke_5(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue,
            IObservable<System.Object[]> parameters)
        {
            return Observable.Zip(_ConstructorInfoValue, parameters,
                (_ConstructorInfoValueLambda, parametersLambda) =>
                    _ConstructorInfoValueLambda.Invoke_5(parametersLambda));
        }


        public static IObservable<System.Reflection.MemberTypes> get_MemberType(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.MemberType);
        }


        public static IObservable<System.String> get_Name(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.Name);
        }


        public static IObservable<System.Type> get_DeclaringType(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.DeclaringType);
        }


        public static IObservable<System.Type> get_ReflectedType(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.ReflectedType);
        }


        public static IObservable<System.RuntimeMethodHandle> get_MethodHandle(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.MethodHandle);
        }


        public static IObservable<System.Reflection.MethodAttributes> get_Attributes(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.Attributes);
        }


        public static IObservable<System.Reflection.CallingConventions> get_CallingConvention(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.CallingConvention);
        }


        public static IObservable<System.Boolean> get_IsPublic(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.IsPublic);
        }


        public static IObservable<System.Boolean> get_IsPrivate(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.IsPrivate);
        }


        public static IObservable<System.Boolean> get_IsFamily(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.IsFamily);
        }


        public static IObservable<System.Boolean> get_IsAssembly(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.IsAssembly);
        }


        public static IObservable<System.Boolean> get_IsFamilyAndAssembly(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.IsFamilyAndAssembly);
        }


        public static IObservable<System.Boolean> get_IsFamilyOrAssembly(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.IsFamilyOrAssembly);
        }


        public static IObservable<System.Boolean> get_IsStatic(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.IsStatic);
        }


        public static IObservable<System.Boolean> get_IsFinal(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.IsFinal);
        }


        public static IObservable<System.Boolean> get_IsVirtual(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.IsVirtual);
        }


        public static IObservable<System.Boolean> get_IsHideBySig(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.IsHideBySig);
        }


        public static IObservable<System.Boolean> get_IsAbstract(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.IsAbstract);
        }


        public static IObservable<System.Boolean> get_IsSpecialName(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.IsSpecialName);
        }


        public static IObservable<System.Boolean> get_IsConstructor(
            this IObservable<System.Runtime.InteropServices._ConstructorInfo> _ConstructorInfoValue)
        {
            return Observable.Select(_ConstructorInfoValue,
                (_ConstructorInfoValueLambda) => _ConstructorInfoValueLambda.IsConstructor);
        }
    }
}