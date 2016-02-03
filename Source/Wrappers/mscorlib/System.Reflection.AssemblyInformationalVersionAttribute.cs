using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __AssemblyInformationalVersionAttribute
    {
        
        public static IObservable<System.String> get_InformationalVersion(this IObservable<System.Reflection.AssemblyInformationalVersionAttribute> AssemblyInformationalVersionAttributeValue)
        {
            return Observable.Select(AssemblyInformationalVersionAttributeValue, (AssemblyInformationalVersionAttributeValueLambda) => AssemblyInformationalVersionAttributeValueLambda.InformationalVersion);
        }

    }
}