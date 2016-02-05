using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http
{
    public static class __HttpResponseMessage
    {
        
        public static IObservable<System.Net.Http.HttpResponseMessage> EnsureSuccessStatusCode(this IObservable<System.Net.Http.HttpResponseMessage> HttpResponseMessageValue)
        {
            return Observable.Select(HttpResponseMessageValue, (HttpResponseMessageValueLambda) => HttpResponseMessageValueLambda.EnsureSuccessStatusCode());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.HttpResponseMessage> HttpResponseMessageValue)
        {
            return Observable.Select(HttpResponseMessageValue, (HttpResponseMessageValueLambda) => HttpResponseMessageValueLambda.ToString());
        }


        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Net.Http.HttpResponseMessage> HttpResponseMessageValue)
        {
            return Observable.Do(HttpResponseMessageValue, (HttpResponseMessageValueLambda) => HttpResponseMessageValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Version> get_Version(this IObservable<System.Net.Http.HttpResponseMessage> HttpResponseMessageValue)
        {
            return Observable.Select(HttpResponseMessageValue, (HttpResponseMessageValueLambda) => HttpResponseMessageValueLambda.Version);
        }


        public static IObservable<System.Net.Http.HttpContent> get_Content(this IObservable<System.Net.Http.HttpResponseMessage> HttpResponseMessageValue)
        {
            return Observable.Select(HttpResponseMessageValue, (HttpResponseMessageValueLambda) => HttpResponseMessageValueLambda.Content);
        }


        public static IObservable<System.Net.HttpStatusCode> get_StatusCode(this IObservable<System.Net.Http.HttpResponseMessage> HttpResponseMessageValue)
        {
            return Observable.Select(HttpResponseMessageValue, (HttpResponseMessageValueLambda) => HttpResponseMessageValueLambda.StatusCode);
        }


        public static IObservable<System.String> get_ReasonPhrase(this IObservable<System.Net.Http.HttpResponseMessage> HttpResponseMessageValue)
        {
            return Observable.Select(HttpResponseMessageValue, (HttpResponseMessageValueLambda) => HttpResponseMessageValueLambda.ReasonPhrase);
        }


        public static IObservable<System.Net.Http.Headers.HttpResponseHeaders> get_Headers(this IObservable<System.Net.Http.HttpResponseMessage> HttpResponseMessageValue)
        {
            return Observable.Select(HttpResponseMessageValue, (HttpResponseMessageValueLambda) => HttpResponseMessageValueLambda.Headers);
        }


        public static IObservable<System.Net.Http.HttpRequestMessage> get_RequestMessage(this IObservable<System.Net.Http.HttpResponseMessage> HttpResponseMessageValue)
        {
            return Observable.Select(HttpResponseMessageValue, (HttpResponseMessageValueLambda) => HttpResponseMessageValueLambda.RequestMessage);
        }


        public static IObservable<System.Boolean> get_IsSuccessStatusCode(this IObservable<System.Net.Http.HttpResponseMessage> HttpResponseMessageValue)
        {
            return Observable.Select(HttpResponseMessageValue, (HttpResponseMessageValueLambda) => HttpResponseMessageValueLambda.IsSuccessStatusCode);
        }


        public static IObservable<System.Reactive.Unit> set_Version(this IObservable<System.Net.Http.HttpResponseMessage> HttpResponseMessageValue, IObservable<System.Version> value)
        {
            return ObservableExt.ZipExecute(HttpResponseMessageValue, value, (HttpResponseMessageValueLambda, valueLambda) => HttpResponseMessageValueLambda.Version = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Content(this IObservable<System.Net.Http.HttpResponseMessage> HttpResponseMessageValue, IObservable<System.Net.Http.HttpContent> value)
        {
            return ObservableExt.ZipExecute(HttpResponseMessageValue, value, (HttpResponseMessageValueLambda, valueLambda) => HttpResponseMessageValueLambda.Content = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_StatusCode(this IObservable<System.Net.Http.HttpResponseMessage> HttpResponseMessageValue, IObservable<System.Net.HttpStatusCode> value)
        {
            return ObservableExt.ZipExecute(HttpResponseMessageValue, value, (HttpResponseMessageValueLambda, valueLambda) => HttpResponseMessageValueLambda.StatusCode = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ReasonPhrase(this IObservable<System.Net.Http.HttpResponseMessage> HttpResponseMessageValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(HttpResponseMessageValue, value, (HttpResponseMessageValueLambda, valueLambda) => HttpResponseMessageValueLambda.ReasonPhrase = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_RequestMessage(this IObservable<System.Net.Http.HttpResponseMessage> HttpResponseMessageValue, IObservable<System.Net.Http.HttpRequestMessage> value)
        {
            return ObservableExt.ZipExecute(HttpResponseMessageValue, value, (HttpResponseMessageValueLambda, valueLambda) => HttpResponseMessageValueLambda.RequestMessage = valueLambda);
        }

    }
}