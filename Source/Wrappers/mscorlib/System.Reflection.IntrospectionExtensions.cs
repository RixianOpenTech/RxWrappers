using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _IntrospectionExtensions
{
    
public static IObservable<System.Reflection.TypeInfo> GetTypeInfo(IObservable<System.Type> type)
{
    return Observable.Select(type, (typeLambda) => System.Reflection.IntrospectionExtensions.GetTypeInfo(typeLambda));
}

}
}