using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
    public static class __EncoderReplacementFallbackBuffer
    {
        
        public static IObservable<System.Boolean> Fallback(this IObservable<System.Text.EncoderReplacementFallbackBuffer> EncoderReplacementFallbackBufferValue, IObservable<System.Char> charUnknown, IObservable<System.Int32> index)
        {
            return Observable.Zip(EncoderReplacementFallbackBufferValue, charUnknown, index, (EncoderReplacementFallbackBufferValueLambda, charUnknownLambda, indexLambda) => EncoderReplacementFallbackBufferValueLambda.Fallback(charUnknownLambda, indexLambda));
        }


        public static IObservable<System.Boolean> Fallback(this IObservable<System.Text.EncoderReplacementFallbackBuffer> EncoderReplacementFallbackBufferValue, IObservable<System.Char> charUnknownHigh, IObservable<System.Char> charUnknownLow, IObservable<System.Int32> index)
        {
            return Observable.Zip(EncoderReplacementFallbackBufferValue, charUnknownHigh, charUnknownLow, index, (EncoderReplacementFallbackBufferValueLambda, charUnknownHighLambda, charUnknownLowLambda, indexLambda) => EncoderReplacementFallbackBufferValueLambda.Fallback(charUnknownHighLambda, charUnknownLowLambda, indexLambda));
        }


        public static IObservable<System.Char> GetNextChar(this IObservable<System.Text.EncoderReplacementFallbackBuffer> EncoderReplacementFallbackBufferValue)
        {
            return Observable.Select(EncoderReplacementFallbackBufferValue, (EncoderReplacementFallbackBufferValueLambda) => EncoderReplacementFallbackBufferValueLambda.GetNextChar());
        }


        public static IObservable<System.Boolean> MovePrevious(this IObservable<System.Text.EncoderReplacementFallbackBuffer> EncoderReplacementFallbackBufferValue)
        {
            return Observable.Select(EncoderReplacementFallbackBufferValue, (EncoderReplacementFallbackBufferValueLambda) => EncoderReplacementFallbackBufferValueLambda.MovePrevious());
        }


        public static IObservable<System.Reactive.Unit> Reset(this IObservable<System.Text.EncoderReplacementFallbackBuffer> EncoderReplacementFallbackBufferValue)
        {
            return Observable.Do(EncoderReplacementFallbackBufferValue, (EncoderReplacementFallbackBufferValueLambda) => EncoderReplacementFallbackBufferValueLambda.Reset()).ToUnit();
        }


        public static IObservable<System.Int32> get_Remaining(this IObservable<System.Text.EncoderReplacementFallbackBuffer> EncoderReplacementFallbackBufferValue)
        {
            return Observable.Select(EncoderReplacementFallbackBufferValue, (EncoderReplacementFallbackBufferValueLambda) => EncoderReplacementFallbackBufferValueLambda.Remaining);
        }

    }
}