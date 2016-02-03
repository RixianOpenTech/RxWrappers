using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
    public static class __EncoderFallbackBuffer
    {
        public static IObservable<System.Boolean> Fallback(
            this IObservable<System.Text.EncoderFallbackBuffer> EncoderFallbackBufferValue,
            IObservable<System.Char> charUnknown, IObservable<System.Int32> index)
        {
            return Observable.Zip(EncoderFallbackBufferValue, charUnknown, index,
                (EncoderFallbackBufferValueLambda, charUnknownLambda, indexLambda) =>
                    EncoderFallbackBufferValueLambda.Fallback(charUnknownLambda, indexLambda));
        }


        public static IObservable<System.Boolean> Fallback(
            this IObservable<System.Text.EncoderFallbackBuffer> EncoderFallbackBufferValue,
            IObservable<System.Char> charUnknownHigh, IObservable<System.Char> charUnknownLow,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(EncoderFallbackBufferValue, charUnknownHigh, charUnknownLow, index,
                (EncoderFallbackBufferValueLambda, charUnknownHighLambda, charUnknownLowLambda, indexLambda) =>
                    EncoderFallbackBufferValueLambda.Fallback(charUnknownHighLambda, charUnknownLowLambda, indexLambda));
        }


        public static IObservable<System.Char> GetNextChar(
            this IObservable<System.Text.EncoderFallbackBuffer> EncoderFallbackBufferValue)
        {
            return Observable.Select(EncoderFallbackBufferValue,
                (EncoderFallbackBufferValueLambda) => EncoderFallbackBufferValueLambda.GetNextChar());
        }


        public static IObservable<System.Boolean> MovePrevious(
            this IObservable<System.Text.EncoderFallbackBuffer> EncoderFallbackBufferValue)
        {
            return Observable.Select(EncoderFallbackBufferValue,
                (EncoderFallbackBufferValueLambda) => EncoderFallbackBufferValueLambda.MovePrevious());
        }


        public static IObservable<System.Reactive.Unit> Reset(
            this IObservable<System.Text.EncoderFallbackBuffer> EncoderFallbackBufferValue)
        {
            return
                Observable.Do(EncoderFallbackBufferValue,
                    (EncoderFallbackBufferValueLambda) => EncoderFallbackBufferValueLambda.Reset()).ToUnit();
        }


        public static IObservable<System.Int32> get_Remaining(
            this IObservable<System.Text.EncoderFallbackBuffer> EncoderFallbackBufferValue)
        {
            return Observable.Select(EncoderFallbackBufferValue,
                (EncoderFallbackBufferValueLambda) => EncoderFallbackBufferValueLambda.Remaining);
        }
    }
}