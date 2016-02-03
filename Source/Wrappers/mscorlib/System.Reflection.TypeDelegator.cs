using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _TypeDelegator
{
    
public static IObservable<System.Boolean> IsAssignableFrom(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue, IObservable<System.Reflection.TypeInfo> typeInfo)
{
    return Observable.Zip(TypeDelegatorValue, typeInfo, (TypeDelegatorValueLambda, typeInfoLambda) => TypeDelegatorValueLambda.IsAssignableFrom(typeInfoLambda));
}


public static IObservable<System.Object> InvokeMember(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object> target, IObservable<System.Object[]> args, IObservable<System.Reflection.ParameterModifier[]> modifiers, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.String[]> namedParameters)
{
    return Observable.Zip(TypeDelegatorValue, name, invokeAttr, binder, target, args, modifiers, culture, namedParameters, (TypeDelegatorValueLambda, nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda, modifiersLambda, cultureLambda, namedParametersLambda) => TypeDelegatorValueLambda.InvokeMember(nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda, modifiersLambda, cultureLambda, namedParametersLambda));
}


public static IObservable<System.Reflection.ConstructorInfo[]> GetConstructors(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(TypeDelegatorValue, bindingAttr, (TypeDelegatorValueLambda, bindingAttrLambda) => TypeDelegatorValueLambda.GetConstructors(bindingAttrLambda));
}


public static IObservable<System.Reflection.MethodInfo[]> GetMethods(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(TypeDelegatorValue, bindingAttr, (TypeDelegatorValueLambda, bindingAttrLambda) => TypeDelegatorValueLambda.GetMethods(bindingAttrLambda));
}


public static IObservable<System.Reflection.FieldInfo> GetField(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(TypeDelegatorValue, name, bindingAttr, (TypeDelegatorValueLambda, nameLambda, bindingAttrLambda) => TypeDelegatorValueLambda.GetField(nameLambda, bindingAttrLambda));
}


public static IObservable<System.Reflection.FieldInfo[]> GetFields(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(TypeDelegatorValue, bindingAttr, (TypeDelegatorValueLambda, bindingAttrLambda) => TypeDelegatorValueLambda.GetFields(bindingAttrLambda));
}


public static IObservable<System.Type> GetInterface(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue, IObservable<System.String> name, IObservable<System.Boolean> ignoreCase)
{
    return Observable.Zip(TypeDelegatorValue, name, ignoreCase, (TypeDelegatorValueLambda, nameLambda, ignoreCaseLambda) => TypeDelegatorValueLambda.GetInterface(nameLambda, ignoreCaseLambda));
}


public static IObservable<System.Type[]> GetInterfaces(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue)
{
    return Observable.Select(TypeDelegatorValue, (TypeDelegatorValueLambda) => TypeDelegatorValueLambda.GetInterfaces());
}


public static IObservable<System.Reflection.EventInfo> GetEvent(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(TypeDelegatorValue, name, bindingAttr, (TypeDelegatorValueLambda, nameLambda, bindingAttrLambda) => TypeDelegatorValueLambda.GetEvent(nameLambda, bindingAttrLambda));
}


public static IObservable<System.Reflection.EventInfo[]> GetEvents(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue)
{
    return Observable.Select(TypeDelegatorValue, (TypeDelegatorValueLambda) => TypeDelegatorValueLambda.GetEvents());
}


public static IObservable<System.Reflection.PropertyInfo[]> GetProperties(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(TypeDelegatorValue, bindingAttr, (TypeDelegatorValueLambda, bindingAttrLambda) => TypeDelegatorValueLambda.GetProperties(bindingAttrLambda));
}


public static IObservable<System.Reflection.EventInfo[]> GetEvents(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(TypeDelegatorValue, bindingAttr, (TypeDelegatorValueLambda, bindingAttrLambda) => TypeDelegatorValueLambda.GetEvents(bindingAttrLambda));
}


public static IObservable<System.Type[]> GetNestedTypes(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(TypeDelegatorValue, bindingAttr, (TypeDelegatorValueLambda, bindingAttrLambda) => TypeDelegatorValueLambda.GetNestedTypes(bindingAttrLambda));
}


public static IObservable<System.Type> GetNestedType(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(TypeDelegatorValue, name, bindingAttr, (TypeDelegatorValueLambda, nameLambda, bindingAttrLambda) => TypeDelegatorValueLambda.GetNestedType(nameLambda, bindingAttrLambda));
}


public static IObservable<System.Reflection.MemberInfo[]> GetMember(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue, IObservable<System.String> name, IObservable<System.Reflection.MemberTypes> type, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(TypeDelegatorValue, name, type, bindingAttr, (TypeDelegatorValueLambda, nameLambda, typeLambda, bindingAttrLambda) => TypeDelegatorValueLambda.GetMember(nameLambda, typeLambda, bindingAttrLambda));
}


public static IObservable<System.Reflection.MemberInfo[]> GetMembers(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(TypeDelegatorValue, bindingAttr, (TypeDelegatorValueLambda, bindingAttrLambda) => TypeDelegatorValueLambda.GetMembers(bindingAttrLambda));
}


public static IObservable<System.Type> GetElementType(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue)
{
    return Observable.Select(TypeDelegatorValue, (TypeDelegatorValueLambda) => TypeDelegatorValueLambda.GetElementType());
}


public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(TypeDelegatorValue, inherit, (TypeDelegatorValueLambda, inheritLambda) => TypeDelegatorValueLambda.GetCustomAttributes(inheritLambda));
}


