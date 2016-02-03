using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
    public static class __ReferenceAssemblyAttribute
    {
        
        public static IObservable<System.String> get_Description(this IObservable<System.Runtime.CompilerServices.ReferenceAssemblyAttribute> ReferenceAssemblyAttributeValue)
        {
            return Observable.Select(ReferenceAssemblyAttributeValue, (ReferenceAssemblyAttributeValueLambda) => ReferenceAssemblyAttributeValueLambda.Description);
        }

    }
}