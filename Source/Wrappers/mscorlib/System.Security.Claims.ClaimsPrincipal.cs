using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Claims
{
    public static class __ClaimsPrincipal
    {
        public static IObservable<System.Reactive.Unit> AddIdentity(
            this IObservable<System.Security.Claims.ClaimsPrincipal> ClaimsPrincipalValue,
            IObservable<System.Security.Claims.ClaimsIdentity> identity)
        {
            return ObservableExt.ZipExecute(ClaimsPrincipalValue, identity,
                (ClaimsPrincipalValueLambda, identityLambda) => ClaimsPrincipalValueLambda.AddIdentity(identityLambda));
        }


        public static IObservable<System.Security.Claims.ClaimsPrincipal> Clone(
            this IObservable<System.Security.Claims.ClaimsPrincipal> ClaimsPrincipalValue)
        {
            return Observable.Select(ClaimsPrincipalValue,
                (ClaimsPrincipalValueLambda) => ClaimsPrincipalValueLambda.Clone());
        }


        public static IObservable<System.Reactive.Unit> AddIdentities(
            this IObservable<System.Security.Claims.ClaimsPrincipal> ClaimsPrincipalValue,
            IObservable<System.Collections.Generic.IEnumerable<System.Security.Claims.ClaimsIdentity>> identities)
        {
            return ObservableExt.ZipExecute(ClaimsPrincipalValue, identities,
                (ClaimsPrincipalValueLambda, identitiesLambda) =>
                    ClaimsPrincipalValueLambda.AddIdentities(identitiesLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>> FindAll(
            this IObservable<System.Security.Claims.ClaimsPrincipal> ClaimsPrincipalValue,
            IObservable<System.Predicate<System.Security.Claims.Claim>> match)
        {
            return Observable.Zip(ClaimsPrincipalValue, match,
                (ClaimsPrincipalValueLambda, matchLambda) => ClaimsPrincipalValueLambda.FindAll(matchLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>> FindAll(
            this IObservable<System.Security.Claims.ClaimsPrincipal> ClaimsPrincipalValue,
            IObservable<System.String> type)
        {
            return Observable.Zip(ClaimsPrincipalValue, type,
                (ClaimsPrincipalValueLambda, typeLambda) => ClaimsPrincipalValueLambda.FindAll(typeLambda));
        }


        public static IObservable<System.Security.Claims.Claim> FindFirst(
            this IObservable<System.Security.Claims.ClaimsPrincipal> ClaimsPrincipalValue,
            IObservable<System.Predicate<System.Security.Claims.Claim>> match)
        {
            return Observable.Zip(ClaimsPrincipalValue, match,
                (ClaimsPrincipalValueLambda, matchLambda) => ClaimsPrincipalValueLambda.FindFirst(matchLambda));
        }


        public static IObservable<System.Security.Claims.Claim> FindFirst(
            this IObservable<System.Security.Claims.ClaimsPrincipal> ClaimsPrincipalValue,
            IObservable<System.String> type)
        {
            return Observable.Zip(ClaimsPrincipalValue, type,
                (ClaimsPrincipalValueLambda, typeLambda) => ClaimsPrincipalValueLambda.FindFirst(typeLambda));
        }


        public static IObservable<System.Boolean> HasClaim(
            this IObservable<System.Security.Claims.ClaimsPrincipal> ClaimsPrincipalValue,
            IObservable<System.Predicate<System.Security.Claims.Claim>> match)
        {
            return Observable.Zip(ClaimsPrincipalValue, match,
                (ClaimsPrincipalValueLambda, matchLambda) => ClaimsPrincipalValueLambda.HasClaim(matchLambda));
        }


        public static IObservable<System.Boolean> HasClaim(
            this IObservable<System.Security.Claims.ClaimsPrincipal> ClaimsPrincipalValue,
            IObservable<System.String> type, IObservable<System.String> value)
        {
            return Observable.Zip(ClaimsPrincipalValue, type, value,
                (ClaimsPrincipalValueLambda, typeLambda, valueLambda) =>
                    ClaimsPrincipalValueLambda.HasClaim(typeLambda, valueLambda));
        }


        public static IObservable<System.Boolean> IsInRole(
            this IObservable<System.Security.Claims.ClaimsPrincipal> ClaimsPrincipalValue,
            IObservable<System.String> role)
        {
            return Observable.Zip(ClaimsPrincipalValue, role,
                (ClaimsPrincipalValueLambda, roleLambda) => ClaimsPrincipalValueLambda.IsInRole(roleLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteTo(
            this IObservable<System.Security.Claims.ClaimsPrincipal> ClaimsPrincipalValue,
            IObservable<System.IO.BinaryWriter> writer)
        {
            return ObservableExt.ZipExecute(ClaimsPrincipalValue, writer,
                (ClaimsPrincipalValueLambda, writerLambda) => ClaimsPrincipalValueLambda.WriteTo(writerLambda));
        }


        public static
            IObservable
                <
                    System.Func
                        <System.Collections.Generic.IEnumerable<System.Security.Claims.ClaimsIdentity>,
                            System.Security.Claims.ClaimsIdentity>> get_PrimaryIdentitySelector()
        {
            return ObservableExt.Factory(() => System.Security.Claims.ClaimsPrincipal.PrimaryIdentitySelector);
        }


        public static IObservable<System.Func<System.Security.Claims.ClaimsPrincipal>> get_ClaimsPrincipalSelector()
        {
            return ObservableExt.Factory(() => System.Security.Claims.ClaimsPrincipal.ClaimsPrincipalSelector);
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>> get_Claims(
            this IObservable<System.Security.Claims.ClaimsPrincipal> ClaimsPrincipalValue)
        {
            return Observable.Select(ClaimsPrincipalValue,
                (ClaimsPrincipalValueLambda) => ClaimsPrincipalValueLambda.Claims);
        }


        public static IObservable<System.Security.Claims.ClaimsPrincipal> get_Current()
        {
            return ObservableExt.Factory(() => System.Security.Claims.ClaimsPrincipal.Current);
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Security.Claims.ClaimsIdentity>>
            get_Identities(this IObservable<System.Security.Claims.ClaimsPrincipal> ClaimsPrincipalValue)
        {
            return Observable.Select(ClaimsPrincipalValue,
                (ClaimsPrincipalValueLambda) => ClaimsPrincipalValueLambda.Identities);
        }


        public static IObservable<System.Security.Principal.IIdentity> get_Identity(
            this IObservable<System.Security.Claims.ClaimsPrincipal> ClaimsPrincipalValue)
        {
            return Observable.Select(ClaimsPrincipalValue,
                (ClaimsPrincipalValueLambda) => ClaimsPrincipalValueLambda.Identity);
        }


        public static IObservable<System.Reactive.Unit> set_PrimaryIdentitySelector(
            IObservable
                <
                    System.Func
                        <System.Collections.Generic.IEnumerable<System.Security.Claims.ClaimsIdentity>,
                            System.Security.Claims.ClaimsIdentity>> value)
        {
            return
                Observable.Do(value,
                    (valueLambda) => System.Security.Claims.ClaimsPrincipal.PrimaryIdentitySelector = valueLambda)
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_ClaimsPrincipalSelector(
            IObservable<System.Func<System.Security.Claims.ClaimsPrincipal>> value)
        {
            return
                Observable.Do(value,
                    (valueLambda) => System.Security.Claims.ClaimsPrincipal.ClaimsPrincipalSelector = valueLambda)
                    .ToUnit();
        }
    }
}