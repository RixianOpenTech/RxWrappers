using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __Stack
    {
        
        public static IObservable<System.Reactive.Unit> Clear(this IObservable<System.Collections.Stack> StackValue)
        {
            return Observable.Do(StackValue, (StackValueLambda) => StackValueLambda.Clear()).ToUnit();
        }


        public static IObservable<System.Object> Clone(this IObservable<System.Collections.Stack> StackValue)
        {
            return Observable.Select(StackValue, (StackValueLambda) => StackValueLambda.Clone());
        }


        public static IObservable<System.Boolean> Contains(this IObservable<System.Collections.Stack> StackValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(StackValue, obj, (StackValueLambda, objLambda) => StackValueLambda.Contains(objLambda));
        }


        public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Collections.Stack> StackValue, IObservable<System.Array> array, IObservable<System.Int32> index)
        {
            return ObservableExt.ZipExecute(StackValue, array, index, (StackValueLambda, arrayLambda, indexLambda) => StackValueLambda.CopyTo(arrayLambda, indexLambda));
        }


        public static IObservable<System.Collections.IEnumerator> GetEnumerator(this IObservable<System.Collections.Stack> StackValue)
        {
            return Observable.Select(StackValue, (StackValueLambda) => StackValueLambda.GetEnumerator());
        }


        public static IObservable<System.Object> Peek(this IObservable<System.Collections.Stack> StackValue)
        {
            return Observable.Select(StackValue, (StackValueLambda) => StackValueLambda.Peek());
        }


        public static IObservable<System.Object> Pop(this IObservable<System.Collections.Stack> StackValue)
        {
            return Observable.Select(StackValue, (StackValueLambda) => StackValueLambda.Pop());
        }


        public static IObservable<System.Reactive.Unit> Push(this IObservable<System.Collections.Stack> StackValue, IObservable<System.Object> obj)
        {
            return ObservableExt.ZipExecute(StackValue, obj, (StackValueLambda, objLambda) => StackValueLambda.Push(objLambda));
        }


        public static IObservable<System.Collections.Stack> Synchronized(IObservable<System.Collections.Stack> stack)
        {
            return Observable.Select(stack, (stackLambda) => System.Collections.Stack.Synchronized(stackLambda));
        }


        public static IObservable<System.Object[]> ToArray(this IObservable<System.Collections.Stack> StackValue)
        {
            return Observable.Select(StackValue, (StackValueLambda) => StackValueLambda.ToArray());
        }


        public static IObservable<System.Int32> get_Count(this IObservable<System.Collections.Stack> StackValue)
        {
            return Observable.Select(StackValue, (StackValueLambda) => StackValueLambda.Count);
        }


        public static IObservable<System.Boolean> get_IsSynchronized(this IObservable<System.Collections.Stack> StackValue)
        {
            return Observable.Select(StackValue, (StackValueLambda) => StackValueLambda.IsSynchronized);
        }


        public static IObservable<System.Object> get_SyncRoot(this IObservable<System.Collections.Stack> StackValue)
        {
            return Observable.Select(StackValue, (StackValueLambda) => StackValueLambda.SyncRoot);
        }

    }
}