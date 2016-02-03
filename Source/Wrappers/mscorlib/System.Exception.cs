using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Exception
    {
        public static IObservable<System.Exception> GetBaseException(this IObservable<System.Exception> ExceptionValue)
        {
            return Observable.Select(ExceptionValue, (ExceptionValueLambda) => ExceptionValueLambda.GetBaseException());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Exception> ExceptionValue)
        {
            return Observable.Select(ExceptionValue, (ExceptionValueLambda) => ExceptionValueLambda.ToString());
        }


        public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.Exception> ExceptionValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(ExceptionValue, info, context,
                (ExceptionValueLambda, infoLambda, contextLambda) =>
                    ExceptionValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.Type> GetType(this IObservable<System.Exception> ExceptionValue)
        {
            return Observable.Select(ExceptionValue, (ExceptionValueLambda) => ExceptionValueLambda.GetType());
        }


        public static IObservable<System.String> get_Message(this IObservable<System.Exception> ExceptionValue)
        {
            return Observable.Select(ExceptionValue, (ExceptionValueLambda) => ExceptionValueLambda.Message);
        }


        public static IObservable<System.Collections.IDictionary> get_Data(
            this IObservable<System.Exception> ExceptionValue)
        {
            return Observable.Select(ExceptionValue, (ExceptionValueLambda) => ExceptionValueLambda.Data);
        }


        public static IObservable<System.Exception> get_InnerException(this IObservable<System.Exception> ExceptionValue)
        {
            return Observable.Select(ExceptionValue, (ExceptionValueLambda) => ExceptionValueLambda.InnerException);
        }


        public static IObservable<System.Reflection.MethodBase> get_TargetSite(
            this IObservable<System.Exception> ExceptionValue)
        {
            return Observable.Select(ExceptionValue, (ExceptionValueLambda) => ExceptionValueLambda.TargetSite);
        }


        public static IObservable<System.String> get_StackTrace(this IObservable<System.Exception> ExceptionValue)
        {
            return Observable.Select(ExceptionValue, (ExceptionValueLambda) => ExceptionValueLambda.StackTrace);
        }


        public static IObservable<System.String> get_HelpLink(this IObservable<System.Exception> ExceptionValue)
        {
            return Observable.Select(ExceptionValue, (ExceptionValueLambda) => ExceptionValueLambda.HelpLink);
        }


        public static IObservable<System.String> get_Source(this IObservable<System.Exception> ExceptionValue)
        {
            return Observable.Select(ExceptionValue, (ExceptionValueLambda) => ExceptionValueLambda.Source);
        }


        public static IObservable<System.Int32> get_HResult(this IObservable<System.Exception> ExceptionValue)
        {
            return Observable.Select(ExceptionValue, (ExceptionValueLambda) => ExceptionValueLambda.HResult);
        }


        public static IObservable<System.Reactive.Unit> set_HelpLink(this IObservable<System.Exception> ExceptionValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(ExceptionValue, value,
                (ExceptionValueLambda, valueLambda) => ExceptionValueLambda.HelpLink = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Source(this IObservable<System.Exception> ExceptionValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(ExceptionValue, value,
                (ExceptionValueLambda, valueLambda) => ExceptionValueLambda.Source = valueLambda);
        }
    }
}