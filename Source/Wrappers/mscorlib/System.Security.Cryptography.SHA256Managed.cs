using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __SHA256Managed
    {
        
        public static IObservable<System.Reactive.Unit> Initialize(this IObservable<System.Security.Cryptography.SHA256Managed> SHA256ManagedValue)
        {
            return Observable.Do(SHA256ManagedValue, (SHA256ManagedValueLambda) => SHA256ManagedValueLambda.Initialize()).ToUnit();
        }

    }
}