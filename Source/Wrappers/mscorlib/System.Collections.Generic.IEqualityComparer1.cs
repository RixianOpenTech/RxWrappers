using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Generic
{
    public static class __IEqualityComparer1
    {
        public static IObservable<System.Boolean> Equals<T>(
            this IObservable<System.Collections.Generic.IEqualityComparer<T>> IEqualityComparerValue, IObservable<T> x,
            IObservable<T> y)
        {
            return Observable.Zip(IEqualityComparerValue, x, y,
                (IEqualityComparerValueLambda, xLambda, yLambda) =>
                    IEqualityComparerValueLambda.Equals(xLambda, yLambda));
        }


        public static IObservable<System.Int32> GetHashCode<T>(
            this IObservable<System.Collections.Generic.IEqualityComparer<T>> IEqualityComparerValue, IObservable<T> obj)
        {
            return Observable.Zip(IEqualityComparerValue, obj,
                (IEqualityComparerValueLambda, objLambda) => IEqualityComparerValueLambda.GetHashCode(objLambda));
        }
    }
}