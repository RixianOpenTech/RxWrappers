using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __ExceptionHandlingClause
    {
        public static IObservable<System.String> ToString(
            this IObservable<System.Reflection.ExceptionHandlingClause> ExceptionHandlingClauseValue)
        {
            return Observable.Select(ExceptionHandlingClauseValue,
                (ExceptionHandlingClauseValueLambda) => ExceptionHandlingClauseValueLambda.ToString());
        }


        public static IObservable<System.Reflection.ExceptionHandlingClauseOptions> get_Flags(
            this IObservable<System.Reflection.ExceptionHandlingClause> ExceptionHandlingClauseValue)
        {
            return Observable.Select(ExceptionHandlingClauseValue,
                (ExceptionHandlingClauseValueLambda) => ExceptionHandlingClauseValueLambda.Flags);
        }


        public static IObservable<System.Int32> get_TryOffset(
            this IObservable<System.Reflection.ExceptionHandlingClause> ExceptionHandlingClauseValue)
        {
            return Observable.Select(ExceptionHandlingClauseValue,
                (ExceptionHandlingClauseValueLambda) => ExceptionHandlingClauseValueLambda.TryOffset);
        }


        public static IObservable<System.Int32> get_TryLength(
            this IObservable<System.Reflection.ExceptionHandlingClause> ExceptionHandlingClauseValue)
        {
            return Observable.Select(ExceptionHandlingClauseValue,
                (ExceptionHandlingClauseValueLambda) => ExceptionHandlingClauseValueLambda.TryLength);
        }


        public static IObservable<System.Int32> get_HandlerOffset(
            this IObservable<System.Reflection.ExceptionHandlingClause> ExceptionHandlingClauseValue)
        {
            return Observable.Select(ExceptionHandlingClauseValue,
                (ExceptionHandlingClauseValueLambda) => ExceptionHandlingClauseValueLambda.HandlerOffset);
        }


        public static IObservable<System.Int32> get_HandlerLength(
            this IObservable<System.Reflection.ExceptionHandlingClause> ExceptionHandlingClauseValue)
        {
            return Observable.Select(ExceptionHandlingClauseValue,
                (ExceptionHandlingClauseValueLambda) => ExceptionHandlingClauseValueLambda.HandlerLength);
        }


        public static IObservable<System.Int32> get_FilterOffset(
            this IObservable<System.Reflection.ExceptionHandlingClause> ExceptionHandlingClauseValue)
        {
            return Observable.Select(ExceptionHandlingClauseValue,
                (ExceptionHandlingClauseValueLambda) => ExceptionHandlingClauseValueLambda.FilterOffset);
        }


        public static IObservable<System.Type> get_CatchType(
            this IObservable<System.Reflection.ExceptionHandlingClause> ExceptionHandlingClauseValue)
        {
            return Observable.Select(ExceptionHandlingClauseValue,
                (ExceptionHandlingClauseValueLambda) => ExceptionHandlingClauseValueLambda.CatchType);
        }
    }
}