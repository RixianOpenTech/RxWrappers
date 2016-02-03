using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting
{
public static class _ObjRef
{
    
public static IObservable<System.Object> GetRealObject(this IObservable<System.Runtime.Remoting.ObjRef> ObjRefValue, IObservable<System.Runtime.Serialization.StreamingContext> context)
{
    return Observable.Zip(ObjRefValue, context, (ObjRefValueLambda, contextLambda) => ObjRefValueLambda.GetRealObject(contextLambda));
}


public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.Runtime.Remoting.ObjRef> ObjRefValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
{
    return ObservableExt.ZipExecute(ObjRefValue, info, context, (ObjRefValueLambda, infoLambda, contextLambda) => ObjRefValueLambda.GetObjectData(infoLambda, contextLambda));
}


public static IObservable<System.Boolean> IsFromThisProcess(this IObservable<System.Runtime.Remoting.ObjRef> ObjRefValue)
{
    return Observable.Select(ObjRefValue, (ObjRefValueLambda) => ObjRefValueLambda.IsFromThisProcess());
}


public static IObservable<System.Boolean> IsFromThisAppDomain(this IObservable<System.Runtime.Remoting.ObjRef> ObjRefValue)
{
    return Observable.Select(ObjRefValue, (ObjRefValueLambda) => ObjRefValueLambda.IsFromThisAppDomain());
}


public static IObservable<System.String> get_URI(this IObservable<System.Runtime.Remoting.ObjRef> ObjRefValue)
{
    return Observable.Select(ObjRefValue, (ObjRefValueLambda) => ObjRefValueLambda.URI);
}


public static IObservable<System.Runtime.Remoting.IRemotingTypeInfo> get_TypeInfo(this IObservable<System.Runtime.Remoting.ObjRef> ObjRefValue)
{
    return Observable.Select(ObjRefValue, (ObjRefValueLambda) => ObjRefValueLambda.TypeInfo);
}


public static IObservable<System.Runtime.Remoting.IEnvoyInfo> get_EnvoyInfo(this IObservable<System.Runtime.Remoting.ObjRef> ObjRefValue)
{
    return Observable.Select(ObjRefValue, (ObjRefValueLambda) => ObjRefValueLambda.EnvoyInfo);
}


public static IObservable<System.Runtime.Remoting.IChannelInfo> get_ChannelInfo(this IObservable<System.Runtime.Remoting.ObjRef> ObjRefValue)
{
    return Observable.Select(ObjRefValue, (ObjRefValueLambda) => ObjRefValueLambda.ChannelInfo);
}


public static IObservable<System.Reactive.Unit> set_URI(this IObservable<System.Runtime.Remoting.ObjRef> ObjRefValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(ObjRefValue, value, (ObjRefValueLambda, valueLambda) => ObjRefValueLambda.URI = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_TypeInfo(this IObservable<System.Runtime.Remoting.ObjRef> ObjRefValue, IObservable<System.Runtime.Remoting.IRemotingTypeInfo> value)
{
    return ObservableExt.ZipExecute(ObjRefValue, value, (ObjRefValueLambda, valueLambda) => ObjRefValueLambda.TypeInfo = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_EnvoyInfo(this IObservable<System.Runtime.Remoting.ObjRef> ObjRefValue, IObservable<System.Runtime.Remoting.IEnvoyInfo> value)
{
    return ObservableExt.ZipExecute(ObjRefValue, value, (ObjRefValueLambda, valueLambda) => ObjRefValueLambda.EnvoyInfo = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ChannelInfo(this IObservable<System.Runtime.Remoting.ObjRef> ObjRefValue, IObservable<System.Runtime.Remoting.IChannelInfo> value)
{
    return ObservableExt.ZipExecute(ObjRefValue, value, (ObjRefValueLambda, valueLambda) => ObjRefValueLambda.ChannelInfo = valueLambda);
}

}
}