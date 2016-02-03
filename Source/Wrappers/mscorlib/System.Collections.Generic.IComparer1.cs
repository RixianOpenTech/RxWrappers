using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Generic
{
public static class _IComparer1
{
    
public static IObservable<System.Int32> Compare<T>(this IObservable<System.Collections.Generic.IComparer<T>> IComparerValue, IObservable<T> x, IObservable<T> y)
{
    return Observable.Zip(IComparerValue, x, y, (IComparerValueLambda, xLambda, yLambda) => IComparerValueLambda.Compare(xLambda, yLambda));
}

}
}