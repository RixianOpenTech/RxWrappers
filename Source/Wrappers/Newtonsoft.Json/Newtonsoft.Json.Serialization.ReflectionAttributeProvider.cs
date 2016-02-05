using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __ReflectionAttributeProvider
    {
        
        public static IObservable<System.Collections.Generic.IList<System.Attribute>> GetAttributes(this IObservable<Newtonsoft.Json.Serialization.ReflectionAttributeProvider> ReflectionAttributeProviderValue, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(ReflectionAttributeProviderValue, inherit, (ReflectionAttributeProviderValueLambda, inheritLambda) => ReflectionAttributeProviderValueLambda.GetAttributes(inheritLambda));
        }


        public static IObservable<System.Collections.Generic.IList<System.Attribute>> GetAttributes(this IObservable<Newtonsoft.Json.Serialization.ReflectionAttributeProvider> ReflectionAttributeProviderValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(ReflectionAttributeProviderValue, attributeType, inherit, (ReflectionAttributeProviderValueLambda, attributeTypeLambda, inheritLambda) => ReflectionAttributeProviderValueLambda.GetAttributes(attributeTypeLambda, inheritLambda));
        }

    }
}