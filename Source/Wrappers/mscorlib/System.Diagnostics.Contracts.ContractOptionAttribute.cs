using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.Contracts
{
public static class _ContractOptionAttribute
{
    
public static IObservable<System.String> get_Category(this IObservable<System.Diagnostics.Contracts.ContractOptionAttribute> ContractOptionAttributeValue)
{
    return Observable.Select(ContractOptionAttributeValue, (ContractOptionAttributeValueLambda) => ContractOptionAttributeValueLambda.Category);
}


public static IObservable<System.String> get_Setting(this IObservable<System.Diagnostics.Contracts.ContractOptionAttribute> ContractOptionAttributeValue)
{
    return Observable.Select(ContractOptionAttributeValue, (ContractOptionAttributeValueLambda) => ContractOptionAttributeValueLambda.Setting);
}


public static IObservable<System.Boolean> get_Enabled(this IObservable<System.Diagnostics.Contracts.ContractOptionAttribute> ContractOptionAttributeValue)
{
    return Observable.Select(ContractOptionAttributeValue, (ContractOptionAttributeValueLambda) => ContractOptionAttributeValueLambda.Enabled);
}


public static IObservable<System.String> get_Value(this IObservable<System.Diagnostics.Contracts.ContractOptionAttribute> ContractOptionAttributeValue)
{
    return Observable.Select(ContractOptionAttributeValue, (ContractOptionAttributeValueLambda) => ContractOptionAttributeValueLambda.Value);
}

}
}