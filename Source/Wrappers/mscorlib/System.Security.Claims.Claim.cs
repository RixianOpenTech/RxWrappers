using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Claims
{
public static class _Claim
{
    
public static IObservable<System.Security.Claims.Claim> Clone(this IObservable<System.Security.Claims.Claim> ClaimValue)
{
    return Observable.Select(ClaimValue, (ClaimValueLambda) => ClaimValueLambda.Clone());
}


public static IObservable<System.Security.Claims.Claim> Clone(this IObservable<System.Security.Claims.Claim> ClaimValue, IObservable<System.Security.Claims.ClaimsIdentity> identity)
{
    return Observable.Zip(ClaimValue, identity, (ClaimValueLambda, identityLambda) => ClaimValueLambda.Clone(identityLambda));
}


public static IObservable<System.Reactive.Unit> WriteTo(this IObservable<System.Security.Claims.Claim> ClaimValue, IObservable<System.IO.BinaryWriter> writer)
{
    return ObservableExt.ZipExecute(ClaimValue, writer, (ClaimValueLambda, writerLambda) => ClaimValueLambda.WriteTo(writerLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.Security.Claims.Claim> ClaimValue)
{
    return Observable.Select(ClaimValue, (ClaimValueLambda) => ClaimValueLambda.ToString());
}


public static IObservable<System.String> get_Issuer(this IObservable<System.Security.Claims.Claim> ClaimValue)
{
    return Observable.Select(ClaimValue, (ClaimValueLambda) => ClaimValueLambda.Issuer);
}


public static IObservable<System.String> get_OriginalIssuer(this IObservable<System.Security.Claims.Claim> ClaimValue)
{
    return Observable.Select(ClaimValue, (ClaimValueLambda) => ClaimValueLambda.OriginalIssuer);
}


public static IObservable<System.Collections.Generic.IDictionary<System.String, System.String>> get_Properties(this IObservable<System.Security.Claims.Claim> ClaimValue)
{
    return Observable.Select(ClaimValue, (ClaimValueLambda) => ClaimValueLambda.Properties);
}


public static IObservable<System.Security.Claims.ClaimsIdentity> get_Subject(this IObservable<System.Security.Claims.Claim> ClaimValue)
{
    return Observable.Select(ClaimValue, (ClaimValueLambda) => ClaimValueLambda.Subject);
}


public static IObservable<System.String> get_Type(this IObservable<System.Security.Claims.Claim> ClaimValue)
{
    return Observable.Select(ClaimValue, (ClaimValueLambda) => ClaimValueLambda.Type);
}


public static IObservable<System.String> get_Value(this IObservable<System.Security.Claims.Claim> ClaimValue)
{
    return Observable.Select(ClaimValue, (ClaimValueLambda) => ClaimValueLambda.Value);
}


public static IObservable<System.String> get_ValueType(this IObservable<System.Security.Claims.Claim> ClaimValue)
{
    return Observable.Select(ClaimValue, (ClaimValueLambda) => ClaimValueLambda.ValueType);
}

}
}