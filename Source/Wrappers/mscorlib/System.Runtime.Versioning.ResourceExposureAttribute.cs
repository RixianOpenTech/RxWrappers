using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Versioning
{
    public static class __ResourceExposureAttribute
    {
        public static IObservable<System.Runtime.Versioning.ResourceScope> get_ResourceExposureLevel(
            this IObservable<System.Runtime.Versioning.ResourceExposureAttribute> ResourceExposureAttributeValue)
        {
            return Observable.Select(ResourceExposureAttributeValue,
                (ResourceExposureAttributeValueLambda) => ResourceExposureAttributeValueLambda.ResourceExposureLevel);
        }
    }
}