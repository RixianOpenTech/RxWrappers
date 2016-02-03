using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __ParameterInfo
    {
        public static IObservable<System.Type[]> GetRequiredCustomModifiers(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue)
        {
            return Observable.Select(ParameterInfoValue,
                (ParameterInfoValueLambda) => ParameterInfoValueLambda.GetRequiredCustomModifiers());
        }


        public static IObservable<System.Type[]> GetOptionalCustomModifiers(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue)
        {
            return Observable.Select(ParameterInfoValue,
                (ParameterInfoValueLambda) => ParameterInfoValueLambda.GetOptionalCustomModifiers());
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue)
        {
            return Observable.Select(ParameterInfoValue,
                (ParameterInfoValueLambda) => ParameterInfoValueLambda.ToString());
        }


        public static IObservable<System.Object[]> GetCustomAttributes(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(ParameterInfoValue, inherit,
                (ParameterInfoValueLambda, inheritLambda) => ParameterInfoValueLambda.GetCustomAttributes(inheritLambda));
        }


        public static IObservable<System.Object[]> GetCustomAttributes(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue, IObservable<System.Type> attributeType,
            IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(ParameterInfoValue, attributeType, inherit,
                (ParameterInfoValueLambda, attributeTypeLambda, inheritLambda) =>
                    ParameterInfoValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue, IObservable<System.Type> attributeType,
            IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(ParameterInfoValue, attributeType, inherit,
                (ParameterInfoValueLambda, attributeTypeLambda, inheritLambda) =>
                    ParameterInfoValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Collections.Generic.IList<System.Reflection.CustomAttributeData>>
            GetCustomAttributesData(this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue)
        {
            return Observable.Select(ParameterInfoValue,
                (ParameterInfoValueLambda) => ParameterInfoValueLambda.GetCustomAttributesData());
        }


        public static IObservable<System.Object> GetRealObject(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return Observable.Zip(ParameterInfoValue, context,
                (ParameterInfoValueLambda, contextLambda) => ParameterInfoValueLambda.GetRealObject(contextLambda));
        }


        public static IObservable<System.Type> get_ParameterType(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue)
        {
            return Observable.Select(ParameterInfoValue,
                (ParameterInfoValueLambda) => ParameterInfoValueLambda.ParameterType);
        }


        public static IObservable<System.String> get_Name(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue)
        {
            return Observable.Select(ParameterInfoValue, (ParameterInfoValueLambda) => ParameterInfoValueLambda.Name);
        }


        public static IObservable<System.Boolean> get_HasDefaultValue(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue)
        {
            return Observable.Select(ParameterInfoValue,
                (ParameterInfoValueLambda) => ParameterInfoValueLambda.HasDefaultValue);
        }


        public static IObservable<System.Object> get_DefaultValue(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue)
        {
            return Observable.Select(ParameterInfoValue,
                (ParameterInfoValueLambda) => ParameterInfoValueLambda.DefaultValue);
        }


        public static IObservable<System.Object> get_RawDefaultValue(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue)
        {
            return Observable.Select(ParameterInfoValue,
                (ParameterInfoValueLambda) => ParameterInfoValueLambda.RawDefaultValue);
        }


        public static IObservable<System.Int32> get_Position(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue)
        {
            return Observable.Select(ParameterInfoValue, (ParameterInfoValueLambda) => ParameterInfoValueLambda.Position);
        }


        public static IObservable<System.Reflection.ParameterAttributes> get_Attributes(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue)
        {
            return Observable.Select(ParameterInfoValue,
                (ParameterInfoValueLambda) => ParameterInfoValueLambda.Attributes);
        }


        public static IObservable<System.Reflection.MemberInfo> get_Member(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue)
        {
            return Observable.Select(ParameterInfoValue, (ParameterInfoValueLambda) => ParameterInfoValueLambda.Member);
        }


        public static IObservable<System.Boolean> get_IsIn(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue)
        {
            return Observable.Select(ParameterInfoValue, (ParameterInfoValueLambda) => ParameterInfoValueLambda.IsIn);
        }


        public static IObservable<System.Boolean> get_IsOut(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue)
        {
            return Observable.Select(ParameterInfoValue, (ParameterInfoValueLambda) => ParameterInfoValueLambda.IsOut);
        }


        public static IObservable<System.Boolean> get_IsLcid(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue)
        {
            return Observable.Select(ParameterInfoValue, (ParameterInfoValueLambda) => ParameterInfoValueLambda.IsLcid);
        }


        public static IObservable<System.Boolean> get_IsRetval(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue)
        {
            return Observable.Select(ParameterInfoValue, (ParameterInfoValueLambda) => ParameterInfoValueLambda.IsRetval);
        }


        public static IObservable<System.Boolean> get_IsOptional(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue)
        {
            return Observable.Select(ParameterInfoValue,
                (ParameterInfoValueLambda) => ParameterInfoValueLambda.IsOptional);
        }


        public static IObservable<System.Int32> get_MetadataToken(
            this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue)
        {
            return Observable.Select(ParameterInfoValue,
                (ParameterInfoValueLambda) => ParameterInfoValueLambda.MetadataToken);
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>>
            get_CustomAttributes(this IObservable<System.Reflection.ParameterInfo> ParameterInfoValue)
        {
            return Observable.Select(ParameterInfoValue,
                (ParameterInfoValueLambda) => ParameterInfoValueLambda.CustomAttributes);
        }
    }
}