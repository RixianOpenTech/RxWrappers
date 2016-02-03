using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __HMACSHA512
    {
        
        public static IObservable<System.Boolean> get_ProduceLegacyHmacValues(this IObservable<System.Security.Cryptography.HMACSHA512> HMACSHA512Value)
        {
            return Observable.Select(HMACSHA512Value, (HMACSHA512ValueLambda) => HMACSHA512ValueLambda.ProduceLegacyHmacValues);
        }


        public static IObservable<System.Reactive.Unit> set_ProduceLegacyHmacValues(this IObservable<System.Security.Cryptography.HMACSHA512> HMACSHA512Value, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(HMACSHA512Value, value, (HMACSHA512ValueLambda, valueLambda) => HMACSHA512ValueLambda.ProduceLegacyHmacValues = valueLambda);
        }

    }
}