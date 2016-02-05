using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __HttpResponseHeaders
    {
        
        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.String>> get_AcceptRanges(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.AcceptRanges);
        }


        public static IObservable<System.Nullable<System.TimeSpan>> get_Age(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.Age);
        }


        public static IObservable<System.Net.Http.Headers.EntityTagHeaderValue> get_ETag(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.ETag);
        }


        public static IObservable<System.Uri> get_Location(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.Location);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.AuthenticationHeaderValue>> get_ProxyAuthenticate(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.ProxyAuthenticate);
        }


        public static IObservable<System.Net.Http.Headers.RetryConditionHeaderValue> get_RetryAfter(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.RetryAfter);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ProductInfoHeaderValue>> get_Server(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.Server);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.String>> get_Vary(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.Vary);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.AuthenticationHeaderValue>> get_WwwAuthenticate(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.WwwAuthenticate);
        }


        public static IObservable<System.Net.Http.Headers.CacheControlHeaderValue> get_CacheControl(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.CacheControl);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.String>> get_Connection(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.Connection);
        }


        public static IObservable<System.Nullable<System.Boolean>> get_ConnectionClose(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.ConnectionClose);
        }


        public static IObservable<System.Nullable<System.DateTimeOffset>> get_Date(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.Date);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.NameValueHeaderValue>> get_Pragma(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.Pragma);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.String>> get_Trailer(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.Trailer);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.TransferCodingHeaderValue>> get_TransferEncoding(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.TransferEncoding);
        }


        public static IObservable<System.Nullable<System.Boolean>> get_TransferEncodingChunked(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.TransferEncodingChunked);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ProductHeaderValue>> get_Upgrade(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.Upgrade);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ViaHeaderValue>> get_Via(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.Via);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.WarningHeaderValue>> get_Warning(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue)
        {
            return Observable.Select(HttpResponseHeadersValue, (HttpResponseHeadersValueLambda) => HttpResponseHeadersValueLambda.Warning);
        }


        public static IObservable<System.Reactive.Unit> set_Age(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue, IObservable<System.Nullable<System.TimeSpan>> value)
        {
            return ObservableExt.ZipExecute(HttpResponseHeadersValue, value, (HttpResponseHeadersValueLambda, valueLambda) => HttpResponseHeadersValueLambda.Age = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ETag(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue, IObservable<System.Net.Http.Headers.EntityTagHeaderValue> value)
        {
            return ObservableExt.ZipExecute(HttpResponseHeadersValue, value, (HttpResponseHeadersValueLambda, valueLambda) => HttpResponseHeadersValueLambda.ETag = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Location(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue, IObservable<System.Uri> value)
        {
            return ObservableExt.ZipExecute(HttpResponseHeadersValue, value, (HttpResponseHeadersValueLambda, valueLambda) => HttpResponseHeadersValueLambda.Location = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_RetryAfter(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue, IObservable<System.Net.Http.Headers.RetryConditionHeaderValue> value)
        {
            return ObservableExt.ZipExecute(HttpResponseHeadersValue, value, (HttpResponseHeadersValueLambda, valueLambda) => HttpResponseHeadersValueLambda.RetryAfter = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_CacheControl(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue, IObservable<System.Net.Http.Headers.CacheControlHeaderValue> value)
        {
            return ObservableExt.ZipExecute(HttpResponseHeadersValue, value, (HttpResponseHeadersValueLambda, valueLambda) => HttpResponseHeadersValueLambda.CacheControl = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ConnectionClose(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue, IObservable<System.Nullable<System.Boolean>> value)
        {
            return ObservableExt.ZipExecute(HttpResponseHeadersValue, value, (HttpResponseHeadersValueLambda, valueLambda) => HttpResponseHeadersValueLambda.ConnectionClose = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Date(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue, IObservable<System.Nullable<System.DateTimeOffset>> value)
        {
            return ObservableExt.ZipExecute(HttpResponseHeadersValue, value, (HttpResponseHeadersValueLambda, valueLambda) => HttpResponseHeadersValueLambda.Date = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_TransferEncodingChunked(this IObservable<System.Net.Http.Headers.HttpResponseHeaders> HttpResponseHeadersValue, IObservable<System.Nullable<System.Boolean>> value)
        {
            return ObservableExt.ZipExecute(HttpResponseHeadersValue, value, (HttpResponseHeadersValueLambda, valueLambda) => HttpResponseHeadersValueLambda.TransferEncodingChunked = valueLambda);
        }

    }
}