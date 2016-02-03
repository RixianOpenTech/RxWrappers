using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
    public static class __EnumBuilder
    {
        
        public static IObservable<System.Boolean> IsAssignableFrom(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.Reflection.TypeInfo> typeInfo)
        {
            return Observable.Zip(EnumBuilderValue, typeInfo, (EnumBuilderValueLambda, typeInfoLambda) => EnumBuilderValueLambda.IsAssignableFrom(typeInfoLambda));
        }


        public static IObservable<System.Reflection.Emit.FieldBuilder> DefineLiteral(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.String> literalName, IObservable<System.Object> literalValue)
        {
            return Observable.Zip(EnumBuilderValue, literalName, literalValue, (EnumBuilderValueLambda, literalNameLambda, literalValueLambda) => EnumBuilderValueLambda.DefineLiteral(literalNameLambda, literalValueLambda));
        }


        public static IObservable<System.Reflection.TypeInfo> CreateTypeInfo(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.CreateTypeInfo());
        }


        public static IObservable<System.Type> CreateType(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.CreateType());
        }


        public static IObservable<System.Object> InvokeMember(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object> target, IObservable<System.Object[]> args, IObservable<System.Reflection.ParameterModifier[]> modifiers, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.String[]> namedParameters)
        {
            return Observable.Zip(EnumBuilderValue, name, invokeAttr, binder, target, args, modifiers, culture, namedParameters, (EnumBuilderValueLambda, nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda, modifiersLambda, cultureLambda, namedParametersLambda) => EnumBuilderValueLambda.InvokeMember(nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda, modifiersLambda, cultureLambda, namedParametersLambda));
        }


        public static IObservable<System.Reflection.ConstructorInfo[]> GetConstructors(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(EnumBuilderValue, bindingAttr, (EnumBuilderValueLambda, bindingAttrLambda) => EnumBuilderValueLambda.GetConstructors(bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MethodInfo[]> GetMethods(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(EnumBuilderValue, bindingAttr, (EnumBuilderValueLambda, bindingAttrLambda) => EnumBuilderValueLambda.GetMethods(bindingAttrLambda));
        }


        public static IObservable<System.Reflection.FieldInfo> GetField(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(EnumBuilderValue, name, bindingAttr, (EnumBuilderValueLambda, nameLambda, bindingAttrLambda) => EnumBuilderValueLambda.GetField(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.FieldInfo[]> GetFields(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(EnumBuilderValue, bindingAttr, (EnumBuilderValueLambda, bindingAttrLambda) => EnumBuilderValueLambda.GetFields(bindingAttrLambda));
        }


        public static IObservable<System.Type> GetInterface(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.String> name, IObservable<System.Boolean> ignoreCase)
        {
            return Observable.Zip(EnumBuilderValue, name, ignoreCase, (EnumBuilderValueLambda, nameLambda, ignoreCaseLambda) => EnumBuilderValueLambda.GetInterface(nameLambda, ignoreCaseLambda));
        }


        public static IObservable<System.Type[]> GetInterfaces(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.GetInterfaces());
        }


        public static IObservable<System.Reflection.EventInfo> GetEvent(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(EnumBuilderValue, name, bindingAttr, (EnumBuilderValueLambda, nameLambda, bindingAttrLambda) => EnumBuilderValueLambda.GetEvent(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.EventInfo[]> GetEvents(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.GetEvents());
        }


        public static IObservable<System.Reflection.PropertyInfo[]> GetProperties(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(EnumBuilderValue, bindingAttr, (EnumBuilderValueLambda, bindingAttrLambda) => EnumBuilderValueLambda.GetProperties(bindingAttrLambda));
        }


        public static IObservable<System.Type[]> GetNestedTypes(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(EnumBuilderValue, bindingAttr, (EnumBuilderValueLambda, bindingAttrLambda) => EnumBuilderValueLambda.GetNestedTypes(bindingAttrLambda));
        }


        public static IObservable<System.Type> GetNestedType(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(EnumBuilderValue, name, bindingAttr, (EnumBuilderValueLambda, nameLambda, bindingAttrLambda) => EnumBuilderValueLambda.GetNestedType(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MemberInfo[]> GetMember(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.MemberTypes> type, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(EnumBuilderValue, name, type, bindingAttr, (EnumBuilderValueLambda, nameLambda, typeLambda, bindingAttrLambda) => EnumBuilderValueLambda.GetMember(nameLambda, typeLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MemberInfo[]> GetMembers(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(EnumBuilderValue, bindingAttr, (EnumBuilderValueLambda, bindingAttrLambda) => EnumBuilderValueLambda.GetMembers(bindingAttrLambda));
        }


        public static IObservable<System.Reflection.InterfaceMapping> GetInterfaceMap(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.Type> interfaceType)
        {
            return Observable.Zip(EnumBuilderValue, interfaceType, (EnumBuilderValueLambda, interfaceTypeLambda) => EnumBuilderValueLambda.GetInterfaceMap(interfaceTypeLambda));
        }


        public static IObservable<System.Reflection.EventInfo[]> GetEvents(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(EnumBuilderValue, bindingAttr, (EnumBuilderValueLambda, bindingAttrLambda) => EnumBuilderValueLambda.GetEvents(bindingAttrLambda));
        }


        public static IObservable<System.Type> GetElementType(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.GetElementType());
        }


        public static IObservable<System.Type> GetEnumUnderlyingType(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.GetEnumUnderlyingType());
        }


        public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(EnumBuilderValue, inherit, (EnumBuilderValueLambda, inheritLambda) => EnumBuilderValueLambda.GetCustomAttributes(inheritLambda));
        }


        public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(EnumBuilderValue, attributeType, inherit, (EnumBuilderValueLambda, attributeTypeLambda, inheritLambda) => EnumBuilderValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Reactive.Unit> SetCustomAttribute(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.Reflection.ConstructorInfo> con, IObservable<System.Byte[]> binaryAttribute)
        {
            return ObservableExt.ZipExecute(EnumBuilderValue, con, binaryAttribute, (EnumBuilderValueLambda, conLambda, binaryAttributeLambda) => EnumBuilderValueLambda.SetCustomAttribute(conLambda, binaryAttributeLambda));
        }


        public static IObservable<System.Reactive.Unit> SetCustomAttribute(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.Reflection.Emit.CustomAttributeBuilder> customBuilder)
        {
            return ObservableExt.ZipExecute(EnumBuilderValue, customBuilder, (EnumBuilderValueLambda, customBuilderLambda) => EnumBuilderValueLambda.SetCustomAttribute(customBuilderLambda));
        }


        public static IObservable<System.Boolean> IsDefined(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(EnumBuilderValue, attributeType, inherit, (EnumBuilderValueLambda, attributeTypeLambda, inheritLambda) => EnumBuilderValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Type> MakePointerType(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.MakePointerType());
        }


        public static IObservable<System.Type> MakeByRefType(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.MakeByRefType());
        }


        public static IObservable<System.Type> MakeArrayType(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.MakeArrayType());
        }


        public static IObservable<System.Type> MakeArrayType(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue, IObservable<System.Int32> rank)
        {
            return Observable.Zip(EnumBuilderValue, rank, (EnumBuilderValueLambda, rankLambda) => EnumBuilderValueLambda.MakeArrayType(rankLambda));
        }


        public static IObservable<System.Reflection.Emit.TypeToken> get_TypeToken(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.TypeToken);
        }


        public static IObservable<System.Reflection.Emit.FieldBuilder> get_UnderlyingField(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.UnderlyingField);
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.Name);
        }


        public static IObservable<System.Guid> get_GUID(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.GUID);
        }


        public static IObservable<System.Reflection.Module> get_Module(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.Module);
        }


        public static IObservable<System.Reflection.Assembly> get_Assembly(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.Assembly);
        }


        public static IObservable<System.RuntimeTypeHandle> get_TypeHandle(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.TypeHandle);
        }


        public static IObservable<System.String> get_FullName(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.FullName);
        }


        public static IObservable<System.String> get_AssemblyQualifiedName(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.AssemblyQualifiedName);
        }


        public static IObservable<System.String> get_Namespace(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.Namespace);
        }


        public static IObservable<System.Type> get_BaseType(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.BaseType);
        }


        public static IObservable<System.Boolean> get_IsConstructedGenericType(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.IsConstructedGenericType);
        }


        public static IObservable<System.Type> get_UnderlyingSystemType(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.UnderlyingSystemType);
        }


        public static IObservable<System.Type> get_DeclaringType(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.DeclaringType);
        }


        public static IObservable<System.Type> get_ReflectedType(this IObservable<System.Reflection.Emit.EnumBuilder> EnumBuilderValue)
        {
            return Observable.Select(EnumBuilderValue, (EnumBuilderValueLambda) => EnumBuilderValueLambda.ReflectedType);
        }

    }
}