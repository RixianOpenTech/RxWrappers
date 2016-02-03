using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
public static class _RuntimeCompatibilityAttribute
{
    
public static IObservable<System.Boolean> get_WrapNonExceptionThrows(this IObservable<System.Runtime.CompilerServices.RuntimeCompatibilityAttribute> RuntimeCompatibilityAttributeValue)
{
    return Observable.Select(RuntimeCompatibilityAttributeValue, (RuntimeCompatibilityAttributeValueLambda) => RuntimeCompatibilityAttributeValueLambda.WrapNonExceptionThrows);
}


public static IObservable<System.Reactive.Unit> set_WrapNonExceptionThrows(this IObservable<System.Runtime.CompilerServices.RuntimeCompatibilityAttribute> RuntimeCompatibilityAttributeValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(RuntimeCompatibilityAttributeValue, value, (RuntimeCompatibilityAttributeValueLambda, valueLambda) => RuntimeCompatibilityAttributeValueLambda.WrapNonExceptionThrows = valueLambda);
}

}
}