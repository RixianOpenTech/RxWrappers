using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __AsyncFlowControl
    {
        public static IObservable<System.Reactive.Unit> Undo(
            this IObservable<System.Threading.AsyncFlowControl> AsyncFlowControlValue)
        {
            return
                Observable.Do(AsyncFlowControlValue, (AsyncFlowControlValueLambda) => AsyncFlowControlValueLambda.Undo())
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Dispose(
            this IObservable<System.Threading.AsyncFlowControl> AsyncFlowControlValue)
        {
            return
                Observable.Do(AsyncFlowControlValue,
                    (AsyncFlowControlValueLambda) => AsyncFlowControlValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Threading.AsyncFlowControl> AsyncFlowControlValue)
        {
            return Observable.Select(AsyncFlowControlValue,
                (AsyncFlowControlValueLambda) => AsyncFlowControlValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Threading.AsyncFlowControl> AsyncFlowControlValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(AsyncFlowControlValue, obj,
                (AsyncFlowControlValueLambda, objLambda) => AsyncFlowControlValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Threading.AsyncFlowControl> AsyncFlowControlValue,
            IObservable<System.Threading.AsyncFlowControl> obj)
        {
            return Observable.Zip(AsyncFlowControlValue, obj,
                (AsyncFlowControlValueLambda, objLambda) => AsyncFlowControlValueLambda.Equals(objLambda));
        }
    }
}