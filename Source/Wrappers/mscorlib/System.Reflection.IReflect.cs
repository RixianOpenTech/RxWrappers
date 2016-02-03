using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __IReflect
    {
        
        public static IObservable<System.Reflection.MethodInfo> GetMethod(this IObservable<System.Reflection.IReflect> IReflectValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Type[]> types, IObservable<System.Reflection.ParameterModifier[]> modifiers)
        {
            return Observable.Zip(IReflectValue, name, bindingAttr, binder, types, modifiers, (IReflectValueLambda, nameLambda, bindingAttrLambda, binderLambda, typesLambda, modifiersLambda) => IReflectValueLambda.GetMethod(nameLambda, bindingAttrLambda, binderLambda, typesLambda, modifiersLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetMethod(this IObservable<System.Reflection.IReflect> IReflectValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(IReflectValue, name, bindingAttr, (IReflectValueLambda, nameLambda, bindingAttrLambda) => IReflectValueLambda.GetMethod(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MethodInfo[]> GetMethods(this IObservable<System.Reflection.IReflect> IReflectValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(IReflectValue, bindingAttr, (IReflectValueLambda, bindingAttrLambda) => IReflectValueLambda.GetMethods(bindingAttrLambda));
        }


        public static IObservable<System.Reflection.FieldInfo> GetField(this IObservable<System.Reflection.IReflect> IReflectValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(IReflectValue, name, bindingAttr, (IReflectValueLambda, nameLambda, bindingAttrLambda) => IReflectValueLambda.GetField(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.FieldInfo[]> GetFields(this IObservable<System.Reflection.IReflect> IReflectValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(IReflectValue, bindingAttr, (IReflectValueLambda, bindingAttrLambda) => IReflectValueLambda.GetFields(bindingAttrLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo> GetProperty(this IObservable<System.Reflection.IReflect> IReflectValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(IReflectValue, name, bindingAttr, (IReflectValueLambda, nameLambda, bindingAttrLambda) => IReflectValueLambda.GetProperty(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo> GetProperty(this IObservable<System.Reflection.IReflect> IReflectValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Type> returnType, IObservable<System.Type[]> types, IObservable<System.Reflection.ParameterModifier[]> modifiers)
        {
            return Observable.Zip(IReflectValue, name, bindingAttr, binder, returnType, types, modifiers, (IReflectValueLambda, nameLambda, bindingAttrLambda, binderLambda, returnTypeLambda, typesLambda, modifiersLambda) => IReflectValueLambda.GetProperty(nameLambda, bindingAttrLambda, binderLambda, returnTypeLambda, typesLambda, modifiersLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo[]> GetProperties(this IObservable<System.Reflection.IReflect> IReflectValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(IReflectValue, bindingAttr, (IReflectValueLambda, bindingAttrLambda) => IReflectValueLambda.GetProperties(bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MemberInfo[]> GetMember(this IObservable<System.Reflection.IReflect> IReflectValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(IReflectValue, name, bindingAttr, (IReflectValueLambda, nameLambda, bindingAttrLambda) => IReflectValueLambda.GetMember(nameLambda, bindingAttrLambda));
        }


        public static IObservable<System.Reflection.MemberInfo[]> GetMembers(this IObservable<System.Reflection.IReflect> IReflectValue, IObservable<System.Reflection.BindingFlags> bindingAttr)
        {
            return Observable.Zip(IReflectValue, bindingAttr, (IReflectValueLambda, bindingAttrLambda) => IReflectValueLambda.GetMembers(bindingAttrLambda));
        }


        public static IObservable<System.Object> InvokeMember(this IObservable<System.Reflection.IReflect> IReflectValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object> target, IObservable<System.Object[]> args, IObservable<System.Reflection.ParameterModifier[]> modifiers, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.String[]> namedParameters)
        {
            return Observable.Zip(IReflectValue, name, invokeAttr, binder, target, args, modifiers, culture, namedParameters, (IReflectValueLambda, nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda, modifiersLambda, cultureLambda, namedParametersLambda) => IReflectValueLambda.InvokeMember(nameLambda, invokeAttrLambda, binderLambda, targetLambda, argsLambda, modifiersLambda, cultureLambda, namedParametersLambda));
        }


        public static IObservable<System.Type> get_UnderlyingSystemType(this IObservable<System.Reflection.IReflect> IReflectValue)
        {
            return Observable.Select(IReflectValue, (IReflectValueLambda) => IReflectValueLambda.UnderlyingSystemType);
        }

    }
}