using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
public static class _GacInstalled
{
    
public static IObservable<System.Security.IPermission> CreateIdentityPermission(this IObservable<System.Security.Policy.GacInstalled> GacInstalledValue, IObservable<System.Security.Policy.Evidence> evidence)
{
    return Observable.Zip(GacInstalledValue, evidence, (GacInstalledValueLambda, evidenceLambda) => GacInstalledValueLambda.CreateIdentityPermission(evidenceLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Policy.GacInstalled> GacInstalledValue, IObservable<System.Object> o)
{
    return Observable.Zip(GacInstalledValue, o, (GacInstalledValueLambda, oLambda) => GacInstalledValueLambda.Equals(oLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Policy.GacInstalled> GacInstalledValue)
{
    return Observable.Select(GacInstalledValue, (GacInstalledValueLambda) => GacInstalledValueLambda.GetHashCode());
}


public static IObservable<System.Security.Policy.EvidenceBase> Clone(this IObservable<System.Security.Policy.GacInstalled> GacInstalledValue)
{
    return Observable.Select(GacInstalledValue, (GacInstalledValueLambda) => GacInstalledValueLambda.Clone());
}


public static IObservable<System.Object> Copy(this IObservable<System.Security.Policy.GacInstalled> GacInstalledValue)
{
    return Observable.Select(GacInstalledValue, (GacInstalledValueLambda) => GacInstalledValueLambda.Copy());
}


public static IObservable<System.String> ToString(this IObservable<System.Security.Policy.GacInstalled> GacInstalledValue)
{
    return Observable.Select(GacInstalledValue, (GacInstalledValueLambda) => GacInstalledValueLambda.ToString());
}

}
}