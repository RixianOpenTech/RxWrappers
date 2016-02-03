using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _ICustomFormatter
{
    
public static IObservable<System.String> Format(this IObservable<System.ICustomFormatter> ICustomFormatterValue, IObservable<System.String> format, IObservable<System.Object> arg, IObservable<System.IFormatProvider> formatProvider)
{
    return Observable.Zip(ICustomFormatterValue, format, arg, formatProvider, (ICustomFormatterValueLambda, formatLambda, argLambda, formatProviderLambda) => ICustomFormatterValueLambda.Format(formatLambda, argLambda, formatProviderLambda));
}

}
}