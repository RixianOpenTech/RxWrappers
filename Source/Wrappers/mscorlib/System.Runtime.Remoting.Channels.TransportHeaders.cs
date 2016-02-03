using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
    public static class __TransportHeaders
    {
        
        public static IObservable<System.Collections.IEnumerator> GetEnumerator(this IObservable<System.Runtime.Remoting.Channels.TransportHeaders> TransportHeadersValue)
        {
            return Observable.Select(TransportHeadersValue, (TransportHeadersValueLambda) => TransportHeadersValueLambda.GetEnumerator());
        }


        public static IObservable<System.Object> get_Item(this IObservable<System.Runtime.Remoting.Channels.TransportHeaders> TransportHeadersValue, IObservable<System.Object> key)
        {
            return Observable.Zip(TransportHeadersValue, key, (TransportHeadersValueLambda, keyLambda) => TransportHeadersValueLambda[keyLambda]);
        }


        public static IObservable<System.Reactive.Unit> set_Item(this IObservable<System.Runtime.Remoting.Channels.TransportHeaders> TransportHeadersValue, IObservable<System.Object> key, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(TransportHeadersValue, key, value, (TransportHeadersValueLambda, keyLambda, valueLambda) => TransportHeadersValueLambda[keyLambda] = valueLambda);
        }

    }
}