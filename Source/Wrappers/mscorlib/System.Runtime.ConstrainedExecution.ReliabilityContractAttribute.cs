using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.ConstrainedExecution
{
    public static class __ReliabilityContractAttribute
    {
        public static IObservable<System.Runtime.ConstrainedExecution.Consistency> get_ConsistencyGuarantee(
            this IObservable<System.Runtime.ConstrainedExecution.ReliabilityContractAttribute>
                ReliabilityContractAttributeValue)
        {
            return Observable.Select(ReliabilityContractAttributeValue,
                (ReliabilityContractAttributeValueLambda) =>
                    ReliabilityContractAttributeValueLambda.ConsistencyGuarantee);
        }


        public static IObservable<System.Runtime.ConstrainedExecution.Cer> get_Cer(
            this IObservable<System.Runtime.ConstrainedExecution.ReliabilityContractAttribute>
                ReliabilityContractAttributeValue)
        {
            return Observable.Select(ReliabilityContractAttributeValue,
                (ReliabilityContractAttributeValueLambda) => ReliabilityContractAttributeValueLambda.Cer);
        }
    }
}