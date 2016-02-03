using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _SafeBuffer
{
    
public static IObservable<System.Byte*> AcquirePointer(this IObservable<System.Runtime.InteropServices.SafeBuffer> SafeBufferValue, IObservable<System.Byte*> pointer)
{
    return Observable.Zip(SafeBufferValue, pointer, (SafeBufferValueLambda, pointerLambda) => {
SafeBufferValueLambda.AcquirePointer(ref pointerLambda);
return pointerLambda;
});
}


public static IObservable<System.Reactive.Unit> Initialize(this IObservable<System.Runtime.InteropServices.SafeBuffer> SafeBufferValue, IObservable<System.UInt64> numBytes)
{
    return ObservableExt.ZipExecute(SafeBufferValue, numBytes, (SafeBufferValueLambda, numBytesLambda) => SafeBufferValueLambda.Initialize(numBytesLambda));
}


public static IObservable<System.Reactive.Unit> Initialize(this IObservable<System.Runtime.InteropServices.SafeBuffer> SafeBufferValue, IObservable<System.UInt32> numElements, IObservable<System.UInt32> sizeOfEachElement)
{
    return ObservableExt.ZipExecute(SafeBufferValue, numElements, sizeOfEachElement, (SafeBufferValueLambda, numElementsLambda, sizeOfEachElementLambda) => SafeBufferValueLambda.Initialize(numElementsLambda, sizeOfEachElementLambda));
}


public static IObservable<System.Reactive.Unit> Initialize<T>(this IObservable<System.Runtime.InteropServices.SafeBuffer> SafeBufferValue, IObservable<System.UInt32> numElements)
{
    return ObservableExt.ZipExecute(SafeBufferValue, numElements, (SafeBufferValueLambda, numElementsLambda) => SafeBufferValueLambda.Initialize(numElementsLambda));
}


public static IObservable<System.Reactive.Unit> ReleasePointer(this IObservable<System.Runtime.InteropServices.SafeBuffer> SafeBufferValue)
{
    return Observable.Do(SafeBufferValue, (SafeBufferValueLambda) => SafeBufferValueLambda.ReleasePointer()).ToUnit();
}


public static IObservable<T> Read<T>(this IObservable<System.Runtime.InteropServices.SafeBuffer> SafeBufferValue, IObservable<System.UInt64> byteOffset)
{
    return Observable.Zip(SafeBufferValue, byteOffset, (SafeBufferValueLambda, byteOffsetLambda) => SafeBufferValueLambda.Read(byteOffsetLambda));
}


public static IObservable<System.Reactive.Unit> ReadArray<T>(this IObservable<System.Runtime.InteropServices.SafeBuffer> SafeBufferValue, IObservable<System.UInt64> byteOffset, IObservable<T[]> array, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return ObservableExt.ZipExecute(SafeBufferValue, byteOffset, array, index, count, (SafeBufferValueLambda, byteOffsetLambda, arrayLambda, indexLambda, countLambda) => SafeBufferValueLambda.ReadArray(byteOffsetLambda, arrayLambda, indexLambda, countLambda));
}


public static IObservable<System.Reactive.Unit> Write<T>(this IObservable<System.Runtime.InteropServices.SafeBuffer> SafeBufferValue, IObservable<System.UInt64> byteOffset, IObservable<T> value)
{
    return ObservableExt.ZipExecute(SafeBufferValue, byteOffset, value, (SafeBufferValueLambda, byteOffsetLambda, valueLambda) => SafeBufferValueLambda.Write(byteOffsetLambda, valueLambda));
}


public static IObservable<System.Reactive.Unit> WriteArray<T>(this IObservable<System.Runtime.InteropServices.SafeBuffer> SafeBufferValue, IObservable<System.UInt64> byteOffset, IObservable<T[]> array, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return ObservableExt.ZipExecute(SafeBufferValue, byteOffset, array, index, count, (SafeBufferValueLambda, byteOffsetLambda, arrayLambda, indexLambda, countLambda) => SafeBufferValueLambda.WriteArray(byteOffsetLambda, arrayLambda, indexLambda, countLambda));
}


public static IObservable<System.UInt64> get_ByteLength(this IObservable<System.Runtime.InteropServices.SafeBuffer> SafeBufferValue)
{
    return Observable.Select(SafeBufferValue, (SafeBufferValueLambda) => SafeBufferValueLambda.ByteLength);
}

}
}