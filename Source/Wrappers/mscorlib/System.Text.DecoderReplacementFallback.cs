using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
public static class _DecoderReplacementFallback
{
    
public static IObservable<System.Text.DecoderFallbackBuffer> CreateFallbackBuffer(this IObservable<System.Text.DecoderReplacementFallback> DecoderReplacementFallbackValue)
{
    return Observable.Select(DecoderReplacementFallbackValue, (DecoderReplacementFallbackValueLambda) => DecoderReplacementFallbackValueLambda.CreateFallbackBuffer());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Text.DecoderReplacementFallback> DecoderReplacementFallbackValue, IObservable<System.Object> value)
{
    return Observable.Zip(DecoderReplacementFallbackValue, value, (DecoderReplacementFallbackValueLambda, valueLambda) => DecoderReplacementFallbackValueLambda.Equals(valueLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Text.DecoderReplacementFallback> DecoderReplacementFallbackValue)
{
    return Observable.Select(DecoderReplacementFallbackValue, (DecoderReplacementFallbackValueLambda) => DecoderReplacementFallbackValueLambda.GetHashCode());
}


public static IObservable<System.String> get_DefaultString(this IObservable<System.Text.DecoderReplacementFallback> DecoderReplacementFallbackValue)
{
    return Observable.Select(DecoderReplacementFallbackValue, (DecoderReplacementFallbackValueLambda) => DecoderReplacementFallbackValueLambda.DefaultString);
}


public static IObservable<System.Int32> get_MaxCharCount(this IObservable<System.Text.DecoderReplacementFallback> DecoderReplacementFallbackValue)
{
    return Observable.Select(DecoderReplacementFallbackValue, (DecoderReplacementFallbackValueLambda) => DecoderReplacementFallbackValueLambda.MaxCharCount);
}

}
}