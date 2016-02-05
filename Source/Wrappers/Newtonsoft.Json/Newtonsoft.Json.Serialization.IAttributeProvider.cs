using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __IAttributeProvider
    {
        
        public static IObservable<System.Collections.Generic.IList<System.Attribute>> GetAttributes(this IObservable<Newtonsoft.Json.Serialization.IAttributeProvider> IAttributeProviderValue, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(IAttributeProviderValue, inherit, (IAttributeProviderValueLambda, inheritLambda) => IAttributeProviderValueLambda.GetAttributes(inheritLambda));
        }


        public static IObservable<System.Collections.Generic.IList<System.Attribute>> GetAttributes(this IObservable<Newtonsoft.Json.Serialization.IAttributeProvider> IAttributeProviderValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(IAttributeProviderValue, attributeType, inherit, (IAttributeProviderValueLambda, attributeTypeLambda, inheritLambda) => IAttributeProviderValueLambda.GetAttributes(attributeTypeLambda, inheritLambda));
        }

    }
}