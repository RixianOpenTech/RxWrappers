using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __CryptoAPITransform
    {
        
        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Security.Cryptography.CryptoAPITransform> CryptoAPITransformValue)
        {
            return Observable.Do(CryptoAPITransformValue, (CryptoAPITransformValueLambda) => CryptoAPITransformValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Clear(this IObservable<System.Security.Cryptography.CryptoAPITransform> CryptoAPITransformValue)
        {
            return Observable.Do(CryptoAPITransformValue, (CryptoAPITransformValueLambda) => CryptoAPITransformValueLambda.Clear()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Reset(this IObservable<System.Security.Cryptography.CryptoAPITransform> CryptoAPITransformValue)
        {
            return Observable.Do(CryptoAPITransformValue, (CryptoAPITransformValueLambda) => CryptoAPITransformValueLambda.Reset()).ToUnit();
        }


        public static IObservable<System.Int32> TransformBlock(this IObservable<System.Security.Cryptography.CryptoAPITransform> CryptoAPITransformValue, IObservable<System.Byte[]> inputBuffer, IObservable<System.Int32> inputOffset, IObservable<System.Int32> inputCount, IObservable<System.Byte[]> outputBuffer, IObservable<System.Int32> outputOffset)
        {
            return Observable.Zip(CryptoAPITransformValue, inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset, (CryptoAPITransformValueLambda, inputBufferLambda, inputOffsetLambda, inputCountLambda, outputBufferLambda, outputOffsetLambda) => CryptoAPITransformValueLambda.TransformBlock(inputBufferLambda, inputOffsetLambda, inputCountLambda, outputBufferLambda, outputOffsetLambda));
        }


        public static IObservable<System.Byte[]> TransformFinalBlock(this IObservable<System.Security.Cryptography.CryptoAPITransform> CryptoAPITransformValue, IObservable<System.Byte[]> inputBuffer, IObservable<System.Int32> inputOffset, IObservable<System.Int32> inputCount)
        {
            return Observable.Zip(CryptoAPITransformValue, inputBuffer, inputOffset, inputCount, (CryptoAPITransformValueLambda, inputBufferLambda, inputOffsetLambda, inputCountLambda) => CryptoAPITransformValueLambda.TransformFinalBlock(inputBufferLambda, inputOffsetLambda, inputCountLambda));
        }


        public static IObservable<System.IntPtr> get_KeyHandle(this IObservable<System.Security.Cryptography.CryptoAPITransform> CryptoAPITransformValue)
        {
            return Observable.Select(CryptoAPITransformValue, (CryptoAPITransformValueLambda) => CryptoAPITransformValueLambda.KeyHandle);
        }


        public static IObservable<System.Int32> get_InputBlockSize(this IObservable<System.Security.Cryptography.CryptoAPITransform> CryptoAPITransformValue)
        {
            return Observable.Select(CryptoAPITransformValue, (CryptoAPITransformValueLambda) => CryptoAPITransformValueLambda.InputBlockSize);
        }


        public static IObservable<System.Int32> get_OutputBlockSize(this IObservable<System.Security.Cryptography.CryptoAPITransform> CryptoAPITransformValue)
        {
            return Observable.Select(CryptoAPITransformValue, (CryptoAPITransformValueLambda) => CryptoAPITransformValueLambda.OutputBlockSize);
        }


        public static IObservable<System.Boolean> get_CanTransformMultipleBlocks(this IObservable<System.Security.Cryptography.CryptoAPITransform> CryptoAPITransformValue)
        {
            return Observable.Select(CryptoAPITransformValue, (CryptoAPITransformValueLambda) => CryptoAPITransformValueLambda.CanTransformMultipleBlocks);
        }


        public static IObservable<System.Boolean> get_CanReuseTransform(this IObservable<System.Security.Cryptography.CryptoAPITransform> CryptoAPITransformValue)
        {
            return Observable.Select(CryptoAPITransformValue, (CryptoAPITransformValueLambda) => CryptoAPITransformValueLambda.CanReuseTransform);
        }

    }
}