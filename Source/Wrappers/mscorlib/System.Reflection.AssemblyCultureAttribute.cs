using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _AssemblyCultureAttribute
{
    
public static IObservable<System.String> get_Culture(this IObservable<System.Reflection.AssemblyCultureAttribute> AssemblyCultureAttributeValue)
{
    return Observable.Select(AssemblyCultureAttributeValue, (AssemblyCultureAttributeValueLambda) => AssemblyCultureAttributeValueLambda.Culture);
}

}
}