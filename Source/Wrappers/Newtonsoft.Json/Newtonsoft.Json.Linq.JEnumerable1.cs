using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Linq
{
    public static class __JEnumerable1
    {
        
        public static IObservable<IEnumerator<T>> GetEnumerator<T>(this IObservable<Newtonsoft.Json.Linq.JEnumerable<T>> JEnumerableValue) where T : Newtonsoft.Json.Linq.JToken
        {
            return Observable.Select(JEnumerableValue, (JEnumerableValueLambda) => JEnumerableValueLambda.GetEnumerator());
        }


        public static IObservable<System.Boolean> Equals<T>(this IObservable<Newtonsoft.Json.Linq.JEnumerable<T>> JEnumerableValue, IObservable<Newtonsoft.Json.Linq.JEnumerable<T>> other) where T : Newtonsoft.Json.Linq.JToken
        {
            return Observable.Zip(JEnumerableValue, other, (JEnumerableValueLambda, otherLambda) => JEnumerableValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Boolean> Equals<T>(this IObservable<Newtonsoft.Json.Linq.JEnumerable<T>> JEnumerableValue, IObservable<System.Object> obj) where T : Newtonsoft.Json.Linq.JToken
        {
            return Observable.Zip(JEnumerableValue, obj, (JEnumerableValueLambda, objLambda) => JEnumerableValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode<T>(this IObservable<Newtonsoft.Json.Linq.JEnumerable<T>> JEnumerableValue) where T : Newtonsoft.Json.Linq.JToken
        {
            return Observable.Select(JEnumerableValue, (JEnumerableValueLambda) => JEnumerableValueLambda.GetHashCode());
        }


        public static IObservable<Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>> get_Item<T>(this IObservable<Newtonsoft.Json.Linq.JEnumerable<T>> JEnumerableValue, IObservable<System.Object> key) where T : Newtonsoft.Json.Linq.JToken
        {
            return Observable.Zip(JEnumerableValue, key, (JEnumerableValueLambda, keyLambda) => JEnumerableValueLambda[keyLambda]);
        }

    }
}