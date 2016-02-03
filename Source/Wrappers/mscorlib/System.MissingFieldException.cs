using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __MissingFieldException
    {
        public static IObservable<System.String> get_Message(
            this IObservable<System.MissingFieldException> MissingFieldExceptionValue)
        {
            return Observable.Select(MissingFieldExceptionValue,
                (MissingFieldExceptionValueLambda) => MissingFieldExceptionValueLambda.Message);
        }
    }
}