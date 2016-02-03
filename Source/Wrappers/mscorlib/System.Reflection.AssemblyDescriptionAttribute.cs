using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _AssemblyDescriptionAttribute
{
    
public static IObservable<System.String> get_Description(this IObservable<System.Reflection.AssemblyDescriptionAttribute> AssemblyDescriptionAttributeValue)
{
    return Observable.Select(AssemblyDescriptionAttributeValue, (AssemblyDescriptionAttributeValueLambda) => AssemblyDescriptionAttributeValueLambda.Description);
}

}
}