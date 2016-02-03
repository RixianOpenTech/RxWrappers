using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Principal
{
    public static class __NTAccount
    {
        public static IObservable<System.Boolean> IsValidTargetType(
            this IObservable<System.Security.Principal.NTAccount> NTAccountValue, IObservable<System.Type> targetType)
        {
            return Observable.Zip(NTAccountValue, targetType,
                (NTAccountValueLambda, targetTypeLambda) => NTAccountValueLambda.IsValidTargetType(targetTypeLambda));
        }


        public static IObservable<System.Security.Principal.IdentityReference> Translate(
            this IObservable<System.Security.Principal.NTAccount> NTAccountValue, IObservable<System.Type> targetType)
        {
            return Observable.Zip(NTAccountValue, targetType,
                (NTAccountValueLambda, targetTypeLambda) => NTAccountValueLambda.Translate(targetTypeLambda));
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Security.Principal.NTAccount> NTAccountValue, IObservable<System.Object> o)
        {
            return Observable.Zip(NTAccountValue, o,
                (NTAccountValueLambda, oLambda) => NTAccountValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Security.Principal.NTAccount> NTAccountValue)
        {
            return Observable.Select(NTAccountValue, (NTAccountValueLambda) => NTAccountValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Security.Principal.NTAccount> NTAccountValue)
        {
            return Observable.Select(NTAccountValue, (NTAccountValueLambda) => NTAccountValueLambda.ToString());
        }


        public static IObservable<System.String> get_Value(
            this IObservable<System.Security.Principal.NTAccount> NTAccountValue)
        {
            return Observable.Select(NTAccountValue, (NTAccountValueLambda) => NTAccountValueLambda.Value);
        }
    }
}