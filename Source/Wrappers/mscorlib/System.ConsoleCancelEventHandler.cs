using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __ConsoleCancelEventHandler
    {
        
        public static IObservable<System.Reactive.Unit> Invoke(this IObservable<System.ConsoleCancelEventHandler> ConsoleCancelEventHandlerValue, IObservable<System.Object> sender, IObservable<System.ConsoleCancelEventArgs> e)
        {
            return ObservableExt.ZipExecute(ConsoleCancelEventHandlerValue, sender, e, (ConsoleCancelEventHandlerValueLambda, senderLambda, eLambda) => ConsoleCancelEventHandlerValueLambda.Invoke(senderLambda, eLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(this IObservable<System.ConsoleCancelEventHandler> ConsoleCancelEventHandlerValue, IObservable<System.Object> sender, IObservable<System.ConsoleCancelEventArgs> e, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(ConsoleCancelEventHandlerValue, sender, e, callback, @object, (ConsoleCancelEventHandlerValueLambda, senderLambda, eLambda, callbackLambda, @objectLambda) => ConsoleCancelEventHandlerValueLambda.BeginInvoke(senderLambda, eLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke(this IObservable<System.ConsoleCancelEventHandler> ConsoleCancelEventHandlerValue, IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(ConsoleCancelEventHandlerValue, result, (ConsoleCancelEventHandlerValueLambda, resultLambda) => ConsoleCancelEventHandlerValueLambda.EndInvoke(resultLambda));
        }

    }
}