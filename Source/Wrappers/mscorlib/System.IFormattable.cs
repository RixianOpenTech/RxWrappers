using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _IFormattable
{
    
public static IObservable<System.String> ToString(this IObservable<System.IFormattable> IFormattableValue, IObservable<System.String> format, IObservable<System.IFormatProvider> formatProvider)
{
    return Observable.Zip(IFormattableValue, format, formatProvider, (IFormattableValueLambda, formatLambda, formatProviderLambda) => IFormattableValueLambda.ToString(formatLambda, formatProviderLambda));
}

}
}