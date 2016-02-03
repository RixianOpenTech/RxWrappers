using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _ExtensibleClassFactory
{
    
public static IObservable<System.Reactive.Unit> RegisterObjectCreationCallback(IObservable<System.Runtime.InteropServices.ObjectCreationDelegate> callback)
{
    return Observable.Do(callback, (callbackLambda) => System.Runtime.InteropServices.ExtensibleClassFactory.RegisterObjectCreationCallback(callbackLambda)).ToUnit();
}

}
}