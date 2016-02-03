using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
public static class _ApplicationTrustEnumerator
{
    
public static IObservable<System.Boolean> MoveNext(this IObservable<System.Security.Policy.ApplicationTrustEnumerator> ApplicationTrustEnumeratorValue)
{
    return Observable.Select(ApplicationTrustEnumeratorValue, (ApplicationTrustEnumeratorValueLambda) => ApplicationTrustEnumeratorValueLambda.MoveNext());
}


public static IObservable<System.Reactive.Unit> Reset(this IObservable<System.Security.Policy.ApplicationTrustEnumerator> ApplicationTrustEnumeratorValue)
{
    return Observable.Do(ApplicationTrustEnumeratorValue, (ApplicationTrustEnumeratorValueLambda) => ApplicationTrustEnumeratorValueLambda.Reset()).ToUnit();
}


public static IObservable<System.Security.Policy.ApplicationTrust> get_Current(this IObservable<System.Security.Policy.ApplicationTrustEnumerator> ApplicationTrustEnumeratorValue)
{
    return Observable.Select(ApplicationTrustEnumeratorValue, (ApplicationTrustEnumeratorValueLambda) => ApplicationTrustEnumeratorValueLambda.Current);
}

}
}