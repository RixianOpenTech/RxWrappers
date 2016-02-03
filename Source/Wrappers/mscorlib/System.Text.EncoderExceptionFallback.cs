using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
    public static class __EncoderExceptionFallback
    {
        public static IObservable<System.Text.EncoderFallbackBuffer> CreateFallbackBuffer(
            this IObservable<System.Text.EncoderExceptionFallback> EncoderExceptionFallbackValue)
        {
            return Observable.Select(EncoderExceptionFallbackValue,
                (EncoderExceptionFallbackValueLambda) => EncoderExceptionFallbackValueLambda.CreateFallbackBuffer());
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Text.EncoderExceptionFallback> EncoderExceptionFallbackValue,
            IObservable<System.Object> value)
        {
            return Observable.Zip(EncoderExceptionFallbackValue, value,
                (EncoderExceptionFallbackValueLambda, valueLambda) =>
                    EncoderExceptionFallbackValueLambda.Equals(valueLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Text.EncoderExceptionFallback> EncoderExceptionFallbackValue)
        {
            return Observable.Select(EncoderExceptionFallbackValue,
                (EncoderExceptionFallbackValueLambda) => EncoderExceptionFallbackValueLambda.GetHashCode());
        }


        public static IObservable<System.Int32> get_MaxCharCount(
            this IObservable<System.Text.EncoderExceptionFallback> EncoderExceptionFallbackValue)
        {
            return Observable.Select(EncoderExceptionFallbackValue,
                (EncoderExceptionFallbackValueLambda) => EncoderExceptionFallbackValueLambda.MaxCharCount);
        }
    }
}