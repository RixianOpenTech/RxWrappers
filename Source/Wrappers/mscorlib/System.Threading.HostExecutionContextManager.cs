using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __HostExecutionContextManager
    {
        public static IObservable<System.Reactive.Unit> Revert(
            this IObservable<System.Threading.HostExecutionContextManager> HostExecutionContextManagerValue,
            IObservable<System.Object> previousState)
        {
            return ObservableExt.ZipExecute(HostExecutionContextManagerValue, previousState,
                (HostExecutionContextManagerValueLambda, previousStateLambda) =>
                    HostExecutionContextManagerValueLambda.Revert(previousStateLambda));
        }


        public static IObservable<System.Threading.HostExecutionContext> Capture(
            this IObservable<System.Threading.HostExecutionContextManager> HostExecutionContextManagerValue)
        {
            return Observable.Select(HostExecutionContextManagerValue,
                (HostExecutionContextManagerValueLambda) => HostExecutionContextManagerValueLambda.Capture());
        }


        public static IObservable<System.Object> SetHostExecutionContext(
            this IObservable<System.Threading.HostExecutionContextManager> HostExecutionContextManagerValue,
            IObservable<System.Threading.HostExecutionContext> hostExecutionContext)
        {
            return Observable.Zip(HostExecutionContextManagerValue, hostExecutionContext,
                (HostExecutionContextManagerValueLambda, hostExecutionContextLambda) =>
                    HostExecutionContextManagerValueLambda.SetHostExecutionContext(hostExecutionContextLambda));
        }
    }
}