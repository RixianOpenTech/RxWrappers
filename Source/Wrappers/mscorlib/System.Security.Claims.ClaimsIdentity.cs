using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Claims
{
    public static class __ClaimsIdentity
    {
        public static IObservable<System.Security.Claims.ClaimsIdentity> Clone(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue)
        {
            return Observable.Select(ClaimsIdentityValue,
                (ClaimsIdentityValueLambda) => ClaimsIdentityValueLambda.Clone());
        }


        public static IObservable<System.Reactive.Unit> AddClaim(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue,
            IObservable<System.Security.Claims.Claim> claim)
        {
            return ObservableExt.ZipExecute(ClaimsIdentityValue, claim,
                (ClaimsIdentityValueLambda, claimLambda) => ClaimsIdentityValueLambda.AddClaim(claimLambda));
        }


        public static IObservable<System.Reactive.Unit> AddClaims(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue,
            IObservable<System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>> claims)
        {
            return ObservableExt.ZipExecute(ClaimsIdentityValue, claims,
                (ClaimsIdentityValueLambda, claimsLambda) => ClaimsIdentityValueLambda.AddClaims(claimsLambda));
        }


        public static IObservable<System.Boolean> TryRemoveClaim(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue,
            IObservable<System.Security.Claims.Claim> claim)
        {
            return Observable.Zip(ClaimsIdentityValue, claim,
                (ClaimsIdentityValueLambda, claimLambda) => ClaimsIdentityValueLambda.TryRemoveClaim(claimLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveClaim(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue,
            IObservable<System.Security.Claims.Claim> claim)
        {
            return ObservableExt.ZipExecute(ClaimsIdentityValue, claim,
                (ClaimsIdentityValueLambda, claimLambda) => ClaimsIdentityValueLambda.RemoveClaim(claimLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>> FindAll(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue,
            IObservable<System.Predicate<System.Security.Claims.Claim>> match)
        {
            return Observable.Zip(ClaimsIdentityValue, match,
                (ClaimsIdentityValueLambda, matchLambda) => ClaimsIdentityValueLambda.FindAll(matchLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>> FindAll(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue, IObservable<System.String> type)
        {
            return Observable.Zip(ClaimsIdentityValue, type,
                (ClaimsIdentityValueLambda, typeLambda) => ClaimsIdentityValueLambda.FindAll(typeLambda));
        }


        public static IObservable<System.Boolean> HasClaim(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue,
            IObservable<System.Predicate<System.Security.Claims.Claim>> match)
        {
            return Observable.Zip(ClaimsIdentityValue, match,
                (ClaimsIdentityValueLambda, matchLambda) => ClaimsIdentityValueLambda.HasClaim(matchLambda));
        }


        public static IObservable<System.Boolean> HasClaim(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue, IObservable<System.String> type,
            IObservable<System.String> value)
        {
            return Observable.Zip(ClaimsIdentityValue, type, value,
                (ClaimsIdentityValueLambda, typeLambda, valueLambda) =>
                    ClaimsIdentityValueLambda.HasClaim(typeLambda, valueLambda));
        }


        public static IObservable<System.Security.Claims.Claim> FindFirst(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue,
            IObservable<System.Predicate<System.Security.Claims.Claim>> match)
        {
            return Observable.Zip(ClaimsIdentityValue, match,
                (ClaimsIdentityValueLambda, matchLambda) => ClaimsIdentityValueLambda.FindFirst(matchLambda));
        }


        public static IObservable<System.Security.Claims.Claim> FindFirst(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue, IObservable<System.String> type)
        {
            return Observable.Zip(ClaimsIdentityValue, type,
                (ClaimsIdentityValueLambda, typeLambda) => ClaimsIdentityValueLambda.FindFirst(typeLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteTo(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue,
            IObservable<System.IO.BinaryWriter> writer)
        {
            return ObservableExt.ZipExecute(ClaimsIdentityValue, writer,
                (ClaimsIdentityValueLambda, writerLambda) => ClaimsIdentityValueLambda.WriteTo(writerLambda));
        }


        public static IObservable<System.String> get_AuthenticationType(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue)
        {
            return Observable.Select(ClaimsIdentityValue,
                (ClaimsIdentityValueLambda) => ClaimsIdentityValueLambda.AuthenticationType);
        }


        public static IObservable<System.Boolean> get_IsAuthenticated(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue)
        {
            return Observable.Select(ClaimsIdentityValue,
                (ClaimsIdentityValueLambda) => ClaimsIdentityValueLambda.IsAuthenticated);
        }


        public static IObservable<System.Security.Claims.ClaimsIdentity> get_Actor(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue)
        {
            return Observable.Select(ClaimsIdentityValue, (ClaimsIdentityValueLambda) => ClaimsIdentityValueLambda.Actor);
        }


        public static IObservable<System.Object> get_BootstrapContext(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue)
        {
            return Observable.Select(ClaimsIdentityValue,
                (ClaimsIdentityValueLambda) => ClaimsIdentityValueLambda.BootstrapContext);
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>> get_Claims(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue)
        {
            return Observable.Select(ClaimsIdentityValue,
                (ClaimsIdentityValueLambda) => ClaimsIdentityValueLambda.Claims);
        }


        public static IObservable<System.String> get_Label(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue)
        {
            return Observable.Select(ClaimsIdentityValue, (ClaimsIdentityValueLambda) => ClaimsIdentityValueLambda.Label);
        }


        public static IObservable<System.String> get_Name(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue)
        {
            return Observable.Select(ClaimsIdentityValue, (ClaimsIdentityValueLambda) => ClaimsIdentityValueLambda.Name);
        }


        public static IObservable<System.String> get_NameClaimType(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue)
        {
            return Observable.Select(ClaimsIdentityValue,
                (ClaimsIdentityValueLambda) => ClaimsIdentityValueLambda.NameClaimType);
        }


        public static IObservable<System.String> get_RoleClaimType(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue)
        {
            return Observable.Select(ClaimsIdentityValue,
                (ClaimsIdentityValueLambda) => ClaimsIdentityValueLambda.RoleClaimType);
        }


        public static IObservable<System.Reactive.Unit> set_Actor(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue,
            IObservable<System.Security.Claims.ClaimsIdentity> value)
        {
            return ObservableExt.ZipExecute(ClaimsIdentityValue, value,
                (ClaimsIdentityValueLambda, valueLambda) => ClaimsIdentityValueLambda.Actor = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_BootstrapContext(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue,
            IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(ClaimsIdentityValue, value,
                (ClaimsIdentityValueLambda, valueLambda) => ClaimsIdentityValueLambda.BootstrapContext = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Label(
            this IObservable<System.Security.Claims.ClaimsIdentity> ClaimsIdentityValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(ClaimsIdentityValue, value,
                (ClaimsIdentityValueLambda, valueLambda) => ClaimsIdentityValueLambda.Label = valueLambda);
        }
    }
}