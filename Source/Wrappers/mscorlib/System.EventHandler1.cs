using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __EventHandler1
    {
        public static IObservable<System.Reactive.Unit> Invoke<TEventArgs>(
            this IObservable<System.EventHandler<TEventArgs>> EventHandlerValue, IObservable<System.Object> sender,
            IObservable<TEventArgs> e)
        {
            return ObservableExt.ZipExecute(EventHandlerValue, sender, e,
                (EventHandlerValueLambda, senderLambda, eLambda) =>
                    EventHandlerValueLambda.Invoke(senderLambda, eLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke<TEventArgs>(
            this IObservable<System.EventHandler<TEventArgs>> EventHandlerValue, IObservable<System.Object> sender,
            IObservable<TEventArgs> e, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(EventHandlerValue, sender, e, callback, @object,
                (EventHandlerValueLambda, senderLambda, eLambda, callbackLambda, @objectLambda) =>
                    EventHandlerValueLambda.BeginInvoke(senderLambda, eLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke<TEventArgs>(
            this IObservable<System.EventHandler<TEventArgs>> EventHandlerValue, IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(EventHandlerValue, result,
                (EventHandlerValueLambda, resultLambda) => EventHandlerValueLambda.EndInvoke(resultLambda));
        }
    }
}