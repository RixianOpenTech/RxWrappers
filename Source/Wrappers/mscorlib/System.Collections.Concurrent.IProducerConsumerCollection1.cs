using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Concurrent
{
    public static class __IProducerConsumerCollection1
    {
        
        public static IObservable<System.Reactive.Unit> CopyTo<T>(this IObservable<System.Collections.Concurrent.IProducerConsumerCollection<T>> IProducerConsumerCollectionValue, IObservable<T[]> array, IObservable<System.Int32> index)
        {
            return ObservableExt.ZipExecute(IProducerConsumerCollectionValue, array, index, (IProducerConsumerCollectionValueLambda, arrayLambda, indexLambda) => IProducerConsumerCollectionValueLambda.CopyTo(arrayLambda, indexLambda));
        }


        public static IObservable<System.Boolean> TryAdd<T>(this IObservable<System.Collections.Concurrent.IProducerConsumerCollection<T>> IProducerConsumerCollectionValue, IObservable<T> item)
        {
            return Observable.Zip(IProducerConsumerCollectionValue, item, (IProducerConsumerCollectionValueLambda, itemLambda) => IProducerConsumerCollectionValueLambda.TryAdd(itemLambda));
        }


        public static IObservable<Tuple<System.Boolean, T>> TryTake<T>(this IObservable<System.Collections.Concurrent.IProducerConsumerCollection<T>> IProducerConsumerCollectionValue)
        {
            return Observable.Select(IProducerConsumerCollectionValue, (IProducerConsumerCollectionValueLambda) => {
T itemOutput = default(T);
var result = IProducerConsumerCollectionValueLambda.TryTake(out itemOutput);
return Tuple.Create(result, itemOutput);
});
        }


        public static IObservable<T[]> ToArray<T>(this IObservable<System.Collections.Concurrent.IProducerConsumerCollection<T>> IProducerConsumerCollectionValue)
        {
            return Observable.Select(IProducerConsumerCollectionValue, (IProducerConsumerCollectionValueLambda) => IProducerConsumerCollectionValueLambda.ToArray());
        }

    }
}