using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
    public static class __UnmanagedMemoryStream
    {
        public static IObservable<System.Reactive.Unit> Flush(
            this IObservable<System.IO.UnmanagedMemoryStream> UnmanagedMemoryStreamValue)
        {
            return
                Observable.Do(UnmanagedMemoryStreamValue,
                    (UnmanagedMemoryStreamValueLambda) => UnmanagedMemoryStreamValueLambda.Flush()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> FlushAsync(
            this IObservable<System.IO.UnmanagedMemoryStream> UnmanagedMemoryStreamValue,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(UnmanagedMemoryStreamValue, cancellationToken,
                    (UnmanagedMemoryStreamValueLambda, cancellationTokenLambda) =>
                        UnmanagedMemoryStreamValueLambda.FlushAsync(cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<int> Read(
            this IObservable<System.IO.UnmanagedMemoryStream> UnmanagedMemoryStreamValue,
            IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count)
        {
            return Observable.Zip(UnmanagedMemoryStreamValue, buffer, offset, count,
                (UnmanagedMemoryStreamValueLambda, bufferLambda, offsetLambda, countLambda) =>
                    UnmanagedMemoryStreamValueLambda.Read(bufferLambda, offsetLambda, countLambda));
        }


        public static IObservable<System.Int32> ReadAsync(
            this IObservable<System.IO.UnmanagedMemoryStream> UnmanagedMemoryStreamValue,
            IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(UnmanagedMemoryStreamValue, buffer, offset, count, cancellationToken,
                    (UnmanagedMemoryStreamValueLambda, bufferLambda, offsetLambda, countLambda, cancellationTokenLambda)
                        =>
                        UnmanagedMemoryStreamValueLambda.ReadAsync(bufferLambda, offsetLambda, countLambda,
                            cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Int32> ReadByte(
            this IObservable<System.IO.UnmanagedMemoryStream> UnmanagedMemoryStreamValue)
        {
            return Observable.Select(UnmanagedMemoryStreamValue,
                (UnmanagedMemoryStreamValueLambda) => UnmanagedMemoryStreamValueLambda.ReadByte());
        }


        public static IObservable<System.Int64> Seek(
            this IObservable<System.IO.UnmanagedMemoryStream> UnmanagedMemoryStreamValue,
            IObservable<System.Int64> offset, IObservable<System.IO.SeekOrigin> loc)
        {
            return Observable.Zip(UnmanagedMemoryStreamValue, offset, loc,
                (UnmanagedMemoryStreamValueLambda, offsetLambda, locLambda) =>
                    UnmanagedMemoryStreamValueLambda.Seek(offsetLambda, locLambda));
        }


        public static IObservable<System.Reactive.Unit> SetLength(
            this IObservable<System.IO.UnmanagedMemoryStream> UnmanagedMemoryStreamValue,
            IObservable<System.Int64> value)
        {
            return ObservableExt.ZipExecute(UnmanagedMemoryStreamValue, value,
                (UnmanagedMemoryStreamValueLambda, valueLambda) =>
                    UnmanagedMemoryStreamValueLambda.SetLength(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(
            this IObservable<System.IO.UnmanagedMemoryStream> UnmanagedMemoryStreamValue,
            IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count)
        {
            return ObservableExt.ZipExecute(UnmanagedMemoryStreamValue, buffer, offset, count,
                (UnmanagedMemoryStreamValueLambda, bufferLambda, offsetLambda, countLambda) =>
                    UnmanagedMemoryStreamValueLambda.Write(bufferLambda, offsetLambda, countLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteAsync(
            this IObservable<System.IO.UnmanagedMemoryStream> UnmanagedMemoryStreamValue,
            IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(UnmanagedMemoryStreamValue, buffer, offset, count, cancellationToken,
                    (UnmanagedMemoryStreamValueLambda, bufferLambda, offsetLambda, countLambda, cancellationTokenLambda)
                        =>
                        UnmanagedMemoryStreamValueLambda.WriteAsync(bufferLambda, offsetLambda, countLambda,
                            cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> WriteByte(
            this IObservable<System.IO.UnmanagedMemoryStream> UnmanagedMemoryStreamValue, IObservable<System.Byte> value)
        {
            return ObservableExt.ZipExecute(UnmanagedMemoryStreamValue, value,
                (UnmanagedMemoryStreamValueLambda, valueLambda) =>
                    UnmanagedMemoryStreamValueLambda.WriteByte(valueLambda));
        }


        public static IObservable<System.Boolean> get_CanRead(
            this IObservable<System.IO.UnmanagedMemoryStream> UnmanagedMemoryStreamValue)
        {
            return Observable.Select(UnmanagedMemoryStreamValue,
                (UnmanagedMemoryStreamValueLambda) => UnmanagedMemoryStreamValueLambda.CanRead);
        }


        public static IObservable<System.Boolean> get_CanSeek(
            this IObservable<System.IO.UnmanagedMemoryStream> UnmanagedMemoryStreamValue)
        {
            return Observable.Select(UnmanagedMemoryStreamValue,
                (UnmanagedMemoryStreamValueLambda) => UnmanagedMemoryStreamValueLambda.CanSeek);
        }


        public static IObservable<System.Boolean> get_CanWrite(
            this IObservable<System.IO.UnmanagedMemoryStream> UnmanagedMemoryStreamValue)
        {
            return Observable.Select(UnmanagedMemoryStreamValue,
                (UnmanagedMemoryStreamValueLambda) => UnmanagedMemoryStreamValueLambda.CanWrite);
        }


        public static IObservable<System.Int64> get_Length(
            this IObservable<System.IO.UnmanagedMemoryStream> UnmanagedMemoryStreamValue)
        {
            return Observable.Select(UnmanagedMemoryStreamValue,
                (UnmanagedMemoryStreamValueLambda) => UnmanagedMemoryStreamValueLambda.Length);
        }


        public static IObservable<System.Int64> get_Capacity(
            this IObservable<System.IO.UnmanagedMemoryStream> UnmanagedMemoryStreamValue)
        {
            return Observable.Select(UnmanagedMemoryStreamValue,
                (UnmanagedMemoryStreamValueLambda) => UnmanagedMemoryStreamValueLambda.Capacity);
        }


        public static IObservable<System.Int64> get_Position(
            this IObservable<System.IO.UnmanagedMemoryStream> UnmanagedMemoryStreamValue)
        {
            return Observable.Select(UnmanagedMemoryStreamValue,
                (UnmanagedMemoryStreamValueLambda) => UnmanagedMemoryStreamValueLambda.Position);
        }


        public static IObservable<System.Reactive.Unit> set_Position(
            this IObservable<System.IO.UnmanagedMemoryStream> UnmanagedMemoryStreamValue,
            IObservable<System.Int64> value)
        {
            return ObservableExt.ZipExecute(UnmanagedMemoryStreamValue, value,
                (UnmanagedMemoryStreamValueLambda, valueLambda) =>
                    UnmanagedMemoryStreamValueLambda.Position = valueLambda);
        }
    }
}