public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(TypeDelegatorValue, attributeType, inherit, (TypeDelegatorValueLambda, attributeTypeLambda, inheritLambda) => TypeDelegatorValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Boolean> IsDefined(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(TypeDelegatorValue, attributeType, inherit, (TypeDelegatorValueLambda, attributeTypeLambda, inheritLambda) => TypeDelegatorValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Reflection.InterfaceMapping> GetInterfaceMap(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue, IObservable<System.Type> interfaceType)
{
    return Observable.Zip(TypeDelegatorValue, interfaceType, (TypeDelegatorValueLambda, interfaceTypeLambda) => TypeDelegatorValueLambda.GetInterfaceMap(interfaceTypeLambda));
}


public static IObservable<System.Guid> get_GUID(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue)
{
    return Observable.Select(TypeDelegatorValue, (TypeDelegatorValueLambda) => TypeDelegatorValueLambda.GUID);
}


public static IObservable<System.Int32> get_MetadataToken(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue)
{
    return Observable.Select(TypeDelegatorValue, (TypeDelegatorValueLambda) => TypeDelegatorValueLambda.MetadataToken);
}


public static IObservable<System.Reflection.Module> get_Module(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue)
{
    return Observable.Select(TypeDelegatorValue, (TypeDelegatorValueLambda) => TypeDelegatorValueLambda.Module);
}


public static IObservable<System.Reflection.Assembly> get_Assembly(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue)
{
    return Observable.Select(TypeDelegatorValue, (TypeDelegatorValueLambda) => TypeDelegatorValueLambda.Assembly);
}


public static IObservable<System.RuntimeTypeHandle> get_TypeHandle(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue)
{
    return Observable.Select(TypeDelegatorValue, (TypeDelegatorValueLambda) => TypeDelegatorValueLambda.TypeHandle);
}


public static IObservable<System.String> get_Name(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue)
{
    return Observable.Select(TypeDelegatorValue, (TypeDelegatorValueLambda) => TypeDelegatorValueLambda.Name);
}


public static IObservable<System.String> get_FullName(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue)
{
    return Observable.Select(TypeDelegatorValue, (TypeDelegatorValueLambda) => TypeDelegatorValueLambda.FullName);
}


public static IObservable<System.String> get_Namespace(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue)
{
    return Observable.Select(TypeDelegatorValue, (TypeDelegatorValueLambda) => TypeDelegatorValueLambda.Namespace);
}


public static IObservable<System.String> get_AssemblyQualifiedName(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue)
{
    return Observable.Select(TypeDelegatorValue, (TypeDelegatorValueLambda) => TypeDelegatorValueLambda.AssemblyQualifiedName);
}


public static IObservable<System.Type> get_BaseType(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue)
{
    return Observable.Select(TypeDelegatorValue, (TypeDelegatorValueLambda) => TypeDelegatorValueLambda.BaseType);
}


public static IObservable<System.Boolean> get_IsConstructedGenericType(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue)
{
    return Observable.Select(TypeDelegatorValue, (TypeDelegatorValueLambda) => TypeDelegatorValueLambda.IsConstructedGenericType);
}


public static IObservable<System.Type> get_UnderlyingSystemType(this IObservable<System.Reflection.TypeDelegator> TypeDelegatorValue)
{
    return Observable.Select(TypeDelegatorValue, (TypeDelegatorValueLambda) => TypeDelegatorValueLambda.UnderlyingSystemType);
}

}
}