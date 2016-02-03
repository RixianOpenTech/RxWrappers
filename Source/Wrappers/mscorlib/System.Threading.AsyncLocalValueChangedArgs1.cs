using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __AsyncLocalValueChangedArgs1
    {
        public static IObservable<T> get_PreviousValue<T>(
            this IObservable<System.Threading.AsyncLocalValueChangedArgs<T>> AsyncLocalValueChangedArgsValue)
        {
            return Observable.Select(AsyncLocalValueChangedArgsValue,
                (AsyncLocalValueChangedArgsValueLambda) => AsyncLocalValueChangedArgsValueLambda.PreviousValue);
        }


        public static IObservable<T> get_CurrentValue<T>(
            this IObservable<System.Threading.AsyncLocalValueChangedArgs<T>> AsyncLocalValueChangedArgsValue)
        {
            return Observable.Select(AsyncLocalValueChangedArgsValue,
                (AsyncLocalValueChangedArgsValueLambda) => AsyncLocalValueChangedArgsValueLambda.CurrentValue);
        }


        public static IObservable<System.Boolean> get_ThreadContextChanged<T>(
            this IObservable<System.Threading.AsyncLocalValueChangedArgs<T>> AsyncLocalValueChangedArgsValue)
        {
            return Observable.Select(AsyncLocalValueChangedArgsValue,
                (AsyncLocalValueChangedArgsValueLambda) => AsyncLocalValueChangedArgsValueLambda.ThreadContextChanged);
        }
    }
}