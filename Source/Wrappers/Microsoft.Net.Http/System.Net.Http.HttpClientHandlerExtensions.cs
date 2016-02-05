using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http
{
    public static class __HttpClientHandlerExtensions
    {
        
        public static IObservable<System.Boolean> SupportsAllowAutoRedirect(IObservable<System.Net.Http.HttpClientHandler> handler)
        {
            return Observable.Select(handler, (handlerLambda) => System.Net.Http.HttpClientHandlerExtensions.SupportsAllowAutoRedirect(handlerLambda));
        }


        public static IObservable<System.Boolean> SupportsPreAuthenticate(IObservable<System.Net.Http.HttpClientHandler> handler)
        {
            return Observable.Select(handler, (handlerLambda) => System.Net.Http.HttpClientHandlerExtensions.SupportsPreAuthenticate(handlerLambda));
        }


        public static IObservable<System.Boolean> SupportsProtocolVersion(IObservable<System.Net.Http.HttpClientHandler> handler)
        {
            return Observable.Select(handler, (handlerLambda) => System.Net.Http.HttpClientHandlerExtensions.SupportsProtocolVersion(handlerLambda));
        }


        public static IObservable<System.Boolean> SupportsTransferEncodingChunked(IObservable<System.Net.Http.HttpClientHandler> handler)
        {
            return Observable.Select(handler, (handlerLambda) => System.Net.Http.HttpClientHandlerExtensions.SupportsTransferEncodingChunked(handlerLambda));
        }


        public static IObservable<System.Boolean> SupportsUseProxy(IObservable<System.Net.Http.HttpClientHandler> handler)
        {
            return Observable.Select(handler, (handlerLambda) => System.Net.Http.HttpClientHandlerExtensions.SupportsUseProxy(handlerLambda));
        }

    }
}