using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting
{
public static class _ObjectHandle
{
    
public static IObservable<System.Object> Unwrap(this IObservable<System.Runtime.Remoting.ObjectHandle> ObjectHandleValue)
{
    return Observable.Select(ObjectHandleValue, (ObjectHandleValueLambda) => ObjectHandleValueLambda.Unwrap());
}


public static IObservable<System.Object> InitializeLifetimeService(this IObservable<System.Runtime.Remoting.ObjectHandle> ObjectHandleValue)
{
    return Observable.Select(ObjectHandleValue, (ObjectHandleValueLambda) => ObjectHandleValueLambda.InitializeLifetimeService());
}

}
}