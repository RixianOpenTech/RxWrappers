using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _IComparable1
{
    
public static IObservable<System.Int32> CompareTo<T>(this IObservable<System.IComparable<T>> IComparableValue, IObservable<T> other)
{
    return Observable.Zip(IComparableValue, other, (IComparableValueLambda, otherLambda) => IComparableValueLambda.CompareTo(otherLambda));
}

}
}