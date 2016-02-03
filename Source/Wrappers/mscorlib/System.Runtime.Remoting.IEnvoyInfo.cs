using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting
{
public static class _IEnvoyInfo
{
    
public static IObservable<System.Runtime.Remoting.Messaging.IMessageSink> get_EnvoySinks(this IObservable<System.Runtime.Remoting.IEnvoyInfo> IEnvoyInfoValue)
{
    return Observable.Select(IEnvoyInfoValue, (IEnvoyInfoValueLambda) => IEnvoyInfoValueLambda.EnvoySinks);
}


public static IObservable<System.Reactive.Unit> set_EnvoySinks(this IObservable<System.Runtime.Remoting.IEnvoyInfo> IEnvoyInfoValue, IObservable<System.Runtime.Remoting.Messaging.IMessageSink> value)
{
    return ObservableExt.ZipExecute(IEnvoyInfoValue, value, (IEnvoyInfoValueLambda, valueLambda) => IEnvoyInfoValueLambda.EnvoySinks = valueLambda);
}

}
}