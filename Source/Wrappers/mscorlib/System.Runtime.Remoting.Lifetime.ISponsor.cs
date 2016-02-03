using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Lifetime
{
public static class _ISponsor
{
    
public static IObservable<System.TimeSpan> Renewal(this IObservable<System.Runtime.Remoting.Lifetime.ISponsor> ISponsorValue, IObservable<System.Runtime.Remoting.Lifetime.ILease> lease)
{
    return Observable.Zip(ISponsorValue, lease, (ISponsorValueLambda, leaseLambda) => ISponsorValueLambda.Renewal(leaseLambda));
}

}
}