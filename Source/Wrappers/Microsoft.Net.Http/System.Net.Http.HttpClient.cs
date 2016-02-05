using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http
{
    public static class __HttpClient
    {
        
        public static IObservable<System.String> GetStringAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.String> requestUri)
        {
            return Observable.Zip(HttpClientValue, requestUri, (HttpClientValueLambda, requestUriLambda) => HttpClientValueLambda.GetStringAsync(requestUriLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.String> GetStringAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.Uri> requestUri)
        {
            return Observable.Zip(HttpClientValue, requestUri, (HttpClientValueLambda, requestUriLambda) => HttpClientValueLambda.GetStringAsync(requestUriLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Byte[]> GetByteArrayAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.String> requestUri)
        {
            return Observable.Zip(HttpClientValue, requestUri, (HttpClientValueLambda, requestUriLambda) => HttpClientValueLambda.GetByteArrayAsync(requestUriLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Byte[]> GetByteArrayAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.Uri> requestUri)
        {
            return Observable.Zip(HttpClientValue, requestUri, (HttpClientValueLambda, requestUriLambda) => HttpClientValueLambda.GetByteArrayAsync(requestUriLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.IO.Stream> GetStreamAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.String> requestUri)
        {
            return Observable.Zip(HttpClientValue, requestUri, (HttpClientValueLambda, requestUriLambda) => HttpClientValueLambda.GetStreamAsync(requestUriLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.IO.Stream> GetStreamAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.Uri> requestUri)
        {
            return Observable.Zip(HttpClientValue, requestUri, (HttpClientValueLambda, requestUriLambda) => HttpClientValueLambda.GetStreamAsync(requestUriLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> GetAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.String> requestUri)
        {
            return Observable.Zip(HttpClientValue, requestUri, (HttpClientValueLambda, requestUriLambda) => HttpClientValueLambda.GetAsync(requestUriLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> GetAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.Uri> requestUri)
        {
            return Observable.Zip(HttpClientValue, requestUri, (HttpClientValueLambda, requestUriLambda) => HttpClientValueLambda.GetAsync(requestUriLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> GetAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.String> requestUri, IObservable<System.Net.Http.HttpCompletionOption> completionOption)
        {
            return Observable.Zip(HttpClientValue, requestUri, completionOption, (HttpClientValueLambda, requestUriLambda, completionOptionLambda) => HttpClientValueLambda.GetAsync(requestUriLambda, completionOptionLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> GetAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.Uri> requestUri, IObservable<System.Net.Http.HttpCompletionOption> completionOption)
        {
            return Observable.Zip(HttpClientValue, requestUri, completionOption, (HttpClientValueLambda, requestUriLambda, completionOptionLambda) => HttpClientValueLambda.GetAsync(requestUriLambda, completionOptionLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> GetAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.String> requestUri, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(HttpClientValue, requestUri, cancellationToken, (HttpClientValueLambda, requestUriLambda, cancellationTokenLambda) => HttpClientValueLambda.GetAsync(requestUriLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> GetAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.Uri> requestUri, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(HttpClientValue, requestUri, cancellationToken, (HttpClientValueLambda, requestUriLambda, cancellationTokenLambda) => HttpClientValueLambda.GetAsync(requestUriLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> GetAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.String> requestUri, IObservable<System.Net.Http.HttpCompletionOption> completionOption, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(HttpClientValue, requestUri, completionOption, cancellationToken, (HttpClientValueLambda, requestUriLambda, completionOptionLambda, cancellationTokenLambda) => HttpClientValueLambda.GetAsync(requestUriLambda, completionOptionLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> GetAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.Uri> requestUri, IObservable<System.Net.Http.HttpCompletionOption> completionOption, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(HttpClientValue, requestUri, completionOption, cancellationToken, (HttpClientValueLambda, requestUriLambda, completionOptionLambda, cancellationTokenLambda) => HttpClientValueLambda.GetAsync(requestUriLambda, completionOptionLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> PostAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.String> requestUri, IObservable<System.Net.Http.HttpContent> content)
        {
            return Observable.Zip(HttpClientValue, requestUri, content, (HttpClientValueLambda, requestUriLambda, contentLambda) => HttpClientValueLambda.PostAsync(requestUriLambda, contentLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> PostAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.Uri> requestUri, IObservable<System.Net.Http.HttpContent> content)
        {
            return Observable.Zip(HttpClientValue, requestUri, content, (HttpClientValueLambda, requestUriLambda, contentLambda) => HttpClientValueLambda.PostAsync(requestUriLambda, contentLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> PostAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.String> requestUri, IObservable<System.Net.Http.HttpContent> content, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(HttpClientValue, requestUri, content, cancellationToken, (HttpClientValueLambda, requestUriLambda, contentLambda, cancellationTokenLambda) => HttpClientValueLambda.PostAsync(requestUriLambda, contentLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> PostAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.Uri> requestUri, IObservable<System.Net.Http.HttpContent> content, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(HttpClientValue, requestUri, content, cancellationToken, (HttpClientValueLambda, requestUriLambda, contentLambda, cancellationTokenLambda) => HttpClientValueLambda.PostAsync(requestUriLambda, contentLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> PutAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.String> requestUri, IObservable<System.Net.Http.HttpContent> content)
        {
            return Observable.Zip(HttpClientValue, requestUri, content, (HttpClientValueLambda, requestUriLambda, contentLambda) => HttpClientValueLambda.PutAsync(requestUriLambda, contentLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> PutAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.Uri> requestUri, IObservable<System.Net.Http.HttpContent> content)
        {
            return Observable.Zip(HttpClientValue, requestUri, content, (HttpClientValueLambda, requestUriLambda, contentLambda) => HttpClientValueLambda.PutAsync(requestUriLambda, contentLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> PutAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.String> requestUri, IObservable<System.Net.Http.HttpContent> content, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(HttpClientValue, requestUri, content, cancellationToken, (HttpClientValueLambda, requestUriLambda, contentLambda, cancellationTokenLambda) => HttpClientValueLambda.PutAsync(requestUriLambda, contentLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> PutAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.Uri> requestUri, IObservable<System.Net.Http.HttpContent> content, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(HttpClientValue, requestUri, content, cancellationToken, (HttpClientValueLambda, requestUriLambda, contentLambda, cancellationTokenLambda) => HttpClientValueLambda.PutAsync(requestUriLambda, contentLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> DeleteAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.String> requestUri)
        {
            return Observable.Zip(HttpClientValue, requestUri, (HttpClientValueLambda, requestUriLambda) => HttpClientValueLambda.DeleteAsync(requestUriLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> DeleteAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.Uri> requestUri)
        {
            return Observable.Zip(HttpClientValue, requestUri, (HttpClientValueLambda, requestUriLambda) => HttpClientValueLambda.DeleteAsync(requestUriLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> DeleteAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.String> requestUri, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(HttpClientValue, requestUri, cancellationToken, (HttpClientValueLambda, requestUriLambda, cancellationTokenLambda) => HttpClientValueLambda.DeleteAsync(requestUriLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> DeleteAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.Uri> requestUri, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(HttpClientValue, requestUri, cancellationToken, (HttpClientValueLambda, requestUriLambda, cancellationTokenLambda) => HttpClientValueLambda.DeleteAsync(requestUriLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> SendAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.Net.Http.HttpRequestMessage> request)
        {
            return Observable.Zip(HttpClientValue, request, (HttpClientValueLambda, requestLambda) => HttpClientValueLambda.SendAsync(requestLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> SendAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.Net.Http.HttpRequestMessage> request, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(HttpClientValue, request, cancellationToken, (HttpClientValueLambda, requestLambda, cancellationTokenLambda) => HttpClientValueLambda.SendAsync(requestLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> SendAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.Net.Http.HttpRequestMessage> request, IObservable<System.Net.Http.HttpCompletionOption> completionOption)
        {
            return Observable.Zip(HttpClientValue, request, completionOption, (HttpClientValueLambda, requestLambda, completionOptionLambda) => HttpClientValueLambda.SendAsync(requestLambda, completionOptionLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Net.Http.HttpResponseMessage> SendAsync(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.Net.Http.HttpRequestMessage> request, IObservable<System.Net.Http.HttpCompletionOption> completionOption, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(HttpClientValue, request, completionOption, cancellationToken, (HttpClientValueLambda, requestLambda, completionOptionLambda, cancellationTokenLambda) => HttpClientValueLambda.SendAsync(requestLambda, completionOptionLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> CancelPendingRequests(this IObservable<System.Net.Http.HttpClient> HttpClientValue)
        {
            return Observable.Do(HttpClientValue, (HttpClientValueLambda) => HttpClientValueLambda.CancelPendingRequests()).ToUnit();
        }


        public static IObservable<System.Net.Http.Headers.HttpRequestHeaders> get_DefaultRequestHeaders(this IObservable<System.Net.Http.HttpClient> HttpClientValue)
        {
            return Observable.Select(HttpClientValue, (HttpClientValueLambda) => HttpClientValueLambda.DefaultRequestHeaders);
        }


        public static IObservable<System.Uri> get_BaseAddress(this IObservable<System.Net.Http.HttpClient> HttpClientValue)
        {
            return Observable.Select(HttpClientValue, (HttpClientValueLambda) => HttpClientValueLambda.BaseAddress);
        }


        public static IObservable<System.TimeSpan> get_Timeout(this IObservable<System.Net.Http.HttpClient> HttpClientValue)
        {
            return Observable.Select(HttpClientValue, (HttpClientValueLambda) => HttpClientValueLambda.Timeout);
        }


        public static IObservable<System.Int64> get_MaxResponseContentBufferSize(this IObservable<System.Net.Http.HttpClient> HttpClientValue)
        {
            return Observable.Select(HttpClientValue, (HttpClientValueLambda) => HttpClientValueLambda.MaxResponseContentBufferSize);
        }


        public static IObservable<System.Reactive.Unit> set_BaseAddress(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.Uri> value)
        {
            return ObservableExt.ZipExecute(HttpClientValue, value, (HttpClientValueLambda, valueLambda) => HttpClientValueLambda.BaseAddress = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Timeout(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.TimeSpan> value)
        {
            return ObservableExt.ZipExecute(HttpClientValue, value, (HttpClientValueLambda, valueLambda) => HttpClientValueLambda.Timeout = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MaxResponseContentBufferSize(this IObservable<System.Net.Http.HttpClient> HttpClientValue, IObservable<System.Int64> value)
        {
            return ObservableExt.ZipExecute(HttpClientValue, value, (HttpClientValueLambda, valueLambda) => HttpClientValueLambda.MaxResponseContentBufferSize = valueLambda);
        }

    }
}