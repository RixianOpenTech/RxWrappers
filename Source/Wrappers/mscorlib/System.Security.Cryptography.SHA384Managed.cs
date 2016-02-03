using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __SHA384Managed
    {
        public static IObservable<System.Reactive.Unit> Initialize(
            this IObservable<System.Security.Cryptography.SHA384Managed> SHA384ManagedValue)
        {
            return
                Observable.Do(SHA384ManagedValue, (SHA384ManagedValueLambda) => SHA384ManagedValueLambda.Initialize())
                    .ToUnit();
        }
    }
}