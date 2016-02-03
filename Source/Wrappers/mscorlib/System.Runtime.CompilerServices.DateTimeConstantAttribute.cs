using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
public static class _DateTimeConstantAttribute
{
    
public static IObservable<System.Object> get_Value(this IObservable<System.Runtime.CompilerServices.DateTimeConstantAttribute> DateTimeConstantAttributeValue)
{
    return Observable.Select(DateTimeConstantAttributeValue, (DateTimeConstantAttributeValueLambda) => DateTimeConstantAttributeValueLambda.Value);
}

}
}