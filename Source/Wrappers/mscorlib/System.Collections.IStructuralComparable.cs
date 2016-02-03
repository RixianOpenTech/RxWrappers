using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __IStructuralComparable
    {
        
        public static IObservable<System.Int32> CompareTo(this IObservable<System.Collections.IStructuralComparable> IStructuralComparableValue, IObservable<System.Object> other, IObservable<System.Collections.IComparer> comparer)
        {
            return Observable.Zip(IStructuralComparableValue, other, comparer, (IStructuralComparableValueLambda, otherLambda, comparerLambda) => IStructuralComparableValueLambda.CompareTo(otherLambda, comparerLambda));
        }

    }
}