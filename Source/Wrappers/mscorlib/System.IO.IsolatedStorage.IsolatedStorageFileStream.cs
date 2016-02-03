using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO.IsolatedStorage
{
public static class _IsolatedStorageFileStream
{
    
public static IObservable<System.Reactive.Unit> Flush(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue)
{
    return Observable.Do(IsolatedStorageFileStreamValue, (IsolatedStorageFileStreamValueLambda) => IsolatedStorageFileStreamValueLambda.Flush()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Flush(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue, IObservable<System.Boolean> flushToDisk)
{
    return ObservableExt.ZipExecute(IsolatedStorageFileStreamValue, flushToDisk, (IsolatedStorageFileStreamValueLambda, flushToDiskLambda) => IsolatedStorageFileStreamValueLambda.Flush(flushToDiskLambda));
}


public static IObservable<System.Reactive.Unit> SetLength(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue, IObservable<System.Int64> value)
{
    return ObservableExt.ZipExecute(IsolatedStorageFileStreamValue, value, (IsolatedStorageFileStreamValueLambda, valueLambda) => IsolatedStorageFileStreamValueLambda.SetLength(valueLambda));
}


public static IObservable<System.Reactive.Unit> Lock(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue, IObservable<System.Int64> position, IObservable<System.Int64> length)
{
    return ObservableExt.ZipExecute(IsolatedStorageFileStreamValue, position, length, (IsolatedStorageFileStreamValueLambda, positionLambda, lengthLambda) => IsolatedStorageFileStreamValueLambda.Lock(positionLambda, lengthLambda));
}


public static IObservable<System.Reactive.Unit> Unlock(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue, IObservable<System.Int64> position, IObservable<System.Int64> length)
{
    return ObservableExt.ZipExecute(IsolatedStorageFileStreamValue, position, length, (IsolatedStorageFileStreamValueLambda, positionLambda, lengthLambda) => IsolatedStorageFileStreamValueLambda.Unlock(positionLambda, lengthLambda));
}


public static IObservable<System.Int32> Read(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count)
{
    return Observable.Zip(IsolatedStorageFileStreamValue, buffer, offset, count, (IsolatedStorageFileStreamValueLambda, bufferLambda, offsetLambda, countLambda) => IsolatedStorageFileStreamValueLambda.Read(bufferLambda, offsetLambda, countLambda));
}


public static IObservable<System.Int32> ReadByte(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue)
{
    return Observable.Select(IsolatedStorageFileStreamValue, (IsolatedStorageFileStreamValueLambda) => IsolatedStorageFileStreamValueLambda.ReadByte());
}


public static IObservable<System.Int64> Seek(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue, IObservable<System.Int64> offset, IObservable<System.IO.SeekOrigin> origin)
{
    return Observable.Zip(IsolatedStorageFileStreamValue, offset, origin, (IsolatedStorageFileStreamValueLambda, offsetLambda, originLambda) => IsolatedStorageFileStreamValueLambda.Seek(offsetLambda, originLambda));
}


public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count)
{
    return ObservableExt.ZipExecute(IsolatedStorageFileStreamValue, buffer, offset, count, (IsolatedStorageFileStreamValueLambda, bufferLambda, offsetLambda, countLambda) => IsolatedStorageFileStreamValueLambda.Write(bufferLambda, offsetLambda, countLambda));
}


public static IObservable<System.Reactive.Unit> WriteByte(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue, IObservable<System.Byte> value)
{
    return ObservableExt.ZipExecute(IsolatedStorageFileStreamValue, value, (IsolatedStorageFileStreamValueLambda, valueLambda) => IsolatedStorageFileStreamValueLambda.WriteByte(valueLambda));
}


public static IObservable<System.IAsyncResult> BeginRead(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> numBytes, IObservable<System.AsyncCallback> userCallback, IObservable<System.Object> stateObject)
{
    return Observable.Zip(IsolatedStorageFileStreamValue, buffer, offset, numBytes, userCallback, stateObject, (IsolatedStorageFileStreamValueLambda, bufferLambda, offsetLambda, numBytesLambda, userCallbackLambda, stateObjectLambda) => IsolatedStorageFileStreamValueLambda.BeginRead(bufferLambda, offsetLambda, numBytesLambda, userCallbackLambda, stateObjectLambda));
}


public static IObservable<System.Int32> EndRead(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue, IObservable<System.IAsyncResult> asyncResult)
{
    return Observable.Zip(IsolatedStorageFileStreamValue, asyncResult, (IsolatedStorageFileStreamValueLambda, asyncResultLambda) => IsolatedStorageFileStreamValueLambda.EndRead(asyncResultLambda));
}


public static IObservable<System.IAsyncResult> BeginWrite(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> numBytes, IObservable<System.AsyncCallback> userCallback, IObservable<System.Object> stateObject)
{
    return Observable.Zip(IsolatedStorageFileStreamValue, buffer, offset, numBytes, userCallback, stateObject, (IsolatedStorageFileStreamValueLambda, bufferLambda, offsetLambda, numBytesLambda, userCallbackLambda, stateObjectLambda) => IsolatedStorageFileStreamValueLambda.BeginWrite(bufferLambda, offsetLambda, numBytesLambda, userCallbackLambda, stateObjectLambda));
}


public static IObservable<System.Reactive.Unit> EndWrite(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue, IObservable<System.IAsyncResult> asyncResult)
{
    return ObservableExt.ZipExecute(IsolatedStorageFileStreamValue, asyncResult, (IsolatedStorageFileStreamValueLambda, asyncResultLambda) => IsolatedStorageFileStreamValueLambda.EndWrite(asyncResultLambda));
}


public static IObservable<System.Boolean> get_CanRead(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue)
{
    return Observable.Select(IsolatedStorageFileStreamValue, (IsolatedStorageFileStreamValueLambda) => IsolatedStorageFileStreamValueLambda.CanRead);
}


public static IObservable<System.Boolean> get_CanWrite(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue)
{
    return Observable.Select(IsolatedStorageFileStreamValue, (IsolatedStorageFileStreamValueLambda) => IsolatedStorageFileStreamValueLambda.CanWrite);
}


public static IObservable<System.Boolean> get_CanSeek(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue)
{
    return Observable.Select(IsolatedStorageFileStreamValue, (IsolatedStorageFileStreamValueLambda) => IsolatedStorageFileStreamValueLambda.CanSeek);
}


public static IObservable<System.Boolean> get_IsAsync(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue)
{
    return Observable.Select(IsolatedStorageFileStreamValue, (IsolatedStorageFileStreamValueLambda) => IsolatedStorageFileStreamValueLambda.IsAsync);
}


public static IObservable<System.Int64> get_Length(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue)
{
    return Observable.Select(IsolatedStorageFileStreamValue, (IsolatedStorageFileStreamValueLambda) => IsolatedStorageFileStreamValueLambda.Length);
}


public static IObservable<System.Int64> get_Position(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue)
{
    return Observable.Select(IsolatedStorageFileStreamValue, (IsolatedStorageFileStreamValueLambda) => IsolatedStorageFileStreamValueLambda.Position);
}


public static IObservable<System.IntPtr> get_Handle(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue)
{
    return Observable.Select(IsolatedStorageFileStreamValue, (IsolatedStorageFileStreamValueLambda) => IsolatedStorageFileStreamValueLambda.Handle);
}


public static IObservable<Microsoft.Win32.SafeHandles.SafeFileHandle> get_SafeFileHandle(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue)
{
    return Observable.Select(IsolatedStorageFileStreamValue, (IsolatedStorageFileStreamValueLambda) => IsolatedStorageFileStreamValueLambda.SafeFileHandle);
}


public static IObservable<System.Reactive.Unit> set_Position(this IObservable<System.IO.IsolatedStorage.IsolatedStorageFileStream> IsolatedStorageFileStreamValue, IObservable<System.Int64> value)
{
    return ObservableExt.ZipExecute(IsolatedStorageFileStreamValue, value, (IsolatedStorageFileStreamValueLambda, valueLambda) => IsolatedStorageFileStreamValueLambda.Position = valueLambda);
}

}
}