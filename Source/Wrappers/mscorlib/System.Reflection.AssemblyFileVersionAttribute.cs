using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _AssemblyFileVersionAttribute
{
    
public static IObservable<System.String> get_Version(this IObservable<System.Reflection.AssemblyFileVersionAttribute> AssemblyFileVersionAttributeValue)
{
    return Observable.Select(AssemblyFileVersionAttributeValue, (AssemblyFileVersionAttributeValueLambda) => AssemblyFileVersionAttributeValueLambda.Version);
}

}
}