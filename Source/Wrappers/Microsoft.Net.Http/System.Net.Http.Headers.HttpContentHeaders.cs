using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __HttpContentHeaders
    {
        
        public static IObservable<System.Collections.Generic.ICollection<System.String>> get_Allow(this IObservable<System.Net.Http.Headers.HttpContentHeaders> HttpContentHeadersValue)
        {
            return Observable.Select(HttpContentHeadersValue, (HttpContentHeadersValueLambda) => HttpContentHeadersValueLambda.Allow);
        }


        public static IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> get_ContentDisposition(this IObservable<System.Net.Http.Headers.HttpContentHeaders> HttpContentHeadersValue)
        {
            return Observable.Select(HttpContentHeadersValue, (HttpContentHeadersValueLambda) => HttpContentHeadersValueLambda.ContentDisposition);
        }


        public static IObservable<System.Collections.Generic.ICollection<System.String>> get_ContentEncoding(this IObservable<System.Net.Http.Headers.HttpContentHeaders> HttpContentHeadersValue)
        {
            return Observable.Select(HttpContentHeadersValue, (HttpContentHeadersValueLambda) => HttpContentHeadersValueLambda.ContentEncoding);
        }


        public static IObservable<System.Collections.Generic.ICollection<System.String>> get_ContentLanguage(this IObservable<System.Net.Http.Headers.HttpContentHeaders> HttpContentHeadersValue)
        {
            return Observable.Select(HttpContentHeadersValue, (HttpContentHeadersValueLambda) => HttpContentHeadersValueLambda.ContentLanguage);
        }


        public static IObservable<System.Nullable<System.Int64>> get_ContentLength(this IObservable<System.Net.Http.Headers.HttpContentHeaders> HttpContentHeadersValue)
        {
            return Observable.Select(HttpContentHeadersValue, (HttpContentHeadersValueLambda) => HttpContentHeadersValueLambda.ContentLength);
        }


        public static IObservable<System.Uri> get_ContentLocation(this IObservable<System.Net.Http.Headers.HttpContentHeaders> HttpContentHeadersValue)
        {
            return Observable.Select(HttpContentHeadersValue, (HttpContentHeadersValueLambda) => HttpContentHeadersValueLambda.ContentLocation);
        }


        public static IObservable<System.Byte[]> get_ContentMD5(this IObservable<System.Net.Http.Headers.HttpContentHeaders> HttpContentHeadersValue)
        {
            return Observable.Select(HttpContentHeadersValue, (HttpContentHeadersValueLambda) => HttpContentHeadersValueLambda.ContentMD5);
        }


        public static IObservable<System.Net.Http.Headers.ContentRangeHeaderValue> get_ContentRange(this IObservable<System.Net.Http.Headers.HttpContentHeaders> HttpContentHeadersValue)
        {
            return Observable.Select(HttpContentHeadersValue, (HttpContentHeadersValueLambda) => HttpContentHeadersValueLambda.ContentRange);
        }


        public static IObservable<System.Net.Http.Headers.MediaTypeHeaderValue> get_ContentType(this IObservable<System.Net.Http.Headers.HttpContentHeaders> HttpContentHeadersValue)
        {
            return Observable.Select(HttpContentHeadersValue, (HttpContentHeadersValueLambda) => HttpContentHeadersValueLambda.ContentType);
        }


        public static IObservable<System.Nullable<System.DateTimeOffset>> get_Expires(this IObservable<System.Net.Http.Headers.HttpContentHeaders> HttpContentHeadersValue)
        {
            return Observable.Select(HttpContentHeadersValue, (HttpContentHeadersValueLambda) => HttpContentHeadersValueLambda.Expires);
        }


        public static IObservable<System.Nullable<System.DateTimeOffset>> get_LastModified(this IObservable<System.Net.Http.Headers.HttpContentHeaders> HttpContentHeadersValue)
        {
            return Observable.Select(HttpContentHeadersValue, (HttpContentHeadersValueLambda) => HttpContentHeadersValueLambda.LastModified);
        }


        public static IObservable<System.Reactive.Unit> set_ContentDisposition(this IObservable<System.Net.Http.Headers.HttpContentHeaders> HttpContentHeadersValue, IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> value)
        {
            return ObservableExt.ZipExecute(HttpContentHeadersValue, value, (HttpContentHeadersValueLambda, valueLambda) => HttpContentHeadersValueLambda.ContentDisposition = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ContentLength(this IObservable<System.Net.Http.Headers.HttpContentHeaders> HttpContentHeadersValue, IObservable<System.Nullable<System.Int64>> value)
        {
            return ObservableExt.ZipExecute(HttpContentHeadersValue, value, (HttpContentHeadersValueLambda, valueLambda) => HttpContentHeadersValueLambda.ContentLength = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ContentLocation(this IObservable<System.Net.Http.Headers.HttpContentHeaders> HttpContentHeadersValue, IObservable<System.Uri> value)
        {
            return ObservableExt.ZipExecute(HttpContentHeadersValue, value, (HttpContentHeadersValueLambda, valueLambda) => HttpContentHeadersValueLambda.ContentLocation = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ContentMD5(this IObservable<System.Net.Http.Headers.HttpContentHeaders> HttpContentHeadersValue, IObservable<System.Byte[]> value)
        {
            return ObservableExt.ZipExecute(HttpContentHeadersValue, value, (HttpContentHeadersValueLambda, valueLambda) => HttpContentHeadersValueLambda.ContentMD5 = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ContentRange(this IObservable<System.Net.Http.Headers.HttpContentHeaders> HttpContentHeadersValue, IObservable<System.Net.Http.Headers.ContentRangeHeaderValue> value)
        {
            return ObservableExt.ZipExecute(HttpContentHeadersValue, value, (HttpContentHeadersValueLambda, valueLambda) => HttpContentHeadersValueLambda.ContentRange = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ContentType(this IObservable<System.Net.Http.Headers.HttpContentHeaders> HttpContentHeadersValue, IObservable<System.Net.Http.Headers.MediaTypeHeaderValue> value)
        {
            return ObservableExt.ZipExecute(HttpContentHeadersValue, value, (HttpContentHeadersValueLambda, valueLambda) => HttpContentHeadersValueLambda.ContentType = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Expires(this IObservable<System.Net.Http.Headers.HttpContentHeaders> HttpContentHeadersValue, IObservable<System.Nullable<System.DateTimeOffset>> value)
        {
            return ObservableExt.ZipExecute(HttpContentHeadersValue, value, (HttpContentHeadersValueLambda, valueLambda) => HttpContentHeadersValueLambda.Expires = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_LastModified(this IObservable<System.Net.Http.Headers.HttpContentHeaders> HttpContentHeadersValue, IObservable<System.Nullable<System.DateTimeOffset>> value)
        {
            return ObservableExt.ZipExecute(HttpContentHeadersValue, value, (HttpContentHeadersValueLambda, valueLambda) => HttpContentHeadersValueLambda.LastModified = valueLambda);
        }

    }
}