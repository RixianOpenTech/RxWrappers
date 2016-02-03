using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
public static class _Stream
{
    
public static IObservable<System.Reactive.Unit> CopyToAsync(this IObservable<System.IO.Stream> StreamValue, IObservable<System.IO.Stream> destination)
{
    return Observable.Zip(StreamValue, destination, (StreamValueLambda, destinationLambda) => StreamValueLambda.CopyToAsync(destinationLambda).ToObservable()).Flatten();
}


public static IObservable<System.Reactive.Unit> CopyToAsync(this IObservable<System.IO.Stream> StreamValue, IObservable<System.IO.Stream> destination, IObservable<System.Int32> bufferSize)
{
    return Observable.Zip(StreamValue, destination, bufferSize, (StreamValueLambda, destinationLambda, bufferSizeLambda) => StreamValueLambda.CopyToAsync(destinationLambda, bufferSizeLambda).ToObservable()).Flatten();
}


public static IObservable<System.Reactive.Unit> CopyToAsync(this IObservable<System.IO.Stream> StreamValue, IObservable<System.IO.Stream> destination, IObservable<System.Int32> bufferSize, IObservable<System.Threading.CancellationToken> cancellationToken)
{
    return Observable.Zip(StreamValue, destination, bufferSize, cancellationToken, (StreamValueLambda, destinationLambda, bufferSizeLambda, cancellationTokenLambda) => StreamValueLambda.CopyToAsync(destinationLambda, bufferSizeLambda, cancellationTokenLambda).ToObservable()).Flatten();
}


public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.IO.Stream> StreamValue, IObservable<System.IO.Stream> destination)
{
    return ObservableExt.ZipExecute(StreamValue, destination, (StreamValueLambda, destinationLambda) => StreamValueLambda.CopyTo(destinationLambda));
}


public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.IO.Stream> StreamValue, IObservable<System.IO.Stream> destination, IObservable<System.Int32> bufferSize)
{
    return ObservableExt.ZipExecute(StreamValue, destination, bufferSize, (StreamValueLambda, destinationLambda, bufferSizeLambda) => StreamValueLambda.CopyTo(destinationLambda, bufferSizeLambda));
}


