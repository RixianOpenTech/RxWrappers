using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __CacheControlHeaderValue
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue)
        {
            return Observable.Select(CacheControlHeaderValueValue, (CacheControlHeaderValueValueLambda) => CacheControlHeaderValueValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(CacheControlHeaderValueValue, obj, (CacheControlHeaderValueValueLambda, objLambda) => CacheControlHeaderValueValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue)
        {
            return Observable.Select(CacheControlHeaderValueValue, (CacheControlHeaderValueValueLambda) => CacheControlHeaderValueValueLambda.GetHashCode());
        }


        public static IObservable<System.Net.Http.Headers.CacheControlHeaderValue> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Net.Http.Headers.CacheControlHeaderValue.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Net.Http.Headers.CacheControlHeaderValue>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => {
System.Net.Http.Headers.CacheControlHeaderValue parsedValueOutput = default(System.Net.Http.Headers.CacheControlHeaderValue);
var result = System.Net.Http.Headers.CacheControlHeaderValue.TryParse(inputLambda, out parsedValueOutput);
return Tuple.Create(result, parsedValueOutput);
});
        }


        public static IObservable<System.Boolean> get_NoCache(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue)
        {
            return Observable.Select(CacheControlHeaderValueValue, (CacheControlHeaderValueValueLambda) => CacheControlHeaderValueValueLambda.NoCache);
        }


        public static IObservable<System.Collections.Generic.ICollection<System.String>> get_NoCacheHeaders(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue)
        {
            return Observable.Select(CacheControlHeaderValueValue, (CacheControlHeaderValueValueLambda) => CacheControlHeaderValueValueLambda.NoCacheHeaders);
        }


        public static IObservable<System.Boolean> get_NoStore(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue)
        {
            return Observable.Select(CacheControlHeaderValueValue, (CacheControlHeaderValueValueLambda) => CacheControlHeaderValueValueLambda.NoStore);
        }


        public static IObservable<System.Nullable<System.TimeSpan>> get_MaxAge(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue)
        {
            return Observable.Select(CacheControlHeaderValueValue, (CacheControlHeaderValueValueLambda) => CacheControlHeaderValueValueLambda.MaxAge);
        }


        public static IObservable<System.Nullable<System.TimeSpan>> get_SharedMaxAge(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue)
        {
            return Observable.Select(CacheControlHeaderValueValue, (CacheControlHeaderValueValueLambda) => CacheControlHeaderValueValueLambda.SharedMaxAge);
        }


        public static IObservable<System.Boolean> get_MaxStale(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue)
        {
            return Observable.Select(CacheControlHeaderValueValue, (CacheControlHeaderValueValueLambda) => CacheControlHeaderValueValueLambda.MaxStale);
        }


        public static IObservable<System.Nullable<System.TimeSpan>> get_MaxStaleLimit(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue)
        {
            return Observable.Select(CacheControlHeaderValueValue, (CacheControlHeaderValueValueLambda) => CacheControlHeaderValueValueLambda.MaxStaleLimit);
        }


        public static IObservable<System.Nullable<System.TimeSpan>> get_MinFresh(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue)
        {
            return Observable.Select(CacheControlHeaderValueValue, (CacheControlHeaderValueValueLambda) => CacheControlHeaderValueValueLambda.MinFresh);
        }


        public static IObservable<System.Boolean> get_NoTransform(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue)
        {
            return Observable.Select(CacheControlHeaderValueValue, (CacheControlHeaderValueValueLambda) => CacheControlHeaderValueValueLambda.NoTransform);
        }


        public static IObservable<System.Boolean> get_OnlyIfCached(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue)
        {
            return Observable.Select(CacheControlHeaderValueValue, (CacheControlHeaderValueValueLambda) => CacheControlHeaderValueValueLambda.OnlyIfCached);
        }


        public static IObservable<System.Boolean> get_Public(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue)
        {
            return Observable.Select(CacheControlHeaderValueValue, (CacheControlHeaderValueValueLambda) => CacheControlHeaderValueValueLambda.Public);
        }


        public static IObservable<System.Boolean> get_Private(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue)
        {
            return Observable.Select(CacheControlHeaderValueValue, (CacheControlHeaderValueValueLambda) => CacheControlHeaderValueValueLambda.Private);
        }


        public static IObservable<System.Collections.Generic.ICollection<System.String>> get_PrivateHeaders(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue)
        {
            return Observable.Select(CacheControlHeaderValueValue, (CacheControlHeaderValueValueLambda) => CacheControlHeaderValueValueLambda.PrivateHeaders);
        }


        public static IObservable<System.Boolean> get_MustRevalidate(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue)
        {
            return Observable.Select(CacheControlHeaderValueValue, (CacheControlHeaderValueValueLambda) => CacheControlHeaderValueValueLambda.MustRevalidate);
        }


        public static IObservable<System.Boolean> get_ProxyRevalidate(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue)
        {
            return Observable.Select(CacheControlHeaderValueValue, (CacheControlHeaderValueValueLambda) => CacheControlHeaderValueValueLambda.ProxyRevalidate);
        }


        public static IObservable<System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue>> get_Extensions(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue)
        {
            return Observable.Select(CacheControlHeaderValueValue, (CacheControlHeaderValueValueLambda) => CacheControlHeaderValueValueLambda.Extensions);
        }


        public static IObservable<System.Reactive.Unit> set_NoCache(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(CacheControlHeaderValueValue, value, (CacheControlHeaderValueValueLambda, valueLambda) => CacheControlHeaderValueValueLambda.NoCache = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_NoStore(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(CacheControlHeaderValueValue, value, (CacheControlHeaderValueValueLambda, valueLambda) => CacheControlHeaderValueValueLambda.NoStore = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MaxAge(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue, IObservable<System.Nullable<System.TimeSpan>> value)
        {
            return ObservableExt.ZipExecute(CacheControlHeaderValueValue, value, (CacheControlHeaderValueValueLambda, valueLambda) => CacheControlHeaderValueValueLambda.MaxAge = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_SharedMaxAge(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue, IObservable<System.Nullable<System.TimeSpan>> value)
        {
            return ObservableExt.ZipExecute(CacheControlHeaderValueValue, value, (CacheControlHeaderValueValueLambda, valueLambda) => CacheControlHeaderValueValueLambda.SharedMaxAge = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MaxStale(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(CacheControlHeaderValueValue, value, (CacheControlHeaderValueValueLambda, valueLambda) => CacheControlHeaderValueValueLambda.MaxStale = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MaxStaleLimit(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue, IObservable<System.Nullable<System.TimeSpan>> value)
        {
            return ObservableExt.ZipExecute(CacheControlHeaderValueValue, value, (CacheControlHeaderValueValueLambda, valueLambda) => CacheControlHeaderValueValueLambda.MaxStaleLimit = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MinFresh(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue, IObservable<System.Nullable<System.TimeSpan>> value)
        {
            return ObservableExt.ZipExecute(CacheControlHeaderValueValue, value, (CacheControlHeaderValueValueLambda, valueLambda) => CacheControlHeaderValueValueLambda.MinFresh = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_NoTransform(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(CacheControlHeaderValueValue, value, (CacheControlHeaderValueValueLambda, valueLambda) => CacheControlHeaderValueValueLambda.NoTransform = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_OnlyIfCached(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(CacheControlHeaderValueValue, value, (CacheControlHeaderValueValueLambda, valueLambda) => CacheControlHeaderValueValueLambda.OnlyIfCached = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Public(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(CacheControlHeaderValueValue, value, (CacheControlHeaderValueValueLambda, valueLambda) => CacheControlHeaderValueValueLambda.Public = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Private(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(CacheControlHeaderValueValue, value, (CacheControlHeaderValueValueLambda, valueLambda) => CacheControlHeaderValueValueLambda.Private = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MustRevalidate(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(CacheControlHeaderValueValue, value, (CacheControlHeaderValueValueLambda, valueLambda) => CacheControlHeaderValueValueLambda.MustRevalidate = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ProxyRevalidate(this IObservable<System.Net.Http.Headers.CacheControlHeaderValue> CacheControlHeaderValueValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(CacheControlHeaderValueValue, value, (CacheControlHeaderValueValueLambda, valueLambda) => CacheControlHeaderValueValueLambda.ProxyRevalidate = valueLambda);
        }

    }
}