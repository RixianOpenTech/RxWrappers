using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __SHA1Managed
    {
        
        public static IObservable<System.Reactive.Unit> Initialize(this IObservable<System.Security.Cryptography.SHA1Managed> SHA1ManagedValue)
        {
            return Observable.Do(SHA1ManagedValue, (SHA1ManagedValueLambda) => SHA1ManagedValueLambda.Initialize()).ToUnit();
        }

    }
}