using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
public static class _StrongName
{
    
public static IObservable<System.Security.IPermission> CreateIdentityPermission(this IObservable<System.Security.Policy.StrongName> StrongNameValue, IObservable<System.Security.Policy.Evidence> evidence)
{
    return Observable.Zip(StrongNameValue, evidence, (StrongNameValueLambda, evidenceLambda) => StrongNameValueLambda.CreateIdentityPermission(evidenceLambda));
}


public static IObservable<System.Security.Policy.EvidenceBase> Clone(this IObservable<System.Security.Policy.StrongName> StrongNameValue)
{
    return Observable.Select(StrongNameValue, (StrongNameValueLambda) => StrongNameValueLambda.Clone());
}


public static IObservable<System.Object> Copy(this IObservable<System.Security.Policy.StrongName> StrongNameValue)
{
    return Observable.Select(StrongNameValue, (StrongNameValueLambda) => StrongNameValueLambda.Copy());
}


public static IObservable<System.String> ToString(this IObservable<System.Security.Policy.StrongName> StrongNameValue)
{
    return Observable.Select(StrongNameValue, (StrongNameValueLambda) => StrongNameValueLambda.ToString());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Policy.StrongName> StrongNameValue, IObservable<System.Object> o)
{
    return Observable.Zip(StrongNameValue, o, (StrongNameValueLambda, oLambda) => StrongNameValueLambda.Equals(oLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Policy.StrongName> StrongNameValue)
{
    return Observable.Select(StrongNameValue, (StrongNameValueLambda) => StrongNameValueLambda.GetHashCode());
}


public static IObservable<System.Security.Permissions.StrongNamePublicKeyBlob> get_PublicKey(this IObservable<System.Security.Policy.StrongName> StrongNameValue)
{
    return Observable.Select(StrongNameValue, (StrongNameValueLambda) => StrongNameValueLambda.PublicKey);
}


public static IObservable<System.String> get_Name(this IObservable<System.Security.Policy.StrongName> StrongNameValue)
{
    return Observable.Select(StrongNameValue, (StrongNameValueLambda) => StrongNameValueLambda.Name);
}


public static IObservable<System.Version> get_Version(this IObservable<System.Security.Policy.StrongName> StrongNameValue)
{
    return Observable.Select(StrongNameValue, (StrongNameValueLambda) => StrongNameValueLambda.Version);
}

}
}