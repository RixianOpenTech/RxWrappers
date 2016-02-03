using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Generic
{
public static class _Comparer1
{
    
public static IObservable<System.Collections.Generic.Comparer<T>> Create<T>(IObservable<Comparison<T>> comparison)
{
    return Observable.Select(comparison, (comparisonLambda) => System.Collections.Generic.Comparer<T>.Create(comparisonLambda));
}


public static IObservable<System.Int32> Compare<T>(this IObservable<System.Collections.Generic.Comparer<T>> ComparerValue, IObservable<T> x, IObservable<T> y)
{
    return Observable.Zip(ComparerValue, x, y, (ComparerValueLambda, xLambda, yLambda) => ComparerValueLambda.Compare(xLambda, yLambda));
}


public static IObservable<System.Collections.Generic.Comparer<T>> get_Default<T>()
{
    return ObservableExt.Factory(() => System.Collections.Generic.Comparer<T>.Default);
}

}
}