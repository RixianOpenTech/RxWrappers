using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class ___Type
    {
        
        public static IObservable<System.UInt32> GetTypeInfoCount(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => {
System.UInt32 pcTInfoOutput = default(System.UInt32);
_TypeValueLambda.GetTypeInfoCount(out pcTInfoOutput);
return pcTInfoOutput;
});
        }


        public static IObservable<System.Reactive.Unit> GetTypeInfo(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.UInt32> iTInfo, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> ppTInfo)
        {
            return ObservableExt.ZipExecute(_TypeValue, iTInfo, lcid, ppTInfo, (_TypeValueLambda, iTInfoLambda, lcidLambda, ppTInfoLambda) => _TypeValueLambda.GetTypeInfo(iTInfoLambda, lcidLambda, ppTInfoLambda));
        }


        public static IObservable<System.Guid> GetIDsOfNames(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Guid> riid, IObservable<System.IntPtr> rgszNames, IObservable<System.UInt32> cNames, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> rgDispId)
        {
            return Observable.Zip(_TypeValue, riid, rgszNames, cNames, lcid, rgDispId, (_TypeValueLambda, riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda) => {
_TypeValueLambda.GetIDsOfNames(ref riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda);
return riidLambda;
});
        }


        public static IObservable<System.Guid> Invoke(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.UInt32> dispIdMember, IObservable<System.Guid> riid, IObservable<System.UInt32> lcid, IObservable<System.Int16> wFlags, IObservable<System.IntPtr> pDispParams, IObservable<System.IntPtr> pVarResult, IObservable<System.IntPtr> pExcepInfo, IObservable<System.IntPtr> puArgErr)
        {
            return Observable.Zip(_TypeValue, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr, (_TypeValueLambda, dispIdMemberLambda, riidLambda, lcidLambda, wFlagsLambda, pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda) => {
_TypeValueLambda.Invoke(dispIdMemberLambda, ref riidLambda, lcidLambda, wFlagsLambda, pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda);
return riidLambda;
});
        }


        public static IObservable<System.String> ToString(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Object> other)
        {
            return Observable.Zip(_TypeValue, other, (_TypeValueLambda, otherLambda) => _TypeValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.GetHashCode());
        }


        public static IObservable<System.Type> GetType(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.GetType());
        }


        public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_TypeValue, attributeType, inherit, (_TypeValueLambda, attributeTypeLambda, inheritLambda) => _TypeValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_TypeValue, inherit, (_TypeValueLambda, inheritLambda) => _TypeValueLambda.GetCustomAttributes(inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_TypeValue, attributeType, inherit, (_TypeValueLambda, attributeTypeLambda, inheritLambda) => _TypeValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Int32> GetArrayRank(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.GetArrayRank());
        }


        public static IObservable<System.Reflection.ConstructorInfo[]> GetConstructors(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(_TypeValue, bindingAttr, (_TypeValueLambda, bindingAttrLambda) => _TypeValueLambda.GetConstructors(bindingAttrLambda));
        }


        public static IObservable<System.Type> GetInterface(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Boolean> ignoreCase)
        {
            return Observable.Zip(_TypeValue, name, ignoreCase, (_TypeValueLambda, nameLambda, ignoreCaseLambda) => _TypeValueLambda.GetInterface(nameLambda, ignoreCaseLambda));
        }


        public static IObservable<System.Type[]> GetInterfaces(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.GetInterfaces());
        }


        public static IObservable<System.Type[]> FindInterfaces(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Reflection.TypeFilter> filter, IObservable<System.Object> filterCriteria)
        {
            return Observable.Zip(_TypeValue, filter, filterCriteria, (_TypeValueLambda, filterLambda, filterCriteriaLambda) => _TypeValueLambda.FindInterfaces(filterLambda, filterCriteriaLambda));
        }


        public static IObservable<System.Reflection.EventInfo> GetEvent(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(_TypeValue, name, bindingAttr, (_TypeValueLambda, nameLambda, bindingAttrLambda) => _TypeValueLambda.GetEvent(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.EventInfo[]> GetEvents(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.GetEvents());
        }


        public static IObservable<System.Reflection.EventInfo[]> GetEvents(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(_TypeValue, bindingAttr, (_TypeValueLambda, bindingAttrLambda) => _TypeValueLambda.GetEvents(bindingAttrLambda));
        }


        public static IObservable<System.Type[]> GetNestedTypes(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(_TypeValue, bindingAttr, (_TypeValueLambda, bindingAttrLambda) => _TypeValueLambda.GetNestedTypes(bindingAttrLambda));
        }


        public static IObservable<System.Type> GetNestedType(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(_TypeValue, name, bindingAttr, (_TypeValueLambda, nameLambda, bindingAttrLambda) => _TypeValueLambda.GetNestedType(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MemberInfo[]> GetMember(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Reflection.MemberTypes> type, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(_TypeValue, name, type, bindingAttr, (_TypeValueLambda, nameLambda, typeLambda, bindingAttrLambda) => _TypeValueLambda.GetMember(nameLambda, typeLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MemberInfo[]> GetDefaultMembers(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.GetDefaultMembers());
        }


        public static IObservable<System.Reflection.MemberInfo[]> FindMembers(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Reflection.MemberTypes> memberType, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.MemberFilter> filter, IObservable<System.Object> filterCriteria)
        {
            return Observable.Zip(_TypeValue, memberType, bindingAttr, filter, filterCriteria, (_TypeValueLambda, memberTypeLambda, bindingAttrLambda, filterLambda, filterCriteriaLambda) => _TypeValueLambda.FindMembers(memberTypeLambda, bindingAttrLambda, filterLambda, filterCriteriaLambda));
        }


        public static IObservable<System.Type> GetElementType(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.GetElementType());
        }


        public static IObservable<System.Boolean> IsSubclassOf(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Type> c)
        {
            return Observable.Zip(_TypeValue, c, (_TypeValueLambda, cLambda) => _TypeValueLambda.IsSubclassOf(cLambda));
        }


        public static IObservable<System.Boolean> IsInstanceOfType(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Object> o)
        {
            return Observable.Zip(_TypeValue, o, (_TypeValueLambda, oLambda) => _TypeValueLambda.IsInstanceOfType(oLambda));
        }


        public static IObservable<System.Boolean> IsAssignableFrom(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Type> c)
        {
            return Observable.Zip(_TypeValue, c, (_TypeValueLambda, cLambda) => _TypeValueLambda.IsAssignableFrom(cLambda));
        }


        public static IObservable<System.Reflection.InterfaceMapping> GetInterfaceMap(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Type> interfaceType)
        {
            return Observable.Zip(_TypeValue, interfaceType, (_TypeValueLambda, interfaceTypeLambda) => _TypeValueLambda.GetInterfaceMap(interfaceTypeLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetMethod(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Type[]> types, IObservable<System.Reflection.ParameterModifier[]> modifiers)
        {
            return Observable.Zip(_TypeValue, name, bindingAttr, binder, types, modifiers, (_TypeValueLambda, nameLambda, bindingAttrLambda, binderLambda, typesLambda, modifiersLambda) => _TypeValueLambda.GetMethod(nameLambda, bindingAttrLambda, binderLambda, typesLambda, modifiersLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetMethod(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(_TypeValue, name, bindingAttr, (_TypeValueLambda, nameLambda, bindingAttrLambda) => _TypeValueLambda.GetMethod(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MethodInfo[]> GetMethods(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(_TypeValue, bindingAttr, (_TypeValueLambda, bindingAttrLambda) => _TypeValueLambda.GetMethods(bindingAttrLambda));
        }


        public static IObservable<System.Reflection.FieldInfo> GetField(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(_TypeValue, name, bindingAttr, (_TypeValueLambda, nameLambda, bindingAttrLambda) => _TypeValueLambda.GetField(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.FieldInfo[]> GetFields(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(_TypeValue, bindingAttr, (_TypeValueLambda, bindingAttrLambda) => _TypeValueLambda.GetFields(bindingAttrLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo> GetProperty(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(_TypeValue, name, bindingAttr, (_TypeValueLambda, nameLambda, bindingAttrLambda) => _TypeValueLambda.GetProperty(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo> GetProperty(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Type> returnType, IObservable<System.Type[]> types, IObservable<System.Reflection.ParameterModifier[]> modifiers)
        {
            return Observable.Zip(_TypeValue, name, bindingAttr, binder, returnType, types, modifiers, (_TypeValueLambda, nameLambda, bindingAttrLambda, binderLambda, returnTypeLambda, typesLambda, modifiersLambda) => _TypeValueLambda.GetProperty(nameLambda, bindingAttrLambda, binderLambda, returnTypeLambda, typesLambda, modifiersLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo[]> GetProperties(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(_TypeValue, bindingAttr, (_TypeValueLambda, bindingAttrLambda) => _TypeValueLambda.GetProperties(bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MemberInfo[]> GetMember(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(_TypeValue, name, bindingAttr, (_TypeValueLambda, nameLambda, bindingAttrLambda) => _TypeValueLambda.GetMember(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MemberInfo[]> GetMembers(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(_TypeValue, bindingAttr, (_TypeValueLambda, bindingAttrLambda) => _TypeValueLambda.GetMembers(bindingAttrLambda));
        }


        public static IObservable<System.Object> InvokeMember(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object> target, IObservable<System.Object[]> args, IObservable<System.Reflection.ParameterModifier[]> modifiers, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.String[]> namedParameters)
        {
            return Observable.Zip(_TypeValue, name, invokeAttr, binder, target, args, modifiers, culture, namedParameters, (_TypeValueLambda, nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda, modifiersLambda, cultureLambda, namedParametersLambda) => _TypeValueLambda.InvokeMember(nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda, modifiersLambda, cultureLambda, namedParametersLambda));
        }


        public static IObservable<System.Object> InvokeMember(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object> target, IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture)
        {
            return Observable.Zip(_TypeValue, name, invokeAttr, binder, target, args, culture, (_TypeValueLambda, nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda, cultureLambda) => _TypeValueLambda.InvokeMember(nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda, cultureLambda));
        }


        public static IObservable<System.Object> InvokeMember(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object> target, IObservable<System.Object[]> args)
        {
            return Observable.Zip(_TypeValue, name, invokeAttr, binder, target, args, (_TypeValueLambda, nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda) => _TypeValueLambda.InvokeMember(nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda));
        }


        public static IObservable<System.Reflection.ConstructorInfo> GetConstructor(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Reflection.CallingConventions> callConvention, IObservable<System.Type[]> types, IObservable<System.Reflection.ParameterModifier[]> modifiers)
        {
            return Observable.Zip(_TypeValue, bindingAttr, binder, callConvention, types, modifiers, (_TypeValueLambda, bindingAttrLambda, binderLambda, callConventionLambda, typesLambda, modifiersLambda) => _TypeValueLambda.GetConstructor(bindingAttrLambda, binderLambda, callConventionLambda, typesLambda, modifiersLambda));
        }


        public static IObservable<System.Reflection.ConstructorInfo> GetConstructor(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Type[]> types, IObservable<System.Reflection.ParameterModifier[]> modifiers)
        {
            return Observable.Zip(_TypeValue, bindingAttr, binder, types, modifiers, (_TypeValueLambda, bindingAttrLambda, binderLambda, typesLambda, modifiersLambda) => _TypeValueLambda.GetConstructor(bindingAttrLambda, binderLambda, typesLambda, modifiersLambda));
        }


        public static IObservable<System.Reflection.ConstructorInfo> GetConstructor(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Type[]> types)
        {
            return Observable.Zip(_TypeValue, types, (_TypeValueLambda, typesLambda) => _TypeValueLambda.GetConstructor(typesLambda));
        }


        public static IObservable<System.Reflection.ConstructorInfo[]> GetConstructors(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.GetConstructors());
        }


        public static IObservable<System.Reflection.MethodInfo> GetMethod(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Reflection.CallingConventions> callConvention, IObservable<System.Type[]> types, IObservable<System.Reflection.ParameterModifier[]> modifiers)
        {
            return Observable.Zip(_TypeValue, name, bindingAttr, binder, callConvention, types, modifiers, (_TypeValueLambda, nameLambda, bindingAttrLambda, binderLambda, callConventionLambda, typesLambda, modifiersLambda) => _TypeValueLambda.GetMethod(nameLambda, bindingAttrLambda, binderLambda, callConventionLambda, typesLambda, modifiersLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetMethod(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Type[]> types, IObservable<System.Reflection.ParameterModifier[]> modifiers)
        {
            return Observable.Zip(_TypeValue, name, types, modifiers, (_TypeValueLambda, nameLambda, typesLambda, modifiersLambda) => _TypeValueLambda.GetMethod(nameLambda, typesLambda, modifiersLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetMethod(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Type[]> types)
        {
            return Observable.Zip(_TypeValue, name, types, (_TypeValueLambda, nameLambda, typesLambda) => _TypeValueLambda.GetMethod(nameLambda, typesLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetMethod(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name)
        {
            return Observable.Zip(_TypeValue, name, (_TypeValueLambda, nameLambda) => _TypeValueLambda.GetMethod(nameLambda));
        }


        public static IObservable<System.Reflection.MethodInfo[]> GetMethods(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.GetMethods());
        }


        public static IObservable<System.Reflection.FieldInfo> GetField(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name)
        {
            return Observable.Zip(_TypeValue, name, (_TypeValueLambda, nameLambda) => _TypeValueLambda.GetField(nameLambda));
        }


        public static IObservable<System.Reflection.FieldInfo[]> GetFields(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.GetFields());
        }


        public static IObservable<System.Type> GetInterface(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name)
        {
            return Observable.Zip(_TypeValue, name, (_TypeValueLambda, nameLambda) => _TypeValueLambda.GetInterface(nameLambda));
        }


        public static IObservable<System.Reflection.EventInfo> GetEvent(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name)
        {
            return Observable.Zip(_TypeValue, name, (_TypeValueLambda, nameLambda) => _TypeValueLambda.GetEvent(nameLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo> GetProperty(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Type> returnType, IObservable<System.Type[]> types, IObservable<System.Reflection.ParameterModifier[]> modifiers)
        {
            return Observable.Zip(_TypeValue, name, returnType, types, modifiers, (_TypeValueLambda, nameLambda, returnTypeLambda, typesLambda, modifiersLambda) => _TypeValueLambda.GetProperty(nameLambda, returnTypeLambda, typesLambda, modifiersLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo> GetProperty(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Type> returnType, IObservable<System.Type[]> types)
        {
            return Observable.Zip(_TypeValue, name, returnType, types, (_TypeValueLambda, nameLambda, returnTypeLambda, typesLambda) => _TypeValueLambda.GetProperty(nameLambda, returnTypeLambda, typesLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo> GetProperty(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Type[]> types)
        {
            return Observable.Zip(_TypeValue, name, types, (_TypeValueLambda, nameLambda, typesLambda) => _TypeValueLambda.GetProperty(nameLambda, typesLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo> GetProperty(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name, IObservable<System.Type> returnType)
        {
            return Observable.Zip(_TypeValue, name, returnType, (_TypeValueLambda, nameLambda, returnTypeLambda) => _TypeValueLambda.GetProperty(nameLambda, returnTypeLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo> GetProperty(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name)
        {
            return Observable.Zip(_TypeValue, name, (_TypeValueLambda, nameLambda) => _TypeValueLambda.GetProperty(nameLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo[]> GetProperties(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.GetProperties());
        }


        public static IObservable<System.Type[]> GetNestedTypes(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.GetNestedTypes());
        }


        public static IObservable<System.Type> GetNestedType(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name)
        {
            return Observable.Zip(_TypeValue, name, (_TypeValueLambda, nameLambda) => _TypeValueLambda.GetNestedType(nameLambda));
        }


        public static IObservable<System.Reflection.MemberInfo[]> GetMember(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.String> name)
        {
            return Observable.Zip(_TypeValue, name, (_TypeValueLambda, nameLambda) => _TypeValueLambda.GetMember(nameLambda));
        }


        public static IObservable<System.Reflection.MemberInfo[]> GetMembers(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.GetMembers());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Runtime.InteropServices._Type> _TypeValue, IObservable<System.Type> o)
        {
            return Observable.Zip(_TypeValue, o, (_TypeValueLambda, oLambda) => _TypeValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Reflection.MemberTypes> get_MemberType(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.MemberType);
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.Name);
        }


        public static IObservable<System.Type> get_DeclaringType(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.DeclaringType);
        }


        public static IObservable<System.Type> get_ReflectedType(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.ReflectedType);
        }


        public static IObservable<System.Guid> get_GUID(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.GUID);
        }


        public static IObservable<System.Reflection.Module> get_Module(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.Module);
        }


        public static IObservable<System.Reflection.Assembly> get_Assembly(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.Assembly);
        }


        public static IObservable<System.RuntimeTypeHandle> get_TypeHandle(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.TypeHandle);
        }


        public static IObservable<System.String> get_FullName(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.FullName);
        }


        public static IObservable<System.String> get_Namespace(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.Namespace);
        }


        public static IObservable<System.String> get_AssemblyQualifiedName(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.AssemblyQualifiedName);
        }


        public static IObservable<System.Type> get_BaseType(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.BaseType);
        }


        public static IObservable<System.Type> get_UnderlyingSystemType(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.UnderlyingSystemType);
        }


        public static IObservable<System.Reflection.ConstructorInfo> get_TypeInitializer(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.TypeInitializer);
        }


        public static IObservable<System.Reflection.TypeAttributes> get_Attributes(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.Attributes);
        }


        public static IObservable<System.Boolean> get_IsNotPublic(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsNotPublic);
        }


        public static IObservable<System.Boolean> get_IsPublic(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsPublic);
        }


        public static IObservable<System.Boolean> get_IsNestedPublic(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsNestedPublic);
        }


        public static IObservable<System.Boolean> get_IsNestedPrivate(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsNestedPrivate);
        }


        public static IObservable<System.Boolean> get_IsNestedFamily(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsNestedFamily);
        }


        public static IObservable<System.Boolean> get_IsNestedAssembly(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsNestedAssembly);
        }


        public static IObservable<System.Boolean> get_IsNestedFamANDAssem(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsNestedFamANDAssem);
        }


        public static IObservable<System.Boolean> get_IsNestedFamORAssem(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsNestedFamORAssem);
        }


        public static IObservable<System.Boolean> get_IsAutoLayout(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsAutoLayout);
        }


        public static IObservable<System.Boolean> get_IsLayoutSequential(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsLayoutSequential);
        }


        public static IObservable<System.Boolean> get_IsExplicitLayout(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsExplicitLayout);
        }


        public static IObservable<System.Boolean> get_IsClass(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsClass);
        }


        public static IObservable<System.Boolean> get_IsInterface(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsInterface);
        }


        public static IObservable<System.Boolean> get_IsValueType(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsValueType);
        }


        public static IObservable<System.Boolean> get_IsAbstract(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsAbstract);
        }


        public static IObservable<System.Boolean> get_IsSealed(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsSealed);
        }


        public static IObservable<System.Boolean> get_IsEnum(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsEnum);
        }


        public static IObservable<System.Boolean> get_IsSpecialName(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsSpecialName);
        }


        public static IObservable<System.Boolean> get_IsImport(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsImport);
        }


        public static IObservable<System.Boolean> get_IsSerializable(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsSerializable);
        }


        public static IObservable<System.Boolean> get_IsAnsiClass(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsAnsiClass);
        }


        public static IObservable<System.Boolean> get_IsUnicodeClass(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsUnicodeClass);
        }


        public static IObservable<System.Boolean> get_IsAutoClass(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsAutoClass);
        }


        public static IObservable<System.Boolean> get_IsArray(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsArray);
        }


        public static IObservable<System.Boolean> get_IsByRef(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsByRef);
        }


        public static IObservable<System.Boolean> get_IsPointer(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsPointer);
        }


        public static IObservable<System.Boolean> get_IsPrimitive(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsPrimitive);
        }


        public static IObservable<System.Boolean> get_IsCOMObject(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsCOMObject);
        }


        public static IObservable<System.Boolean> get_HasElementType(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.HasElementType);
        }


        public static IObservable<System.Boolean> get_IsContextful(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsContextful);
        }


        public static IObservable<System.Boolean> get_IsMarshalByRef(this IObservable<System.Runtime.InteropServices._Type> _TypeValue)
        {
            return Observable.Select(_TypeValue, (_TypeValueLambda) => _TypeValueLambda.IsMarshalByRef);
        }

    }
}