using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __IStructuralEquatable
    {
        
        public static IObservable<System.Boolean> Equals(this IObservable<System.Collections.IStructuralEquatable> IStructuralEquatableValue, IObservable<System.Object> other, IObservable<System.Collections.IEqualityComparer> comparer)
        {
            return Observable.Zip(IStructuralEquatableValue, other, comparer, (IStructuralEquatableValueLambda, otherLambda, comparerLambda) => IStructuralEquatableValueLambda.Equals(otherLambda, comparerLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Collections.IStructuralEquatable> IStructuralEquatableValue, IObservable<System.Collections.IEqualityComparer> comparer)
        {
            return Observable.Zip(IStructuralEquatableValue, comparer, (IStructuralEquatableValueLambda, comparerLambda) => IStructuralEquatableValueLambda.GetHashCode(comparerLambda));
        }

    }
}