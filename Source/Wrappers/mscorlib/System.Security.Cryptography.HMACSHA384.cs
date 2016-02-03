using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __HMACSHA384
    {
        public static IObservable<System.Boolean> get_ProduceLegacyHmacValues(
            this IObservable<System.Security.Cryptography.HMACSHA384> HMACSHA384Value)
        {
            return Observable.Select(HMACSHA384Value,
                (HMACSHA384ValueLambda) => HMACSHA384ValueLambda.ProduceLegacyHmacValues);
        }


        public static IObservable<System.Reactive.Unit> set_ProduceLegacyHmacValues(
            this IObservable<System.Security.Cryptography.HMACSHA384> HMACSHA384Value, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(HMACSHA384Value, value,
                (HMACSHA384ValueLambda, valueLambda) => HMACSHA384ValueLambda.ProduceLegacyHmacValues = valueLambda);
        }
    }
}