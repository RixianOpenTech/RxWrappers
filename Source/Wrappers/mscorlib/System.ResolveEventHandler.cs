using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __ResolveEventHandler
    {
        
        public static IObservable<System.Reflection.Assembly> Invoke(this IObservable<System.ResolveEventHandler> ResolveEventHandlerValue, IObservable<System.Object> sender, IObservable<System.ResolveEventArgs> args)
        {
            return Observable.Zip(ResolveEventHandlerValue, sender, args, (ResolveEventHandlerValueLambda, senderLambda, argsLambda) => ResolveEventHandlerValueLambda.Invoke(senderLambda, argsLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(this IObservable<System.ResolveEventHandler> ResolveEventHandlerValue, IObservable<System.Object> sender, IObservable<System.ResolveEventArgs> args, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(ResolveEventHandlerValue, sender, args, callback, @object, (ResolveEventHandlerValueLambda, senderLambda, argsLambda, callbackLambda, @objectLambda) => ResolveEventHandlerValueLambda.BeginInvoke(senderLambda, argsLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reflection.Assembly> EndInvoke(this IObservable<System.ResolveEventHandler> ResolveEventHandlerValue, IObservable<System.IAsyncResult> result)
        {
            return Observable.Zip(ResolveEventHandlerValue, result, (ResolveEventHandlerValueLambda, resultLambda) => ResolveEventHandlerValueLambda.EndInvoke(resultLambda));
        }

    }
}