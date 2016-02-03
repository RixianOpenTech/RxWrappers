using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Resources
{
    public static class __SatelliteContractVersionAttribute
    {
        public static IObservable<System.String> get_Version(
            this IObservable<System.Resources.SatelliteContractVersionAttribute> SatelliteContractVersionAttributeValue)
        {
            return Observable.Select(SatelliteContractVersionAttributeValue,
                (SatelliteContractVersionAttributeValueLambda) => SatelliteContractVersionAttributeValueLambda.Version);
        }
    }
}