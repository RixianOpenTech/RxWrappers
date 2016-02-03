using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _AssemblyDelaySignAttribute
{
    
public static IObservable<System.Boolean> get_DelaySign(this IObservable<System.Reflection.AssemblyDelaySignAttribute> AssemblyDelaySignAttributeValue)
{
    return Observable.Select(AssemblyDelaySignAttributeValue, (AssemblyDelaySignAttributeValueLambda) => AssemblyDelaySignAttributeValueLambda.DelaySign);
}

}
}