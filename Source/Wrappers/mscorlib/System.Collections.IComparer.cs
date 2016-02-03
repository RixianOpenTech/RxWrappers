using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __IComparer
    {
        public static IObservable<System.Int32> Compare(this IObservable<System.Collections.IComparer> IComparerValue,
            IObservable<System.Object> x, IObservable<System.Object> y)
        {
            return Observable.Zip(IComparerValue, x, y,
                (IComparerValueLambda, xLambda, yLambda) => IComparerValueLambda.Compare(xLambda, yLambda));
        }
    }
}