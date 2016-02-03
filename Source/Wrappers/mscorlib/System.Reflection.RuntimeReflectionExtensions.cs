using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __RuntimeReflectionExtensions
    {
        public static IObservable<System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo>>
            GetRuntimeProperties(IObservable<System.Type> type)
        {
            return Observable.Select(type,
                (typeLambda) => System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperties(typeLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Reflection.EventInfo>> GetRuntimeEvents(
            IObservable<System.Type> type)
        {
            return Observable.Select(type,
                (typeLambda) => System.Reflection.RuntimeReflectionExtensions.GetRuntimeEvents(typeLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>>
            GetRuntimeMethods(IObservable<System.Type> type)
        {
            return Observable.Select(type,
                (typeLambda) => System.Reflection.RuntimeReflectionExtensions.GetRuntimeMethods(typeLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo>> GetRuntimeFields(
            IObservable<System.Type> type)
        {
            return Observable.Select(type,
                (typeLambda) => System.Reflection.RuntimeReflectionExtensions.GetRuntimeFields(typeLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo> GetRuntimeProperty(IObservable<System.Type> type,
            IObservable<System.String> name)
        {
            return Observable.Zip(type, name,
                (typeLambda, nameLambda) =>
                    System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperty(typeLambda, nameLambda));
        }


        public static IObservable<System.Reflection.EventInfo> GetRuntimeEvent(IObservable<System.Type> type,
            IObservable<System.String> name)
        {
            return Observable.Zip(type, name,
                (typeLambda, nameLambda) =>
                    System.Reflection.RuntimeReflectionExtensions.GetRuntimeEvent(typeLambda, nameLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetRuntimeMethod(IObservable<System.Type> type,
            IObservable<System.String> name, IObservable<System.Type[]> parameters)
        {
            return Observable.Zip(type, name, parameters,
                (typeLambda, nameLambda, parametersLambda) =>
                    System.Reflection.RuntimeReflectionExtensions.GetRuntimeMethod(typeLambda, nameLambda,
                        parametersLambda));
        }


        public static IObservable<System.Reflection.FieldInfo> GetRuntimeField(IObservable<System.Type> type,
            IObservable<System.String> name)
        {
            return Observable.Zip(type, name,
                (typeLambda, nameLambda) =>
                    System.Reflection.RuntimeReflectionExtensions.GetRuntimeField(typeLambda, nameLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetRuntimeBaseDefinition(
            IObservable<System.Reflection.MethodInfo> method)
        {
            return Observable.Select(method,
                (methodLambda) => System.Reflection.RuntimeReflectionExtensions.GetRuntimeBaseDefinition(methodLambda));
        }


        public static IObservable<System.Reflection.InterfaceMapping> GetRuntimeInterfaceMap(
            IObservable<System.Reflection.TypeInfo> typeInfo, IObservable<System.Type> interfaceType)
        {
            return Observable.Zip(typeInfo, interfaceType,
                (typeInfoLambda, interfaceTypeLambda) =>
                    System.Reflection.RuntimeReflectionExtensions.GetRuntimeInterfaceMap(typeInfoLambda,
                        interfaceTypeLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetMethodInfo(IObservable<System.Delegate> del)
        {
            return Observable.Select(del,
                (delLambda) => System.Reflection.RuntimeReflectionExtensions.GetMethodInfo(delLambda));
        }
    }
}