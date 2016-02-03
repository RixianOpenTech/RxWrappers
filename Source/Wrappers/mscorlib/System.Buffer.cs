using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _Buffer
{
    
public static IObservable<System.Reactive.Unit> BlockCopy(IObservable<System.Array> src, IObservable<System.Int32> srcOffset, IObservable<System.Array> dst, IObservable<System.Int32> dstOffset, IObservable<System.Int32> count)
{
    return ObservableExt.ZipExecute(src, srcOffset, dst, dstOffset, count, (srcLambda, srcOffsetLambda, dstLambda, dstOffsetLambda, countLambda) => System.Buffer.BlockCopy(srcLambda, srcOffsetLambda, dstLambda, dstOffsetLambda, countLambda));
}


public static IObservable<System.Byte> GetByte(IObservable<System.Array> array, IObservable<System.Int32> index)
{
    return Observable.Zip(array, index, (arrayLambda, indexLambda) => System.Buffer.GetByte(arrayLambda, indexLambda));
}


public static IObservable<System.Reactive.Unit> SetByte(IObservable<System.Array> array, IObservable<System.Int32> index, IObservable<System.Byte> value)
{
    return ObservableExt.ZipExecute(array, index, value, (arrayLambda, indexLambda, valueLambda) => System.Buffer.SetByte(arrayLambda, indexLambda, valueLambda));
}


public static IObservable<System.Int32> ByteLength(IObservable<System.Array> array)
{
    return Observable.Select(array, (arrayLambda) => System.Buffer.ByteLength(arrayLambda));
}


public static IObservable<System.Reactive.Unit> MemoryCopy(IObservable<System.Void*> source, IObservable<System.Void*> destination, IObservable<System.Int64> destinationSizeInBytes, IObservable<System.Int64> sourceBytesToCopy)
{
    return ObservableExt.ZipExecute(source, destination, destinationSizeInBytes, sourceBytesToCopy, (sourceLambda, destinationLambda, destinationSizeInBytesLambda, sourceBytesToCopyLambda) => System.Buffer.MemoryCopy(sourceLambda, destinationLambda, destinationSizeInBytesLambda, sourceBytesToCopyLambda));
}


public static IObservable<System.Reactive.Unit> MemoryCopy(IObservable<System.Void*> source, IObservable<System.Void*> destination, IObservable<System.UInt64> destinationSizeInBytes, IObservable<System.UInt64> sourceBytesToCopy)
{
    return ObservableExt.ZipExecute(source, destination, destinationSizeInBytes, sourceBytesToCopy, (sourceLambda, destinationLambda, destinationSizeInBytesLambda, sourceBytesToCopyLambda) => System.Buffer.MemoryCopy(sourceLambda, destinationLambda, destinationSizeInBytesLambda, sourceBytesToCopyLambda));
}

}
}