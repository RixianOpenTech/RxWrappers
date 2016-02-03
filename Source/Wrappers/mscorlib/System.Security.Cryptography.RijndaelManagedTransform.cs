using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __RijndaelManagedTransform
    {
        
        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Security.Cryptography.RijndaelManagedTransform> RijndaelManagedTransformValue)
        {
            return Observable.Do(RijndaelManagedTransformValue, (RijndaelManagedTransformValueLambda) => RijndaelManagedTransformValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Clear(this IObservable<System.Security.Cryptography.RijndaelManagedTransform> RijndaelManagedTransformValue)
        {
            return Observable.Do(RijndaelManagedTransformValue, (RijndaelManagedTransformValueLambda) => RijndaelManagedTransformValueLambda.Clear()).ToUnit();
        }


        public static IObservable<System.Int32> TransformBlock(this IObservable<System.Security.Cryptography.RijndaelManagedTransform> RijndaelManagedTransformValue, IObservable<System.Byte[]> inputBuffer, IObservable<System.Int32> inputOffset, IObservable<System.Int32> inputCount, IObservable<System.Byte[]> outputBuffer, IObservable<System.Int32> outputOffset)
        {
            return Observable.Zip(RijndaelManagedTransformValue, inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset, (RijndaelManagedTransformValueLambda, inputBufferLambda, inputOffsetLambda, inputCountLambda, outputBufferLambda, outputOffsetLambda) => RijndaelManagedTransformValueLambda.TransformBlock(inputBufferLambda, inputOffsetLambda, inputCountLambda, outputBufferLambda, outputOffsetLambda));
        }


        public static IObservable<System.Byte[]> TransformFinalBlock(this IObservable<System.Security.Cryptography.RijndaelManagedTransform> RijndaelManagedTransformValue, IObservable<System.Byte[]> inputBuffer, IObservable<System.Int32> inputOffset, IObservable<System.Int32> inputCount)
        {
            return Observable.Zip(RijndaelManagedTransformValue, inputBuffer, inputOffset, inputCount, (RijndaelManagedTransformValueLambda, inputBufferLambda, inputOffsetLambda, inputCountLambda) => RijndaelManagedTransformValueLambda.TransformFinalBlock(inputBufferLambda, inputOffsetLambda, inputCountLambda));
        }


        public static IObservable<System.Reactive.Unit> Reset(this IObservable<System.Security.Cryptography.RijndaelManagedTransform> RijndaelManagedTransformValue)
        {
            return Observable.Do(RijndaelManagedTransformValue, (RijndaelManagedTransformValueLambda) => RijndaelManagedTransformValueLambda.Reset()).ToUnit();
        }


        public static IObservable<System.Int32> get_BlockSizeValue(this IObservable<System.Security.Cryptography.RijndaelManagedTransform> RijndaelManagedTransformValue)
        {
            return Observable.Select(RijndaelManagedTransformValue, (RijndaelManagedTransformValueLambda) => RijndaelManagedTransformValueLambda.BlockSizeValue);
        }


        public static IObservable<System.Int32> get_InputBlockSize(this IObservable<System.Security.Cryptography.RijndaelManagedTransform> RijndaelManagedTransformValue)
        {
            return Observable.Select(RijndaelManagedTransformValue, (RijndaelManagedTransformValueLambda) => RijndaelManagedTransformValueLambda.InputBlockSize);
        }


        public static IObservable<System.Int32> get_OutputBlockSize(this IObservable<System.Security.Cryptography.RijndaelManagedTransform> RijndaelManagedTransformValue)
        {
            return Observable.Select(RijndaelManagedTransformValue, (RijndaelManagedTransformValueLambda) => RijndaelManagedTransformValueLambda.OutputBlockSize);
        }


        public static IObservable<System.Boolean> get_CanTransformMultipleBlocks(this IObservable<System.Security.Cryptography.RijndaelManagedTransform> RijndaelManagedTransformValue)
        {
            return Observable.Select(RijndaelManagedTransformValue, (RijndaelManagedTransformValueLambda) => RijndaelManagedTransformValueLambda.CanTransformMultipleBlocks);
        }


        public static IObservable<System.Boolean> get_CanReuseTransform(this IObservable<System.Security.Cryptography.RijndaelManagedTransform> RijndaelManagedTransformValue)
        {
            return Observable.Select(RijndaelManagedTransformValue, (RijndaelManagedTransformValueLambda) => RijndaelManagedTransformValueLambda.CanReuseTransform);
        }

    }
}