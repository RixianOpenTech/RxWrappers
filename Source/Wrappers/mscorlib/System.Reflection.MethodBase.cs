using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __MethodBase
    {
        public static IObservable<System.Reflection.MethodBase> GetMethodFromHandle(
            IObservable<System.RuntimeMethodHandle> handle)
        {
            return Observable.Select(handle,
                (handleLambda) => System.Reflection.MethodBase.GetMethodFromHandle(handleLambda));
        }


        public static IObservable<System.Reflection.MethodBase> GetMethodFromHandle(
            IObservable<System.RuntimeMethodHandle> handle, IObservable<System.RuntimeTypeHandle> declaringType)
        {
            return Observable.Zip(handle, declaringType,
                (handleLambda, declaringTypeLambda) =>
                    System.Reflection.MethodBase.GetMethodFromHandle(handleLambda, declaringTypeLambda));
        }


        public static IObservable<System.Reflection.MethodBase> GetCurrentMethod()
        {
            return ObservableExt.Factory(() => System.Reflection.MethodBase.GetCurrentMethod());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.MethodBase> MethodBaseValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(MethodBaseValue, obj,
                (MethodBaseValueLambda, objLambda) => MethodBaseValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue, (MethodBaseValueLambda) => MethodBaseValueLambda.GetHashCode());
        }


        public static IObservable<System.Reflection.ParameterInfo[]> GetParameters(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue, (MethodBaseValueLambda) => MethodBaseValueLambda.GetParameters());
        }


        public static IObservable<System.Reflection.MethodImplAttributes> GetMethodImplementationFlags(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue,
                (MethodBaseValueLambda) => MethodBaseValueLambda.GetMethodImplementationFlags());
        }


        public static IObservable<System.Object> Invoke(this IObservable<System.Reflection.MethodBase> MethodBaseValue,
            IObservable<System.Object> obj, IObservable<System.Reflection.BindingFlags> invokeAttr,
            IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> parameters,
            IObservable<System.Globalization.CultureInfo> culture)
        {
            return Observable.Zip(MethodBaseValue, obj, invokeAttr, binder, parameters, culture,
                (MethodBaseValueLambda, objLambda, invokeAttrLambda, binderLambda, parametersLambda, cultureLambda) =>
                    MethodBaseValueLambda.Invoke(objLambda, invokeAttrLambda, binderLambda, parametersLambda,
                        cultureLambda));
        }


        public static IObservable<System.Type[]> GetGenericArguments(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue,
                (MethodBaseValueLambda) => MethodBaseValueLambda.GetGenericArguments());
        }


        public static IObservable<System.Object> Invoke(this IObservable<System.Reflection.MethodBase> MethodBaseValue,
            IObservable<System.Object> obj, IObservable<System.Object[]> parameters)
        {
            return Observable.Zip(MethodBaseValue, obj, parameters,
                (MethodBaseValueLambda, objLambda, parametersLambda) =>
                    MethodBaseValueLambda.Invoke(objLambda, parametersLambda));
        }


        public static IObservable<System.Reflection.MethodBody> GetMethodBody(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue, (MethodBaseValueLambda) => MethodBaseValueLambda.GetMethodBody());
        }


        public static IObservable<System.Reflection.MethodImplAttributes> get_MethodImplementationFlags(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue,
                (MethodBaseValueLambda) => MethodBaseValueLambda.MethodImplementationFlags);
        }


        public static IObservable<System.RuntimeMethodHandle> get_MethodHandle(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue, (MethodBaseValueLambda) => MethodBaseValueLambda.MethodHandle);
        }


        public static IObservable<System.Reflection.MethodAttributes> get_Attributes(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue, (MethodBaseValueLambda) => MethodBaseValueLambda.Attributes);
        }


        public static IObservable<System.Reflection.CallingConventions> get_CallingConvention(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue, (MethodBaseValueLambda) => MethodBaseValueLambda.CallingConvention);
        }


        public static IObservable<System.Boolean> get_IsGenericMethodDefinition(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue,
                (MethodBaseValueLambda) => MethodBaseValueLambda.IsGenericMethodDefinition);
        }


        public static IObservable<System.Boolean> get_ContainsGenericParameters(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue,
                (MethodBaseValueLambda) => MethodBaseValueLambda.ContainsGenericParameters);
        }


        public static IObservable<System.Boolean> get_IsGenericMethod(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue, (MethodBaseValueLambda) => MethodBaseValueLambda.IsGenericMethod);
        }


        public static IObservable<System.Boolean> get_IsSecurityCritical(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue,
                (MethodBaseValueLambda) => MethodBaseValueLambda.IsSecurityCritical);
        }


        public static IObservable<System.Boolean> get_IsSecuritySafeCritical(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue,
                (MethodBaseValueLambda) => MethodBaseValueLambda.IsSecuritySafeCritical);
        }


        public static IObservable<System.Boolean> get_IsSecurityTransparent(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue,
                (MethodBaseValueLambda) => MethodBaseValueLambda.IsSecurityTransparent);
        }


        public static IObservable<System.Boolean> get_IsPublic(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue, (MethodBaseValueLambda) => MethodBaseValueLambda.IsPublic);
        }


        public static IObservable<System.Boolean> get_IsPrivate(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue, (MethodBaseValueLambda) => MethodBaseValueLambda.IsPrivate);
        }


        public static IObservable<System.Boolean> get_IsFamily(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue, (MethodBaseValueLambda) => MethodBaseValueLambda.IsFamily);
        }


        public static IObservable<System.Boolean> get_IsAssembly(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue, (MethodBaseValueLambda) => MethodBaseValueLambda.IsAssembly);
        }


        public static IObservable<System.Boolean> get_IsFamilyAndAssembly(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue,
                (MethodBaseValueLambda) => MethodBaseValueLambda.IsFamilyAndAssembly);
        }


        public static IObservable<System.Boolean> get_IsFamilyOrAssembly(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue,
                (MethodBaseValueLambda) => MethodBaseValueLambda.IsFamilyOrAssembly);
        }


        public static IObservable<System.Boolean> get_IsStatic(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue, (MethodBaseValueLambda) => MethodBaseValueLambda.IsStatic);
        }


        public static IObservable<System.Boolean> get_IsFinal(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue, (MethodBaseValueLambda) => MethodBaseValueLambda.IsFinal);
        }


        public static IObservable<System.Boolean> get_IsVirtual(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue, (MethodBaseValueLambda) => MethodBaseValueLambda.IsVirtual);
        }


        public static IObservable<System.Boolean> get_IsHideBySig(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue, (MethodBaseValueLambda) => MethodBaseValueLambda.IsHideBySig);
        }


        public static IObservable<System.Boolean> get_IsAbstract(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue, (MethodBaseValueLambda) => MethodBaseValueLambda.IsAbstract);
        }


        public static IObservable<System.Boolean> get_IsSpecialName(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue, (MethodBaseValueLambda) => MethodBaseValueLambda.IsSpecialName);
        }


        public static IObservable<System.Boolean> get_IsConstructor(
            this IObservable<System.Reflection.MethodBase> MethodBaseValue)
        {
            return Observable.Select(MethodBaseValue, (MethodBaseValueLambda) => MethodBaseValueLambda.IsConstructor);
        }
    }
}