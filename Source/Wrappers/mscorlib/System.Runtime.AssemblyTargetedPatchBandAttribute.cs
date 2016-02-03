using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime
{
    public static class __AssemblyTargetedPatchBandAttribute
    {
        
        public static IObservable<System.String> get_TargetedPatchBand(this IObservable<System.Runtime.AssemblyTargetedPatchBandAttribute> AssemblyTargetedPatchBandAttributeValue)
        {
            return Observable.Select(AssemblyTargetedPatchBandAttributeValue, (AssemblyTargetedPatchBandAttributeValueLambda) => AssemblyTargetedPatchBandAttributeValueLambda.TargetedPatchBand);
        }

    }
}