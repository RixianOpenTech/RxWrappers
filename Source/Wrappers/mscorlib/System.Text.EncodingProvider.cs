using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
public static class _EncodingProvider
{
    
public static IObservable<System.Text.Encoding> GetEncoding(this IObservable<System.Text.EncodingProvider> EncodingProviderValue, IObservable<System.String> name)
{
    return Observable.Zip(EncodingProviderValue, name, (EncodingProviderValueLambda, nameLambda) => EncodingProviderValueLambda.GetEncoding(nameLambda));
}


public static IObservable<System.Text.Encoding> GetEncoding(this IObservable<System.Text.EncodingProvider> EncodingProviderValue, IObservable<System.Int32> codepage)
{
    return Observable.Zip(EncodingProviderValue, codepage, (EncodingProviderValueLambda, codepageLambda) => EncodingProviderValueLambda.GetEncoding(codepageLambda));
}


public static IObservable<System.Text.Encoding> GetEncoding(this IObservable<System.Text.EncodingProvider> EncodingProviderValue, IObservable<System.String> name, IObservable<System.Text.EncoderFallback> encoderFallback, IObservable<System.Text.DecoderFallback> decoderFallback)
{
    return Observable.Zip(EncodingProviderValue, name, encoderFallback, decoderFallback, (EncodingProviderValueLambda, nameLambda, encoderFallbackLambda, decoderFallbackLambda) => EncodingProviderValueLambda.GetEncoding(nameLambda, encoderFallbackLambda, decoderFallbackLambda));
}


public static IObservable<System.Text.Encoding> GetEncoding(this IObservable<System.Text.EncodingProvider> EncodingProviderValue, IObservable<System.Int32> codepage, IObservable<System.Text.EncoderFallback> encoderFallback, IObservable<System.Text.DecoderFallback> decoderFallback)
{
    return Observable.Zip(EncodingProviderValue, codepage, encoderFallback, decoderFallback, (EncodingProviderValueLambda, codepageLambda, encoderFallbackLambda, decoderFallbackLambda) => EncodingProviderValueLambda.GetEncoding(codepageLambda, encoderFallbackLambda, decoderFallbackLambda));
}

}
}