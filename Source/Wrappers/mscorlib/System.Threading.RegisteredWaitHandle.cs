using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __RegisteredWaitHandle
    {
        public static IObservable<System.Boolean> Unregister(
            this IObservable<System.Threading.RegisteredWaitHandle> RegisteredWaitHandleValue,
            IObservable<System.Threading.WaitHandle> waitObject)
        {
            return Observable.Zip(RegisteredWaitHandleValue, waitObject,
                (RegisteredWaitHandleValueLambda, waitObjectLambda) =>
                    RegisteredWaitHandleValueLambda.Unregister(waitObjectLambda));
        }
    }
}