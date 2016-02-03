using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
public static class _ApplicationDirectory
{
    
public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Policy.ApplicationDirectory> ApplicationDirectoryValue, IObservable<System.Object> o)
{
    return Observable.Zip(ApplicationDirectoryValue, o, (ApplicationDirectoryValueLambda, oLambda) => ApplicationDirectoryValueLambda.Equals(oLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Policy.ApplicationDirectory> ApplicationDirectoryValue)
{
    return Observable.Select(ApplicationDirectoryValue, (ApplicationDirectoryValueLambda) => ApplicationDirectoryValueLambda.GetHashCode());
}


public static IObservable<System.Security.Policy.EvidenceBase> Clone(this IObservable<System.Security.Policy.ApplicationDirectory> ApplicationDirectoryValue)
{
    return Observable.Select(ApplicationDirectoryValue, (ApplicationDirectoryValueLambda) => ApplicationDirectoryValueLambda.Clone());
}


public static IObservable<System.Object> Copy(this IObservable<System.Security.Policy.ApplicationDirectory> ApplicationDirectoryValue)
{
    return Observable.Select(ApplicationDirectoryValue, (ApplicationDirectoryValueLambda) => ApplicationDirectoryValueLambda.Copy());
}


public static IObservable<System.String> ToString(this IObservable<System.Security.Policy.ApplicationDirectory> ApplicationDirectoryValue)
{
    return Observable.Select(ApplicationDirectoryValue, (ApplicationDirectoryValueLambda) => ApplicationDirectoryValueLambda.ToString());
}


public static IObservable<System.String> get_Directory(this IObservable<System.Security.Policy.ApplicationDirectory> ApplicationDirectoryValue)
{
    return Observable.Select(ApplicationDirectoryValue, (ApplicationDirectoryValueLambda) => ApplicationDirectoryValueLambda.Directory);
}

}
}