using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
public static class _Zone
{
    
public static IObservable<System.Security.Policy.Zone> CreateFromUrl(IObservable<System.String> url)
{
    return Observable.Select(url, (urlLambda) => System.Security.Policy.Zone.CreateFromUrl(urlLambda));
}


public static IObservable<System.Security.IPermission> CreateIdentityPermission(this IObservable<System.Security.Policy.Zone> ZoneValue, IObservable<System.Security.Policy.Evidence> evidence)
{
    return Observable.Zip(ZoneValue, evidence, (ZoneValueLambda, evidenceLambda) => ZoneValueLambda.CreateIdentityPermission(evidenceLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Policy.Zone> ZoneValue, IObservable<System.Object> o)
{
    return Observable.Zip(ZoneValue, o, (ZoneValueLambda, oLambda) => ZoneValueLambda.Equals(oLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Policy.Zone> ZoneValue)
{
    return Observable.Select(ZoneValue, (ZoneValueLambda) => ZoneValueLambda.GetHashCode());
}


public static IObservable<System.Security.Policy.EvidenceBase> Clone(this IObservable<System.Security.Policy.Zone> ZoneValue)
{
    return Observable.Select(ZoneValue, (ZoneValueLambda) => ZoneValueLambda.Clone());
}


public static IObservable<System.Object> Copy(this IObservable<System.Security.Policy.Zone> ZoneValue)
{
    return Observable.Select(ZoneValue, (ZoneValueLambda) => ZoneValueLambda.Copy());
}


public static IObservable<System.String> ToString(this IObservable<System.Security.Policy.Zone> ZoneValue)
{
    return Observable.Select(ZoneValue, (ZoneValueLambda) => ZoneValueLambda.ToString());
}


public static IObservable<System.Security.SecurityZone> get_SecurityZone(this IObservable<System.Security.Policy.Zone> ZoneValue)
{
    return Observable.Select(ZoneValue, (ZoneValueLambda) => ZoneValueLambda.SecurityZone);
}

}
}