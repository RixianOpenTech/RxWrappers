using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
public static class _AccessedThroughPropertyAttribute
{
    
public static IObservable<System.String> get_PropertyName(this IObservable<System.Runtime.CompilerServices.AccessedThroughPropertyAttribute> AccessedThroughPropertyAttributeValue)
{
    return Observable.Select(AccessedThroughPropertyAttributeValue, (AccessedThroughPropertyAttributeValueLambda) => AccessedThroughPropertyAttributeValueLambda.PropertyName);
}

}
}