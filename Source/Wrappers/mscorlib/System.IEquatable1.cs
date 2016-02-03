using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __IEquatable1
    {
        
        public static IObservable<System.Boolean> Equals<T>(this IObservable<System.IEquatable<T>> IEquatableValue, IObservable<T> other)
        {
            return Observable.Zip(IEquatableValue, other, (IEquatableValueLambda, otherLambda) => IEquatableValueLambda.Equals(otherLambda));
        }

    }
}