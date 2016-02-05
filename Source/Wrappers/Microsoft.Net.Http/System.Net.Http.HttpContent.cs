using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http
{
    public static class __HttpContent
    {
        
        public static IObservable<System.String> ReadAsStringAsync(this IObservable<System.Net.Http.HttpContent> HttpContentValue)
        {
            return Observable.Select(HttpContentValue, (HttpContentValueLambda) => HttpContentValueLambda.ReadAsStringAsync().ToObservable()).Flatten();
        }


        public static IObservable<System.Byte[]> ReadAsByteArrayAsync(this IObservable<System.Net.Http.HttpContent> HttpContentValue)
        {
            return Observable.Select(HttpContentValue, (HttpContentValueLambda) => HttpContentValueLambda.ReadAsByteArrayAsync().ToObservable()).Flatten();
        }


        public static IObservable<System.IO.Stream> ReadAsStreamAsync(this IObservable<System.Net.Http.HttpContent> HttpContentValue)
        {
            return Observable.Select(HttpContentValue, (HttpContentValueLambda) => HttpContentValueLambda.ReadAsStreamAsync().ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> CopyToAsync(this IObservable<System.Net.Http.HttpContent> HttpContentValue, IObservable<System.IO.Stream> stream, IObservable<System.Net.TransportContext> context)
        {
            return Observable.Zip(HttpContentValue, stream, context, (HttpContentValueLambda, streamLambda, contextLambda) => HttpContentValueLambda.CopyToAsync(streamLambda, contextLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> CopyToAsync(this IObservable<System.Net.Http.HttpContent> HttpContentValue, IObservable<System.IO.Stream> stream)
        {
            return Observable.Zip(HttpContentValue, stream, (HttpContentValueLambda, streamLambda) => HttpContentValueLambda.CopyToAsync(streamLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> LoadIntoBufferAsync(this IObservable<System.Net.Http.HttpContent> HttpContentValue)
        {
            return Observable.Select(HttpContentValue, (HttpContentValueLambda) => HttpContentValueLambda.LoadIntoBufferAsync().ToObservable()).Flatten().ToUnit();
        }


        public static IObservable<System.Reactive.Unit> LoadIntoBufferAsync(this IObservable<System.Net.Http.HttpContent> HttpContentValue, IObservable<System.Int64> maxBufferSize)
        {
            return Observable.Zip(HttpContentValue, maxBufferSize, (HttpContentValueLambda, maxBufferSizeLambda) => HttpContentValueLambda.LoadIntoBufferAsync(maxBufferSizeLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Net.Http.HttpContent> HttpContentValue)
        {
            return Observable.Do(HttpContentValue, (HttpContentValueLambda) => HttpContentValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Net.Http.Headers.HttpContentHeaders> get_Headers(this IObservable<System.Net.Http.HttpContent> HttpContentValue)
        {
            return Observable.Select(HttpContentValue, (HttpContentValueLambda) => HttpContentValueLambda.Headers);
        }

    }
}