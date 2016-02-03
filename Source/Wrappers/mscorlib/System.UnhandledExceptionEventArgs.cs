using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __UnhandledExceptionEventArgs
    {
        public static IObservable<System.Object> get_ExceptionObject(
            this IObservable<System.UnhandledExceptionEventArgs> UnhandledExceptionEventArgsValue)
        {
            return Observable.Select(UnhandledExceptionEventArgsValue,
                (UnhandledExceptionEventArgsValueLambda) => UnhandledExceptionEventArgsValueLambda.ExceptionObject);
        }


        public static IObservable<System.Boolean> get_IsTerminating(
            this IObservable<System.UnhandledExceptionEventArgs> UnhandledExceptionEventArgsValue)
        {
            return Observable.Select(UnhandledExceptionEventArgsValue,
                (UnhandledExceptionEventArgsValueLambda) => UnhandledExceptionEventArgsValueLambda.IsTerminating);
        }
    }
}