using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
public static class _PropertyToken
{
    
public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.Emit.PropertyToken> PropertyTokenValue)
{
    return Observable.Select(PropertyTokenValue, (PropertyTokenValueLambda) => PropertyTokenValueLambda.GetHashCode());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Emit.PropertyToken> PropertyTokenValue, IObservable<System.Object> obj)
{
    return Observable.Zip(PropertyTokenValue, obj, (PropertyTokenValueLambda, objLambda) => PropertyTokenValueLambda.Equals(objLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Emit.PropertyToken> PropertyTokenValue, IObservable<System.Reflection.Emit.PropertyToken> obj)
{
    return Observable.Zip(PropertyTokenValue, obj, (PropertyTokenValueLambda, objLambda) => PropertyTokenValueLambda.Equals(objLambda));
}


public static IObservable<System.Int32> get_Token(this IObservable<System.Reflection.Emit.PropertyToken> PropertyTokenValue)
{
    return Observable.Select(PropertyTokenValue, (PropertyTokenValueLambda) => PropertyTokenValueLambda.Token);
}

}
}