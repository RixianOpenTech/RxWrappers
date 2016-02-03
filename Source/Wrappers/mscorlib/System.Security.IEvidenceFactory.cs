using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
    public static class __IEvidenceFactory
    {
        public static IObservable<System.Security.Policy.Evidence> get_Evidence(
            this IObservable<System.Security.IEvidenceFactory> IEvidenceFactoryValue)
        {
            return Observable.Select(IEvidenceFactoryValue,
                (IEvidenceFactoryValueLambda) => IEvidenceFactoryValueLambda.Evidence);
        }
    }
}