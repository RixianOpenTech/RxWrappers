using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Linq
{
    public static class __IJEnumerable1
    {
        
        public static IObservable<Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>> get_Item<T>(this IObservable<Newtonsoft.Json.Linq.IJEnumerable<T>> IJEnumerableValue, IObservable<System.Object> key) where T : Newtonsoft.Json.Linq.JToken
        {
            return Observable.Zip(IJEnumerableValue, key, (IJEnumerableValueLambda, keyLambda) => IJEnumerableValueLambda[keyLambda]);
        }

    }
}