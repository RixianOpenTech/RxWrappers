using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __PropertyInfo
    {
        
        public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(PropertyInfoValue, obj, (PropertyInfoValueLambda, objLambda) => PropertyInfoValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue)
        {
            return Observable.Select(PropertyInfoValue, (PropertyInfoValueLambda) => PropertyInfoValueLambda.GetHashCode());
        }


        public static IObservable<System.Object> GetConstantValue(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue)
        {
            return Observable.Select(PropertyInfoValue, (PropertyInfoValueLambda) => PropertyInfoValueLambda.GetConstantValue());
        }


        public static IObservable<System.Object> GetRawConstantValue(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue)
        {
            return Observable.Select(PropertyInfoValue, (PropertyInfoValueLambda) => PropertyInfoValueLambda.GetRawConstantValue());
        }


        public static IObservable<System.Reactive.Unit> SetValue(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue, IObservable<System.Object> obj, IObservable<System.Object> value, IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> index, IObservable<System.Globalization.CultureInfo> culture)
        {
            return ObservableExt.ZipExecute(PropertyInfoValue, obj, value, invokeAttr, binder, index, culture, (PropertyInfoValueLambda, objLambda, valueLambda, invokeAttrLambda, binderLambda, indexLambda, cultureLambda) => PropertyInfoValueLambda.SetValue(objLambda, valueLambda, invokeAttrLambda, binderLambda, indexLambda, cultureLambda));
        }


        public static IObservable<System.Reflection.MethodInfo[]> GetAccessors(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue, IObservable<System.Boolean> nonPublic)
        {
            return Observable.Zip(PropertyInfoValue, nonPublic, (PropertyInfoValueLambda, nonPublicLambda) => PropertyInfoValueLambda.GetAccessors(nonPublicLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetGetMethod(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue, IObservable<System.Boolean> nonPublic)
        {
            return Observable.Zip(PropertyInfoValue, nonPublic, (PropertyInfoValueLambda, nonPublicLambda) => PropertyInfoValueLambda.GetGetMethod(nonPublicLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetSetMethod(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue, IObservable<System.Boolean> nonPublic)
        {
            return Observable.Zip(PropertyInfoValue, nonPublic, (PropertyInfoValueLambda, nonPublicLambda) => PropertyInfoValueLambda.GetSetMethod(nonPublicLambda));
        }


        public static IObservable<System.Reflection.ParameterInfo[]> GetIndexParameters(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue)
        {
            return Observable.Select(PropertyInfoValue, (PropertyInfoValueLambda) => PropertyInfoValueLambda.GetIndexParameters());
        }


        public static IObservable<System.Object> GetValue(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(PropertyInfoValue, obj, (PropertyInfoValueLambda, objLambda) => PropertyInfoValueLambda.GetValue(objLambda));
        }


        public static IObservable<System.Object> GetValue(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue, IObservable<System.Object> obj, IObservable<System.Object[]> index)
        {
            return Observable.Zip(PropertyInfoValue, obj, index, (PropertyInfoValueLambda, objLambda, indexLambda) => PropertyInfoValueLambda.GetValue(objLambda, indexLambda));
        }


        public static IObservable<System.Object> GetValue(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue, IObservable<System.Object> obj, IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> index, IObservable<System.Globalization.CultureInfo> culture)
        {
            return Observable.Zip(PropertyInfoValue, obj, invokeAttr, binder, index, culture, (PropertyInfoValueLambda, objLambda, invokeAttrLambda, binderLambda, indexLambda, cultureLambda) => PropertyInfoValueLambda.GetValue(objLambda, invokeAttrLambda, binderLambda, indexLambda, cultureLambda));
        }


        public static IObservable<System.Reactive.Unit> SetValue(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue, IObservable<System.Object> obj, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(PropertyInfoValue, obj, value, (PropertyInfoValueLambda, objLambda, valueLambda) => PropertyInfoValueLambda.SetValue(objLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> SetValue(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue, IObservable<System.Object> obj, IObservable<System.Object> value, IObservable<System.Object[]> index)
        {
            return ObservableExt.ZipExecute(PropertyInfoValue, obj, value, index, (PropertyInfoValueLambda, objLambda, valueLambda, indexLambda) => PropertyInfoValueLambda.SetValue(objLambda, valueLambda, indexLambda));
        }


        public static IObservable<System.Type[]> GetRequiredCustomModifiers(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue)
        {
            return Observable.Select(PropertyInfoValue, (PropertyInfoValueLambda) => PropertyInfoValueLambda.GetRequiredCustomModifiers());
        }


        public static IObservable<System.Type[]> GetOptionalCustomModifiers(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue)
        {
            return Observable.Select(PropertyInfoValue, (PropertyInfoValueLambda) => PropertyInfoValueLambda.GetOptionalCustomModifiers());
        }


        public static IObservable<System.Reflection.MethodInfo[]> GetAccessors(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue)
        {
            return Observable.Select(PropertyInfoValue, (PropertyInfoValueLambda) => PropertyInfoValueLambda.GetAccessors());
        }


        public static IObservable<System.Reflection.MethodInfo> GetGetMethod(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue)
        {
            return Observable.Select(PropertyInfoValue, (PropertyInfoValueLambda) => PropertyInfoValueLambda.GetGetMethod());
        }


        public static IObservable<System.Reflection.MethodInfo> GetSetMethod(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue)
        {
            return Observable.Select(PropertyInfoValue, (PropertyInfoValueLambda) => PropertyInfoValueLambda.GetSetMethod());
        }


        public static IObservable<System.Reflection.MemberTypes> get_MemberType(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue)
        {
            return Observable.Select(PropertyInfoValue, (PropertyInfoValueLambda) => PropertyInfoValueLambda.MemberType);
        }


        public static IObservable<System.Type> get_PropertyType(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue)
        {
            return Observable.Select(PropertyInfoValue, (PropertyInfoValueLambda) => PropertyInfoValueLambda.PropertyType);
        }


        public static IObservable<System.Reflection.PropertyAttributes> get_Attributes(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue)
        {
            return Observable.Select(PropertyInfoValue, (PropertyInfoValueLambda) => PropertyInfoValueLambda.Attributes);
        }


        public static IObservable<System.Boolean> get_CanRead(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue)
        {
            return Observable.Select(PropertyInfoValue, (PropertyInfoValueLambda) => PropertyInfoValueLambda.CanRead);
        }


        public static IObservable<System.Boolean> get_CanWrite(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue)
        {
            return Observable.Select(PropertyInfoValue, (PropertyInfoValueLambda) => PropertyInfoValueLambda.CanWrite);
        }


        public static IObservable<System.Reflection.MethodInfo> get_GetMethod(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue)
        {
            return Observable.Select(PropertyInfoValue, (PropertyInfoValueLambda) => PropertyInfoValueLambda.GetMethod);
        }


        public static IObservable<System.Reflection.MethodInfo> get_SetMethod(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue)
        {
            return Observable.Select(PropertyInfoValue, (PropertyInfoValueLambda) => PropertyInfoValueLambda.SetMethod);
        }


        public static IObservable<System.Boolean> get_IsSpecialName(this IObservable<System.Reflection.PropertyInfo> PropertyInfoValue)
        {
            return Observable.Select(PropertyInfoValue, (PropertyInfoValueLambda) => PropertyInfoValueLambda.IsSpecialName);
        }

    }
}