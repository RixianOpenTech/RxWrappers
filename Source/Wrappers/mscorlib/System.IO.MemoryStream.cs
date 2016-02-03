using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
    public static class __MemoryStream
    {
        public static IObservable<System.Reactive.Unit> Flush(this IObservable<System.IO.MemoryStream> MemoryStreamValue)
        {
            return
                Observable.Do(MemoryStreamValue, (MemoryStreamValueLambda) => MemoryStreamValueLambda.Flush()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> FlushAsync(
            this IObservable<System.IO.MemoryStream> MemoryStreamValue,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(MemoryStreamValue, cancellationToken,
                    (MemoryStreamValueLambda, cancellationTokenLambda) =>
                        MemoryStreamValueLambda.FlushAsync(cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Byte[]> GetBuffer(this IObservable<System.IO.MemoryStream> MemoryStreamValue)
        {
            return Observable.Select(MemoryStreamValue, (MemoryStreamValueLambda) => MemoryStreamValueLambda.GetBuffer());
        }


        public static IObservable<Tuple<System.Boolean, System.ArraySegment<System.Byte>>> TryGetBuffer(
            this IObservable<System.IO.MemoryStream> MemoryStreamValue)
        {
            return Observable.Select(MemoryStreamValue, (MemoryStreamValueLambda) =>
            {
                System.ArraySegment<System.Byte> bufferOutput = default(System.ArraySegment<System.Byte>);
                var result = MemoryStreamValueLambda.TryGetBuffer(out bufferOutput);
                return Tuple.Create(result, bufferOutput);
            });
        }


        public static IObservable<int> Read(this IObservable<System.IO.MemoryStream> MemoryStreamValue,
            IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count)
        {
            return Observable.Zip(MemoryStreamValue, buffer, offset, count,
                (MemoryStreamValueLambda, bufferLambda, offsetLambda, countLambda) =>
                    MemoryStreamValueLambda.Read(bufferLambda, offsetLambda, countLambda));
        }


        public static IObservable<System.Int32> ReadAsync(this IObservable<System.IO.MemoryStream> MemoryStreamValue,
            IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(MemoryStreamValue, buffer, offset, count, cancellationToken,
                    (MemoryStreamValueLambda, bufferLambda, offsetLambda, countLambda, cancellationTokenLambda) =>
                        MemoryStreamValueLambda.ReadAsync(bufferLambda, offsetLambda, countLambda,
                            cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Int32> ReadByte(this IObservable<System.IO.MemoryStream> MemoryStreamValue)
        {
            return Observable.Select(MemoryStreamValue, (MemoryStreamValueLambda) => MemoryStreamValueLambda.ReadByte());
        }


        public static IObservable<System.Reactive.Unit> CopyToAsync(
            this IObservable<System.IO.MemoryStream> MemoryStreamValue, IObservable<System.IO.Stream> destination,
            IObservable<System.Int32> bufferSize, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(MemoryStreamValue, destination, bufferSize, cancellationToken,
                    (MemoryStreamValueLambda, destinationLambda, bufferSizeLambda, cancellationTokenLambda) =>
                        MemoryStreamValueLambda.CopyToAsync(destinationLambda, bufferSizeLambda, cancellationTokenLambda)
                            .ToObservable()).Flatten();
        }


        public static IObservable<System.Int64> Seek(this IObservable<System.IO.MemoryStream> MemoryStreamValue,
            IObservable<System.Int64> offset, IObservable<System.IO.SeekOrigin> loc)
        {
            return Observable.Zip(MemoryStreamValue, offset, loc,
                (MemoryStreamValueLambda, offsetLambda, locLambda) =>
                    MemoryStreamValueLambda.Seek(offsetLambda, locLambda));
        }


        public static IObservable<System.Reactive.Unit> SetLength(
            this IObservable<System.IO.MemoryStream> MemoryStreamValue, IObservable<System.Int64> value)
        {
            return ObservableExt.ZipExecute(MemoryStreamValue, value,
                (MemoryStreamValueLambda, valueLambda) => MemoryStreamValueLambda.SetLength(valueLambda));
        }


        public static IObservable<System.Byte[]> ToArray(this IObservable<System.IO.MemoryStream> MemoryStreamValue)
        {
            return Observable.Select(MemoryStreamValue, (MemoryStreamValueLambda) => MemoryStreamValueLambda.ToArray());
        }


        public static IObservable<System.Reactive.Unit> Write(
            this IObservable<System.IO.MemoryStream> MemoryStreamValue, IObservable<System.Byte[]> buffer,
            IObservable<System.Int32> offset, IObservable<System.Int32> count)
        {
            return ObservableExt.ZipExecute(MemoryStreamValue, buffer, offset, count,
                (MemoryStreamValueLambda, bufferLambda, offsetLambda, countLambda) =>
                    MemoryStreamValueLambda.Write(bufferLambda, offsetLambda, countLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteAsync(
            this IObservable<System.IO.MemoryStream> MemoryStreamValue, IObservable<System.Byte[]> buffer,
            IObservable<System.Int32> offset, IObservable<System.Int32> count,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(MemoryStreamValue, buffer, offset, count, cancellationToken,
                    (MemoryStreamValueLambda, bufferLambda, offsetLambda, countLambda, cancellationTokenLambda) =>
                        MemoryStreamValueLambda.WriteAsync(bufferLambda, offsetLambda, countLambda,
                            cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> WriteByte(
            this IObservable<System.IO.MemoryStream> MemoryStreamValue, IObservable<System.Byte> value)
        {
            return ObservableExt.ZipExecute(MemoryStreamValue, value,
                (MemoryStreamValueLambda, valueLambda) => MemoryStreamValueLambda.WriteByte(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteTo(
            this IObservable<System.IO.MemoryStream> MemoryStreamValue, IObservable<System.IO.Stream> stream)
        {
            return ObservableExt.ZipExecute(MemoryStreamValue, stream,
                (MemoryStreamValueLambda, streamLambda) => MemoryStreamValueLambda.WriteTo(streamLambda));
        }


        public static IObservable<System.Boolean> get_CanRead(this IObservable<System.IO.MemoryStream> MemoryStreamValue)
        {
            return Observable.Select(MemoryStreamValue, (MemoryStreamValueLambda) => MemoryStreamValueLambda.CanRead);
        }


        public static IObservable<System.Boolean> get_CanSeek(this IObservable<System.IO.MemoryStream> MemoryStreamValue)
        {
            return Observable.Select(MemoryStreamValue, (MemoryStreamValueLambda) => MemoryStreamValueLambda.CanSeek);
        }


        public static IObservable<System.Boolean> get_CanWrite(
            this IObservable<System.IO.MemoryStream> MemoryStreamValue)
        {
            return Observable.Select(MemoryStreamValue, (MemoryStreamValueLambda) => MemoryStreamValueLambda.CanWrite);
        }


        public static IObservable<System.Int32> get_Capacity(this IObservable<System.IO.MemoryStream> MemoryStreamValue)
        {
            return Observable.Select(MemoryStreamValue, (MemoryStreamValueLambda) => MemoryStreamValueLambda.Capacity);
        }


        public static IObservable<System.Int64> get_Length(this IObservable<System.IO.MemoryStream> MemoryStreamValue)
        {
            return Observable.Select(MemoryStreamValue, (MemoryStreamValueLambda) => MemoryStreamValueLambda.Length);
        }


        public static IObservable<System.Int64> get_Position(this IObservable<System.IO.MemoryStream> MemoryStreamValue)
        {
            return Observable.Select(MemoryStreamValue, (MemoryStreamValueLambda) => MemoryStreamValueLambda.Position);
        }


        public static IObservable<System.Reactive.Unit> set_Capacity(
            this IObservable<System.IO.MemoryStream> MemoryStreamValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(MemoryStreamValue, value,
                (MemoryStreamValueLambda, valueLambda) => MemoryStreamValueLambda.Capacity = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Position(
            this IObservable<System.IO.MemoryStream> MemoryStreamValue, IObservable<System.Int64> value)
        {
            return ObservableExt.ZipExecute(MemoryStreamValue, value,
                (MemoryStreamValueLambda, valueLambda) => MemoryStreamValueLambda.Position = valueLambda);
        }
    }
}