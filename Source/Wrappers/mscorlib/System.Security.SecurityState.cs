using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
    public static class __SecurityState
    {
        public static IObservable<System.Boolean> IsStateAvailable(
            this IObservable<System.Security.SecurityState> SecurityStateValue)
        {
            return Observable.Select(SecurityStateValue,
                (SecurityStateValueLambda) => SecurityStateValueLambda.IsStateAvailable());
        }


        public static IObservable<System.Reactive.Unit> EnsureState(
            this IObservable<System.Security.SecurityState> SecurityStateValue)
        {
            return
                Observable.Do(SecurityStateValue, (SecurityStateValueLambda) => SecurityStateValueLambda.EnsureState())
                    .ToUnit();
        }
    }
}