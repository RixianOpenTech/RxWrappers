using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Microsoft.Win32.SafeHandles
{
    public static class __CriticalHandleZeroOrMinusOneIsInvalid
    {
        public static IObservable<System.Boolean> get_IsInvalid(
            this IObservable<Microsoft.Win32.SafeHandles.CriticalHandleZeroOrMinusOneIsInvalid>
                CriticalHandleZeroOrMinusOneIsInvalidValue)
        {
            return Observable.Select(CriticalHandleZeroOrMinusOneIsInvalidValue,
                (CriticalHandleZeroOrMinusOneIsInvalidValueLambda) =>
                    CriticalHandleZeroOrMinusOneIsInvalidValueLambda.IsInvalid);
        }
    }
}