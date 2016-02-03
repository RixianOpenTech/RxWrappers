using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __BestFitMappingAttribute
    {
        public static IObservable<System.Boolean> get_BestFitMapping(
            this IObservable<System.Runtime.InteropServices.BestFitMappingAttribute> BestFitMappingAttributeValue)
        {
            return Observable.Select(BestFitMappingAttributeValue,
                (BestFitMappingAttributeValueLambda) => BestFitMappingAttributeValueLambda.BestFitMapping);
        }
    }
}