using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __Volatile
    {
        public static IObservable<Tuple<System.Boolean, System.Boolean>> Read(IObservable<System.Boolean> location)
        {
            return Observable.Select(location, (locationLambda) =>
            {
                var result = System.Threading.Volatile.Read(ref locationLambda);
                return Tuple.Create(result, locationLambda);
            });
        }


        public static IObservable<Tuple<System.SByte, System.SByte>> Read(IObservable<System.SByte> location)
        {
            return Observable.Select(location, (locationLambda) =>
            {
                var result = System.Threading.Volatile.Read(ref locationLambda);
                return Tuple.Create(result, locationLambda);
            });
        }


        public static IObservable<Tuple<System.Byte, System.Byte>> Read(IObservable<System.Byte> location)
        {
            return Observable.Select(location, (locationLambda) =>
            {
                var result = System.Threading.Volatile.Read(ref locationLambda);
                return Tuple.Create(result, locationLambda);
            });
        }


        public static IObservable<Tuple<System.Int16, System.Int16>> Read(IObservable<System.Int16> location)
        {
            return Observable.Select(location, (locationLambda) =>
            {
                var result = System.Threading.Volatile.Read(ref locationLambda);
                return Tuple.Create(result, locationLambda);
            });
        }


        public static IObservable<Tuple<System.UInt16, System.UInt16>> Read(IObservable<System.UInt16> location)
        {
            return Observable.Select(location, (locationLambda) =>
            {
                var result = System.Threading.Volatile.Read(ref locationLambda);
                return Tuple.Create(result, locationLambda);
            });
        }


        public static IObservable<Tuple<System.Int32, System.Int32>> Read(IObservable<System.Int32> location)
        {
            return Observable.Select(location, (locationLambda) =>
            {
                var result = System.Threading.Volatile.Read(ref locationLambda);
                return Tuple.Create(result, locationLambda);
            });
        }


        public static IObservable<Tuple<System.UInt32, System.UInt32>> Read(IObservable<System.UInt32> location)
        {
            return Observable.Select(location, (locationLambda) =>
            {
                var result = System.Threading.Volatile.Read(ref locationLambda);
                return Tuple.Create(result, locationLambda);
            });
        }


        public static IObservable<Tuple<System.Int64, System.Int64>> Read(IObservable<System.Int64> location)
        {
            return Observable.Select(location, (locationLambda) =>
            {
                var result = System.Threading.Volatile.Read(ref locationLambda);
                return Tuple.Create(result, locationLambda);
            });
        }


        public static IObservable<Tuple<System.UInt64, System.UInt64>> Read(IObservable<System.UInt64> location)
        {
            return Observable.Select(location, (locationLambda) =>
            {
                var result = System.Threading.Volatile.Read(ref locationLambda);
                return Tuple.Create(result, locationLambda);
            });
        }


        public static IObservable<Tuple<System.IntPtr, System.IntPtr>> Read(IObservable<System.IntPtr> location)
        {
            return Observable.Select(location, (locationLambda) =>
            {
                var result = System.Threading.Volatile.Read(ref locationLambda);
                return Tuple.Create(result, locationLambda);
            });
        }


        public static IObservable<Tuple<System.UIntPtr, System.UIntPtr>> Read(IObservable<System.UIntPtr> location)
        {
            return Observable.Select(location, (locationLambda) =>
            {
                var result = System.Threading.Volatile.Read(ref locationLambda);
                return Tuple.Create(result, locationLambda);
            });
        }


        public static IObservable<Tuple<System.Single, System.Single>> Read(IObservable<System.Single> location)
        {
            return Observable.Select(location, (locationLambda) =>
            {
                var result = System.Threading.Volatile.Read(ref locationLambda);
                return Tuple.Create(result, locationLambda);
            });
        }


        public static IObservable<Tuple<System.Double, System.Double>> Read(IObservable<System.Double> location)
        {
            return Observable.Select(location, (locationLambda) =>
            {
                var result = System.Threading.Volatile.Read(ref locationLambda);
                return Tuple.Create(result, locationLambda);
            });
        }


        public static IObservable<Tuple<T, T>> Read<T>(IObservable<T> location) where T : class
        {
            return Observable.Select(location, (locationLambda) =>
            {
                var result = System.Threading.Volatile.Read(ref locationLambda);
                return Tuple.Create(result, locationLambda);
            });
        }


        public static IObservable<System.Boolean> Write(IObservable<System.Boolean> location,
            IObservable<System.Boolean> value)
        {
            return Observable.Zip(location, value, (locationLambda, valueLambda) =>
            {
                System.Threading.Volatile.Write(ref locationLambda, valueLambda);
                return locationLambda;
            });
        }


        public static IObservable<System.SByte> Write(IObservable<System.SByte> location,
            IObservable<System.SByte> value)
        {
            return Observable.Zip(location, value, (locationLambda, valueLambda) =>
            {
                System.Threading.Volatile.Write(ref locationLambda, valueLambda);
                return locationLambda;
            });
        }


        public static IObservable<System.Byte> Write(IObservable<System.Byte> location, IObservable<System.Byte> value)
        {
            return Observable.Zip(location, value, (locationLambda, valueLambda) =>
            {
                System.Threading.Volatile.Write(ref locationLambda, valueLambda);
                return locationLambda;
            });
        }


        public static IObservable<System.Int16> Write(IObservable<System.Int16> location,
            IObservable<System.Int16> value)
        {
            return Observable.Zip(location, value, (locationLambda, valueLambda) =>
            {
                System.Threading.Volatile.Write(ref locationLambda, valueLambda);
                return locationLambda;
            });
        }


        public static IObservable<System.UInt16> Write(IObservable<System.UInt16> location,
            IObservable<System.UInt16> value)
        {
            return Observable.Zip(location, value, (locationLambda, valueLambda) =>
            {
                System.Threading.Volatile.Write(ref locationLambda, valueLambda);
                return locationLambda;
            });
        }


        public static IObservable<System.Int32> Write(IObservable<System.Int32> location,
            IObservable<System.Int32> value)
        {
            return Observable.Zip(location, value, (locationLambda, valueLambda) =>
            {
                System.Threading.Volatile.Write(ref locationLambda, valueLambda);
                return locationLambda;
            });
        }


        public static IObservable<System.UInt32> Write(IObservable<System.UInt32> location,
            IObservable<System.UInt32> value)
        {
            return Observable.Zip(location, value, (locationLambda, valueLambda) =>
            {
                System.Threading.Volatile.Write(ref locationLambda, valueLambda);
                return locationLambda;
            });
        }


        public static IObservable<System.Int64> Write(IObservable<System.Int64> location,
            IObservable<System.Int64> value)
        {
            return Observable.Zip(location, value, (locationLambda, valueLambda) =>
            {
                System.Threading.Volatile.Write(ref locationLambda, valueLambda);
                return locationLambda;
            });
        }


        public static IObservable<System.UInt64> Write(IObservable<System.UInt64> location,
            IObservable<System.UInt64> value)
        {
            return Observable.Zip(location, value, (locationLambda, valueLambda) =>
            {
                System.Threading.Volatile.Write(ref locationLambda, valueLambda);
                return locationLambda;
            });
        }


        public static IObservable<System.IntPtr> Write(IObservable<System.IntPtr> location,
            IObservable<System.IntPtr> value)
        {
            return Observable.Zip(location, value, (locationLambda, valueLambda) =>
            {
                System.Threading.Volatile.Write(ref locationLambda, valueLambda);
                return locationLambda;
            });
        }


        public static IObservable<System.UIntPtr> Write(IObservable<System.UIntPtr> location,
            IObservable<System.UIntPtr> value)
        {
            return Observable.Zip(location, value, (locationLambda, valueLambda) =>
            {
                System.Threading.Volatile.Write(ref locationLambda, valueLambda);
                return locationLambda;
            });
        }


        public static IObservable<System.Single> Write(IObservable<System.Single> location,
            IObservable<System.Single> value)
        {
            return Observable.Zip(location, value, (locationLambda, valueLambda) =>
            {
                System.Threading.Volatile.Write(ref locationLambda, valueLambda);
                return locationLambda;
            });
        }


        public static IObservable<System.Double> Write(IObservable<System.Double> location,
            IObservable<System.Double> value)
        {
            return Observable.Zip(location, value, (locationLambda, valueLambda) =>
            {
                System.Threading.Volatile.Write(ref locationLambda, valueLambda);
                return locationLambda;
            });
        }


        public static IObservable<T> Write<T>(IObservable<T> location, IObservable<T> value) where T : class
        {
            return Observable.Zip(location, value, (locationLambda, valueLambda) =>
            {
                System.Threading.Volatile.Write(ref locationLambda, valueLambda);
                return locationLambda;
            });
        }
    }
}