using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
public static class _FormattableStringFactory
{
    
public static IObservable<System.FormattableString> Create(IObservable<System.String> format, IObservable<System.Object[]> arguments)
{
    return Observable.Zip(format, arguments, (formatLambda, argumentsLambda) => System.Runtime.CompilerServices.FormattableStringFactory.Create(formatLambda, argumentsLambda));
}

}
}