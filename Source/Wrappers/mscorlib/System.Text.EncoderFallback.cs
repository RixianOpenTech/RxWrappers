using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
    public static class __EncoderFallback
    {
        
        public static IObservable<System.Text.EncoderFallbackBuffer> CreateFallbackBuffer(this IObservable<System.Text.EncoderFallback> EncoderFallbackValue)
        {
            return Observable.Select(EncoderFallbackValue, (EncoderFallbackValueLambda) => EncoderFallbackValueLambda.CreateFallbackBuffer());
        }


        public static IObservable<System.Text.EncoderFallback> get_ReplacementFallback()
        {
            return ObservableExt.Factory(() => System.Text.EncoderFallback.ReplacementFallback);
        }


        public static IObservable<System.Text.EncoderFallback> get_ExceptionFallback()
        {
            return ObservableExt.Factory(() => System.Text.EncoderFallback.ExceptionFallback);
        }


        public static IObservable<System.Int32> get_MaxCharCount(this IObservable<System.Text.EncoderFallback> EncoderFallbackValue)
        {
            return Observable.Select(EncoderFallbackValue, (EncoderFallbackValueLambda) => EncoderFallbackValueLambda.MaxCharCount);
        }

    }
}