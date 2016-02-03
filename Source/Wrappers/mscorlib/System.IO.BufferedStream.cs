using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
public static class _BufferedStream
{
    
public static IObservable<System.Reactive.Unit> Flush(this IObservable<System.IO.BufferedStream> BufferedStreamValue)
{
    return Observable.Do(BufferedStreamValue, (BufferedStreamValueLambda) => BufferedStreamValueLambda.Flush()).ToUnit();
}


public static IObservable<System.Reactive.Unit> FlushAsync(this IObservable<System.IO.BufferedStream> BufferedStreamValue, IObservable<System.Threading.CancellationToken> cancellationToken)
{
    return Observable.Zip(BufferedStreamValue, cancellationToken, (BufferedStreamValueLambda, cancellationTokenLambda) => BufferedStreamValueLambda.FlushAsync(cancellationTokenLambda).ToObservable()).Flatten();
}


public static IObservable<Tuple<System.Int32, System.Byte>> Read(this IObservable<System.IO.BufferedStream> BufferedStreamValue, IObservable<System.Byte[]> array, IObservable<System.Int32> offset, IObservable<System.Int32> count)
{
    return Observable.Zip(BufferedStreamValue, array, offset, count, (BufferedStreamValueLambda, arrayLambda, offsetLambda, countLambda) => BufferedStreamValueLambda.Read(arrayLambda, offsetLambda, countLambda));
}


public static IObservable<System.IAsyncResult> BeginRead(this IObservable<System.IO.BufferedStream> BufferedStreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count, IObservable<System.AsyncCallback> callback, IObservable<System.Object> state)
{
    return Observable.Zip(BufferedStreamValue, buffer, offset, count, callback, state, (BufferedStreamValueLambda, bufferLambda, offsetLambda, countLambda, callbackLambda, stateLambda) => BufferedStreamValueLambda.BeginRead(bufferLambda, offsetLambda, countLambda, callbackLambda, stateLambda));
}


public static IObservable<System.Int32> EndRead(this IObservable<System.IO.BufferedStream> BufferedStreamValue, IObservable<System.IAsyncResult> asyncResult)
{
    return Observable.Zip(BufferedStreamValue, asyncResult, (BufferedStreamValueLambda, asyncResultLambda) => BufferedStreamValueLambda.EndRead(asyncResultLambda));
}


public static IObservable<System.Int32> ReadAsync(this IObservable<System.IO.BufferedStream> BufferedStreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count, IObservable<System.Threading.CancellationToken> cancellationToken)
{
    return Observable.Zip(BufferedStreamValue, buffer, offset, count, cancellationToken, (BufferedStreamValueLambda, bufferLambda, offsetLambda, countLambda, cancellationTokenLambda) => BufferedStreamValueLambda.ReadAsync(bufferLambda, offsetLambda, countLambda, cancellationTokenLambda).ToObservable()).Flatten();
}


public static IObservable<System.Int32> ReadByte(this IObservable<System.IO.BufferedStream> BufferedStreamValue)
{
    return Observable.Select(BufferedStreamValue, (BufferedStreamValueLambda) => BufferedStreamValueLambda.ReadByte());
}


public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.BufferedStream> BufferedStreamValue, IObservable<System.Byte[]> array, IObservable<System.Int32> offset, IObservable<System.Int32> count)
{
    return ObservableExt.ZipExecute(BufferedStreamValue, array, offset, count, (BufferedStreamValueLambda, arrayLambda, offsetLambda, countLambda) => BufferedStreamValueLambda.Write(arrayLambda, offsetLambda, countLambda));
}


public static IObservable<System.IAsyncResult> BeginWrite(this IObservable<System.IO.BufferedStream> BufferedStreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count, IObservable<System.AsyncCallback> callback, IObservable<System.Object> state)
{
    return Observable.Zip(BufferedStreamValue, buffer, offset, count, callback, state, (BufferedStreamValueLambda, bufferLambda, offsetLambda, countLambda, callbackLambda, stateLambda) => BufferedStreamValueLambda.BeginWrite(bufferLambda, offsetLambda, countLambda, callbackLambda, stateLambda));
}


