using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics
{
public static class _DebuggableAttribute
{
    
public static IObservable<System.Boolean> get_IsJITTrackingEnabled(this IObservable<System.Diagnostics.DebuggableAttribute> DebuggableAttributeValue)
{
    return Observable.Select(DebuggableAttributeValue, (DebuggableAttributeValueLambda) => DebuggableAttributeValueLambda.IsJITTrackingEnabled);
}


public static IObservable<System.Boolean> get_IsJITOptimizerDisabled(this IObservable<System.Diagnostics.DebuggableAttribute> DebuggableAttributeValue)
{
    return Observable.Select(DebuggableAttributeValue, (DebuggableAttributeValueLambda) => DebuggableAttributeValueLambda.IsJITOptimizerDisabled);
}


public static IObservable<System.Diagnostics.DebuggableAttribute.DebuggingModes> get_DebuggingFlags(this IObservable<System.Diagnostics.DebuggableAttribute> DebuggableAttributeValue)
{
    return Observable.Select(DebuggableAttributeValue, (DebuggableAttributeValueLambda) => DebuggableAttributeValueLambda.DebuggingFlags);
}

}
}