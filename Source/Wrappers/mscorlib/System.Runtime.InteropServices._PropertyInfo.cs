using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class ___PropertyInfo
    {
        public static IObservable<System.UInt32> GetTypeInfoCount(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue)
        {
            return Observable.Select(_PropertyInfoValue, (_PropertyInfoValueLambda) =>
            {
                System.UInt32 pcTInfoOutput = default(System.UInt32);
                _PropertyInfoValueLambda.GetTypeInfoCount(out pcTInfoOutput);
                return pcTInfoOutput;
            });
        }


        public static IObservable<System.Reactive.Unit> GetTypeInfo(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue,
            IObservable<System.UInt32> iTInfo, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> ppTInfo)
        {
            return ObservableExt.ZipExecute(_PropertyInfoValue, iTInfo, lcid, ppTInfo,
                (_PropertyInfoValueLambda, iTInfoLambda, lcidLambda, ppTInfoLambda) =>
                    _PropertyInfoValueLambda.GetTypeInfo(iTInfoLambda, lcidLambda, ppTInfoLambda));
        }


        public static IObservable<System.Guid> GetIDsOfNames(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue,
            IObservable<System.Guid> riid, IObservable<System.IntPtr> rgszNames, IObservable<System.UInt32> cNames,
            IObservable<System.UInt32> lcid, IObservable<System.IntPtr> rgDispId)
        {
            return Observable.Zip(_PropertyInfoValue, riid, rgszNames, cNames, lcid, rgDispId,
                (_PropertyInfoValueLambda, riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda) =>
                {
                    _PropertyInfoValueLambda.GetIDsOfNames(ref riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda,
                        rgDispIdLambda);
                    return riidLambda;
                });
        }


        public static IObservable<System.Guid> Invoke(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue,
            IObservable<System.UInt32> dispIdMember, IObservable<System.Guid> riid, IObservable<System.UInt32> lcid,
            IObservable<System.Int16> wFlags, IObservable<System.IntPtr> pDispParams,
            IObservable<System.IntPtr> pVarResult, IObservable<System.IntPtr> pExcepInfo,
            IObservable<System.IntPtr> puArgErr)
        {
            return Observable.Zip(_PropertyInfoValue, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult,
                pExcepInfo, puArgErr,
                (_PropertyInfoValueLambda, dispIdMemberLambda, riidLambda, lcidLambda, wFlagsLambda, pDispParamsLambda,
                    pVarResultLambda, pExcepInfoLambda, puArgErrLambda) =>
                {
                    _PropertyInfoValueLambda.Invoke(dispIdMemberLambda, ref riidLambda, lcidLambda, wFlagsLambda,
                        pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda);
                    return riidLambda;
                });
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue)
        {
            return Observable.Select(_PropertyInfoValue,
                (_PropertyInfoValueLambda) => _PropertyInfoValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue,
            IObservable<System.Object> other)
        {
            return Observable.Zip(_PropertyInfoValue, other,
                (_PropertyInfoValueLambda, otherLambda) => _PropertyInfoValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue)
        {
            return Observable.Select(_PropertyInfoValue,
                (_PropertyInfoValueLambda) => _PropertyInfoValueLambda.GetHashCode());
        }


        public static IObservable<System.Type> GetType(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue)
        {
            return Observable.Select(_PropertyInfoValue,
                (_PropertyInfoValueLambda) => _PropertyInfoValueLambda.GetType());
        }


        public static IObservable<System.Object[]> GetCustomAttributes(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_PropertyInfoValue, attributeType, inherit,
                (_PropertyInfoValueLambda, attributeTypeLambda, inheritLambda) =>
                    _PropertyInfoValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Object[]> GetCustomAttributes(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue,
            IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_PropertyInfoValue, inherit,
                (_PropertyInfoValueLambda, inheritLambda) => _PropertyInfoValueLambda.GetCustomAttributes(inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_PropertyInfoValue, attributeType, inherit,
                (_PropertyInfoValueLambda, attributeTypeLambda, inheritLambda) =>
                    _PropertyInfoValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Object> GetValue(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue,
            IObservable<System.Object> obj, IObservable<System.Object[]> index)
        {
            return Observable.Zip(_PropertyInfoValue, obj, index,
                (_PropertyInfoValueLambda, objLambda, indexLambda) =>
                    _PropertyInfoValueLambda.GetValue(objLambda, indexLambda));
        }


        public static IObservable<System.Object> GetValue(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue,
            IObservable<System.Object> obj, IObservable<System.Reflection.BindingFlags> invokeAttr,
            IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> index,
            IObservable<System.Globalization.CultureInfo> culture)
        {
            return Observable.Zip(_PropertyInfoValue, obj, invokeAttr, binder, index, culture,
                (_PropertyInfoValueLambda, objLambda, invokeAttrLambda, binderLambda, indexLambda, cultureLambda) =>
                    _PropertyInfoValueLambda.GetValue(objLambda, invokeAttrLambda, binderLambda, indexLambda,
                        cultureLambda));
        }


        public static IObservable<System.Reactive.Unit> SetValue(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue,
            IObservable<System.Object> obj, IObservable<System.Object> value, IObservable<System.Object[]> index)
        {
            return ObservableExt.ZipExecute(_PropertyInfoValue, obj, value, index,
                (_PropertyInfoValueLambda, objLambda, valueLambda, indexLambda) =>
                    _PropertyInfoValueLambda.SetValue(objLambda, valueLambda, indexLambda));
        }


        public static IObservable<System.Reactive.Unit> SetValue(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue,
            IObservable<System.Object> obj, IObservable<System.Object> value,
            IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder,
            IObservable<System.Object[]> index, IObservable<System.Globalization.CultureInfo> culture)
        {
            return ObservableExt.ZipExecute(_PropertyInfoValue, obj, value, invokeAttr, binder, index, culture,
                (_PropertyInfoValueLambda, objLambda, valueLambda, invokeAttrLambda, binderLambda, indexLambda,
                    cultureLambda) =>
                    _PropertyInfoValueLambda.SetValue(objLambda, valueLambda, invokeAttrLambda, binderLambda,
                        indexLambda, cultureLambda));
        }


        public static IObservable<System.Reflection.MethodInfo[]> GetAccessors(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue,
            IObservable<System.Boolean> nonPublic)
        {
            return Observable.Zip(_PropertyInfoValue, nonPublic,
                (_PropertyInfoValueLambda, nonPublicLambda) => _PropertyInfoValueLambda.GetAccessors(nonPublicLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetGetMethod(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue,
            IObservable<System.Boolean> nonPublic)
        {
            return Observable.Zip(_PropertyInfoValue, nonPublic,
                (_PropertyInfoValueLambda, nonPublicLambda) => _PropertyInfoValueLambda.GetGetMethod(nonPublicLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetSetMethod(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue,
            IObservable<System.Boolean> nonPublic)
        {
            return Observable.Zip(_PropertyInfoValue, nonPublic,
                (_PropertyInfoValueLambda, nonPublicLambda) => _PropertyInfoValueLambda.GetSetMethod(nonPublicLambda));
        }


        public static IObservable<System.Reflection.ParameterInfo[]> GetIndexParameters(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue)
        {
            return Observable.Select(_PropertyInfoValue,
                (_PropertyInfoValueLambda) => _PropertyInfoValueLambda.GetIndexParameters());
        }


        public static IObservable<System.Reflection.MethodInfo[]> GetAccessors(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue)
        {
            return Observable.Select(_PropertyInfoValue,
                (_PropertyInfoValueLambda) => _PropertyInfoValueLambda.GetAccessors());
        }


        public static IObservable<System.Reflection.MethodInfo> GetGetMethod(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue)
        {
            return Observable.Select(_PropertyInfoValue,
                (_PropertyInfoValueLambda) => _PropertyInfoValueLambda.GetGetMethod());
        }


        public static IObservable<System.Reflection.MethodInfo> GetSetMethod(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue)
        {
            return Observable.Select(_PropertyInfoValue,
                (_PropertyInfoValueLambda) => _PropertyInfoValueLambda.GetSetMethod());
        }


        public static IObservable<System.Reflection.MemberTypes> get_MemberType(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue)
        {
            return Observable.Select(_PropertyInfoValue,
                (_PropertyInfoValueLambda) => _PropertyInfoValueLambda.MemberType);
        }


        public static IObservable<System.String> get_Name(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue)
        {
            return Observable.Select(_PropertyInfoValue, (_PropertyInfoValueLambda) => _PropertyInfoValueLambda.Name);
        }


        public static IObservable<System.Type> get_DeclaringType(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue)
        {
            return Observable.Select(_PropertyInfoValue,
                (_PropertyInfoValueLambda) => _PropertyInfoValueLambda.DeclaringType);
        }


        public static IObservable<System.Type> get_ReflectedType(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue)
        {
            return Observable.Select(_PropertyInfoValue,
                (_PropertyInfoValueLambda) => _PropertyInfoValueLambda.ReflectedType);
        }


        public static IObservable<System.Type> get_PropertyType(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue)
        {
            return Observable.Select(_PropertyInfoValue,
                (_PropertyInfoValueLambda) => _PropertyInfoValueLambda.PropertyType);
        }


        public static IObservable<System.Reflection.PropertyAttributes> get_Attributes(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue)
        {
            return Observable.Select(_PropertyInfoValue,
                (_PropertyInfoValueLambda) => _PropertyInfoValueLambda.Attributes);
        }


        public static IObservable<System.Boolean> get_CanRead(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue)
        {
            return Observable.Select(_PropertyInfoValue, (_PropertyInfoValueLambda) => _PropertyInfoValueLambda.CanRead);
        }


        public static IObservable<System.Boolean> get_CanWrite(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue)
        {
            return Observable.Select(_PropertyInfoValue, (_PropertyInfoValueLambda) => _PropertyInfoValueLambda.CanWrite);
        }


        public static IObservable<System.Boolean> get_IsSpecialName(
            this IObservable<System.Runtime.InteropServices._PropertyInfo> _PropertyInfoValue)
        {
            return Observable.Select(_PropertyInfoValue,
                (_PropertyInfoValueLambda) => _PropertyInfoValueLambda.IsSpecialName);
        }
    }
}