using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
    public static class __EncoderExceptionFallbackBuffer
    {
        public static IObservable<System.Boolean> Fallback(
            this IObservable<System.Text.EncoderExceptionFallbackBuffer> EncoderExceptionFallbackBufferValue,
            IObservable<System.Char> charUnknown, IObservable<System.Int32> index)
        {
            return Observable.Zip(EncoderExceptionFallbackBufferValue, charUnknown, index,
                (EncoderExceptionFallbackBufferValueLambda, charUnknownLambda, indexLambda) =>
                    EncoderExceptionFallbackBufferValueLambda.Fallback(charUnknownLambda, indexLambda));
        }


        public static IObservable<System.Boolean> Fallback(
            this IObservable<System.Text.EncoderExceptionFallbackBuffer> EncoderExceptionFallbackBufferValue,
            IObservable<System.Char> charUnknownHigh, IObservable<System.Char> charUnknownLow,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(EncoderExceptionFallbackBufferValue, charUnknownHigh, charUnknownLow, index,
                (EncoderExceptionFallbackBufferValueLambda, charUnknownHighLambda, charUnknownLowLambda, indexLambda) =>
                    EncoderExceptionFallbackBufferValueLambda.Fallback(charUnknownHighLambda, charUnknownLowLambda,
                        indexLambda));
        }


        public static IObservable<System.Char> GetNextChar(
            this IObservable<System.Text.EncoderExceptionFallbackBuffer> EncoderExceptionFallbackBufferValue)
        {
            return Observable.Select(EncoderExceptionFallbackBufferValue,
                (EncoderExceptionFallbackBufferValueLambda) => EncoderExceptionFallbackBufferValueLambda.GetNextChar());
        }


        public static IObservable<System.Boolean> MovePrevious(
            this IObservable<System.Text.EncoderExceptionFallbackBuffer> EncoderExceptionFallbackBufferValue)
        {
            return Observable.Select(EncoderExceptionFallbackBufferValue,
                (EncoderExceptionFallbackBufferValueLambda) => EncoderExceptionFallbackBufferValueLambda.MovePrevious());
        }


        public static IObservable<System.Int32> get_Remaining(
            this IObservable<System.Text.EncoderExceptionFallbackBuffer> EncoderExceptionFallbackBufferValue)
        {
            return Observable.Select(EncoderExceptionFallbackBufferValue,
                (EncoderExceptionFallbackBufferValueLambda) => EncoderExceptionFallbackBufferValueLambda.Remaining);
        }
    }
}