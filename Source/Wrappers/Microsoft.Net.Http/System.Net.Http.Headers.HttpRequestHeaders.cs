using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __HttpRequestHeaders
    {
        
        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.MediaTypeWithQualityHeaderValue>> get_Accept(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.Accept);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.StringWithQualityHeaderValue>> get_AcceptCharset(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.AcceptCharset);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.StringWithQualityHeaderValue>> get_AcceptEncoding(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.AcceptEncoding);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.StringWithQualityHeaderValue>> get_AcceptLanguage(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.AcceptLanguage);
        }


        public static IObservable<System.Net.Http.Headers.AuthenticationHeaderValue> get_Authorization(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.Authorization);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.NameValueWithParametersHeaderValue>> get_Expect(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.Expect);
        }


        public static IObservable<System.Nullable<System.Boolean>> get_ExpectContinue(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.ExpectContinue);
        }


        public static IObservable<System.String> get_From(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.From);
        }


        public static IObservable<System.String> get_Host(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.Host);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.EntityTagHeaderValue>> get_IfMatch(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.IfMatch);
        }


        public static IObservable<System.Nullable<System.DateTimeOffset>> get_IfModifiedSince(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.IfModifiedSince);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.EntityTagHeaderValue>> get_IfNoneMatch(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.IfNoneMatch);
        }


        public static IObservable<System.Net.Http.Headers.RangeConditionHeaderValue> get_IfRange(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.IfRange);
        }


        public static IObservable<System.Nullable<System.DateTimeOffset>> get_IfUnmodifiedSince(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.IfUnmodifiedSince);
        }


        public static IObservable<System.Nullable<System.Int32>> get_MaxForwards(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.MaxForwards);
        }


        public static IObservable<System.Net.Http.Headers.AuthenticationHeaderValue> get_ProxyAuthorization(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.ProxyAuthorization);
        }


        public static IObservable<System.Net.Http.Headers.RangeHeaderValue> get_Range(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.Range);
        }


        public static IObservable<System.Uri> get_Referrer(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.Referrer);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.TransferCodingWithQualityHeaderValue>> get_TE(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.TE);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ProductInfoHeaderValue>> get_UserAgent(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.UserAgent);
        }


        public static IObservable<System.Net.Http.Headers.CacheControlHeaderValue> get_CacheControl(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.CacheControl);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.String>> get_Connection(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.Connection);
        }


        public static IObservable<System.Nullable<System.Boolean>> get_ConnectionClose(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.ConnectionClose);
        }


        public static IObservable<System.Nullable<System.DateTimeOffset>> get_Date(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.Date);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.NameValueHeaderValue>> get_Pragma(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.Pragma);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.String>> get_Trailer(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.Trailer);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.TransferCodingHeaderValue>> get_TransferEncoding(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.TransferEncoding);
        }


        public static IObservable<System.Nullable<System.Boolean>> get_TransferEncodingChunked(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.TransferEncodingChunked);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ProductHeaderValue>> get_Upgrade(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.Upgrade);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ViaHeaderValue>> get_Via(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.Via);
        }


        public static IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.WarningHeaderValue>> get_Warning(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue)
        {
            return Observable.Select(HttpRequestHeadersValue, (HttpRequestHeadersValueLambda) => HttpRequestHeadersValueLambda.Warning);
        }


        public static IObservable<System.Reactive.Unit> set_Authorization(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue, IObservable<System.Net.Http.Headers.AuthenticationHeaderValue> value)
        {
            return ObservableExt.ZipExecute(HttpRequestHeadersValue, value, (HttpRequestHeadersValueLambda, valueLambda) => HttpRequestHeadersValueLambda.Authorization = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ExpectContinue(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue, IObservable<System.Nullable<System.Boolean>> value)
        {
            return ObservableExt.ZipExecute(HttpRequestHeadersValue, value, (HttpRequestHeadersValueLambda, valueLambda) => HttpRequestHeadersValueLambda.ExpectContinue = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_From(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(HttpRequestHeadersValue, value, (HttpRequestHeadersValueLambda, valueLambda) => HttpRequestHeadersValueLambda.From = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Host(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(HttpRequestHeadersValue, value, (HttpRequestHeadersValueLambda, valueLambda) => HttpRequestHeadersValueLambda.Host = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_IfModifiedSince(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue, IObservable<System.Nullable<System.DateTimeOffset>> value)
        {
            return ObservableExt.ZipExecute(HttpRequestHeadersValue, value, (HttpRequestHeadersValueLambda, valueLambda) => HttpRequestHeadersValueLambda.IfModifiedSince = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_IfRange(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue, IObservable<System.Net.Http.Headers.RangeConditionHeaderValue> value)
        {
            return ObservableExt.ZipExecute(HttpRequestHeadersValue, value, (HttpRequestHeadersValueLambda, valueLambda) => HttpRequestHeadersValueLambda.IfRange = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_IfUnmodifiedSince(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue, IObservable<System.Nullable<System.DateTimeOffset>> value)
        {
            return ObservableExt.ZipExecute(HttpRequestHeadersValue, value, (HttpRequestHeadersValueLambda, valueLambda) => HttpRequestHeadersValueLambda.IfUnmodifiedSince = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MaxForwards(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue, IObservable<System.Nullable<System.Int32>> value)
        {
            return ObservableExt.ZipExecute(HttpRequestHeadersValue, value, (HttpRequestHeadersValueLambda, valueLambda) => HttpRequestHeadersValueLambda.MaxForwards = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ProxyAuthorization(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue, IObservable<System.Net.Http.Headers.AuthenticationHeaderValue> value)
        {
            return ObservableExt.ZipExecute(HttpRequestHeadersValue, value, (HttpRequestHeadersValueLambda, valueLambda) => HttpRequestHeadersValueLambda.ProxyAuthorization = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Range(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue, IObservable<System.Net.Http.Headers.RangeHeaderValue> value)
        {
            return ObservableExt.ZipExecute(HttpRequestHeadersValue, value, (HttpRequestHeadersValueLambda, valueLambda) => HttpRequestHeadersValueLambda.Range = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Referrer(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue, IObservable<System.Uri> value)
        {
            return ObservableExt.ZipExecute(HttpRequestHeadersValue, value, (HttpRequestHeadersValueLambda, valueLambda) => HttpRequestHeadersValueLambda.Referrer = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_CacheControl(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue, IObservable<System.Net.Http.Headers.CacheControlHeaderValue> value)
        {
            return ObservableExt.ZipExecute(HttpRequestHeadersValue, value, (HttpRequestHeadersValueLambda, valueLambda) => HttpRequestHeadersValueLambda.CacheControl = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ConnectionClose(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue, IObservable<System.Nullable<System.Boolean>> value)
        {
            return ObservableExt.ZipExecute(HttpRequestHeadersValue, value, (HttpRequestHeadersValueLambda, valueLambda) => HttpRequestHeadersValueLambda.ConnectionClose = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Date(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue, IObservable<System.Nullable<System.DateTimeOffset>> value)
        {
            return ObservableExt.ZipExecute(HttpRequestHeadersValue, value, (HttpRequestHeadersValueLambda, valueLambda) => HttpRequestHeadersValueLambda.Date = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_TransferEncodingChunked(this IObservable<System.Net.Http.Headers.HttpRequestHeaders> HttpRequestHeadersValue, IObservable<System.Nullable<System.Boolean>> value)
        {
            return ObservableExt.ZipExecute(HttpRequestHeadersValue, value, (HttpRequestHeadersValueLambda, valueLambda) => HttpRequestHeadersValueLambda.TransferEncodingChunked = valueLambda);
        }

    }
}