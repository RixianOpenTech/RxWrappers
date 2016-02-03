using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Type
    {
        public static IObservable<System.Type> GetType(IObservable<System.String> typeName,
            IObservable<System.Boolean> throwOnError, IObservable<System.Boolean> ignoreCase)
        {
            return Observable.Zip(typeName, throwOnError, ignoreCase,
                (typeNameLambda, throwOnErrorLambda, ignoreCaseLambda) =>
                    System.Type.GetType(typeNameLambda, throwOnErrorLambda, ignoreCaseLambda));
        }


        public static IObservable<System.Type> GetType(IObservable<System.String> typeName,
            IObservable<System.Boolean> throwOnError)
        {
            return Observable.Zip(typeName, throwOnError,
                (typeNameLambda, throwOnErrorLambda) => System.Type.GetType(typeNameLambda, throwOnErrorLambda));
        }


        public static IObservable<System.Type> GetType(IObservable<System.String> typeName)
        {
            return Observable.Select(typeName, (typeNameLambda) => System.Type.GetType(typeNameLambda));
        }


        public static IObservable<System.Type> GetType(IObservable<System.String> typeName,
            IObservable<System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly>> assemblyResolver,
            IObservable<System.Func<System.Reflection.Assembly, System.String, System.Boolean, System.Type>>
                typeResolver)
        {
            return Observable.Zip(typeName, assemblyResolver, typeResolver,
                (typeNameLambda, assemblyResolverLambda, typeResolverLambda) =>
                    System.Type.GetType(typeNameLambda, assemblyResolverLambda, typeResolverLambda));
        }


        public static IObservable<System.Type> GetType(IObservable<System.String> typeName,
            IObservable<System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly>> assemblyResolver,
            IObservable<System.Func<System.Reflection.Assembly, System.String, System.Boolean, System.Type>>
                typeResolver, IObservable<System.Boolean> throwOnError)
        {
            return Observable.Zip(typeName, assemblyResolver, typeResolver, throwOnError,
                (typeNameLambda, assemblyResolverLambda, typeResolverLambda, throwOnErrorLambda) =>
                    System.Type.GetType(typeNameLambda, assemblyResolverLambda, typeResolverLambda, throwOnErrorLambda));
        }


        public static IObservable<System.Type> GetType(IObservable<System.String> typeName,
            IObservable<System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly>> assemblyResolver,
            IObservable<System.Func<System.Reflection.Assembly, System.String, System.Boolean, System.Type>>
                typeResolver, IObservable<System.Boolean> throwOnError, IObservable<System.Boolean> ignoreCase)
        {
            return Observable.Zip(typeName, assemblyResolver, typeResolver, throwOnError, ignoreCase,
                (typeNameLambda, assemblyResolverLambda, typeResolverLambda, throwOnErrorLambda, ignoreCaseLambda) =>
                    System.Type.GetType(typeNameLambda, assemblyResolverLambda, typeResolverLambda, throwOnErrorLambda,
                        ignoreCaseLambda));
        }


        public static IObservable<System.Type> ReflectionOnlyGetType(IObservable<System.String> typeName,
            IObservable<System.Boolean> throwIfNotFound, IObservable<System.Boolean> ignoreCase)
        {
            return Observable.Zip(typeName, throwIfNotFound, ignoreCase,
                (typeNameLambda, throwIfNotFoundLambda, ignoreCaseLambda) =>
                    System.Type.ReflectionOnlyGetType(typeNameLambda, throwIfNotFoundLambda, ignoreCaseLambda));
        }


        public static IObservable<System.Type> MakePointerType(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.MakePointerType());
        }


        public static IObservable<System.Type> MakeByRefType(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.MakeByRefType());
        }


        public static IObservable<System.Type> MakeArrayType(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.MakeArrayType());
        }


        public static IObservable<System.Type> MakeArrayType(this IObservable<System.Type> TypeValue,
            IObservable<System.Int32> rank)
        {
            return Observable.Zip(TypeValue, rank,
                (TypeValueLambda, rankLambda) => TypeValueLambda.MakeArrayType(rankLambda));
        }


        public static IObservable<System.Type> GetTypeFromProgID(IObservable<System.String> progID)
        {
            return Observable.Select(progID, (progIDLambda) => System.Type.GetTypeFromProgID(progIDLambda));
        }


        public static IObservable<System.Type> GetTypeFromProgID(IObservable<System.String> progID,
            IObservable<System.Boolean> throwOnError)
        {
            return Observable.Zip(progID, throwOnError,
                (progIDLambda, throwOnErrorLambda) => System.Type.GetTypeFromProgID(progIDLambda, throwOnErrorLambda));
        }


        public static IObservable<System.Type> GetTypeFromProgID(IObservable<System.String> progID,
            IObservable<System.String> server)
        {
            return Observable.Zip(progID, server,
                (progIDLambda, serverLambda) => System.Type.GetTypeFromProgID(progIDLambda, serverLambda));
        }


        public static IObservable<System.Type> GetTypeFromProgID(IObservable<System.String> progID,
            IObservable<System.String> server, IObservable<System.Boolean> throwOnError)
        {
            return Observable.Zip(progID, server, throwOnError,
                (progIDLambda, serverLambda, throwOnErrorLambda) =>
                    System.Type.GetTypeFromProgID(progIDLambda, serverLambda, throwOnErrorLambda));
        }


        public static IObservable<System.Type> GetTypeFromCLSID(IObservable<System.Guid> clsid)
        {
            return Observable.Select(clsid, (clsidLambda) => System.Type.GetTypeFromCLSID(clsidLambda));
        }


        public static IObservable<System.Type> GetTypeFromCLSID(IObservable<System.Guid> clsid,
            IObservable<System.Boolean> throwOnError)
        {
            return Observable.Zip(clsid, throwOnError,
                (clsidLambda, throwOnErrorLambda) => System.Type.GetTypeFromCLSID(clsidLambda, throwOnErrorLambda));
        }


        public static IObservable<System.Type> GetTypeFromCLSID(IObservable<System.Guid> clsid,
            IObservable<System.String> server)
        {
            return Observable.Zip(clsid, server,
                (clsidLambda, serverLambda) => System.Type.GetTypeFromCLSID(clsidLambda, serverLambda));
        }


        public static IObservable<System.Type> GetTypeFromCLSID(IObservable<System.Guid> clsid,
            IObservable<System.String> server, IObservable<System.Boolean> throwOnError)
        {
            return Observable.Zip(clsid, server, throwOnError,
                (clsidLambda, serverLambda, throwOnErrorLambda) =>
                    System.Type.GetTypeFromCLSID(clsidLambda, serverLambda, throwOnErrorLambda));
        }


        public static IObservable<System.TypeCode> GetTypeCode(IObservable<System.Type> type)
        {
            return Observable.Select(type, (typeLambda) => System.Type.GetTypeCode(typeLambda));
        }


        public static IObservable<System.Object> InvokeMember(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> invokeAttr,
            IObservable<System.Reflection.Binder> binder, IObservable<System.Object> target,
            IObservable<System.Object[]> args, IObservable<System.Reflection.ParameterModifier[]> modifiers,
            IObservable<System.Globalization.CultureInfo> culture, IObservable<System.String[]> namedParameters)
        {
            return Observable.Zip(TypeValue, name, invokeAttr, binder, target, args, modifiers, culture, namedParameters,
                (TypeValueLambda, nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda, modifiersLambda,
                    cultureLambda, namedParametersLambda) =>
                    TypeValueLambda.InvokeMember(nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda,
                        modifiersLambda, cultureLambda, namedParametersLambda));
        }


        public static IObservable<System.Object> InvokeMember(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> invokeAttr,
            IObservable<System.Reflection.Binder> binder, IObservable<System.Object> target,
            IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture)
        {
            return Observable.Zip(TypeValue, name, invokeAttr, binder, target, args, culture,
                (TypeValueLambda, nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda, cultureLambda)
                    =>
                    TypeValueLambda.InvokeMember(nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda,
                        cultureLambda));
        }


        public static IObservable<System.Object> InvokeMember(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> invokeAttr,
            IObservable<System.Reflection.Binder> binder, IObservable<System.Object> target,
            IObservable<System.Object[]> args)
        {
            return Observable.Zip(TypeValue, name, invokeAttr, binder, target, args,
                (TypeValueLambda, nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda) =>
                    TypeValueLambda.InvokeMember(nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda));
        }


        public static IObservable<System.RuntimeTypeHandle> GetTypeHandle(IObservable<System.Object> o)
        {
            return Observable.Select(o, (oLambda) => System.Type.GetTypeHandle(oLambda));
        }


        public static IObservable<System.Type> GetTypeFromHandle(IObservable<System.RuntimeTypeHandle> handle)
        {
            return Observable.Select(handle, (handleLambda) => System.Type.GetTypeFromHandle(handleLambda));
        }


        public static IObservable<System.Int32> GetArrayRank(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GetArrayRank());
        }


        public static IObservable<System.Reflection.ConstructorInfo> GetConstructor(
            this IObservable<System.Type> TypeValue, IObservable<System.Reflection.BindingFlags> bindingAttr,
            IObservable<System.Reflection.Binder> binder,
            IObservable<System.Reflection.CallingConventions> callConvention, IObservable<System.Type[]> types,
            IObservable<System.Reflection.ParameterModifier[]> modifiers)
        {
            return Observable.Zip(TypeValue, bindingAttr, binder, callConvention, types, modifiers,
                (TypeValueLambda, bindingAttrLambda, binderLambda, callConventionLambda, typesLambda, modifiersLambda)
                    =>
                    TypeValueLambda.GetConstructor(bindingAttrLambda, binderLambda, callConventionLambda, typesLambda,
                        modifiersLambda));
        }


        public static IObservable<System.Reflection.ConstructorInfo> GetConstructor(
            this IObservable<System.Type> TypeValue, IObservable<System.Reflection.BindingFlags> bindingAttr,
            IObservable<System.Reflection.Binder> binder, IObservable<System.Type[]> types,
            IObservable<System.Reflection.ParameterModifier[]> modifiers)
        {
            return Observable.Zip(TypeValue, bindingAttr, binder, types, modifiers,
                (TypeValueLambda, bindingAttrLambda, binderLambda, typesLambda, modifiersLambda) =>
                    TypeValueLambda.GetConstructor(bindingAttrLambda, binderLambda, typesLambda, modifiersLambda));
        }


        public static IObservable<System.Reflection.ConstructorInfo> GetConstructor(
            this IObservable<System.Type> TypeValue, IObservable<System.Type[]> types)
        {
            return Observable.Zip(TypeValue, types,
                (TypeValueLambda, typesLambda) => TypeValueLambda.GetConstructor(typesLambda));
        }


        public static IObservable<System.Reflection.ConstructorInfo[]> GetConstructors(
            this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GetConstructors());
        }


        public static IObservable<System.Reflection.ConstructorInfo[]> GetConstructors(
            this IObservable<System.Type> TypeValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeValue, bindingAttr,
                (TypeValueLambda, bindingAttrLambda) => TypeValueLambda.GetConstructors(bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetMethod(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr,
            IObservable<System.Reflection.Binder> binder,
            IObservable<System.Reflection.CallingConventions> callConvention, IObservable<System.Type[]> types,
            IObservable<System.Reflection.ParameterModifier[]> modifiers)
        {
            return Observable.Zip(TypeValue, name, bindingAttr, binder, callConvention, types, modifiers,
                (TypeValueLambda, nameLambda, bindingAttrLambda, binderLambda, callConventionLambda, typesLambda,
                    modifiersLambda) =>
                    TypeValueLambda.GetMethod(nameLambda, bindingAttrLambda, binderLambda, callConventionLambda,
                        typesLambda, modifiersLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetMethod(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr,
            IObservable<System.Reflection.Binder> binder, IObservable<System.Type[]> types,
            IObservable<System.Reflection.ParameterModifier[]> modifiers)
        {
            return Observable.Zip(TypeValue, name, bindingAttr, binder, types, modifiers,
                (TypeValueLambda, nameLambda, bindingAttrLambda, binderLambda, typesLambda, modifiersLambda) =>
                    TypeValueLambda.GetMethod(nameLambda, bindingAttrLambda, binderLambda, typesLambda, modifiersLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetMethod(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Type[]> types,
            IObservable<System.Reflection.ParameterModifier[]> modifiers)
        {
            return Observable.Zip(TypeValue, name, types, modifiers,
                (TypeValueLambda, nameLambda, typesLambda, modifiersLambda) =>
                    TypeValueLambda.GetMethod(nameLambda, typesLambda, modifiersLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetMethod(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Type[]> types)
        {
            return Observable.Zip(TypeValue, name, types,
                (TypeValueLambda, nameLambda, typesLambda) => TypeValueLambda.GetMethod(nameLambda, typesLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetMethod(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeValue, name, bindingAttr,
                (TypeValueLambda, nameLambda, bindingAttrLambda) =>
                    TypeValueLambda.GetMethod(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetMethod(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name)
        {
            return Observable.Zip(TypeValue, name,
                (TypeValueLambda, nameLambda) => TypeValueLambda.GetMethod(nameLambda));
        }


        public static IObservable<System.Reflection.MethodInfo[]> GetMethods(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GetMethods());
        }


        public static IObservable<System.Reflection.MethodInfo[]> GetMethods(this IObservable<System.Type> TypeValue,
            IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeValue, bindingAttr,
                (TypeValueLambda, bindingAttrLambda) => TypeValueLambda.GetMethods(bindingAttrLambda));
        }


        public static IObservable<System.Reflection.FieldInfo> GetField(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeValue, name, bindingAttr,
                (TypeValueLambda, nameLambda, bindingAttrLambda) =>
                    TypeValueLambda.GetField(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.FieldInfo> GetField(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name)
        {
            return Observable.Zip(TypeValue, name, (TypeValueLambda, nameLambda) => TypeValueLambda.GetField(nameLambda));
        }


        public static IObservable<System.Reflection.FieldInfo[]> GetFields(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GetFields());
        }


        public static IObservable<System.Reflection.FieldInfo[]> GetFields(this IObservable<System.Type> TypeValue,
            IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeValue, bindingAttr,
                (TypeValueLambda, bindingAttrLambda) => TypeValueLambda.GetFields(bindingAttrLambda));
        }


        public static IObservable<System.Type> GetInterface(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name)
        {
            return Observable.Zip(TypeValue, name,
                (TypeValueLambda, nameLambda) => TypeValueLambda.GetInterface(nameLambda));
        }


        public static IObservable<System.Type> GetInterface(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Boolean> ignoreCase)
        {
            return Observable.Zip(TypeValue, name, ignoreCase,
                (TypeValueLambda, nameLambda, ignoreCaseLambda) =>
                    TypeValueLambda.GetInterface(nameLambda, ignoreCaseLambda));
        }


        public static IObservable<System.Type[]> GetInterfaces(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GetInterfaces());
        }


        public static IObservable<System.Type[]> FindInterfaces(this IObservable<System.Type> TypeValue,
            IObservable<System.Reflection.TypeFilter> filter, IObservable<System.Object> filterCriteria)
        {
            return Observable.Zip(TypeValue, filter, filterCriteria,
                (TypeValueLambda, filterLambda, filterCriteriaLambda) =>
                    TypeValueLambda.FindInterfaces(filterLambda, filterCriteriaLambda));
        }


        public static IObservable<System.Reflection.EventInfo> GetEvent(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name)
        {
            return Observable.Zip(TypeValue, name, (TypeValueLambda, nameLambda) => TypeValueLambda.GetEvent(nameLambda));
        }


        public static IObservable<System.Reflection.EventInfo> GetEvent(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeValue, name, bindingAttr,
                (TypeValueLambda, nameLambda, bindingAttrLambda) =>
                    TypeValueLambda.GetEvent(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.EventInfo[]> GetEvents(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GetEvents());
        }


        public static IObservable<System.Reflection.EventInfo[]> GetEvents(this IObservable<System.Type> TypeValue,
            IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeValue, bindingAttr,
                (TypeValueLambda, bindingAttrLambda) => TypeValueLambda.GetEvents(bindingAttrLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo> GetProperty(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr,
            IObservable<System.Reflection.Binder> binder, IObservable<System.Type> returnType,
            IObservable<System.Type[]> types, IObservable<System.Reflection.ParameterModifier[]> modifiers)
        {
            return Observable.Zip(TypeValue, name, bindingAttr, binder, returnType, types, modifiers,
                (TypeValueLambda, nameLambda, bindingAttrLambda, binderLambda, returnTypeLambda, typesLambda,
                    modifiersLambda) =>
                    TypeValueLambda.GetProperty(nameLambda, bindingAttrLambda, binderLambda, returnTypeLambda,
                        typesLambda, modifiersLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo> GetProperty(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Type> returnType, IObservable<System.Type[]> types,
            IObservable<System.Reflection.ParameterModifier[]> modifiers)
        {
            return Observable.Zip(TypeValue, name, returnType, types, modifiers,
                (TypeValueLambda, nameLambda, returnTypeLambda, typesLambda, modifiersLambda) =>
                    TypeValueLambda.GetProperty(nameLambda, returnTypeLambda, typesLambda, modifiersLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo> GetProperty(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeValue, name, bindingAttr,
                (TypeValueLambda, nameLambda, bindingAttrLambda) =>
                    TypeValueLambda.GetProperty(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo> GetProperty(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Type> returnType, IObservable<System.Type[]> types)
        {
            return Observable.Zip(TypeValue, name, returnType, types,
                (TypeValueLambda, nameLambda, returnTypeLambda, typesLambda) =>
                    TypeValueLambda.GetProperty(nameLambda, returnTypeLambda, typesLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo> GetProperty(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Type[]> types)
        {
            return Observable.Zip(TypeValue, name, types,
                (TypeValueLambda, nameLambda, typesLambda) => TypeValueLambda.GetProperty(nameLambda, typesLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo> GetProperty(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Type> returnType)
        {
            return Observable.Zip(TypeValue, name, returnType,
                (TypeValueLambda, nameLambda, returnTypeLambda) =>
                    TypeValueLambda.GetProperty(nameLambda, returnTypeLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo> GetProperty(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name)
        {
            return Observable.Zip(TypeValue, name,
                (TypeValueLambda, nameLambda) => TypeValueLambda.GetProperty(nameLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo[]> GetProperties(
            this IObservable<System.Type> TypeValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeValue, bindingAttr,
                (TypeValueLambda, bindingAttrLambda) => TypeValueLambda.GetProperties(bindingAttrLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo[]> GetProperties(
            this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GetProperties());
        }


        public static IObservable<System.Type[]> GetNestedTypes(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GetNestedTypes());
        }


        public static IObservable<System.Type[]> GetNestedTypes(this IObservable<System.Type> TypeValue,
            IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeValue, bindingAttr,
                (TypeValueLambda, bindingAttrLambda) => TypeValueLambda.GetNestedTypes(bindingAttrLambda));
        }


        public static IObservable<System.Type> GetNestedType(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name)
        {
            return Observable.Zip(TypeValue, name,
                (TypeValueLambda, nameLambda) => TypeValueLambda.GetNestedType(nameLambda));
        }


        public static IObservable<System.Type> GetNestedType(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeValue, name, bindingAttr,
                (TypeValueLambda, nameLambda, bindingAttrLambda) =>
                    TypeValueLambda.GetNestedType(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MemberInfo[]> GetMember(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name)
        {
            return Observable.Zip(TypeValue, name,
                (TypeValueLambda, nameLambda) => TypeValueLambda.GetMember(nameLambda));
        }


        public static IObservable<System.Reflection.MemberInfo[]> GetMember(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeValue, name, bindingAttr,
                (TypeValueLambda, nameLambda, bindingAttrLambda) =>
                    TypeValueLambda.GetMember(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MemberInfo[]> GetMember(this IObservable<System.Type> TypeValue,
            IObservable<System.String> name, IObservable<System.Reflection.MemberTypes> type,
            IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeValue, name, type, bindingAttr,
                (TypeValueLambda, nameLambda, typeLambda, bindingAttrLambda) =>
                    TypeValueLambda.GetMember(nameLambda, typeLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MemberInfo[]> GetMembers(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GetMembers());
        }


        public static IObservable<System.Reflection.MemberInfo[]> GetMembers(this IObservable<System.Type> TypeValue,
            IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeValue, bindingAttr,
                (TypeValueLambda, bindingAttrLambda) => TypeValueLambda.GetMembers(bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MemberInfo[]> GetDefaultMembers(
            this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GetDefaultMembers());
        }


        public static IObservable<System.Reflection.MemberInfo[]> FindMembers(this IObservable<System.Type> TypeValue,
            IObservable<System.Reflection.MemberTypes> memberType,
            IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.MemberFilter> filter,
            IObservable<System.Object> filterCriteria)
        {
            return Observable.Zip(TypeValue, memberType, bindingAttr, filter, filterCriteria,
                (TypeValueLambda, memberTypeLambda, bindingAttrLambda, filterLambda, filterCriteriaLambda) =>
                    TypeValueLambda.FindMembers(memberTypeLambda, bindingAttrLambda, filterLambda, filterCriteriaLambda));
        }


        public static IObservable<System.Type[]> GetGenericParameterConstraints(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GetGenericParameterConstraints());
        }


        public static IObservable<System.Type> MakeGenericType(this IObservable<System.Type> TypeValue,
            IObservable<System.Type[]> typeArguments)
        {
            return Observable.Zip(TypeValue, typeArguments,
                (TypeValueLambda, typeArgumentsLambda) => TypeValueLambda.MakeGenericType(typeArgumentsLambda));
        }


        public static IObservable<System.Type> GetElementType(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GetElementType());
        }


        public static IObservable<System.Type[]> GetGenericArguments(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GetGenericArguments());
        }


        public static IObservable<System.Type> GetGenericTypeDefinition(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GetGenericTypeDefinition());
        }


        public static IObservable<System.String[]> GetEnumNames(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GetEnumNames());
        }


        public static IObservable<System.Array> GetEnumValues(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GetEnumValues());
        }


        public static IObservable<System.Type> GetEnumUnderlyingType(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GetEnumUnderlyingType());
        }


        public static IObservable<System.Boolean> IsEnumDefined(this IObservable<System.Type> TypeValue,
            IObservable<System.Object> value)
        {
            return Observable.Zip(TypeValue, value,
                (TypeValueLambda, valueLambda) => TypeValueLambda.IsEnumDefined(valueLambda));
        }


        public static IObservable<System.String> GetEnumName(this IObservable<System.Type> TypeValue,
            IObservable<System.Object> value)
        {
            return Observable.Zip(TypeValue, value,
                (TypeValueLambda, valueLambda) => TypeValueLambda.GetEnumName(valueLambda));
        }


        public static IObservable<System.Boolean> IsSubclassOf(this IObservable<System.Type> TypeValue,
            IObservable<System.Type> c)
        {
            return Observable.Zip(TypeValue, c, (TypeValueLambda, cLambda) => TypeValueLambda.IsSubclassOf(cLambda));
        }


        public static IObservable<System.Boolean> IsInstanceOfType(this IObservable<System.Type> TypeValue,
            IObservable<System.Object> o)
        {
            return Observable.Zip(TypeValue, o, (TypeValueLambda, oLambda) => TypeValueLambda.IsInstanceOfType(oLambda));
        }


        public static IObservable<System.Boolean> IsAssignableFrom(this IObservable<System.Type> TypeValue,
            IObservable<System.Type> c)
        {
            return Observable.Zip(TypeValue, c, (TypeValueLambda, cLambda) => TypeValueLambda.IsAssignableFrom(cLambda));
        }


        public static IObservable<System.Boolean> IsEquivalentTo(this IObservable<System.Type> TypeValue,
            IObservable<System.Type> other)
        {
            return Observable.Zip(TypeValue, other,
                (TypeValueLambda, otherLambda) => TypeValueLambda.IsEquivalentTo(otherLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.ToString());
        }


        public static IObservable<System.Type[]> GetTypeArray(IObservable<System.Object[]> args)
        {
            return Observable.Select(args, (argsLambda) => System.Type.GetTypeArray(argsLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Type> TypeValue,
            IObservable<System.Object> o)
        {
            return Observable.Zip(TypeValue, o, (TypeValueLambda, oLambda) => TypeValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Type> TypeValue,
            IObservable<System.Type> o)
        {
            return Observable.Zip(TypeValue, o, (TypeValueLambda, oLambda) => TypeValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GetHashCode());
        }


        public static IObservable<System.Reflection.InterfaceMapping> GetInterfaceMap(
            this IObservable<System.Type> TypeValue, IObservable<System.Type> interfaceType)
        {
            return Observable.Zip(TypeValue, interfaceType,
                (TypeValueLambda, interfaceTypeLambda) => TypeValueLambda.GetInterfaceMap(interfaceTypeLambda));
        }


        public static IObservable<System.Type> GetType(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GetType());
        }


        public static IObservable<System.Reflection.MemberTypes> get_MemberType(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.MemberType);
        }


        public static IObservable<System.Type> get_DeclaringType(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.DeclaringType);
        }


        public static IObservable<System.Reflection.MethodBase> get_DeclaringMethod(
            this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.DeclaringMethod);
        }


        public static IObservable<System.Type> get_ReflectedType(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.ReflectedType);
        }


        public static IObservable<System.Runtime.InteropServices.StructLayoutAttribute> get_StructLayoutAttribute(
            this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.StructLayoutAttribute);
        }


        public static IObservable<System.Guid> get_GUID(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GUID);
        }


        public static IObservable<System.Reflection.Binder> get_DefaultBinder()
        {
            return ObservableExt.Factory(() => System.Type.DefaultBinder);
        }


        public static IObservable<System.Reflection.Module> get_Module(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.Module);
        }


        public static IObservable<System.Reflection.Assembly> get_Assembly(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.Assembly);
        }


        public static IObservable<System.RuntimeTypeHandle> get_TypeHandle(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.TypeHandle);
        }


        public static IObservable<System.String> get_FullName(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.FullName);
        }


        public static IObservable<System.String> get_Namespace(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.Namespace);
        }


        public static IObservable<System.String> get_AssemblyQualifiedName(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.AssemblyQualifiedName);
        }


        public static IObservable<System.Type> get_BaseType(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.BaseType);
        }


        public static IObservable<System.Reflection.ConstructorInfo> get_TypeInitializer(
            this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.TypeInitializer);
        }


        public static IObservable<System.Boolean> get_IsNested(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsNested);
        }


        public static IObservable<System.Reflection.TypeAttributes> get_Attributes(
            this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.Attributes);
        }


        public static IObservable<System.Reflection.GenericParameterAttributes> get_GenericParameterAttributes(
            this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GenericParameterAttributes);
        }


        public static IObservable<System.Boolean> get_IsVisible(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsVisible);
        }


        public static IObservable<System.Boolean> get_IsNotPublic(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsNotPublic);
        }


        public static IObservable<System.Boolean> get_IsPublic(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsPublic);
        }


        public static IObservable<System.Boolean> get_IsNestedPublic(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsNestedPublic);
        }


        public static IObservable<System.Boolean> get_IsNestedPrivate(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsNestedPrivate);
        }


        public static IObservable<System.Boolean> get_IsNestedFamily(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsNestedFamily);
        }


        public static IObservable<System.Boolean> get_IsNestedAssembly(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsNestedAssembly);
        }


        public static IObservable<System.Boolean> get_IsNestedFamANDAssem(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsNestedFamANDAssem);
        }


        public static IObservable<System.Boolean> get_IsNestedFamORAssem(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsNestedFamORAssem);
        }


        public static IObservable<System.Boolean> get_IsAutoLayout(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsAutoLayout);
        }


        public static IObservable<System.Boolean> get_IsLayoutSequential(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsLayoutSequential);
        }


        public static IObservable<System.Boolean> get_IsExplicitLayout(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsExplicitLayout);
        }


        public static IObservable<System.Boolean> get_IsClass(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsClass);
        }


        public static IObservable<System.Boolean> get_IsInterface(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsInterface);
        }


        public static IObservable<System.Boolean> get_IsValueType(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsValueType);
        }


        public static IObservable<System.Boolean> get_IsAbstract(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsAbstract);
        }


        public static IObservable<System.Boolean> get_IsSealed(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsSealed);
        }


        public static IObservable<System.Boolean> get_IsEnum(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsEnum);
        }


        public static IObservable<System.Boolean> get_IsSpecialName(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsSpecialName);
        }


        public static IObservable<System.Boolean> get_IsImport(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsImport);
        }


        public static IObservable<System.Boolean> get_IsSerializable(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsSerializable);
        }


        public static IObservable<System.Boolean> get_IsAnsiClass(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsAnsiClass);
        }


        public static IObservable<System.Boolean> get_IsUnicodeClass(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsUnicodeClass);
        }


        public static IObservable<System.Boolean> get_IsAutoClass(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsAutoClass);
        }


        public static IObservable<System.Boolean> get_IsArray(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsArray);
        }


        public static IObservable<System.Boolean> get_IsGenericType(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsGenericType);
        }


        public static IObservable<System.Boolean> get_IsGenericTypeDefinition(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsGenericTypeDefinition);
        }


        public static IObservable<System.Boolean> get_IsConstructedGenericType(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsConstructedGenericType);
        }


        public static IObservable<System.Boolean> get_IsGenericParameter(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsGenericParameter);
        }


        public static IObservable<System.Int32> get_GenericParameterPosition(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GenericParameterPosition);
        }


        public static IObservable<System.Boolean> get_ContainsGenericParameters(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.ContainsGenericParameters);
        }


        public static IObservable<System.Boolean> get_IsByRef(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsByRef);
        }


        public static IObservable<System.Boolean> get_IsPointer(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsPointer);
        }


        public static IObservable<System.Boolean> get_IsPrimitive(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsPrimitive);
        }


        public static IObservable<System.Boolean> get_IsCOMObject(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsCOMObject);
        }


        public static IObservable<System.Boolean> get_HasElementType(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.HasElementType);
        }


        public static IObservable<System.Boolean> get_IsContextful(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsContextful);
        }


        public static IObservable<System.Boolean> get_IsMarshalByRef(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsMarshalByRef);
        }


        public static IObservable<System.Type[]> get_GenericTypeArguments(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.GenericTypeArguments);
        }


        public static IObservable<System.Boolean> get_IsSecurityCritical(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsSecurityCritical);
        }


        public static IObservable<System.Boolean> get_IsSecuritySafeCritical(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsSecuritySafeCritical);
        }


        public static IObservable<System.Boolean> get_IsSecurityTransparent(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.IsSecurityTransparent);
        }


        public static IObservable<System.Type> get_UnderlyingSystemType(this IObservable<System.Type> TypeValue)
        {
            return Observable.Select(TypeValue, (TypeValueLambda) => TypeValueLambda.UnderlyingSystemType);
        }
    }
}