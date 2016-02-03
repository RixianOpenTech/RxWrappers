using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Concurrent
{
public static class _Partitioner
{
    
public static IObservable<OrderablePartitioner<TSource>> Create<TSource>(IObservable<IList<TSource>> list, IObservable<System.Boolean> loadBalance)
{
    return Observable.Zip(list, loadBalance, (listLambda, loadBalanceLambda) => System.Collections.Concurrent.Partitioner.Create(listLambda, loadBalanceLambda));
}


public static IObservable<OrderablePartitioner<TSource>> Create<TSource>(IObservable<TSource[]> array, IObservable<System.Boolean> loadBalance)
{
    return Observable.Zip(array, loadBalance, (arrayLambda, loadBalanceLambda) => System.Collections.Concurrent.Partitioner.Create(arrayLambda, loadBalanceLambda));
}


public static IObservable<OrderablePartitioner<TSource>> Create<TSource>(IObservable<IEnumerable<TSource>> source)
{
    return Observable.Select(source, (sourceLambda) => System.Collections.Concurrent.Partitioner.Create(sourceLambda));
}


public static IObservable<OrderablePartitioner<TSource>> Create<TSource>(IObservable<IEnumerable<TSource>> source, IObservable<System.Collections.Concurrent.EnumerablePartitionerOptions> partitionerOptions)
{
    return Observable.Zip(source, partitionerOptions, (sourceLambda, partitionerOptionsLambda) => System.Collections.Concurrent.Partitioner.Create(sourceLambda, partitionerOptionsLambda));
}


public static IObservable<System.Collections.Concurrent.OrderablePartitioner`1[[System.Tuple<System.Tuple<System.Int64, System.Int64>>> Create(IObservable<System.Int64> fromInclusive, IObservable<System.Int64> toExclusive)
{
    return Observable.Zip(fromInclusive, toExclusive, (fromInclusiveLambda, toExclusiveLambda) => System.Collections.Concurrent.Partitioner.Create(fromInclusiveLambda, toExclusiveLambda));
}


public static IObservable<System.Collections.Concurrent.OrderablePartitioner`1[[System.Tuple<System.Tuple<System.Int64, System.Int64>>> Create(IObservable<System.Int64> fromInclusive, IObservable<System.Int64> toExclusive, IObservable<System.Int64> rangeSize)
{
    return Observable.Zip(fromInclusive, toExclusive, rangeSize, (fromInclusiveLambda, toExclusiveLambda, rangeSizeLambda) => System.Collections.Concurrent.Partitioner.Create(fromInclusiveLambda, toExclusiveLambda, rangeSizeLambda));
}


public static IObservable<System.Collections.Concurrent.OrderablePartitioner`1[[System.Tuple<System.Tuple<System.Int32, System.Int32>>> Create(IObservable<System.Int32> fromInclusive, IObservable<System.Int32> toExclusive)
{
    return Observable.Zip(fromInclusive, toExclusive, (fromInclusiveLambda, toExclusiveLambda) => System.Collections.Concurrent.Partitioner.Create(fromInclusiveLambda, toExclusiveLambda));
}


public static IObservable<System.Collections.Concurrent.OrderablePartitioner`1[[System.Tuple<System.Tuple<System.Int32, System.Int32>>> Create(IObservable<System.Int32> fromInclusive, IObservable<System.Int32> toExclusive, IObservable<System.Int32> rangeSize)
{
    return Observable.Zip(fromInclusive, toExclusive, rangeSize, (fromInclusiveLambda, toExclusiveLambda, rangeSizeLambda) => System.Collections.Concurrent.Partitioner.Create(fromInclusiveLambda, toExclusiveLambda, rangeSizeLambda));
}

}
}