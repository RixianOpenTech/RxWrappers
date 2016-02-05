using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http
{
    public static class __DelegatingHandler
    {
        
        public static IObservable<System.Net.Http.HttpMessageHandler> get_InnerHandler(this IObservable<System.Net.Http.DelegatingHandler> DelegatingHandlerValue)
        {
            return Observable.Select(DelegatingHandlerValue, (DelegatingHandlerValueLambda) => DelegatingHandlerValueLambda.InnerHandler);
        }


        public static IObservable<System.Reactive.Unit> set_InnerHandler(this IObservable<System.Net.Http.DelegatingHandler> DelegatingHandlerValue, IObservable<System.Net.Http.HttpMessageHandler> value)
        {
            return ObservableExt.ZipExecute(DelegatingHandlerValue, value, (DelegatingHandlerValueLambda, valueLambda) => DelegatingHandlerValueLambda.InnerHandler = valueLambda);
        }

    }
}