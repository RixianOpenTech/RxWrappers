using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __MethodInfo
    {
        
        public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.MethodInfo> MethodInfoValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(MethodInfoValue, obj, (MethodInfoValueLambda, objLambda) => MethodInfoValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.MethodInfo> MethodInfoValue)
        {
            return Observable.Select(MethodInfoValue, (MethodInfoValueLambda) => MethodInfoValueLambda.GetHashCode());
        }


        public static IObservable<System.Reflection.MethodInfo> GetBaseDefinition(this IObservable<System.Reflection.MethodInfo> MethodInfoValue)
        {
            return Observable.Select(MethodInfoValue, (MethodInfoValueLambda) => MethodInfoValueLambda.GetBaseDefinition());
        }


        public static IObservable<System.Type[]> GetGenericArguments(this IObservable<System.Reflection.MethodInfo> MethodInfoValue)
        {
            return Observable.Select(MethodInfoValue, (MethodInfoValueLambda) => MethodInfoValueLambda.GetGenericArguments());
        }


        public static IObservable<System.Reflection.MethodInfo> GetGenericMethodDefinition(this IObservable<System.Reflection.MethodInfo> MethodInfoValue)
        {
            return Observable.Select(MethodInfoValue, (MethodInfoValueLambda) => MethodInfoValueLambda.GetGenericMethodDefinition());
        }


        public static IObservable<System.Reflection.MethodInfo> MakeGenericMethod(this IObservable<System.Reflection.MethodInfo> MethodInfoValue, IObservable<System.Type[]> typeArguments)
        {
            return Observable.Zip(MethodInfoValue, typeArguments, (MethodInfoValueLambda, typeArgumentsLambda) => MethodInfoValueLambda.MakeGenericMethod(typeArgumentsLambda));
        }


        public static IObservable<System.Delegate> CreateDelegate(this IObservable<System.Reflection.MethodInfo> MethodInfoValue, IObservable<System.Type> delegateType)
        {
            return Observable.Zip(MethodInfoValue, delegateType, (MethodInfoValueLambda, delegateTypeLambda) => MethodInfoValueLambda.CreateDelegate(delegateTypeLambda));
        }


        public static IObservable<System.Delegate> CreateDelegate(this IObservable<System.Reflection.MethodInfo> MethodInfoValue, IObservable<System.Type> delegateType, IObservable<System.Object> target)
        {
            return Observable.Zip(MethodInfoValue, delegateType, target, (MethodInfoValueLambda, delegateTypeLambda, targetLambda) => MethodInfoValueLambda.CreateDelegate(delegateTypeLambda, targetLambda));
        }


        public static IObservable<System.Reflection.MemberTypes> get_MemberType(this IObservable<System.Reflection.MethodInfo> MethodInfoValue)
        {
            return Observable.Select(MethodInfoValue, (MethodInfoValueLambda) => MethodInfoValueLambda.MemberType);
        }


        public static IObservable<System.Type> get_ReturnType(this IObservable<System.Reflection.MethodInfo> MethodInfoValue)
        {
            return Observable.Select(MethodInfoValue, (MethodInfoValueLambda) => MethodInfoValueLambda.ReturnType);
        }


        public static IObservable<System.Reflection.ParameterInfo> get_ReturnParameter(this IObservable<System.Reflection.MethodInfo> MethodInfoValue)
        {
            return Observable.Select(MethodInfoValue, (MethodInfoValueLambda) => MethodInfoValueLambda.ReturnParameter);
        }


        public static IObservable<System.Reflection.ICustomAttributeProvider> get_ReturnTypeCustomAttributes(this IObservable<System.Reflection.MethodInfo> MethodInfoValue)
        {
            return Observable.Select(MethodInfoValue, (MethodInfoValueLambda) => MethodInfoValueLambda.ReturnTypeCustomAttributes);
        }

    }
}