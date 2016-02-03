using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __RIPEMD160Managed
    {
        
        public static IObservable<System.Reactive.Unit> Initialize(this IObservable<System.Security.Cryptography.RIPEMD160Managed> RIPEMD160ManagedValue)
        {
            return Observable.Do(RIPEMD160ManagedValue, (RIPEMD160ManagedValueLambda) => RIPEMD160ManagedValueLambda.Initialize()).ToUnit();
        }

    }
}