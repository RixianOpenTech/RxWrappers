using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Generic
{
    public static class __IEnumerable1
    {
        
        public static IObservable<IEnumerator<T>> GetEnumerator<T>(this IObservable<System.Collections.Generic.IEnumerable<T>> IEnumerableValue)
        {
            return Observable.Select(IEnumerableValue, (IEnumerableValueLambda) => IEnumerableValueLambda.GetEnumerator());
        }

    }
}