using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Attribute
    {
        public static IObservable<System.Attribute[]> GetCustomAttributes(
            IObservable<System.Reflection.MemberInfo> element, IObservable<System.Type> type)
        {
            return Observable.Zip(element, type,
                (elementLambda, typeLambda) => System.Attribute.GetCustomAttributes(elementLambda, typeLambda));
        }


        public static IObservable<System.Attribute[]> GetCustomAttributes(
            IObservable<System.Reflection.MemberInfo> element, IObservable<System.Type> type,
            IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, type, inherit,
                (elementLambda, typeLambda, inheritLambda) =>
                    System.Attribute.GetCustomAttributes(elementLambda, typeLambda, inheritLambda));
        }


        public static IObservable<System.Attribute[]> GetCustomAttributes(
            IObservable<System.Reflection.MemberInfo> element)
        {
            return Observable.Select(element, (elementLambda) => System.Attribute.GetCustomAttributes(elementLambda));
        }


        public static IObservable<System.Attribute[]> GetCustomAttributes(
            IObservable<System.Reflection.MemberInfo> element, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, inherit,
                (elementLambda, inheritLambda) => System.Attribute.GetCustomAttributes(elementLambda, inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(IObservable<System.Reflection.MemberInfo> element,
            IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType,
                (elementLambda, attributeTypeLambda) => System.Attribute.IsDefined(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Boolean> IsDefined(IObservable<System.Reflection.MemberInfo> element,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, attributeType, inherit,
                (elementLambda, attributeTypeLambda, inheritLambda) =>
                    System.Attribute.IsDefined(elementLambda, attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Attribute> GetCustomAttribute(
            IObservable<System.Reflection.MemberInfo> element, IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType,
                (elementLambda, attributeTypeLambda) =>
                    System.Attribute.GetCustomAttribute(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Attribute> GetCustomAttribute(
            IObservable<System.Reflection.MemberInfo> element, IObservable<System.Type> attributeType,
            IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, attributeType, inherit,
                (elementLambda, attributeTypeLambda, inheritLambda) =>
                    System.Attribute.GetCustomAttribute(elementLambda, attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Attribute[]> GetCustomAttributes(
            IObservable<System.Reflection.ParameterInfo> element)
        {
            return Observable.Select(element, (elementLambda) => System.Attribute.GetCustomAttributes(elementLambda));
        }


        public static IObservable<System.Attribute[]> GetCustomAttributes(
            IObservable<System.Reflection.ParameterInfo> element, IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType,
                (elementLambda, attributeTypeLambda) =>
                    System.Attribute.GetCustomAttributes(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Attribute[]> GetCustomAttributes(
            IObservable<System.Reflection.ParameterInfo> element, IObservable<System.Type> attributeType,
            IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, attributeType, inherit,
                (elementLambda, attributeTypeLambda, inheritLambda) =>
                    System.Attribute.GetCustomAttributes(elementLambda, attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Attribute[]> GetCustomAttributes(
            IObservable<System.Reflection.ParameterInfo> element, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, inherit,
                (elementLambda, inheritLambda) => System.Attribute.GetCustomAttributes(elementLambda, inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(IObservable<System.Reflection.ParameterInfo> element,
            IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType,
                (elementLambda, attributeTypeLambda) => System.Attribute.IsDefined(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Boolean> IsDefined(IObservable<System.Reflection.ParameterInfo> element,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, attributeType, inherit,
                (elementLambda, attributeTypeLambda, inheritLambda) =>
                    System.Attribute.IsDefined(elementLambda, attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Attribute> GetCustomAttribute(
            IObservable<System.Reflection.ParameterInfo> element, IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType,
                (elementLambda, attributeTypeLambda) =>
                    System.Attribute.GetCustomAttribute(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Attribute> GetCustomAttribute(
            IObservable<System.Reflection.ParameterInfo> element, IObservable<System.Type> attributeType,
            IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, attributeType, inherit,
                (elementLambda, attributeTypeLambda, inheritLambda) =>
                    System.Attribute.GetCustomAttribute(elementLambda, attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Attribute[]> GetCustomAttributes(IObservable<System.Reflection.Module> element,
            IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType,
                (elementLambda, attributeTypeLambda) =>
                    System.Attribute.GetCustomAttributes(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Attribute[]> GetCustomAttributes(IObservable<System.Reflection.Module> element)
        {
            return Observable.Select(element, (elementLambda) => System.Attribute.GetCustomAttributes(elementLambda));
        }


        public static IObservable<System.Attribute[]> GetCustomAttributes(IObservable<System.Reflection.Module> element,
            IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, inherit,
                (elementLambda, inheritLambda) => System.Attribute.GetCustomAttributes(elementLambda, inheritLambda));
        }


        public static IObservable<System.Attribute[]> GetCustomAttributes(IObservable<System.Reflection.Module> element,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, attributeType, inherit,
                (elementLambda, attributeTypeLambda, inheritLambda) =>
                    System.Attribute.GetCustomAttributes(elementLambda, attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(IObservable<System.Reflection.Module> element,
            IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType,
                (elementLambda, attributeTypeLambda) => System.Attribute.IsDefined(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Boolean> IsDefined(IObservable<System.Reflection.Module> element,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, attributeType, inherit,
                (elementLambda, attributeTypeLambda, inheritLambda) =>
                    System.Attribute.IsDefined(elementLambda, attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Attribute> GetCustomAttribute(IObservable<System.Reflection.Module> element,
            IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType,
                (elementLambda, attributeTypeLambda) =>
                    System.Attribute.GetCustomAttribute(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Attribute> GetCustomAttribute(IObservable<System.Reflection.Module> element,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, attributeType, inherit,
                (elementLambda, attributeTypeLambda, inheritLambda) =>
                    System.Attribute.GetCustomAttribute(elementLambda, attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Attribute[]> GetCustomAttributes(
            IObservable<System.Reflection.Assembly> element, IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType,
                (elementLambda, attributeTypeLambda) =>
                    System.Attribute.GetCustomAttributes(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Attribute[]> GetCustomAttributes(
            IObservable<System.Reflection.Assembly> element, IObservable<System.Type> attributeType,
            IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, attributeType, inherit,
                (elementLambda, attributeTypeLambda, inheritLambda) =>
                    System.Attribute.GetCustomAttributes(elementLambda, attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Attribute[]> GetCustomAttributes(
            IObservable<System.Reflection.Assembly> element)
        {
            return Observable.Select(element, (elementLambda) => System.Attribute.GetCustomAttributes(elementLambda));
        }


        public static IObservable<System.Attribute[]> GetCustomAttributes(
            IObservable<System.Reflection.Assembly> element, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, inherit,
                (elementLambda, inheritLambda) => System.Attribute.GetCustomAttributes(elementLambda, inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(IObservable<System.Reflection.Assembly> element,
            IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType,
                (elementLambda, attributeTypeLambda) => System.Attribute.IsDefined(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Boolean> IsDefined(IObservable<System.Reflection.Assembly> element,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, attributeType, inherit,
                (elementLambda, attributeTypeLambda, inheritLambda) =>
                    System.Attribute.IsDefined(elementLambda, attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Attribute> GetCustomAttribute(IObservable<System.Reflection.Assembly> element,
            IObservable<System.Type> attributeType)
        {
            return Observable.Zip(element, attributeType,
                (elementLambda, attributeTypeLambda) =>
                    System.Attribute.GetCustomAttribute(elementLambda, attributeTypeLambda));
        }


        public static IObservable<System.Attribute> GetCustomAttribute(IObservable<System.Reflection.Assembly> element,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(element, attributeType, inherit,
                (elementLambda, attributeTypeLambda, inheritLambda) =>
                    System.Attribute.GetCustomAttribute(elementLambda, attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Attribute> AttributeValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(AttributeValue, obj,
                (AttributeValueLambda, objLambda) => AttributeValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Attribute> AttributeValue)
        {
            return Observable.Select(AttributeValue, (AttributeValueLambda) => AttributeValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Match(this IObservable<System.Attribute> AttributeValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(AttributeValue, obj,
                (AttributeValueLambda, objLambda) => AttributeValueLambda.Match(objLambda));
        }


        public static IObservable<System.Boolean> IsDefaultAttribute(this IObservable<System.Attribute> AttributeValue)
        {
            return Observable.Select(AttributeValue, (AttributeValueLambda) => AttributeValueLambda.IsDefaultAttribute());
        }


        public static IObservable<System.Object> get_TypeId(this IObservable<System.Attribute> AttributeValue)
        {
            return Observable.Select(AttributeValue, (AttributeValueLambda) => AttributeValueLambda.TypeId);
        }
    }
}