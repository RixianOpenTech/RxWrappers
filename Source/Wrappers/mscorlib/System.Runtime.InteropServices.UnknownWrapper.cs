using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _UnknownWrapper
{
    
public static IObservable<System.Object> get_WrappedObject(this IObservable<System.Runtime.InteropServices.UnknownWrapper> UnknownWrapperValue)
{
    return Observable.Select(UnknownWrapperValue, (UnknownWrapperValueLambda) => UnknownWrapperValueLambda.WrappedObject);
}

}
}