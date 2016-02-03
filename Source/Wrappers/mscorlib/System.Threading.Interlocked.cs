using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __Interlocked
    {
        public static IObservable<Tuple<System.Int32, System.Int32>> Increment(IObservable<System.Int32> location)
        {
            return Observable.Select(location, (locationLambda) =>
            {
                var result = System.Threading.Interlocked.Increment(ref locationLambda);
                return Tuple.Create(result, locationLambda);
            });
        }


        public static IObservable<Tuple<System.Int64, System.Int64>> Increment(IObservable<System.Int64> location)
        {
            return Observable.Select(location, (locationLambda) =>
            {
                var result = System.Threading.Interlocked.Increment(ref locationLambda);
                return Tuple.Create(result, locationLambda);
            });
        }


        public static IObservable<Tuple<System.Int32, System.Int32>> Decrement(IObservable<System.Int32> location)
        {
            return Observable.Select(location, (locationLambda) =>
            {
                var result = System.Threading.Interlocked.Decrement(ref locationLambda);
                return Tuple.Create(result, locationLambda);
            });
        }


        public static IObservable<Tuple<System.Int64, System.Int64>> Decrement(IObservable<System.Int64> location)
        {
            return Observable.Select(location, (locationLambda) =>
            {
                var result = System.Threading.Interlocked.Decrement(ref locationLambda);
                return Tuple.Create(result, locationLambda);
            });
        }


        public static IObservable<Tuple<System.Int32, System.Int32>> Exchange(IObservable<System.Int32> location1,
            IObservable<System.Int32> value)
        {
            return Observable.Zip(location1, value, (location1Lambda, valueLambda) =>
            {
                var result = System.Threading.Interlocked.Exchange(ref location1Lambda, valueLambda);
                return Tuple.Create(result, location1Lambda);
            });
        }


        public static IObservable<Tuple<System.Int64, System.Int64>> Exchange(IObservable<System.Int64> location1,
            IObservable<System.Int64> value)
        {
            return Observable.Zip(location1, value, (location1Lambda, valueLambda) =>
            {
                var result = System.Threading.Interlocked.Exchange(ref location1Lambda, valueLambda);
                return Tuple.Create(result, location1Lambda);
            });
        }


        public static IObservable<Tuple<System.Single, System.Single>> Exchange(IObservable<System.Single> location1,
            IObservable<System.Single> value)
        {
            return Observable.Zip(location1, value, (location1Lambda, valueLambda) =>
            {
                var result = System.Threading.Interlocked.Exchange(ref location1Lambda, valueLambda);
                return Tuple.Create(result, location1Lambda);
            });
        }


        public static IObservable<Tuple<System.Double, System.Double>> Exchange(IObservable<System.Double> location1,
            IObservable<System.Double> value)
        {
            return Observable.Zip(location1, value, (location1Lambda, valueLambda) =>
            {
                var result = System.Threading.Interlocked.Exchange(ref location1Lambda, valueLambda);
                return Tuple.Create(result, location1Lambda);
            });
        }


        public static IObservable<Tuple<System.Object, System.Object>> Exchange(IObservable<System.Object> location1,
            IObservable<System.Object> value)
        {
            return Observable.Zip(location1, value, (location1Lambda, valueLambda) =>
            {
                var result = System.Threading.Interlocked.Exchange(ref location1Lambda, valueLambda);
                return Tuple.Create(result, location1Lambda);
            });
        }


        public static IObservable<Tuple<System.IntPtr, System.IntPtr>> Exchange(IObservable<System.IntPtr> location1,
            IObservable<System.IntPtr> value)
        {
            return Observable.Zip(location1, value, (location1Lambda, valueLambda) =>
            {
                var result = System.Threading.Interlocked.Exchange(ref location1Lambda, valueLambda);
                return Tuple.Create(result, location1Lambda);
            });
        }


        public static IObservable<Tuple<T, T>> Exchange<T>(IObservable<T> location1, IObservable<T> value)
            where T : class
        {
            return Observable.Zip(location1, value, (location1Lambda, valueLambda) =>
            {
                var result = System.Threading.Interlocked.Exchange(ref location1Lambda, valueLambda);
                return Tuple.Create(result, location1Lambda);
            });
        }


        public static IObservable<Tuple<System.Int32, System.Int32>> CompareExchange(
            IObservable<System.Int32> location1, IObservable<System.Int32> value, IObservable<System.Int32> comparand)
        {
            return Observable.Zip(location1, value, comparand, (location1Lambda, valueLambda, comparandLambda) =>
            {
                var result = System.Threading.Interlocked.CompareExchange(ref location1Lambda, valueLambda,
                    comparandLambda);
                return Tuple.Create(result, location1Lambda);
            });
        }


        public static IObservable<Tuple<System.Int64, System.Int64>> CompareExchange(
            IObservable<System.Int64> location1, IObservable<System.Int64> value, IObservable<System.Int64> comparand)
        {
            return Observable.Zip(location1, value, comparand, (location1Lambda, valueLambda, comparandLambda) =>
            {
                var result = System.Threading.Interlocked.CompareExchange(ref location1Lambda, valueLambda,
                    comparandLambda);
                return Tuple.Create(result, location1Lambda);
            });
        }


        public static IObservable<Tuple<System.Single, System.Single>> CompareExchange(
            IObservable<System.Single> location1, IObservable<System.Single> value, IObservable<System.Single> comparand)
        {
            return Observable.Zip(location1, value, comparand, (location1Lambda, valueLambda, comparandLambda) =>
            {
                var result = System.Threading.Interlocked.CompareExchange(ref location1Lambda, valueLambda,
                    comparandLambda);
                return Tuple.Create(result, location1Lambda);
            });
        }


        public static IObservable<Tuple<System.Double, System.Double>> CompareExchange(
            IObservable<System.Double> location1, IObservable<System.Double> value, IObservable<System.Double> comparand)
        {
            return Observable.Zip(location1, value, comparand, (location1Lambda, valueLambda, comparandLambda) =>
            {
                var result = System.Threading.Interlocked.CompareExchange(ref location1Lambda, valueLambda,
                    comparandLambda);
                return Tuple.Create(result, location1Lambda);
            });
        }


        public static IObservable<Tuple<System.Object, System.Object>> CompareExchange(
            IObservable<System.Object> location1, IObservable<System.Object> value, IObservable<System.Object> comparand)
        {
            return Observable.Zip(location1, value, comparand, (location1Lambda, valueLambda, comparandLambda) =>
            {
                var result = System.Threading.Interlocked.CompareExchange(ref location1Lambda, valueLambda,
                    comparandLambda);
                return Tuple.Create(result, location1Lambda);
            });
        }


        public static IObservable<Tuple<System.IntPtr, System.IntPtr>> CompareExchange(
            IObservable<System.IntPtr> location1, IObservable<System.IntPtr> value, IObservable<System.IntPtr> comparand)
        {
            return Observable.Zip(location1, value, comparand, (location1Lambda, valueLambda, comparandLambda) =>
            {
                var result = System.Threading.Interlocked.CompareExchange(ref location1Lambda, valueLambda,
                    comparandLambda);
                return Tuple.Create(result, location1Lambda);
            });
        }


        public static IObservable<Tuple<T, T>> CompareExchange<T>(IObservable<T> location1, IObservable<T> value,
            IObservable<T> comparand) where T : class
        {
            return Observable.Zip(location1, value, comparand, (location1Lambda, valueLambda, comparandLambda) =>
            {
                var result = System.Threading.Interlocked.CompareExchange(ref location1Lambda, valueLambda,
                    comparandLambda);
                return Tuple.Create(result, location1Lambda);
            });
        }


        public static IObservable<Tuple<System.Int32, System.Int32>> Add(IObservable<System.Int32> location1,
            IObservable<System.Int32> value)
        {
            return Observable.Zip(location1, value, (location1Lambda, valueLambda) =>
            {
                var result = System.Threading.Interlocked.Add(ref location1Lambda, valueLambda);
                return Tuple.Create(result, location1Lambda);
            });
        }


        public static IObservable<Tuple<System.Int64, System.Int64>> Add(IObservable<System.Int64> location1,
            IObservable<System.Int64> value)
        {
            return Observable.Zip(location1, value, (location1Lambda, valueLambda) =>
            {
                var result = System.Threading.Interlocked.Add(ref location1Lambda, valueLambda);
                return Tuple.Create(result, location1Lambda);
            });
        }


        public static IObservable<Tuple<System.Int64, System.Int64>> Read(IObservable<System.Int64> location)
        {
            return Observable.Select(location, (locationLambda) =>
            {
                var result = System.Threading.Interlocked.Read(ref locationLambda);
                return Tuple.Create(result, locationLambda);
            });
        }


        public static IObservable<System.Reactive.Unit> MemoryBarrier()
        {
            return ObservableExt.Factory(() => System.Threading.Interlocked.MemoryBarrier());
        }
    }
}