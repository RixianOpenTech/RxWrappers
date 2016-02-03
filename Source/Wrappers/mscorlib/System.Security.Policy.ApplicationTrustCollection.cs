using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
public static class _ApplicationTrustCollection
{
    
public static IObservable<System.Int32> Add(this IObservable<System.Security.Policy.ApplicationTrustCollection> ApplicationTrustCollectionValue, IObservable<System.Security.Policy.ApplicationTrust> trust)
{
    return Observable.Zip(ApplicationTrustCollectionValue, trust, (ApplicationTrustCollectionValueLambda, trustLambda) => ApplicationTrustCollectionValueLambda.Add(trustLambda));
}


public static IObservable<System.Reactive.Unit> AddRange(this IObservable<System.Security.Policy.ApplicationTrustCollection> ApplicationTrustCollectionValue, IObservable<System.Security.Policy.ApplicationTrust[]> trusts)
{
    return ObservableExt.ZipExecute(ApplicationTrustCollectionValue, trusts, (ApplicationTrustCollectionValueLambda, trustsLambda) => ApplicationTrustCollectionValueLambda.AddRange(trustsLambda));
}


public static IObservable<System.Reactive.Unit> AddRange(this IObservable<System.Security.Policy.ApplicationTrustCollection> ApplicationTrustCollectionValue, IObservable<System.Security.Policy.ApplicationTrustCollection> trusts)
{
    return ObservableExt.ZipExecute(ApplicationTrustCollectionValue, trusts, (ApplicationTrustCollectionValueLambda, trustsLambda) => ApplicationTrustCollectionValueLambda.AddRange(trustsLambda));
}


public static IObservable<System.Security.Policy.ApplicationTrustCollection> Find(this IObservable<System.Security.Policy.ApplicationTrustCollection> ApplicationTrustCollectionValue, IObservable<System.ApplicationIdentity> applicationIdentity, IObservable<System.Security.Policy.ApplicationVersionMatch> versionMatch)
{
    return Observable.Zip(ApplicationTrustCollectionValue, applicationIdentity, versionMatch, (ApplicationTrustCollectionValueLambda, applicationIdentityLambda, versionMatchLambda) => ApplicationTrustCollectionValueLambda.Find(applicationIdentityLambda, versionMatchLambda));
}


public static IObservable<System.Reactive.Unit> Remove(this IObservable<System.Security.Policy.ApplicationTrustCollection> ApplicationTrustCollectionValue, IObservable<System.ApplicationIdentity> applicationIdentity, IObservable<System.Security.Policy.ApplicationVersionMatch> versionMatch)
{
    return ObservableExt.ZipExecute(ApplicationTrustCollectionValue, applicationIdentity, versionMatch, (ApplicationTrustCollectionValueLambda, applicationIdentityLambda, versionMatchLambda) => ApplicationTrustCollectionValueLambda.Remove(applicationIdentityLambda, versionMatchLambda));
}


public static IObservable<System.Reactive.Unit> Remove(this IObservable<System.Security.Policy.ApplicationTrustCollection> ApplicationTrustCollectionValue, IObservable<System.Security.Policy.ApplicationTrust> trust)
{
    return ObservableExt.ZipExecute(ApplicationTrustCollectionValue, trust, (ApplicationTrustCollectionValueLambda, trustLambda) => ApplicationTrustCollectionValueLambda.Remove(trustLambda));
}


public static IObservable<System.Reactive.Unit> RemoveRange(this IObservable<System.Security.Policy.ApplicationTrustCollection> ApplicationTrustCollectionValue, IObservable<System.Security.Policy.ApplicationTrust[]> trusts)
{
    return ObservableExt.ZipExecute(ApplicationTrustCollectionValue, trusts, (ApplicationTrustCollectionValueLambda, trustsLambda) => ApplicationTrustCollectionValueLambda.RemoveRange(trustsLambda));
}


public static IObservable<System.Reactive.Unit> RemoveRange(this IObservable<System.Security.Policy.ApplicationTrustCollection> ApplicationTrustCollectionValue, IObservable<System.Security.Policy.ApplicationTrustCollection> trusts)
{
    return ObservableExt.ZipExecute(ApplicationTrustCollectionValue, trusts, (ApplicationTrustCollectionValueLambda, trustsLambda) => ApplicationTrustCollectionValueLambda.RemoveRange(trustsLambda));
}


public static IObservable<System.Reactive.Unit> Clear(this IObservable<System.Security.Policy.ApplicationTrustCollection> ApplicationTrustCollectionValue)
{
    return Observable.Do(ApplicationTrustCollectionValue, (ApplicationTrustCollectionValueLambda) => ApplicationTrustCollectionValueLambda.Clear()).ToUnit();
}


public static IObservable<System.Security.Policy.ApplicationTrustEnumerator> GetEnumerator(this IObservable<System.Security.Policy.ApplicationTrustCollection> ApplicationTrustCollectionValue)
{
    return Observable.Select(ApplicationTrustCollectionValue, (ApplicationTrustCollectionValueLambda) => ApplicationTrustCollectionValueLambda.GetEnumerator());
}


public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Security.Policy.ApplicationTrustCollection> ApplicationTrustCollectionValue, IObservable<System.Security.Policy.ApplicationTrust[]> array, IObservable<System.Int32> index)
{
    return ObservableExt.ZipExecute(ApplicationTrustCollectionValue, array, index, (ApplicationTrustCollectionValueLambda, arrayLambda, indexLambda) => ApplicationTrustCollectionValueLambda.CopyTo(arrayLambda, indexLambda));
}


public static IObservable<System.Int32> get_Count(this IObservable<System.Security.Policy.ApplicationTrustCollection> ApplicationTrustCollectionValue)
{
    return Observable.Select(ApplicationTrustCollectionValue, (ApplicationTrustCollectionValueLambda) => ApplicationTrustCollectionValueLambda.Count);
}


public static IObservable<System.Security.Policy.ApplicationTrust> get_Item(this IObservable<System.Security.Policy.ApplicationTrustCollection> ApplicationTrustCollectionValue, IObservable<System.Int32> index)
{
    return Observable.Zip(ApplicationTrustCollectionValue, index, (ApplicationTrustCollectionValueLambda, indexLambda) => ApplicationTrustCollectionValueLambda.Item);
}


public static IObservable<System.Security.Policy.ApplicationTrust> get_Item(this IObservable<System.Security.Policy.ApplicationTrustCollection> ApplicationTrustCollectionValue, IObservable<System.String> appFullName)
{
    return Observable.Zip(ApplicationTrustCollectionValue, appFullName, (ApplicationTrustCollectionValueLambda, appFullNameLambda) => ApplicationTrustCollectionValueLambda.Item);
}


public static IObservable<System.Boolean> get_IsSynchronized(this IObservable<System.Security.Policy.ApplicationTrustCollection> ApplicationTrustCollectionValue)
{
    return Observable.Select(ApplicationTrustCollectionValue, (ApplicationTrustCollectionValueLambda) => ApplicationTrustCollectionValueLambda.IsSynchronized);
}


public static IObservable<System.Object> get_SyncRoot(this IObservable<System.Security.Policy.ApplicationTrustCollection> ApplicationTrustCollectionValue)
{
    return Observable.Select(ApplicationTrustCollectionValue, (ApplicationTrustCollectionValueLambda) => ApplicationTrustCollectionValueLambda.SyncRoot);
}

}
}