using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
public static class _GenericTypeParameterBuilder
{
    
public static IObservable<System.Boolean> IsAssignableFrom(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Reflection.TypeInfo> typeInfo)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, typeInfo, (GenericTypeParameterBuilderValueLambda, typeInfoLambda) => GenericTypeParameterBuilderValueLambda.IsAssignableFrom(typeInfoLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.ToString());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Object> o)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, o, (GenericTypeParameterBuilderValueLambda, oLambda) => GenericTypeParameterBuilderValueLambda.Equals(oLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.GetHashCode());
}


public static IObservable<System.Type> MakePointerType(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.MakePointerType());
}


public static IObservable<System.Type> MakeByRefType(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.MakeByRefType());
}


public static IObservable<System.Type> MakeArrayType(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.MakeArrayType());
}


public static IObservable<System.Type> MakeArrayType(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Int32> rank)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, rank, (GenericTypeParameterBuilderValueLambda, rankLambda) => GenericTypeParameterBuilderValueLambda.MakeArrayType(rankLambda));
}


public static IObservable<System.Object> InvokeMember(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object> target, IObservable<System.Object[]> args, IObservable<System.Reflection.ParameterModifier[]> modifiers, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.String[]> namedParameters)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, name, invokeAttr, binder, target, args, modifiers, culture, namedParameters, (GenericTypeParameterBuilderValueLambda, nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda, modifiersLambda, cultureLambda, namedParametersLambda) => GenericTypeParameterBuilderValueLambda.InvokeMember(nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda, modifiersLambda, cultureLambda, namedParametersLambda));
}


public static IObservable<System.Reflection.ConstructorInfo[]> GetConstructors(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, bindingAttr, (GenericTypeParameterBuilderValueLambda, bindingAttrLambda) => GenericTypeParameterBuilderValueLambda.GetConstructors(bindingAttrLambda));
}


public static IObservable<System.Reflection.MethodInfo[]> GetMethods(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, bindingAttr, (GenericTypeParameterBuilderValueLambda, bindingAttrLambda) => GenericTypeParameterBuilderValueLambda.GetMethods(bindingAttrLambda));
}


public static IObservable<System.Reflection.FieldInfo> GetField(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, name, bindingAttr, (GenericTypeParameterBuilderValueLambda, nameLambda, bindingAttrLambda) => GenericTypeParameterBuilderValueLambda.GetField(nameLambda, bindingAttrLambda));
}


public static IObservable<System.Reflection.FieldInfo[]> GetFields(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, bindingAttr, (GenericTypeParameterBuilderValueLambda, bindingAttrLambda) => GenericTypeParameterBuilderValueLambda.GetFields(bindingAttrLambda));
}


public static IObservable<System.Type> GetInterface(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.String> name, IObservable<System.Boolean> ignoreCase)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, name, ignoreCase, (GenericTypeParameterBuilderValueLambda, nameLambda, ignoreCaseLambda) => GenericTypeParameterBuilderValueLambda.GetInterface(nameLambda, ignoreCaseLambda));
}


public static IObservable<System.Type[]> GetInterfaces(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.GetInterfaces());
}


public static IObservable<System.Reflection.EventInfo> GetEvent(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, name, bindingAttr, (GenericTypeParameterBuilderValueLambda, nameLambda, bindingAttrLambda) => GenericTypeParameterBuilderValueLambda.GetEvent(nameLambda, bindingAttrLambda));
}


public static IObservable<System.Reflection.EventInfo[]> GetEvents(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.GetEvents());
}


public static IObservable<System.Reflection.PropertyInfo[]> GetProperties(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, bindingAttr, (GenericTypeParameterBuilderValueLambda, bindingAttrLambda) => GenericTypeParameterBuilderValueLambda.GetProperties(bindingAttrLambda));
}


public static IObservable<System.Type[]> GetNestedTypes(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, bindingAttr, (GenericTypeParameterBuilderValueLambda, bindingAttrLambda) => GenericTypeParameterBuilderValueLambda.GetNestedTypes(bindingAttrLambda));
}


public static IObservable<System.Type> GetNestedType(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, name, bindingAttr, (GenericTypeParameterBuilderValueLambda, nameLambda, bindingAttrLambda) => GenericTypeParameterBuilderValueLambda.GetNestedType(nameLambda, bindingAttrLambda));
}


public static IObservable<System.Reflection.MemberInfo[]> GetMember(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.MemberTypes> type, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, name, type, bindingAttr, (GenericTypeParameterBuilderValueLambda, nameLambda, typeLambda, bindingAttrLambda) => GenericTypeParameterBuilderValueLambda.GetMember(nameLambda, typeLambda, bindingAttrLambda));
}


public static IObservable<System.Reflection.InterfaceMapping> GetInterfaceMap(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Type> interfaceType)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, interfaceType, (GenericTypeParameterBuilderValueLambda, interfaceTypeLambda) => GenericTypeParameterBuilderValueLambda.GetInterfaceMap(interfaceTypeLambda));
}


public static IObservable<System.Reflection.EventInfo[]> GetEvents(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, bindingAttr, (GenericTypeParameterBuilderValueLambda, bindingAttrLambda) => GenericTypeParameterBuilderValueLambda.GetEvents(bindingAttrLambda));
}


public static IObservable<System.Reflection.MemberInfo[]> GetMembers(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, bindingAttr, (GenericTypeParameterBuilderValueLambda, bindingAttrLambda) => GenericTypeParameterBuilderValueLambda.GetMembers(bindingAttrLambda));
}


public static IObservable<System.Type> GetElementType(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.GetElementType());
}


public static IObservable<System.Type[]> GetGenericArguments(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.GetGenericArguments());
}


public static IObservable<System.Type> GetGenericTypeDefinition(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.GetGenericTypeDefinition());
}


