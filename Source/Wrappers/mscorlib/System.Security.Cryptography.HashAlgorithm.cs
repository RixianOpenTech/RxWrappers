using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __HashAlgorithm
    {
        public static IObservable<System.Security.Cryptography.HashAlgorithm> Create()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.HashAlgorithm.Create());
        }


        public static IObservable<System.Security.Cryptography.HashAlgorithm> Create(IObservable<System.String> hashName)
        {
            return Observable.Select(hashName,
                (hashNameLambda) => System.Security.Cryptography.HashAlgorithm.Create(hashNameLambda));
        }


        public static IObservable<System.Byte[]> ComputeHash(
            this IObservable<System.Security.Cryptography.HashAlgorithm> HashAlgorithmValue,
            IObservable<System.IO.Stream> inputStream)
        {
            return Observable.Zip(HashAlgorithmValue, inputStream,
                (HashAlgorithmValueLambda, inputStreamLambda) => HashAlgorithmValueLambda.ComputeHash(inputStreamLambda));
        }


        public static IObservable<System.Byte[]> ComputeHash(
            this IObservable<System.Security.Cryptography.HashAlgorithm> HashAlgorithmValue,
            IObservable<System.Byte[]> buffer)
        {
            return Observable.Zip(HashAlgorithmValue, buffer,
                (HashAlgorithmValueLambda, bufferLambda) => HashAlgorithmValueLambda.ComputeHash(bufferLambda));
        }


        public static IObservable<System.Byte[]> ComputeHash(
            this IObservable<System.Security.Cryptography.HashAlgorithm> HashAlgorithmValue,
            IObservable<System.Byte[]> buffer, IObservable<System.Int32> offset, IObservable<System.Int32> count)
        {
            return Observable.Zip(HashAlgorithmValue, buffer, offset, count,
                (HashAlgorithmValueLambda, bufferLambda, offsetLambda, countLambda) =>
                    HashAlgorithmValueLambda.ComputeHash(bufferLambda, offsetLambda, countLambda));
        }


        public static IObservable<System.Int32> TransformBlock(
            this IObservable<System.Security.Cryptography.HashAlgorithm> HashAlgorithmValue,
            IObservable<System.Byte[]> inputBuffer, IObservable<System.Int32> inputOffset,
            IObservable<System.Int32> inputCount, IObservable<System.Byte[]> outputBuffer,
            IObservable<System.Int32> outputOffset)
        {
            return Observable.Zip(HashAlgorithmValue, inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset,
                (HashAlgorithmValueLambda, inputBufferLambda, inputOffsetLambda, inputCountLambda, outputBufferLambda,
                    outputOffsetLambda) =>
                    HashAlgorithmValueLambda.TransformBlock(inputBufferLambda, inputOffsetLambda, inputCountLambda,
                        outputBufferLambda, outputOffsetLambda));
        }


        public static IObservable<System.Byte[]> TransformFinalBlock(
            this IObservable<System.Security.Cryptography.HashAlgorithm> HashAlgorithmValue,
            IObservable<System.Byte[]> inputBuffer, IObservable<System.Int32> inputOffset,
            IObservable<System.Int32> inputCount)
        {
            return Observable.Zip(HashAlgorithmValue, inputBuffer, inputOffset, inputCount,
                (HashAlgorithmValueLambda, inputBufferLambda, inputOffsetLambda, inputCountLambda) =>
                    HashAlgorithmValueLambda.TransformFinalBlock(inputBufferLambda, inputOffsetLambda, inputCountLambda));
        }


        public static IObservable<System.Reactive.Unit> Dispose(
            this IObservable<System.Security.Cryptography.HashAlgorithm> HashAlgorithmValue)
        {
            return
                Observable.Do(HashAlgorithmValue, (HashAlgorithmValueLambda) => HashAlgorithmValueLambda.Dispose())
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Clear(
            this IObservable<System.Security.Cryptography.HashAlgorithm> HashAlgorithmValue)
        {
            return
                Observable.Do(HashAlgorithmValue, (HashAlgorithmValueLambda) => HashAlgorithmValueLambda.Clear())
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Initialize(
            this IObservable<System.Security.Cryptography.HashAlgorithm> HashAlgorithmValue)
        {
            return
                Observable.Do(HashAlgorithmValue, (HashAlgorithmValueLambda) => HashAlgorithmValueLambda.Initialize())
                    .ToUnit();
        }


        public static IObservable<System.Int32> get_HashSize(
            this IObservable<System.Security.Cryptography.HashAlgorithm> HashAlgorithmValue)
        {
            return Observable.Select(HashAlgorithmValue, (HashAlgorithmValueLambda) => HashAlgorithmValueLambda.HashSize);
        }


        public static IObservable<System.Byte[]> get_Hash(
            this IObservable<System.Security.Cryptography.HashAlgorithm> HashAlgorithmValue)
        {
            return Observable.Select(HashAlgorithmValue, (HashAlgorithmValueLambda) => HashAlgorithmValueLambda.Hash);
        }


        public static IObservable<System.Int32> get_InputBlockSize(
            this IObservable<System.Security.Cryptography.HashAlgorithm> HashAlgorithmValue)
        {
            return Observable.Select(HashAlgorithmValue,
                (HashAlgorithmValueLambda) => HashAlgorithmValueLambda.InputBlockSize);
        }


        public static IObservable<System.Int32> get_OutputBlockSize(
            this IObservable<System.Security.Cryptography.HashAlgorithm> HashAlgorithmValue)
        {
            return Observable.Select(HashAlgorithmValue,
                (HashAlgorithmValueLambda) => HashAlgorithmValueLambda.OutputBlockSize);
        }


        public static IObservable<System.Boolean> get_CanTransformMultipleBlocks(
            this IObservable<System.Security.Cryptography.HashAlgorithm> HashAlgorithmValue)
        {
            return Observable.Select(HashAlgorithmValue,
                (HashAlgorithmValueLambda) => HashAlgorithmValueLambda.CanTransformMultipleBlocks);
        }


        public static IObservable<System.Boolean> get_CanReuseTransform(
            this IObservable<System.Security.Cryptography.HashAlgorithm> HashAlgorithmValue)
        {
            return Observable.Select(HashAlgorithmValue,
                (HashAlgorithmValueLambda) => HashAlgorithmValueLambda.CanReuseTransform);
        }
    }
}