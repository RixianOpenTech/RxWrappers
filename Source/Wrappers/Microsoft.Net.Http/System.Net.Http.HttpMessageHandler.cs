using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http
{
    public static class __HttpMessageHandler
    {
        
        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Net.Http.HttpMessageHandler> HttpMessageHandlerValue)
        {
            return Observable.Do(HttpMessageHandlerValue, (HttpMessageHandlerValueLambda) => HttpMessageHandlerValueLambda.Dispose()).ToUnit();
        }

    }
}