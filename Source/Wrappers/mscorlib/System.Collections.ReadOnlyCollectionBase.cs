using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
public static class _ReadOnlyCollectionBase
{
    
public static IObservable<System.Collections.IEnumerator> GetEnumerator(this IObservable<System.Collections.ReadOnlyCollectionBase> ReadOnlyCollectionBaseValue)
{
    return Observable.Select(ReadOnlyCollectionBaseValue, (ReadOnlyCollectionBaseValueLambda) => ReadOnlyCollectionBaseValueLambda.GetEnumerator());
}


public static IObservable<System.Int32> get_Count(this IObservable<System.Collections.ReadOnlyCollectionBase> ReadOnlyCollectionBaseValue)
{
    return Observable.Select(ReadOnlyCollectionBaseValue, (ReadOnlyCollectionBaseValueLambda) => ReadOnlyCollectionBaseValueLambda.Count);
}

}
}