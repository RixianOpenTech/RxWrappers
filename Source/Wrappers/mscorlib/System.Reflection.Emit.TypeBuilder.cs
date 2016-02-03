using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
    public static class __TypeBuilder
    {
        
        public static IObservable<System.Boolean> IsAssignableFrom(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Reflection.TypeInfo> typeInfo)
        {
            return Observable.Zip(TypeBuilderValue, typeInfo, (TypeBuilderValueLambda, typeInfoLambda) => TypeBuilderValueLambda.IsAssignableFrom(typeInfoLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetMethod(IObservable<System.Type> type, IObservable<System.Reflection.MethodInfo> method)
        {
            return Observable.Zip(type, method, (typeLambda, methodLambda) => System.Reflection.Emit.TypeBuilder.GetMethod(typeLambda, methodLambda));
        }


        public static IObservable<System.Reflection.ConstructorInfo> GetConstructor(IObservable<System.Type> type, IObservable<System.Reflection.ConstructorInfo> constructor)
        {
            return Observable.Zip(type, constructor, (typeLambda, constructorLambda) => System.Reflection.Emit.TypeBuilder.GetConstructor(typeLambda, constructorLambda));
        }


        public static IObservable<System.Reflection.FieldInfo> GetField(IObservable<System.Type> type, IObservable<System.Reflection.FieldInfo> field)
        {
            return Observable.Zip(type, field, (typeLambda, fieldLambda) => System.Reflection.Emit.TypeBuilder.GetField(typeLambda, fieldLambda));
        }


        public static IObservable<System.Boolean> IsCreated(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.IsCreated());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.ToString());
        }


        public static IObservable<System.Object> InvokeMember(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object> target, IObservable<System.Object[]> args, IObservable<System.Reflection.ParameterModifier[]> modifiers, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.String[]> namedParameters)
        {
            return Observable.Zip(TypeBuilderValue, name, invokeAttr, binder, target, args, modifiers, culture, namedParameters, (TypeBuilderValueLambda, nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda, modifiersLambda, cultureLambda, namedParametersLambda) => TypeBuilderValueLambda.InvokeMember(nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda, modifiersLambda, cultureLambda, namedParametersLambda));
        }


        public static IObservable<System.Reflection.ConstructorInfo[]> GetConstructors(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeBuilderValue, bindingAttr, (TypeBuilderValueLambda, bindingAttrLambda) => TypeBuilderValueLambda.GetConstructors(bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MethodInfo[]> GetMethods(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeBuilderValue, bindingAttr, (TypeBuilderValueLambda, bindingAttrLambda) => TypeBuilderValueLambda.GetMethods(bindingAttrLambda));
        }


        public static IObservable<System.Reflection.FieldInfo> GetField(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeBuilderValue, name, bindingAttr, (TypeBuilderValueLambda, nameLambda, bindingAttrLambda) => TypeBuilderValueLambda.GetField(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.FieldInfo[]> GetFields(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeBuilderValue, bindingAttr, (TypeBuilderValueLambda, bindingAttrLambda) => TypeBuilderValueLambda.GetFields(bindingAttrLambda));
        }


        public static IObservable<System.Type> GetInterface(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Boolean> ignoreCase)
        {
            return Observable.Zip(TypeBuilderValue, name, ignoreCase, (TypeBuilderValueLambda, nameLambda, ignoreCaseLambda) => TypeBuilderValueLambda.GetInterface(nameLambda, ignoreCaseLambda));
        }


        public static IObservable<System.Type[]> GetInterfaces(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.GetInterfaces());
        }


        public static IObservable<System.Reflection.EventInfo> GetEvent(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeBuilderValue, name, bindingAttr, (TypeBuilderValueLambda, nameLambda, bindingAttrLambda) => TypeBuilderValueLambda.GetEvent(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.EventInfo[]> GetEvents(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.GetEvents());
        }


        public static IObservable<System.Reflection.PropertyInfo[]> GetProperties(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeBuilderValue, bindingAttr, (TypeBuilderValueLambda, bindingAttrLambda) => TypeBuilderValueLambda.GetProperties(bindingAttrLambda));
        }


        public static IObservable<System.Type[]> GetNestedTypes(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeBuilderValue, bindingAttr, (TypeBuilderValueLambda, bindingAttrLambda) => TypeBuilderValueLambda.GetNestedTypes(bindingAttrLambda));
        }


        public static IObservable<System.Type> GetNestedType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeBuilderValue, name, bindingAttr, (TypeBuilderValueLambda, nameLambda, bindingAttrLambda) => TypeBuilderValueLambda.GetNestedType(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MemberInfo[]> GetMember(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.MemberTypes> type, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeBuilderValue, name, type, bindingAttr, (TypeBuilderValueLambda, nameLambda, typeLambda, bindingAttrLambda) => TypeBuilderValueLambda.GetMember(nameLambda, typeLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.InterfaceMapping> GetInterfaceMap(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Type> interfaceType)
        {
            return Observable.Zip(TypeBuilderValue, interfaceType, (TypeBuilderValueLambda, interfaceTypeLambda) => TypeBuilderValueLambda.GetInterfaceMap(interfaceTypeLambda));
        }


        public static IObservable<System.Reflection.EventInfo[]> GetEvents(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeBuilderValue, bindingAttr, (TypeBuilderValueLambda, bindingAttrLambda) => TypeBuilderValueLambda.GetEvents(bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MemberInfo[]> GetMembers(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(TypeBuilderValue, bindingAttr, (TypeBuilderValueLambda, bindingAttrLambda) => TypeBuilderValueLambda.GetMembers(bindingAttrLambda));
        }


        public static IObservable<System.Boolean> IsAssignableFrom(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Type> c)
        {
            return Observable.Zip(TypeBuilderValue, c, (TypeBuilderValueLambda, cLambda) => TypeBuilderValueLambda.IsAssignableFrom(cLambda));
        }


        public static IObservable<System.Type> GetElementType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.GetElementType());
        }


        public static IObservable<System.Boolean> IsSubclassOf(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Type> c)
        {
            return Observable.Zip(TypeBuilderValue, c, (TypeBuilderValueLambda, cLambda) => TypeBuilderValueLambda.IsSubclassOf(cLambda));
        }


        public static IObservable<System.Type> MakePointerType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.MakePointerType());
        }


        public static IObservable<System.Type> MakeByRefType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.MakeByRefType());
        }


        public static IObservable<System.Type> MakeArrayType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.MakeArrayType());
        }


        public static IObservable<System.Type> MakeArrayType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Int32> rank)
        {
            return Observable.Zip(TypeBuilderValue, rank, (TypeBuilderValueLambda, rankLambda) => TypeBuilderValueLambda.MakeArrayType(rankLambda));
        }


        public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(TypeBuilderValue, inherit, (TypeBuilderValueLambda, inheritLambda) => TypeBuilderValueLambda.GetCustomAttributes(inheritLambda));
        }


        public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(TypeBuilderValue, attributeType, inherit, (TypeBuilderValueLambda, attributeTypeLambda, inheritLambda) => TypeBuilderValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(TypeBuilderValue, attributeType, inherit, (TypeBuilderValueLambda, attributeTypeLambda, inheritLambda) => TypeBuilderValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Reflection.Emit.GenericTypeParameterBuilder[]> DefineGenericParameters(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String[]> names)
        {
            return Observable.Zip(TypeBuilderValue, names, (TypeBuilderValueLambda, namesLambda) => TypeBuilderValueLambda.DefineGenericParameters(namesLambda));
        }


        public static IObservable<System.Type> MakeGenericType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Type[]> typeArguments)
        {
            return Observable.Zip(TypeBuilderValue, typeArguments, (TypeBuilderValueLambda, typeArgumentsLambda) => TypeBuilderValueLambda.MakeGenericType(typeArgumentsLambda));
        }


        public static IObservable<System.Type[]> GetGenericArguments(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.GetGenericArguments());
        }


        public static IObservable<System.Type> GetGenericTypeDefinition(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.GetGenericTypeDefinition());
        }


        public static IObservable<System.Reactive.Unit> DefineMethodOverride(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Reflection.MethodInfo> methodInfoBody, IObservable<System.Reflection.MethodInfo> methodInfoDeclaration)
        {
            return ObservableExt.ZipExecute(TypeBuilderValue, methodInfoBody, methodInfoDeclaration, (TypeBuilderValueLambda, methodInfoBodyLambda, methodInfoDeclarationLambda) => TypeBuilderValueLambda.DefineMethodOverride(methodInfoBodyLambda, methodInfoDeclarationLambda));
        }


        public static IObservable<System.Reflection.Emit.MethodBuilder> DefineMethod(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.MethodAttributes> attributes, IObservable<System.Type> returnType, IObservable<System.Type[]> parameterTypes)
        {
            return Observable.Zip(TypeBuilderValue, name, attributes, returnType, parameterTypes, (TypeBuilderValueLambda, nameLambda, attributesLambda, returnTypeLambda, parameterTypesLambda) => TypeBuilderValueLambda.DefineMethod(nameLambda, attributesLambda, returnTypeLambda, parameterTypesLambda));
        }


        public static IObservable<System.Reflection.Emit.MethodBuilder> DefineMethod(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.MethodAttributes> attributes)
        {
            return Observable.Zip(TypeBuilderValue, name, attributes, (TypeBuilderValueLambda, nameLambda, attributesLambda) => TypeBuilderValueLambda.DefineMethod(nameLambda, attributesLambda));
        }


        public static IObservable<System.Reflection.Emit.MethodBuilder> DefineMethod(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.MethodAttributes> attributes, IObservable<System.Reflection.CallingConventions> callingConvention)
        {
            return Observable.Zip(TypeBuilderValue, name, attributes, callingConvention, (TypeBuilderValueLambda, nameLambda, attributesLambda, callingConventionLambda) => TypeBuilderValueLambda.DefineMethod(nameLambda, attributesLambda, callingConventionLambda));
        }


        public static IObservable<System.Reflection.Emit.MethodBuilder> DefineMethod(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.MethodAttributes> attributes, IObservable<System.Reflection.CallingConventions> callingConvention, IObservable<System.Type> returnType, IObservable<System.Type[]> parameterTypes)
        {
            return Observable.Zip(TypeBuilderValue, name, attributes, callingConvention, returnType, parameterTypes, (TypeBuilderValueLambda, nameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, parameterTypesLambda) => TypeBuilderValueLambda.DefineMethod(nameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, parameterTypesLambda));
        }


        public static IObservable<System.Reflection.Emit.MethodBuilder> DefineMethod(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.MethodAttributes> attributes, IObservable<System.Reflection.CallingConventions> callingConvention, IObservable<System.Type> returnType, IObservable<System.Type[]> returnTypeRequiredCustomModifiers, IObservable<System.Type[]> returnTypeOptionalCustomModifiers, IObservable<System.Type[]> parameterTypes, IObservable<System.Type[][]> parameterTypeRequiredCustomModifiers, IObservable<System.Type[][]> parameterTypeOptionalCustomModifiers)
        {
            return Observable.Zip(TypeBuilderValue, name, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers, (TypeBuilderValueLambda, nameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, returnTypeRequiredCustomModifiersLambda, returnTypeOptionalCustomModifiersLambda, parameterTypesLambda, parameterTypeRequiredCustomModifiersLambda, parameterTypeOptionalCustomModifiersLambda) => TypeBuilderValueLambda.DefineMethod(nameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, returnTypeRequiredCustomModifiersLambda, returnTypeOptionalCustomModifiersLambda, parameterTypesLambda, parameterTypeRequiredCustomModifiersLambda, parameterTypeOptionalCustomModifiersLambda));
        }


        public static IObservable<System.Reflection.Emit.ConstructorBuilder> DefineTypeInitializer(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.DefineTypeInitializer());
        }


        public static IObservable<System.Reflection.Emit.ConstructorBuilder> DefineDefaultConstructor(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Reflection.MethodAttributes> attributes)
        {
            return Observable.Zip(TypeBuilderValue, attributes, (TypeBuilderValueLambda, attributesLambda) => TypeBuilderValueLambda.DefineDefaultConstructor(attributesLambda));
        }


        public static IObservable<System.Reflection.Emit.ConstructorBuilder> DefineConstructor(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Reflection.MethodAttributes> attributes, IObservable<System.Reflection.CallingConventions> callingConvention, IObservable<System.Type[]> parameterTypes)
        {
            return Observable.Zip(TypeBuilderValue, attributes, callingConvention, parameterTypes, (TypeBuilderValueLambda, attributesLambda, callingConventionLambda, parameterTypesLambda) => TypeBuilderValueLambda.DefineConstructor(attributesLambda, callingConventionLambda, parameterTypesLambda));
        }


        public static IObservable<System.Reflection.Emit.ConstructorBuilder> DefineConstructor(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Reflection.MethodAttributes> attributes, IObservable<System.Reflection.CallingConventions> callingConvention, IObservable<System.Type[]> parameterTypes, IObservable<System.Type[][]> requiredCustomModifiers, IObservable<System.Type[][]> optionalCustomModifiers)
        {
            return Observable.Zip(TypeBuilderValue, attributes, callingConvention, parameterTypes, requiredCustomModifiers, optionalCustomModifiers, (TypeBuilderValueLambda, attributesLambda, callingConventionLambda, parameterTypesLambda, requiredCustomModifiersLambda, optionalCustomModifiersLambda) => TypeBuilderValueLambda.DefineConstructor(attributesLambda, callingConventionLambda, parameterTypesLambda, requiredCustomModifiersLambda, optionalCustomModifiersLambda));
        }


        public static IObservable<System.Reflection.Emit.MethodBuilder> DefinePInvokeMethod(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.String> dllName, IObservable<System.Reflection.MethodAttributes> attributes, IObservable<System.Reflection.CallingConventions> callingConvention, IObservable<System.Type> returnType, IObservable<System.Type[]> parameterTypes, IObservable<System.Runtime.InteropServices.CallingConvention> nativeCallConv, IObservable<System.Runtime.InteropServices.CharSet> nativeCharSet)
        {
            return Observable.Zip(TypeBuilderValue, name, dllName, attributes, callingConvention, returnType, parameterTypes, nativeCallConv, nativeCharSet, (TypeBuilderValueLambda, nameLambda, dllNameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, parameterTypesLambda, nativeCallConvLambda, nativeCharSetLambda) => TypeBuilderValueLambda.DefinePInvokeMethod(nameLambda, dllNameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, parameterTypesLambda, nativeCallConvLambda, nativeCharSetLambda));
        }


        public static IObservable<System.Reflection.Emit.MethodBuilder> DefinePInvokeMethod(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.String> dllName, IObservable<System.String> entryName, IObservable<System.Reflection.MethodAttributes> attributes, IObservable<System.Reflection.CallingConventions> callingConvention, IObservable<System.Type> returnType, IObservable<System.Type[]> parameterTypes, IObservable<System.Runtime.InteropServices.CallingConvention> nativeCallConv, IObservable<System.Runtime.InteropServices.CharSet> nativeCharSet)
        {
            return Observable.Zip(TypeBuilderValue, name, dllName, entryName, attributes, callingConvention, returnType, parameterTypes, nativeCallConv, nativeCharSet, (TypeBuilderValueLambda, nameLambda, dllNameLambda, entryNameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, parameterTypesLambda, nativeCallConvLambda, nativeCharSetLambda) => TypeBuilderValueLambda.DefinePInvokeMethod(nameLambda, dllNameLambda, entryNameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, parameterTypesLambda, nativeCallConvLambda, nativeCharSetLambda));
        }


        public static IObservable<System.Reflection.Emit.MethodBuilder> DefinePInvokeMethod(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.String> dllName, IObservable<System.String> entryName, IObservable<System.Reflection.MethodAttributes> attributes, IObservable<System.Reflection.CallingConventions> callingConvention, IObservable<System.Type> returnType, IObservable<System.Type[]> returnTypeRequiredCustomModifiers, IObservable<System.Type[]> returnTypeOptionalCustomModifiers, IObservable<System.Type[]> parameterTypes, IObservable<System.Type[][]> parameterTypeRequiredCustomModifiers, IObservable<System.Type[][]> parameterTypeOptionalCustomModifiers, IObservable<System.Runtime.InteropServices.CallingConvention> nativeCallConv, IObservable<System.Runtime.InteropServices.CharSet> nativeCharSet)
        {
            return Observable.Zip(TypeBuilderValue, name, dllName, entryName, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers, nativeCallConv, nativeCharSet, (TypeBuilderValueLambda, nameLambda, dllNameLambda, entryNameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, returnTypeRequiredCustomModifiersLambda, returnTypeOptionalCustomModifiersLambda, parameterTypesLambda, parameterTypeRequiredCustomModifiersLambda, parameterTypeOptionalCustomModifiersLambda, nativeCallConvLambda, nativeCharSetLambda) => TypeBuilderValueLambda.DefinePInvokeMethod(nameLambda, dllNameLambda, entryNameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, returnTypeRequiredCustomModifiersLambda, returnTypeOptionalCustomModifiersLambda, parameterTypesLambda, parameterTypeRequiredCustomModifiersLambda, parameterTypeOptionalCustomModifiersLambda, nativeCallConvLambda, nativeCharSetLambda));
        }


        public static IObservable<System.Reflection.Emit.TypeBuilder> DefineNestedType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name)
        {
            return Observable.Zip(TypeBuilderValue, name, (TypeBuilderValueLambda, nameLambda) => TypeBuilderValueLambda.DefineNestedType(nameLambda));
        }


        public static IObservable<System.Reflection.Emit.TypeBuilder> DefineNestedType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.TypeAttributes> attr, IObservable<System.Type> parent, IObservable<System.Type[]> interfaces)
        {
            return Observable.Zip(TypeBuilderValue, name, attr, parent, interfaces, (TypeBuilderValueLambda, nameLambda, attrLambda, parentLambda, interfacesLambda) => TypeBuilderValueLambda.DefineNestedType(nameLambda, attrLambda, parentLambda, interfacesLambda));
        }


        public static IObservable<System.Reflection.Emit.TypeBuilder> DefineNestedType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.TypeAttributes> attr, IObservable<System.Type> parent)
        {
            return Observable.Zip(TypeBuilderValue, name, attr, parent, (TypeBuilderValueLambda, nameLambda, attrLambda, parentLambda) => TypeBuilderValueLambda.DefineNestedType(nameLambda, attrLambda, parentLambda));
        }


        public static IObservable<System.Reflection.Emit.TypeBuilder> DefineNestedType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.TypeAttributes> attr)
        {
            return Observable.Zip(TypeBuilderValue, name, attr, (TypeBuilderValueLambda, nameLambda, attrLambda) => TypeBuilderValueLambda.DefineNestedType(nameLambda, attrLambda));
        }


        public static IObservable<System.Reflection.Emit.TypeBuilder> DefineNestedType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.TypeAttributes> attr, IObservable<System.Type> parent, IObservable<System.Int32> typeSize)
        {
            return Observable.Zip(TypeBuilderValue, name, attr, parent, typeSize, (TypeBuilderValueLambda, nameLambda, attrLambda, parentLambda, typeSizeLambda) => TypeBuilderValueLambda.DefineNestedType(nameLambda, attrLambda, parentLambda, typeSizeLambda));
        }


        public static IObservable<System.Reflection.Emit.TypeBuilder> DefineNestedType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.TypeAttributes> attr, IObservable<System.Type> parent, IObservable<System.Reflection.Emit.PackingSize> packSize)
        {
            return Observable.Zip(TypeBuilderValue, name, attr, parent, packSize, (TypeBuilderValueLambda, nameLambda, attrLambda, parentLambda, packSizeLambda) => TypeBuilderValueLambda.DefineNestedType(nameLambda, attrLambda, parentLambda, packSizeLambda));
        }


        public static IObservable<System.Reflection.Emit.TypeBuilder> DefineNestedType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.TypeAttributes> attr, IObservable<System.Type> parent, IObservable<System.Reflection.Emit.PackingSize> packSize, IObservable<System.Int32> typeSize)
        {
            return Observable.Zip(TypeBuilderValue, name, attr, parent, packSize, typeSize, (TypeBuilderValueLambda, nameLambda, attrLambda, parentLambda, packSizeLambda, typeSizeLambda) => TypeBuilderValueLambda.DefineNestedType(nameLambda, attrLambda, parentLambda, packSizeLambda, typeSizeLambda));
        }


        public static IObservable<System.Reflection.Emit.FieldBuilder> DefineField(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> fieldName, IObservable<System.Type> type, IObservable<System.Reflection.FieldAttributes> attributes)
        {
            return Observable.Zip(TypeBuilderValue, fieldName, type, attributes, (TypeBuilderValueLambda, fieldNameLambda, typeLambda, attributesLambda) => TypeBuilderValueLambda.DefineField(fieldNameLambda, typeLambda, attributesLambda));
        }


        public static IObservable<System.Reflection.Emit.FieldBuilder> DefineField(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> fieldName, IObservable<System.Type> type, IObservable<System.Type[]> requiredCustomModifiers, IObservable<System.Type[]> optionalCustomModifiers, IObservable<System.Reflection.FieldAttributes> attributes)
        {
            return Observable.Zip(TypeBuilderValue, fieldName, type, requiredCustomModifiers, optionalCustomModifiers, attributes, (TypeBuilderValueLambda, fieldNameLambda, typeLambda, requiredCustomModifiersLambda, optionalCustomModifiersLambda, attributesLambda) => TypeBuilderValueLambda.DefineField(fieldNameLambda, typeLambda, requiredCustomModifiersLambda, optionalCustomModifiersLambda, attributesLambda));
        }


        public static IObservable<System.Reflection.Emit.FieldBuilder> DefineInitializedData(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Byte[]> data, IObservable<System.Reflection.FieldAttributes> attributes)
        {
            return Observable.Zip(TypeBuilderValue, name, data, attributes, (TypeBuilderValueLambda, nameLambda, dataLambda, attributesLambda) => TypeBuilderValueLambda.DefineInitializedData(nameLambda, dataLambda, attributesLambda));
        }


        public static IObservable<System.Reflection.Emit.FieldBuilder> DefineUninitializedData(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Int32> size, IObservable<System.Reflection.FieldAttributes> attributes)
        {
            return Observable.Zip(TypeBuilderValue, name, size, attributes, (TypeBuilderValueLambda, nameLambda, sizeLambda, attributesLambda) => TypeBuilderValueLambda.DefineUninitializedData(nameLambda, sizeLambda, attributesLambda));
        }


        public static IObservable<System.Reflection.Emit.PropertyBuilder> DefineProperty(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.PropertyAttributes> attributes, IObservable<System.Type> returnType, IObservable<System.Type[]> parameterTypes)
        {
            return Observable.Zip(TypeBuilderValue, name, attributes, returnType, parameterTypes, (TypeBuilderValueLambda, nameLambda, attributesLambda, returnTypeLambda, parameterTypesLambda) => TypeBuilderValueLambda.DefineProperty(nameLambda, attributesLambda, returnTypeLambda, parameterTypesLambda));
        }


        public static IObservable<System.Reflection.Emit.PropertyBuilder> DefineProperty(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.PropertyAttributes> attributes, IObservable<System.Reflection.CallingConventions> callingConvention, IObservable<System.Type> returnType, IObservable<System.Type[]> parameterTypes)
        {
            return Observable.Zip(TypeBuilderValue, name, attributes, callingConvention, returnType, parameterTypes, (TypeBuilderValueLambda, nameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, parameterTypesLambda) => TypeBuilderValueLambda.DefineProperty(nameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, parameterTypesLambda));
        }


        public static IObservable<System.Reflection.Emit.PropertyBuilder> DefineProperty(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.PropertyAttributes> attributes, IObservable<System.Type> returnType, IObservable<System.Type[]> returnTypeRequiredCustomModifiers, IObservable<System.Type[]> returnTypeOptionalCustomModifiers, IObservable<System.Type[]> parameterTypes, IObservable<System.Type[][]> parameterTypeRequiredCustomModifiers, IObservable<System.Type[][]> parameterTypeOptionalCustomModifiers)
        {
            return Observable.Zip(TypeBuilderValue, name, attributes, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers, (TypeBuilderValueLambda, nameLambda, attributesLambda, returnTypeLambda, returnTypeRequiredCustomModifiersLambda, returnTypeOptionalCustomModifiersLambda, parameterTypesLambda, parameterTypeRequiredCustomModifiersLambda, parameterTypeOptionalCustomModifiersLambda) => TypeBuilderValueLambda.DefineProperty(nameLambda, attributesLambda, returnTypeLambda, returnTypeRequiredCustomModifiersLambda, returnTypeOptionalCustomModifiersLambda, parameterTypesLambda, parameterTypeRequiredCustomModifiersLambda, parameterTypeOptionalCustomModifiersLambda));
        }


        public static IObservable<System.Reflection.Emit.PropertyBuilder> DefineProperty(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.PropertyAttributes> attributes, IObservable<System.Reflection.CallingConventions> callingConvention, IObservable<System.Type> returnType, IObservable<System.Type[]> returnTypeRequiredCustomModifiers, IObservable<System.Type[]> returnTypeOptionalCustomModifiers, IObservable<System.Type[]> parameterTypes, IObservable<System.Type[][]> parameterTypeRequiredCustomModifiers, IObservable<System.Type[][]> parameterTypeOptionalCustomModifiers)
        {
            return Observable.Zip(TypeBuilderValue, name, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers, (TypeBuilderValueLambda, nameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, returnTypeRequiredCustomModifiersLambda, returnTypeOptionalCustomModifiersLambda, parameterTypesLambda, parameterTypeRequiredCustomModifiersLambda, parameterTypeOptionalCustomModifiersLambda) => TypeBuilderValueLambda.DefineProperty(nameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, returnTypeRequiredCustomModifiersLambda, returnTypeOptionalCustomModifiersLambda, parameterTypesLambda, parameterTypeRequiredCustomModifiersLambda, parameterTypeOptionalCustomModifiersLambda));
        }


        public static IObservable<System.Reflection.Emit.EventBuilder> DefineEvent(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.EventAttributes> attributes, IObservable<System.Type> eventtype)
        {
            return Observable.Zip(TypeBuilderValue, name, attributes, eventtype, (TypeBuilderValueLambda, nameLambda, attributesLambda, eventtypeLambda) => TypeBuilderValueLambda.DefineEvent(nameLambda, attributesLambda, eventtypeLambda));
        }


        public static IObservable<System.Reflection.TypeInfo> CreateTypeInfo(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.CreateTypeInfo());
        }


        public static IObservable<System.Type> CreateType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.CreateType());
        }


        public static IObservable<System.Reactive.Unit> SetParent(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Type> parent)
        {
            return ObservableExt.ZipExecute(TypeBuilderValue, parent, (TypeBuilderValueLambda, parentLambda) => TypeBuilderValueLambda.SetParent(parentLambda));
        }


        public static IObservable<System.Reactive.Unit> AddInterfaceImplementation(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Type> interfaceType)
        {
            return ObservableExt.ZipExecute(TypeBuilderValue, interfaceType, (TypeBuilderValueLambda, interfaceTypeLambda) => TypeBuilderValueLambda.AddInterfaceImplementation(interfaceTypeLambda));
        }


        public static IObservable<System.Reactive.Unit> AddDeclarativeSecurity(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Security.Permissions.SecurityAction> action, IObservable<System.Security.PermissionSet> pset)
        {
            return ObservableExt.ZipExecute(TypeBuilderValue, action, pset, (TypeBuilderValueLambda, actionLambda, psetLambda) => TypeBuilderValueLambda.AddDeclarativeSecurity(actionLambda, psetLambda));
        }


        public static IObservable<System.Reactive.Unit> SetCustomAttribute(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Reflection.ConstructorInfo> con, IObservable<System.Byte[]> binaryAttribute)
        {
            return ObservableExt.ZipExecute(TypeBuilderValue, con, binaryAttribute, (TypeBuilderValueLambda, conLambda, binaryAttributeLambda) => TypeBuilderValueLambda.SetCustomAttribute(conLambda, binaryAttributeLambda));
        }


        public static IObservable<System.Reactive.Unit> SetCustomAttribute(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue, IObservable<System.Reflection.Emit.CustomAttributeBuilder> customBuilder)
        {
            return ObservableExt.ZipExecute(TypeBuilderValue, customBuilder, (TypeBuilderValueLambda, customBuilderLambda) => TypeBuilderValueLambda.SetCustomAttribute(customBuilderLambda));
        }


        public static IObservable<System.Type> get_DeclaringType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.DeclaringType);
        }


        public static IObservable<System.Type> get_ReflectedType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.ReflectedType);
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.Name);
        }


        public static IObservable<System.Reflection.Module> get_Module(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.Module);
        }


        public static IObservable<System.Guid> get_GUID(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.GUID);
        }


        public static IObservable<System.Reflection.Assembly> get_Assembly(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.Assembly);
        }


        public static IObservable<System.RuntimeTypeHandle> get_TypeHandle(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.TypeHandle);
        }


        public static IObservable<System.String> get_FullName(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.FullName);
        }


        public static IObservable<System.String> get_Namespace(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.Namespace);
        }


        public static IObservable<System.String> get_AssemblyQualifiedName(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.AssemblyQualifiedName);
        }


        public static IObservable<System.Type> get_BaseType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.BaseType);
        }


        public static IObservable<System.Boolean> get_IsSecurityCritical(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.IsSecurityCritical);
        }


        public static IObservable<System.Boolean> get_IsSecuritySafeCritical(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.IsSecuritySafeCritical);
        }


        public static IObservable<System.Boolean> get_IsSecurityTransparent(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.IsSecurityTransparent);
        }


        public static IObservable<System.Type> get_UnderlyingSystemType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.UnderlyingSystemType);
        }


        public static IObservable<System.Reflection.GenericParameterAttributes> get_GenericParameterAttributes(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.GenericParameterAttributes);
        }


        public static IObservable<System.Boolean> get_IsGenericTypeDefinition(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.IsGenericTypeDefinition);
        }


        public static IObservable<System.Boolean> get_IsGenericType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.IsGenericType);
        }


        public static IObservable<System.Boolean> get_IsGenericParameter(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.IsGenericParameter);
        }


        public static IObservable<System.Boolean> get_IsConstructedGenericType(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.IsConstructedGenericType);
        }


        public static IObservable<System.Int32> get_GenericParameterPosition(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.GenericParameterPosition);
        }


        public static IObservable<System.Reflection.MethodBase> get_DeclaringMethod(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.DeclaringMethod);
        }


        public static IObservable<System.Int32> get_Size(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.Size);
        }


        public static IObservable<System.Reflection.Emit.PackingSize> get_PackingSize(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.PackingSize);
        }


        public static IObservable<System.Reflection.Emit.TypeToken> get_TypeToken(this IObservable<System.Reflection.Emit.TypeBuilder> TypeBuilderValue)
        {
            return Observable.Select(TypeBuilderValue, (TypeBuilderValueLambda) => TypeBuilderValueLambda.TypeToken);
        }

    }
}