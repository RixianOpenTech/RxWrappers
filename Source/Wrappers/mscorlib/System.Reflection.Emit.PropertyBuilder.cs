using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
    public static class __PropertyBuilder
    {
        public static IObservable<System.Reactive.Unit> SetConstant(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue,
            IObservable<System.Object> defaultValue)
        {
            return ObservableExt.ZipExecute(PropertyBuilderValue, defaultValue,
                (PropertyBuilderValueLambda, defaultValueLambda) =>
                    PropertyBuilderValueLambda.SetConstant(defaultValueLambda));
        }


        public static IObservable<System.Reactive.Unit> SetGetMethod(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue,
            IObservable<System.Reflection.Emit.MethodBuilder> mdBuilder)
        {
            return ObservableExt.ZipExecute(PropertyBuilderValue, mdBuilder,
                (PropertyBuilderValueLambda, mdBuilderLambda) =>
                    PropertyBuilderValueLambda.SetGetMethod(mdBuilderLambda));
        }


        public static IObservable<System.Reactive.Unit> SetSetMethod(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue,
            IObservable<System.Reflection.Emit.MethodBuilder> mdBuilder)
        {
            return ObservableExt.ZipExecute(PropertyBuilderValue, mdBuilder,
                (PropertyBuilderValueLambda, mdBuilderLambda) =>
                    PropertyBuilderValueLambda.SetSetMethod(mdBuilderLambda));
        }


        public static IObservable<System.Reactive.Unit> AddOtherMethod(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue,
            IObservable<System.Reflection.Emit.MethodBuilder> mdBuilder)
        {
            return ObservableExt.ZipExecute(PropertyBuilderValue, mdBuilder,
                (PropertyBuilderValueLambda, mdBuilderLambda) =>
                    PropertyBuilderValueLambda.AddOtherMethod(mdBuilderLambda));
        }


        public static IObservable<System.Reactive.Unit> SetCustomAttribute(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue,
            IObservable<System.Reflection.ConstructorInfo> con, IObservable<System.Byte[]> binaryAttribute)
        {
            return ObservableExt.ZipExecute(PropertyBuilderValue, con, binaryAttribute,
                (PropertyBuilderValueLambda, conLambda, binaryAttributeLambda) =>
                    PropertyBuilderValueLambda.SetCustomAttribute(conLambda, binaryAttributeLambda));
        }


        public static IObservable<System.Reactive.Unit> SetCustomAttribute(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue,
            IObservable<System.Reflection.Emit.CustomAttributeBuilder> customBuilder)
        {
            return ObservableExt.ZipExecute(PropertyBuilderValue, customBuilder,
                (PropertyBuilderValueLambda, customBuilderLambda) =>
                    PropertyBuilderValueLambda.SetCustomAttribute(customBuilderLambda));
        }


        public static IObservable<System.Object> GetValue(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue,
            IObservable<System.Object> obj, IObservable<System.Object[]> index)
        {
            return Observable.Zip(PropertyBuilderValue, obj, index,
                (PropertyBuilderValueLambda, objLambda, indexLambda) =>
                    PropertyBuilderValueLambda.GetValue(objLambda, indexLambda));
        }


        public static IObservable<System.Object> GetValue(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue,
            IObservable<System.Object> obj, IObservable<System.Reflection.BindingFlags> invokeAttr,
            IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> index,
            IObservable<System.Globalization.CultureInfo> culture)
        {
            return Observable.Zip(PropertyBuilderValue, obj, invokeAttr, binder, index, culture,
                (PropertyBuilderValueLambda, objLambda, invokeAttrLambda, binderLambda, indexLambda, cultureLambda) =>
                    PropertyBuilderValueLambda.GetValue(objLambda, invokeAttrLambda, binderLambda, indexLambda,
                        cultureLambda));
        }


        public static IObservable<System.Reactive.Unit> SetValue(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue,
            IObservable<System.Object> obj, IObservable<System.Object> value, IObservable<System.Object[]> index)
        {
            return ObservableExt.ZipExecute(PropertyBuilderValue, obj, value, index,
                (PropertyBuilderValueLambda, objLambda, valueLambda, indexLambda) =>
                    PropertyBuilderValueLambda.SetValue(objLambda, valueLambda, indexLambda));
        }


        public static IObservable<System.Reactive.Unit> SetValue(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue,
            IObservable<System.Object> obj, IObservable<System.Object> value,
            IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder,
            IObservable<System.Object[]> index, IObservable<System.Globalization.CultureInfo> culture)
        {
            return ObservableExt.ZipExecute(PropertyBuilderValue, obj, value, invokeAttr, binder, index, culture,
                (PropertyBuilderValueLambda, objLambda, valueLambda, invokeAttrLambda, binderLambda, indexLambda,
                    cultureLambda) =>
                    PropertyBuilderValueLambda.SetValue(objLambda, valueLambda, invokeAttrLambda, binderLambda,
                        indexLambda, cultureLambda));
        }


        public static IObservable<System.Reflection.MethodInfo[]> GetAccessors(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue,
            IObservable<System.Boolean> nonPublic)
        {
            return Observable.Zip(PropertyBuilderValue, nonPublic,
                (PropertyBuilderValueLambda, nonPublicLambda) =>
                    PropertyBuilderValueLambda.GetAccessors(nonPublicLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetGetMethod(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue,
            IObservable<System.Boolean> nonPublic)
        {
            return Observable.Zip(PropertyBuilderValue, nonPublic,
                (PropertyBuilderValueLambda, nonPublicLambda) =>
                    PropertyBuilderValueLambda.GetGetMethod(nonPublicLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetSetMethod(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue,
            IObservable<System.Boolean> nonPublic)
        {
            return Observable.Zip(PropertyBuilderValue, nonPublic,
                (PropertyBuilderValueLambda, nonPublicLambda) =>
                    PropertyBuilderValueLambda.GetSetMethod(nonPublicLambda));
        }


        public static IObservable<System.Reflection.ParameterInfo[]> GetIndexParameters(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue)
        {
            return Observable.Select(PropertyBuilderValue,
                (PropertyBuilderValueLambda) => PropertyBuilderValueLambda.GetIndexParameters());
        }


        public static IObservable<System.Object[]> GetCustomAttributes(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue,
            IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(PropertyBuilderValue, inherit,
                (PropertyBuilderValueLambda, inheritLambda) =>
                    PropertyBuilderValueLambda.GetCustomAttributes(inheritLambda));
        }


        public static IObservable<System.Object[]> GetCustomAttributes(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(PropertyBuilderValue, attributeType, inherit,
                (PropertyBuilderValueLambda, attributeTypeLambda, inheritLambda) =>
                    PropertyBuilderValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(PropertyBuilderValue, attributeType, inherit,
                (PropertyBuilderValueLambda, attributeTypeLambda, inheritLambda) =>
                    PropertyBuilderValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Reflection.Emit.PropertyToken> get_PropertyToken(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue)
        {
            return Observable.Select(PropertyBuilderValue,
                (PropertyBuilderValueLambda) => PropertyBuilderValueLambda.PropertyToken);
        }


        public static IObservable<System.Reflection.Module> get_Module(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue)
        {
            return Observable.Select(PropertyBuilderValue,
                (PropertyBuilderValueLambda) => PropertyBuilderValueLambda.Module);
        }


        public static IObservable<System.Type> get_PropertyType(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue)
        {
            return Observable.Select(PropertyBuilderValue,
                (PropertyBuilderValueLambda) => PropertyBuilderValueLambda.PropertyType);
        }


        public static IObservable<System.Reflection.PropertyAttributes> get_Attributes(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue)
        {
            return Observable.Select(PropertyBuilderValue,
                (PropertyBuilderValueLambda) => PropertyBuilderValueLambda.Attributes);
        }


        public static IObservable<System.Boolean> get_CanRead(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue)
        {
            return Observable.Select(PropertyBuilderValue,
                (PropertyBuilderValueLambda) => PropertyBuilderValueLambda.CanRead);
        }


        public static IObservable<System.Boolean> get_CanWrite(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue)
        {
            return Observable.Select(PropertyBuilderValue,
                (PropertyBuilderValueLambda) => PropertyBuilderValueLambda.CanWrite);
        }


        public static IObservable<System.String> get_Name(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue)
        {
            return Observable.Select(PropertyBuilderValue,
                (PropertyBuilderValueLambda) => PropertyBuilderValueLambda.Name);
        }


        public static IObservable<System.Type> get_DeclaringType(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue)
        {
            return Observable.Select(PropertyBuilderValue,
                (PropertyBuilderValueLambda) => PropertyBuilderValueLambda.DeclaringType);
        }


        public static IObservable<System.Type> get_ReflectedType(
            this IObservable<System.Reflection.Emit.PropertyBuilder> PropertyBuilderValue)
        {
            return Observable.Select(PropertyBuilderValue,
                (PropertyBuilderValueLambda) => PropertyBuilderValueLambda.ReflectedType);
        }
    }
}