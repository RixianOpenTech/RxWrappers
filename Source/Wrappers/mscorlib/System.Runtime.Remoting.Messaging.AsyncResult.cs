using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
    public static class __AsyncResult
    {
        
        public static IObservable<System.Runtime.Remoting.Messaging.IMessage> SyncProcessMessage(this IObservable<System.Runtime.Remoting.Messaging.AsyncResult> AsyncResultValue, IObservable<System.Runtime.Remoting.Messaging.IMessage> msg)
        {
            return Observable.Zip(AsyncResultValue, msg, (AsyncResultValueLambda, msgLambda) => AsyncResultValueLambda.SyncProcessMessage(msgLambda));
        }


        public static IObservable<System.Reactive.Unit> SetMessageCtrl(this IObservable<System.Runtime.Remoting.Messaging.AsyncResult> AsyncResultValue, IObservable<System.Runtime.Remoting.Messaging.IMessageCtrl> mc)
        {
            return ObservableExt.ZipExecute(AsyncResultValue, mc, (AsyncResultValueLambda, mcLambda) => AsyncResultValueLambda.SetMessageCtrl(mcLambda));
        }


        public static IObservable<System.Runtime.Remoting.Messaging.IMessageCtrl> AsyncProcessMessage(this IObservable<System.Runtime.Remoting.Messaging.AsyncResult> AsyncResultValue, IObservable<System.Runtime.Remoting.Messaging.IMessage> msg, IObservable<System.Runtime.Remoting.Messaging.IMessageSink> replySink)
        {
            return Observable.Zip(AsyncResultValue, msg, replySink, (AsyncResultValueLambda, msgLambda, replySinkLambda) => AsyncResultValueLambda.AsyncProcessMessage(msgLambda, replySinkLambda));
        }


        public static IObservable<System.Runtime.Remoting.Messaging.IMessage> GetReplyMessage(this IObservable<System.Runtime.Remoting.Messaging.AsyncResult> AsyncResultValue)
        {
            return Observable.Select(AsyncResultValue, (AsyncResultValueLambda) => AsyncResultValueLambda.GetReplyMessage());
        }


        public static IObservable<System.Boolean> get_IsCompleted(this IObservable<System.Runtime.Remoting.Messaging.AsyncResult> AsyncResultValue)
        {
            return Observable.Select(AsyncResultValue, (AsyncResultValueLambda) => AsyncResultValueLambda.IsCompleted);
        }


        public static IObservable<System.Object> get_AsyncDelegate(this IObservable<System.Runtime.Remoting.Messaging.AsyncResult> AsyncResultValue)
        {
            return Observable.Select(AsyncResultValue, (AsyncResultValueLambda) => AsyncResultValueLambda.AsyncDelegate);
        }


        public static IObservable<System.Object> get_AsyncState(this IObservable<System.Runtime.Remoting.Messaging.AsyncResult> AsyncResultValue)
        {
            return Observable.Select(AsyncResultValue, (AsyncResultValueLambda) => AsyncResultValueLambda.AsyncState);
        }


        public static IObservable<System.Boolean> get_CompletedSynchronously(this IObservable<System.Runtime.Remoting.Messaging.AsyncResult> AsyncResultValue)
        {
            return Observable.Select(AsyncResultValue, (AsyncResultValueLambda) => AsyncResultValueLambda.CompletedSynchronously);
        }


        public static IObservable<System.Boolean> get_EndInvokeCalled(this IObservable<System.Runtime.Remoting.Messaging.AsyncResult> AsyncResultValue)
        {
            return Observable.Select(AsyncResultValue, (AsyncResultValueLambda) => AsyncResultValueLambda.EndInvokeCalled);
        }


        public static IObservable<System.Threading.WaitHandle> get_AsyncWaitHandle(this IObservable<System.Runtime.Remoting.Messaging.AsyncResult> AsyncResultValue)
        {
            return Observable.Select(AsyncResultValue, (AsyncResultValueLambda) => AsyncResultValueLambda.AsyncWaitHandle);
        }


        public static IObservable<System.Runtime.Remoting.Messaging.IMessageSink> get_NextSink(this IObservable<System.Runtime.Remoting.Messaging.AsyncResult> AsyncResultValue)
        {
            return Observable.Select(AsyncResultValue, (AsyncResultValueLambda) => AsyncResultValueLambda.NextSink);
        }


        public static IObservable<System.Reactive.Unit> set_EndInvokeCalled(this IObservable<System.Runtime.Remoting.Messaging.AsyncResult> AsyncResultValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(AsyncResultValue, value, (AsyncResultValueLambda, valueLambda) => AsyncResultValueLambda.EndInvokeCalled = valueLambda);
        }

    }
}