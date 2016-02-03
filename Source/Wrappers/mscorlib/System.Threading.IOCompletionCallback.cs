using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __IOCompletionCallback
    {
        public static IObservable<System.Reactive.Unit> EndInvoke(
            this IObservable<System.Threading.IOCompletionCallback> IOCompletionCallbackValue,
            IObservable<System.IAsyncResult> result)
        {
            return ObservableExt.ZipExecute(IOCompletionCallbackValue, result,
                (IOCompletionCallbackValueLambda, resultLambda) =>
                    IOCompletionCallbackValueLambda.EndInvoke(resultLambda));
        }
    }
}