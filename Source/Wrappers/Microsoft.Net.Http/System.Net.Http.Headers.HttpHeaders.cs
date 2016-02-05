using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __HttpHeaders
    {
        
        public static IObservable<System.Reactive.Unit> Add(this IObservable<System.Net.Http.Headers.HttpHeaders> HttpHeadersValue, IObservable<System.String> name, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(HttpHeadersValue, name, value, (HttpHeadersValueLambda, nameLambda, valueLambda) => HttpHeadersValueLambda.Add(nameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Add(this IObservable<System.Net.Http.Headers.HttpHeaders> HttpHeadersValue, IObservable<System.String> name, IObservable<System.Collections.Generic.IEnumerable<System.String>> values)
        {
            return ObservableExt.ZipExecute(HttpHeadersValue, name, values, (HttpHeadersValueLambda, nameLambda, valuesLambda) => HttpHeadersValueLambda.Add(nameLambda, valuesLambda));
        }


        public static IObservable<System.Boolean> TryAddWithoutValidation(this IObservable<System.Net.Http.Headers.HttpHeaders> HttpHeadersValue, IObservable<System.String> name, IObservable<System.String> value)
        {
            return Observable.Zip(HttpHeadersValue, name, value, (HttpHeadersValueLambda, nameLambda, valueLambda) => HttpHeadersValueLambda.TryAddWithoutValidation(nameLambda, valueLambda));
        }


        public static IObservable<System.Boolean> TryAddWithoutValidation(this IObservable<System.Net.Http.Headers.HttpHeaders> HttpHeadersValue, IObservable<System.String> name, IObservable<System.Collections.Generic.IEnumerable<System.String>> values)
        {
            return Observable.Zip(HttpHeadersValue, name, values, (HttpHeadersValueLambda, nameLambda, valuesLambda) => HttpHeadersValueLambda.TryAddWithoutValidation(nameLambda, valuesLambda));
        }


        public static IObservable<System.Reactive.Unit> Clear(this IObservable<System.Net.Http.Headers.HttpHeaders> HttpHeadersValue)
        {
            return Observable.Do(HttpHeadersValue, (HttpHeadersValueLambda) => HttpHeadersValueLambda.Clear()).ToUnit();
        }


        public static IObservable<System.Boolean> Remove(this IObservable<System.Net.Http.Headers.HttpHeaders> HttpHeadersValue, IObservable<System.String> name)
        {
            return Observable.Zip(HttpHeadersValue, name, (HttpHeadersValueLambda, nameLambda) => HttpHeadersValueLambda.Remove(nameLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.String>> GetValues(this IObservable<System.Net.Http.Headers.HttpHeaders> HttpHeadersValue, IObservable<System.String> name)
        {
            return Observable.Zip(HttpHeadersValue, name, (HttpHeadersValueLambda, nameLambda) => HttpHeadersValueLambda.GetValues(nameLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Collections.Generic.IEnumerable<System.String>>> TryGetValues(this IObservable<System.Net.Http.Headers.HttpHeaders> HttpHeadersValue, IObservable<System.String> name)
        {
            return Observable.Zip(HttpHeadersValue, name, (HttpHeadersValueLambda, nameLambda) => {
System.Collections.Generic.IEnumerable<System.String> valuesOutput = default(System.Collections.Generic.IEnumerable<System.String>);
var result = HttpHeadersValueLambda.TryGetValues(nameLambda, out valuesOutput);
return Tuple.Create(result, valuesOutput);
});
        }


        public static IObservable<System.Boolean> Contains(this IObservable<System.Net.Http.Headers.HttpHeaders> HttpHeadersValue, IObservable<System.String> name)
        {
            return Observable.Zip(HttpHeadersValue, name, (HttpHeadersValueLambda, nameLambda) => HttpHeadersValueLambda.Contains(nameLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.Headers.HttpHeaders> HttpHeadersValue)
        {
            return Observable.Select(HttpHeadersValue, (HttpHeadersValueLambda) => HttpHeadersValueLambda.ToString());
        }


        public static IObservable<IEnumerator<KeyValuePair<string, IEnumerable<string>>>> GetEnumerator(this IObservable<System.Net.Http.Headers.HttpHeaders> HttpHeadersValue)
        {
            return Observable.Select(HttpHeadersValue, (HttpHeadersValueLambda) => HttpHeadersValueLambda.GetEnumerator());
        }

    }
}