using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
public static class _ParameterToken
{
    
public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.Emit.ParameterToken> ParameterTokenValue)
{
    return Observable.Select(ParameterTokenValue, (ParameterTokenValueLambda) => ParameterTokenValueLambda.GetHashCode());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Emit.ParameterToken> ParameterTokenValue, IObservable<System.Object> obj)
{
    return Observable.Zip(ParameterTokenValue, obj, (ParameterTokenValueLambda, objLambda) => ParameterTokenValueLambda.Equals(objLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Emit.ParameterToken> ParameterTokenValue, IObservable<System.Reflection.Emit.ParameterToken> obj)
{
    return Observable.Zip(ParameterTokenValue, obj, (ParameterTokenValueLambda, objLambda) => ParameterTokenValueLambda.Equals(objLambda));
}


public static IObservable<System.Int32> get_Token(this IObservable<System.Reflection.Emit.ParameterToken> ParameterTokenValue)
{
    return Observable.Select(ParameterTokenValue, (ParameterTokenValueLambda) => ParameterTokenValueLambda.Token);
}

}
}