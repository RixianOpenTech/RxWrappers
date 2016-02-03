using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
    public static class __DecoderReplacementFallbackBuffer
    {
        public static IObservable<System.Boolean> Fallback(
            this IObservable<System.Text.DecoderReplacementFallbackBuffer> DecoderReplacementFallbackBufferValue,
            IObservable<System.Byte[]> bytesUnknown, IObservable<System.Int32> index)
        {
            return Observable.Zip(DecoderReplacementFallbackBufferValue, bytesUnknown, index,
                (DecoderReplacementFallbackBufferValueLambda, bytesUnknownLambda, indexLambda) =>
                    DecoderReplacementFallbackBufferValueLambda.Fallback(bytesUnknownLambda, indexLambda));
        }


        public static IObservable<System.Char> GetNextChar(
            this IObservable<System.Text.DecoderReplacementFallbackBuffer> DecoderReplacementFallbackBufferValue)
        {
            return Observable.Select(DecoderReplacementFallbackBufferValue,
                (DecoderReplacementFallbackBufferValueLambda) =>
                    DecoderReplacementFallbackBufferValueLambda.GetNextChar());
        }


        public static IObservable<System.Boolean> MovePrevious(
            this IObservable<System.Text.DecoderReplacementFallbackBuffer> DecoderReplacementFallbackBufferValue)
        {
            return Observable.Select(DecoderReplacementFallbackBufferValue,
                (DecoderReplacementFallbackBufferValueLambda) =>
                    DecoderReplacementFallbackBufferValueLambda.MovePrevious());
        }


        public static IObservable<System.Reactive.Unit> Reset(
            this IObservable<System.Text.DecoderReplacementFallbackBuffer> DecoderReplacementFallbackBufferValue)
        {
            return
                Observable.Do(DecoderReplacementFallbackBufferValue,
                    (DecoderReplacementFallbackBufferValueLambda) => DecoderReplacementFallbackBufferValueLambda.Reset())
                    .ToUnit();
        }


        public static IObservable<System.Int32> get_Remaining(
            this IObservable<System.Text.DecoderReplacementFallbackBuffer> DecoderReplacementFallbackBufferValue)
        {
            return Observable.Select(DecoderReplacementFallbackBufferValue,
                (DecoderReplacementFallbackBufferValueLambda) => DecoderReplacementFallbackBufferValueLambda.Remaining);
        }
    }
}