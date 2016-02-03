using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _CryptoStream
{
    
public static IObservable<System.Reactive.Unit> FlushFinalBlock(this IObservable<System.Security.Cryptography.CryptoStream> CryptoStreamValue)
{
    return Observable.Do(CryptoStreamValue, (CryptoStreamValueLambda) => CryptoStreamValueLambda.FlushFinalBlock()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Flush(this IObservable<System.Security.Cryptography.CryptoStream> CryptoStreamValue)
{
    return Observable.Do(CryptoStreamValue, (CryptoStreamValueLambda) => CryptoStreamValueLambda.Flush()).ToUnit();
}


public static IObservable<System.Reactive.Unit> FlushAsync(this IObservable<System.Security.Cryptography.CryptoStream> CryptoStreamValue, IObservable<System.Threading.CancellationToken> cancellationToken)
{
    return Observable.Zip(CryptoStreamValue, cancellationToken, (CryptoStreamValueLambda, cancellationTokenLambda) => CryptoStreamValueLambda.FlushAsync(cancellationTokenLambda).ToObservable()).Flatten();
}


public static IObservable<System.Int64> Seek(this IObservable<System.Security.Cryptography.CryptoStream> CryptoStreamValue, IObservable<System.Int64> offset, IObservable<System.IO.SeekOrigin> origin)
{
    return Observable.Zip(CryptoStreamValue, offset, origin, (CryptoStreamValueLambda, offsetLambda, originLambda) => CryptoStreamValueLambda.Seek(offsetLambda, originLambda));
}


public static IObservable<System.Reactive.Unit> SetLength(this IObservable<System.Security.Cryptography.CryptoStream> CryptoStreamValue, IObservable<System.Int64> value)
{
    return ObservableExt.ZipExecute(CryptoStreamValue, value, (CryptoStreamValueLambda, valueLambda) => CryptoStreamValueLambda.SetLength(valueLambda));
}


public static IObservable<Tuple<System.Int32, System.Byte>> Read(this IObservable<System.Security.Cryptography.CryptoStream> CryptoStreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count)
{
    return Observable.Zip(CryptoStreamValue, buffer, offset, count, (CryptoStreamValueLambda, bufferLambda, offsetLambda, countLambda) => CryptoStreamValueLambda.Read(bufferLambda, offsetLambda, countLambda));
}


public static IObservable<System.Int32> ReadAsync(this IObservable<System.Security.Cryptography.CryptoStream> CryptoStreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count, IObservable<System.Threading.CancellationToken> cancellationToken)
{
    return Observable.Zip(CryptoStreamValue, buffer, offset, count, cancellationToken, (CryptoStreamValueLambda, bufferLambda, offsetLambda, countLambda, cancellationTokenLambda) => CryptoStreamValueLambda.ReadAsync(bufferLambda, offsetLambda, countLambda, cancellationTokenLambda).ToObservable()).Flatten();
}


public static IObservable<System.Reactive.Unit> Write(this IObservable<System.Security.Cryptography.CryptoStream> CryptoStreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count)
{
    return ObservableExt.ZipExecute(CryptoStreamValue, buffer, offset, count, (CryptoStreamValueLambda, bufferLambda, offsetLambda, countLambda) => CryptoStreamValueLambda.Write(bufferLambda, offsetLambda, countLambda));
}


public static IObservable<System.Reactive.Unit> WriteAsync(this IObservable<System.Security.Cryptography.CryptoStream> CryptoStreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count, IObservable<System.Threading.CancellationToken> cancellationToken)
{
    return Observable.Zip(CryptoStreamValue, buffer, offset, count, cancellationToken, (CryptoStreamValueLambda, bufferLambda, offsetLambda, countLambda, cancellationTokenLambda) => CryptoStreamValueLambda.WriteAsync(bufferLambda, offsetLambda, countLambda, cancellationTokenLambda).ToObservable()).Flatten();
}


public static IObservable<System.Reactive.Unit> Clear(this IObservable<System.Security.Cryptography.CryptoStream> CryptoStreamValue)
{
    return Observable.Do(CryptoStreamValue, (CryptoStreamValueLambda) => CryptoStreamValueLambda.Clear()).ToUnit();
}


public static IObservable<System.Boolean> get_CanRead(this IObservable<System.Security.Cryptography.CryptoStream> CryptoStreamValue)
{
    return Observable.Select(CryptoStreamValue, (CryptoStreamValueLambda) => CryptoStreamValueLambda.CanRead);
}


public static IObservable<System.Boolean> get_CanSeek(this IObservable<System.Security.Cryptography.CryptoStream> CryptoStreamValue)
{
    return Observable.Select(CryptoStreamValue, (CryptoStreamValueLambda) => CryptoStreamValueLambda.CanSeek);
}


public static IObservable<System.Boolean> get_CanWrite(this IObservable<System.Security.Cryptography.CryptoStream> CryptoStreamValue)
{
    return Observable.Select(CryptoStreamValue, (CryptoStreamValueLambda) => CryptoStreamValueLambda.CanWrite);
}


public static IObservable<System.Int64> get_Length(this IObservable<System.Security.Cryptography.CryptoStream> CryptoStreamValue)
{
    return Observable.Select(CryptoStreamValue, (CryptoStreamValueLambda) => CryptoStreamValueLambda.Length);
}


public static IObservable<System.Int64> get_Position(this IObservable<System.Security.Cryptography.CryptoStream> CryptoStreamValue)
{
    return Observable.Select(CryptoStreamValue, (CryptoStreamValueLambda) => CryptoStreamValueLambda.Position);
}


public static IObservable<System.Boolean> get_HasFlushedFinalBlock(this IObservable<System.Security.Cryptography.CryptoStream> CryptoStreamValue)
{
    return Observable.Select(CryptoStreamValue, (CryptoStreamValueLambda) => CryptoStreamValueLambda.HasFlushedFinalBlock);
}


public static IObservable<System.Reactive.Unit> set_Position(this IObservable<System.Security.Cryptography.CryptoStream> CryptoStreamValue, IObservable<System.Int64> value)
{
    return ObservableExt.ZipExecute(CryptoStreamValue, value, (CryptoStreamValueLambda, valueLambda) => CryptoStreamValueLambda.Position = valueLambda);
}

}
}