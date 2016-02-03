using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.Contracts
{
    public static class __ContractVerificationAttribute
    {
        public static IObservable<System.Boolean> get_Value(
            this IObservable<System.Diagnostics.Contracts.ContractVerificationAttribute>
                ContractVerificationAttributeValue)
        {
            return Observable.Select(ContractVerificationAttributeValue,
                (ContractVerificationAttributeValueLambda) => ContractVerificationAttributeValueLambda.Value);
        }
    }
}