using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
    public static class __DecoderFallbackBuffer
    {
        
        public static IObservable<System.Boolean> Fallback(this IObservable<System.Text.DecoderFallbackBuffer> DecoderFallbackBufferValue, IObservable<System.Byte[]> bytesUnknown, IObservable<System.Int32> index)
        {
            return Observable.Zip(DecoderFallbackBufferValue, bytesUnknown, index, (DecoderFallbackBufferValueLambda, bytesUnknownLambda, indexLambda) => DecoderFallbackBufferValueLambda.Fallback(bytesUnknownLambda, indexLambda));
        }


        public static IObservable<System.Char> GetNextChar(this IObservable<System.Text.DecoderFallbackBuffer> DecoderFallbackBufferValue)
        {
            return Observable.Select(DecoderFallbackBufferValue, (DecoderFallbackBufferValueLambda) => DecoderFallbackBufferValueLambda.GetNextChar());
        }


        public static IObservable<System.Boolean> MovePrevious(this IObservable<System.Text.DecoderFallbackBuffer> DecoderFallbackBufferValue)
        {
            return Observable.Select(DecoderFallbackBufferValue, (DecoderFallbackBufferValueLambda) => DecoderFallbackBufferValueLambda.MovePrevious());
        }


        public static IObservable<System.Reactive.Unit> Reset(this IObservable<System.Text.DecoderFallbackBuffer> DecoderFallbackBufferValue)
        {
            return Observable.Do(DecoderFallbackBufferValue, (DecoderFallbackBufferValueLambda) => DecoderFallbackBufferValueLambda.Reset()).ToUnit();
        }


        public static IObservable<System.Int32> get_Remaining(this IObservable<System.Text.DecoderFallbackBuffer> DecoderFallbackBufferValue)
        {
            return Observable.Select(DecoderFallbackBufferValue, (DecoderFallbackBufferValueLambda) => DecoderFallbackBufferValueLambda.Remaining);
        }

    }
}