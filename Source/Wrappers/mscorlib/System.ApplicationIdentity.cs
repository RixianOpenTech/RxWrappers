using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __ApplicationIdentity
    {
        public static IObservable<System.String> ToString(
            this IObservable<System.ApplicationIdentity> ApplicationIdentityValue)
        {
            return Observable.Select(ApplicationIdentityValue,
                (ApplicationIdentityValueLambda) => ApplicationIdentityValueLambda.ToString());
        }


        public static IObservable<System.String> get_FullName(
            this IObservable<System.ApplicationIdentity> ApplicationIdentityValue)
        {
            return Observable.Select(ApplicationIdentityValue,
                (ApplicationIdentityValueLambda) => ApplicationIdentityValueLambda.FullName);
        }


        public static IObservable<System.String> get_CodeBase(
            this IObservable<System.ApplicationIdentity> ApplicationIdentityValue)
        {
            return Observable.Select(ApplicationIdentityValue,
                (ApplicationIdentityValueLambda) => ApplicationIdentityValueLambda.CodeBase);
        }
    }
}