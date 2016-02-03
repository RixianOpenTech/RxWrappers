using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __ExecutionContext
    {
        public static IObservable<System.Reactive.Unit> Dispose(
            this IObservable<System.Threading.ExecutionContext> ExecutionContextValue)
        {
            return
                Observable.Do(ExecutionContextValue,
                    (ExecutionContextValueLambda) => ExecutionContextValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Run(
            IObservable<System.Threading.ExecutionContext> executionContext,
            IObservable<System.Threading.ContextCallback> callback, IObservable<System.Object> state)
        {
            return ObservableExt.ZipExecute(executionContext, callback, state,
                (executionContextLambda, callbackLambda, stateLambda) =>
                    System.Threading.ExecutionContext.Run(executionContextLambda, callbackLambda, stateLambda));
        }


        public static IObservable<System.Threading.ExecutionContext> CreateCopy(
            this IObservable<System.Threading.ExecutionContext> ExecutionContextValue)
        {
            return Observable.Select(ExecutionContextValue,
                (ExecutionContextValueLambda) => ExecutionContextValueLambda.CreateCopy());
        }


        public static IObservable<System.Threading.AsyncFlowControl> SuppressFlow()
        {
            return ObservableExt.Factory(() => System.Threading.ExecutionContext.SuppressFlow());
        }


        public static IObservable<System.Reactive.Unit> RestoreFlow()
        {
            return ObservableExt.Factory(() => System.Threading.ExecutionContext.RestoreFlow());
        }


        public static IObservable<System.Boolean> IsFlowSuppressed()
        {
            return ObservableExt.Factory(() => System.Threading.ExecutionContext.IsFlowSuppressed());
        }


        public static IObservable<System.Threading.ExecutionContext> Capture()
        {
            return ObservableExt.Factory(() => System.Threading.ExecutionContext.Capture());
        }


        public static IObservable<System.Reactive.Unit> GetObjectData(
            this IObservable<System.Threading.ExecutionContext> ExecutionContextValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(ExecutionContextValue, info, context,
                (ExecutionContextValueLambda, infoLambda, contextLambda) =>
                    ExecutionContextValueLambda.GetObjectData(infoLambda, contextLambda));
        }
    }
}