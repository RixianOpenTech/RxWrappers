using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http
{
    public static class __HttpMessageInvoker
    {
        
        public static IObservable<System.Net.Http.HttpResponseMessage> SendAsync(this IObservable<System.Net.Http.HttpMessageInvoker> HttpMessageInvokerValue, IObservable<System.Net.Http.HttpRequestMessage> request, IObservable<System.Threading.CancellationToken> cancellationToken)
        {
            return Observable.Zip(HttpMessageInvokerValue, request, cancellationToken, (HttpMessageInvokerValueLambda, requestLambda, cancellationTokenLambda) => HttpMessageInvokerValueLambda.SendAsync(requestLambda, cancellationTokenLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Net.Http.HttpMessageInvoker> HttpMessageInvokerValue)
        {
            return Observable.Do(HttpMessageInvokerValue, (HttpMessageInvokerValueLambda) => HttpMessageInvokerValueLambda.Dispose()).ToUnit();
        }

    }
}