using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __ConstructorInfo
    {
        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Reflection.ConstructorInfo> ConstructorInfoValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(ConstructorInfoValue, obj,
                (ConstructorInfoValueLambda, objLambda) => ConstructorInfoValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Reflection.ConstructorInfo> ConstructorInfoValue)
        {
            return Observable.Select(ConstructorInfoValue,
                (ConstructorInfoValueLambda) => ConstructorInfoValueLambda.GetHashCode());
        }


        public static IObservable<System.Object> Invoke(
            this IObservable<System.Reflection.ConstructorInfo> ConstructorInfoValue,
            IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder,
            IObservable<System.Object[]> parameters, IObservable<System.Globalization.CultureInfo> culture)
        {
            return Observable.Zip(ConstructorInfoValue, invokeAttr, binder, parameters, culture,
                (ConstructorInfoValueLambda, invokeAttrLambda, binderLambda, parametersLambda, cultureLambda) =>
                    ConstructorInfoValueLambda.Invoke(invokeAttrLambda, binderLambda, parametersLambda, cultureLambda));
        }


        public static IObservable<System.Object> Invoke(
            this IObservable<System.Reflection.ConstructorInfo> ConstructorInfoValue,
            IObservable<System.Object[]> parameters)
        {
            return Observable.Zip(ConstructorInfoValue, parameters,
                (ConstructorInfoValueLambda, parametersLambda) => ConstructorInfoValueLambda.Invoke(parametersLambda));
        }


        public static IObservable<System.Reflection.MemberTypes> get_MemberType(
            this IObservable<System.Reflection.ConstructorInfo> ConstructorInfoValue)
        {
            return Observable.Select(ConstructorInfoValue,
                (ConstructorInfoValueLambda) => ConstructorInfoValueLambda.MemberType);
        }
    }
}