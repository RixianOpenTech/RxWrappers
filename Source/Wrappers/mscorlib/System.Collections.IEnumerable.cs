using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
public static class _IEnumerable
{
    
public static IObservable<System.Collections.IEnumerator> GetEnumerator(this IObservable<System.Collections.IEnumerable> IEnumerableValue)
{
    return Observable.Select(IEnumerableValue, (IEnumerableValueLambda) => IEnumerableValueLambda.GetEnumerator());
}

}
}