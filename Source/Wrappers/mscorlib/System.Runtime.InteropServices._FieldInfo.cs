using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class ___FieldInfo
    {
        public static IObservable<System.UInt32> GetTypeInfoCount(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) =>
            {
                System.UInt32 pcTInfoOutput = default(System.UInt32);
                _FieldInfoValueLambda.GetTypeInfoCount(out pcTInfoOutput);
                return pcTInfoOutput;
            });
        }


        public static IObservable<System.Reactive.Unit> GetTypeInfo(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue,
            IObservable<System.UInt32> iTInfo, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> ppTInfo)
        {
            return ObservableExt.ZipExecute(_FieldInfoValue, iTInfo, lcid, ppTInfo,
                (_FieldInfoValueLambda, iTInfoLambda, lcidLambda, ppTInfoLambda) =>
                    _FieldInfoValueLambda.GetTypeInfo(iTInfoLambda, lcidLambda, ppTInfoLambda));
        }


        public static IObservable<System.Guid> GetIDsOfNames(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue, IObservable<System.Guid> riid,
            IObservable<System.IntPtr> rgszNames, IObservable<System.UInt32> cNames, IObservable<System.UInt32> lcid,
            IObservable<System.IntPtr> rgDispId)
        {
            return Observable.Zip(_FieldInfoValue, riid, rgszNames, cNames, lcid, rgDispId,
                (_FieldInfoValueLambda, riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda) =>
                {
                    _FieldInfoValueLambda.GetIDsOfNames(ref riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda,
                        rgDispIdLambda);
                    return riidLambda;
                });
        }


        public static IObservable<System.Guid> Invoke(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue,
            IObservable<System.UInt32> dispIdMember, IObservable<System.Guid> riid, IObservable<System.UInt32> lcid,
            IObservable<System.Int16> wFlags, IObservable<System.IntPtr> pDispParams,
            IObservable<System.IntPtr> pVarResult, IObservable<System.IntPtr> pExcepInfo,
            IObservable<System.IntPtr> puArgErr)
        {
            return Observable.Zip(_FieldInfoValue, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo,
                puArgErr,
                (_FieldInfoValueLambda, dispIdMemberLambda, riidLambda, lcidLambda, wFlagsLambda, pDispParamsLambda,
                    pVarResultLambda, pExcepInfoLambda, puArgErrLambda) =>
                {
                    _FieldInfoValueLambda.Invoke(dispIdMemberLambda, ref riidLambda, lcidLambda, wFlagsLambda,
                        pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda);
                    return riidLambda;
                });
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue,
            IObservable<System.Object> other)
        {
            return Observable.Zip(_FieldInfoValue, other,
                (_FieldInfoValueLambda, otherLambda) => _FieldInfoValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.GetHashCode());
        }


        public static IObservable<System.Type> GetType(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.GetType());
        }


        public static IObservable<System.Object[]> GetCustomAttributes(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_FieldInfoValue, attributeType, inherit,
                (_FieldInfoValueLambda, attributeTypeLambda, inheritLambda) =>
                    _FieldInfoValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Object[]> GetCustomAttributes(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue,
            IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_FieldInfoValue, inherit,
                (_FieldInfoValueLambda, inheritLambda) => _FieldInfoValueLambda.GetCustomAttributes(inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_FieldInfoValue, attributeType, inherit,
                (_FieldInfoValueLambda, attributeTypeLambda, inheritLambda) =>
                    _FieldInfoValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Object> GetValue(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(_FieldInfoValue, obj,
                (_FieldInfoValueLambda, objLambda) => _FieldInfoValueLambda.GetValue(objLambda));
        }


        public static IObservable<System.Reactive.Unit> SetValue(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue, IObservable<System.Object> obj,
            IObservable<System.Object> value, IObservable<System.Reflection.BindingFlags> invokeAttr,
            IObservable<System.Reflection.Binder> binder, IObservable<System.Globalization.CultureInfo> culture)
        {
            return ObservableExt.ZipExecute(_FieldInfoValue, obj, value, invokeAttr, binder, culture,
                (_FieldInfoValueLambda, objLambda, valueLambda, invokeAttrLambda, binderLambda, cultureLambda) =>
                    _FieldInfoValueLambda.SetValue(objLambda, valueLambda, invokeAttrLambda, binderLambda, cultureLambda));
        }


        public static IObservable<System.Reactive.Unit> SetValue(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue, IObservable<System.Object> obj,
            IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(_FieldInfoValue, obj, value,
                (_FieldInfoValueLambda, objLambda, valueLambda) =>
                    _FieldInfoValueLambda.SetValue(objLambda, valueLambda));
        }


        public static IObservable<System.Reflection.MemberTypes> get_MemberType(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.MemberType);
        }


        public static IObservable<System.String> get_Name(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.Name);
        }


        public static IObservable<System.Type> get_DeclaringType(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.DeclaringType);
        }


        public static IObservable<System.Type> get_ReflectedType(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.ReflectedType);
        }


        public static IObservable<System.Type> get_FieldType(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.FieldType);
        }


        public static IObservable<System.RuntimeFieldHandle> get_FieldHandle(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.FieldHandle);
        }


        public static IObservable<System.Reflection.FieldAttributes> get_Attributes(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.Attributes);
        }


        public static IObservable<System.Boolean> get_IsPublic(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.IsPublic);
        }


        public static IObservable<System.Boolean> get_IsPrivate(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.IsPrivate);
        }


        public static IObservable<System.Boolean> get_IsFamily(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.IsFamily);
        }


        public static IObservable<System.Boolean> get_IsAssembly(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.IsAssembly);
        }


        public static IObservable<System.Boolean> get_IsFamilyAndAssembly(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue,
                (_FieldInfoValueLambda) => _FieldInfoValueLambda.IsFamilyAndAssembly);
        }


        public static IObservable<System.Boolean> get_IsFamilyOrAssembly(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue,
                (_FieldInfoValueLambda) => _FieldInfoValueLambda.IsFamilyOrAssembly);
        }


        public static IObservable<System.Boolean> get_IsStatic(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.IsStatic);
        }


        public static IObservable<System.Boolean> get_IsInitOnly(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.IsInitOnly);
        }


        public static IObservable<System.Boolean> get_IsLiteral(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.IsLiteral);
        }


        public static IObservable<System.Boolean> get_IsNotSerialized(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.IsNotSerialized);
        }


        public static IObservable<System.Boolean> get_IsSpecialName(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.IsSpecialName);
        }


        public static IObservable<System.Boolean> get_IsPinvokeImpl(
            this IObservable<System.Runtime.InteropServices._FieldInfo> _FieldInfoValue)
        {
            return Observable.Select(_FieldInfoValue, (_FieldInfoValueLambda) => _FieldInfoValueLambda.IsPinvokeImpl);
        }
    }
}