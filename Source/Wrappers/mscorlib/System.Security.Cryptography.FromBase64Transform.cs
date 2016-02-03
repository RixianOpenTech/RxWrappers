using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _FromBase64Transform
{
    
public static IObservable<System.Int32> TransformBlock(this IObservable<System.Security.Cryptography.FromBase64Transform> FromBase64TransformValue, IObservable<System.Byte[]> inputBuffer, IObservable<System.Int32> inputOffset, IObservable<System.Int32> inputCount, IObservable<System.Byte[]> outputBuffer, IObservable<System.Int32> outputOffset)
{
    return Observable.Zip(FromBase64TransformValue, inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset, (FromBase64TransformValueLambda, inputBufferLambda, inputOffsetLambda, inputCountLambda, outputBufferLambda, outputOffsetLambda) => FromBase64TransformValueLambda.TransformBlock(inputBufferLambda, inputOffsetLambda, inputCountLambda, outputBufferLambda, outputOffsetLambda));
}


public static IObservable<System.Byte[]> TransformFinalBlock(this IObservable<System.Security.Cryptography.FromBase64Transform> FromBase64TransformValue, IObservable<System.Byte[]> inputBuffer, IObservable<System.Int32> inputOffset, IObservable<System.Int32> inputCount)
{
    return Observable.Zip(FromBase64TransformValue, inputBuffer, inputOffset, inputCount, (FromBase64TransformValueLambda, inputBufferLambda, inputOffsetLambda, inputCountLambda) => FromBase64TransformValueLambda.TransformFinalBlock(inputBufferLambda, inputOffsetLambda, inputCountLambda));
}


public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Security.Cryptography.FromBase64Transform> FromBase64TransformValue)
{
    return Observable.Do(FromBase64TransformValue, (FromBase64TransformValueLambda) => FromBase64TransformValueLambda.Dispose()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Clear(this IObservable<System.Security.Cryptography.FromBase64Transform> FromBase64TransformValue)
{
    return Observable.Do(FromBase64TransformValue, (FromBase64TransformValueLambda) => FromBase64TransformValueLambda.Clear()).ToUnit();
}


public static IObservable<System.Int32> get_InputBlockSize(this IObservable<System.Security.Cryptography.FromBase64Transform> FromBase64TransformValue)
{
    return Observable.Select(FromBase64TransformValue, (FromBase64TransformValueLambda) => FromBase64TransformValueLambda.InputBlockSize);
}


public static IObservable<System.Int32> get_OutputBlockSize(this IObservable<System.Security.Cryptography.FromBase64Transform> FromBase64TransformValue)
{
    return Observable.Select(FromBase64TransformValue, (FromBase64TransformValueLambda) => FromBase64TransformValueLambda.OutputBlockSize);
}


public static IObservable<System.Boolean> get_CanTransformMultipleBlocks(this IObservable<System.Security.Cryptography.FromBase64Transform> FromBase64TransformValue)
{
    return Observable.Select(FromBase64TransformValue, (FromBase64TransformValueLambda) => FromBase64TransformValueLambda.CanTransformMultipleBlocks);
}


public static IObservable<System.Boolean> get_CanReuseTransform(this IObservable<System.Security.Cryptography.FromBase64Transform> FromBase64TransformValue)
{
    return Observable.Select(FromBase64TransformValue, (FromBase64TransformValueLambda) => FromBase64TransformValueLambda.CanReuseTransform);
}

}
}