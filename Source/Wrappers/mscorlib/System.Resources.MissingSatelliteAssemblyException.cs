using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Resources
{
    public static class __MissingSatelliteAssemblyException
    {
        
        public static IObservable<System.String> get_CultureName(this IObservable<System.Resources.MissingSatelliteAssemblyException> MissingSatelliteAssemblyExceptionValue)
        {
            return Observable.Select(MissingSatelliteAssemblyExceptionValue, (MissingSatelliteAssemblyExceptionValueLambda) => MissingSatelliteAssemblyExceptionValueLambda.CultureName);
        }

    }
}