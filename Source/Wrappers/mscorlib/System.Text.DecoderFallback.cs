using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
    public static class __DecoderFallback
    {
        
        public static IObservable<System.Text.DecoderFallbackBuffer> CreateFallbackBuffer(this IObservable<System.Text.DecoderFallback> DecoderFallbackValue)
        {
            return Observable.Select(DecoderFallbackValue, (DecoderFallbackValueLambda) => DecoderFallbackValueLambda.CreateFallbackBuffer());
        }


        public static IObservable<System.Text.DecoderFallback> get_ReplacementFallback()
        {
            return ObservableExt.Factory(() => System.Text.DecoderFallback.ReplacementFallback);
        }


        public static IObservable<System.Text.DecoderFallback> get_ExceptionFallback()
        {
            return ObservableExt.Factory(() => System.Text.DecoderFallback.ExceptionFallback);
        }


        public static IObservable<System.Int32> get_MaxCharCount(this IObservable<System.Text.DecoderFallback> DecoderFallbackValue)
        {
            return Observable.Select(DecoderFallbackValue, (DecoderFallbackValueLambda) => DecoderFallbackValueLambda.MaxCharCount);
        }

    }
}