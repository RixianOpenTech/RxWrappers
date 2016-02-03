using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Concurrent
{
    public static class __ConcurrentQueue1
    {
        
        public static IObservable<System.Reactive.Unit> Enqueue<T>(this IObservable<System.Collections.Concurrent.ConcurrentQueue<T>> ConcurrentQueueValue, IObservable<T> item)
        {
            return ObservableExt.ZipExecute(ConcurrentQueueValue, item, (ConcurrentQueueValueLambda, itemLambda) => ConcurrentQueueValueLambda.Enqueue(itemLambda));
        }


        public static IObservable<Tuple<System.Boolean, T>> TryDequeue<T>(this IObservable<System.Collections.Concurrent.ConcurrentQueue<T>> ConcurrentQueueValue)
        {
            return Observable.Select(ConcurrentQueueValue, (ConcurrentQueueValueLambda) => {
T resultOutput = default(T);
var result = ConcurrentQueueValueLambda.TryDequeue(out resultOutput);
return Tuple.Create(result, resultOutput);
});
        }


        public static IObservable<T[]> ToArray<T>(this IObservable<System.Collections.Concurrent.ConcurrentQueue<T>> ConcurrentQueueValue)
        {
            return Observable.Select(ConcurrentQueueValue, (ConcurrentQueueValueLambda) => ConcurrentQueueValueLambda.ToArray());
        }


        public static IObservable<System.Reactive.Unit> CopyTo<T>(this IObservable<System.Collections.Concurrent.ConcurrentQueue<T>> ConcurrentQueueValue, IObservable<T[]> array, IObservable<System.Int32> index)
        {
            return ObservableExt.ZipExecute(ConcurrentQueueValue, array, index, (ConcurrentQueueValueLambda, arrayLambda, indexLambda) => ConcurrentQueueValueLambda.CopyTo(arrayLambda, indexLambda));
        }


        public static IObservable<IEnumerator<T>> GetEnumerator<T>(this IObservable<System.Collections.Concurrent.ConcurrentQueue<T>> ConcurrentQueueValue)
        {
            return Observable.Select(ConcurrentQueueValue, (ConcurrentQueueValueLambda) => ConcurrentQueueValueLambda.GetEnumerator());
        }


        public static IObservable<Tuple<System.Boolean, T>> TryPeek<T>(this IObservable<System.Collections.Concurrent.ConcurrentQueue<T>> ConcurrentQueueValue)
        {
            return Observable.Select(ConcurrentQueueValue, (ConcurrentQueueValueLambda) => {
T resultOutput = default(T);
var result = ConcurrentQueueValueLambda.TryPeek(out resultOutput);
return Tuple.Create(result, resultOutput);
});
        }


        public static IObservable<System.Boolean> get_IsEmpty<T>(this IObservable<System.Collections.Concurrent.ConcurrentQueue<T>> ConcurrentQueueValue)
        {
            return Observable.Select(ConcurrentQueueValue, (ConcurrentQueueValueLambda) => ConcurrentQueueValueLambda.IsEmpty);
        }


        public static IObservable<System.Int32> get_Count<T>(this IObservable<System.Collections.Concurrent.ConcurrentQueue<T>> ConcurrentQueueValue)
        {
            return Observable.Select(ConcurrentQueueValue, (ConcurrentQueueValueLambda) => ConcurrentQueueValueLambda.Count);
        }

    }
}