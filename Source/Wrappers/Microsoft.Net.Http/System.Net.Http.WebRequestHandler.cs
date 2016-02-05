using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http
{
    public static class __WebRequestHandler
    {
        
        public static IObservable<System.Net.Security.AuthenticationLevel> get_AuthenticationLevel(this IObservable<System.Net.Http.WebRequestHandler> WebRequestHandlerValue)
        {
            return Observable.Select(WebRequestHandlerValue, (WebRequestHandlerValueLambda) => WebRequestHandlerValueLambda.AuthenticationLevel);
        }


        public static IObservable<System.Security.Principal.TokenImpersonationLevel> get_ImpersonationLevel(this IObservable<System.Net.Http.WebRequestHandler> WebRequestHandlerValue)
        {
            return Observable.Select(WebRequestHandlerValue, (WebRequestHandlerValueLambda) => WebRequestHandlerValueLambda.ImpersonationLevel);
        }


        public static IObservable<System.Boolean> get_AllowPipelining(this IObservable<System.Net.Http.WebRequestHandler> WebRequestHandlerValue)
        {
            return Observable.Select(WebRequestHandlerValue, (WebRequestHandlerValueLambda) => WebRequestHandlerValueLambda.AllowPipelining);
        }


        public static IObservable<System.Boolean> get_UnsafeAuthenticatedConnectionSharing(this IObservable<System.Net.Http.WebRequestHandler> WebRequestHandlerValue)
        {
            return Observable.Select(WebRequestHandlerValue, (WebRequestHandlerValueLambda) => WebRequestHandlerValueLambda.UnsafeAuthenticatedConnectionSharing);
        }


        public static IObservable<System.Int32> get_MaxResponseHeadersLength(this IObservable<System.Net.Http.WebRequestHandler> WebRequestHandlerValue)
        {
            return Observable.Select(WebRequestHandlerValue, (WebRequestHandlerValueLambda) => WebRequestHandlerValueLambda.MaxResponseHeadersLength);
        }


        public static IObservable<System.Int32> get_ReadWriteTimeout(this IObservable<System.Net.Http.WebRequestHandler> WebRequestHandlerValue)
        {
            return Observable.Select(WebRequestHandlerValue, (WebRequestHandlerValueLambda) => WebRequestHandlerValueLambda.ReadWriteTimeout);
        }


        public static IObservable<System.Net.Cache.RequestCachePolicy> get_CachePolicy(this IObservable<System.Net.Http.WebRequestHandler> WebRequestHandlerValue)
        {
            return Observable.Select(WebRequestHandlerValue, (WebRequestHandlerValueLambda) => WebRequestHandlerValueLambda.CachePolicy);
        }


        public static IObservable<System.TimeSpan> get_ContinueTimeout(this IObservable<System.Net.Http.WebRequestHandler> WebRequestHandlerValue)
        {
            return Observable.Select(WebRequestHandlerValue, (WebRequestHandlerValueLambda) => WebRequestHandlerValueLambda.ContinueTimeout);
        }


        public static IObservable<System.Security.Cryptography.X509Certificates.X509CertificateCollection> get_ClientCertificates(this IObservable<System.Net.Http.WebRequestHandler> WebRequestHandlerValue)
        {
            return Observable.Select(WebRequestHandlerValue, (WebRequestHandlerValueLambda) => WebRequestHandlerValueLambda.ClientCertificates);
        }


        public static IObservable<System.Net.Security.RemoteCertificateValidationCallback> get_ServerCertificateValidationCallback(this IObservable<System.Net.Http.WebRequestHandler> WebRequestHandlerValue)
        {
            return Observable.Select(WebRequestHandlerValue, (WebRequestHandlerValueLambda) => WebRequestHandlerValueLambda.ServerCertificateValidationCallback);
        }


        public static IObservable<System.Reactive.Unit> set_AuthenticationLevel(this IObservable<System.Net.Http.WebRequestHandler> WebRequestHandlerValue, IObservable<System.Net.Security.AuthenticationLevel> value)
        {
            return ObservableExt.ZipExecute(WebRequestHandlerValue, value, (WebRequestHandlerValueLambda, valueLambda) => WebRequestHandlerValueLambda.AuthenticationLevel = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ImpersonationLevel(this IObservable<System.Net.Http.WebRequestHandler> WebRequestHandlerValue, IObservable<System.Security.Principal.TokenImpersonationLevel> value)
        {
            return ObservableExt.ZipExecute(WebRequestHandlerValue, value, (WebRequestHandlerValueLambda, valueLambda) => WebRequestHandlerValueLambda.ImpersonationLevel = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_AllowPipelining(this IObservable<System.Net.Http.WebRequestHandler> WebRequestHandlerValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(WebRequestHandlerValue, value, (WebRequestHandlerValueLambda, valueLambda) => WebRequestHandlerValueLambda.AllowPipelining = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_UnsafeAuthenticatedConnectionSharing(this IObservable<System.Net.Http.WebRequestHandler> WebRequestHandlerValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(WebRequestHandlerValue, value, (WebRequestHandlerValueLambda, valueLambda) => WebRequestHandlerValueLambda.UnsafeAuthenticatedConnectionSharing = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MaxResponseHeadersLength(this IObservable<System.Net.Http.WebRequestHandler> WebRequestHandlerValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(WebRequestHandlerValue, value, (WebRequestHandlerValueLambda, valueLambda) => WebRequestHandlerValueLambda.MaxResponseHeadersLength = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ReadWriteTimeout(this IObservable<System.Net.Http.WebRequestHandler> WebRequestHandlerValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(WebRequestHandlerValue, value, (WebRequestHandlerValueLambda, valueLambda) => WebRequestHandlerValueLambda.ReadWriteTimeout = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_CachePolicy(this IObservable<System.Net.Http.WebRequestHandler> WebRequestHandlerValue, IObservable<System.Net.Cache.RequestCachePolicy> value)
        {
            return ObservableExt.ZipExecute(WebRequestHandlerValue, value, (WebRequestHandlerValueLambda, valueLambda) => WebRequestHandlerValueLambda.CachePolicy = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ContinueTimeout(this IObservable<System.Net.Http.WebRequestHandler> WebRequestHandlerValue, IObservable<System.TimeSpan> value)
        {
            return ObservableExt.ZipExecute(WebRequestHandlerValue, value, (WebRequestHandlerValueLambda, valueLambda) => WebRequestHandlerValueLambda.ContinueTimeout = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ServerCertificateValidationCallback(this IObservable<System.Net.Http.WebRequestHandler> WebRequestHandlerValue, IObservable<System.Net.Security.RemoteCertificateValidationCallback> value)
        {
            return ObservableExt.ZipExecute(WebRequestHandlerValue, value, (WebRequestHandlerValueLambda, valueLambda) => WebRequestHandlerValueLambda.ServerCertificateValidationCallback = valueLambda);
        }

    }
}