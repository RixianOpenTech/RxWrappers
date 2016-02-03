using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __CustomAttributeNamedArgument
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Reflection.CustomAttributeNamedArgument> CustomAttributeNamedArgumentValue)
        {
            return Observable.Select(CustomAttributeNamedArgumentValue, (CustomAttributeNamedArgumentValueLambda) => CustomAttributeNamedArgumentValueLambda.ToString());
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.CustomAttributeNamedArgument> CustomAttributeNamedArgumentValue)
        {
            return Observable.Select(CustomAttributeNamedArgumentValue, (CustomAttributeNamedArgumentValueLambda) => CustomAttributeNamedArgumentValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.CustomAttributeNamedArgument> CustomAttributeNamedArgumentValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(CustomAttributeNamedArgumentValue, obj, (CustomAttributeNamedArgumentValueLambda, objLambda) => CustomAttributeNamedArgumentValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Reflection.MemberInfo> get_MemberInfo(this IObservable<System.Reflection.CustomAttributeNamedArgument> CustomAttributeNamedArgumentValue)
        {
            return Observable.Select(CustomAttributeNamedArgumentValue, (CustomAttributeNamedArgumentValueLambda) => CustomAttributeNamedArgumentValueLambda.MemberInfo);
        }


        public static IObservable<System.Reflection.CustomAttributeTypedArgument> get_TypedValue(this IObservable<System.Reflection.CustomAttributeNamedArgument> CustomAttributeNamedArgumentValue)
        {
            return Observable.Select(CustomAttributeNamedArgumentValue, (CustomAttributeNamedArgumentValueLambda) => CustomAttributeNamedArgumentValueLambda.TypedValue);
        }


        public static IObservable<System.String> get_MemberName(this IObservable<System.Reflection.CustomAttributeNamedArgument> CustomAttributeNamedArgumentValue)
        {
            return Observable.Select(CustomAttributeNamedArgumentValue, (CustomAttributeNamedArgumentValueLambda) => CustomAttributeNamedArgumentValueLambda.MemberName);
        }


        public static IObservable<System.Boolean> get_IsField(this IObservable<System.Reflection.CustomAttributeNamedArgument> CustomAttributeNamedArgumentValue)
        {
            return Observable.Select(CustomAttributeNamedArgumentValue, (CustomAttributeNamedArgumentValueLambda) => CustomAttributeNamedArgumentValueLambda.IsField);
        }

    }
}