public static IObservable<System.Type> MakeGenericType(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Type[]> typeArguments)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, typeArguments, (GenericTypeParameterBuilderValueLambda, typeArgumentsLambda) => GenericTypeParameterBuilderValueLambda.MakeGenericType(typeArgumentsLambda));
}


public static IObservable<System.Boolean> IsAssignableFrom(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Type> c)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, c, (GenericTypeParameterBuilderValueLambda, cLambda) => GenericTypeParameterBuilderValueLambda.IsAssignableFrom(cLambda));
}


public static IObservable<System.Boolean> IsSubclassOf(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Type> c)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, c, (GenericTypeParameterBuilderValueLambda, cLambda) => GenericTypeParameterBuilderValueLambda.IsSubclassOf(cLambda));
}


public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, inherit, (GenericTypeParameterBuilderValueLambda, inheritLambda) => GenericTypeParameterBuilderValueLambda.GetCustomAttributes(inheritLambda));
}


public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, attributeType, inherit, (GenericTypeParameterBuilderValueLambda, attributeTypeLambda, inheritLambda) => GenericTypeParameterBuilderValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Boolean> IsDefined(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(GenericTypeParameterBuilderValue, attributeType, inherit, (GenericTypeParameterBuilderValueLambda, attributeTypeLambda, inheritLambda) => GenericTypeParameterBuilderValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Reactive.Unit> SetCustomAttribute(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Reflection.ConstructorInfo> con, IObservable<System.Byte[]> binaryAttribute)
{
    return ObservableExt.ZipExecute(GenericTypeParameterBuilderValue, con, binaryAttribute, (GenericTypeParameterBuilderValueLambda, conLambda, binaryAttributeLambda) => GenericTypeParameterBuilderValueLambda.SetCustomAttribute(conLambda, binaryAttributeLambda));
}


public static IObservable<System.Reactive.Unit> SetCustomAttribute(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Reflection.Emit.CustomAttributeBuilder> customBuilder)
{
    return ObservableExt.ZipExecute(GenericTypeParameterBuilderValue, customBuilder, (GenericTypeParameterBuilderValueLambda, customBuilderLambda) => GenericTypeParameterBuilderValueLambda.SetCustomAttribute(customBuilderLambda));
}


public static IObservable<System.Reactive.Unit> SetBaseTypeConstraint(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Type> baseTypeConstraint)
{
    return ObservableExt.ZipExecute(GenericTypeParameterBuilderValue, baseTypeConstraint, (GenericTypeParameterBuilderValueLambda, baseTypeConstraintLambda) => GenericTypeParameterBuilderValueLambda.SetBaseTypeConstraint(baseTypeConstraintLambda));
}


public static IObservable<System.Reactive.Unit> SetInterfaceConstraints(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Type[]> interfaceConstraints)
{
    return ObservableExt.ZipExecute(GenericTypeParameterBuilderValue, interfaceConstraints, (GenericTypeParameterBuilderValueLambda, interfaceConstraintsLambda) => GenericTypeParameterBuilderValueLambda.SetInterfaceConstraints(interfaceConstraintsLambda));
}


public static IObservable<System.Reactive.Unit> SetGenericParameterAttributes(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue, IObservable<System.Reflection.GenericParameterAttributes> genericParameterAttributes)
{
    return ObservableExt.ZipExecute(GenericTypeParameterBuilderValue, genericParameterAttributes, (GenericTypeParameterBuilderValueLambda, genericParameterAttributesLambda) => GenericTypeParameterBuilderValueLambda.SetGenericParameterAttributes(genericParameterAttributesLambda));
}


public static IObservable<System.Type> get_DeclaringType(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.DeclaringType);
}


public static IObservable<System.Type> get_ReflectedType(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.ReflectedType);
}


public static IObservable<System.String> get_Name(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.Name);
}


public static IObservable<System.Reflection.Module> get_Module(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.Module);
}


public static IObservable<System.Guid> get_GUID(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.GUID);
}


public static IObservable<System.Reflection.Assembly> get_Assembly(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.Assembly);
}


public static IObservable<System.RuntimeTypeHandle> get_TypeHandle(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.TypeHandle);
}


public static IObservable<System.String> get_FullName(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.FullName);
}


public static IObservable<System.String> get_Namespace(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.Namespace);
}


public static IObservable<System.String> get_AssemblyQualifiedName(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.AssemblyQualifiedName);
}


public static IObservable<System.Type> get_BaseType(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.BaseType);
}


public static IObservable<System.Type> get_UnderlyingSystemType(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.UnderlyingSystemType);
}


public static IObservable<System.Boolean> get_IsGenericTypeDefinition(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.IsGenericTypeDefinition);
}


public static IObservable<System.Boolean> get_IsGenericType(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.IsGenericType);
}


public static IObservable<System.Boolean> get_IsGenericParameter(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.IsGenericParameter);
}


public static IObservable<System.Boolean> get_IsConstructedGenericType(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.IsConstructedGenericType);
}


public static IObservable<System.Int32> get_GenericParameterPosition(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.GenericParameterPosition);
}


public static IObservable<System.Boolean> get_ContainsGenericParameters(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.ContainsGenericParameters);
}


public static IObservable<System.Reflection.GenericParameterAttributes> get_GenericParameterAttributes(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.GenericParameterAttributes);
}


public static IObservable<System.Reflection.MethodBase> get_DeclaringMethod(this IObservable<System.Reflection.Emit.GenericTypeParameterBuilder> GenericTypeParameterBuilderValue)
{
    return Observable.Select(GenericTypeParameterBuilderValue, (GenericTypeParameterBuilderValueLambda) => GenericTypeParameterBuilderValueLambda.DeclaringMethod);
}

}
}