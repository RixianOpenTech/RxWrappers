using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Microsoft.Win32.SafeHandles
{
    public static class __CriticalHandleMinusOneIsInvalid
    {
        
        public static IObservable<System.Boolean> get_IsInvalid(this IObservable<Microsoft.Win32.SafeHandles.CriticalHandleMinusOneIsInvalid> CriticalHandleMinusOneIsInvalidValue)
        {
            return Observable.Select(CriticalHandleMinusOneIsInvalidValue, (CriticalHandleMinusOneIsInvalidValueLambda) => CriticalHandleMinusOneIsInvalidValueLambda.IsInvalid);
        }

    }
}