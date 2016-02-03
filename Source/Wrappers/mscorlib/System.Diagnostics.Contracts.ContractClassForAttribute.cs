using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.Contracts
{
public static class _ContractClassForAttribute
{
    
public static IObservable<System.Type> get_TypeContractsAreFor(this IObservable<System.Diagnostics.Contracts.ContractClassForAttribute> ContractClassForAttributeValue)
{
    return Observable.Select(ContractClassForAttributeValue, (ContractClassForAttributeValueLambda) => ContractClassForAttributeValueLambda.TypeContractsAreFor);
}

}
}