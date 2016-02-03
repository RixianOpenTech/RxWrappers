using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __ExternalException
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Runtime.InteropServices.ExternalException> ExternalExceptionValue)
        {
            return Observable.Select(ExternalExceptionValue, (ExternalExceptionValueLambda) => ExternalExceptionValueLambda.ToString());
        }


        public static IObservable<System.Int32> get_ErrorCode(this IObservable<System.Runtime.InteropServices.ExternalException> ExternalExceptionValue)
        {
            return Observable.Select(ExternalExceptionValue, (ExternalExceptionValueLambda) => ExternalExceptionValueLambda.ErrorCode);
        }

    }
}