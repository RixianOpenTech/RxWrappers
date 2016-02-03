using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __CustomAttributeData
    {
        public static IObservable<System.Collections.Generic.IList<System.Reflection.CustomAttributeData>>
            GetCustomAttributes(IObservable<System.Reflection.MemberInfo> target)
        {
            return Observable.Select(target,
                (targetLambda) => System.Reflection.CustomAttributeData.GetCustomAttributes(targetLambda));
        }


        public static IObservable<System.Collections.Generic.IList<System.Reflection.CustomAttributeData>>
            GetCustomAttributes(IObservable<System.Reflection.Module> target)
        {
            return Observable.Select(target,
                (targetLambda) => System.Reflection.CustomAttributeData.GetCustomAttributes(targetLambda));
        }


        public static IObservable<System.Collections.Generic.IList<System.Reflection.CustomAttributeData>>
            GetCustomAttributes(IObservable<System.Reflection.Assembly> target)
        {
            return Observable.Select(target,
                (targetLambda) => System.Reflection.CustomAttributeData.GetCustomAttributes(targetLambda));
        }


        public static IObservable<System.Collections.Generic.IList<System.Reflection.CustomAttributeData>>
            GetCustomAttributes(IObservable<System.Reflection.ParameterInfo> target)
        {
            return Observable.Select(target,
                (targetLambda) => System.Reflection.CustomAttributeData.GetCustomAttributes(targetLambda));
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Reflection.CustomAttributeData> CustomAttributeDataValue)
        {
            return Observable.Select(CustomAttributeDataValue,
                (CustomAttributeDataValueLambda) => CustomAttributeDataValueLambda.ToString());
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Reflection.CustomAttributeData> CustomAttributeDataValue)
        {
            return Observable.Select(CustomAttributeDataValue,
                (CustomAttributeDataValueLambda) => CustomAttributeDataValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Reflection.CustomAttributeData> CustomAttributeDataValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(CustomAttributeDataValue, obj,
                (CustomAttributeDataValueLambda, objLambda) => CustomAttributeDataValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Type> get_AttributeType(
            this IObservable<System.Reflection.CustomAttributeData> CustomAttributeDataValue)
        {
            return Observable.Select(CustomAttributeDataValue,
                (CustomAttributeDataValueLambda) => CustomAttributeDataValueLambda.AttributeType);
        }


        public static IObservable<System.Reflection.ConstructorInfo> get_Constructor(
            this IObservable<System.Reflection.CustomAttributeData> CustomAttributeDataValue)
        {
            return Observable.Select(CustomAttributeDataValue,
                (CustomAttributeDataValueLambda) => CustomAttributeDataValueLambda.Constructor);
        }


        public static IObservable<System.Collections.Generic.IList<System.Reflection.CustomAttributeTypedArgument>>
            get_ConstructorArguments(this IObservable<System.Reflection.CustomAttributeData> CustomAttributeDataValue)
        {
            return Observable.Select(CustomAttributeDataValue,
                (CustomAttributeDataValueLambda) => CustomAttributeDataValueLambda.ConstructorArguments);
        }


        public static IObservable<System.Collections.Generic.IList<System.Reflection.CustomAttributeNamedArgument>>
            get_NamedArguments(this IObservable<System.Reflection.CustomAttributeData> CustomAttributeDataValue)
        {
            return Observable.Select(CustomAttributeDataValue,
                (CustomAttributeDataValueLambda) => CustomAttributeDataValueLambda.NamedArguments);
        }
    }
}