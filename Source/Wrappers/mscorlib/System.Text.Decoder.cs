using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
    public static class __Decoder
    {
        public static IObservable<System.Reactive.Unit> Reset(this IObservable<System.Text.Decoder> DecoderValue)
        {
            return Observable.Do(DecoderValue, (DecoderValueLambda) => DecoderValueLambda.Reset()).ToUnit();
        }


        public static IObservable<System.Int32> GetCharCount(this IObservable<System.Text.Decoder> DecoderValue,
            IObservable<System.Byte[]> bytes, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(DecoderValue, bytes, index, count,
                (DecoderValueLambda, bytesLambda, indexLambda, countLambda) =>
                    DecoderValueLambda.GetCharCount(bytesLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Int32> GetCharCount(this IObservable<System.Text.Decoder> DecoderValue,
            IObservable<System.Byte[]> bytes, IObservable<System.Int32> index, IObservable<System.Int32> count,
            IObservable<System.Boolean> flush)
        {
            return Observable.Zip(DecoderValue, bytes, index, count, flush,
                (DecoderValueLambda, bytesLambda, indexLambda, countLambda, flushLambda) =>
                    DecoderValueLambda.GetCharCount(bytesLambda, indexLambda, countLambda, flushLambda));
        }


        public static IObservable<System.Int32> GetChars(this IObservable<System.Text.Decoder> DecoderValue,
            IObservable<System.Byte[]> bytes, IObservable<System.Int32> byteIndex, IObservable<System.Int32> byteCount,
            IObservable<System.Char[]> chars, IObservable<System.Int32> charIndex)
        {
            return Observable.Zip(DecoderValue, bytes, byteIndex, byteCount, chars, charIndex,
                (DecoderValueLambda, bytesLambda, byteIndexLambda, byteCountLambda, charsLambda, charIndexLambda) =>
                    DecoderValueLambda.GetChars(bytesLambda, byteIndexLambda, byteCountLambda, charsLambda,
                        charIndexLambda));
        }


        public static IObservable<System.Int32> GetChars(this IObservable<System.Text.Decoder> DecoderValue,
            IObservable<System.Byte[]> bytes, IObservable<System.Int32> byteIndex, IObservable<System.Int32> byteCount,
            IObservable<System.Char[]> chars, IObservable<System.Int32> charIndex, IObservable<System.Boolean> flush)
        {
            return Observable.Zip(DecoderValue, bytes, byteIndex, byteCount, chars, charIndex, flush,
                (DecoderValueLambda, bytesLambda, byteIndexLambda, byteCountLambda, charsLambda, charIndexLambda,
                    flushLambda) =>
                    DecoderValueLambda.GetChars(bytesLambda, byteIndexLambda, byteCountLambda, charsLambda,
                        charIndexLambda, flushLambda));
        }


        public static IObservable<Tuple<System.Int32, System.Int32, System.Boolean>> Convert(
            this IObservable<System.Text.Decoder> DecoderValue, IObservable<System.Byte[]> bytes,
            IObservable<System.Int32> byteIndex, IObservable<System.Int32> byteCount, IObservable<System.Char[]> chars,
            IObservable<System.Int32> charIndex, IObservable<System.Int32> charCount, IObservable<System.Boolean> flush)
        {
            return Observable.Zip(DecoderValue, bytes, byteIndex, byteCount, chars, charIndex, charCount, flush,
                (DecoderValueLambda, bytesLambda, byteIndexLambda, byteCountLambda, charsLambda, charIndexLambda,
                    charCountLambda, flushLambda) =>
                {
                    System.Int32 bytesUsedOutput = default(System.Int32);
                    System.Int32 charsUsedOutput = default(System.Int32);
                    System.Boolean completedOutput = default(System.Boolean);
                    DecoderValueLambda.Convert(bytesLambda, byteIndexLambda, byteCountLambda, charsLambda,
                        charIndexLambda, charCountLambda, flushLambda, out bytesUsedOutput, out charsUsedOutput,
                        out completedOutput);
                    return Tuple.Create(bytesUsedOutput, charsUsedOutput, completedOutput);
                });
        }


        public static IObservable<System.Text.DecoderFallback> get_Fallback(
            this IObservable<System.Text.Decoder> DecoderValue)
        {
            return Observable.Select(DecoderValue, (DecoderValueLambda) => DecoderValueLambda.Fallback);
        }


        public static IObservable<System.Text.DecoderFallbackBuffer> get_FallbackBuffer(
            this IObservable<System.Text.Decoder> DecoderValue)
        {
            return Observable.Select(DecoderValue, (DecoderValueLambda) => DecoderValueLambda.FallbackBuffer);
        }


        public static IObservable<System.Reactive.Unit> set_Fallback(this IObservable<System.Text.Decoder> DecoderValue,
            IObservable<System.Text.DecoderFallback> value)
        {
            return ObservableExt.ZipExecute(DecoderValue, value,
                (DecoderValueLambda, valueLambda) => DecoderValueLambda.Fallback = valueLambda);
        }
    }
}