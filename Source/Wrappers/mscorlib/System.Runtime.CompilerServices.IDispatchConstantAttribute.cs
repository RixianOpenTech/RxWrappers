using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
    public static class __IDispatchConstantAttribute
    {
        
        public static IObservable<System.Object> get_Value(this IObservable<System.Runtime.CompilerServices.IDispatchConstantAttribute> IDispatchConstantAttributeValue)
        {
            return Observable.Select(IDispatchConstantAttributeValue, (IDispatchConstantAttributeValueLambda) => IDispatchConstantAttributeValueLambda.Value);
        }

    }
}