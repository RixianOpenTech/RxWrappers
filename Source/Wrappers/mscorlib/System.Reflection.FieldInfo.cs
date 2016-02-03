using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __FieldInfo
    {
        public static IObservable<System.Reflection.FieldInfo> GetFieldFromHandle(
            IObservable<System.RuntimeFieldHandle> handle)
        {
            return Observable.Select(handle,
                (handleLambda) => System.Reflection.FieldInfo.GetFieldFromHandle(handleLambda));
        }


        public static IObservable<System.Reflection.FieldInfo> GetFieldFromHandle(
            IObservable<System.RuntimeFieldHandle> handle, IObservable<System.RuntimeTypeHandle> declaringType)
        {
            return Observable.Zip(handle, declaringType,
                (handleLambda, declaringTypeLambda) =>
                    System.Reflection.FieldInfo.GetFieldFromHandle(handleLambda, declaringTypeLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.FieldInfo> FieldInfoValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(FieldInfoValue, obj,
                (FieldInfoValueLambda, objLambda) => FieldInfoValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue, (FieldInfoValueLambda) => FieldInfoValueLambda.GetHashCode());
        }


        public static IObservable<System.Type[]> GetRequiredCustomModifiers(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue,
                (FieldInfoValueLambda) => FieldInfoValueLambda.GetRequiredCustomModifiers());
        }


        public static IObservable<System.Type[]> GetOptionalCustomModifiers(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue,
                (FieldInfoValueLambda) => FieldInfoValueLambda.GetOptionalCustomModifiers());
        }


        public static IObservable<System.Object> GetValue(this IObservable<System.Reflection.FieldInfo> FieldInfoValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(FieldInfoValue, obj,
                (FieldInfoValueLambda, objLambda) => FieldInfoValueLambda.GetValue(objLambda));
        }


        public static IObservable<System.Object> GetRawConstantValue(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue,
                (FieldInfoValueLambda) => FieldInfoValueLambda.GetRawConstantValue());
        }


        public static IObservable<System.Reactive.Unit> SetValue(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue, IObservable<System.Object> obj,
            IObservable<System.Object> value, IObservable<System.Reflection.BindingFlags> invokeAttr,
            IObservable<System.Reflection.Binder> binder, IObservable<System.Globalization.CultureInfo> culture)
        {
            return ObservableExt.ZipExecute(FieldInfoValue, obj, value, invokeAttr, binder, culture,
                (FieldInfoValueLambda, objLambda, valueLambda, invokeAttrLambda, binderLambda, cultureLambda) =>
                    FieldInfoValueLambda.SetValue(objLambda, valueLambda, invokeAttrLambda, binderLambda, cultureLambda));
        }


        public static IObservable<System.Reactive.Unit> SetValue(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue, IObservable<System.Object> obj,
            IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(FieldInfoValue, obj, value,
                (FieldInfoValueLambda, objLambda, valueLambda) => FieldInfoValueLambda.SetValue(objLambda, valueLambda));
        }


        public static IObservable<System.Reflection.MemberTypes> get_MemberType(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue, (FieldInfoValueLambda) => FieldInfoValueLambda.MemberType);
        }


        public static IObservable<System.RuntimeFieldHandle> get_FieldHandle(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue, (FieldInfoValueLambda) => FieldInfoValueLambda.FieldHandle);
        }


        public static IObservable<System.Type> get_FieldType(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue, (FieldInfoValueLambda) => FieldInfoValueLambda.FieldType);
        }


        public static IObservable<System.Reflection.FieldAttributes> get_Attributes(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue, (FieldInfoValueLambda) => FieldInfoValueLambda.Attributes);
        }


        public static IObservable<System.Boolean> get_IsPublic(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue, (FieldInfoValueLambda) => FieldInfoValueLambda.IsPublic);
        }


        public static IObservable<System.Boolean> get_IsPrivate(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue, (FieldInfoValueLambda) => FieldInfoValueLambda.IsPrivate);
        }


        public static IObservable<System.Boolean> get_IsFamily(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue, (FieldInfoValueLambda) => FieldInfoValueLambda.IsFamily);
        }


        public static IObservable<System.Boolean> get_IsAssembly(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue, (FieldInfoValueLambda) => FieldInfoValueLambda.IsAssembly);
        }


        public static IObservable<System.Boolean> get_IsFamilyAndAssembly(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue, (FieldInfoValueLambda) => FieldInfoValueLambda.IsFamilyAndAssembly);
        }


        public static IObservable<System.Boolean> get_IsFamilyOrAssembly(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue, (FieldInfoValueLambda) => FieldInfoValueLambda.IsFamilyOrAssembly);
        }


        public static IObservable<System.Boolean> get_IsStatic(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue, (FieldInfoValueLambda) => FieldInfoValueLambda.IsStatic);
        }


        public static IObservable<System.Boolean> get_IsInitOnly(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue, (FieldInfoValueLambda) => FieldInfoValueLambda.IsInitOnly);
        }


        public static IObservable<System.Boolean> get_IsLiteral(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue, (FieldInfoValueLambda) => FieldInfoValueLambda.IsLiteral);
        }


        public static IObservable<System.Boolean> get_IsNotSerialized(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue, (FieldInfoValueLambda) => FieldInfoValueLambda.IsNotSerialized);
        }


        public static IObservable<System.Boolean> get_IsSpecialName(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue, (FieldInfoValueLambda) => FieldInfoValueLambda.IsSpecialName);
        }


        public static IObservable<System.Boolean> get_IsPinvokeImpl(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue, (FieldInfoValueLambda) => FieldInfoValueLambda.IsPinvokeImpl);
        }


        public static IObservable<System.Boolean> get_IsSecurityCritical(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue, (FieldInfoValueLambda) => FieldInfoValueLambda.IsSecurityCritical);
        }


        public static IObservable<System.Boolean> get_IsSecuritySafeCritical(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue,
                (FieldInfoValueLambda) => FieldInfoValueLambda.IsSecuritySafeCritical);
        }


        public static IObservable<System.Boolean> get_IsSecurityTransparent(
            this IObservable<System.Reflection.FieldInfo> FieldInfoValue)
        {
            return Observable.Select(FieldInfoValue,
                (FieldInfoValueLambda) => FieldInfoValueLambda.IsSecurityTransparent);
        }
    }
}