using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _ApplicationId
{
    
public static IObservable<System.ApplicationId> Copy(this IObservable<System.ApplicationId> ApplicationIdValue)
{
    return Observable.Select(ApplicationIdValue, (ApplicationIdValueLambda) => ApplicationIdValueLambda.Copy());
}


public static IObservable<System.String> ToString(this IObservable<System.ApplicationId> ApplicationIdValue)
{
    return Observable.Select(ApplicationIdValue, (ApplicationIdValueLambda) => ApplicationIdValueLambda.ToString());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.ApplicationId> ApplicationIdValue, IObservable<System.Object> o)
{
    return Observable.Zip(ApplicationIdValue, o, (ApplicationIdValueLambda, oLambda) => ApplicationIdValueLambda.Equals(oLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.ApplicationId> ApplicationIdValue)
{
    return Observable.Select(ApplicationIdValue, (ApplicationIdValueLambda) => ApplicationIdValueLambda.GetHashCode());
}


public static IObservable<System.Byte[]> get_PublicKeyToken(this IObservable<System.ApplicationId> ApplicationIdValue)
{
    return Observable.Select(ApplicationIdValue, (ApplicationIdValueLambda) => ApplicationIdValueLambda.PublicKeyToken);
}


public static IObservable<System.String> get_Name(this IObservable<System.ApplicationId> ApplicationIdValue)
{
    return Observable.Select(ApplicationIdValue, (ApplicationIdValueLambda) => ApplicationIdValueLambda.Name);
}


public static IObservable<System.Version> get_Version(this IObservable<System.ApplicationId> ApplicationIdValue)
{
    return Observable.Select(ApplicationIdValue, (ApplicationIdValueLambda) => ApplicationIdValueLambda.Version);
}


public static IObservable<System.String> get_ProcessorArchitecture(this IObservable<System.ApplicationId> ApplicationIdValue)
{
    return Observable.Select(ApplicationIdValue, (ApplicationIdValueLambda) => ApplicationIdValueLambda.ProcessorArchitecture);
}


public static IObservable<System.String> get_Culture(this IObservable<System.ApplicationId> ApplicationIdValue)
{
    return Observable.Select(ApplicationIdValue, (ApplicationIdValueLambda) => ApplicationIdValueLambda.Culture);
}

}
}