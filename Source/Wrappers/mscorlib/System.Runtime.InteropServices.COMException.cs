using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __COMException
    {
        public static IObservable<System.String> ToString(
            this IObservable<System.Runtime.InteropServices.COMException> COMExceptionValue)
        {
            return Observable.Select(COMExceptionValue, (COMExceptionValueLambda) => COMExceptionValueLambda.ToString());
        }
    }
}