using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __ArgumentException
    {
        public static IObservable<System.Reactive.Unit> GetObjectData(
            this IObservable<System.ArgumentException> ArgumentExceptionValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(ArgumentExceptionValue, info, context,
                (ArgumentExceptionValueLambda, infoLambda, contextLambda) =>
                    ArgumentExceptionValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.String> get_Message(
            this IObservable<System.ArgumentException> ArgumentExceptionValue)
        {
            return Observable.Select(ArgumentExceptionValue,
                (ArgumentExceptionValueLambda) => ArgumentExceptionValueLambda.Message);
        }


        public static IObservable<System.String> get_ParamName(
            this IObservable<System.ArgumentException> ArgumentExceptionValue)
        {
            return Observable.Select(ArgumentExceptionValue,
                (ArgumentExceptionValueLambda) => ArgumentExceptionValueLambda.ParamName);
        }
    }
}