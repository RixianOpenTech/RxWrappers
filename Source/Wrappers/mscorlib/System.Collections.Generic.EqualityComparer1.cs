using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Generic
{
public static class _EqualityComparer1
{
    
public static IObservable<System.Boolean> Equals<T>(this IObservable<System.Collections.Generic.EqualityComparer<T>> EqualityComparerValue, IObservable<T> x, IObservable<T> y)
{
    return Observable.Zip(EqualityComparerValue, x, y, (EqualityComparerValueLambda, xLambda, yLambda) => EqualityComparerValueLambda.Equals(xLambda, yLambda));
}


public static IObservable<System.Int32> GetHashCode<T>(this IObservable<System.Collections.Generic.EqualityComparer<T>> EqualityComparerValue, IObservable<T> obj)
{
    return Observable.Zip(EqualityComparerValue, obj, (EqualityComparerValueLambda, objLambda) => EqualityComparerValueLambda.GetHashCode(objLambda));
}


public static IObservable<System.Collections.Generic.EqualityComparer<T>> get_Default<T>()
{
    return ObservableExt.Factory(() => System.Collections.Generic.EqualityComparer<T>.Default);
}

}
}