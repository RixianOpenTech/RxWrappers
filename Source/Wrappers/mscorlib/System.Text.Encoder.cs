using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
    public static class __Encoder
    {
        public static IObservable<System.Reactive.Unit> Reset(this IObservable<System.Text.Encoder> EncoderValue)
        {
            return Observable.Do(EncoderValue, (EncoderValueLambda) => EncoderValueLambda.Reset()).ToUnit();
        }


        public static IObservable<System.Int32> GetByteCount(this IObservable<System.Text.Encoder> EncoderValue,
            IObservable<System.Char[]> chars, IObservable<System.Int32> index, IObservable<System.Int32> count,
            IObservable<System.Boolean> flush)
        {
            return Observable.Zip(EncoderValue, chars, index, count, flush,
                (EncoderValueLambda, charsLambda, indexLambda, countLambda, flushLambda) =>
                    EncoderValueLambda.GetByteCount(charsLambda, indexLambda, countLambda, flushLambda));
        }


        public static IObservable<System.Int32> GetBytes(this IObservable<System.Text.Encoder> EncoderValue,
            IObservable<System.Char[]> chars, IObservable<System.Int32> charIndex, IObservable<System.Int32> charCount,
            IObservable<System.Byte[]> bytes, IObservable<System.Int32> byteIndex, IObservable<System.Boolean> flush)
        {
            return Observable.Zip(EncoderValue, chars, charIndex, charCount, bytes, byteIndex, flush,
                (EncoderValueLambda, charsLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda,
                    flushLambda) =>
                    EncoderValueLambda.GetBytes(charsLambda, charIndexLambda, charCountLambda, bytesLambda,
                        byteIndexLambda, flushLambda));
        }


        public static IObservable<Tuple<System.Int32, System.Int32, System.Boolean>> Convert(
            this IObservable<System.Text.Encoder> EncoderValue, IObservable<System.Char[]> chars,
            IObservable<System.Int32> charIndex, IObservable<System.Int32> charCount, IObservable<System.Byte[]> bytes,
            IObservable<System.Int32> byteIndex, IObservable<System.Int32> byteCount, IObservable<System.Boolean> flush)
        {
            return Observable.Zip(EncoderValue, chars, charIndex, charCount, bytes, byteIndex, byteCount, flush,
                (EncoderValueLambda, charsLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda,
                    byteCountLambda, flushLambda) =>
                {
                    System.Int32 charsUsedOutput = default(System.Int32);
                    System.Int32 bytesUsedOutput = default(System.Int32);
                    System.Boolean completedOutput = default(System.Boolean);
                    EncoderValueLambda.Convert(charsLambda, charIndexLambda, charCountLambda, bytesLambda,
                        byteIndexLambda, byteCountLambda, flushLambda, out charsUsedOutput, out bytesUsedOutput,
                        out completedOutput);
                    return Tuple.Create(charsUsedOutput, bytesUsedOutput, completedOutput);
                });
        }


        public static IObservable<System.Text.EncoderFallback> get_Fallback(
            this IObservable<System.Text.Encoder> EncoderValue)
        {
            return Observable.Select(EncoderValue, (EncoderValueLambda) => EncoderValueLambda.Fallback);
        }


        public static IObservable<System.Text.EncoderFallbackBuffer> get_FallbackBuffer(
            this IObservable<System.Text.Encoder> EncoderValue)
        {
            return Observable.Select(EncoderValue, (EncoderValueLambda) => EncoderValueLambda.FallbackBuffer);
        }


        public static IObservable<System.Reactive.Unit> set_Fallback(this IObservable<System.Text.Encoder> EncoderValue,
            IObservable<System.Text.EncoderFallback> value)
        {
            return ObservableExt.ZipExecute(EncoderValue, value,
                (EncoderValueLambda, valueLambda) => EncoderValueLambda.Fallback = valueLambda);
        }
    }
}