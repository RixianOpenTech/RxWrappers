using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
public static class _ITransportHeaders
{
    
public static IObservable<System.Collections.IEnumerator> GetEnumerator(this IObservable<System.Runtime.Remoting.Channels.ITransportHeaders> ITransportHeadersValue)
{
    return Observable.Select(ITransportHeadersValue, (ITransportHeadersValueLambda) => ITransportHeadersValueLambda.GetEnumerator());
}


public static IObservable<System.Object> get_Item(this IObservable<System.Runtime.Remoting.Channels.ITransportHeaders> ITransportHeadersValue, IObservable<System.Object> key)
{
    return Observable.Zip(ITransportHeadersValue, key, (ITransportHeadersValueLambda, keyLambda) => ITransportHeadersValueLambda.Item);
}


public static IObservable<System.Reactive.Unit> set_Item(this IObservable<System.Runtime.Remoting.Channels.ITransportHeaders> ITransportHeadersValue, IObservable<System.Object> key, IObservable<System.Object> value)
{
    return ObservableExt.ZipExecute(ITransportHeadersValue, key, value, (ITransportHeadersValueLambda, keyLambda, valueLambda) => ITransportHeadersValueLambda.Item = valueLambda);
}

}
}