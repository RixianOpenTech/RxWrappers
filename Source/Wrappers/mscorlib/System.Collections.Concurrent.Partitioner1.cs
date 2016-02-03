using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Concurrent
{
    public static class __Partitioner1
    {
        public static IObservable<IList<IEnumerator<TSource>>> GetPartitions<TSource>(
            this IObservable<System.Collections.Concurrent.Partitioner<TSource>> PartitionerValue,
            IObservable<System.Int32> partitionCount)
        {
            return Observable.Zip(PartitionerValue, partitionCount,
                (PartitionerValueLambda, partitionCountLambda) =>
                    PartitionerValueLambda.GetPartitions(partitionCountLambda));
        }


        public static IObservable<IEnumerable<TSource>> GetDynamicPartitions<TSource>(
            this IObservable<System.Collections.Concurrent.Partitioner<TSource>> PartitionerValue)
        {
            return Observable.Select(PartitionerValue,
                (PartitionerValueLambda) => PartitionerValueLambda.GetDynamicPartitions());
        }


        public static IObservable<System.Boolean> get_SupportsDynamicPartitions<TSource>(
            this IObservable<System.Collections.Concurrent.Partitioner<TSource>> PartitionerValue)
        {
            return Observable.Select(PartitionerValue,
                (PartitionerValueLambda) => PartitionerValueLambda.SupportsDynamicPartitions);
        }
    }
}