public static IObservable<System.Reactive.Unit> EndWrite(this IObservable<System.IO.BufferedStream> BufferedStreamValue, IObservable<System.IAsyncResult> asyncResult)
{
    return ObservableExt.ZipExecute(BufferedStreamValue, asyncResult, (BufferedStreamValueLambda, asyncResultLambda) => BufferedStreamValueLambda.EndWrite(asyncResultLambda));
}


public static IObservable<System.Reactive.Unit> WriteAsync(this IObservable<System.IO.BufferedStream> BufferedStreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count, IObservable<System.Threading.CancellationToken> cancellationToken)
{
    return Observable.Zip(BufferedStreamValue, buffer, offset, count, cancellationToken, (BufferedStreamValueLambda, bufferLambda, offsetLambda, countLambda, cancellationTokenLambda) => BufferedStreamValueLambda.WriteAsync(bufferLambda, offsetLambda, countLambda, cancellationTokenLambda).ToObservable()).Flatten();
}


public static IObservable<System.Reactive.Unit> WriteByte(this IObservable<System.IO.BufferedStream> BufferedStreamValue, IObservable<System.Byte> value)
{
    return ObservableExt.ZipExecute(BufferedStreamValue, value, (BufferedStreamValueLambda, valueLambda) => BufferedStreamValueLambda.WriteByte(valueLambda));
}


public static IObservable<System.Int64> Seek(this IObservable<System.IO.BufferedStream> BufferedStreamValue, IObservable<System.Int64> offset, IObservable<System.IO.SeekOrigin> origin)
{
    return Observable.Zip(BufferedStreamValue, offset, origin, (BufferedStreamValueLambda, offsetLambda, originLambda) => BufferedStreamValueLambda.Seek(offsetLambda, originLambda));
}


public static IObservable<System.Reactive.Unit> SetLength(this IObservable<System.IO.BufferedStream> BufferedStreamValue, IObservable<System.Int64> value)
{
    return ObservableExt.ZipExecute(BufferedStreamValue, value, (BufferedStreamValueLambda, valueLambda) => BufferedStreamValueLambda.SetLength(valueLambda));
}


public static IObservable<System.Boolean> get_CanRead(this IObservable<System.IO.BufferedStream> BufferedStreamValue)
{
    return Observable.Select(BufferedStreamValue, (BufferedStreamValueLambda) => BufferedStreamValueLambda.CanRead);
}


public static IObservable<System.Boolean> get_CanWrite(this IObservable<System.IO.BufferedStream> BufferedStreamValue)
{
    return Observable.Select(BufferedStreamValue, (BufferedStreamValueLambda) => BufferedStreamValueLambda.CanWrite);
}


public static IObservable<System.Boolean> get_CanSeek(this IObservable<System.IO.BufferedStream> BufferedStreamValue)
{
    return Observable.Select(BufferedStreamValue, (BufferedStreamValueLambda) => BufferedStreamValueLambda.CanSeek);
}


public static IObservable<System.Int64> get_Length(this IObservable<System.IO.BufferedStream> BufferedStreamValue)
{
    return Observable.Select(BufferedStreamValue, (BufferedStreamValueLambda) => BufferedStreamValueLambda.Length);
}


public static IObservable<System.Int64> get_Position(this IObservable<System.IO.BufferedStream> BufferedStreamValue)
{
    return Observable.Select(BufferedStreamValue, (BufferedStreamValueLambda) => BufferedStreamValueLambda.Position);
}


public static IObservable<System.Reactive.Unit> set_Position(this IObservable<System.IO.BufferedStream> BufferedStreamValue, IObservable<System.Int64> value)
{
    return ObservableExt.ZipExecute(BufferedStreamValue, value, (BufferedStreamValueLambda, valueLambda) => BufferedStreamValueLambda.Position = valueLambda);
}

}
}