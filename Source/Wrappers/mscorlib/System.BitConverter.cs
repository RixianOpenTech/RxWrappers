using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __BitConverter
    {
        public static IObservable<System.Byte[]> GetBytes(IObservable<System.Boolean> value)
        {
            return Observable.Select(value, (valueLambda) => System.BitConverter.GetBytes(valueLambda));
        }


        public static IObservable<System.Byte[]> GetBytes(IObservable<System.Char> value)
        {
            return Observable.Select(value, (valueLambda) => System.BitConverter.GetBytes(valueLambda));
        }


        public static IObservable<System.Byte[]> GetBytes(IObservable<System.Int16> value)
        {
            return Observable.Select(value, (valueLambda) => System.BitConverter.GetBytes(valueLambda));
        }


        public static IObservable<System.Byte[]> GetBytes(IObservable<System.Int32> value)
        {
            return Observable.Select(value, (valueLambda) => System.BitConverter.GetBytes(valueLambda));
        }


        public static IObservable<System.Byte[]> GetBytes(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => System.BitConverter.GetBytes(valueLambda));
        }


        public static IObservable<System.Byte[]> GetBytes(IObservable<System.UInt16> value)
        {
            return Observable.Select(value, (valueLambda) => System.BitConverter.GetBytes(valueLambda));
        }


        public static IObservable<System.Byte[]> GetBytes(IObservable<System.UInt32> value)
        {
            return Observable.Select(value, (valueLambda) => System.BitConverter.GetBytes(valueLambda));
        }


        public static IObservable<System.Byte[]> GetBytes(IObservable<System.UInt64> value)
        {
            return Observable.Select(value, (valueLambda) => System.BitConverter.GetBytes(valueLambda));
        }


        public static IObservable<System.Byte[]> GetBytes(IObservable<System.Single> value)
        {
            return Observable.Select(value, (valueLambda) => System.BitConverter.GetBytes(valueLambda));
        }


        public static IObservable<System.Byte[]> GetBytes(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.BitConverter.GetBytes(valueLambda));
        }


        public static IObservable<System.Char> ToChar(IObservable<System.Byte[]> value,
            IObservable<System.Int32> startIndex)
        {
            return Observable.Zip(value, startIndex,
                (valueLambda, startIndexLambda) => System.BitConverter.ToChar(valueLambda, startIndexLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.Byte[]> value,
            IObservable<System.Int32> startIndex)
        {
            return Observable.Zip(value, startIndex,
                (valueLambda, startIndexLambda) => System.BitConverter.ToInt16(valueLambda, startIndexLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.Byte[]> value,
            IObservable<System.Int32> startIndex)
        {
            return Observable.Zip(value, startIndex,
                (valueLambda, startIndexLambda) => System.BitConverter.ToInt32(valueLambda, startIndexLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.Byte[]> value,
            IObservable<System.Int32> startIndex)
        {
            return Observable.Zip(value, startIndex,
                (valueLambda, startIndexLambda) => System.BitConverter.ToInt64(valueLambda, startIndexLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.Byte[]> value,
            IObservable<System.Int32> startIndex)
        {
            return Observable.Zip(value, startIndex,
                (valueLambda, startIndexLambda) => System.BitConverter.ToUInt16(valueLambda, startIndexLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.Byte[]> value,
            IObservable<System.Int32> startIndex)
        {
            return Observable.Zip(value, startIndex,
                (valueLambda, startIndexLambda) => System.BitConverter.ToUInt32(valueLambda, startIndexLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.Byte[]> value,
            IObservable<System.Int32> startIndex)
        {
            return Observable.Zip(value, startIndex,
                (valueLambda, startIndexLambda) => System.BitConverter.ToUInt64(valueLambda, startIndexLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.Byte[]> value,
            IObservable<System.Int32> startIndex)
        {
            return Observable.Zip(value, startIndex,
                (valueLambda, startIndexLambda) => System.BitConverter.ToSingle(valueLambda, startIndexLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.Byte[]> value,
            IObservable<System.Int32> startIndex)
        {
            return Observable.Zip(value, startIndex,
                (valueLambda, startIndexLambda) => System.BitConverter.ToDouble(valueLambda, startIndexLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Byte[]> value,
            IObservable<System.Int32> startIndex, IObservable<System.Int32> length)
        {
            return Observable.Zip(value, startIndex, length,
                (valueLambda, startIndexLambda, lengthLambda) =>
                    System.BitConverter.ToString(valueLambda, startIndexLambda, lengthLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Byte[]> value)
        {
            return Observable.Select(value, (valueLambda) => System.BitConverter.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Byte[]> value,
            IObservable<System.Int32> startIndex)
        {
            return Observable.Zip(value, startIndex,
                (valueLambda, startIndexLambda) => System.BitConverter.ToString(valueLambda, startIndexLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(IObservable<System.Byte[]> value,
            IObservable<System.Int32> startIndex)
        {
            return Observable.Zip(value, startIndex,
                (valueLambda, startIndexLambda) => System.BitConverter.ToBoolean(valueLambda, startIndexLambda));
        }


        public static IObservable<System.Int64> DoubleToInt64Bits(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.BitConverter.DoubleToInt64Bits(valueLambda));
        }


        public static IObservable<System.Double> Int64BitsToDouble(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => System.BitConverter.Int64BitsToDouble(valueLambda));
        }
    }
}