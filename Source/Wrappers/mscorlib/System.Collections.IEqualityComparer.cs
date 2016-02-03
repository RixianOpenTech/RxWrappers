using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __IEqualityComparer
    {
        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Collections.IEqualityComparer> IEqualityComparerValue, IObservable<System.Object> x,
            IObservable<System.Object> y)
        {
            return Observable.Zip(IEqualityComparerValue, x, y,
                (IEqualityComparerValueLambda, xLambda, yLambda) =>
                    IEqualityComparerValueLambda.Equals(xLambda, yLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Collections.IEqualityComparer> IEqualityComparerValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(IEqualityComparerValue, obj,
                (IEqualityComparerValueLambda, objLambda) => IEqualityComparerValueLambda.GetHashCode(objLambda));
        }
    }
}