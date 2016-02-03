using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Channels
{
public static class _SinkProviderData
{
    
public static IObservable<System.String> get_Name(this IObservable<System.Runtime.Remoting.Channels.SinkProviderData> SinkProviderDataValue)
{
    return Observable.Select(SinkProviderDataValue, (SinkProviderDataValueLambda) => SinkProviderDataValueLambda.Name);
}


public static IObservable<System.Collections.IDictionary> get_Properties(this IObservable<System.Runtime.Remoting.Channels.SinkProviderData> SinkProviderDataValue)
{
    return Observable.Select(SinkProviderDataValue, (SinkProviderDataValueLambda) => SinkProviderDataValueLambda.Properties);
}


public static IObservable<System.Collections.IList> get_Children(this IObservable<System.Runtime.Remoting.Channels.SinkProviderData> SinkProviderDataValue)
{
    return Observable.Select(SinkProviderDataValue, (SinkProviderDataValueLambda) => SinkProviderDataValueLambda.Children);
}

}
}