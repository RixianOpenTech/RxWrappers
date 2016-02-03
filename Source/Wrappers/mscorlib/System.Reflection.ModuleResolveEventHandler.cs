using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _ModuleResolveEventHandler
{
    
public static IObservable<System.Reflection.Module> Invoke(this IObservable<System.Reflection.ModuleResolveEventHandler> ModuleResolveEventHandlerValue, IObservable<System.Object> sender, IObservable<System.ResolveEventArgs> e)
{
    return Observable.Zip(ModuleResolveEventHandlerValue, sender, e, (ModuleResolveEventHandlerValueLambda, senderLambda, eLambda) => ModuleResolveEventHandlerValueLambda.Invoke(senderLambda, eLambda));
}


public static IObservable<System.IAsyncResult> BeginInvoke(this IObservable<System.Reflection.ModuleResolveEventHandler> ModuleResolveEventHandlerValue, IObservable<System.Object> sender, IObservable<System.ResolveEventArgs> e, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
{
    return Observable.Zip(ModuleResolveEventHandlerValue, sender, e, callback, @object, (ModuleResolveEventHandlerValueLambda, senderLambda, eLambda, callbackLambda, @objectLambda) => ModuleResolveEventHandlerValueLambda.BeginInvoke(senderLambda, eLambda, callbackLambda, @objectLambda));
}


public static IObservable<System.Reflection.Module> EndInvoke(this IObservable<System.Reflection.ModuleResolveEventHandler> ModuleResolveEventHandlerValue, IObservable<System.IAsyncResult> result)
{
    return Observable.Zip(ModuleResolveEventHandlerValue, result, (ModuleResolveEventHandlerValueLambda, resultLambda) => ModuleResolveEventHandlerValueLambda.EndInvoke(resultLambda));
}

}
}