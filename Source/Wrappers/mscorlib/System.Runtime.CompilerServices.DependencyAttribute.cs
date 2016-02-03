using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
    public static class __DependencyAttribute
    {
        
        public static IObservable<System.String> get_DependentAssembly(this IObservable<System.Runtime.CompilerServices.DependencyAttribute> DependencyAttributeValue)
        {
            return Observable.Select(DependencyAttributeValue, (DependencyAttributeValueLambda) => DependencyAttributeValueLambda.DependentAssembly);
        }


        public static IObservable<System.Runtime.CompilerServices.LoadHint> get_LoadHint(this IObservable<System.Runtime.CompilerServices.DependencyAttribute> DependencyAttributeValue)
        {
            return Observable.Select(DependencyAttributeValue, (DependencyAttributeValueLambda) => DependencyAttributeValueLambda.LoadHint);
        }

    }
}