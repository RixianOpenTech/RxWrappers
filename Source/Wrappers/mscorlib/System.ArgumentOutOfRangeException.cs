using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __ArgumentOutOfRangeException
    {
        public static IObservable<System.Reactive.Unit> GetObjectData(
            this IObservable<System.ArgumentOutOfRangeException> ArgumentOutOfRangeExceptionValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(ArgumentOutOfRangeExceptionValue, info, context,
                (ArgumentOutOfRangeExceptionValueLambda, infoLambda, contextLambda) =>
                    ArgumentOutOfRangeExceptionValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.String> get_Message(
            this IObservable<System.ArgumentOutOfRangeException> ArgumentOutOfRangeExceptionValue)
        {
            return Observable.Select(ArgumentOutOfRangeExceptionValue,
                (ArgumentOutOfRangeExceptionValueLambda) => ArgumentOutOfRangeExceptionValueLambda.Message);
        }


        public static IObservable<System.Object> get_ActualValue(
            this IObservable<System.ArgumentOutOfRangeException> ArgumentOutOfRangeExceptionValue)
        {
            return Observable.Select(ArgumentOutOfRangeExceptionValue,
                (ArgumentOutOfRangeExceptionValueLambda) => ArgumentOutOfRangeExceptionValueLambda.ActualValue);
        }
    }
}