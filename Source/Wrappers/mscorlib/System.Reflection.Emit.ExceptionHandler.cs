using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
    public static class __ExceptionHandler
    {
        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Reflection.Emit.ExceptionHandler> ExceptionHandlerValue)
        {
            return Observable.Select(ExceptionHandlerValue,
                (ExceptionHandlerValueLambda) => ExceptionHandlerValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Reflection.Emit.ExceptionHandler> ExceptionHandlerValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(ExceptionHandlerValue, obj,
                (ExceptionHandlerValueLambda, objLambda) => ExceptionHandlerValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Reflection.Emit.ExceptionHandler> ExceptionHandlerValue,
            IObservable<System.Reflection.Emit.ExceptionHandler> other)
        {
            return Observable.Zip(ExceptionHandlerValue, other,
                (ExceptionHandlerValueLambda, otherLambda) => ExceptionHandlerValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Int32> get_ExceptionTypeToken(
            this IObservable<System.Reflection.Emit.ExceptionHandler> ExceptionHandlerValue)
        {
            return Observable.Select(ExceptionHandlerValue,
                (ExceptionHandlerValueLambda) => ExceptionHandlerValueLambda.ExceptionTypeToken);
        }


        public static IObservable<System.Int32> get_TryOffset(
            this IObservable<System.Reflection.Emit.ExceptionHandler> ExceptionHandlerValue)
        {
            return Observable.Select(ExceptionHandlerValue,
                (ExceptionHandlerValueLambda) => ExceptionHandlerValueLambda.TryOffset);
        }


        public static IObservable<System.Int32> get_TryLength(
            this IObservable<System.Reflection.Emit.ExceptionHandler> ExceptionHandlerValue)
        {
            return Observable.Select(ExceptionHandlerValue,
                (ExceptionHandlerValueLambda) => ExceptionHandlerValueLambda.TryLength);
        }


        public static IObservable<System.Int32> get_FilterOffset(
            this IObservable<System.Reflection.Emit.ExceptionHandler> ExceptionHandlerValue)
        {
            return Observable.Select(ExceptionHandlerValue,
                (ExceptionHandlerValueLambda) => ExceptionHandlerValueLambda.FilterOffset);
        }


        public static IObservable<System.Int32> get_HandlerOffset(
            this IObservable<System.Reflection.Emit.ExceptionHandler> ExceptionHandlerValue)
        {
            return Observable.Select(ExceptionHandlerValue,
                (ExceptionHandlerValueLambda) => ExceptionHandlerValueLambda.HandlerOffset);
        }


        public static IObservable<System.Int32> get_HandlerLength(
            this IObservable<System.Reflection.Emit.ExceptionHandler> ExceptionHandlerValue)
        {
            return Observable.Select(ExceptionHandlerValue,
                (ExceptionHandlerValueLambda) => ExceptionHandlerValueLambda.HandlerLength);
        }


        public static IObservable<System.Reflection.ExceptionHandlingClauseOptions> get_Kind(
            this IObservable<System.Reflection.Emit.ExceptionHandler> ExceptionHandlerValue)
        {
            return Observable.Select(ExceptionHandlerValue,
                (ExceptionHandlerValueLambda) => ExceptionHandlerValueLambda.Kind);
        }
    }
}