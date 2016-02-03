using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Versioning
{
    public static class __ResourceConsumptionAttribute
    {
        
        public static IObservable<System.Runtime.Versioning.ResourceScope> get_ResourceScope(this IObservable<System.Runtime.Versioning.ResourceConsumptionAttribute> ResourceConsumptionAttributeValue)
        {
            return Observable.Select(ResourceConsumptionAttributeValue, (ResourceConsumptionAttributeValueLambda) => ResourceConsumptionAttributeValueLambda.ResourceScope);
        }


        public static IObservable<System.Runtime.Versioning.ResourceScope> get_ConsumptionScope(this IObservable<System.Runtime.Versioning.ResourceConsumptionAttribute> ResourceConsumptionAttributeValue)
        {
            return Observable.Select(ResourceConsumptionAttributeValue, (ResourceConsumptionAttributeValueLambda) => ResourceConsumptionAttributeValueLambda.ConsumptionScope);
        }

    }
}