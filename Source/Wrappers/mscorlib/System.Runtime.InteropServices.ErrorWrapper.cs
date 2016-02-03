using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __ErrorWrapper
    {
        public static IObservable<System.Int32> get_ErrorCode(
            this IObservable<System.Runtime.InteropServices.ErrorWrapper> ErrorWrapperValue)
        {
            return Observable.Select(ErrorWrapperValue, (ErrorWrapperValueLambda) => ErrorWrapperValueLambda.ErrorCode);
        }
    }
}