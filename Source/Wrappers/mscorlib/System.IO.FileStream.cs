using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
    public static class __FileStream
    {
        public static IObservable<System.Security.AccessControl.FileSecurity> GetAccessControl(
            this IObservable<System.IO.FileStream> FileStreamValue)
        {
            return Observable.Select(FileStreamValue,
                (FileStreamValueLambda) => FileStreamValueLambda.GetAccessControl());
        }


        public static IObservable<System.Reactive.Unit> SetAccessControl(
            this IObservable<System.IO.FileStream> FileStreamValue,
            IObservable<System.Security.AccessControl.FileSecurity> fileSecurity)
        {
            return ObservableExt.ZipExecute(FileStreamValue, fileSecurity,
                (FileStreamValueLambda, fileSecurityLambda) =>
                    FileStreamValueLambda.SetAccessControl(fileSecurityLambda));
        }


        public static IObservable<System.Reactive.Unit> Flush(this IObservable<System.IO.FileStream> FileStreamValue)
        {
            return Observable.Do(FileStreamValue, (FileStreamValueLambda) => FileStreamValueLambda.Flush()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Flush(this IObservable<System.IO.FileStream> FileStreamValue,
            IObservable<System.Boolean> flushToDisk)
        {
            return ObservableExt.ZipExecute(FileStreamValue, flushToDisk,
                (FileStreamValueLambda, flushToDiskLambda) => FileStreamValueLambda.Flush(flushToDiskLambda));
        }


        public static IObservable<System.Reactive.Unit> SetLength(
            this IObservable<System.IO.FileStream> FileStreamValue, IObservable<System.Int64> value)
        {
            return ObservableExt.ZipExecute(FileStreamValue, value,
                (FileStreamValueLambda, valueLambda) => FileStreamValueLambda.SetLength(valueLambda));
        }


        public static IObservable<int> Read(this IObservable<System.IO.FileStream> FileStreamValue,
            IObservable<System.Byte[]> array, IObservable<System.Int32> offset, IObservable<System.Int32> count)
        {
            return Observable.Zip(FileStreamValue, array, offset, count,
                (FileStreamValueLambda, arrayLambda, offsetLambda, countLambda) =>
                    FileStreamValueLambda.Read(arrayLambda, offsetLambda, countLambda));
        }


        public static IObservable<System.Int64> Seek(this IObservable<System.IO.FileStream> FileStreamValue,
            IObservable<System.Int64> offset, IObservable<System.IO.SeekOrigin> origin)
        {
            return Observable.Zip(FileStreamValue, offset, origin,
                (FileStreamValueLambda, offsetLambda, originLambda) =>
                    FileStreamValueLambda.Seek(offsetLambda, originLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.FileStream> FileStreamValue,
            IObservable<System.Byte[]> array, IObservable<System.Int32> offset, IObservable<System.Int32> count)
        {
            return ObservableExt.ZipExecute(FileStreamValue, array, offset, count,
                (FileStreamValueLambda, arrayLambda, offsetLambda, countLambda) =>
                    FileStreamValueLambda.Write(arrayLambda, offsetLambda, countLambda));
        }


        public static IObservable<System.IAsyncResult> BeginRead(this IObservable<System.IO.FileStream> FileStreamValue,
            IObservable<System.Byte[]> array, IObservable<System.Int32> offset, IObservable<System.Int32> numBytes,
            IObservable<System.AsyncCallback> userCallback, IObservable<System.Object> stateObject)
        {
            return Observable.Zip(FileStreamValue, array, offset, numBytes, userCallback, stateObject,
                (FileStreamValueLambda, arrayLambda, offsetLambda, numBytesLambda, userCallbackLambda, stateObjectLambda)
                    =>
                    FileStreamValueLambda.BeginRead(arrayLambda, offsetLambda, numBytesLambda, userCallbackLambda,
                        stateObjectLambda));
        }


        public static IObservable<System.Int32> EndRead(this IObservable<System.IO.FileStream> FileStreamValue,
            IObservable<System.IAsyncResult> asyncResult)
        {
            return Observable.Zip(FileStreamValue, asyncResult,
                (FileStreamValueLambda, asyncResultLambda) => FileStreamValueLambda.EndRead(asyncResultLambda));
        }


        public static IObservable<System.Int32> ReadByte(this IObservable<System.IO.FileStream> FileStreamValue)
        {
            return Observable.Select(FileStreamValue, (FileStreamValueLambda) => FileStreamValueLambda.ReadByte());
        }


        public static IObservable<System.IAsyncResult> BeginWrite(
            this IObservable<System.IO.FileStream> FileStreamValue, IObservable<System.Byte[]> array,
            IObservable<System.Int32> offset, IObservable<System.Int32> numBytes,
            IObservable<System.AsyncCallback> userCallback, IObservable<System.Object> stateObject)
        {
            return Observable.Zip(FileStreamValue, array, offset, numBytes, userCallback, stateObject,
                (FileStreamValueLambda, arrayLambda, offsetLambda, numBytesLambda, userCallbackLambda, stateObjectLambda)
                    =>
                    FileStreamValueLambda.BeginWrite(arrayLambda, offsetLambda, numBytesLambda, userCallbackLambda,
                        stateObjectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndWrite(this IObservable<System.IO.FileStream> FileStreamValue,
            IObservable<System.IAsyncResult> asyncResult)
        {
            return ObservableExt.ZipExecute(FileStreamValue, asyncResult,
                (FileStreamValueLambda, asyncResultLambda) => FileStreamValueLambda.EndWrite(asyncResultLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteByte(
            this IObservable<System.IO.FileStream> FileStreamValue, IObservable<System.Byte> value)
        {
            return ObservableExt.ZipExecute(FileStreamValue, value,
                (FileStreamValueLambda, valueLambda) => FileStreamValueLambda.WriteByte(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Lock(this IObservable<System.IO.FileStream> FileStreamValue,
            IObservable<System.Int64> position, IObservable<System.Int64> length)
        {
            return ObservableExt.ZipExecute(FileStreamValue, position, length,
                (FileStreamValueLambda, positionLambda, lengthLambda) =>
                    FileStreamValueLambda.Lock(positionLambda, lengthLambda));
        }


        public static IObservable<System.Reactive.Unit> Unlock(this IObservable<System.IO.FileStream> FileStreamValue,
            IObservable<System.Int64> position, IObservable<System.Int64> length)
        {
            return ObservableExt.ZipExecute(FileStreamValue, position, length,
                (FileStreamValueLambda, positionLambda, lengthLambda) =>
                    FileStreamValueLambda.Unlock(positionLambda, lengthLambda));
        }


        public static IObservable<System.Int32> ReadAsync(this IObservable<System.IO.FileStream> FileStreamValue,
            IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(FileStreamValue, buffer, offset, count, cancellationToken,
                    (FileStreamValueLambda, bufferLambda, offsetLambda, countLambda, cancellationTokenLambda) =>
                        FileStreamValueLambda.ReadAsync(bufferLambda, offsetLambda, countLambda, cancellationTokenLambda)
                            .ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> WriteAsync(
            this IObservable<System.IO.FileStream> FileStreamValue, IObservable<System.Byte[]> buffer,
            IObservable<System.Int32> offset, IObservable<System.Int32> count,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(FileStreamValue, buffer, offset, count, cancellationToken,
                    (FileStreamValueLambda, bufferLambda, offsetLambda, countLambda, cancellationTokenLambda) =>
                        FileStreamValueLambda.WriteAsync(bufferLambda, offsetLambda, countLambda,
                            cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> FlushAsync(
            this IObservable<System.IO.FileStream> FileStreamValue,
            IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return
                Observable.Zip(FileStreamValue, cancellationToken,
                    (FileStreamValueLambda, cancellationTokenLambda) =>
                        FileStreamValueLambda.FlushAsync(cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Boolean> get_CanRead(this IObservable<System.IO.FileStream> FileStreamValue)
        {
            return Observable.Select(FileStreamValue, (FileStreamValueLambda) => FileStreamValueLambda.CanRead);
        }


        public static IObservable<System.Boolean> get_CanWrite(this IObservable<System.IO.FileStream> FileStreamValue)
        {
            return Observable.Select(FileStreamValue, (FileStreamValueLambda) => FileStreamValueLambda.CanWrite);
        }


        public static IObservable<System.Boolean> get_CanSeek(this IObservable<System.IO.FileStream> FileStreamValue)
        {
            return Observable.Select(FileStreamValue, (FileStreamValueLambda) => FileStreamValueLambda.CanSeek);
        }


        public static IObservable<System.Boolean> get_IsAsync(this IObservable<System.IO.FileStream> FileStreamValue)
        {
            return Observable.Select(FileStreamValue, (FileStreamValueLambda) => FileStreamValueLambda.IsAsync);
        }


        public static IObservable<System.Int64> get_Length(this IObservable<System.IO.FileStream> FileStreamValue)
        {
            return Observable.Select(FileStreamValue, (FileStreamValueLambda) => FileStreamValueLambda.Length);
        }


        public static IObservable<System.String> get_Name(this IObservable<System.IO.FileStream> FileStreamValue)
        {
            return Observable.Select(FileStreamValue, (FileStreamValueLambda) => FileStreamValueLambda.Name);
        }


        public static IObservable<System.Int64> get_Position(this IObservable<System.IO.FileStream> FileStreamValue)
        {
            return Observable.Select(FileStreamValue, (FileStreamValueLambda) => FileStreamValueLambda.Position);
        }


        public static IObservable<System.IntPtr> get_Handle(this IObservable<System.IO.FileStream> FileStreamValue)
        {
            return Observable.Select(FileStreamValue, (FileStreamValueLambda) => FileStreamValueLambda.Handle);
        }


        public static IObservable<Microsoft.Win32.SafeHandles.SafeFileHandle> get_SafeFileHandle(
            this IObservable<System.IO.FileStream> FileStreamValue)
        {
            return Observable.Select(FileStreamValue, (FileStreamValueLambda) => FileStreamValueLambda.SafeFileHandle);
        }


        public static IObservable<System.Reactive.Unit> set_Position(
            this IObservable<System.IO.FileStream> FileStreamValue, IObservable<System.Int64> value)
        {
            return ObservableExt.ZipExecute(FileStreamValue, value,
                (FileStreamValueLambda, valueLambda) => FileStreamValueLambda.Position = valueLambda);
        }
    }
}