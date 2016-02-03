using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _AssemblyKeyFileAttribute
{
    
public static IObservable<System.String> get_KeyFile(this IObservable<System.Reflection.AssemblyKeyFileAttribute> AssemblyKeyFileAttributeValue)
{
    return Observable.Select(AssemblyKeyFileAttributeValue, (AssemblyKeyFileAttributeValueLambda) => AssemblyKeyFileAttributeValueLambda.KeyFile);
}

}
}