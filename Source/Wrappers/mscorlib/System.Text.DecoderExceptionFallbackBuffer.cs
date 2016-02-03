using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
    public static class __DecoderExceptionFallbackBuffer
    {
        
        public static IObservable<System.Boolean> Fallback(this IObservable<System.Text.DecoderExceptionFallbackBuffer> DecoderExceptionFallbackBufferValue, IObservable<System.Byte[]> bytesUnknown, IObservable<System.Int32> index)
        {
            return Observable.Zip(DecoderExceptionFallbackBufferValue, bytesUnknown, index, (DecoderExceptionFallbackBufferValueLambda, bytesUnknownLambda, indexLambda) => DecoderExceptionFallbackBufferValueLambda.Fallback(bytesUnknownLambda, indexLambda));
        }


        public static IObservable<System.Char> GetNextChar(this IObservable<System.Text.DecoderExceptionFallbackBuffer> DecoderExceptionFallbackBufferValue)
        {
            return Observable.Select(DecoderExceptionFallbackBufferValue, (DecoderExceptionFallbackBufferValueLambda) => DecoderExceptionFallbackBufferValueLambda.GetNextChar());
        }


        public static IObservable<System.Boolean> MovePrevious(this IObservable<System.Text.DecoderExceptionFallbackBuffer> DecoderExceptionFallbackBufferValue)
        {
            return Observable.Select(DecoderExceptionFallbackBufferValue, (DecoderExceptionFallbackBufferValueLambda) => DecoderExceptionFallbackBufferValueLambda.MovePrevious());
        }


        public static IObservable<System.Int32> get_Remaining(this IObservable<System.Text.DecoderExceptionFallbackBuffer> DecoderExceptionFallbackBufferValue)
        {
            return Observable.Select(DecoderExceptionFallbackBufferValue, (DecoderExceptionFallbackBufferValueLambda) => DecoderExceptionFallbackBufferValueLambda.Remaining);
        }

    }
}