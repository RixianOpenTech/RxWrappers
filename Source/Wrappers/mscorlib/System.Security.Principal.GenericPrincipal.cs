using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Principal
{
    public static class __GenericPrincipal
    {
        public static IObservable<System.Boolean> IsInRole(
            this IObservable<System.Security.Principal.GenericPrincipal> GenericPrincipalValue,
            IObservable<System.String> role)
        {
            return Observable.Zip(GenericPrincipalValue, role,
                (GenericPrincipalValueLambda, roleLambda) => GenericPrincipalValueLambda.IsInRole(roleLambda));
        }


        public static IObservable<System.Security.Principal.IIdentity> get_Identity(
            this IObservable<System.Security.Principal.GenericPrincipal> GenericPrincipalValue)
        {
            return Observable.Select(GenericPrincipalValue,
                (GenericPrincipalValueLambda) => GenericPrincipalValueLambda.Identity);
        }
    }
}