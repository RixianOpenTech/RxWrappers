using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __ToBase64Transform
    {
        public static IObservable<System.Int32> TransformBlock(
            this IObservable<System.Security.Cryptography.ToBase64Transform> ToBase64TransformValue,
            IObservable<System.Byte[]> inputBuffer, IObservable<System.Int32> inputOffset,
            IObservable<System.Int32> inputCount, IObservable<System.Byte[]> outputBuffer,
            IObservable<System.Int32> outputOffset)
        {
            return Observable.Zip(ToBase64TransformValue, inputBuffer, inputOffset, inputCount, outputBuffer,
                outputOffset,
                (ToBase64TransformValueLambda, inputBufferLambda, inputOffsetLambda, inputCountLambda,
                    outputBufferLambda, outputOffsetLambda) =>
                    ToBase64TransformValueLambda.TransformBlock(inputBufferLambda, inputOffsetLambda, inputCountLambda,
                        outputBufferLambda, outputOffsetLambda));
        }


        public static IObservable<System.Byte[]> TransformFinalBlock(
            this IObservable<System.Security.Cryptography.ToBase64Transform> ToBase64TransformValue,
            IObservable<System.Byte[]> inputBuffer, IObservable<System.Int32> inputOffset,
            IObservable<System.Int32> inputCount)
        {
            return Observable.Zip(ToBase64TransformValue, inputBuffer, inputOffset, inputCount,
                (ToBase64TransformValueLambda, inputBufferLambda, inputOffsetLambda, inputCountLambda) =>
                    ToBase64TransformValueLambda.TransformFinalBlock(inputBufferLambda, inputOffsetLambda,
                        inputCountLambda));
        }


        public static IObservable<System.Reactive.Unit> Dispose(
            this IObservable<System.Security.Cryptography.ToBase64Transform> ToBase64TransformValue)
        {
            return
                Observable.Do(ToBase64TransformValue,
                    (ToBase64TransformValueLambda) => ToBase64TransformValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Clear(
            this IObservable<System.Security.Cryptography.ToBase64Transform> ToBase64TransformValue)
        {
            return
                Observable.Do(ToBase64TransformValue,
                    (ToBase64TransformValueLambda) => ToBase64TransformValueLambda.Clear()).ToUnit();
        }


        public static IObservable<System.Int32> get_InputBlockSize(
            this IObservable<System.Security.Cryptography.ToBase64Transform> ToBase64TransformValue)
        {
            return Observable.Select(ToBase64TransformValue,
                (ToBase64TransformValueLambda) => ToBase64TransformValueLambda.InputBlockSize);
        }


        public static IObservable<System.Int32> get_OutputBlockSize(
            this IObservable<System.Security.Cryptography.ToBase64Transform> ToBase64TransformValue)
        {
            return Observable.Select(ToBase64TransformValue,
                (ToBase64TransformValueLambda) => ToBase64TransformValueLambda.OutputBlockSize);
        }


        public static IObservable<System.Boolean> get_CanTransformMultipleBlocks(
            this IObservable<System.Security.Cryptography.ToBase64Transform> ToBase64TransformValue)
        {
            return Observable.Select(ToBase64TransformValue,
                (ToBase64TransformValueLambda) => ToBase64TransformValueLambda.CanTransformMultipleBlocks);
        }


        public static IObservable<System.Boolean> get_CanReuseTransform(
            this IObservable<System.Security.Cryptography.ToBase64Transform> ToBase64TransformValue)
        {
            return Observable.Select(ToBase64TransformValue,
                (ToBase64TransformValueLambda) => ToBase64TransformValueLambda.CanReuseTransform);
        }
    }
}