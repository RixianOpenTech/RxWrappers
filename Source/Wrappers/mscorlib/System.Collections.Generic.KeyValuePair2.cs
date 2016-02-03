using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Generic
{
    public static class __KeyValuePair2
    {
        
        public static IObservable<System.String> ToString<TKey, TValue>(this IObservable<System.Collections.Generic.KeyValuePair<TKey, TValue>> KeyValuePairValue)
        {
            return Observable.Select(KeyValuePairValue, (KeyValuePairValueLambda) => KeyValuePairValueLambda.ToString());
        }


        public static IObservable<TKey> get_Key<TKey, TValue>(this IObservable<System.Collections.Generic.KeyValuePair<TKey, TValue>> KeyValuePairValue)
        {
            return Observable.Select(KeyValuePairValue, (KeyValuePairValueLambda) => KeyValuePairValueLambda.Key);
        }


        public static IObservable<TValue> get_Value<TKey, TValue>(this IObservable<System.Collections.Generic.KeyValuePair<TKey, TValue>> KeyValuePairValue)
        {
            return Observable.Select(KeyValuePairValue, (KeyValuePairValueLambda) => KeyValuePairValueLambda.Value);
        }

    }
}