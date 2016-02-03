using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Generic
{
    public static class __IReadOnlyCollection1
    {
        
        public static IObservable<System.Int32> get_Count<T>(this IObservable<System.Collections.Generic.IReadOnlyCollection<T>> IReadOnlyCollectionValue)
        {
            return Observable.Select(IReadOnlyCollectionValue, (IReadOnlyCollectionValueLambda) => IReadOnlyCollectionValueLambda.Count);
        }

    }
}