using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.WindowsRuntime
{
    public static class __EventRegistrationToken
    {
        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>
                EventRegistrationTokenValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(EventRegistrationTokenValue, obj,
                (EventRegistrationTokenValueLambda, objLambda) => EventRegistrationTokenValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken>
                EventRegistrationTokenValue)
        {
            return Observable.Select(EventRegistrationTokenValue,
                (EventRegistrationTokenValueLambda) => EventRegistrationTokenValueLambda.GetHashCode());
        }
    }
}