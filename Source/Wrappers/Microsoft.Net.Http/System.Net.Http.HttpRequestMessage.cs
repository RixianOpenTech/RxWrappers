using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http
{
    public static class __HttpRequestMessage
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.HttpRequestMessage> HttpRequestMessageValue)
        {
            return Observable.Select(HttpRequestMessageValue, (HttpRequestMessageValueLambda) => HttpRequestMessageValueLambda.ToString());
        }


        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Net.Http.HttpRequestMessage> HttpRequestMessageValue)
        {
            return Observable.Do(HttpRequestMessageValue, (HttpRequestMessageValueLambda) => HttpRequestMessageValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Version> get_Version(this IObservable<System.Net.Http.HttpRequestMessage> HttpRequestMessageValue)
        {
            return Observable.Select(HttpRequestMessageValue, (HttpRequestMessageValueLambda) => HttpRequestMessageValueLambda.Version);
        }


        public static IObservable<System.Net.Http.HttpContent> get_Content(this IObservable<System.Net.Http.HttpRequestMessage> HttpRequestMessageValue)
        {
            return Observable.Select(HttpRequestMessageValue, (HttpRequestMessageValueLambda) => HttpRequestMessageValueLambda.Content);
        }


        public static IObservable<System.Net.Http.HttpMethod> get_Method(this IObservable<System.Net.Http.HttpRequestMessage> HttpRequestMessageValue)
        {
            return Observable.Select(HttpRequestMessageValue, (HttpRequestMessageValueLambda) => HttpRequestMessageValueLambda.Method);
        }


        public static IObservable<System.Uri> get_RequestUri(this IObservable<System.Net.Http.HttpRequestMessage> HttpRequestMessageValue)
        {
            return Observable.Select(HttpRequestMessageValue, (HttpRequestMessageValueLambda) => HttpRequestMessageValueLambda.RequestUri);
        }


        public static IObservable<System.Net.Http.Headers.HttpRequestHeaders> get_Headers(this IObservable<System.Net.Http.HttpRequestMessage> HttpRequestMessageValue)
        {
            return Observable.Select(HttpRequestMessageValue, (HttpRequestMessageValueLambda) => HttpRequestMessageValueLambda.Headers);
        }


        public static IObservable<System.Collections.Generic.IDictionary<System.String, System.Object>> get_Properties(this IObservable<System.Net.Http.HttpRequestMessage> HttpRequestMessageValue)
        {
            return Observable.Select(HttpRequestMessageValue, (HttpRequestMessageValueLambda) => HttpRequestMessageValueLambda.Properties);
        }


        public static IObservable<System.Reactive.Unit> set_Version(this IObservable<System.Net.Http.HttpRequestMessage> HttpRequestMessageValue, IObservable<System.Version> value)
        {
            return ObservableExt.ZipExecute(HttpRequestMessageValue, value, (HttpRequestMessageValueLambda, valueLambda) => HttpRequestMessageValueLambda.Version = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Content(this IObservable<System.Net.Http.HttpRequestMessage> HttpRequestMessageValue, IObservable<System.Net.Http.HttpContent> value)
        {
            return ObservableExt.ZipExecute(HttpRequestMessageValue, value, (HttpRequestMessageValueLambda, valueLambda) => HttpRequestMessageValueLambda.Content = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Method(this IObservable<System.Net.Http.HttpRequestMessage> HttpRequestMessageValue, IObservable<System.Net.Http.HttpMethod> value)
        {
            return ObservableExt.ZipExecute(HttpRequestMessageValue, value, (HttpRequestMessageValueLambda, valueLambda) => HttpRequestMessageValueLambda.Method = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_RequestUri(this IObservable<System.Net.Http.HttpRequestMessage> HttpRequestMessageValue, IObservable<System.Uri> value)
        {
            return ObservableExt.ZipExecute(HttpRequestMessageValue, value, (HttpRequestMessageValueLambda, valueLambda) => HttpRequestMessageValueLambda.RequestUri = valueLambda);
        }

    }
}