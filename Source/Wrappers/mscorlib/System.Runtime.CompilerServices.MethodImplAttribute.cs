using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
    public static class __MethodImplAttribute
    {
        
        public static IObservable<System.Runtime.CompilerServices.MethodImplOptions> get_Value(this IObservable<System.Runtime.CompilerServices.MethodImplAttribute> MethodImplAttributeValue)
        {
            return Observable.Select(MethodImplAttributeValue, (MethodImplAttributeValueLambda) => MethodImplAttributeValueLambda.Value);
        }

    }
}