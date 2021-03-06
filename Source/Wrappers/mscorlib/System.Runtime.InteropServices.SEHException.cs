using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __SEHException
    {
        public static IObservable<System.Boolean> CanResume(
            this IObservable<System.Runtime.InteropServices.SEHException> SEHExceptionValue)
        {
            return Observable.Select(SEHExceptionValue, (SEHExceptionValueLambda) => SEHExceptionValueLambda.CanResume());
        }
    }
}