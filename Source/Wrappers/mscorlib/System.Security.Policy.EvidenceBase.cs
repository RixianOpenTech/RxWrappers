using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __EvidenceBase
    {
        public static IObservable<System.Security.Policy.EvidenceBase> Clone(
            this IObservable<System.Security.Policy.EvidenceBase> EvidenceBaseValue)
        {
            return Observable.Select(EvidenceBaseValue, (EvidenceBaseValueLambda) => EvidenceBaseValueLambda.Clone());
        }
    }
}