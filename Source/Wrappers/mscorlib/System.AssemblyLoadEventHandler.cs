using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __AssemblyLoadEventHandler
    {
        
        public static IObservable<System.Reactive.Unit> Invoke(this IObservable<System.AssemblyLoadEventHandler> AssemblyLoadEventHandlerValue, IObservable<System.Object> sender, IObservable<System.AssemblyLoadEventArgs> args)
        {
            return ObservableExt.ZipExecute(AssemblyLoadEventHandlerValue, sender, args, (AssemblyLoadEventHandlerValueLambda, senderLambda, argsLambda) => AssemblyLoadEventHandlerValueLambda.Invoke(senderLambda, argsLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke(this IObservable<System.AssemblyLoadEventHandler> AssemblyLoadEventHandlerValue, IObservable<System.Object> sender, IObservable<System.AssemblyLoadEventArgs> args, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(AssemblyLoadEventHandlerValue, sender, args, callback, @object, (AssemblyLoadEventHandlerValueLambda, senderLambda, argsLambda, callbackLambda, @objectLambda) => AssemblyLoadEventHandlerValueLambda.BeginInvoke(senderLambda, argsLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Reactive.Unit> EndInvoke(this IObservable<System.AssemblyLoadEventHandler> AssemblyLoadEventHandlerValue, IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(AssemblyLoadEventHandlerValue, result, (AssemblyLoadEventHandlerValueLambda, resultLambda) => AssemblyLoadEventHandlerValueLambda.EndInvoke(resultLambda));
        }

    }
}