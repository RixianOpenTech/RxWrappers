using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
public static class _TypeForwardedToAttribute
{
    
public static IObservable<System.Type> get_Destination(this IObservable<System.Runtime.CompilerServices.TypeForwardedToAttribute> TypeForwardedToAttributeValue)
{
    return Observable.Select(TypeForwardedToAttributeValue, (TypeForwardedToAttributeValueLambda) => TypeForwardedToAttributeValueLambda.Destination);
}

}
}