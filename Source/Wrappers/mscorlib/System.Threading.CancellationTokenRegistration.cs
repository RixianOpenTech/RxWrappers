using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __CancellationTokenRegistration
    {
        public static IObservable<System.Reactive.Unit> Dispose(
            this IObservable<System.Threading.CancellationTokenRegistration> CancellationTokenRegistrationValue)
        {
            return
                Observable.Do(CancellationTokenRegistrationValue,
                    (CancellationTokenRegistrationValueLambda) => CancellationTokenRegistrationValueLambda.Dispose())
                    .ToUnit();
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Threading.CancellationTokenRegistration> CancellationTokenRegistrationValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(CancellationTokenRegistrationValue, obj,
                (CancellationTokenRegistrationValueLambda, objLambda) =>
                    CancellationTokenRegistrationValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Threading.CancellationTokenRegistration> CancellationTokenRegistrationValue,
            IObservable<System.Threading.CancellationTokenRegistration> other)
        {
            return Observable.Zip(CancellationTokenRegistrationValue, other,
                (CancellationTokenRegistrationValueLambda, otherLambda) =>
                    CancellationTokenRegistrationValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Threading.CancellationTokenRegistration> CancellationTokenRegistrationValue)
        {
            return Observable.Select(CancellationTokenRegistrationValue,
                (CancellationTokenRegistrationValueLambda) => CancellationTokenRegistrationValueLambda.GetHashCode());
        }
    }
}