using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Contexts
{
public static class _IDynamicProperty
{
    
public static IObservable<System.String> get_Name(this IObservable<System.Runtime.Remoting.Contexts.IDynamicProperty> IDynamicPropertyValue)
{
    return Observable.Select(IDynamicPropertyValue, (IDynamicPropertyValueLambda) => IDynamicPropertyValueLambda.Name);
}

}
}