using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.Contracts
{
public static class _ContractPublicPropertyNameAttribute
{
    
public static IObservable<System.String> get_Name(this IObservable<System.Diagnostics.Contracts.ContractPublicPropertyNameAttribute> ContractPublicPropertyNameAttributeValue)
{
    return Observable.Select(ContractPublicPropertyNameAttributeValue, (ContractPublicPropertyNameAttributeValueLambda) => ContractPublicPropertyNameAttributeValueLambda.Name);
}

}
}