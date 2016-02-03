using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Concurrent
{
public static class _OrderablePartitioner1
{
    
public static IObservable<IList<IEnumerator<KeyValuePair<System.Int64, TSource>>>> GetOrderablePartitions<TSource>(this IObservable<System.Collections.Concurrent.OrderablePartitioner<TSource>> OrderablePartitionerValue, IObservable<System.Int32> partitionCount)
{
    return Observable.Zip(OrderablePartitionerValue, partitionCount, (OrderablePartitionerValueLambda, partitionCountLambda) => OrderablePartitionerValueLambda.GetOrderablePartitions(partitionCountLambda));
}


public static IObservable<IEnumerable<KeyValuePair<System.Int64, TSource>>> GetOrderableDynamicPartitions<TSource>(this IObservable<System.Collections.Concurrent.OrderablePartitioner<TSource>> OrderablePartitionerValue)
{
    return Observable.Select(OrderablePartitionerValue, (OrderablePartitionerValueLambda) => OrderablePartitionerValueLambda.GetOrderableDynamicPartitions());
}


public static IObservable<IList<IEnumerator<TSource>>> GetPartitions<TSource>(this IObservable<System.Collections.Concurrent.OrderablePartitioner<TSource>> OrderablePartitionerValue, IObservable<System.Int32> partitionCount)
{
    return Observable.Zip(OrderablePartitionerValue, partitionCount, (OrderablePartitionerValueLambda, partitionCountLambda) => OrderablePartitionerValueLambda.GetPartitions(partitionCountLambda));
}


public static IObservable<IEnumerable<TSource>> GetDynamicPartitions<TSource>(this IObservable<System.Collections.Concurrent.OrderablePartitioner<TSource>> OrderablePartitionerValue)
{
    return Observable.Select(OrderablePartitionerValue, (OrderablePartitionerValueLambda) => OrderablePartitionerValueLambda.GetDynamicPartitions());
}


public static IObservable<System.Boolean> get_KeysOrderedInEachPartition<TSource>(this IObservable<System.Collections.Concurrent.OrderablePartitioner<TSource>> OrderablePartitionerValue)
{
    return Observable.Select(OrderablePartitionerValue, (OrderablePartitionerValueLambda) => OrderablePartitionerValueLambda.KeysOrderedInEachPartition);
}


public static IObservable<System.Boolean> get_KeysOrderedAcrossPartitions<TSource>(this IObservable<System.Collections.Concurrent.OrderablePartitioner<TSource>> OrderablePartitionerValue)
{
    return Observable.Select(OrderablePartitionerValue, (OrderablePartitionerValueLambda) => OrderablePartitionerValueLambda.KeysOrderedAcrossPartitions);
}


public static IObservable<System.Boolean> get_KeysNormalized<TSource>(this IObservable<System.Collections.Concurrent.OrderablePartitioner<TSource>> OrderablePartitionerValue)
{
    return Observable.Select(OrderablePartitionerValue, (OrderablePartitionerValueLambda) => OrderablePartitionerValueLambda.KeysNormalized);
}

}
}