using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
public static class _Overlapped
{
    
public static IObservable<System.Threading.NativeOverlapped*> Pack(this IObservable<System.Threading.Overlapped> OverlappedValue, IObservable<System.Threading.IOCompletionCallback> iocb)
{
    return Observable.Zip(OverlappedValue, iocb, (OverlappedValueLambda, iocbLambda) => OverlappedValueLambda.Pack(iocbLambda));
}


public static IObservable<System.Threading.NativeOverlapped*> Pack(this IObservable<System.Threading.Overlapped> OverlappedValue, IObservable<System.Threading.IOCompletionCallback> iocb, IObservable<System.Object> userData)
{
    return Observable.Zip(OverlappedValue, iocb, userData, (OverlappedValueLambda, iocbLambda, userDataLambda) => OverlappedValueLambda.Pack(iocbLambda, userDataLambda));
}


public static IObservable<System.Threading.NativeOverlapped*> UnsafePack(this IObservable<System.Threading.Overlapped> OverlappedValue, IObservable<System.Threading.IOCompletionCallback> iocb)
{
    return Observable.Zip(OverlappedValue, iocb, (OverlappedValueLambda, iocbLambda) => OverlappedValueLambda.UnsafePack(iocbLambda));
}


public static IObservable<System.Threading.NativeOverlapped*> UnsafePack(this IObservable<System.Threading.Overlapped> OverlappedValue, IObservable<System.Threading.IOCompletionCallback> iocb, IObservable<System.Object> userData)
{
    return Observable.Zip(OverlappedValue, iocb, userData, (OverlappedValueLambda, iocbLambda, userDataLambda) => OverlappedValueLambda.UnsafePack(iocbLambda, userDataLambda));
}


public static IObservable<System.Threading.Overlapped> Unpack(IObservable<System.Threading.NativeOverlapped*> nativeOverlappedPtr)
{
    return Observable.Select(nativeOverlappedPtr, (nativeOverlappedPtrLambda) => System.Threading.Overlapped.Unpack(nativeOverlappedPtrLambda));
}


public static IObservable<System.Reactive.Unit> Free(IObservable<System.Threading.NativeOverlapped*> nativeOverlappedPtr)
{
    return Observable.Do(nativeOverlappedPtr, (nativeOverlappedPtrLambda) => System.Threading.Overlapped.Free(nativeOverlappedPtrLambda)).ToUnit();
}


public static IObservable<System.IAsyncResult> get_AsyncResult(this IObservable<System.Threading.Overlapped> OverlappedValue)
{
    return Observable.Select(OverlappedValue, (OverlappedValueLambda) => OverlappedValueLambda.AsyncResult);
}


public static IObservable<System.Int32> get_OffsetLow(this IObservable<System.Threading.Overlapped> OverlappedValue)
{
    return Observable.Select(OverlappedValue, (OverlappedValueLambda) => OverlappedValueLambda.OffsetLow);
}


public static IObservable<System.Int32> get_OffsetHigh(this IObservable<System.Threading.Overlapped> OverlappedValue)
{
    return Observable.Select(OverlappedValue, (OverlappedValueLambda) => OverlappedValueLambda.OffsetHigh);
}


public static IObservable<System.Int32> get_EventHandle(this IObservable<System.Threading.Overlapped> OverlappedValue)
{
    return Observable.Select(OverlappedValue, (OverlappedValueLambda) => OverlappedValueLambda.EventHandle);
}


public static IObservable<System.IntPtr> get_EventHandleIntPtr(this IObservable<System.Threading.Overlapped> OverlappedValue)
{
    return Observable.Select(OverlappedValue, (OverlappedValueLambda) => OverlappedValueLambda.EventHandleIntPtr);
}


public static IObservable<System.Reactive.Unit> set_AsyncResult(this IObservable<System.Threading.Overlapped> OverlappedValue, IObservable<System.IAsyncResult> value)
{
    return ObservableExt.ZipExecute(OverlappedValue, value, (OverlappedValueLambda, valueLambda) => OverlappedValueLambda.AsyncResult = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_OffsetLow(this IObservable<System.Threading.Overlapped> OverlappedValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(OverlappedValue, value, (OverlappedValueLambda, valueLambda) => OverlappedValueLambda.OffsetLow = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_OffsetHigh(this IObservable<System.Threading.Overlapped> OverlappedValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(OverlappedValue, value, (OverlappedValueLambda, valueLambda) => OverlappedValueLambda.OffsetHigh = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_EventHandle(this IObservable<System.Threading.Overlapped> OverlappedValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(OverlappedValue, value, (OverlappedValueLambda, valueLambda) => OverlappedValueLambda.EventHandle = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_EventHandleIntPtr(this IObservable<System.Threading.Overlapped> OverlappedValue, IObservable<System.IntPtr> value)
{
    return ObservableExt.ZipExecute(OverlappedValue, value, (OverlappedValueLambda, valueLambda) => OverlappedValueLambda.EventHandleIntPtr = valueLambda);
}

}
}