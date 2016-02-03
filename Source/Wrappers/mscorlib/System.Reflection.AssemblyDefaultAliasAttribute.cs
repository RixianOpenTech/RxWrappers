using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _AssemblyDefaultAliasAttribute
{
    
public static IObservable<System.String> get_DefaultAlias(this IObservable<System.Reflection.AssemblyDefaultAliasAttribute> AssemblyDefaultAliasAttributeValue)
{
    return Observable.Select(AssemblyDefaultAliasAttributeValue, (AssemblyDefaultAliasAttributeValueLambda) => AssemblyDefaultAliasAttributeValueLambda.DefaultAlias);
}

}
}