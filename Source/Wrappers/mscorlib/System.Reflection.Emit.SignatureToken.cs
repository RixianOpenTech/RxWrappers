using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
public static class _SignatureToken
{
    
public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.Emit.SignatureToken> SignatureTokenValue)
{
    return Observable.Select(SignatureTokenValue, (SignatureTokenValueLambda) => SignatureTokenValueLambda.GetHashCode());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Emit.SignatureToken> SignatureTokenValue, IObservable<System.Object> obj)
{
    return Observable.Zip(SignatureTokenValue, obj, (SignatureTokenValueLambda, objLambda) => SignatureTokenValueLambda.Equals(objLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Emit.SignatureToken> SignatureTokenValue, IObservable<System.Reflection.Emit.SignatureToken> obj)
{
    return Observable.Zip(SignatureTokenValue, obj, (SignatureTokenValueLambda, objLambda) => SignatureTokenValueLambda.Equals(objLambda));
}


public static IObservable<System.Int32> get_Token(this IObservable<System.Reflection.Emit.SignatureToken> SignatureTokenValue)
{
    return Observable.Select(SignatureTokenValue, (SignatureTokenValueLambda) => SignatureTokenValueLambda.Token);
}

}
}