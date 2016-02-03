using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __TypeInfo
    {
        
        public static IObservable<System.Type> AsType(this IObservable<System.Reflection.TypeInfo> TypeInfoValue)
        {
            return Observable.Select(TypeInfoValue, (TypeInfoValueLambda) => TypeInfoValueLambda.AsType());
        }


        public static IObservable<System.Boolean> IsAssignableFrom(this IObservable<System.Reflection.TypeInfo> TypeInfoValue, IObservable<System.Reflection.TypeInfo> typeInfo)
        {
            return Observable.Zip(TypeInfoValue, typeInfo, (TypeInfoValueLambda, typeInfoLambda) => TypeInfoValueLambda.IsAssignableFrom(typeInfoLambda));
        }


        public static IObservable<System.Reflection.EventInfo> GetDeclaredEvent(this IObservable<System.Reflection.TypeInfo> TypeInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(TypeInfoValue, name, (TypeInfoValueLambda, nameLambda) => TypeInfoValueLambda.GetDeclaredEvent(nameLambda));
        }


        public static IObservable<System.Reflection.FieldInfo> GetDeclaredField(this IObservable<System.Reflection.TypeInfo> TypeInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(TypeInfoValue, name, (TypeInfoValueLambda, nameLambda) => TypeInfoValueLambda.GetDeclaredField(nameLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetDeclaredMethod(this IObservable<System.Reflection.TypeInfo> TypeInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(TypeInfoValue, name, (TypeInfoValueLambda, nameLambda) => TypeInfoValueLambda.GetDeclaredMethod(nameLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>> GetDeclaredMethods(this IObservable<System.Reflection.TypeInfo> TypeInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(TypeInfoValue, name, (TypeInfoValueLambda, nameLambda) => TypeInfoValueLambda.GetDeclaredMethods(nameLambda));
        }


        public static IObservable<System.Reflection.TypeInfo> GetDeclaredNestedType(this IObservable<System.Reflection.TypeInfo> TypeInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(TypeInfoValue, name, (TypeInfoValueLambda, nameLambda) => TypeInfoValueLambda.GetDeclaredNestedType(nameLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo> GetDeclaredProperty(this IObservable<System.Reflection.TypeInfo> TypeInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(TypeInfoValue, name, (TypeInfoValueLambda, nameLambda) => TypeInfoValueLambda.GetDeclaredProperty(nameLambda));
        }


        public static IObservable<System.Type[]> get_GenericTypeParameters(this IObservable<System.Reflection.TypeInfo> TypeInfoValue)
        {
            return Observable.Select(TypeInfoValue, (TypeInfoValueLambda) => TypeInfoValueLambda.GenericTypeParameters);
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Reflection.ConstructorInfo>> get_DeclaredConstructors(this IObservable<System.Reflection.TypeInfo> TypeInfoValue)
        {
            return Observable.Select(TypeInfoValue, (TypeInfoValueLambda) => TypeInfoValueLambda.DeclaredConstructors);
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Reflection.EventInfo>> get_DeclaredEvents(this IObservable<System.Reflection.TypeInfo> TypeInfoValue)
        {
            return Observable.Select(TypeInfoValue, (TypeInfoValueLambda) => TypeInfoValueLambda.DeclaredEvents);
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo>> get_DeclaredFields(this IObservable<System.Reflection.TypeInfo> TypeInfoValue)
        {
            return Observable.Select(TypeInfoValue, (TypeInfoValueLambda) => TypeInfoValueLambda.DeclaredFields);
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>> get_DeclaredMembers(this IObservable<System.Reflection.TypeInfo> TypeInfoValue)
        {
            return Observable.Select(TypeInfoValue, (TypeInfoValueLambda) => TypeInfoValueLambda.DeclaredMembers);
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>> get_DeclaredMethods(this IObservable<System.Reflection.TypeInfo> TypeInfoValue)
        {
            return Observable.Select(TypeInfoValue, (TypeInfoValueLambda) => TypeInfoValueLambda.DeclaredMethods);
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Reflection.TypeInfo>> get_DeclaredNestedTypes(this IObservable<System.Reflection.TypeInfo> TypeInfoValue)
        {
            return Observable.Select(TypeInfoValue, (TypeInfoValueLambda) => TypeInfoValueLambda.DeclaredNestedTypes);
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo>> get_DeclaredProperties(this IObservable<System.Reflection.TypeInfo> TypeInfoValue)
        {
            return Observable.Select(TypeInfoValue, (TypeInfoValueLambda) => TypeInfoValueLambda.DeclaredProperties);
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Type>> get_ImplementedInterfaces(this IObservable<System.Reflection.TypeInfo> TypeInfoValue)
        {
            return Observable.Select(TypeInfoValue, (TypeInfoValueLambda) => TypeInfoValueLambda.ImplementedInterfaces);
        }

    }
}