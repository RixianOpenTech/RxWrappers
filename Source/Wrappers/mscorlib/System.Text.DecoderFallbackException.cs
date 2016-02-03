using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
public static class _DecoderFallbackException
{
    
public static IObservable<System.Byte[]> get_BytesUnknown(this IObservable<System.Text.DecoderFallbackException> DecoderFallbackExceptionValue)
{
    return Observable.Select(DecoderFallbackExceptionValue, (DecoderFallbackExceptionValueLambda) => DecoderFallbackExceptionValueLambda.BytesUnknown);
}


public static IObservable<System.Int32> get_Index(this IObservable<System.Text.DecoderFallbackException> DecoderFallbackExceptionValue)
{
    return Observable.Select(DecoderFallbackExceptionValue, (DecoderFallbackExceptionValueLambda) => DecoderFallbackExceptionValueLambda.Index);
}

}
}