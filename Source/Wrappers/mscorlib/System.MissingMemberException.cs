using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __MissingMemberException
    {
        public static IObservable<System.Reactive.Unit> GetObjectData(
            this IObservable<System.MissingMemberException> MissingMemberExceptionValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(MissingMemberExceptionValue, info, context,
                (MissingMemberExceptionValueLambda, infoLambda, contextLambda) =>
                    MissingMemberExceptionValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.String> get_Message(
            this IObservable<System.MissingMemberException> MissingMemberExceptionValue)
        {
            return Observable.Select(MissingMemberExceptionValue,
                (MissingMemberExceptionValueLambda) => MissingMemberExceptionValueLambda.Message);
        }
    }
}