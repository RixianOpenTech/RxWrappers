using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.Contracts
{
    public static class __ContractClassAttribute
    {
        
        public static IObservable<System.Type> get_TypeContainingContracts(this IObservable<System.Diagnostics.Contracts.ContractClassAttribute> ContractClassAttributeValue)
        {
            return Observable.Select(ContractClassAttributeValue, (ContractClassAttributeValueLambda) => ContractClassAttributeValueLambda.TypeContainingContracts);
        }

    }
}