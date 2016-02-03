using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
    public static class __RequiredAttributeAttribute
    {
        
        public static IObservable<System.Type> get_RequiredContract(this IObservable<System.Runtime.CompilerServices.RequiredAttributeAttribute> RequiredAttributeAttributeValue)
        {
            return Observable.Select(RequiredAttributeAttributeValue, (RequiredAttributeAttributeValueLambda) => RequiredAttributeAttributeValueLambda.RequiredContract);
        }

    }
}