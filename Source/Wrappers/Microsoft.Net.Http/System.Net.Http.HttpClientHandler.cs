using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http
{
    public static class __HttpClientHandler
    {
        
        public static IObservable<System.Boolean> get_SupportsAutomaticDecompression(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue)
        {
            return Observable.Select(HttpClientHandlerValue, (HttpClientHandlerValueLambda) => HttpClientHandlerValueLambda.SupportsAutomaticDecompression);
        }


        public static IObservable<System.Boolean> get_SupportsProxy(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue)
        {
            return Observable.Select(HttpClientHandlerValue, (HttpClientHandlerValueLambda) => HttpClientHandlerValueLambda.SupportsProxy);
        }


        public static IObservable<System.Boolean> get_SupportsRedirectConfiguration(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue)
        {
            return Observable.Select(HttpClientHandlerValue, (HttpClientHandlerValueLambda) => HttpClientHandlerValueLambda.SupportsRedirectConfiguration);
        }


        public static IObservable<System.Boolean> get_UseCookies(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue)
        {
            return Observable.Select(HttpClientHandlerValue, (HttpClientHandlerValueLambda) => HttpClientHandlerValueLambda.UseCookies);
        }


        public static IObservable<System.Net.CookieContainer> get_CookieContainer(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue)
        {
            return Observable.Select(HttpClientHandlerValue, (HttpClientHandlerValueLambda) => HttpClientHandlerValueLambda.CookieContainer);
        }


        public static IObservable<System.Net.Http.ClientCertificateOption> get_ClientCertificateOptions(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue)
        {
            return Observable.Select(HttpClientHandlerValue, (HttpClientHandlerValueLambda) => HttpClientHandlerValueLambda.ClientCertificateOptions);
        }


        public static IObservable<System.Net.DecompressionMethods> get_AutomaticDecompression(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue)
        {
            return Observable.Select(HttpClientHandlerValue, (HttpClientHandlerValueLambda) => HttpClientHandlerValueLambda.AutomaticDecompression);
        }


        public static IObservable<System.Boolean> get_UseProxy(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue)
        {
            return Observable.Select(HttpClientHandlerValue, (HttpClientHandlerValueLambda) => HttpClientHandlerValueLambda.UseProxy);
        }


        public static IObservable<System.Net.IWebProxy> get_Proxy(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue)
        {
            return Observable.Select(HttpClientHandlerValue, (HttpClientHandlerValueLambda) => HttpClientHandlerValueLambda.Proxy);
        }


        public static IObservable<System.Boolean> get_PreAuthenticate(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue)
        {
            return Observable.Select(HttpClientHandlerValue, (HttpClientHandlerValueLambda) => HttpClientHandlerValueLambda.PreAuthenticate);
        }


        public static IObservable<System.Boolean> get_UseDefaultCredentials(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue)
        {
            return Observable.Select(HttpClientHandlerValue, (HttpClientHandlerValueLambda) => HttpClientHandlerValueLambda.UseDefaultCredentials);
        }


        public static IObservable<System.Net.ICredentials> get_Credentials(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue)
        {
            return Observable.Select(HttpClientHandlerValue, (HttpClientHandlerValueLambda) => HttpClientHandlerValueLambda.Credentials);
        }


        public static IObservable<System.Boolean> get_AllowAutoRedirect(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue)
        {
            return Observable.Select(HttpClientHandlerValue, (HttpClientHandlerValueLambda) => HttpClientHandlerValueLambda.AllowAutoRedirect);
        }


        public static IObservable<System.Int32> get_MaxAutomaticRedirections(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue)
        {
            return Observable.Select(HttpClientHandlerValue, (HttpClientHandlerValueLambda) => HttpClientHandlerValueLambda.MaxAutomaticRedirections);
        }


        public static IObservable<System.Int64> get_MaxRequestContentBufferSize(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue)
        {
            return Observable.Select(HttpClientHandlerValue, (HttpClientHandlerValueLambda) => HttpClientHandlerValueLambda.MaxRequestContentBufferSize);
        }


        public static IObservable<System.Reactive.Unit> set_UseCookies(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(HttpClientHandlerValue, value, (HttpClientHandlerValueLambda, valueLambda) => HttpClientHandlerValueLambda.UseCookies = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_CookieContainer(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue, IObservable<System.Net.CookieContainer> value)
        {
            return ObservableExt.ZipExecute(HttpClientHandlerValue, value, (HttpClientHandlerValueLambda, valueLambda) => HttpClientHandlerValueLambda.CookieContainer = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ClientCertificateOptions(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue, IObservable<System.Net.Http.ClientCertificateOption> value)
        {
            return ObservableExt.ZipExecute(HttpClientHandlerValue, value, (HttpClientHandlerValueLambda, valueLambda) => HttpClientHandlerValueLambda.ClientCertificateOptions = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_AutomaticDecompression(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue, IObservable<System.Net.DecompressionMethods> value)
        {
            return ObservableExt.ZipExecute(HttpClientHandlerValue, value, (HttpClientHandlerValueLambda, valueLambda) => HttpClientHandlerValueLambda.AutomaticDecompression = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_UseProxy(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(HttpClientHandlerValue, value, (HttpClientHandlerValueLambda, valueLambda) => HttpClientHandlerValueLambda.UseProxy = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Proxy(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue, IObservable<System.Net.IWebProxy> value)
        {
            return ObservableExt.ZipExecute(HttpClientHandlerValue, value, (HttpClientHandlerValueLambda, valueLambda) => HttpClientHandlerValueLambda.Proxy = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PreAuthenticate(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(HttpClientHandlerValue, value, (HttpClientHandlerValueLambda, valueLambda) => HttpClientHandlerValueLambda.PreAuthenticate = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_UseDefaultCredentials(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(HttpClientHandlerValue, value, (HttpClientHandlerValueLambda, valueLambda) => HttpClientHandlerValueLambda.UseDefaultCredentials = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Credentials(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue, IObservable<System.Net.ICredentials> value)
        {
            return ObservableExt.ZipExecute(HttpClientHandlerValue, value, (HttpClientHandlerValueLambda, valueLambda) => HttpClientHandlerValueLambda.Credentials = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_AllowAutoRedirect(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(HttpClientHandlerValue, value, (HttpClientHandlerValueLambda, valueLambda) => HttpClientHandlerValueLambda.AllowAutoRedirect = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MaxAutomaticRedirections(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(HttpClientHandlerValue, value, (HttpClientHandlerValueLambda, valueLambda) => HttpClientHandlerValueLambda.MaxAutomaticRedirections = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MaxRequestContentBufferSize(this IObservable<System.Net.Http.HttpClientHandler> HttpClientHandlerValue, IObservable<System.Int64> value)
        {
            return ObservableExt.ZipExecute(HttpClientHandlerValue, value, (HttpClientHandlerValueLambda, valueLambda) => HttpClientHandlerValueLambda.MaxRequestContentBufferSize = valueLambda);
        }

    }
}