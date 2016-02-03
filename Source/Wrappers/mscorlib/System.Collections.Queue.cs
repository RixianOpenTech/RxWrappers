using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __Queue
    {
        public static IObservable<System.Object> Clone(this IObservable<System.Collections.Queue> QueueValue)
        {
            return Observable.Select(QueueValue, (QueueValueLambda) => QueueValueLambda.Clone());
        }


        public static IObservable<System.Reactive.Unit> Clear(this IObservable<System.Collections.Queue> QueueValue)
        {
            return Observable.Do(QueueValue, (QueueValueLambda) => QueueValueLambda.Clear()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Collections.Queue> QueueValue,
            IObservable<System.Array> array, IObservable<System.Int32> index)
        {
            return ObservableExt.ZipExecute(QueueValue, array, index,
                (QueueValueLambda, arrayLambda, indexLambda) => QueueValueLambda.CopyTo(arrayLambda, indexLambda));
        }


        public static IObservable<System.Reactive.Unit> Enqueue(this IObservable<System.Collections.Queue> QueueValue,
            IObservable<System.Object> obj)
        {
            return ObservableExt.ZipExecute(QueueValue, obj,
                (QueueValueLambda, objLambda) => QueueValueLambda.Enqueue(objLambda));
        }


        public static IObservable<System.Collections.IEnumerator> GetEnumerator(
            this IObservable<System.Collections.Queue> QueueValue)
        {
            return Observable.Select(QueueValue, (QueueValueLambda) => QueueValueLambda.GetEnumerator());
        }


        public static IObservable<System.Object> Dequeue(this IObservable<System.Collections.Queue> QueueValue)
        {
            return Observable.Select(QueueValue, (QueueValueLambda) => QueueValueLambda.Dequeue());
        }


        public static IObservable<System.Object> Peek(this IObservable<System.Collections.Queue> QueueValue)
        {
            return Observable.Select(QueueValue, (QueueValueLambda) => QueueValueLambda.Peek());
        }


        public static IObservable<System.Collections.Queue> Synchronized(IObservable<System.Collections.Queue> queue)
        {
            return Observable.Select(queue, (queueLambda) => System.Collections.Queue.Synchronized(queueLambda));
        }


        public static IObservable<System.Boolean> Contains(this IObservable<System.Collections.Queue> QueueValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(QueueValue, obj, (QueueValueLambda, objLambda) => QueueValueLambda.Contains(objLambda));
        }


        public static IObservable<System.Object[]> ToArray(this IObservable<System.Collections.Queue> QueueValue)
        {
            return Observable.Select(QueueValue, (QueueValueLambda) => QueueValueLambda.ToArray());
        }


        public static IObservable<System.Reactive.Unit> TrimToSize(this IObservable<System.Collections.Queue> QueueValue)
        {
            return Observable.Do(QueueValue, (QueueValueLambda) => QueueValueLambda.TrimToSize()).ToUnit();
        }


        public static IObservable<System.Int32> get_Count(this IObservable<System.Collections.Queue> QueueValue)
        {
            return Observable.Select(QueueValue, (QueueValueLambda) => QueueValueLambda.Count);
        }


        public static IObservable<System.Boolean> get_IsSynchronized(
            this IObservable<System.Collections.Queue> QueueValue)
        {
            return Observable.Select(QueueValue, (QueueValueLambda) => QueueValueLambda.IsSynchronized);
        }


        public static IObservable<System.Object> get_SyncRoot(this IObservable<System.Collections.Queue> QueueValue)
        {
            return Observable.Select(QueueValue, (QueueValueLambda) => QueueValueLambda.SyncRoot);
        }
    }
}