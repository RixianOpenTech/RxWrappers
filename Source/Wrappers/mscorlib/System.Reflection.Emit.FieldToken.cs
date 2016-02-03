using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
public static class _FieldToken
{
    
public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.Emit.FieldToken> FieldTokenValue)
{
    return Observable.Select(FieldTokenValue, (FieldTokenValueLambda) => FieldTokenValueLambda.GetHashCode());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Emit.FieldToken> FieldTokenValue, IObservable<System.Object> obj)
{
    return Observable.Zip(FieldTokenValue, obj, (FieldTokenValueLambda, objLambda) => FieldTokenValueLambda.Equals(objLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Emit.FieldToken> FieldTokenValue, IObservable<System.Reflection.Emit.FieldToken> obj)
{
    return Observable.Zip(FieldTokenValue, obj, (FieldTokenValueLambda, objLambda) => FieldTokenValueLambda.Equals(objLambda));
}


public static IObservable<System.Int32> get_Token(this IObservable<System.Reflection.Emit.FieldToken> FieldTokenValue)
{
    return Observable.Select(FieldTokenValue, (FieldTokenValueLambda) => FieldTokenValueLambda.Token);
}

}
}