using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
    public static class __EncoderFallbackException
    {
        
        public static IObservable<System.Boolean> IsUnknownSurrogate(this IObservable<System.Text.EncoderFallbackException> EncoderFallbackExceptionValue)
        {
            return Observable.Select(EncoderFallbackExceptionValue, (EncoderFallbackExceptionValueLambda) => EncoderFallbackExceptionValueLambda.IsUnknownSurrogate());
        }


        public static IObservable<System.Char> get_CharUnknown(this IObservable<System.Text.EncoderFallbackException> EncoderFallbackExceptionValue)
        {
            return Observable.Select(EncoderFallbackExceptionValue, (EncoderFallbackExceptionValueLambda) => EncoderFallbackExceptionValueLambda.CharUnknown);
        }


        public static IObservable<System.Char> get_CharUnknownHigh(this IObservable<System.Text.EncoderFallbackException> EncoderFallbackExceptionValue)
        {
            return Observable.Select(EncoderFallbackExceptionValue, (EncoderFallbackExceptionValueLambda) => EncoderFallbackExceptionValueLambda.CharUnknownHigh);
        }


        public static IObservable<System.Char> get_CharUnknownLow(this IObservable<System.Text.EncoderFallbackException> EncoderFallbackExceptionValue)
        {
            return Observable.Select(EncoderFallbackExceptionValue, (EncoderFallbackExceptionValueLambda) => EncoderFallbackExceptionValueLambda.CharUnknownLow);
        }


        public static IObservable<System.Int32> get_Index(this IObservable<System.Text.EncoderFallbackException> EncoderFallbackExceptionValue)
        {
            return Observable.Select(EncoderFallbackExceptionValue, (EncoderFallbackExceptionValueLambda) => EncoderFallbackExceptionValueLambda.Index);
        }

    }
}