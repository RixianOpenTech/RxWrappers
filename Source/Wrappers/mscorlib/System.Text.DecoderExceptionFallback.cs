using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
public static class _DecoderExceptionFallback
{
    
public static IObservable<System.Text.DecoderFallbackBuffer> CreateFallbackBuffer(this IObservable<System.Text.DecoderExceptionFallback> DecoderExceptionFallbackValue)
{
    return Observable.Select(DecoderExceptionFallbackValue, (DecoderExceptionFallbackValueLambda) => DecoderExceptionFallbackValueLambda.CreateFallbackBuffer());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Text.DecoderExceptionFallback> DecoderExceptionFallbackValue, IObservable<System.Object> value)
{
    return Observable.Zip(DecoderExceptionFallbackValue, value, (DecoderExceptionFallbackValueLambda, valueLambda) => DecoderExceptionFallbackValueLambda.Equals(valueLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Text.DecoderExceptionFallback> DecoderExceptionFallbackValue)
{
    return Observable.Select(DecoderExceptionFallbackValue, (DecoderExceptionFallbackValueLambda) => DecoderExceptionFallbackValueLambda.GetHashCode());
}


public static IObservable<System.Int32> get_MaxCharCount(this IObservable<System.Text.DecoderExceptionFallback> DecoderExceptionFallbackValue)
{
    return Observable.Select(DecoderExceptionFallbackValue, (DecoderExceptionFallbackValueLambda) => DecoderExceptionFallbackValueLambda.MaxCharCount);
}

}
}