using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __IComparable
    {
        public static IObservable<System.Int32> CompareTo(this IObservable<System.IComparable> IComparableValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(IComparableValue, obj,
                (IComparableValueLambda, objLambda) => IComparableValueLambda.CompareTo(objLambda));
        }
    }
}