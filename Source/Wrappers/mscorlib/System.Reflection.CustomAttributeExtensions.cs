using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __CustomAttributeExtensions
    {
        
        public static IObservable<System.Attribute> GetCustomAttribute(IObservable<System.Reflection.Assembly> element, IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType, (elementLambda, attributeTypeLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttribute(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Attribute> GetCustomAttribute(IObservable<System.Reflection.Module> element, IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType, (elementLambda, attributeTypeLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttribute(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Attribute> GetCustomAttribute(IObservable<System.Reflection.MemberInfo> element, IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType, (elementLambda, attributeTypeLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttribute(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Attribute> GetCustomAttribute(IObservable<System.Reflection.ParameterInfo> element, IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType, (elementLambda, attributeTypeLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttribute(elementLambda, attributeTypeLambda));
        }


        public static IObservable<T> GetCustomAttribute<T>(IObservable<System.Reflection.Assembly> element) where T : System.Attribute
        {
            return Observable.Select(element, (elementLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttribute<T>(elementLambda));
        }


        public static IObservable<T> GetCustomAttribute<T>(IObservable<System.Reflection.Module> element) where T : System.Attribute
        {
            return Observable.Select(element, (elementLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttribute<T>(elementLambda));
        }


        public static IObservable<T> GetCustomAttribute<T>(IObservable<System.Reflection.MemberInfo> element) where T : System.Attribute
        {
            return Observable.Select(element, (elementLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttribute<T>(elementLambda));
        }


        public static IObservable<T> GetCustomAttribute<T>(IObservable<System.Reflection.ParameterInfo> element) where T : System.Attribute
        {
            return Observable.Select(element, (elementLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttribute<T>(elementLambda));
        }


        public static IObservable<System.Attribute> GetCustomAttribute(IObservable<System.Reflection.MemberInfo> element, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, attributeType, inherit, (elementLambda, attributeTypeLambda, inheritLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttribute(elementLambda, attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Attribute> GetCustomAttribute(IObservable<System.Reflection.ParameterInfo> element, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, attributeType, inherit, (elementLambda, attributeTypeLambda, inheritLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttribute(elementLambda, attributeTypeLambda, inheritLambda));
        }


        public static IObservable<T> GetCustomAttribute<T>(IObservable<System.Reflection.MemberInfo> element, IObservable<System.Boolean> inherit) where T : System.Attribute
        {
            return Observable.Zip(element, inherit, (elementLambda, inheritLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttribute<T>(elementLambda, inheritLambda));
        }


        public static IObservable<T> GetCustomAttribute<T>(IObservable<System.Reflection.ParameterInfo> element, IObservable<System.Boolean> inherit) where T : System.Attribute
        {
            return Observable.Zip(element, inherit, (elementLambda, inheritLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttribute<T>(elementLambda, inheritLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Attribute>> GetCustomAttributes(IObservable<System.Reflection.Assembly> element)
        {
            return Observable.Select(element, (elementLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttributes(elementLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Attribute>> GetCustomAttributes(IObservable<System.Reflection.Module> element)
        {
            return Observable.Select(element, (elementLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttributes(elementLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Attribute>> GetCustomAttributes(IObservable<System.Reflection.MemberInfo> element)
        {
            return Observable.Select(element, (elementLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttributes(elementLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Attribute>> GetCustomAttributes(IObservable<System.Reflection.ParameterInfo> element)
        {
            return Observable.Select(element, (elementLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttributes(elementLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Attribute>> GetCustomAttributes(IObservable<System.Reflection.MemberInfo> element, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, inherit, (elementLambda, inheritLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttributes(elementLambda, inheritLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Attribute>> GetCustomAttributes(IObservable<System.Reflection.ParameterInfo> element, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, inherit, (elementLambda, inheritLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttributes(elementLambda, inheritLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Attribute>> GetCustomAttributes(IObservable<System.Reflection.Assembly> element, IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType, (elementLambda, attributeTypeLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttributes(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Attribute>> GetCustomAttributes(IObservable<System.Reflection.Module> element, IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType, (elementLambda, attributeTypeLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttributes(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Attribute>> GetCustomAttributes(IObservable<System.Reflection.MemberInfo> element, IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType, (elementLambda, attributeTypeLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttributes(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Attribute>> GetCustomAttributes(IObservable<System.Reflection.ParameterInfo> element, IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType, (elementLambda, attributeTypeLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttributes(elementLambda, attributeTypeLambda));
        }


        public static IObservable<IEnumerable<T>> GetCustomAttributes<T>(IObservable<System.Reflection.Assembly> element) where T : System.Attribute
        {
            return Observable.Select(element, (elementLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttributes<T>(elementLambda));
        }


        public static IObservable<IEnumerable<T>> GetCustomAttributes<T>(IObservable<System.Reflection.Module> element) where T : System.Attribute
        {
            return Observable.Select(element, (elementLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttributes<T>(elementLambda));
        }


        public static IObservable<IEnumerable<T>> GetCustomAttributes<T>(IObservable<System.Reflection.MemberInfo> element) where T : System.Attribute
        {
            return Observable.Select(element, (elementLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttributes<T>(elementLambda));
        }


        public static IObservable<IEnumerable<T>> GetCustomAttributes<T>(IObservable<System.Reflection.ParameterInfo> element) where T : System.Attribute
        {
            return Observable.Select(element, (elementLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttributes<T>(elementLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Attribute>> GetCustomAttributes(IObservable<System.Reflection.MemberInfo> element, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, attributeType, inherit, (elementLambda, attributeTypeLambda, inheritLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttributes(elementLambda, attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Attribute>> GetCustomAttributes(IObservable<System.Reflection.ParameterInfo> element, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, attributeType, inherit, (elementLambda, attributeTypeLambda, inheritLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttributes(elementLambda, attributeTypeLambda, inheritLambda));
        }


        public static IObservable<IEnumerable<T>> GetCustomAttributes<T>(IObservable<System.Reflection.MemberInfo> element, IObservable<System.Boolean> inherit) where T : System.Attribute
        {
            return Observable.Zip(element, inherit, (elementLambda, inheritLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttributes<T>(elementLambda, inheritLambda));
        }


        public static IObservable<IEnumerable<T>> GetCustomAttributes<T>(IObservable<System.Reflection.ParameterInfo> element, IObservable<System.Boolean> inherit) where T : System.Attribute
        {
            return Observable.Zip(element, inherit, (elementLambda, inheritLambda) => System.Reflection.CustomAttributeExtensions.GetCustomAttributes<T>(elementLambda, inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(IObservable<System.Reflection.Assembly> element, IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType, (elementLambda, attributeTypeLambda) => System.Reflection.CustomAttributeExtensions.IsDefined(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Boolean> IsDefined(IObservable<System.Reflection.Module> element, IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType, (elementLambda, attributeTypeLambda) => System.Reflection.CustomAttributeExtensions.IsDefined(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Boolean> IsDefined(IObservable<System.Reflection.MemberInfo> element, IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType, (elementLambda, attributeTypeLambda) => System.Reflection.CustomAttributeExtensions.IsDefined(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Boolean> IsDefined(IObservable<System.Reflection.ParameterInfo> element, IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType, (elementLambda, attributeTypeLambda) => System.Reflection.CustomAttributeExtensions.IsDefined(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Boolean> IsDefined(IObservable<System.Reflection.MemberInfo> element, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, attributeType, inherit, (elementLambda, attributeTypeLambda, inheritLambda) => System.Reflection.CustomAttributeExtensions.IsDefined(elementLambda, attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(IObservable<System.Reflection.ParameterInfo> element, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, attributeType, inherit, (elementLambda, attributeTypeLambda, inheritLambda) => System.Reflection.CustomAttributeExtensions.IsDefined(elementLambda, attributeTypeLambda, inheritLambda));
        }

    }
}