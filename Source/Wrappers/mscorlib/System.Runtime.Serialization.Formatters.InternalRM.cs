using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization.Formatters
{
public static class _InternalRM
{
    
public static IObservable<System.Reactive.Unit> InfoSoap(IObservable<System.Object[]> messages)
{
    return Observable.Do(messages, (messagesLambda) => System.Runtime.Serialization.Formatters.InternalRM.InfoSoap(messagesLambda)).ToUnit();
}


public static IObservable<System.Boolean> SoapCheckEnabled()
{
    return ObservableExt.Factory(() => System.Runtime.Serialization.Formatters.InternalRM.SoapCheckEnabled());
}

}
}