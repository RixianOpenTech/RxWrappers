using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Versioning
{
public static class _ComponentGuaranteesAttribute
{
    
public static IObservable<System.Runtime.Versioning.ComponentGuaranteesOptions> get_Guarantees(this IObservable<System.Runtime.Versioning.ComponentGuaranteesAttribute> ComponentGuaranteesAttributeValue)
{
    return Observable.Select(ComponentGuaranteesAttributeValue, (ComponentGuaranteesAttributeValueLambda) => ComponentGuaranteesAttributeValueLambda.Guarantees);
}

}
}