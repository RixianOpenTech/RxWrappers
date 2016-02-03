using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __ICustomAttributeProvider
    {
        public static IObservable<System.Object[]> GetCustomAttributes(
            this IObservable<System.Reflection.ICustomAttributeProvider> ICustomAttributeProviderValue,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(ICustomAttributeProviderValue, attributeType, inherit,
                (ICustomAttributeProviderValueLambda, attributeTypeLambda, inheritLambda) =>
                    ICustomAttributeProviderValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Object[]> GetCustomAttributes(
            this IObservable<System.Reflection.ICustomAttributeProvider> ICustomAttributeProviderValue,
            IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(ICustomAttributeProviderValue, inherit,
                (ICustomAttributeProviderValueLambda, inheritLambda) =>
                    ICustomAttributeProviderValueLambda.GetCustomAttributes(inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(
            this IObservable<System.Reflection.ICustomAttributeProvider> ICustomAttributeProviderValue,
            IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(ICustomAttributeProviderValue, attributeType, inherit,
                (ICustomAttributeProviderValueLambda, attributeTypeLambda, inheritLambda) =>
                    ICustomAttributeProviderValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
        }
    }
}