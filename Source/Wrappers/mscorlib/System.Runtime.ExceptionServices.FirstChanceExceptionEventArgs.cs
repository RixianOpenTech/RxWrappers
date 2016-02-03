using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.ExceptionServices
{
    public static class __FirstChanceExceptionEventArgs
    {
        public static IObservable<System.Exception> get_Exception(
            this IObservable<System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs>
                FirstChanceExceptionEventArgsValue)
        {
            return Observable.Select(FirstChanceExceptionEventArgsValue,
                (FirstChanceExceptionEventArgsValueLambda) => FirstChanceExceptionEventArgsValueLambda.Exception);
        }
    }
}