public static IObservable<System.Reactive.Unit> Close(this IObservable<System.IO.Stream> StreamValue)
{
    return Observable.Do(StreamValue, (StreamValueLambda) => StreamValueLambda.Close()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.IO.Stream> StreamValue)
{
    return Observable.Do(StreamValue, (StreamValueLambda) => StreamValueLambda.Dispose()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Flush(this IObservable<System.IO.Stream> StreamValue)
{
    return Observable.Do(StreamValue, (StreamValueLambda) => StreamValueLambda.Flush()).ToUnit();
}


public static IObservable<System.Reactive.Unit> FlushAsync(this IObservable<System.IO.Stream> StreamValue)
{
    return Observable.Select(StreamValue, (StreamValueLambda) => StreamValueLambda.FlushAsync().ToObservable()).Flatten().ToUnit();
}


public static IObservable<System.Reactive.Unit> FlushAsync(this IObservable<System.IO.Stream> StreamValue, IObservable<System.Threading.CancellationToken> cancellationToken)
{
    return Observable.Zip(StreamValue, cancellationToken, (StreamValueLambda, cancellationTokenLambda) => StreamValueLambda.FlushAsync(cancellationTokenLambda).ToObservable()).Flatten();
}


public static IObservable<System.IAsyncResult> BeginRead(this IObservable<System.IO.Stream> StreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count, IObservable<System.AsyncCallback> callback, IObservable<System.Object> state)
{
    return Observable.Zip(StreamValue, buffer, offset, count, callback, state, (StreamValueLambda, bufferLambda, offsetLambda, countLambda, callbackLambda, stateLambda) => StreamValueLambda.BeginRead(bufferLambda, offsetLambda, countLambda, callbackLambda, stateLambda));
}


public static IObservable<System.Int32> EndRead(this IObservable<System.IO.Stream> StreamValue, IObservable<System.IAsyncResult> asyncResult)
{
    return Observable.Zip(StreamValue, asyncResult, (StreamValueLambda, asyncResultLambda) => StreamValueLambda.EndRead(asyncResultLambda));
}


public static IObservable<System.Int32> ReadAsync(this IObservable<System.IO.Stream> StreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count)
{
    return Observable.Zip(StreamValue, buffer, offset, count, (StreamValueLambda, bufferLambda, offsetLambda, countLambda) => StreamValueLambda.ReadAsync(bufferLambda, offsetLambda, countLambda).ToObservable()).Flatten();
}


public static IObservable<System.Int32> ReadAsync(this IObservable<System.IO.Stream> StreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count, IObservable<System.Threading.CancellationToken> cancellationToken)
{
    return Observable.Zip(StreamValue, buffer, offset, count, cancellationToken, (StreamValueLambda, bufferLambda, offsetLambda, countLambda, cancellationTokenLambda) => StreamValueLambda.ReadAsync(bufferLambda, offsetLambda, countLambda, cancellationTokenLambda).ToObservable()).Flatten();
}


public static IObservable<System.IAsyncResult> BeginWrite(this IObservable<System.IO.Stream> StreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count, IObservable<System.AsyncCallback> callback, IObservable<System.Object> state)
{
    return Observable.Zip(StreamValue, buffer, offset, count, callback, state, (StreamValueLambda, bufferLambda, offsetLambda, countLambda, callbackLambda, stateLambda) => StreamValueLambda.BeginWrite(bufferLambda, offsetLambda, countLambda, callbackLambda, stateLambda));
}


public static IObservable<System.Reactive.Unit> EndWrite(this IObservable<System.IO.Stream> StreamValue, IObservable<System.IAsyncResult> asyncResult)
{
    return ObservableExt.ZipExecute(StreamValue, asyncResult, (StreamValueLambda, asyncResultLambda) => StreamValueLambda.EndWrite(asyncResultLambda));
}


public static IObservable<System.Reactive.Unit> WriteAsync(this IObservable<System.IO.Stream> StreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count)
{
    return Observable.Zip(StreamValue, buffer, offset, count, (StreamValueLambda, bufferLambda, offsetLambda, countLambda) => StreamValueLambda.WriteAsync(bufferLambda, offsetLambda, countLambda).ToObservable()).Flatten();
}


public static IObservable<System.Reactive.Unit> WriteAsync(this IObservable<System.IO.Stream> StreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count, IObservable<System.Threading.CancellationToken> cancellationToken)
{
    return Observable.Zip(StreamValue, buffer, offset, count, cancellationToken, (StreamValueLambda, bufferLambda, offsetLambda, countLambda, cancellationTokenLambda) => StreamValueLambda.WriteAsync(bufferLambda, offsetLambda, countLambda, cancellationTokenLambda).ToObservable()).Flatten();
}


public static IObservable<System.Int64> Seek(this IObservable<System.IO.Stream> StreamValue, IObservable<System.Int64> offset, IObservable<System.IO.SeekOrigin> origin)
{
    return Observable.Zip(StreamValue, offset, origin, (StreamValueLambda, offsetLambda, originLambda) => StreamValueLambda.Seek(offsetLambda, originLambda));
}


public static IObservable<System.Reactive.Unit> SetLength(this IObservable<System.IO.Stream> StreamValue, IObservable<System.Int64> value)
{
    return ObservableExt.ZipExecute(StreamValue, value, (StreamValueLambda, valueLambda) => StreamValueLambda.SetLength(valueLambda));
}


public static IObservable<Tuple<System.Int32, System.Byte>> Read(this IObservable<System.IO.Stream> StreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count)
{
    return Observable.Zip(StreamValue, buffer, offset, count, (StreamValueLambda, bufferLambda, offsetLambda, countLambda) => StreamValueLambda.Read(bufferLambda, offsetLambda, countLambda));
}


public static IObservable<System.Int32> ReadByte(this IObservable<System.IO.Stream> StreamValue)
{
    return Observable.Select(StreamValue, (StreamValueLambda) => StreamValueLambda.ReadByte());
}


public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.Stream> StreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count)
{
    return ObservableExt.ZipExecute(StreamValue, buffer, offset, count, (StreamValueLambda, bufferLambda, offsetLambda, countLambda) => StreamValueLambda.Write(bufferLambda, offsetLambda, countLambda));
}


public static IObservable<System.Reactive.Unit> WriteByte(this IObservable<System.IO.Stream> StreamValue, IObservable<System.Byte> value)
{
    return ObservableExt.ZipExecute(StreamValue, value, (StreamValueLambda, valueLambda) => StreamValueLambda.WriteByte(valueLambda));
}


public static IObservable<System.IO.Stream> Synchronized(IObservable<System.IO.Stream> stream)
{
    return Observable.Select(stream, (streamLambda) => System.IO.Stream.Synchronized(streamLambda));
}


public static IObservable<System.Boolean> get_CanRead(this IObservable<System.IO.Stream> StreamValue)
{
    return Observable.Select(StreamValue, (StreamValueLambda) => StreamValueLambda.CanRead);
}


public static IObservable<System.Boolean> get_CanSeek(this IObservable<System.IO.Stream> StreamValue)
{
    return Observable.Select(StreamValue, (StreamValueLambda) => StreamValueLambda.CanSeek);
}


public static IObservable<System.Boolean> get_CanTimeout(this IObservable<System.IO.Stream> StreamValue)
{
    return Observable.Select(StreamValue, (StreamValueLambda) => StreamValueLambda.CanTimeout);
}


public static IObservable<System.Boolean> get_CanWrite(this IObservable<System.IO.Stream> StreamValue)
{
    return Observable.Select(StreamValue, (StreamValueLambda) => StreamValueLambda.CanWrite);
}


public static IObservable<System.Int64> get_Length(this IObservable<System.IO.Stream> StreamValue)
{
    return Observable.Select(StreamValue, (StreamValueLambda) => StreamValueLambda.Length);
}


public static IObservable<System.Int64> get_Position(this IObservable<System.IO.Stream> StreamValue)
{
    return Observable.Select(StreamValue, (StreamValueLambda) => StreamValueLambda.Position);
}


public static IObservable<System.Int32> get_ReadTimeout(this IObservable<System.IO.Stream> StreamValue)
{
    return Observable.Select(StreamValue, (StreamValueLambda) => StreamValueLambda.ReadTimeout);
}


public static IObservable<System.Int32> get_WriteTimeout(this IObservable<System.IO.Stream> StreamValue)
{
    return Observable.Select(StreamValue, (StreamValueLambda) => StreamValueLambda.WriteTimeout);
}


public static IObservable<System.Reactive.Unit> set_Position(this IObservable<System.IO.Stream> StreamValue, IObservable<System.Int64> value)
{
    return ObservableExt.ZipExecute(StreamValue, value, (StreamValueLambda, valueLambda) => StreamValueLambda.Position = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ReadTimeout(this IObservable<System.IO.Stream> StreamValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(StreamValue, value, (StreamValueLambda, valueLambda) => StreamValueLambda.ReadTimeout = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_WriteTimeout(this IObservable<System.IO.Stream> StreamValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(StreamValue, value, (StreamValueLambda, valueLambda) => StreamValueLambda.WriteTimeout = valueLambda);
}

}
}