using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _CLSCompliantAttribute
{
    
public static IObservable<System.Boolean> get_IsCompliant(this IObservable<System.CLSCompliantAttribute> CLSCompliantAttributeValue)
{
    return Observable.Select(CLSCompliantAttributeValue, (CLSCompliantAttributeValueLambda) => CLSCompliantAttributeValueLambda.IsCompliant);
}

}
}