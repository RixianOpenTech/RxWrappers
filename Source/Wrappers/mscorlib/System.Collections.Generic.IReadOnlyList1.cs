using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Generic
{
    public static class __IReadOnlyList1
    {
        public static IObservable<T> get_Item<T>(
            this IObservable<System.Collections.Generic.IReadOnlyList<T>> IReadOnlyListValue,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(IReadOnlyListValue, index,
                (IReadOnlyListValueLambda, indexLambda) => IReadOnlyListValueLambda[indexLambda]);
        }
    }
}