using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __UnhandledExceptionEventHandler
    {
        public static IObservable<System.Reactive.Unit> Invoke(
            this IObservable<System.UnhandledExceptionEventHandler> UnhandledExceptionEventHandlerValue,
            IObservable<System.Object> sender, IObservable<System.UnhandledExceptionEventArgs> e)
        {
            return ObservableExt.ZipExecute(UnhandledExceptionEventHandlerValue, sender, e,
                (UnhandledExceptionEventHandlerValueLambda, senderLambda, eLambda) =>
                    UnhandledExceptionEventHandlerValueLambda.Invoke(senderLambda, eLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(
            this IObservable<System.UnhandledExceptionEventHandler> UnhandledExceptionEventHandlerValue,
            IObservable<System.Object> sender, IObservable<System.UnhandledExceptionEventArgs> e,
            IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(UnhandledExceptionEventHandlerValue, sender, e, callback, @object,
                (UnhandledExceptionEventHandlerValueLambda, senderLambda, eLambda, callbackLambda, @objectLambda) =>
                    UnhandledExceptionEventHandlerValueLambda.BeginInvoke(senderLambda, eLambda, callbackLambda,
                        @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke(
            this IObservable<System.UnhandledExceptionEventHandler> UnhandledExceptionEventHandlerValue,
            IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(UnhandledExceptionEventHandlerValue, result,
                (UnhandledExceptionEventHandlerValueLambda, resultLambda) =>
                    UnhandledExceptionEventHandlerValueLambda.EndInvoke(resultLambda));
        }
    }
}