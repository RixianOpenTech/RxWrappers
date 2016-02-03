using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _ICustomAdapter
{
    
public static IObservable<System.Object> GetUnderlyingObject(this IObservable<System.Runtime.InteropServices.ICustomAdapter> ICustomAdapterValue)
{
    return Observable.Select(ICustomAdapterValue, (ICustomAdapterValueLambda) => ICustomAdapterValueLambda.GetUnderlyingObject());
}

}
}