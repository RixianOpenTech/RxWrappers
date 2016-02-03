using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
public static class _DefaultDependencyAttribute
{
    
public static IObservable<System.Runtime.CompilerServices.LoadHint> get_LoadHint(this IObservable<System.Runtime.CompilerServices.DefaultDependencyAttribute> DefaultDependencyAttributeValue)
{
    return Observable.Select(DefaultDependencyAttributeValue, (DefaultDependencyAttributeValueLambda) => DefaultDependencyAttributeValueLambda.LoadHint);
}

}
}