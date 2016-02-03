using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __LazyInitializer
    {
        
        public static IObservable<Tuple<T, T>> EnsureInitialized<T>(IObservable<T> target) where  T : class
        {
            return Observable.Select(target, (targetLambda) => {
var result = System.Threading.LazyInitializer.EnsureInitialized(ref targetLambda);
return Tuple.Create(result, targetLambda);
});
        }


        public static IObservable<Tuple<T, T>> EnsureInitialized<T>(IObservable<T> target, IObservable<Func<T>> valueFactory) where T : class
        {
            return Observable.Zip(target, valueFactory, (targetLambda, valueFactoryLambda) => {
var result = System.Threading.LazyInitializer.EnsureInitialized(ref targetLambda, valueFactoryLambda);
return Tuple.Create(result, targetLambda);
});
        }


        public static IObservable<Tuple<T, T, System.Boolean, System.Object>> EnsureInitialized<T>(IObservable<T> target, IObservable<System.Boolean> initialized, IObservable<System.Object> syncLock)
        {
            return Observable.Zip(target, initialized, syncLock, (targetLambda, initializedLambda, syncLockLambda) => {
var result = System.Threading.LazyInitializer.EnsureInitialized(ref targetLambda, ref initializedLambda, ref syncLockLambda);
return Tuple.Create(result, targetLambda, initializedLambda, syncLockLambda);
});
        }


        public static IObservable<Tuple<T, T, System.Boolean, System.Object>> EnsureInitialized<T>(IObservable<T> target, IObservable<System.Boolean> initialized, IObservable<System.Object> syncLock, IObservable<Func<T>> valueFactory)
        {
            return Observable.Zip(target, initialized, syncLock, valueFactory, (targetLambda, initializedLambda, syncLockLambda, valueFactoryLambda) => {
var result = System.Threading.LazyInitializer.EnsureInitialized(ref targetLambda, ref initializedLambda, ref syncLockLambda, valueFactoryLambda);
return Tuple.Create(result, targetLambda, initializedLambda, syncLockLambda);
});
        }

    }
}