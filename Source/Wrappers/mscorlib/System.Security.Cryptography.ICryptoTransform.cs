using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _ICryptoTransform
{
    
public static IObservable<System.Int32> TransformBlock(this IObservable<System.Security.Cryptography.ICryptoTransform> ICryptoTransformValue, IObservable<System.Byte[]> inputBuffer, IObservable<System.Int32> inputOffset, IObservable<System.Int32> inputCount, IObservable<System.Byte[]> outputBuffer, IObservable<System.Int32> outputOffset)
{
    return Observable.Zip(ICryptoTransformValue, inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset, (ICryptoTransformValueLambda, inputBufferLambda, inputOffsetLambda, inputCountLambda, outputBufferLambda, outputOffsetLambda) => ICryptoTransformValueLambda.TransformBlock(inputBufferLambda, inputOffsetLambda, inputCountLambda, outputBufferLambda, outputOffsetLambda));
}


public static IObservable<System.Byte[]> TransformFinalBlock(this IObservable<System.Security.Cryptography.ICryptoTransform> ICryptoTransformValue, IObservable<System.Byte[]> inputBuffer, IObservable<System.Int32> inputOffset, IObservable<System.Int32> inputCount)
{
    return Observable.Zip(ICryptoTransformValue, inputBuffer, inputOffset, inputCount, (ICryptoTransformValueLambda, inputBufferLambda, inputOffsetLambda, inputCountLambda) => ICryptoTransformValueLambda.TransformFinalBlock(inputBufferLambda, inputOffsetLambda, inputCountLambda));
}


public static IObservable<System.Int32> get_InputBlockSize(this IObservable<System.Security.Cryptography.ICryptoTransform> ICryptoTransformValue)
{
    return Observable.Select(ICryptoTransformValue, (ICryptoTransformValueLambda) => ICryptoTransformValueLambda.InputBlockSize);
}


public static IObservable<System.Int32> get_OutputBlockSize(this IObservable<System.Security.Cryptography.ICryptoTransform> ICryptoTransformValue)
{
    return Observable.Select(ICryptoTransformValue, (ICryptoTransformValueLambda) => ICryptoTransformValueLambda.OutputBlockSize);
}


public static IObservable<System.Boolean> get_CanTransformMultipleBlocks(this IObservable<System.Security.Cryptography.ICryptoTransform> ICryptoTransformValue)
{
    return Observable.Select(ICryptoTransformValue, (ICryptoTransformValueLambda) => ICryptoTransformValueLambda.CanTransformMultipleBlocks);
}


public static IObservable<System.Boolean> get_CanReuseTransform(this IObservable<System.Security.Cryptography.ICryptoTransform> ICryptoTransformValue)
{
    return Observable.Select(ICryptoTransformValue, (ICryptoTransformValueLambda) => ICryptoTransformValueLambda.CanReuseTransform);
}

}
}