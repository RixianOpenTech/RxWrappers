using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Contexts
{
public static class _ContextProperty
{
    
public static IObservable<System.String> get_Name(this IObservable<System.Runtime.Remoting.Contexts.ContextProperty> ContextPropertyValue)
{
    return Observable.Select(ContextPropertyValue, (ContextPropertyValueLambda) => ContextPropertyValueLambda.Name);
}


public static IObservable<System.Object> get_Property(this IObservable<System.Runtime.Remoting.Contexts.ContextProperty> ContextPropertyValue)
{
    return Observable.Select(ContextPropertyValue, (ContextPropertyValueLambda) => ContextPropertyValueLambda.Property);
}

}
}