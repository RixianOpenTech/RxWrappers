using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _AssemblyKeyNameAttribute
{
    
public static IObservable<System.String> get_KeyName(this IObservable<System.Reflection.AssemblyKeyNameAttribute> AssemblyKeyNameAttributeValue)
{
    return Observable.Select(AssemblyKeyNameAttributeValue, (AssemblyKeyNameAttributeValueLambda) => AssemblyKeyNameAttributeValueLambda.KeyName);
}

}
}