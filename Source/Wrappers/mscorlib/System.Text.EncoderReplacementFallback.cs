using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
    public static class __EncoderReplacementFallback
    {
        public static IObservable<System.Text.EncoderFallbackBuffer> CreateFallbackBuffer(
            this IObservable<System.Text.EncoderReplacementFallback> EncoderReplacementFallbackValue)
        {
            return Observable.Select(EncoderReplacementFallbackValue,
                (EncoderReplacementFallbackValueLambda) => EncoderReplacementFallbackValueLambda.CreateFallbackBuffer());
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Text.EncoderReplacementFallback> EncoderReplacementFallbackValue,
            IObservable<System.Object> value)
        {
            return Observable.Zip(EncoderReplacementFallbackValue, value,
                (EncoderReplacementFallbackValueLambda, valueLambda) =>
                    EncoderReplacementFallbackValueLambda.Equals(valueLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Text.EncoderReplacementFallback> EncoderReplacementFallbackValue)
        {
            return Observable.Select(EncoderReplacementFallbackValue,
                (EncoderReplacementFallbackValueLambda) => EncoderReplacementFallbackValueLambda.GetHashCode());
        }


        public static IObservable<System.String> get_DefaultString(
            this IObservable<System.Text.EncoderReplacementFallback> EncoderReplacementFallbackValue)
        {
            return Observable.Select(EncoderReplacementFallbackValue,
                (EncoderReplacementFallbackValueLambda) => EncoderReplacementFallbackValueLambda.DefaultString);
        }


        public static IObservable<System.Int32> get_MaxCharCount(
            this IObservable<System.Text.EncoderReplacementFallback> EncoderReplacementFallbackValue)
        {
            return Observable.Select(EncoderReplacementFallbackValue,
                (EncoderReplacementFallbackValueLambda) => EncoderReplacementFallbackValueLambda.MaxCharCount);
        }
    }
}